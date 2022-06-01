Imports System.Windows.Forms

Public Class MDIPrincipal
    Dim TestConexion As New Data.OleDb.OleDbConnection

    Private Sub ShowNewForm(ByVal sender As Object, ByVal e As EventArgs)
        ' Create a new instance of the child form.
        Dim ChildForm As New System.Windows.Forms.Form

        ' Make it a child of this MDI form before showing it.
        ChildForm.MdiParent = Me

        m_ChildFormNumber += 1
        ChildForm.Text = "Window " & m_ChildFormNumber

        ChildForm.Show()
    End Sub

    Private Sub ExitToolsStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Me.Close()
    End Sub

    Private Sub CutToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        ' Use My.Computer.Clipboard to insert the selected text or images into the clipboard
    End Sub

    Private Sub CopyToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        ' Use My.Computer.Clipboard to insert the selected text or images into the clipboard
    End Sub

    Private Sub PasteToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        'Use My.Computer.Clipboard.GetText() or My.Computer.Clipboard.GetData to retrieve information from the clipboard.
    End Sub

    Private Sub CascadeToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Me.LayoutMdi(MdiLayout.Cascade)
    End Sub

    Private Sub TileVerticalToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Me.LayoutMdi(MdiLayout.TileVertical)
    End Sub

    Private Sub TileHorizontalToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Me.LayoutMdi(MdiLayout.TileHorizontal)
    End Sub

    Private Sub ArrangeIconsToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Me.LayoutMdi(MdiLayout.ArrangeIcons)
    End Sub

    Private Sub CloseAllToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        ' Close all child forms of the parent.
        For Each ChildForm As Form In Me.MdiChildren
            ChildForm.Close()
        Next
    End Sub

    Private m_ChildFormNumber As Integer

    Private Sub MDIPrincipal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TestConexion.ConnectionString = "Provider=MSDAORA;Data Source=" & Main.Basedatos & ";Persist Security Info=True;User ID=" & Usuario & ";Password=" & password & ";"
        TestConexion.Open()

        Main.StrConexion = TestConexion.ConnectionString
    End Sub

    Private Sub tsiEmpleados_Click(sender As Object, e As EventArgs) Handles tsiEmpleados.Click

        flag = 0
        FrmListadoEmpleados.MdiParent = Me

        With FrmListadoEmpleados
            .WindowState = FormWindowState.Normal
            .MdiParent = Me
            .Show()
        End With
    End Sub

    Private Sub tsiGeneraVaciones_Click(sender As Object, e As EventArgs) Handles tsiGeneraVaciones.Click

        AccionFreeDay = 0

        FrmGenerarVacaciones.MdiParent = Me

        With FrmGenerarVacaciones
            .WindowState = FormWindowState.Normal
            .MdiParent = Me
            .Show()
        End With
    End Sub

    Private Sub tsiTomarVacaciones_Click(sender As Object, e As EventArgs) Handles tsiTomarVacaciones.Click
        FrmListadoEmpleados.MdiParent = Me

        With FrmListadoEmpleados
            .WindowState = FormWindowState.Normal
            .MdiParent = Me
            .Show()
        End With
    End Sub

    Private Sub VacacionesEmpleadosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VacacionesEmpleadosToolStripMenuItem.Click
        FrmListadoVacionesEmpleados.MdiParent = Me

        With FrmListadoVacionesEmpleados
            .WindowState = FormWindowState.Normal
            .MdiParent = Me
            .Show()
        End With
    End Sub
End Class
