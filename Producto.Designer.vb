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
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.txtPrecio = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.Lbl_foto = New System.Windows.Forms.Label()
        Me.txtFoto = New System.Windows.Forms.TextBox()
        Me.btn_examinar = New System.Windows.Forms.Button()
        Me.pbImagen = New System.Windows.Forms.PictureBox()
        Me.ofdSeleccionar = New System.Windows.Forms.OpenFileDialog()
        Me.LabelStock = New System.Windows.Forms.Label()
        Me.txtStock = New System.Windows.Forms.TextBox()
        Me.lblTítulo = New System.Windows.Forms.Label()
        Me.txtIdProducto = New System.Windows.Forms.TextBox()
        CType(Me.pbImagen, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtNombre
        '
        Me.txtNombre.Location = New System.Drawing.Point(415, 64)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(100, 23)
        Me.txtNombre.TabIndex = 1
        '
        'txtPrecio
        '
        Me.txtPrecio.Location = New System.Drawing.Point(415, 136)
        Me.txtPrecio.Name = "txtPrecio"
        Me.txtPrecio.Size = New System.Drawing.Size(100, 23)
        Me.txtPrecio.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(331, 62)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(71, 21)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Nombre:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label2.Location = New System.Drawing.Point(346, 134)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(56, 21)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Precio:"
        '
        'btnCancelar
        '
        Me.btnCancelar.BackColor = System.Drawing.Color.MidnightBlue
        Me.btnCancelar.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnCancelar.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.btnCancelar.Location = New System.Drawing.Point(434, 221)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(100, 40)
        Me.btnCancelar.TabIndex = 31
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = False
        '
        'btnGuardar
        '
        Me.btnGuardar.BackColor = System.Drawing.Color.MidnightBlue
        Me.btnGuardar.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnGuardar.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.btnGuardar.Location = New System.Drawing.Point(582, 221)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(100, 40)
        Me.btnGuardar.TabIndex = 30
        Me.btnGuardar.Text = "Guardar"
        Me.btnGuardar.UseVisualStyleBackColor = False
        '
        'Lbl_foto
        '
        Me.Lbl_foto.AutoSize = True
        Me.Lbl_foto.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Lbl_foto.Location = New System.Drawing.Point(358, 171)
        Me.Lbl_foto.Name = "Lbl_foto"
        Me.Lbl_foto.Size = New System.Drawing.Size(44, 21)
        Me.Lbl_foto.TabIndex = 32
        Me.Lbl_foto.Text = "Foto:"
        '
        'txtFoto
        '
        Me.txtFoto.Location = New System.Drawing.Point(415, 173)
        Me.txtFoto.Name = "txtFoto"
        Me.txtFoto.Size = New System.Drawing.Size(303, 23)
        Me.txtFoto.TabIndex = 33
        '
        'btn_examinar
        '
        Me.btn_examinar.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.btn_examinar.Location = New System.Drawing.Point(724, 173)
        Me.btn_examinar.Name = "btn_examinar"
        Me.btn_examinar.Size = New System.Drawing.Size(75, 23)
        Me.btn_examinar.TabIndex = 34
        Me.btn_examinar.Text = "..."
        Me.btn_examinar.UseVisualStyleBackColor = False
        '
        'pbImagen
        '
        Me.pbImagen.Location = New System.Drawing.Point(37, 28)
        Me.pbImagen.Name = "pbImagen"
        Me.pbImagen.Size = New System.Drawing.Size(261, 216)
        Me.pbImagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbImagen.TabIndex = 35
        Me.pbImagen.TabStop = False
        '
        'ofdSeleccionar
        '
        Me.ofdSeleccionar.FileName = "OpenFileDialog1"
        '
        'LabelStock
        '
        Me.LabelStock.AutoSize = True
        Me.LabelStock.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.LabelStock.Location = New System.Drawing.Point(352, 97)
        Me.LabelStock.Name = "LabelStock"
        Me.LabelStock.Size = New System.Drawing.Size(50, 21)
        Me.LabelStock.TabIndex = 36
        Me.LabelStock.Text = "Stock:"
        '
        'txtStock
        '
        Me.txtStock.Location = New System.Drawing.Point(415, 99)
        Me.txtStock.Name = "txtStock"
        Me.txtStock.Size = New System.Drawing.Size(100, 23)
        Me.txtStock.TabIndex = 2
        '
        'lblTítulo
        '
        Me.lblTítulo.AutoSize = True
        Me.lblTítulo.BackColor = System.Drawing.Color.Transparent
        Me.lblTítulo.Font = New System.Drawing.Font("Sitka Subheading", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblTítulo.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblTítulo.Location = New System.Drawing.Point(469, 9)
        Me.lblTítulo.Name = "lblTítulo"
        Me.lblTítulo.Size = New System.Drawing.Size(161, 30)
        Me.lblTítulo.TabIndex = 38
        Me.lblTítulo.Text = "Nuevo producto"
        '
        'txtIdProducto
        '
        Me.txtIdProducto.Location = New System.Drawing.Point(715, 16)
        Me.txtIdProducto.Name = "txtIdProducto"
        Me.txtIdProducto.Size = New System.Drawing.Size(100, 23)
        Me.txtIdProducto.TabIndex = 39
        Me.txtIdProducto.Visible = False
        '
        'frmProducto
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(838, 450)
        Me.Controls.Add(Me.txtIdProducto)
        Me.Controls.Add(Me.lblTítulo)
        Me.Controls.Add(Me.txtStock)
        Me.Controls.Add(Me.LabelStock)
        Me.Controls.Add(Me.pbImagen)
        Me.Controls.Add(Me.btn_examinar)
        Me.Controls.Add(Me.txtFoto)
        Me.Controls.Add(Me.Lbl_foto)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.btnGuardar)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtPrecio)
        Me.Controls.Add(Me.txtNombre)
        Me.Name = "frmProducto"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmProducto"
        CType(Me.pbImagen, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

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
