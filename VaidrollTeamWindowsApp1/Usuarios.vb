Imports ClassLibrary1
Public Class Usuarios
    Dim obj As New Class1

    Private Sub limpiar()
        txtcodigo.Text = ""
        txtnombre.Text = ""
        txtcorreo.Text = ""
        txtusuario.Text = ""
        ComboBox1.SelectedIndex = 0
    End Sub
    Private Sub listarusuarios()
        Dim dtpro = obj.BuscarUsuarios("")
        DataGridView1.DataSource = dtpro
    End Sub



    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles btnbuscar.Click
        Dim dtpro = obj.BuscarUsuarios(txtbuscar.Text)
        DataGridView1.DataSource = dtpro
    End Sub

    Private Sub Usuarios_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        listarusuarios()

        ComboBox1.DataSource = obj.ListarUsuarios()
        ComboBox1.ValueMember = "idpermisos"
        ComboBox1.DisplayMember = "Permiso"
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles btnnuevo.Click
        limpiar()
    End Sub

    Private Sub btnmodificar_Click(sender As Object, e As EventArgs) Handles btnmodificar.Click
        obj.ModificarUsuario(txtcodigo.Text, txtnombre.Text, txtcorreo.Text, ComboBox1.SelectedValue)
        listarusuarios()
        limpiar()
    End Sub

    Private Sub btnguardar_Click(sender As Object, e As EventArgs) Handles btnguardar.Click
        If ComboBox1.SelectedIndex > 0 Then
            obj.RegistrarUsuario(txtnombre.Text, txtcorreo.Text, txtusuario.Text, ComboBox1.SelectedValue.ToString)
            listarusuarios()
            limpiar()
        End If
    End Sub

    Private Sub Usuarios_Leave(sender As Object, e As EventArgs) Handles MyBase.Leave

    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        If (e.RowIndex >= 0) Then
            txtcodigo.Text = DataGridView1.Item(0, e.RowIndex).Value
            txtnombre.Text = DataGridView1.Item(1, e.RowIndex).Value
            txtcorreo.Text = DataGridView1.Item(2, e.RowIndex).Value
            txtusuario.Text = DataGridView1.Item(3, e.RowIndex).Value
            ComboBox1.SelectedValue = DataGridView1.Item(4, e.RowIndex).Value
        End If
    End Sub

    Private Sub btneliminar_Click(sender As Object, e As EventArgs) Handles btneliminar.Click
        obj.EliminarUsuario(txtcodigo.Text)
        listarusuarios()
        limpiar()
    End Sub

    Private Sub btnresetear_Click(sender As Object, e As EventArgs) Handles btnresetear.Click
        obj.ResetearUsuario(txtcodigo.Text)
        listarusuarios()
        limpiar()
    End Sub
End Class