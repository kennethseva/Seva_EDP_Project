<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class stocks
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
        Me.product_list = New System.Windows.Forms.ListView()
        Me.productname = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.productquantity = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.productdate = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.producttype = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.productbrand = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.test_Btn = New System.Windows.Forms.Button()
        Me.refresh_btn = New System.Windows.Forms.Button()
        Me.back_btn = New System.Windows.Forms.Button()
        Me.manage_btn = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'product_list
        '
        Me.product_list.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.productname, Me.productquantity, Me.productdate, Me.producttype, Me.productbrand})
        Me.product_list.FullRowSelect = True
        Me.product_list.GridLines = True
        Me.product_list.HideSelection = False
        Me.product_list.Location = New System.Drawing.Point(12, 12)
        Me.product_list.Name = "product_list"
        Me.product_list.Size = New System.Drawing.Size(776, 426)
        Me.product_list.TabIndex = 0
        Me.product_list.UseCompatibleStateImageBehavior = False
        Me.product_list.View = System.Windows.Forms.View.Details
        '
        'productname
        '
        Me.productname.Text = "Product Name"
        Me.productname.Width = 175
        '
        'productquantity
        '
        Me.productquantity.Text = "Quantities"
        Me.productquantity.Width = 175
        '
        'productdate
        '
        Me.productdate.Text = "Date of Arrival"
        Me.productdate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.productdate.Width = 150
        '
        'producttype
        '
        Me.producttype.Text = "Types"
        Me.producttype.Width = 150
        '
        'productbrand
        '
        Me.productbrand.Text = "Brands"
        Me.productbrand.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.productbrand.Width = 125
        '
        'test_Btn
        '
        Me.test_Btn.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.test_Btn.Location = New System.Drawing.Point(12, 444)
        Me.test_Btn.Name = "test_Btn"
        Me.test_Btn.Size = New System.Drawing.Size(147, 34)
        Me.test_Btn.TabIndex = 1
        Me.test_Btn.Text = "Test Connection"
        Me.test_Btn.UseVisualStyleBackColor = True
        '
        'refresh_btn
        '
        Me.refresh_btn.Location = New System.Drawing.Point(165, 444)
        Me.refresh_btn.Name = "refresh_btn"
        Me.refresh_btn.Size = New System.Drawing.Size(147, 37)
        Me.refresh_btn.TabIndex = 2
        Me.refresh_btn.Text = "Refresh"
        Me.refresh_btn.UseVisualStyleBackColor = True
        '
        'back_btn
        '
        Me.back_btn.Location = New System.Drawing.Point(601, 444)
        Me.back_btn.Name = "back_btn"
        Me.back_btn.Size = New System.Drawing.Size(187, 37)
        Me.back_btn.TabIndex = 3
        Me.back_btn.Text = "Go Back to Dash Board"
        Me.back_btn.UseVisualStyleBackColor = True
        '
        'manage_btn
        '
        Me.manage_btn.Location = New System.Drawing.Point(451, 444)
        Me.manage_btn.Name = "manage_btn"
        Me.manage_btn.Size = New System.Drawing.Size(144, 37)
        Me.manage_btn.TabIndex = 4
        Me.manage_btn.Text = "Manage Data"
        Me.manage_btn.UseVisualStyleBackColor = True
        '
        'stocks
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 490)
        Me.Controls.Add(Me.manage_btn)
        Me.Controls.Add(Me.back_btn)
        Me.Controls.Add(Me.refresh_btn)
        Me.Controls.Add(Me.test_Btn)
        Me.Controls.Add(Me.product_list)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "stocks"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Items Available"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents product_list As ListView
    Friend WithEvents productname As ColumnHeader
    Friend WithEvents productquantity As ColumnHeader
    Friend WithEvents productdate As ColumnHeader
    Friend WithEvents producttype As ColumnHeader
    Friend WithEvents productbrand As ColumnHeader
    Friend WithEvents test_Btn As Button
    Friend WithEvents refresh_btn As Button
    Friend WithEvents back_btn As Button
    Friend WithEvents manage_btn As Button
End Class
