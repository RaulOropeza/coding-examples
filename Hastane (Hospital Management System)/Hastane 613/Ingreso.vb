Imports System.Data.OleDb

Public Class frmHome
    Dim connection As New OleDbConnection
    Dim nombre As String
    Dim tipo As String

    Public Function Val()
        Dim dt As New DataTable
        Dim ds As New DataSet
        ds.Tables.Add(dt)
        connection.Open()
        Dim da As New OleDbDataAdapter("select * from Usuarios", connection)

        da.Fill(dt)

        For Each datarow In dt.Rows
            If txtUser.Text = datarow.item(1) And txtPassword.Text = datarow.item(2) Then
                nombre = datarow.item("Nombre")
                tipo = datarow.item("Tipo_Usuario")
                connection.Close()
                Return True
            End If
        Next
        connection.Close()
        Return False
    End Function

    Private Sub frmHome_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        End
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs)
        End
    End Sub

    Private Sub txtUser_GotFocus(sender As Object, e As EventArgs) Handles txtUser.GotFocus
        txtUser.Clear()
        txtUser.ForeColor = Color.DarkSlateGray
        txtUser.TextAlign = HorizontalAlignment.Left
    End Sub

    Private Sub txtPassword_GotFocus(sender As Object, e As EventArgs) Handles txtPassword.GotFocus
        txtPassword.Clear()
        txtPassword.ForeColor = Color.DarkSlateGray
        txtPassword.TextAlign = HorizontalAlignment.Left
        txtPassword.PasswordChar = "⚫"
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        frmClave.Show()
    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click
        End
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If txtUser.Text = "Usuario" Or txtPassword.Text = "Contraseña" Then
            MessageBox.Show("Ingrese un usuario y contraseña.", "Error de Ingreso", MessageBoxButtons.OK, MessageBoxIcon.Stop)
        ElseIf Val() = True Then
            MessageBox.Show("Hola " & nombre & ".", "Acceso Concedido")

            Me.Hide()

            Select Case tipo
                Case "##115##"
                    frmDirGen.Show()
                Case "Recepcionista"
                    frmRecep.Show()
                Case "Médico"
                    frmCambio.Show()
                Case "Director"
                    frmDirGen.Show()
                Case "Farmacéutico"
                    frmFarmacia.Show()
                Case "Cajero"
                    frmVentPago.Show()
            End Select

        Else
            MessageBox.Show("Su usuario o su contraseña es incorrecta.", "Acceso Denegado", MessageBoxButtons.OK, MessageBoxIcon.Stop)
        End If
    End Sub

    Private Sub Label3_MouseHover(sender As Object, e As EventArgs) Handles Label3.MouseHover
        Label3.ForeColor = Color.LightSteelBlue
    End Sub

    Private Sub Label3_MouseLeave(sender As Object, e As EventArgs) Handles Label3.MouseLeave
        Label3.ForeColor = Color.SteelBlue
    End Sub

    Private Sub frmHome_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        connection.ConnectionString = "provider = microsoft.jet.oledb.4.0; data source = Hastane.mdb"
    End Sub
End Class