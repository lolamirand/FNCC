<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class listadoProducto
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(listadoProducto))
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.BtnNuevoProducto = New System.Windows.Forms.Button()
        Me.btn_editar = New System.Windows.Forms.Button()
        Me.btn_basura = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(12, 51)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowTemplate.Height = 25
        Me.DataGridView1.Size = New System.Drawing.Size(776, 352)
        Me.DataGridView1.TabIndex = 0
        '
        'BtnNuevoProducto
        '
        Me.BtnNuevoProducto.BackgroundImage = CType(resources.GetObject("BtnNuevoProducto.BackgroundImage"), System.Drawing.Image)
        Me.BtnNuevoProducto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.BtnNuevoProducto.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.BtnNuevoProducto.Location = New System.Drawing.Point(591, 1)
        Me.BtnNuevoProducto.Name = "BtnNuevoProducto"
        Me.BtnNuevoProducto.Size = New System.Drawing.Size(58, 44)
        Me.BtnNuevoProducto.TabIndex = 1
        Me.BtnNuevoProducto.UseVisualStyleBackColor = True
        '
        'btn_editar
        '
        Me.btn_editar.BackgroundImage = CType(resources.GetObject("btn_editar.BackgroundImage"), System.Drawing.Image)
        Me.btn_editar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btn_editar.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.btn_editar.Location = New System.Drawing.Point(656, 1)
        Me.btn_editar.Name = "btn_editar"
        Me.btn_editar.Size = New System.Drawing.Size(58, 44)
        Me.btn_editar.TabIndex = 2
        Me.btn_editar.UseVisualStyleBackColor = True
        '
        'btn_basura
        '
        Me.btn_basura.BackgroundImage = CType(resources.GetObject("btn_basura.BackgroundImage"), System.Drawing.Image)
        Me.btn_basura.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btn_basura.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.btn_basura.Location = New System.Drawing.Point(719, 1)
        Me.btn_basura.Name = "btn_basura"
        Me.btn_basura.Size = New System.Drawing.Size(58, 44)
        Me.btn_basura.TabIndex = 3
        Me.btn_basura.UseVisualStyleBackColor = True
        '
        'listadoProducto
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btn_basura)
        Me.Controls.Add(Me.btn_editar)
        Me.Controls.Add(Me.BtnNuevoProducto)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "listadoProducto"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "listadoProducto"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents BtnNuevoProducto As Button
    Friend WithEvents btn_editar As Button
    Friend WithEvents btn_basura As Button
End Class
