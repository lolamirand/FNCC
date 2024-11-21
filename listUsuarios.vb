

Imports MySql.Data.MySqlClient
Imports MySql.Data
Imports FNCC.conectar
Public Class listUsuarios

    Dim connection As MySqlConnection = GetConnection()
    Private Sub ButtonNuevo_Click(sender As Object, e As EventArgs)
        Me.Close()
        frmUsuario.Show()
    End Sub



    Private Sub listUsuarios_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim selectQuery As String = "SELECT idUsuario,usuario FROM USUARIO"
        Dim dataTable As New DataTable()
        connection.Open()

        Using command As New MySqlCommand(selectQuery, connection)
            Using adapter As New MySqlDataAdapter(command)
                ' Llenar el DataTable con los datos del adaptador
                adapter.Fill(dataTable)
            End Using
        End Using

        DataGridView1.DataSource = dataTable
        DataGridView1.AllowUserToAddRows = False
        DataGridView1.Columns(0).Visible = False

        Dim ColCheck As DataGridViewCheckBoxColumn = New DataGridViewCheckBoxColumn()
        ColCheck.Name = "Opciones"
        Me.DataGridView1.Columns.Add(ColCheck)


    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btn_editar.Click

        For i = 0 To DataGridView1.Rows.Count - 1
            If CBool(DataGridView1.Rows(i).Cells(2).Value) Then

                Dim selectedRow As DataGridViewRow = DataGridView1.Rows(i)

                Dim idUsuario As Integer = Convert.ToInt32(selectedRow.Cells("idUsuario").Value) ' Asumiendo que el nombre de la columna que contiene el ID es "idProducto"
                Dim Usuario As String = Convert.ToString(selectedRow.Cells("Usuario").Value) ' Reemplaza "nombreColumna" con el nombre real de la columna del nombre
                Dim frmUsuario As New frmUsuario() ' Reemplaza "FormularioUsuario" con el nombre real de tu formulario

                frmUsuario.TxtIdUsuario.Text = idUsuario
                frmUsuario.txtUsuario.Text = Usuario

                frmUsuario.lblTitulo.Text = "Editar Usuario"
                frmUsuario.btnGuardar.Text = "Editar"

                DataGridView1.Rows(i).Cells(2).Value = 0
                frmUsuario.Show()
            End If
        Next
        Me.Close()
    End Sub

    Private Sub btn_basura_Click(sender As Object, e As EventArgs) Handles btn_basura.Click
        ' aca programar que si esta tildado lo borre de la base de datos
        For i = 0 To DataGridView1.Rows.Count - 1
            If CBool(DataGridView1.Rows(i).Cells(2).Value) Then

                Dim selectedRow As DataGridViewRow = DataGridView1.Rows(i)

                Dim idUsuario As Integer = Convert.ToInt32(selectedRow.Cells("idUsuario").Value)

                Dim deleteQuery As String = "DELETE FROM `usuario` WHERE `idUsuario` = @idUsuario"


                Using command As New MySqlCommand(deleteQuery, connection)
                    ' Usar parámetros para pasar los valores de manera segura a la consulta.
                    command.Parameters.AddWithValue("@idUsuario", idUsuario)
                    ' Ejecutar la consulta.
                    Dim rowsAffected As Integer = command.ExecuteNonQuery()
                    ' Asumiendo que el nombre de la columna que contiene el ID es "idProducto
                    DataGridView1.Rows(i).Cells(2).Value = 0
                    MsgBox("Datos eliminados correctamente.")
                    '    Me.Close()

                End Using
            End If
        Next
        Me.Refresh()
    End Sub

    Private Sub BtnNuevoProducto_Click(sender As Object, e As EventArgs) Handles BtnNuevoProducto.Click
        Me.Close()
        frmUsuario.lblTitulo.Text = "SIGN UP"
        frmUsuario.btnGuardar.Text = "Guardar"
        frmUsuario.Show()
    End Sub
End Class