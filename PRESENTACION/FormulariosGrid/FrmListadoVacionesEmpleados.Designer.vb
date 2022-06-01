<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmListadoVacionesEmpleados
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.btnAgregar = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DGEmpleados = New System.Windows.Forms.DataGridView()
        Me.ID_VACACIONES = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NOMBRE = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DNI = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FECHA_INGRESO = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DIAS_GENERADOS = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DIAS_TOMADOS = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DIAS_SALDO = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SALARIO_BASE = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.DGEmpleados, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnAgregar
        '
        Me.btnAgregar.Location = New System.Drawing.Point(323, 383)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(75, 25)
        Me.btnAgregar.TabIndex = 12
        Me.btnAgregar.Text = "Solicitar dias"
        Me.btnAgregar.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(259, 10)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(230, 24)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "Vacaciones Empleados"
        '
        'DGEmpleados
        '
        Me.DGEmpleados.AllowUserToAddRows = False
        Me.DGEmpleados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGEmpleados.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ID_VACACIONES, Me.NOMBRE, Me.DNI, Me.FECHA_INGRESO, Me.DIAS_GENERADOS, Me.DIAS_TOMADOS, Me.DIAS_SALDO, Me.SALARIO_BASE})
        Me.DGEmpleados.Location = New System.Drawing.Point(22, 47)
        Me.DGEmpleados.Name = "DGEmpleados"
        Me.DGEmpleados.ReadOnly = True
        Me.DGEmpleados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGEmpleados.Size = New System.Drawing.Size(730, 330)
        Me.DGEmpleados.TabIndex = 10
        '
        'ID_VACACIONES
        '
        Me.ID_VACACIONES.DataPropertyName = "ID_VACACIONES"
        Me.ID_VACACIONES.HeaderText = "ID"
        Me.ID_VACACIONES.Name = "ID_VACACIONES"
        Me.ID_VACACIONES.ReadOnly = True
        '
        'NOMBRE
        '
        Me.NOMBRE.DataPropertyName = "NOMBRE"
        Me.NOMBRE.HeaderText = "NOMBRE"
        Me.NOMBRE.Name = "NOMBRE"
        Me.NOMBRE.ReadOnly = True
        '
        'DNI
        '
        Me.DNI.DataPropertyName = "DNI"
        Me.DNI.HeaderText = "DNI"
        Me.DNI.Name = "DNI"
        Me.DNI.ReadOnly = True
        '
        'FECHA_INGRESO
        '
        Me.FECHA_INGRESO.DataPropertyName = "FECHA_INGRESO"
        Me.FECHA_INGRESO.HeaderText = "FECHA INGRESO"
        Me.FECHA_INGRESO.Name = "FECHA_INGRESO"
        Me.FECHA_INGRESO.ReadOnly = True
        '
        'DIAS_GENERADOS
        '
        Me.DIAS_GENERADOS.DataPropertyName = "DIAS_GENERADOS"
        Me.DIAS_GENERADOS.HeaderText = "DIAS GENERADOS"
        Me.DIAS_GENERADOS.Name = "DIAS_GENERADOS"
        Me.DIAS_GENERADOS.ReadOnly = True
        '
        'DIAS_TOMADOS
        '
        Me.DIAS_TOMADOS.DataPropertyName = "DIAS_TOMADOS"
        Me.DIAS_TOMADOS.HeaderText = "DIAS TOMADOS"
        Me.DIAS_TOMADOS.Name = "DIAS_TOMADOS"
        Me.DIAS_TOMADOS.ReadOnly = True
        '
        'DIAS_SALDO
        '
        Me.DIAS_SALDO.DataPropertyName = "DIAS_SALDO"
        Me.DIAS_SALDO.HeaderText = "DIAS DISPONIBLES"
        Me.DIAS_SALDO.Name = "DIAS_SALDO"
        Me.DIAS_SALDO.ReadOnly = True
        '
        'SALARIO_BASE
        '
        Me.SALARIO_BASE.DataPropertyName = "SALARIO_BASE"
        Me.SALARIO_BASE.HeaderText = "SALARIO BASE"
        Me.SALARIO_BASE.Name = "SALARIO_BASE"
        Me.SALARIO_BASE.ReadOnly = True
        '
        'FrmListadoVacionesEmpleados
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(764, 438)
        Me.Controls.Add(Me.btnAgregar)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DGEmpleados)
        Me.Name = "FrmListadoVacionesEmpleados"
        Me.Text = "FrmListadoVacionesEmpleados"
        CType(Me.DGEmpleados, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnAgregar As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents DGEmpleados As DataGridView
    Friend WithEvents ID_VACACIONES As DataGridViewTextBoxColumn
    Friend WithEvents NOMBRE As DataGridViewTextBoxColumn
    Friend WithEvents DNI As DataGridViewTextBoxColumn
    Friend WithEvents FECHA_INGRESO As DataGridViewTextBoxColumn
    Friend WithEvents DIAS_GENERADOS As DataGridViewTextBoxColumn
    Friend WithEvents DIAS_TOMADOS As DataGridViewTextBoxColumn
    Friend WithEvents DIAS_SALDO As DataGridViewTextBoxColumn
    Friend WithEvents SALARIO_BASE As DataGridViewTextBoxColumn
End Class
