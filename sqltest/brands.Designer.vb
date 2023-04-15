<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class brands
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
        Me.type_list = New System.Windows.Forms.ListView()
        Me.brand_list = New System.Windows.Forms.ListView()
        Me.typeid = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.producttype = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.brandid = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.brandname = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.test_btn = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.manage_btn = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'type_list
        '
        Me.type_list.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.typeid, Me.producttype})
        Me.type_list.FullRowSelect = True
        Me.type_list.GridLines = True
        Me.type_list.HideSelection = False
        Me.type_list.Location = New System.Drawing.Point(12, 12)
        Me.type_list.Name = "type_list"
        Me.type_list.Size = New System.Drawing.Size(383, 337)
        Me.type_list.TabIndex = 0
        Me.type_list.UseCompatibleStateImageBehavior = False
        Me.type_list.View = System.Windows.Forms.View.Details
        '
        'brand_list
        '
        Me.brand_list.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.brandid, Me.brandname})
        Me.brand_list.FullRowSelect = True
        Me.brand_list.GridLines = True
        Me.brand_list.HideSelection = False
        Me.brand_list.Location = New System.Drawing.Point(401, 12)
        Me.brand_list.Name = "brand_list"
        Me.brand_list.Size = New System.Drawing.Size(387, 337)
        Me.brand_list.TabIndex = 1
        Me.brand_list.UseCompatibleStateImageBehavior = False
        Me.brand_list.View = System.Windows.Forms.View.Details
        '
        'typeid
        '
        Me.typeid.Text = "Type ID"
        Me.typeid.Width = 180
        '
        'producttype
        '
        Me.producttype.Text = "Product Type Name"
        Me.producttype.Width = 199
        '
        'brandid
        '
        Me.brandid.Text = "Brand ID"
        Me.brandid.Width = 180
        '
        'brandname
        '
        Me.brandname.Text = "Product Brand Name"
        Me.brandname.Width = 200
        '
        'test_btn
        '
        Me.test_btn.Location = New System.Drawing.Point(12, 355)
        Me.test_btn.Name = "test_btn"
        Me.test_btn.Size = New System.Drawing.Size(383, 42)
        Me.test_btn.TabIndex = 1
        Me.test_btn.Text = "Test Connection"
        Me.test_btn.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(12, 403)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(383, 42)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "Refresh"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'manage_btn
        '
        Me.manage_btn.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.manage_btn.Location = New System.Drawing.Point(401, 355)
        Me.manage_btn.Name = "manage_btn"
        Me.manage_btn.Size = New System.Drawing.Size(387, 90)
        Me.manage_btn.TabIndex = 3
        Me.manage_btn.Text = "Manage Both"
        Me.manage_btn.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(12, 451)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(776, 41)
        Me.Button2.TabIndex = 4
        Me.Button2.Text = "Exit"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'brands
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 504)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.manage_btn)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.test_btn)
        Me.Controls.Add(Me.brand_list)
        Me.Controls.Add(Me.type_list)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "brands"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Product Brands"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents type_list As ListView
    Friend WithEvents brand_list As ListView
    Friend WithEvents typeid As ColumnHeader
    Friend WithEvents producttype As ColumnHeader
    Friend WithEvents brandid As ColumnHeader
    Friend WithEvents brandname As ColumnHeader
    Friend WithEvents test_btn As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents manage_btn As Button
    Friend WithEvents Button2 As Button
End Class
