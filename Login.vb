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
                Me.Hide()
                frmIngresar.Show()
            Else
                MessageBox.Show("Usuario o contraseña incorrectos")
            End If
            reader.Close()
        End Using

    End Sub

    Private Sub txtContrasenia_KeyDown(sender As Object, e As KeyEventArgs) Handles txtContrasenia.KeyDown

        ' Verifica si se ha presionado la tecla Enter
        If e.KeyCode = Keys.Enter Then
            ' Llama al evento del botón Aceptar
            lblAceptar.PerformClick()
            ' Evita el sonido de "ding" al presionar Enter
            e.SuppressKeyPress = True
        End If
    End Sub

    Private Sub txtUsuario_TextChanged(sender As Object, e As EventArgs) Handles txtUsuario.TextChanged

    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Me.Close()
    End Sub
End Class
