Public Class frmSecciones
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        frmCambio.Show()
    End Sub

    Private Sub frmSecciones_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        frmHome.Show()
        frmHome.txtUser.ForeColor = Color.LightSeaGreen
        frmHome.txtUser.TextAlign = HorizontalAlignment.Center
        frmHome.txtUser.Text = "Usuario"

        frmHome.txtPassword.ForeColor = Color.LightSeaGreen
        frmHome.txtPassword.TextAlign = HorizontalAlignment.Center
        frmHome.txtPassword.PasswordChar = ""
        frmHome.txtPassword.Text = "Contraseña"
    End Sub

    Private Sub frmSecciones_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class