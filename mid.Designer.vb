<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmIngresar
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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.usuario = New System.Windows.Forms.ToolStripMenuItem()
        Me.producto = New System.Windows.Forms.ToolStripMenuItem()
        Me.compras = New System.Windows.Forms.ToolStripMenuItem()
        Me.CONSULTASToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.COMPRASPORDIAToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TOTALESToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.usuario, Me.producto, Me.compras, Me.CONSULTASToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(800, 24)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'usuario
        '
        Me.usuario.Name = "usuario"
        Me.usuario.Size = New System.Drawing.Size(68, 20)
        Me.usuario.Text = "USUARIO"
        '
        'producto
        '
        Me.producto.Name = "producto"
        Me.producto.Size = New System.Drawing.Size(80, 20)
        Me.producto.Text = "PRODUCTO"
        '
        'compras
        '
        Me.compras.Name = "compras"
        Me.compras.Size = New System.Drawing.Size(75, 20)
        Me.compras.Text = "COMPRAS"
        '
        'CONSULTASToolStripMenuItem
        '
        Me.CONSULTASToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.COMPRASPORDIAToolStripMenuItem, Me.TOTALESToolStripMenuItem})
        Me.CONSULTASToolStripMenuItem.Name = "CONSULTASToolStripMenuItem"
        Me.CONSULTASToolStripMenuItem.Size = New System.Drawing.Size(83, 20)
        Me.CONSULTASToolStripMenuItem.Text = "CONSULTAS"
        '
        'COMPRASPORDIAToolStripMenuItem
        '
        Me.COMPRASPORDIAToolStripMenuItem.Name = "COMPRASPORDIAToolStripMenuItem"
        Me.COMPRASPORDIAToolStripMenuItem.Size = New System.Drawing.Size(196, 22)
        Me.COMPRASPORDIAToolStripMenuItem.Text = "COMPRAS POR FECHA"
        '
        'TOTALESToolStripMenuItem
        '
        Me.TOTALESToolStripMenuItem.Name = "TOTALESToolStripMenuItem"
        Me.TOTALESToolStripMenuItem.Size = New System.Drawing.Size(196, 22)
        Me.TOTALESToolStripMenuItem.Text = "TOTALES"
        '
        'frmIngresar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7!, 15!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.MenuStrip1)
        Me.IsMdiContainer = true
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frmIngresar"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip1.ResumeLayout(false)
        Me.MenuStrip1.PerformLayout
        Me.ResumeLayout(false)
        Me.PerformLayout

End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents usuario As ToolStripMenuItem
    Friend WithEvents producto As ToolStripMenuItem
    Friend WithEvents compras As ToolStripMenuItem
    Friend WithEvents CONSULTASToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents COMPRASPORDIAToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TOTALESToolStripMenuItem As ToolStripMenuItem
End Class
