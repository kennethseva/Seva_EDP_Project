<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class dashboard
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
        Me.components = New System.ComponentModel.Container()
        Me.string_name = New System.Windows.Forms.Label()
        Me.stock_btn = New System.Windows.Forms.Button()
        Me.employee_btn = New System.Windows.Forms.Button()
        Me.fired_btn = New System.Windows.Forms.Button()
        Me.time_label = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.brands_btn = New System.Windows.Forms.Button()
        Me.picture_btn = New System.Windows.Forms.PictureBox()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.csv_btn = New System.Windows.Forms.Button()
        Me.backup_btn = New System.Windows.Forms.Button()
        CType(Me.picture_btn, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'string_name
        '
        Me.string_name.AutoSize = True
        Me.string_name.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.string_name.Location = New System.Drawing.Point(13, 13)
        Me.string_name.Name = "string_name"
        Me.string_name.Size = New System.Drawing.Size(161, 25)
        Me.string_name.TabIndex = 0
        Me.string_name.Text = "Welcome Label"
        '
        'stock_btn
        '
        Me.stock_btn.Location = New System.Drawing.Point(12, 186)
        Me.stock_btn.Name = "stock_btn"
        Me.stock_btn.Size = New System.Drawing.Size(211, 52)
        Me.stock_btn.TabIndex = 1
        Me.stock_btn.Text = "Show Socks Available"
        Me.stock_btn.UseVisualStyleBackColor = True
        '
        'employee_btn
        '
        Me.employee_btn.Location = New System.Drawing.Point(446, 186)
        Me.employee_btn.Name = "employee_btn"
        Me.employee_btn.Size = New System.Drawing.Size(211, 52)
        Me.employee_btn.TabIndex = 2
        Me.employee_btn.Text = "Show Employee Available"
        Me.employee_btn.UseVisualStyleBackColor = True
        '
        'fired_btn
        '
        Me.fired_btn.Location = New System.Drawing.Point(12, 386)
        Me.fired_btn.Name = "fired_btn"
        Me.fired_btn.Size = New System.Drawing.Size(211, 52)
        Me.fired_btn.TabIndex = 4
        Me.fired_btn.Text = "Fired Employee"
        Me.fired_btn.UseVisualStyleBackColor = True
        '
        'time_label
        '
        Me.time_label.AutoSize = True
        Me.time_label.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.time_label.Location = New System.Drawing.Point(436, 13)
        Me.time_label.Name = "time_label"
        Me.time_label.Size = New System.Drawing.Size(221, 25)
        Me.time_label.TabIndex = 7
        Me.time_label.Text = "dd-MM-yyy hh:mm:ss"
        Me.time_label.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Timer1
        '
        Me.Timer1.Interval = 1000
        '
        'brands_btn
        '
        Me.brands_btn.Location = New System.Drawing.Point(446, 386)
        Me.brands_btn.Name = "brands_btn"
        Me.brands_btn.Size = New System.Drawing.Size(211, 52)
        Me.brands_btn.TabIndex = 3
        Me.brands_btn.Text = "Manage Brands and Types"
        Me.brands_btn.UseVisualStyleBackColor = True
        '
        'picture_btn
        '
        Me.picture_btn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.picture_btn.Image = Global.sqltest.My.Resources.Resources.icon5
        Me.picture_btn.Location = New System.Drawing.Point(229, 95)
        Me.picture_btn.Name = "picture_btn"
        Me.picture_btn.Size = New System.Drawing.Size(211, 194)
        Me.picture_btn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picture_btn.TabIndex = 9
        Me.picture_btn.TabStop = False
        '
        'PictureBox4
        '
        Me.PictureBox4.Image = Global.sqltest.My.Resources.Resources.icon4
        Me.PictureBox4.Location = New System.Drawing.Point(494, 256)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(124, 124)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox4.TabIndex = 8
        Me.PictureBox4.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = Global.sqltest.My.Resources.Resources.icon3
        Me.PictureBox3.Location = New System.Drawing.Point(56, 252)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(128, 128)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox3.TabIndex = 6
        Me.PictureBox3.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.sqltest.My.Resources.Resources.icon2
        Me.PictureBox2.Location = New System.Drawing.Point(490, 52)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(128, 128)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox2.TabIndex = 3
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.sqltest.My.Resources.Resources.icon1
        Me.PictureBox1.Location = New System.Drawing.Point(56, 52)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(128, 128)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
        '
        'csv_btn
        '
        Me.csv_btn.Location = New System.Drawing.Point(229, 386)
        Me.csv_btn.Name = "csv_btn"
        Me.csv_btn.Size = New System.Drawing.Size(211, 52)
        Me.csv_btn.TabIndex = 10
        Me.csv_btn.Text = "CSV Upload"
        Me.csv_btn.UseVisualStyleBackColor = True
        '
        'backup_btn
        '
        Me.backup_btn.Location = New System.Drawing.Point(229, 334)
        Me.backup_btn.Name = "backup_btn"
        Me.backup_btn.Size = New System.Drawing.Size(211, 46)
        Me.backup_btn.TabIndex = 11
        Me.backup_btn.Text = "Backup Database"
        Me.backup_btn.UseVisualStyleBackColor = True
        '
        'dashboard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(669, 450)
        Me.Controls.Add(Me.backup_btn)
        Me.Controls.Add(Me.csv_btn)
        Me.Controls.Add(Me.picture_btn)
        Me.Controls.Add(Me.brands_btn)
        Me.Controls.Add(Me.PictureBox4)
        Me.Controls.Add(Me.time_label)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.fired_btn)
        Me.Controls.Add(Me.employee_btn)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.stock_btn)
        Me.Controls.Add(Me.string_name)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "dashboard"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Gamestocks"
        CType(Me.picture_btn, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents string_name As Label
    Friend WithEvents stock_btn As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents employee_btn As Button
    Friend WithEvents fired_btn As Button
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents time_label As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents brands_btn As Button
    Friend WithEvents picture_btn As PictureBox
    Friend WithEvents csv_btn As Button
    Friend WithEvents backup_btn As Button
End Class
