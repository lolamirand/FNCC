<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmProducto
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        txtNombre = New TextBox()
        txtPrecio = New TextBox()
        Label1 = New Label()
        Label2 = New Label()
        btnCancelar = New Button()
        btnGuardar = New Button()
        Lbl_foto = New Label()
        txtFoto = New TextBox()
        btn_examinar = New Button()
        pbImagen = New PictureBox()
        ofdSeleccionar = New OpenFileDialog()
        LabelStock = New Label()
        txtStock = New TextBox()
        lblTítulo = New Label()
        txtIdProducto = New TextBox()
        CType(pbImagen, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' txtNombre
        ' 
        txtNombre.Location = New Point(415, 64)
        txtNombre.Name = "txtNombre"
        txtNombre.Size = New Size(100, 23)
        txtNombre.TabIndex = 1
        ' 
        ' txtPrecio
        ' 
        txtPrecio.Location = New Point(415, 136)
        txtPrecio.Name = "txtPrecio"
        txtPrecio.Size = New Size(100, 23)
        txtPrecio.TabIndex = 3
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label1.Location = New Point(331, 62)
        Label1.Name = "Label1"
        Label1.Size = New Size(71, 21)
        Label1.TabIndex = 2
        Label1.Text = "Nombre:"' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label2.Location = New Point(346, 134)
        Label2.Name = "Label2"
        Label2.Size = New Size(56, 21)
        Label2.TabIndex = 3
        Label2.Text = "Precio:"' 
        ' btnCancelar
        ' 
        btnCancelar.BackColor = Color.MidnightBlue
        btnCancelar.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        btnCancelar.ForeColor = SystemColors.ButtonFace
        btnCancelar.Location = New Point(434, 221)
        btnCancelar.Name = "btnCancelar"
        btnCancelar.Size = New Size(100, 40)
        btnCancelar.TabIndex = 31
        btnCancelar.Text = "Cancelar"
        btnCancelar.UseVisualStyleBackColor = False
        ' 
        ' btnGuardar
        ' 
        btnGuardar.BackColor = Color.MidnightBlue
        btnGuardar.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        btnGuardar.ForeColor = SystemColors.ButtonFace
        btnGuardar.Location = New Point(582, 221)
        btnGuardar.Name = "btnGuardar"
        btnGuardar.Size = New Size(100, 40)
        btnGuardar.TabIndex = 30
        btnGuardar.Text = "Guardar"
        btnGuardar.UseVisualStyleBackColor = False
        ' 
        ' Lbl_foto
        ' 
        Lbl_foto.AutoSize = True
        Lbl_foto.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Lbl_foto.Location = New Point(358, 171)
        Lbl_foto.Name = "Lbl_foto"
        Lbl_foto.Size = New Size(44, 21)
        Lbl_foto.TabIndex = 32
        Lbl_foto.Text = "Foto:"' 
        ' txtFoto
        ' 
        txtFoto.Location = New Point(415, 173)
        txtFoto.Name = "txtFoto"
        txtFoto.Size = New Size(303, 23)
        txtFoto.TabIndex = 33
        ' 
        ' btn_examinar
        ' 
        btn_examinar.BackColor = SystemColors.ActiveCaption
        btn_examinar.Location = New Point(724, 173)
        btn_examinar.Name = "btn_examinar"
        btn_examinar.Size = New Size(75, 23)
        btn_examinar.TabIndex = 34
        btn_examinar.Text = "..."
        btn_examinar.UseVisualStyleBackColor = False
        ' 
        ' pbImagen
        ' 
        pbImagen.Location = New Point(37, 28)
        pbImagen.Name = "pbImagen"
        pbImagen.Size = New Size(261, 216)
        pbImagen.SizeMode = PictureBoxSizeMode.StretchImage
        pbImagen.TabIndex = 35
        pbImagen.TabStop = False
        ' 
        ' ofdSeleccionar
        ' 
        ofdSeleccionar.FileName = "OpenFileDialog1"' 
        ' LabelStock
        ' 
        LabelStock.AutoSize = True
        LabelStock.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        LabelStock.Location = New Point(352, 97)
        LabelStock.Name = "LabelStock"
        LabelStock.Size = New Size(50, 21)
        LabelStock.TabIndex = 36
        LabelStock.Text = "Stock:"' 
        ' txtStock
        ' 
        txtStock.Location = New Point(415, 99)
        txtStock.Name = "txtStock"
        txtStock.Size = New Size(100, 23)
        txtStock.TabIndex = 2
        ' 
        ' lblTítulo
        ' 
        lblTítulo.AutoSize = True
        lblTítulo.BackColor = Color.Transparent
        lblTítulo.Font = New Font("Sitka Subheading", 15.75F, FontStyle.Regular, GraphicsUnit.Point)
        lblTítulo.ForeColor = SystemColors.ControlText
        lblTítulo.Location = New Point(469, 9)
        lblTítulo.Name = "lblTítulo"
        lblTítulo.Size = New Size(161, 30)
        lblTítulo.TabIndex = 38
        lblTítulo.Text = "Nuevo producto"' 
        ' txtIdProducto
        ' 
        txtIdProducto.Location = New Point(715, 16)
        txtIdProducto.Name = "txtIdProducto"
        txtIdProducto.Size = New Size(100, 23)
        txtIdProducto.TabIndex = 39
        txtIdProducto.Visible = False
        ' 
        ' frmProducto
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(838, 450)
        Controls.Add(txtIdProducto)
        Controls.Add(lblTítulo)
        Controls.Add(txtStock)
        Controls.Add(LabelStock)
        Controls.Add(pbImagen)
        Controls.Add(btn_examinar)
        Controls.Add(txtFoto)
        Controls.Add(Lbl_foto)
        Controls.Add(btnCancelar)
        Controls.Add(btnGuardar)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(txtPrecio)
        Controls.Add(txtNombre)
        Name = "frmProducto"
        StartPosition = FormStartPosition.CenterScreen
        Text = "frmProducto"
        CType(pbImagen, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents txtNombre As TextBox
    Friend WithEvents txtPrecio As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents btnCancelar As Button
    Friend WithEvents btnGuardar As Button
    Friend WithEvents Lbl_foto As Label
    Friend WithEvents txtFoto As TextBox
    Friend WithEvents btn_examinar As Button
    Friend WithEvents pbImagen As PictureBox
    Friend WithEvents ofdSeleccionar As OpenFileDialog
    Friend WithEvents LabelStock As Label
    Friend WithEvents txtStock As TextBox
    Friend WithEvents lblTítulo As Label
    Friend WithEvents txtIdProducto As TextBox
End Class
