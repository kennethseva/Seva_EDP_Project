<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class employee_management
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(employee_management))
        Me.employeeList = New System.Windows.Forms.ListView()
        Me.employeeid = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.employeefname = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.employeemname = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.employeelname = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.employeeprofession = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.employeedate = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.professionList = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.profaddBtn = New System.Windows.Forms.Button()
        Me.profupdBtn = New System.Windows.Forms.Button()
        Me.profdelBtn = New System.Windows.Forms.Button()
        Me.profidBox = New System.Windows.Forms.TextBox()
        Me.profnameBox = New System.Windows.Forms.TextBox()
        Me.profincomeBox = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.labels2 = New System.Windows.Forms.Label()
        Me.label3 = New System.Windows.Forms.Label()
        Me.refBtn = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.employeeidBox = New System.Windows.Forms.TextBox()
        Me.employeefnameBox = New System.Windows.Forms.TextBox()
        Me.employeemnameBox = New System.Windows.Forms.TextBox()
        Me.employeelnameBox = New System.Windows.Forms.TextBox()
        Me.employeeprofBox = New System.Windows.Forms.TextBox()
        Me.employeedateBox = New System.Windows.Forms.TextBox()
        Me.employeedelbtn = New System.Windows.Forms.PictureBox()
        Me.employeeupdbtn = New System.Windows.Forms.PictureBox()
        Me.employeeaddbtn = New System.Windows.Forms.PictureBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        CType(Me.employeedelbtn, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.employeeupdbtn, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.employeeaddbtn, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'employeeList
        '
        Me.employeeList.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.employeeid, Me.employeefname, Me.employeemname, Me.employeelname, Me.employeeprofession, Me.employeedate})
        Me.employeeList.FullRowSelect = True
        Me.employeeList.GridLines = True
        Me.employeeList.HideSelection = False
        Me.employeeList.Location = New System.Drawing.Point(12, 12)
        Me.employeeList.Name = "employeeList"
        Me.employeeList.Size = New System.Drawing.Size(1054, 270)
        Me.employeeList.TabIndex = 0
        Me.employeeList.UseCompatibleStateImageBehavior = False
        Me.employeeList.View = System.Windows.Forms.View.Details
        '
        'employeeid
        '
        Me.employeeid.Text = "ID"
        Me.employeeid.Width = 175
        '
        'employeefname
        '
        Me.employeefname.Text = "First Name"
        Me.employeefname.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.employeefname.Width = 175
        '
        'employeemname
        '
        Me.employeemname.Text = "Middle Name"
        Me.employeemname.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.employeemname.Width = 175
        '
        'employeelname
        '
        Me.employeelname.Text = "Last Name"
        Me.employeelname.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.employeelname.Width = 175
        '
        'employeeprofession
        '
        Me.employeeprofession.Text = "Profession"
        Me.employeeprofession.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.employeeprofession.Width = 175
        '
        'employeedate
        '
        Me.employeedate.Text = "Start Date"
        Me.employeedate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.employeedate.Width = 175
        '
        'professionList
        '
        Me.professionList.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3})
        Me.professionList.FullRowSelect = True
        Me.professionList.GridLines = True
        Me.professionList.HideSelection = False
        Me.professionList.Location = New System.Drawing.Point(333, 288)
        Me.professionList.Name = "professionList"
        Me.professionList.Size = New System.Drawing.Size(304, 255)
        Me.professionList.TabIndex = 1
        Me.professionList.UseCompatibleStateImageBehavior = False
        Me.professionList.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "ID"
        Me.ColumnHeader1.Width = 100
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Profession Name"
        Me.ColumnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader2.Width = 175
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Daily Income"
        Me.ColumnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader3.Width = 175
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 288)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(216, 25)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Manage Profession List"
        '
        'profaddBtn
        '
        Me.profaddBtn.Location = New System.Drawing.Point(12, 507)
        Me.profaddBtn.Name = "profaddBtn"
        Me.profaddBtn.Size = New System.Drawing.Size(101, 36)
        Me.profaddBtn.TabIndex = 3
        Me.profaddBtn.Text = "Add"
        Me.profaddBtn.UseVisualStyleBackColor = True
        '
        'profupdBtn
        '
        Me.profupdBtn.Location = New System.Drawing.Point(119, 506)
        Me.profupdBtn.Name = "profupdBtn"
        Me.profupdBtn.Size = New System.Drawing.Size(101, 36)
        Me.profupdBtn.TabIndex = 4
        Me.profupdBtn.Text = "Update"
        Me.profupdBtn.UseVisualStyleBackColor = True
        '
        'profdelBtn
        '
        Me.profdelBtn.Location = New System.Drawing.Point(226, 506)
        Me.profdelBtn.Name = "profdelBtn"
        Me.profdelBtn.Size = New System.Drawing.Size(101, 36)
        Me.profdelBtn.TabIndex = 5
        Me.profdelBtn.Text = "Delete"
        Me.profdelBtn.UseVisualStyleBackColor = True
        '
        'profidBox
        '
        Me.profidBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.profidBox.Location = New System.Drawing.Point(119, 336)
        Me.profidBox.Name = "profidBox"
        Me.profidBox.Size = New System.Drawing.Size(208, 30)
        Me.profidBox.TabIndex = 6
        '
        'profnameBox
        '
        Me.profnameBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.profnameBox.Location = New System.Drawing.Point(119, 372)
        Me.profnameBox.Name = "profnameBox"
        Me.profnameBox.Size = New System.Drawing.Size(208, 30)
        Me.profnameBox.TabIndex = 7
        '
        'profincomeBox
        '
        Me.profincomeBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.profincomeBox.Location = New System.Drawing.Point(119, 408)
        Me.profincomeBox.Name = "profincomeBox"
        Me.profincomeBox.Size = New System.Drawing.Size(208, 30)
        Me.profincomeBox.TabIndex = 8
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(12, 339)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(37, 25)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "ID:"
        '
        'labels2
        '
        Me.labels2.AutoSize = True
        Me.labels2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labels2.Location = New System.Drawing.Point(12, 375)
        Me.labels2.Name = "labels2"
        Me.labels2.Size = New System.Drawing.Size(70, 25)
        Me.labels2.TabIndex = 10
        Me.labels2.Text = "Name:"
        '
        'label3
        '
        Me.label3.AutoSize = True
        Me.label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label3.Location = New System.Drawing.Point(12, 411)
        Me.label3.Name = "label3"
        Me.label3.Size = New System.Drawing.Size(82, 25)
        Me.label3.TabIndex = 11
        Me.label3.Text = "Income:"
        '
        'refBtn
        '
        Me.refBtn.Location = New System.Drawing.Point(12, 478)
        Me.refBtn.Name = "refBtn"
        Me.refBtn.Size = New System.Drawing.Size(315, 23)
        Me.refBtn.TabIndex = 12
        Me.refBtn.Text = "Refresh"
        Me.refBtn.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(643, 288)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(211, 25)
        Me.Label4.TabIndex = 13
        Me.Label4.Text = "Manage Employee List"
        '
        'employeeidBox
        '
        Me.employeeidBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.employeeidBox.Location = New System.Drawing.Point(858, 334)
        Me.employeeidBox.Name = "employeeidBox"
        Me.employeeidBox.Size = New System.Drawing.Size(208, 30)
        Me.employeeidBox.TabIndex = 14
        '
        'employeefnameBox
        '
        Me.employeefnameBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.employeefnameBox.Location = New System.Drawing.Point(858, 370)
        Me.employeefnameBox.Name = "employeefnameBox"
        Me.employeefnameBox.Size = New System.Drawing.Size(208, 30)
        Me.employeefnameBox.TabIndex = 15
        '
        'employeemnameBox
        '
        Me.employeemnameBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.employeemnameBox.Location = New System.Drawing.Point(858, 406)
        Me.employeemnameBox.Name = "employeemnameBox"
        Me.employeemnameBox.Size = New System.Drawing.Size(208, 30)
        Me.employeemnameBox.TabIndex = 16
        '
        'employeelnameBox
        '
        Me.employeelnameBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.employeelnameBox.Location = New System.Drawing.Point(858, 442)
        Me.employeelnameBox.Name = "employeelnameBox"
        Me.employeelnameBox.Size = New System.Drawing.Size(208, 30)
        Me.employeelnameBox.TabIndex = 17
        '
        'employeeprofBox
        '
        Me.employeeprofBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.employeeprofBox.Location = New System.Drawing.Point(858, 478)
        Me.employeeprofBox.Name = "employeeprofBox"
        Me.employeeprofBox.Size = New System.Drawing.Size(208, 30)
        Me.employeeprofBox.TabIndex = 18
        '
        'employeedateBox
        '
        Me.employeedateBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.employeedateBox.Location = New System.Drawing.Point(858, 514)
        Me.employeedateBox.Name = "employeedateBox"
        Me.employeedateBox.Size = New System.Drawing.Size(208, 30)
        Me.employeedateBox.TabIndex = 19
        '
        'employeedelbtn
        '
        Me.employeedelbtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.employeedelbtn.Image = Global.sqltest.My.Resources.Resources.Oxygen_Icons_org_Oxygen_Actions_list_remove_user_256
        Me.employeedelbtn.Location = New System.Drawing.Point(974, 288)
        Me.employeedelbtn.Name = "employeedelbtn"
        Me.employeedelbtn.Size = New System.Drawing.Size(51, 40)
        Me.employeedelbtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.employeedelbtn.TabIndex = 22
        Me.employeedelbtn.TabStop = False
        '
        'employeeupdbtn
        '
        Me.employeeupdbtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.employeeupdbtn.Image = Global.sqltest.My.Resources.Resources.Oxygen_Icons_org_Oxygen_Actions_edit_redo1
        Me.employeeupdbtn.Location = New System.Drawing.Point(917, 288)
        Me.employeeupdbtn.Name = "employeeupdbtn"
        Me.employeeupdbtn.Size = New System.Drawing.Size(51, 40)
        Me.employeeupdbtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.employeeupdbtn.TabIndex = 21
        Me.employeeupdbtn.TabStop = False
        '
        'employeeaddbtn
        '
        Me.employeeaddbtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.employeeaddbtn.Image = CType(resources.GetObject("employeeaddbtn.Image"), System.Drawing.Image)
        Me.employeeaddbtn.Location = New System.Drawing.Point(860, 288)
        Me.employeeaddbtn.Name = "employeeaddbtn"
        Me.employeeaddbtn.Size = New System.Drawing.Size(51, 40)
        Me.employeeaddbtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.employeeaddbtn.TabIndex = 20
        Me.employeeaddbtn.TabStop = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(643, 337)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(129, 25)
        Me.Label5.TabIndex = 23
        Me.Label5.Text = "Employee ID:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(643, 373)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(204, 25)
        Me.Label6.TabIndex = 24
        Me.Label6.Text = "Employee First Name:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(643, 411)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(189, 25)
        Me.Label7.TabIndex = 25
        Me.Label7.Text = "Employee M. Name:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(643, 445)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(204, 25)
        Me.Label8.TabIndex = 26
        Me.Label8.Text = "Employee Last Name:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(643, 481)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(169, 25)
        Me.Label9.TabIndex = 27
        Me.Label9.Text = "Employee Prof ID:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(643, 517)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(151, 25)
        Me.Label10.TabIndex = 28
        Me.Label10.Text = "Employee Date:"
        '
        'employee_management
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1078, 555)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.employeedelbtn)
        Me.Controls.Add(Me.employeeupdbtn)
        Me.Controls.Add(Me.employeeaddbtn)
        Me.Controls.Add(Me.employeedateBox)
        Me.Controls.Add(Me.employeeprofBox)
        Me.Controls.Add(Me.employeelnameBox)
        Me.Controls.Add(Me.employeemnameBox)
        Me.Controls.Add(Me.employeefnameBox)
        Me.Controls.Add(Me.employeeidBox)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.refBtn)
        Me.Controls.Add(Me.label3)
        Me.Controls.Add(Me.labels2)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.profincomeBox)
        Me.Controls.Add(Me.profnameBox)
        Me.Controls.Add(Me.profidBox)
        Me.Controls.Add(Me.profdelBtn)
        Me.Controls.Add(Me.profupdBtn)
        Me.Controls.Add(Me.profaddBtn)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.professionList)
        Me.Controls.Add(Me.employeeList)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "employee_management"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Manage Employee's"
        CType(Me.employeedelbtn, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.employeeupdbtn, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.employeeaddbtn, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents employeeList As ListView
    Friend WithEvents employeeid As ColumnHeader
    Friend WithEvents employeefname As ColumnHeader
    Friend WithEvents employeemname As ColumnHeader
    Friend WithEvents employeelname As ColumnHeader
    Friend WithEvents employeeprofession As ColumnHeader
    Friend WithEvents employeedate As ColumnHeader
    Friend WithEvents professionList As ListView
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents ColumnHeader2 As ColumnHeader
    Friend WithEvents ColumnHeader3 As ColumnHeader
    Friend WithEvents Label1 As Label
    Friend WithEvents profaddBtn As Button
    Friend WithEvents profupdBtn As Button
    Friend WithEvents profdelBtn As Button
    Friend WithEvents profidBox As TextBox
    Friend WithEvents profnameBox As TextBox
    Friend WithEvents profincomeBox As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents labels2 As Label
    Friend WithEvents label3 As Label
    Friend WithEvents refBtn As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents employeeidBox As TextBox
    Friend WithEvents employeefnameBox As TextBox
    Friend WithEvents employeemnameBox As TextBox
    Friend WithEvents employeelnameBox As TextBox
    Friend WithEvents employeeprofBox As TextBox
    Friend WithEvents employeedateBox As TextBox
    Friend WithEvents employeeaddbtn As PictureBox
    Friend WithEvents employeeupdbtn As PictureBox
    Friend WithEvents employeedelbtn As PictureBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
End Class
