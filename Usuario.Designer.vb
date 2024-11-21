<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmUsuario
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
        Label2 = New Label()
        Label1 = New Label()
        txtContrasenia = New TextBox()
        txtUsuario = New TextBox()
        btnCancelar = New Button()
        btnGuardar = New Button()
        TxtIdUsuario = New TextBox()
        lblTitulo = New Label()
        SuspendLayout()
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label2.Location = New Point(178, 155)
        Label2.Name = "Label2"
        Label2.Size = New Size(92, 21)
        Label2.TabIndex = 9
        Label2.Text = "Contraseña:"' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label1.Location = New Point(203, 113)
        Label1.Name = "Label1"
        Label1.Size = New Size(67, 21)
        Label1.TabIndex = 8
        Label1.Text = "Usuario:"' 
        ' txtContrasenia
        ' 
        txtContrasenia.Location = New Point(291, 153)
        txtContrasenia.Name = "txtContrasenia"
        txtContrasenia.PasswordChar = "*"c
        txtContrasenia.Size = New Size(100, 23)
        txtContrasenia.TabIndex = 7
        txtContrasenia.UseSystemPasswordChar = True
        ' 
        ' txtUsuario
        ' 
        txtUsuario.Location = New Point(291, 113)
        txtUsuario.Name = "txtUsuario"
        txtUsuario.Size = New Size(100, 23)
        txtUsuario.TabIndex = 6
        ' 
        ' btnCancelar
        ' 
        btnCancelar.BackColor = Color.MidnightBlue
        btnCancelar.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        btnCancelar.ForeColor = SystemColors.ButtonFace
        btnCancelar.Location = New Point(178, 209)
        btnCancelar.Name = "btnCancelar"
        btnCancelar.Size = New Size(100, 40)
        btnCancelar.TabIndex = 29
        btnCancelar.Text = "Cancelar"
        btnCancelar.UseVisualStyleBackColor = False
        ' 
        ' btnGuardar
        ' 
        btnGuardar.BackColor = Color.MidnightBlue
        btnGuardar.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        btnGuardar.ForeColor = SystemColors.ButtonFace
        btnGuardar.Location = New Point(291, 209)
        btnGuardar.Name = "btnGuardar"
        btnGuardar.Size = New Size(100, 40)
        btnGuardar.TabIndex = 28
        btnGuardar.Text = "Guardar"
        btnGuardar.UseVisualStyleBackColor = False
        ' 
        ' TxtIdUsuario
        ' 
        TxtIdUsuario.Location = New Point(493, 12)
        TxtIdUsuario.Name = "TxtIdUsuario"
        TxtIdUsuario.Size = New Size(100, 23)
        TxtIdUsuario.TabIndex = 30
        TxtIdUsuario.Visible = False
        ' 
        ' lblTitulo
        ' 
        lblTitulo.AutoSize = True
        lblTitulo.Font = New Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point)
        lblTitulo.Location = New Point(225, 48)
        lblTitulo.Name = "lblTitulo"
        lblTitulo.Size = New Size(110, 32)
        lblTitulo.TabIndex = 31
        lblTitulo.Text = "SIGN UP"' 
        ' frmUsuario
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(605, 322)
        Controls.Add(lblTitulo)
        Controls.Add(TxtIdUsuario)
        Controls.Add(btnCancelar)
        Controls.Add(btnGuardar)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(txtContrasenia)
        Controls.Add(txtUsuario)
        Name = "frmUsuario"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Usuario"
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtContrasenia As TextBox
    Friend WithEvents txtUsuario As TextBox
    Friend WithEvents btnCancelar As Button
    Friend WithEvents btnGuardar As Button
    Friend WithEvents TxtIdUsuario As TextBox
    Friend WithEvents lblTitulo As Label
End Class
