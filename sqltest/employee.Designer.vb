<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class employee
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
        Me.employee_list = New System.Windows.Forms.ListView()
        Me.fname = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.lname = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.profession = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.datestart = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.test_btn = New System.Windows.Forms.Button()
        Me.refresh_btn = New System.Windows.Forms.Button()
        Me.Button1profession_btn = New System.Windows.Forms.Button()
        Me.manage_btn = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'employee_list
        '
        Me.employee_list.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.fname, Me.lname, Me.profession, Me.datestart})
        Me.employee_list.FullRowSelect = True
        Me.employee_list.GridLines = True
        Me.employee_list.HideSelection = False
        Me.employee_list.Location = New System.Drawing.Point(12, 12)
        Me.employee_list.Name = "employee_list"
        Me.employee_list.Size = New System.Drawing.Size(1006, 323)
        Me.employee_list.TabIndex = 0
        Me.employee_list.UseCompatibleStateImageBehavior = False
        Me.employee_list.View = System.Windows.Forms.View.Details
        '
        'fname
        '
        Me.fname.Text = "First Name"
        Me.fname.Width = 250
        '
        'lname
        '
        Me.lname.Text = "Last Name"
        Me.lname.Width = 250
        '
        'profession
        '
        Me.profession.Text = "Professions"
        Me.profession.Width = 250
        '
        'datestart
        '
        Me.datestart.Text = "Date Started Working"
        Me.datestart.Width = 250
        '
        'test_btn
        '
        Me.test_btn.Location = New System.Drawing.Point(12, 341)
        Me.test_btn.Name = "test_btn"
        Me.test_btn.Size = New System.Drawing.Size(173, 44)
        Me.test_btn.TabIndex = 1
        Me.test_btn.Text = "Test Connection"
        Me.test_btn.UseVisualStyleBackColor = True
        '
        'refresh_btn
        '
        Me.refresh_btn.Location = New System.Drawing.Point(191, 341)
        Me.refresh_btn.Name = "refresh_btn"
        Me.refresh_btn.Size = New System.Drawing.Size(201, 43)
        Me.refresh_btn.TabIndex = 2
        Me.refresh_btn.Text = "Refresh"
        Me.refresh_btn.UseVisualStyleBackColor = True
        '
        'Button1profession_btn
        '
        Me.Button1profession_btn.Location = New System.Drawing.Point(398, 341)
        Me.Button1profession_btn.Name = "Button1profession_btn"
        Me.Button1profession_btn.Size = New System.Drawing.Size(301, 41)
        Me.Button1profession_btn.TabIndex = 3
        Me.Button1profession_btn.Text = "Manage Profession Data"
        Me.Button1profession_btn.UseVisualStyleBackColor = True
        '
        'manage_btn
        '
        Me.manage_btn.Location = New System.Drawing.Point(705, 341)
        Me.manage_btn.Name = "manage_btn"
        Me.manage_btn.Size = New System.Drawing.Size(314, 40)
        Me.manage_btn.TabIndex = 4
        Me.manage_btn.Text = "Manage This Data"
        Me.manage_btn.UseVisualStyleBackColor = True
        '
        'employee
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1031, 394)
        Me.Controls.Add(Me.manage_btn)
        Me.Controls.Add(Me.Button1profession_btn)
        Me.Controls.Add(Me.refresh_btn)
        Me.Controls.Add(Me.test_btn)
        Me.Controls.Add(Me.employee_list)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "employee"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Current Employee"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents employee_list As ListView
    Friend WithEvents fname As ColumnHeader
    Friend WithEvents lname As ColumnHeader
    Friend WithEvents profession As ColumnHeader
    Friend WithEvents datestart As ColumnHeader
    Friend WithEvents test_btn As Button
    Friend WithEvents refresh_btn As Button
    Friend WithEvents Button1profession_btn As Button
    Friend WithEvents manage_btn As Button
End Class
