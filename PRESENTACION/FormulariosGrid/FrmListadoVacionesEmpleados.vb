Imports System.Data.OleDb
Imports CLSEDatos
Public Class FrmListadoVacionesEmpleados

    Dim strconexion As String = Main.StrConexion
    Dim ad As New ClsAccesoBD(strconexion)
    Private Sub FrmListadoVacionesEmpleados_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ActualizarGrid()
    End Sub

    Private Sub ActualizarGrid()
        Try

            Dim strSQL As String = "SELECT TVG.ID_VACACIONES,TE.NOMBRE, TE.DNI, TE.FECHA_INGRESO, TVG.DIAS_GENERADOS,TVG.DIAS_TOMADOS,TVG.DIAS_SALDO,TE.SALARIO_BASE FROM FGUZMAN.TBL_VACACIONES_GENERADAS TVG INNER JOIN 
                                    FGUZMAN.TBL_EMPLEADOS TE ON TVG.ID_EMPLEADO = TE.ID_EMPLEADO"

            Dim BSEMPLEADO As New BindingSource
            BSEMPLEADO.DataSource = ad.GetDTable(strSQL)

            Me.DGEmpleados.DataSource = BSEMPLEADO

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        Try
            If DGEmpleados.SelectedRows.Count > 0 Then
                Dim Frmv As FrmSolicitarVacaciones = New FrmSolicitarVacaciones()
                Frmv.txtID.Text = DGEmpleados.CurrentRow.Cells(0).Value.ToString()
                Frmv.txtEmpleado.Text = DGEmpleados.CurrentRow.Cells(1).Value.ToString()
                Frmv.txtDiasDisponibles.Text = DGEmpleados.CurrentRow.Cells(6).Value.ToString()

                Frmv.txtDescripcion.Focus()
                Frmv.ShowDialog()


                DGEmpleados.ClearSelection()
            Else
                MessageBox.Show("Por Favor Seleccione la Fila a Editar.", "Sistema de Ventas.", MessageBoxButtons.OK, MessageBoxIcon.[Error])
            End If

            ActualizarGrid()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class