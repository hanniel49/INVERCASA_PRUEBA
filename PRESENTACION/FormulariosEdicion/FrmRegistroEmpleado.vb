Imports CLSEDatos
Imports System.Data.OleDb
Imports System.Data.SqlClient
Public Class FrmRegistroEmpleado
    Dim ad As New ClsAccesoBD(Main.StrConexion)
    Dim id As Integer
    Dim accion As Integer

    Sub New(ByVal acc As Integer)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        accion = acc
    End Sub


    Private Sub FrmRegistroEmpleado_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtNombre.Focus()
        If accion = 0 Then
            id = 0
        Else
            id = txtId.Text
        End If
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        If txtNombre.Text = "" Or txtIdentificacion.Text = "" Or txtSalarioBase.Text = "" Or txtDireccion.Text = "" Then

            MsgBox("Debe llenar todos los campos")

            Exit Sub
        End If
        GuardarSolicitud()
    End Sub

    Private Sub GuardarSolicitud()
        Try
            Dim param(7) As OleDbParameter
            'Dim parametroOut(0) As OleDb.OleDbParameter

            Try

                param(0) = New OleDbParameter("@PID_EMPLEADO", id)
                param(1) = New OleDbParameter("@PNOMBRE", Trim(txtNombre.Text))
                param(2) = New OleDbParameter("@PTIPO_DNI", cbTipoDni.SelectedItem)
                param(3) = New OleDbParameter("@PDNI", CStr(Trim(txtIdentificacion.Text)))
                param(4) = New OleDbParameter("@PFECHA_INGRESO", CDate(dtpFechaIngreso.Value))
                param(5) = New OleDbParameter("@PSALARIO_BASE", CDec(txtSalarioBase.Text))
                param(6) = New OleDbParameter("@PDIRECCION", Trim(txtDireccion.Text))
                param(7) = New OleDbParameter("@PACCION", accion)

                'parametroOut(0) = New OleDb.OleDbParameter("@PSALIDA", OleDb.OleDbType.Numeric)
                'parametroOut(0).Direction = ParameterDirection.Output

                Dim resultado As Integer = Val(ad.ejecutaSP("FGUZMAN.PKG_VACACIONES.PR_REG_EMPLEADO", param))

                MsgBox("Registro ingresado con exito!!")

                limpiar()

            Catch ex As Exception
                            MsgBox("Ocurrio un error al intentar guardar el regístro " & ex.Message)
                        End Try

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub limpiar()
        txtId.Text = ""
        txtNombre.Text = ""
        txtIdentificacion.Text = ""
        txtSalarioBase.Text = ""
        txtDireccion.Text = ""
    End Sub
End Class