<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddTemplateForm
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
        Me.Cancel = New System.Windows.Forms.Button()
        Me.OK = New System.Windows.Forms.Button()
        Me.DisplayTextBox = New System.Windows.Forms.TextBox()
        Me.TemplateBox = New System.Windows.Forms.TextBox()
        Me.DisplayTextLabel = New System.Windows.Forms.Label()
        Me.TemplateLabel = New System.Windows.Forms.Label()
        Me.TemplateEnd = New System.Windows.Forms.Label()
        Me.TemplateStart = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Cancel
        '
        Me.Cancel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Cancel.Location = New System.Drawing.Point(335, 78)
        Me.Cancel.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Cancel.Name = "Cancel"
        Me.Cancel.Size = New System.Drawing.Size(100, 28)
        Me.Cancel.TabIndex = 7
        Me.Cancel.Text = "Cancel"
        Me.Cancel.UseVisualStyleBackColor = True
        '
        'OK
        '
        Me.OK.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.OK.Enabled = False
        Me.OK.Location = New System.Drawing.Point(227, 78)
        Me.OK.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.OK.Name = "OK"
        Me.OK.Size = New System.Drawing.Size(100, 28)
        Me.OK.TabIndex = 6
        Me.OK.Text = "OK"
        Me.OK.UseVisualStyleBackColor = True
        '
        'DisplayTextBox
        '
        Me.DisplayTextBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DisplayTextBox.Location = New System.Drawing.Point(109, 15)
        Me.DisplayTextBox.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.DisplayTextBox.Name = "DisplayTextBox"
        Me.DisplayTextBox.Size = New System.Drawing.Size(324, 22)
        Me.DisplayTextBox.TabIndex = 1
        '
        'TemplateBox
        '
        Me.TemplateBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TemplateBox.Location = New System.Drawing.Point(164, 50)
        Me.TemplateBox.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TemplateBox.Name = "TemplateBox"
        Me.TemplateBox.Size = New System.Drawing.Size(245, 22)
        Me.TemplateBox.TabIndex = 4
        '
        'DisplayTextLabel
        '
        Me.DisplayTextLabel.AutoSize = True
        Me.DisplayTextLabel.Location = New System.Drawing.Point(16, 18)
        Me.DisplayTextLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.DisplayTextLabel.Name = "DisplayTextLabel"
        Me.DisplayTextLabel.Size = New System.Drawing.Size(84, 17)
        Me.DisplayTextLabel.TabIndex = 0
        Me.DisplayTextLabel.Text = "Display text:"
        '
        'TemplateLabel
        '
        Me.TemplateLabel.AutoSize = True
        Me.TemplateLabel.Location = New System.Drawing.Point(29, 50)
        Me.TemplateLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.TemplateLabel.Name = "TemplateLabel"
        Me.TemplateLabel.Size = New System.Drawing.Size(71, 17)
        Me.TemplateLabel.TabIndex = 2
        Me.TemplateLabel.Text = "Template:"
        '
        'TemplateEnd
        '
        Me.TemplateEnd.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TemplateEnd.AutoSize = True
        Me.TemplateEnd.Location = New System.Drawing.Point(415, 50)
        Me.TemplateEnd.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.TemplateEnd.Name = "TemplateEnd"
        Me.TemplateEnd.Size = New System.Drawing.Size(18, 17)
        Me.TemplateEnd.TabIndex = 5
        Me.TemplateEnd.Text = "}}"
        '
        'TemplateStart
        '
        Me.TemplateStart.AutoSize = True
        Me.TemplateStart.Location = New System.Drawing.Point(109, 50)
        Me.TemplateStart.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.TemplateStart.Name = "TemplateStart"
        Me.TemplateStart.Size = New System.Drawing.Size(56, 17)
        Me.TemplateStart.TabIndex = 3
        Me.TemplateStart.Text = "{{subst:"
        '
        'AddTemplateForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(451, 119)
        Me.Controls.Add(Me.TemplateEnd)
        Me.Controls.Add(Me.TemplateStart)
        Me.Controls.Add(Me.TemplateLabel)
        Me.Controls.Add(Me.DisplayTextLabel)
        Me.Controls.Add(Me.TemplateBox)
        Me.Controls.Add(Me.DisplayTextBox)
        Me.Controls.Add(Me.OK)
        Me.Controls.Add(Me.Cancel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.KeyPreview = True
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "AddTemplateForm"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Add template"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Private WithEvents Cancel As System.Windows.Forms.Button
    Private WithEvents OK As System.Windows.Forms.Button
    Private WithEvents DisplayTextBox As System.Windows.Forms.TextBox
    Private WithEvents TemplateBox As System.Windows.Forms.TextBox
    Private WithEvents DisplayTextLabel As System.Windows.Forms.Label
    Private WithEvents TemplateLabel As System.Windows.Forms.Label
    Private WithEvents TemplateEnd As System.Windows.Forms.Label
    Private WithEvents TemplateStart As System.Windows.Forms.Label
End Class
