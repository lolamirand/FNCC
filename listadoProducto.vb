Imports MySql.Data.MySqlClient
Imports MySql.Data
Imports FNCC.conectar
Public Class listadoProducto

    Dim connection As MySqlConnection = GetConnection()
    Private Sub BtnNuevoProducto_Click(sender As Object, e As EventArgs) Handles BtnNuevoProducto.Click
        Me.Close()
        frmProducto.Show()
    End Sub

    ' Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    '   If e.RowIndex >= 0 Then
    '      Dim selectedRow As DataGridViewRow = DataGridView1.Rows(e.RowIndex)
    '
    'Dim idProducto As Integer = Convert.ToInt32(selectedRow.Cells("idProducto").Value) ' Asumiendo que el nombre de la columna que contiene el ID es "idProducto"
    'Dim nombreProducto As String = Convert.ToString(selectedRow.Cells("nombre").Value) ' Reemplaza "nombreColumna" con el nombre real de la columna del nombre
    'Dim precioProducto As Decimal = Convert.ToDecimal(selectedRow.Cells("precio").Value) ' Reemplaza "precioColumna" con el nombre real de la columna del precio
    'Dim stockProducto As Integer = Convert.ToInt32(selectedRow.Cells("stock").Value) ' Reemplaza "stockColumna" con el nombre real de la columna del stock

    'Dim frmProducto As New frmProducto() ' Reemplaza "FormularioProducto" con el nombre real de tu formulario
    'frmProducto.txtIdProducto.Text = idProducto
    'frmProducto.txtNombre.Text = nombreProducto
    'frmProducto.txtPrecio.Text = precioProducto.ToString()
    'frmProducto.txtStock.Text = stockProducto.ToString()
    ''frmProducto.txtFoto.Text
    'frmProducto.lblTítulo.Text = "Editar producto"
    'frmProducto.btnGuardar.Text = "Editar"

    'frmProducto.Show()
    'End If
    ' End Sub



    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim selectQuery As String = "SELECT idProducto,nombre,precio,stock, foto FROM PRODUCTO"
        Dim dataTable As New DataTable()
        connection.Open()

        Using command As New MySqlCommand(selectQuery, connection)
            Using adapter As New MySqlDataAdapter(command)
                ' Llenar el DataTable con los datos del adaptador
                adapter.Fill(dataTable)
            End Using
        End Using

        ' Asignar el DataTable al DataGridView
        'DataGridView1Column Columna
        ' DataGridView1.DataSource = dataTable
        'DataGridView1.Columns.Add("Nombre")
        'DataGridView1.Columns.Add("precio")
        ' DataGridView1.Columns.Add("stock")

        'DataGridView1.Columns.Add("Precio", "Precio")
        'DataGridView1.Columns.Add("Stock", "Stock")
        DataGridView1.DataSource = dataTable
        Dim ColCheck As DataGridViewCheckBoxColumn = New DataGridViewCheckBoxColumn()
        ColCheck.Name = "Opciones"
        Me.DataGridView1.Columns.Add(ColCheck)
        'DataGridView1.Columns.Add("Opciones", "Opciones")
        'For i = 1 To dataTable.Rows.Count - 1
        'DataGridView1.Rows.Add(dataTable.Rows(i))
        'Next
    End Sub

    Private Sub btn_basura_Click(sender As Object, e As EventArgs) Handles btn_basura.Click
        ' aca programar que si esta tildado lo borre de la base de datos
        For i = 0 To DataGridView1.Rows.Count - 1
            If CBool(DataGridView1.Rows(i).Cells(5).Value) Then

                Dim selectedRow As DataGridViewRow = DataGridView1.Rows(i)

                Dim idProducto As Integer = Convert.ToInt32(selectedRow.Cells("idProducto").Value)

                Dim deleteQuery As String = "DELETE FROM `producto` WHERE `idProducto` = @idProducto"

                '///////////////////////////////////////
                Using command As New MySqlCommand(deleteQuery, connection)
                    ' Usar parámetros para pasar los valores de manera segura a la consulta.
                    command.Parameters.AddWithValue("@idProducto", idProducto)
                    ' Ejecutar la consulta.
                    Dim rowsAffected As Integer = command.ExecuteNonQuery()
                    ' Asumiendo que el nombre de la columna que contiene el ID es "idProducto
                    DataGridView1.Rows(i).Cells(5).Value = 0
                    MsgBox("Datos eliminados correctamente.")
                    '    Me.Close()

                End Using
            End If
        Next
    End Sub

    Private Sub btn_editar_Click(sender As Object, e As EventArgs) Handles btn_editar.Click
        For i = 0 To DataGridView1.Rows.Count - 1
            If CBool(DataGridView1.Rows(i).Cells(5).Value) Then

                Dim selectedRow As DataGridViewRow = DataGridView1.Rows(i)

                Dim idProducto As Integer = Convert.ToInt32(selectedRow.Cells("idProducto").Value) ' Asumiendo que el nombre de la columna que contiene el ID es "idProducto"
                Dim nombreProducto As String = Convert.ToString(selectedRow.Cells("nombre").Value) ' Reemplaza "nombreColumna" con el nombre real de la columna del nombre
                Dim precioProducto As Decimal = Convert.ToDecimal(selectedRow.Cells("precio").Value) ' Reemplaza "precioColumna" con el nombre real de la columna del precio
                Dim stockProducto As Integer = Convert.ToInt32(selectedRow.Cells("stock").Value) ' Reemplaza "stockColumna" con el nombre real de la columna del stock
                Dim fotoProducto As String = Convert.ToString(selectedRow.Cells("foto").Value)
                Dim frmProducto As New frmProducto() ' Reemplaza "FormularioProducto" con el nombre real de tu formulario

                frmProducto.txtIdProducto.Text = idProducto
                frmProducto.txtNombre.Text = nombreProducto
                frmProducto.txtPrecio.Text = precioProducto.ToString()
                frmProducto.txtStock.Text = stockProducto.ToString()
                frmProducto.txtFoto.Text = frmProducto.ToString()
                frmProducto.pbImagen.Image = Image.FromFile(fotoProducto)

                frmProducto.lblTítulo.Text = "Editar producto"
                frmProducto.btnGuardar.Text = "Editar"

                DataGridView1.Rows(i).Cells(5).Value = 0
                frmProducto.Show()
            End If
        Next
    End Sub
End Class





