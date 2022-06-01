Imports CrystalDecisions.Shared
Imports CrystalDecisions.CrystalReports.Engine

Public Class FrmRptVacaciones

    Private MyPath As String
    Private informe As New ReportDocument
    Public parametro1 As String
    Public parametro2 As String
    Public nombreReporte As String

    Private Sub MostrarReporte()

        Dim DataBaseName As String = Main.Basedatos
        Dim UserID As String = Main.Usuario
        Dim Password As String = Main.password
        Dim ServerName As String = Main.Basedatos

        Dim IntegratedSecurity As Boolean = False

        Try
            Dim miConexionInfo As ConnectionInfo = New ConnectionInfo()

            miConexionInfo.UserID = UserID
            miConexionInfo.Password = Password

            miConexionInfo.ServerName = ServerName
            'miConexionInfo.DatabaseName = String.Empty
            miConexionInfo.IntegratedSecurity = IntegratedSecurity

            If informe.IsLoaded Then
                informe.Close()
                informe.Dispose()
            End If

            informe = New ReportDocument()
            Dim reportPath As String = Application.StartupPath & "\Reportes\" & nombreReporte
            informe.Load(reportPath)

            Loguearse(miConexionInfo, informe)

            With Me.CrystalReportViewer1
                .Zoom(75)
            End With

            Me.CrystalReportViewer1.Refresh()

            Select Case nombreReporte

                Case "rptVacaciones.rpt"
                    'informe.SetParameterValue("ID_EMPLEADO", CInt(parametro1))

            End Select
            Me.CrystalReportViewer1.ReportSource = informe
        Catch ex As Exception
            Windows.Forms.Cursor.Current = Cursors.Default
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Try
            Exit Sub

        End Try
    End Sub

    Public Sub Loguearse(ByVal myConnectionInfo As ConnectionInfo, ByVal myReportDocument As ReportDocument)
        Dim myTables As Tables = myReportDocument.Database.Tables
        For Each myTable As CrystalDecisions.CrystalReports.Engine.Table In myTables
            Dim myTableLogonInfo As TableLogOnInfo = myTable.LogOnInfo
            myTableLogonInfo.ConnectionInfo = myConnectionInfo
            myTable.ApplyLogOnInfo(myTableLogonInfo)
        Next
    End Sub
    Private Sub FrmRptVacaciones_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MostrarReporte()

    End Sub
End Class