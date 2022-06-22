Imports ClassLibrary1
Public Class Login
    Dim obj As New Class1
    Private Sub btnlogin_Click(sender As Object, e As EventArgs) Handles btnlogin.Click

        Dim dt = obj.Login(TextBox1.Text, TextBox2.Text)

        If (dt.Rows.Count > 0) Then
            MsgBox("Bienvenido " + dt.Rows(0)(0).ToString, MsgBoxStyle.Exclamation, "Mensaje ")
            varnickusuario = dt.Rows(0)(0).ToString
            varcodigousuario = dt.Rows(0)(4).ToString
            varpermiso = dt.Rows(0)(3).ToString
            Principal.ShowDialog()
            TextBox1.Text = ""
            TextBox2.Text = ""

        Else
            MsgBox("Usuario o Contraseña Incorrecta", MsgBoxStyle.Critical, "Alerta")
            TextBox1.Text = ""
            TextBox2.Text = ""

        End If
    End Sub
End Class
