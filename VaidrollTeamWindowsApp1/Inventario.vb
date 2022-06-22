Imports ClassLibrary1
Public Class Inventario
    Dim obj As New Class1

    Private Sub listarproductos()
        Dim dtpro = obj.BuscarProductos("", "")
        DataGridView1.DataSource = dtpro
    End Sub

    Private Sub BackgroundWorker1_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker1.DoWork
        For i = 0 To 100
            BackgroundWorker1.ReportProgress(i)
            Threading.Thread.Sleep(10)
            If ProgressBar1.Value = ProgressBar1.Maximum Then
                ProgressBar1.Visible = False
            End If
        Next
        listarproductos()
    End Sub

    Private Sub BackgroundWorker1_ProgressChanged(sender As Object, e As System.ComponentModel.ProgressChangedEventArgs) Handles BackgroundWorker1.ProgressChanged
        ProgressBar1.Value = e.ProgressPercentage
        If e.ProgressPercentage = ProgressBar1.Maximum Then
            ProgressBar1.Visible = False
        End If
    End Sub
    Private Sub Inventario_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        BackgroundWorker1.RunWorkerAsync()

        ComboBox1.DataSource = obj.ListarCategoria()
        ComboBox1.ValueMember = "IdCategoria"
        ComboBox1.DisplayMember = "Nombre"

        ComboBox2.DataSource = obj.ListarCategoria()
        ComboBox2.ValueMember = "IdCategoria"
        ComboBox2.DisplayMember = "Nombre"

    End Sub

    Private Sub ComboBox2_SelectedValueChanged(sender As Object, e As EventArgs) Handles ComboBox2.SelectedValueChanged

        Dim dtpro = obj.BuscarProductos(TextBox8.Text, ComboBox2.SelectedValue.ToString)
        DataGridView1.DataSource = dtpro


    End Sub
    Private Sub limpiar()
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox4.Text = ""
        TextBox5.Text = ""
        ComboBox1.SelectedIndex = 0
    End Sub



    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Dim dtpro = obj.BuscarProductos(TextBox8.Text, ComboBox2.SelectedValue.ToString)
        DataGridView1.DataSource = dtpro
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If ComboBox1.SelectedIndex > 0 Then
            obj.RegistrarProducto(TextBox2.Text, ComboBox1.SelectedValue.ToString, TextBox4.Text, TextBox5.Text)
            listarproductos()
            limpiar()
        End If
    End Sub


    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        limpiar()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        obj.EliminarProducto(TextBox1.Text)
        listarproductos()
        limpiar()
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        TextBox1.Text = DataGridView1.Item(0, e.RowIndex).Value
        TextBox2.Text = DataGridView1.Item(1, e.RowIndex).Value
        ComboBox1.SelectedValue = DataGridView1.Item(2, e.RowIndex).Value
        TextBox4.Text = DataGridView1.Item(4, e.RowIndex).Value
        TextBox5.Text = DataGridView1.Item(5, e.RowIndex).Value

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        obj.ModificarProducto(TextBox1.Text, TextBox2.Text, ComboBox1.SelectedValue, TextBox4.Text, TextBox5.Text)
        listarproductos()
        limpiar()
    End Sub


End Class