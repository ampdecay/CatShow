<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CatShowMain
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.addEvent_Button = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.viewEvents_Button = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(218, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(335, 189)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Welcome To The DaigleSoft Cat Show Management System. Please Select from the opti" &
    "ons below."
        '
        'addEvent_Button
        '
        Me.addEvent_Button.Location = New System.Drawing.Point(21, 242)
        Me.addEvent_Button.Name = "addEvent_Button"
        Me.addEvent_Button.Size = New System.Drawing.Size(110, 37)
        Me.addEvent_Button.TabIndex = 2
        Me.addEvent_Button.Text = "Add Event"
        Me.addEvent_Button.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.CatShow.My.Resources.Resources.yuffie
        Me.PictureBox1.Location = New System.Drawing.Point(12, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(200, 200)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'viewEvents_Button
        '
        Me.viewEvents_Button.Location = New System.Drawing.Point(21, 298)
        Me.viewEvents_Button.Name = "viewEvents_Button"
        Me.viewEvents_Button.Size = New System.Drawing.Size(110, 37)
        Me.viewEvents_Button.TabIndex = 3
        Me.viewEvents_Button.Text = "View Events"
        Me.viewEvents_Button.UseVisualStyleBackColor = True
        '
        'CatShowMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(670, 469)
        Me.Controls.Add(Me.viewEvents_Button)
        Me.Controls.Add(Me.addEvent_Button)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "CatShowMain"
        Me.Text = "Cat Show"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents addEvent_Button As Button
    Friend WithEvents viewEvents_Button As Button
End Class
