Imports System.Data.OleDb

Public Class frmEmpleados
    Dim connection As New OleDb.OleDbConnection
    Dim command As New OleDb.OleDbCommand
    Dim adapter As New OleDb.OleDbDataAdapter
    Dim register As New DataSet

    Dim idempleado As String
    Dim nombre As String
    Dim apellido As String
    Dim puesto As String
    Dim especialidad As String
    Dim secc As String
    Dim sala As String
    Dim salario As String
    Dim dpsemana As String

    Public Function AllTextBoxesFilled()
        If txtIdEmpleado.Text = "" Then
            Return False
        ElseIf txtDS.Text = "" Then
            Return False
        ElseIf txtNombre.Text = "" Then
            Return False
        ElseIf txtEspecialidad.Text = "" Then
            Return False
        ElseIf txtPuesto.Text = "" Then
            Return False
        ElseIf txtApellido.Text = "" Then
            Return False
        ElseIf txtSala.Text = "" Then
            Return False
        ElseIf txtSalario.Text = "" Then
            Return False
        ElseIf txtSecc.Text = "" Then
            Return False
        Else
            Return True
        End If
    End Function

    Public Function Val()
        Dim dt As New DataTable
        Dim ds As New DataSet
        ds.Tables.Add(dt)
        connection.Open()
        Dim da As New OleDbDataAdapter("select * from Empleados", connection)

        da.Fill(dt)

        For Each datarow In dt.Rows
            If idempleado = datarow.item("IdEmpleado") Then
                nombre = datarow.item("Nombres")
                idempleado = datarow.item("IdEmpleado")
                apellido = datarow.item("Apellidos")
                puesto = datarow.item("Puesto")
                especialidad = datarow.item("Especialidad")
                secc = datarow.item("Sección")
                sala = datarow.item("Sala")
                salario = datarow.item("Salario_Mensual")
                dpsemana = datarow.item("Días_Por_Semana")

                connection.Close()
                Return True
            End If
        Next
        connection.Close()
        Return False
    End Function

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        frmCambio.Show()
    End Sub

    Private Sub frmEmpleados_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        frmHome.Show()
        frmHome.txtUser.ForeColor = Color.LightSeaGreen
        frmHome.txtUser.TextAlign = HorizontalAlignment.Center
        frmHome.txtUser.Text = "Usuario"

        frmHome.txtPassword.ForeColor = Color.LightSeaGreen
        frmHome.txtPassword.TextAlign = HorizontalAlignment.Center
        frmHome.txtPassword.PasswordChar = ""
        frmHome.txtPassword.Text = "Contraseña"
    End Sub

    Private Sub frmEmpleados_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        connection.ConnectionString = "provider = microsoft.jet.oledb.4.0; data source = Hastane.mdb"
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        txtIdEmpleado.Clear()
        txtIdEmpleado.Focus()
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        txtNombre.Clear()
        txtNombre.Focus()
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        txtApellido.Clear()
        txtApellido.Focus()
    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        txtPuesto.Clear()
        txtPuesto.Focus()
    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        txtEspecialidad.Clear()
        txtEspecialidad.Focus()
    End Sub

    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles Button13.Click
        txtSecc.Clear()
        txtSecc.Focus()
    End Sub

    Private Sub Button14_Click(sender As Object, e As EventArgs) Handles Button14.Click
        txtSala.Clear()
        txtSala.Focus()
    End Sub

    Private Sub Button15_Click(sender As Object, e As EventArgs) Handles Button15.Click
        txtSalario.Clear()
        txtSalario.Focus()
    End Sub

    Private Sub Button16_Click(sender As Object, e As EventArgs) Handles Button16.Click
        txtDS.Clear()
        txtDS.Focus()
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        idempleado = InputBox("Ingrese el Id del empleado que desea buscar:")
        If Val() = True Then
            txtIdEmpleado.Text = idempleado
            txtNombre.Text = nombre
            txtApellido.Text = apellido
            txtPuesto.Text = puesto
            txtEspecialidad.Text = especialidad
            txtSecc.Text = secc
            txtSala.Text = sala
            txtSalario.Text = salario
            txtDS.Text = dpsemana

            btnEliminar.Enabled = True
        Else
            MessageBox.Show("No hay ningún registro con ese Id.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop)
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        txtIdEmpleado.Text = ""
        txtNombre.Text = ""
        txtApellido.Text = ""
        txtPuesto.Text = ""
        txtEspecialidad.Text = ""
        txtSecc.Text = ""
        txtSala.Text = ""
        txtSalario.Text = ""
        txtDS.Text = ""

        txtIdEmpleado.Focus()
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        If AllTextBoxesFilled() = True Then
            idempleado = txtIdEmpleado.Text
            If Val() = False Then
                Dim dt As New DataTable
                Dim ds As New DataSet
                ds.Tables.Add(dt)
                Dim da As New OleDbDataAdapter
                da = New OleDbDataAdapter("SELECT * from Empleados", connection)
                da.Fill(dt)
                Dim neue As DataRow = dt.NewRow

                With neue
                    .Item("IdEmpleado") = txtIdEmpleado.Text
                    .Item("Nombres") = txtNombre.Text
                    .Item("Apellidos") = txtApellido.Text
                    .Item("Puesto") = txtPuesto.Text
                    .Item("Especialidad") = txtEspecialidad.Text
                    .Item("Sección") = txtSecc.Text
                    .Item("Sala") = txtSala.Text
                    .Item("Salario_Mensual") = txtSalario.Text
                    .Item("Días_Por_Semana") = txtDS.Text
                End With

                dt.Rows.Add(neue)
                Dim cb As New OleDbCommandBuilder(da)

                da.Update(dt)
                connection.Close()

                MessageBox.Show("El registro se ha añadido exitosamente.", "Registro Añadido")

            Else
                Dim actualizar As String
                connection.Open()

                actualizar = "UPDATE Empleados SET Nombres = '" & txtNombre.Text & "', Apellidos = '" & txtApellido.Text & "', Puesto = '" & txtPuesto.Text & "', Especialidad = '" & txtEspecialidad.Text & "', Sección = '" & txtSecc.Text & "', Sala = '" & txtSala.Text & "', Salario_Mensual = '" & txtSalario.Text & "', Días_Por_Semana = '" & txtDS.Text & "'"
                command = New OleDb.OleDbCommand(actualizar, connection)
                command.ExecuteNonQuery()
                MsgBox("El registro ha sido actualizado.", vbInformation, "Listo")
            End If
            connection.Close()
        Else
            MessageBox.Show("Todos los campos deben ser llenados.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop)
        End If
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        If AllTextBoxesFilled() = True Then
            Dim eliminar As String
            Dim respuesta As Byte
            respuesta = MsgBox("¿Desea eliminar este registro?", vbYesNo, "Eliminar Registro")

            If respuesta = vbYes Then
                connection.Open()
                idempleado = txtIdEmpleado.Text

                eliminar = "DELETE * FROM Empleados WHERE IdEmpleado = '" & idempleado & "'"
                command = New OleDb.OleDbCommand(eliminar, connection)
                command.ExecuteNonQuery()
                MsgBox("El registro ha sido eliminado.", vbInformation, "Listo")

                txtIdEmpleado.Text = ""
                txtNombre.Text = ""
                txtApellido.Text = ""
                txtPuesto.Text = ""
                txtEspecialidad.Text = ""
                txtSecc.Text = ""
                txtSala.Text = ""
                txtSalario.Text = ""
                txtDS.Text = ""

                txtIdEmpleado.Focus()

                connection.Close()
            End If
        Else
            MessageBox.Show("Todos los campos deben ser llenados.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop)
        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        MessageBox.Show("Esta función está en construcción.", "Lo Sentimos", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        MessageBox.Show("Esta función está en construcción.", "Lo Sentimos", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub
End Class