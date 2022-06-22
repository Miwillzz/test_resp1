Public Class Principal


    Private Sub btninventario_Click(sender As Object, e As EventArgs) Handles btninventario.Click
        Me.ToolStripContainer1.ContentPanel.Controls.Clear()
        Dim frminventario As New Inventario
        frminventario.MdiParent = Me
        Me.ToolStripContainer1.ContentPanel.Controls.Add(frminventario)
        frminventario.Show()
    End Sub

    Private Sub btncategoria_Click(sender As Object, e As EventArgs) Handles btncategoria.Click
        Me.ToolStripContainer1.ContentPanel.Controls.Clear()
        Dim frmcategoria As New Categoria
        frmcategoria.MdiParent = Me
        Me.ToolStripContainer1.ContentPanel.Controls.Add(frmcategoria)
        frmcategoria.Show()
    End Sub

    Private Sub btnusuario_Click(sender As Object, e As EventArgs) Handles btnusuario.Click
        Me.ToolStripContainer1.ContentPanel.Controls.Clear()
        Dim frmusuarios As New Usuarios
        frmusuarios.MdiParent = Me
        Me.ToolStripContainer1.ContentPanel.Controls.Add(frmusuarios)
        frmusuarios.Show()
    End Sub

    Private Sub btbnsalir_Click(sender As Object, e As EventArgs) Handles btbnsalir.Click
        Close()
    End Sub

    Private Sub btnpass_Click(sender As Object, e As EventArgs) Handles btnpass.Click
        Me.ToolStripContainer1.ContentPanel.Controls.Clear()
        Dim frmpass As New Cambiarpass
        frmpass.MdiParent = Me
        Me.ToolStripContainer1.ContentPanel.Controls.Add(frmpass)
        frmpass.Show()
    End Sub

    Private Sub Principal_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        'Application.Exit()
    End Sub

    Private Sub Principal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblnombreusuario.Text = varnickusuario
        Me.ToolStripContainer1.ContentPanel.Controls.Clear()
        If varpermiso = "B0002" Then
            btnusuario.Enabled = False
        ElseIf varpermiso = "B0001" Then
            btnusuario.Enabled = True
        End If
    End Sub

    Private Sub btninicio_Click(sender As Object, e As EventArgs) Handles btninicio.Click
        Try
            Me.ToolStripContainer1.ContentPanel.Controls.Clear()
        Catch ex As Exception
            MsgBox("Tranquilo")
        End Try
    End Sub



End Class