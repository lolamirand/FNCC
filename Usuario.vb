
Imports MySql.Data.MySqlClient
Imports MySql.Data
Imports FNCC.conectar

Public Class frmUsuario

    Dim connection As MySqlConnection = GetConnection()

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        '  Dim connection As MySqlConnection = GetConnection()bulrich

    End Sub



    Private Sub btnCancelar_Click_1(sender As Object, e As EventArgs) Handles btnCancelar.Click
        txtUsuario.Text = ""
        txtContrasenia.Text = ""
        Me.Close()
    End Sub

    Private Sub btnGuardar_Click_1(sender As Object, e As EventArgs) Handles btnGuardar.Click

        If btnGuardar.Text = "Guardar" Then
            Dim usuario As String = txtUsuario.Text
            Dim contrasenia As String = txtContrasenia.Text
            Dim insertQuery As String = "INSERT INTO `usuario`(`usuario`, `contrasenia`) VALUES (@usuario, @contrasenia)"
            connection.Open()

            Using command As New MySqlCommand(insertQuery, connection)
                ' Usar parámetros para pasar los valores de manera segura a la consulta.
                command.Parameters.AddWithValue("@usuario", txtUsuario.Text)
                command.Parameters.AddWithValue("@contrasenia", txtContrasenia.Text)
                ' Ejecutar la consulta.
                Dim rowsAffected As Integer = command.ExecuteNonQuery()

                If rowsAffected > 0 Then
                    MessageBox.Show("Datos insertados correctamente.")
                    Me.Close()
                    listUsuarios.Show()

                Else
                    MessageBox.Show("Error al insertar los datos.")
                End If
            End Using

        ElseIf btnGuardar.Text = "Editar" Then

            If txtContrasenia.Text = "" Then
                MessageBox.Show("Por favor ingrese contraseña.")

            Else
                Dim updateQuery As String = "UPDATE `usuario` SET `usuario`=@usuario, `contrasenia`=@contrasenia WHERE `idUsuario`=@idUsuario"
                connection.Open()


                Using command As New MySqlCommand(updateQuery, connection)
                    command.Parameters.AddWithValue("@idUsuario", TxtIdUsuario.Text)
                    command.Parameters.AddWithValue("@usuario", txtUsuario.Text)
                    command.Parameters.AddWithValue("@contrasenia", txtContrasenia.Text)
                    Dim rowsAffected As Integer = command.ExecuteNonQuery()

                    If rowsAffected > 0 Then
                        MessageBox.Show("Datos editados correctamente.")
                        Me.Close()
                        listUsuarios.Refresh()
                        listUsuarios.Show()
                    Else
                        MessageBox.Show("Error al editar los datos.")
                    End If

                End Using
            End If

        End If
    End Sub

    Private Sub txtContrasenia_TextChanged(sender As Object, e As EventArgs) Handles txtContrasenia.TextChanged
        txtContrasenia.UseSystemPasswordChar = True
        txtContrasenia.PasswordChar = "*"

    End Sub
End Class
