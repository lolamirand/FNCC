<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmCompras
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
        panelComprar = New Panel()
        Label3 = New Label()
        Label2 = New Label()
        Label1 = New Label()
        panelComprar.SuspendLayout()
        SuspendLayout()
        ' 
        ' panelComprar
        ' 
        panelComprar.Controls.Add(Label3)
        panelComprar.Controls.Add(Label2)
        panelComprar.Controls.Add(Label1)
        panelComprar.Location = New Point(30, 24)
        panelComprar.Name = "panelComprar"
        panelComprar.Size = New Size(674, 380)
        panelComprar.TabIndex = 0
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(423, 0)
        Label3.Name = "Label3"
        Label3.Size = New Size(32, 15)
        Label3.TabIndex = 2
        Label3.Text = "Total"' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(241, 0)
        Label2.Name = "Label2"
        Label2.Size = New Size(40, 15)
        Label2.TabIndex = 1
        Label2.Text = "Precio"' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(327, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(55, 15)
        Label1.TabIndex = 0
        Label1.Text = "Cantidad"' 
        ' frmCompras
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(736, 450)
        Controls.Add(panelComprar)
        Name = "frmCompras"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Compras"
        panelComprar.ResumeLayout(False)
        panelComprar.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents panelComprar As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
End Class
