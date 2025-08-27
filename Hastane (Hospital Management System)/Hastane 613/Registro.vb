Imports System.Data.OleDb

Public Class frmSignIn
    Dim connection As New OleDb.OleDbConnection
    Dim command As New OleDb.OleDbCommand
    Dim adapter As New OleDb.OleDbDataAdapter
    Dim register As New DataSet

    Private Sub frmSignIn_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Me.Hide()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If txtApellidoPaterno.Text = "" Then
            MessageBox.Show("Llene todos los campos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop)
        ElseIf txtConfirmar.Text = "" Then
            MessageBox.Show("Llene todos los campos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop)
        ElseIf txtContraseña.Text = "" Then
            MessageBox.Show("Llene todos los campos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop)
        ElseIf txtCorreo.Text = "" Then
            MessageBox.Show("Llene todos los campos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop)
        ElseIf txtIdUsuario.Text = "" Then
            MessageBox.Show("Llene todos los campos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop)
        ElseIf txtNombre.Text = "" Then
            MessageBox.Show("Llene todos los campos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop)
        ElseIf txtUsuario.Text = "" Then
            MessageBox.Show("Llene todos los campos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop)
        ElseIf cmbTipo.Text = "Seleccionar..." Then
            MessageBox.Show("Llene todos los campos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            'ElseIf cmbTipo.Text IsNot cmbTipo.Items And cmbTipo.Text <> "##115##" Then
            'MessageBox.Show("Tipo de Usuario no identificado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop)
        ElseIf txtContraseña.Text <> txtConfirmar.Text Then
            MessageBox.Show("Las contraseñas no coinciden.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop)
        Else
            Dim dt As New DataTable
            Dim ds As New DataSet
            ds.Tables.Add(dt)
            Dim da As New OleDbDataAdapter
            da = New OleDbDataAdapter("Select * from Usuarios", connection)
            da.Fill(dt)
            Dim nuevo As DataRow = dt.NewRow

            With nuevo
                .Item("IdUsuario") = txtIdUsuario.Text
                .Item("Usuario") = txtUsuario.Text
                .Item("Contraseña") = txtConfirmar.Text
                .Item("Nombre") = txtNombre.Text
                .Item("Apellido_Paterno") = txtApellidoPaterno.Text
                .Item("Correo_Elec") = txtCorreo.Text
                .Item("Tipo_Usuario") = cmbTipo.Text
            End With

            dt.Rows.Add(nuevo)
            Dim cb As New OleDbCommandBuilder(da)

            da.Update(dt)
            connection.Close()

            txtIdUsuario.Text = ""
            txtUsuario.Text = ""
            txtContraseña.Text = ""
            txtConfirmar.Text = ""
            txtNombre.Text = ""
            txtApellidoPaterno.Text = ""
            txtCorreo.Text = ""
            cmbTipo.Text = "Seleccionar..."

            MessageBox.Show("Su usuario ha sido añadido a la base de datos.", "Usuario Añadido")

            Me.Hide()
        End If
        connection.Close()
    End Sub

    Private Sub frmSignIn_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        connection.ConnectionString = "provider = microsoft.jet.oledb.4.0; data source = Hastane.mdb"
        connection.Open()
    End Sub
End Class