
<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class AddEventForm
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
        Me.EventidDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LocationDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.eventID_Box = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.genID_Button = New System.Windows.Forms.Button()
        Me.location_box = New System.Windows.Forms.RichTextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.date_selector = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.addEvent_button = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'EventidDataGridViewTextBoxColumn
        '
        Me.EventidDataGridViewTextBoxColumn.DataPropertyName = "event_id"
        Me.EventidDataGridViewTextBoxColumn.HeaderText = "event_id"
        Me.EventidDataGridViewTextBoxColumn.Name = "EventidDataGridViewTextBoxColumn"
        '
        'LocationDataGridViewTextBoxColumn
        '
        Me.LocationDataGridViewTextBoxColumn.DataPropertyName = "location"
        Me.LocationDataGridViewTextBoxColumn.HeaderText = "location"
        Me.LocationDataGridViewTextBoxColumn.Name = "LocationDataGridViewTextBoxColumn"
        '
        'DateDataGridViewTextBoxColumn
        '
        Me.DateDataGridViewTextBoxColumn.DataPropertyName = "date"
        Me.DateDataGridViewTextBoxColumn.HeaderText = "date"
        Me.DateDataGridViewTextBoxColumn.Name = "DateDataGridViewTextBoxColumn"
        '
        'eventID_Box
        '
        Me.eventID_Box.Location = New System.Drawing.Point(12, 38)
        Me.eventID_Box.Name = "eventID_Box"
        Me.eventID_Box.ReadOnly = True
        Me.eventID_Box.Size = New System.Drawing.Size(100, 20)
        Me.eventID_Box.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 19)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(49, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Event ID"
        '
        'genID_Button
        '
        Me.genID_Button.Location = New System.Drawing.Point(133, 38)
        Me.genID_Button.Name = "genID_Button"
        Me.genID_Button.Size = New System.Drawing.Size(75, 23)
        Me.genID_Button.TabIndex = 4
        Me.genID_Button.Text = "Create ID"
        Me.genID_Button.UseVisualStyleBackColor = True
        '
        'location_box
        '
        Me.location_box.Location = New System.Drawing.Point(12, 106)
        Me.location_box.Name = "location_box"
        Me.location_box.Size = New System.Drawing.Size(196, 96)
        Me.location_box.TabIndex = 5
        Me.location_box.Text = ""
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 84)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(79, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Event Location"
        '
        'date_selector
        '
        Me.date_selector.CustomFormat = ""
        Me.date_selector.Location = New System.Drawing.Point(12, 241)
        Me.date_selector.Name = "date_selector"
        Me.date_selector.Size = New System.Drawing.Size(200, 20)
        Me.date_selector.TabIndex = 7
        Me.date_selector.Value = New Date(2017, 4, 17, 0, 0, 0, 0)
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 225)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(61, 13)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Event Date"
        '
        'addEvent_button
        '
        Me.addEvent_button.Location = New System.Drawing.Point(12, 297)
        Me.addEvent_button.Name = "addEvent_button"
        Me.addEvent_button.Size = New System.Drawing.Size(75, 23)
        Me.addEvent_button.TabIndex = 9
        Me.addEvent_button.Text = "Add Event"
        Me.addEvent_button.UseVisualStyleBackColor = True
        '
        'AddEventForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(254, 359)
        Me.Controls.Add(Me.addEvent_button)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.date_selector)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.location_box)
        Me.Controls.Add(Me.genID_Button)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.eventID_Box)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Name = "AddEventForm"
        Me.Text = "Add Event"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents EventidDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents LocationDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DateDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents eventID_Box As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents genID_Button As Button
    Friend WithEvents location_box As RichTextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents date_selector As DateTimePicker
    Friend WithEvents Label1 As Label
    Friend WithEvents addEvent_button As Button
End Class
