Imports Microsoft.Office
Imports Microsoft
Imports MySql.Data.MySqlClient
Imports MySql.Data
Imports FNCC.conectar
Imports System.IO
Imports System.Drawing.Imaging


Public Class frmProducto
    Dim stockAnterior As Integer

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Me.Close()
    End Sub

    Dim connection As MySqlConnection = GetConnection()

    Private Sub btn_examinar_Click(sender As Object, e As EventArgs) Handles btn_examinar.Click
        ' Muestra el cuadro de diálogo para seleccionar la imagen
        Dim nuevaRuta As String
        Dim openFileDialog As New OpenFileDialog()
        openFileDialog.Filter = "Archivos de imagen|*.jpg;*.jpeg;*.png;*.gif|Todos los archivos|*.*"

        If openFileDialog.ShowDialog() = DialogResult.OK Then
            ' Obtiene la ruta de la imagen seleccionada
            Dim rutaImagen As String = openFileDialog.FileName

            ' Muestra la imagen en un PictureBox (opcional)
            pbImagen.Image = Image.FromFile(rutaImagen)

            ' Guarda la imagen en una ubicación específica (puedes personalizar la ruta)
            'nuevaRuta = "C:\Users\karen\source\repos\FNCC\Imagenes\" & Path.GetFileName(rutaImagen)

            nuevaRuta = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyPictures), Path.GetFileName(rutaImagen))
            File.Copy(rutaImagen, nuevaRuta, True)
            txtFoto.Text = nuevaRuta
            ' Aquí puedes guardar la ruta de la imagen en tu base de datos junto con otros detalles del producto
            ' por ejemplo, podrías almacenar 'nuevaRuta' en tu base de datos
        End If
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click

        If connection.State = ConnectionState.Closed Then
            connection.Open()
        End If
        If btnGuardar.Text = "Guardar" Then

            Dim insertQuery As String = "INSERT INTO `producto`( `nombre`, `precio`, `stock`, `foto`) VALUES (@nombre,@precio,@stock,@foto)"
            Using command As New MySqlCommand(insertQuery, connection)
                ' Usar parámetros para pasar los valores de manera segura a la consulta.
                command.Parameters.AddWithValue("@nombre", txtNombre.Text)
                command.Parameters.AddWithValue("@precio", txtPrecio.Text)
                command.Parameters.AddWithValue("@stock", txtStock.Text)
                command.Parameters.AddWithValue("@foto", txtFoto.Text)
                ' Ejecutar la consulta.
                Dim rowsAffected As Integer = command.ExecuteNonQuery()

                If rowsAffected > 0 Then
                    MessageBox.Show("Datos insertados correctamente.")
                    Me.Close()
                    listadoProducto.Show()
                Else
                    MessageBox.Show("Error al insertar los datos.")
                End If
            End Using

        ElseIf btnGuardar.Text = "Editar" Then

            Dim updateQuery As String = "UPDATE `producto` SET `nombre`=@nombre, `precio`=@precio, `stock`=@stock WHERE `idProducto`=@idProducto"

            Using command As New MySqlCommand(updateQuery, connection)
                command.Parameters.AddWithValue("@idProducto", txtIdProducto.Text)
                command.Parameters.AddWithValue("@nombre", txtNombre.Text)
                command.Parameters.AddWithValue("@precio", txtPrecio.Text)
                command.Parameters.AddWithValue("@stock", txtStock.Text + stockAnterior)
                command.Parameters.AddWithValue("@foto", txtFoto.Text)
                Dim rowsAffected As Integer = command.ExecuteNonQuery()

                If rowsAffected > 0 Then
                    MessageBox.Show("Datos editados correctamente.")
                    Me.Close()
                    listadoProducto.Show()
                Else
                    MessageBox.Show("Error al editar los datos.")
                End If

            End Using


        End If

    End Sub

    Private Sub frmProducto_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim connection As MySqlConnection = GetConnection()
        connection.Open()
        'stockAnterior = CInt(txtStock.Text)
    End Sub



    Private Sub txtFoto_TextChanged(sender As Object, e As EventArgs) Handles txtFoto.TextChanged

    End Sub
End Class
