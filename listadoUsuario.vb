Imports MySql.Data.MySqlClient
Imports MySql.Data
Imports FNCC.conectar
Public Class listadoUsuario


    'Dim connection As MySqlConnection = GetConnection()
    ' Private Sub BtnNuevoUsuario_Click(sender As Object, e As EventArgs) Handles BtnNuevoUsuario.Click
    'Me.Close()
    '   frmProducto.Show()

    'End Sub

    ' Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    ' If e.RowIndex >= 0 Then
    '    Dim selectedRow As DataGridViewRow = DataGridView1.Rows(e.RowIndex)

    'Dim idUsuario As Integer = Convert.ToInt32(selectedRow.Cells("idUsuario").Value) ' Asumiendo que el nombre de la columna que contiene el ID es "idProducto"
    'Dim nombreUsuario As String = Convert.ToString(selectedRow.Cells("nombre").Value) ' Reemplaza "nombreColumna" con el nombre real de la columna del nombre


    'Dim frmUsuario As New frmUsuario() ' Reemplaza "FormularioUsuario" con el nombre real de tu formulario
    '    frmUsuario.txtIdUsuario.Text = idUsuario
    '   frmUsuario.txtNombre.Text = nombreUsuario

    'frmProducto.txtFoto.Text
    '   frmUsuario.lblTítulo.Text = "Editar Usuario"
    '       frmUsuario.btnGuardar.Text = "Editar"

    '      frmUsuario.Show()
    'End If
    ' End Sub



    'Private Sub Form1_Load(sender As Object, e As EventArgs)
    ' Dim selectQuery As String = "SELECT idUsuario,nombre FROM USUARIO"
    'Dim dataTable As New DataTable()
    '    connection.Open()

    'Using command As New MySqlCommand(selectQuery, connection)
    'Using adapter As New MySqlDataAdapter(command)
    ' Llenar el DataTable con los datos del adaptador
    '           adapter.Fill(dataTable)
    'End Using
    'End Using

    ' Asignar el DataTable al DataGridView
    'DataGridView1.DataSource = dataTable

    ' End Sub

    'Private Sub InitializeComponent()
    'Me.SuspendLayout()
    '
    'listadoUsuario
    '    Me.ClientSize = New System.Drawing.Size(284, 261)
    'Me.Name = "listadoUsuario"
    ' Me.ResumeLayout(False)

    'End Sub

    ' Private Sub listadoUsuario_Load(sender As Object, e As EventArgs)

    ' End Sub
End Class





