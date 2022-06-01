Imports System.Data.OleDb
Imports CLSEDatos
Public Class FrmListadoEmpleados
    Dim strconexion As String = Main.StrConexion
    Dim ad As New ClsAccesoBD(strconexion)
    Private Sub FrmListadoEmpleados_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If flag = 1 Then
            btnAgregar.Visible = False
            btnEditar.Visible = False
            btnEliminar.Visible = False
        End If
        ActualizarGrid()
    End Sub

    Private Sub ActualizarGrid()
        Try

            Dim strSQL As String = "SELECT * FROM FGUZMAN.TBL_EMPLEADOS"

            Dim BSEMPLEADO As New BindingSource
            BSEMPLEADO.DataSource = ad.GetDTable(strSQL)

            Me.DGEmpleados.DataSource = BSEMPLEADO

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        Dim FrmE As FrmRegistroEmpleado = New FrmRegistroEmpleado(0)
        FrmE.ShowDialog()
    End Sub

    Private Sub btnEditar_Click(sender As Object, e As EventArgs) Handles btnEditar.Click
        Try
            If DGEmpleados.SelectedRows.Count > 0 Then
                Dim FrmE As FrmRegistroEmpleado = New FrmRegistroEmpleado(1)
                FrmE.txtId.Text = DGEmpleados.CurrentRow.Cells(0).Value.ToString()
                FrmE.txtNombre.Text = DGEmpleados.CurrentRow.Cells(1).Value.ToString()
                FrmE.cbTipoDni.Text = DGEmpleados.CurrentRow.Cells(2).Value.ToString()
                FrmE.txtIdentificacion.Text = DGEmpleados.CurrentRow.Cells(3).Value.ToString()
                FrmE.dtpFechaIngreso.Text = DGEmpleados.CurrentRow.Cells(4).Value.ToString()
                FrmE.txtSalarioBase.Text = DGEmpleados.CurrentRow.Cells(5).Value.ToString()
                FrmE.txtDireccion.Text = DGEmpleados.CurrentRow.Cells(6).Value.ToString()
                FrmE.txtNombre.Focus()
                FrmE.ShowDialog()


                DGEmpleados.ClearSelection()
            Else
                MessageBox.Show("Por Favor Seleccione la Fila a Editar.", "Sistema de Ventas.", MessageBoxButtons.OK, MessageBoxIcon.[Error])
            End If

            ActualizarGrid()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        Try
            Dim id As Integer = DGEmpleados.CurrentRow.Cells(0).Value.ToString()
            Dim param(7) As OleDbParameter

            Try

                param(0) = New OleDbParameter("@PID_EMPLEADO", id)
                param(1) = New OleDbParameter("@PNOMBRE", "")
                param(2) = New OleDbParameter("@PTIPO_DNI", "")
                param(3) = New OleDbParameter("@PDNI", "")
                param(4) = New OleDbParameter("@PFECHA_INGRESO", "")
                param(5) = New OleDbParameter("@PSALARIO_BASE", "")
                param(6) = New OleDbParameter("@PDIRECCION", "")
                param(7) = New OleDbParameter("@PACCION", 2)

                'parametroOut(0) = New OleDb.OleDbParameter("@PSALIDA", OleDb.OleDbType.Numeric)
                'parametroOut(0).Direction = ParameterDirection.Output

                Dim resultado As Integer = Val(ad.ejecutaSP("FGUZMAN.PKG_VACACIONES.PR_REG_EMPLEADO", param))
                MsgBox("Registro eliminado correctamente!!")
                ActualizarGrid()
            Catch ex As Exception
                MsgBox("Ocurrio un error al intentar guardar el regístro " & ex.Message)
            End Try

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub DGEmpleados_DoubleClick(sender As Object, e As EventArgs) Handles DGEmpleados.DoubleClick
        Try
            Dim id As Integer
            Dim Nombre As String
            If flag = 1 Then
                id = DGEmpleados.CurrentRow.Cells.Item(0).Value
                Nombre = DGEmpleados.CurrentRow.Cells.Item(1).Value

                FrmGenerarVacaciones.txtID.Text = id
                FrmGenerarVacaciones.txtEmpleado.Text = Nombre
                Dispose()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub
End Class