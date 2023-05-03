<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class stocks_crud
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
        Me.product_list = New System.Windows.Forms.ListView()
        Me.productname = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.productdate = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.producttype = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.productquantity = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.productbrand = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.btn_conn = New System.Windows.Forms.Button()
        Me.back_btn = New System.Windows.Forms.Button()
        Me.search_btn = New System.Windows.Forms.Button()
        Me.searchBox = New System.Windows.Forms.TextBox()
        Me.type_list = New System.Windows.Forms.ListView()
        Me.type_id = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.product_type = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.brand_list = New System.Windows.Forms.ListView()
        Me.brandid = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.product_brand = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.refresh_btn = New System.Windows.Forms.Button()
        Me.productBox = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.quantityBox = New System.Windows.Forms.TextBox()
        Me.dateBox = New System.Windows.Forms.TextBox()
        Me.typeBox = New System.Windows.Forms.TextBox()
        Me.brandBox = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.addBtn = New System.Windows.Forms.Button()
        Me.updateBtn = New System.Windows.Forms.Button()
        Me.deleteBtn = New System.Windows.Forms.Button()
        Me.productid = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.idbox = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.addtypeBtn = New System.Windows.Forms.Button()
        Me.updtypeBtn = New System.Windows.Forms.Button()
        Me.deltypeBtn = New System.Windows.Forms.Button()
        Me.addbrandBtn = New System.Windows.Forms.Button()
        Me.updbrandBtn = New System.Windows.Forms.Button()
        Me.delbrandBtn = New System.Windows.Forms.Button()
        Me.tbidBox = New System.Windows.Forms.TextBox()
        Me.tbnameBox = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'product_list
        '
        Me.product_list.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.productid, Me.productname, Me.productdate, Me.producttype, Me.productquantity, Me.productbrand})
        Me.product_list.FullRowSelect = True
        Me.product_list.GridLines = True
        Me.product_list.HideSelection = False
        Me.product_list.Location = New System.Drawing.Point(12, 12)
        Me.product_list.Name = "product_list"
        Me.product_list.Size = New System.Drawing.Size(582, 278)
        Me.product_list.TabIndex = 0
        Me.product_list.UseCompatibleStateImageBehavior = False
        Me.product_list.View = System.Windows.Forms.View.Details
        '
        'productname
        '
        Me.productname.Text = "Product Name"
        Me.productname.Width = 175
        '
        'productdate
        '
        Me.productdate.Text = "Date of Arrival"
        Me.productdate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.productdate.Width = 175
        '
        'producttype
        '
        Me.producttype.Text = "Product Type"
        Me.producttype.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.producttype.Width = 175
        '
        'productquantity
        '
        Me.productquantity.Text = "Quantities"
        Me.productquantity.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.productquantity.Width = 175
        '
        'productbrand
        '
        Me.productbrand.Text = "Brands"
        Me.productbrand.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.productbrand.Width = 175
        '
        'btn_conn
        '
        Me.btn_conn.Location = New System.Drawing.Point(600, 12)
        Me.btn_conn.Name = "btn_conn"
        Me.btn_conn.Size = New System.Drawing.Size(129, 37)
        Me.btn_conn.TabIndex = 1
        Me.btn_conn.Text = "Test Connection"
        Me.btn_conn.UseVisualStyleBackColor = True
        '
        'back_btn
        '
        Me.back_btn.Location = New System.Drawing.Point(735, 12)
        Me.back_btn.Name = "back_btn"
        Me.back_btn.Size = New System.Drawing.Size(129, 37)
        Me.back_btn.TabIndex = 2
        Me.back_btn.Text = "Go Back"
        Me.back_btn.UseVisualStyleBackColor = True
        '
        'search_btn
        '
        Me.search_btn.Location = New System.Drawing.Point(870, 12)
        Me.search_btn.Name = "search_btn"
        Me.search_btn.Size = New System.Drawing.Size(129, 37)
        Me.search_btn.TabIndex = 3
        Me.search_btn.Text = "Search by Name"
        Me.search_btn.UseVisualStyleBackColor = True
        '
        'searchBox
        '
        Me.searchBox.Location = New System.Drawing.Point(1005, 19)
        Me.searchBox.Name = "searchBox"
        Me.searchBox.Size = New System.Drawing.Size(152, 22)
        Me.searchBox.TabIndex = 4
        '
        'type_list
        '
        Me.type_list.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.type_id, Me.product_type})
        Me.type_list.FullRowSelect = True
        Me.type_list.GridLines = True
        Me.type_list.HideSelection = False
        Me.type_list.Location = New System.Drawing.Point(12, 329)
        Me.type_list.Name = "type_list"
        Me.type_list.Size = New System.Drawing.Size(286, 201)
        Me.type_list.TabIndex = 5
        Me.type_list.UseCompatibleStateImageBehavior = False
        Me.type_list.View = System.Windows.Forms.View.Details
        '
        'type_id
        '
        Me.type_id.Text = "Type ID"
        Me.type_id.Width = 125
        '
        'product_type
        '
        Me.product_type.Text = "Type Name"
        Me.product_type.Width = 150
        '
        'brand_list
        '
        Me.brand_list.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.brandid, Me.product_brand})
        Me.brand_list.FullRowSelect = True
        Me.brand_list.GridLines = True
        Me.brand_list.HideSelection = False
        Me.brand_list.Location = New System.Drawing.Point(304, 329)
        Me.brand_list.Name = "brand_list"
        Me.brand_list.Size = New System.Drawing.Size(290, 201)
        Me.brand_list.TabIndex = 6
        Me.brand_list.UseCompatibleStateImageBehavior = False
        Me.brand_list.View = System.Windows.Forms.View.Details
        '
        'brandid
        '
        Me.brandid.Text = "Brand ID"
        Me.brandid.Width = 125
        '
        'product_brand
        '
        Me.product_brand.Text = "Brand Name"
        Me.product_brand.Width = 150
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(62, 295)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(454, 29)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Legend for their ID's of Brands and Types"
        '
        'refresh_btn
        '
        Me.refresh_btn.Location = New System.Drawing.Point(600, 55)
        Me.refresh_btn.Name = "refresh_btn"
        Me.refresh_btn.Size = New System.Drawing.Size(129, 37)
        Me.refresh_btn.TabIndex = 8
        Me.refresh_btn.Text = "Refresh"
        Me.refresh_btn.UseVisualStyleBackColor = True
        '
        'productBox
        '
        Me.productBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.productBox.Location = New System.Drawing.Point(784, 134)
        Me.productBox.Name = "productBox"
        Me.productBox.Size = New System.Drawing.Size(373, 30)
        Me.productBox.TabIndex = 9
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(600, 137)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(142, 25)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "Product Name:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(600, 245)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(178, 25)
        Me.Label3.TabIndex = 15
        Me.Label3.Text = "Product Quantities:"
        '
        'quantityBox
        '
        Me.quantityBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.quantityBox.Location = New System.Drawing.Point(784, 242)
        Me.quantityBox.Name = "quantityBox"
        Me.quantityBox.Size = New System.Drawing.Size(373, 30)
        Me.quantityBox.TabIndex = 16
        '
        'dateBox
        '
        Me.dateBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dateBox.Location = New System.Drawing.Point(784, 170)
        Me.dateBox.Name = "dateBox"
        Me.dateBox.Size = New System.Drawing.Size(373, 30)
        Me.dateBox.TabIndex = 17
        '
        'typeBox
        '
        Me.typeBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.typeBox.Location = New System.Drawing.Point(784, 206)
        Me.typeBox.Name = "typeBox"
        Me.typeBox.Size = New System.Drawing.Size(373, 30)
        Me.typeBox.TabIndex = 18
        '
        'brandBox
        '
        Me.brandBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.brandBox.Location = New System.Drawing.Point(784, 278)
        Me.brandBox.Name = "brandBox"
        Me.brandBox.Size = New System.Drawing.Size(373, 30)
        Me.brandBox.TabIndex = 19
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(600, 173)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(140, 25)
        Me.Label4.TabIndex = 20
        Me.Label4.Text = "Date of Arrival:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(600, 209)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(135, 25)
        Me.Label5.TabIndex = 21
        Me.Label5.Text = "Product Type:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(600, 281)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(142, 25)
        Me.Label6.TabIndex = 22
        Me.Label6.Text = "Product Brand:"
        '
        'addBtn
        '
        Me.addBtn.Location = New System.Drawing.Point(735, 55)
        Me.addBtn.Name = "addBtn"
        Me.addBtn.Size = New System.Drawing.Size(129, 37)
        Me.addBtn.TabIndex = 23
        Me.addBtn.Text = "Add Product"
        Me.addBtn.UseVisualStyleBackColor = True
        '
        'updateBtn
        '
        Me.updateBtn.Location = New System.Drawing.Point(870, 55)
        Me.updateBtn.Name = "updateBtn"
        Me.updateBtn.Size = New System.Drawing.Size(129, 37)
        Me.updateBtn.TabIndex = 24
        Me.updateBtn.Text = "Update Product"
        Me.updateBtn.UseVisualStyleBackColor = True
        '
        'deleteBtn
        '
        Me.deleteBtn.Location = New System.Drawing.Point(1005, 55)
        Me.deleteBtn.Name = "deleteBtn"
        Me.deleteBtn.Size = New System.Drawing.Size(152, 37)
        Me.deleteBtn.TabIndex = 25
        Me.deleteBtn.Text = "Delete Product"
        Me.deleteBtn.UseVisualStyleBackColor = True
        '
        'productid
        '
        Me.productid.Text = "ID"
        Me.productid.Width = 100
        '
        'idbox
        '
        Me.idbox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.idbox.Location = New System.Drawing.Point(784, 98)
        Me.idbox.Name = "idbox"
        Me.idbox.Size = New System.Drawing.Size(373, 30)
        Me.idbox.TabIndex = 26
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(600, 101)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(109, 25)
        Me.Label7.TabIndex = 27
        Me.Label7.Text = "Product ID:"
        '
        'addtypeBtn
        '
        Me.addtypeBtn.Location = New System.Drawing.Point(600, 314)
        Me.addtypeBtn.Name = "addtypeBtn"
        Me.addtypeBtn.Size = New System.Drawing.Size(129, 37)
        Me.addtypeBtn.TabIndex = 28
        Me.addtypeBtn.Text = "Add Type"
        Me.addtypeBtn.UseVisualStyleBackColor = True
        '
        'updtypeBtn
        '
        Me.updtypeBtn.Location = New System.Drawing.Point(735, 314)
        Me.updtypeBtn.Name = "updtypeBtn"
        Me.updtypeBtn.Size = New System.Drawing.Size(129, 37)
        Me.updtypeBtn.TabIndex = 29
        Me.updtypeBtn.Text = "Update Type"
        Me.updtypeBtn.UseVisualStyleBackColor = True
        '
        'deltypeBtn
        '
        Me.deltypeBtn.Location = New System.Drawing.Point(600, 357)
        Me.deltypeBtn.Name = "deltypeBtn"
        Me.deltypeBtn.Size = New System.Drawing.Size(129, 37)
        Me.deltypeBtn.TabIndex = 30
        Me.deltypeBtn.Text = "Delete Type"
        Me.deltypeBtn.UseVisualStyleBackColor = True
        '
        'addbrandBtn
        '
        Me.addbrandBtn.Location = New System.Drawing.Point(1028, 314)
        Me.addbrandBtn.Name = "addbrandBtn"
        Me.addbrandBtn.Size = New System.Drawing.Size(129, 37)
        Me.addbrandBtn.TabIndex = 31
        Me.addbrandBtn.Text = "Add Brand"
        Me.addbrandBtn.UseVisualStyleBackColor = True
        '
        'updbrandBtn
        '
        Me.updbrandBtn.Location = New System.Drawing.Point(893, 314)
        Me.updbrandBtn.Name = "updbrandBtn"
        Me.updbrandBtn.Size = New System.Drawing.Size(129, 37)
        Me.updbrandBtn.TabIndex = 32
        Me.updbrandBtn.Text = "Update Brand"
        Me.updbrandBtn.UseVisualStyleBackColor = True
        '
        'delbrandBtn
        '
        Me.delbrandBtn.Location = New System.Drawing.Point(1028, 357)
        Me.delbrandBtn.Name = "delbrandBtn"
        Me.delbrandBtn.Size = New System.Drawing.Size(129, 37)
        Me.delbrandBtn.TabIndex = 33
        Me.delbrandBtn.Text = "Delete Brand"
        Me.delbrandBtn.UseVisualStyleBackColor = True
        '
        'tbidBox
        '
        Me.tbidBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbidBox.Location = New System.Drawing.Point(784, 425)
        Me.tbidBox.Name = "tbidBox"
        Me.tbidBox.Size = New System.Drawing.Size(373, 30)
        Me.tbidBox.TabIndex = 34
        '
        'tbnameBox
        '
        Me.tbnameBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbnameBox.Location = New System.Drawing.Point(784, 461)
        Me.tbnameBox.Name = "tbnameBox"
        Me.tbnameBox.Size = New System.Drawing.Size(373, 30)
        Me.tbnameBox.TabIndex = 35
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(600, 428)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(145, 25)
        Me.Label8.TabIndex = 36
        Me.Label8.Text = "Type/Brand ID:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(600, 464)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(178, 25)
        Me.Label9.TabIndex = 37
        Me.Label9.Text = "Type/Brand Name:"
        '
        'stocks_crud
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1169, 542)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.tbnameBox)
        Me.Controls.Add(Me.tbidBox)
        Me.Controls.Add(Me.delbrandBtn)
        Me.Controls.Add(Me.updbrandBtn)
        Me.Controls.Add(Me.addbrandBtn)
        Me.Controls.Add(Me.deltypeBtn)
        Me.Controls.Add(Me.updtypeBtn)
        Me.Controls.Add(Me.addtypeBtn)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.idbox)
        Me.Controls.Add(Me.deleteBtn)
        Me.Controls.Add(Me.updateBtn)
        Me.Controls.Add(Me.addBtn)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.brandBox)
        Me.Controls.Add(Me.typeBox)
        Me.Controls.Add(Me.dateBox)
        Me.Controls.Add(Me.quantityBox)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.productBox)
        Me.Controls.Add(Me.refresh_btn)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.brand_list)
        Me.Controls.Add(Me.type_list)
        Me.Controls.Add(Me.searchBox)
        Me.Controls.Add(Me.search_btn)
        Me.Controls.Add(Me.back_btn)
        Me.Controls.Add(Me.btn_conn)
        Me.Controls.Add(Me.product_list)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "stocks_crud"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Stock Management"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents product_list As ListView
    Friend WithEvents productname As ColumnHeader
    Friend WithEvents productdate As ColumnHeader
    Friend WithEvents producttype As ColumnHeader
    Friend WithEvents productquantity As ColumnHeader
    Friend WithEvents productbrand As ColumnHeader
    Friend WithEvents btn_conn As Button
    Friend WithEvents back_btn As Button
    Friend WithEvents search_btn As Button
    Friend WithEvents searchBox As TextBox
    Friend WithEvents type_list As ListView
    Friend WithEvents type_id As ColumnHeader
    Friend WithEvents product_type As ColumnHeader
    Friend WithEvents brand_list As ListView
    Friend WithEvents brandid As ColumnHeader
    Friend WithEvents product_brand As ColumnHeader
    Friend WithEvents Label1 As Label
    Friend WithEvents refresh_btn As Button
    Friend WithEvents productBox As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents quantityBox As TextBox
    Friend WithEvents dateBox As TextBox
    Friend WithEvents typeBox As TextBox
    Friend WithEvents brandBox As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents addBtn As Button
    Friend WithEvents updateBtn As Button
    Friend WithEvents deleteBtn As Button
    Friend WithEvents productid As ColumnHeader
    Friend WithEvents idbox As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents addtypeBtn As Button
    Friend WithEvents updtypeBtn As Button
    Friend WithEvents deltypeBtn As Button
    Friend WithEvents updbrandBtn As Button
    Friend WithEvents delbrandBtn As Button
    Friend WithEvents tbidBox As TextBox
    Friend WithEvents tbnameBox As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents addbrandBtn As Button
End Class
