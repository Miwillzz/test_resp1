Imports ClassLibrary1
Public Class Cambiarpass
    Dim obj As New Class1
    Private Sub Cambiarpass_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtcodigo.Text = varcodigousuario
    End Sub

    Private Sub btncambiar_Click(sender As Object, e As EventArgs) Handles btncambiar.Click
        If txtnueva.TextLength > 2 Then
            obj.CambiarPass(txtcodigo.Text, txtnueva.Text)
            txtnueva.Text = ""
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        txtnueva.Text = ""
    End Sub
End Class