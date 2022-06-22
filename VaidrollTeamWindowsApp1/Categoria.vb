Imports ClassLibrary1
Public Class Categoria
    Dim obj As New Class1

    Private Sub listarcategoria()
        Dim dtcat = obj.BuscarCategoria("", "")
        dgvcategoria.DataSource = dtcat

    End Sub
    Private Sub limpiar()
        TextBox1.Text = ""
        TextBox2.Text = ""
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Dim dtpro = obj.BuscarCategoria(TextBox3.Text, TextBox8.Text)
        dgvcategoria.DataSource = dtpro
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        obj.RegistrarCategoria(TextBox2.Text)
        listarcategoria()
        limpiar()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        limpiar()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        obj.ModificarCategoria(TextBox1.Text, TextBox2.Text)
        listarcategoria()
        limpiar()
    End Sub

    Private Sub Categoria_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        listarcategoria()
    End Sub

    Private Sub dgvcategoria_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvcategoria.CellContentClick
        TextBox1.Text = dgvcategoria.Item(0, e.RowIndex).Value
        TextBox2.Text = dgvcategoria.Item(1, e.RowIndex).Value
    End Sub
End Class