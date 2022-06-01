<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MDIPrincipal
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MDIPrincipal))
        Me.ToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.MSOpciones = New System.Windows.Forms.MenuStrip()
        Me.tsmCatalogo = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsiEmpleados = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmVacaciones = New System.Windows.Forms.ToolStripMenuItem()
        Me.MSOpciones.SuspendLayout()
        Me.SuspendLayout()
        '
        'MSOpciones
        '
        Me.MSOpciones.BackColor = System.Drawing.Color.FromArgb(CType(CType(101, Byte), Integer), CType(CType(156, Byte), Integer), CType(CType(127, Byte), Integer))
        Me.MSOpciones.Dock = System.Windows.Forms.DockStyle.Left
        Me.MSOpciones.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsmCatalogo, Me.tsmVacaciones})
        Me.MSOpciones.Location = New System.Drawing.Point(0, 0)
        Me.MSOpciones.Name = "MSOpciones"
        Me.MSOpciones.Size = New System.Drawing.Size(138, 539)
        Me.MSOpciones.TabIndex = 10
        Me.MSOpciones.Text = "MenuStrip1"
        '
        'tsmCatalogo
        '
        Me.tsmCatalogo.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsiEmpleados})
        Me.tsmCatalogo.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tsmCatalogo.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.tsmCatalogo.Image = CType(resources.GetObject("tsmCatalogo.Image"), System.Drawing.Image)
        Me.tsmCatalogo.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.tsmCatalogo.Name = "tsmCatalogo"
        Me.tsmCatalogo.Size = New System.Drawing.Size(125, 36)
        Me.tsmCatalogo.Text = "CATALOGOS"
        '
        'tsiEmpleados
        '
        Me.tsiEmpleados.Image = CType(resources.GetObject("tsiEmpleados.Image"), System.Drawing.Image)
        Me.tsiEmpleados.Name = "tsiEmpleados"
        Me.tsiEmpleados.Size = New System.Drawing.Size(180, 22)
        Me.tsiEmpleados.Text = "Empleados"
        '
        'tsmVacaciones
        '
        Me.tsmVacaciones.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tsmVacaciones.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.tsmVacaciones.Image = CType(resources.GetObject("tsmVacaciones.Image"), System.Drawing.Image)
        Me.tsmVacaciones.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.tsmVacaciones.Name = "tsmVacaciones"
        Me.tsmVacaciones.Size = New System.Drawing.Size(125, 36)
        Me.tsmVacaciones.Text = "VACACIONES"
        '
        'MDIPrincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(795, 539)
        Me.Controls.Add(Me.MSOpciones)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.IsMdiContainer = True
        Me.Name = "MDIPrincipal"
        Me.Text = "MDIPrincipal"
        Me.MSOpciones.ResumeLayout(False)
        Me.MSOpciones.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolTip As System.Windows.Forms.ToolTip
    Friend WithEvents MSOpciones As MenuStrip
    Friend WithEvents tsmCatalogo As ToolStripMenuItem
    Friend WithEvents tsiEmpleados As ToolStripMenuItem
    Friend WithEvents tsmVacaciones As ToolStripMenuItem
End Class
