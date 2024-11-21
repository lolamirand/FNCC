<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class listUsuarios
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(listUsuarios))
        DataGridView1 = New DataGridView()
        btn_basura = New Button()
        btn_editar = New Button()
        BtnNuevoProducto = New Button()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' DataGridView1
        ' 
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Location = New Point(12, 56)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.RowTemplate.Height = 25
        DataGridView1.Size = New Size(372, 262)
        DataGridView1.TabIndex = 0
        ' 
        ' btn_basura
        ' 
        btn_basura.BackgroundImage = CType(resources.GetObject("btn_basura.BackgroundImage"), Image)
        btn_basura.BackgroundImageLayout = ImageLayout.Zoom
        btn_basura.ImageAlign = ContentAlignment.TopLeft
        btn_basura.Location = New Point(326, 6)
        btn_basura.Name = "btn_basura"
        btn_basura.Size = New Size(58, 44)
        btn_basura.TabIndex = 6
        btn_basura.UseVisualStyleBackColor = True
        ' 
        ' btn_editar
        ' 
        btn_editar.BackgroundImage = CType(resources.GetObject("btn_editar.BackgroundImage"), Image)
        btn_editar.BackgroundImageLayout = ImageLayout.Zoom
        btn_editar.ImageAlign = ContentAlignment.TopLeft
        btn_editar.Location = New Point(262, 6)
        btn_editar.Name = "btn_editar"
        btn_editar.Size = New Size(58, 44)
        btn_editar.TabIndex = 5
        btn_editar.UseVisualStyleBackColor = True
        ' 
        ' BtnNuevoProducto
        ' 
        BtnNuevoProducto.BackgroundImage = CType(resources.GetObject("BtnNuevoProducto.BackgroundImage"), Image)
        BtnNuevoProducto.BackgroundImageLayout = ImageLayout.Zoom
        BtnNuevoProducto.ImageAlign = ContentAlignment.TopLeft
        BtnNuevoProducto.Location = New Point(198, 6)
        BtnNuevoProducto.Name = "BtnNuevoProducto"
        BtnNuevoProducto.Size = New Size(58, 44)
        BtnNuevoProducto.TabIndex = 4
        BtnNuevoProducto.UseVisualStyleBackColor = True
        ' 
        ' listUsuarios
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(398, 334)
        Controls.Add(btn_basura)
        Controls.Add(btn_editar)
        Controls.Add(BtnNuevoProducto)
        Controls.Add(DataGridView1)
        Name = "listUsuarios"
        StartPosition = FormStartPosition.CenterScreen
        Text = "listUsuarios"
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents btn_basura As Button
    Friend WithEvents btn_editar As Button
    Friend WithEvents BtnNuevoProducto As Button
End Class
