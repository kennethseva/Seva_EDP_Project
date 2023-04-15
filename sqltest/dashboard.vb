Public Class dashboard
    ' Gets the string from form 1
    Public Property welcome_string As String

    ' Input the string from form1 through dashboard label
    Private Sub dashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        string_name.Text = welcome_string
        Timer1.Enabled = True

    End Sub

    ' Timer Purposes Only
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        time_label.Text = Date.Now.ToString("dd-MM-yyyy hh:mm:ss")
    End Sub

    ' Goes to Stock Form
    Private Sub stock_btn_Click(sender As Object, e As EventArgs) Handles stock_btn.Click

        stocks.Show()

    End Sub

    ' Goes to Employee Form
    Private Sub employee_btn_Click(sender As Object, e As EventArgs) Handles employee_btn.Click
        employee.Show()
    End Sub

    ' Goes to Brands Form
    Private Sub brands_btn_Click(sender As Object, e As EventArgs) Handles brands_btn.Click
        brands.Show()
    End Sub

    ' Goes to Fired Form
    Private Sub fired_btn_Click(sender As Object, e As EventArgs) Handles fired_btn.Click
        fired.Show()
    End Sub

    Private Sub picture_btn_Click(sender As Object, e As EventArgs) Handles picture_btn.Click
        Form1.Show()
        Me.Close()
        fired.Close()
        employee.Close()
        brands.Close()
        stocks.Close()
    End Sub

    Private Sub csv_btn_Click(sender As Object, e As EventArgs) Handles csv_btn.Click

        frmCSV.Show()

    End Sub

    Private Sub backup_btn_Click(sender As Object, e As EventArgs) Handles backup_btn.Click
        'Show the OpenFileDialog
        Dim open_files As New OpenFileDialog()
        open_files.Filter = "BAT files (*.bat)|*.bat"
        open_files.FilterIndex = 1
        open_files.RestoreDirectory = True

        ' Show dialog file
        If open_files.ShowDialog() = DialogResult.OK Then
            System.Diagnostics.Process.Start(open_files.FileName)
        End If

    End Sub

End Class