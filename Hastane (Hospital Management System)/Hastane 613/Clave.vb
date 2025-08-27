Public Class frmClave
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If txtSeguridad.Text = "13255" Then
            Me.Hide()
            frmSignIn.Show()
        Else
            MessageBox.Show("Contacte a un administrador.", "Código incorrecto")
        End If
    End Sub

    Private Sub Clave_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Me.Hide()
    End Sub

    Private Sub Clave_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Hide()
    End Sub

End Class