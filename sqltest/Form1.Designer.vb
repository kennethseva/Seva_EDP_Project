<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.check_btn = New System.Windows.Forms.Button()
        Me.fname_box = New System.Windows.Forms.TextBox()
        Me.lname_box = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.log_btn = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'check_btn
        '
        Me.check_btn.Location = New System.Drawing.Point(12, 147)
        Me.check_btn.Name = "check_btn"
        Me.check_btn.Size = New System.Drawing.Size(302, 43)
        Me.check_btn.TabIndex = 4
        Me.check_btn.Text = "Test Connection Sql Connection"
        Me.check_btn.UseVisualStyleBackColor = True
        '
        'fname_box
        '
        Me.fname_box.Location = New System.Drawing.Point(130, 52)
        Me.fname_box.Name = "fname_box"
        Me.fname_box.Size = New System.Drawing.Size(184, 22)
        Me.fname_box.TabIndex = 1
        '
        'lname_box
        '
        Me.lname_box.Location = New System.Drawing.Point(130, 80)
        Me.lname_box.Name = "lname_box"
        Me.lname_box.Size = New System.Drawing.Size(184, 22)
        Me.lname_box.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(14, 55)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(72, 16)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "First Name"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 83)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(72, 16)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Last Name"
        '
        'log_btn
        '
        Me.log_btn.Location = New System.Drawing.Point(12, 108)
        Me.log_btn.Name = "log_btn"
        Me.log_btn.Size = New System.Drawing.Size(302, 33)
        Me.log_btn.TabIndex = 3
        Me.log_btn.Text = "Log In"
        Me.log_btn.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(12, 9)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(309, 29)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Please Login to proceed"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(326, 207)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.log_btn)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lname_box)
        Me.Controls.Add(Me.fname_box)
        Me.Controls.Add(Me.check_btn)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Please Login"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents check_btn As Button
    Friend WithEvents fname_box As TextBox
    Friend WithEvents lname_box As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents log_btn As Button
    Friend WithEvents Label3 As Label
End Class
