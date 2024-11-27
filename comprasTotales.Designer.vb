<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class comprasTotales
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
        fechaDesde = New DateTimePicker()
        fechaHasta = New DateTimePicker()
        Label1 = New Label()
        Label2 = New Label()
        Panel1 = New Panel()
        btnBuscar = New Button()
        dataGridTotales = New DataGridView()
        Panel1.SuspendLayout()
        CType(dataGridTotales, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' fechaDesde
        ' 
        fechaDesde.Format = DateTimePickerFormat.Short
        fechaDesde.Location = New Point(109, 31)
        fechaDesde.Name = "fechaDesde"
        fechaDesde.Size = New Size(99, 23)
        fechaDesde.TabIndex = 0
        ' 
        ' fechaHasta
        ' 
        fechaHasta.CustomFormat = "yyyy-MM-dd"
        fechaHasta.Format = DateTimePickerFormat.Short
        fechaHasta.Location = New Point(382, 31)
        fechaHasta.Name = "fechaHasta"
        fechaHasta.Size = New Size(99, 23)
        fechaHasta.TabIndex = 1
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(27, 39)
        Label1.Name = "Label1"
        Label1.Size = New Size(76, 15)
        Label1.TabIndex = 2
        Label1.Text = "Fecha Desde:"' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(302, 39)
        Label2.Name = "Label2"
        Label2.Size = New Size(74, 15)
        Label2.TabIndex = 3
        Label2.Text = "Fecha Hasta:"' 
        ' Panel1
        ' 
        Panel1.BorderStyle = BorderStyle.Fixed3D
        Panel1.Controls.Add(btnBuscar)
        Panel1.Controls.Add(Label2)
        Panel1.Controls.Add(fechaDesde)
        Panel1.Controls.Add(Label1)
        Panel1.Controls.Add(fechaHasta)
        Panel1.Location = New Point(59, 28)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(660, 100)
        Panel1.TabIndex = 4
        ' 
        ' btnBuscar
        ' 
        btnBuscar.BackColor = Color.MidnightBlue
        btnBuscar.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        btnBuscar.ForeColor = SystemColors.ControlLightLight
        btnBuscar.Location = New Point(552, 31)
        btnBuscar.Name = "btnBuscar"
        btnBuscar.Size = New Size(67, 23)
        btnBuscar.TabIndex = 4
        btnBuscar.Text = "Buscar"
        btnBuscar.UseVisualStyleBackColor = False
        ' 
        ' dataGridTotales
        ' 
        dataGridTotales.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dataGridTotales.Location = New Point(59, 134)
        dataGridTotales.Name = "dataGridTotales"
        dataGridTotales.RowTemplate.Height = 25
        dataGridTotales.Size = New Size(660, 252)
        dataGridTotales.TabIndex = 5
        ' 
        ' comprasTotales
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(dataGridTotales)
        Controls.Add(Panel1)
        Name = "comprasTotales"
        Text = "comprasTotales"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(dataGridTotales, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents fechaDesde As DateTimePicker
    Friend WithEvents fechaHasta As DateTimePicker
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnBuscar As Button
    Friend WithEvents dataGridTotales As DataGridView
End Class
