Imports CLSEDatos
Imports System.Data.OleDb
Imports System.Data.SqlClient
Public Class FrmSolicitarVacaciones
    Dim strconexion As String = Main.StrConexion
    Dim ad As New ClsAccesoBD(strconexion)
    Public IdDiasGenerados As Integer
    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        SolicitarVacaciones()
    End Sub

    Private Sub FrmSolicitarVacaciones_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Sub SolicitarVacaciones()
        Try
            Dim diasSolicitados As Integer
            'Dim FechaInicio As New DateTime(dtpInicial)
            'Dim FechaFin As New DateTime(2015, 10, 31)

            diasSolicitados = DateDiff(DateInterval.Day, dtpInicial.Value, dtpFinal.Value) + 1

            If diasSolicitados > CDbl(txtDiasDisponibles.Text) Then
                MsgBox("Los dias solicitados superan a los disponibles, Dispone de " & txtDiasDisponibles.Text & " dias")
                Exit Sub
            End If

            If txtDescripcion.Text = "" Or cbMotivo.SelectedIndex < 0 Or cbMotivo.Text = "" Then
                MsgBox("Los campos no pueden quedar vacios")
            End If


            Dim param(5) As OleDbParameter
            'Dim parametroOut(0) As OleDb.OleDbParameter

            Try

                param(0) = New OleDbParameter("@PID_VACIONES_G", CInt(txtID.Text))
                param(1) = New OleDbParameter("@PMOTIVO", CStr(cbMotivo.SelectedItem))
                param(2) = New OleDbParameter("@PFECHA_INICIAL", CDate(dtpInicial.Value))
                param(3) = New OleDbParameter("@PFECHA_FINAL", CDate(dtpFinal.Value))
                param(4) = New OleDbParameter("@PDIAS_SOLICITADOS", CInt(diasSolicitados))
                param(5) = New OleDbParameter("@PACCION", AccionFreeDay)

                'parametroOut(0) = New OleDb.OleDbParameter("@PSALIDA", OleDb.OleDbType.Numeric)
                'parametroOut(0).Direction = ParameterDirection.Output

                Dim resultado As Integer = Val(ad.ejecutaSP("FGUZMAN.PKG_VACACIONES.PR_REG_VACACIONES_SOLICITADAS", param))

                MsgBox("Solicitud de vacaciones creada exitosamente para el colaborador" & txtEmpleado.Text)

                btnGuardar.Enabled = False

            Catch ex As Exception
                MsgBox("Ocurrio un error al intentar guardar la solicitud " & ex.Message)
            End Try

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
End Class