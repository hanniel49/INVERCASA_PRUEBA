Imports CLSEDatos
Imports System.Data.OleDb
Imports System.Data.SqlClient

Public Class FrmGenerarVacaciones
    Dim strconexion As String = Main.StrConexion
    Dim ad As New ClsAccesoBD(strconexion)
    Dim diasV As String
    Dim IDVacaciones As Integer = 0
    Dim accion As Integer = 0

    'Sub New(ByVal acc As Integer)

    '    ' This call is required by the designer.
    '    InitializeComponent()
    '    accion = acc
    '    ' Add any initialization after the InitializeComponent() call.

    'End Sub
    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        flag = 1
        'Dim FrmE As FrmListadoEmpleados = New FrmListadoEmpleados()
        FrmListadoEmpleados.ShowDialog()
    End Sub

    Private Sub FrmGenerarVacaciones_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtDescripcion.Focus()
    End Sub

    Private Sub btnGenerar_Click(sender As Object, e As EventArgs) Handles btnGenerar.Click
        GeneraVacaciones()
    End Sub

    Sub GeneraVacaciones()
        Dim sql As String

        sql = "SELECT GENERA_VACACIONES(TO_DATE('" & dtpInicial.Text() & "','DD/MM/YYYY'),TO_DATE('" & dtpFinal.Text & "','DD/MM/YYYY')) as dias FROM DUAL"
        diasV = ad.ExecuteScalar(sql)

        txtVacacionesGeneradas.Text = diasV

    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        GuardarVacaciones()

    End Sub

    Sub GuardarVacaciones()
        Try
            Dim param(6) As OleDbParameter
            'Dim parametroOut(0) As OleDb.OleDbParameter

            Try

                param(0) = New OleDbParameter("@PID_VACIONES_G", IDVacaciones)
                param(1) = New OleDbParameter("@PDESCRIPCION", Trim(txtDescripcion.Text))
                param(2) = New OleDbParameter("@PFECHA_INICIAL", CDate(dtpInicial.Value))
                param(3) = New OleDbParameter("@PFECHA_FINAL", CDate(dtpFinal.Value))
                param(4) = New OleDbParameter("@PDIAS_GENERADOS", CStr(diasV))
                param(5) = New OleDbParameter("@PID_EMPLEADO", CDec(txtID.Text))
                param(6) = New OleDbParameter("@PACCION", AccionFreeDay)

                'parametroOut(0) = New OleDb.OleDbParameter("@PSALIDA", OleDb.OleDbType.Numeric)
                'parametroOut(0).Direction = ParameterDirection.Output

                Dim resultado As Integer = Val(ad.ejecutaSP("FGUZMAN.PKG_VACACIONES.PR_REG_VACACIONES_GENERADAS", param))

                MsgBox("Se generaron " & diasV & " dias de vacaciones para el empleado " & txtEmpleado.Text)

                limpiar()

            Catch ex As Exception
                MsgBox("Ocurrio un error al intentar guardar el regístro " & ex.Message)
            End Try

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub limpiar()
        txtID.Text = ""
        txtDescripcion.Text = ""
        txtEmpleado.Text = ""
        txtVacacionesGeneradas.Text = ""
    End Sub
End Class