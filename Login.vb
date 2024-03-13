Imports MySql.Data.MySqlClient
Imports MySql.Data
Imports FNCC.conectar

Public Class Login
    Dim connection As MySqlConnection = GetConnection()

    Private Sub lbl_aceptar_Click(sender As Object, e As EventArgs) Handles lblAceptar.Click
        If txtUsuario.Text = "" Then
            MessageBox.Show("Por favor, ingrese el usuario. ")
            txtUsuario.Focus()
            Exit Sub
        End If
        If txtContrasenia.Text = "" Then
            MessageBox.Show("Por favor, ingrese la contraseña. ")
            txtUsuario.Focus()
            Exit Sub
        End If

        Dim selectQuery As String = "SELECT * from usuario where usuario ='" & txtUsuario.Text & "' and contrasenia = '" & txtContrasenia.Text & "'"

        If connection.State = ConnectionState.Closed Then
            connection.Open()

        End If
        Using Command As New MySqlCommand(selectQuery, connection)
            Dim reader As MySqlDataReader = Command.ExecuteReader()

            ' Iterar a través de los resultados
            If reader.HasRows() Then
                frmIngresar.Show()

            Else
                MessageBox.Show("usuario o contraseña invalida")
            End If
            reader.Close()
        End Using

    End Sub

    Private Sub txtContrasenia_TextChanged(sender As Object, e As EventArgs) Handles txtContrasenia.TextChanged

    End Sub
End Class
