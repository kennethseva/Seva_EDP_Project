<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmCSV
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
        Me.grid_data = New System.Windows.Forms.DataGridView()
        Me.import_btn = New System.Windows.Forms.Button()
        Me.export_btrn = New System.Windows.Forms.Button()
        CType(Me.grid_data, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'grid_data
        '
        Me.grid_data.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grid_data.Location = New System.Drawing.Point(12, 12)
        Me.grid_data.Name = "grid_data"
        Me.grid_data.RowHeadersWidth = 51
        Me.grid_data.RowTemplate.Height = 24
        Me.grid_data.Size = New System.Drawing.Size(776, 380)
        Me.grid_data.TabIndex = 0
        '
        'import_btn
        '
        Me.import_btn.Location = New System.Drawing.Point(691, 398)
        Me.import_btn.Name = "import_btn"
        Me.import_btn.Size = New System.Drawing.Size(97, 40)
        Me.import_btn.TabIndex = 1
        Me.import_btn.Text = "Import"
        Me.import_btn.UseVisualStyleBackColor = True
        '
        'export_btrn
        '
        Me.export_btrn.Location = New System.Drawing.Point(567, 398)
        Me.export_btrn.Name = "export_btrn"
        Me.export_btrn.Size = New System.Drawing.Size(118, 40)
        Me.export_btrn.TabIndex = 2
        Me.export_btrn.Text = "Export"
        Me.export_btrn.UseVisualStyleBackColor = True
        '
        'frmCSV
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.export_btrn)
        Me.Controls.Add(Me.import_btn)
        Me.Controls.Add(Me.grid_data)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "frmCSV"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "CSV Excel Import/Export"
        CType(Me.grid_data, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents grid_data As DataGridView
    Friend WithEvents import_btn As Button
    Friend WithEvents export_btrn As Button
End Class
