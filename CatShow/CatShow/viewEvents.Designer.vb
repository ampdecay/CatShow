<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class viewEvents
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.eventsGrid = New System.Windows.Forms.DataGridView()
        CType(Me.eventsGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'eventsGrid
        '
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.Gainsboro
        Me.eventsGrid.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.eventsGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.eventsGrid.Dock = System.Windows.Forms.DockStyle.Fill
        Me.eventsGrid.Location = New System.Drawing.Point(0, 0)
        Me.eventsGrid.Name = "eventsGrid"
        Me.eventsGrid.RowTemplate.ReadOnly = True
        Me.eventsGrid.Size = New System.Drawing.Size(499, 228)
        Me.eventsGrid.TabIndex = 0
        '
        'viewEvents
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(499, 228)
        Me.Controls.Add(Me.eventsGrid)
        Me.Name = "viewEvents"
        Me.Text = "viewEvents"
        CType(Me.eventsGrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents eventsGrid As DataGridView
End Class
