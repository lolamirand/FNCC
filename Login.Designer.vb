<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Login
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
        lbl_Nombre = New Label()
        lbl_contrasenia = New Label()
        txtUsuario = New TextBox()
        txtContrasenia = New TextBox()
        lblAceptar = New Button()
        btnCancelar = New Button()
        lbl_login = New Label()
        SuspendLayout()
        ' 
        ' lbl_Nombre
        ' 
        lbl_Nombre.AutoSize = True
        lbl_Nombre.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        lbl_Nombre.Location = New Point(205, 98)
        lbl_Nombre.Name = "lbl_Nombre"
        lbl_Nombre.Size = New Size(67, 21)
        lbl_Nombre.TabIndex = 0
        lbl_Nombre.Text = "Usuario:"' 
        ' lbl_contrasenia
        ' 
        lbl_contrasenia.AutoSize = True
        lbl_contrasenia.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        lbl_contrasenia.Location = New Point(180, 138)
        lbl_contrasenia.Name = "lbl_contrasenia"
        lbl_contrasenia.Size = New Size(92, 21)
        lbl_contrasenia.TabIndex = 1
        lbl_contrasenia.Text = "Contraseña:"' 
        ' txtUsuario
        ' 
        txtUsuario.Font = New Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        txtUsuario.Location = New Point(292, 97)
        txtUsuario.Name = "txtUsuario"
        txtUsuario.Size = New Size(106, 22)
        txtUsuario.TabIndex = 1
        ' 
        ' txtContrasenia
        ' 
        txtContrasenia.Font = New Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        txtContrasenia.Location = New Point(292, 137)
        txtContrasenia.Name = "txtContrasenia"
        txtContrasenia.PasswordChar = "*"c
        txtContrasenia.Size = New Size(106, 22)
        txtContrasenia.TabIndex = 2
        txtContrasenia.UseSystemPasswordChar = True
        ' 
        ' lblAceptar
        ' 
        lblAceptar.BackColor = Color.MidnightBlue
        lblAceptar.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        lblAceptar.ForeColor = SystemColors.ButtonFace
        lblAceptar.Location = New Point(298, 194)
        lblAceptar.Name = "lblAceptar"
        lblAceptar.Size = New Size(100, 40)
        lblAceptar.TabIndex = 3
        lblAceptar.Text = "Aceptar"
        lblAceptar.UseVisualStyleBackColor = False
        ' 
        ' btnCancelar
        ' 
        btnCancelar.BackColor = Color.MidnightBlue
        btnCancelar.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        btnCancelar.ForeColor = SystemColors.ButtonFace
        btnCancelar.Location = New Point(180, 194)
        btnCancelar.Name = "btnCancelar"
        btnCancelar.Size = New Size(100, 40)
        btnCancelar.TabIndex = 5
        btnCancelar.Text = "Cancelar"
        btnCancelar.UseVisualStyleBackColor = False
        ' 
        ' lbl_login
        ' 
        lbl_login.AutoSize = True
        lbl_login.Font = New Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point)
        lbl_login.Location = New Point(253, 36)
        lbl_login.Name = "lbl_login"
        lbl_login.Size = New Size(87, 32)
        lbl_login.TabIndex = 6
        lbl_login.Text = "LOGIN"' 
        ' Login
        ' 
        AutoScaleDimensions = New SizeF(6F, 13F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(605, 322)
        Controls.Add(lbl_login)
        Controls.Add(btnCancelar)
        Controls.Add(lblAceptar)
        Controls.Add(txtContrasenia)
        Controls.Add(txtUsuario)
        Controls.Add(lbl_contrasenia)
        Controls.Add(lbl_Nombre)
        Font = New Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point)
        Name = "Login"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Login"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lbl_Nombre As Label
    Friend WithEvents lbl_contrasenia As Label
    Friend WithEvents txtUsuario As TextBox
    Friend WithEvents txtContrasenia As TextBox
    Friend WithEvents lblAceptar As Button
    Friend WithEvents btnCancelar As Button
    Friend WithEvents lbl_login As Label
End Class
