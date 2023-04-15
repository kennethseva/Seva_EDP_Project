<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class fired
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
        Me.fired_list = New System.Windows.Forms.ListView()
        Me.firedid = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.fname = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.lname = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.status = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.SuspendLayout()
        '
        'fired_list
        '
        Me.fired_list.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.firedid, Me.fname, Me.lname, Me.status})
        Me.fired_list.FullRowSelect = True
        Me.fired_list.GridLines = True
        Me.fired_list.HideSelection = False
        Me.fired_list.Location = New System.Drawing.Point(12, 12)
        Me.fired_list.Name = "fired_list"
        Me.fired_list.Size = New System.Drawing.Size(630, 426)
        Me.fired_list.TabIndex = 0
        Me.fired_list.UseCompatibleStateImageBehavior = False
        Me.fired_list.View = System.Windows.Forms.View.Details
        '
        'firedid
        '
        Me.firedid.Text = "Table ID"
        Me.firedid.Width = 100
        '
        'fname
        '
        Me.fname.Text = "First Name Employee"
        Me.fname.Width = 175
        '
        'lname
        '
        Me.lname.Text = "Last Name Employee"
        Me.lname.Width = 175
        '
        'status
        '
        Me.status.Text = "Status"
        Me.status.Width = 175
        '
        'fired
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(651, 450)
        Me.Controls.Add(Me.fired_list)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Name = "fired"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Employee's that got fired"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents fired_list As ListView
    Friend WithEvents firedid As ColumnHeader
    Friend WithEvents fname As ColumnHeader
    Friend WithEvents lname As ColumnHeader
    Friend WithEvents status As ColumnHeader
End Class
