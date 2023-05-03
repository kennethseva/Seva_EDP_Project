Imports System.Runtime.CompilerServices
Imports MySql.Data.MySqlClient
Imports System.Data
Public Class employee

    ' This is a connection
    Dim my_conn As MySqlConnection
    Dim my_command As MySqlCommand
    Dim my_adapter As MySqlDataAdapter

    ' Main Load/ Employee Form Load
    Private Sub employee_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ' Use to load data
        my_conn = New MySqlConnection
        my_conn.ConnectionString = "server=localhost;userid=root;password=1234;database=gamestocks"
        Dim my_reader As MySqlDataReader

        Try
            my_conn.Open()
            Dim my_query As String

            my_adapter = New MySqlDataAdapter("select * from gamestocks.employee_report", my_conn)
            Dim my_data_table As New DataTable
            my_adapter.Fill(my_data_table)
            employee_list.Items.Clear()

            For Each data_row As DataRow In my_data_table.Rows
                employee_list.Items.Add(data_row(0).ToString())
                employee_list.Items(employee_list.Items.Count - 1).SubItems.Add(data_row(1).ToString())
                employee_list.Items(employee_list.Items.Count - 1).SubItems.Add(data_row(2).ToString())
                employee_list.Items(employee_list.Items.Count - 1).SubItems.Add(data_row(3).ToString())
            Next
            my_conn.Close()

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error!")
        End Try

    End Sub

    ' Connection Test Button Function
    Private Sub test_btn_Click(sender As Object, e As EventArgs) Handles test_btn.Click
        my_conn = New MySqlConnection
        my_conn.ConnectionString = "server=localhost;userid=root;password=1234;database=gamestocks"

        Try
            my_conn.Open()
            MessageBox.Show("Connect Test success")
            my_conn.Close()

        Catch ex As MySqlException
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error in your Connection String!")

        Finally
            my_conn.Dispose()

        End Try
    End Sub

    Private Sub refresh_btn_Click(sender As Object, e As EventArgs) Handles refresh_btn.Click

        my_conn = New MySqlConnection
        my_conn.ConnectionString = "server=localhost;userid=root;password=1234;database=gamestocks"
        Dim my_reader As MySqlDataReader

        Try
            my_conn.Open()
            Dim my_query As String

            my_adapter = New MySqlDataAdapter("select * from gamestocks.employee_report", my_conn)
            Dim my_data_table As New DataTable
            my_adapter.Fill(my_data_table)
            employee_list.Items.Clear()

            For Each data_row As DataRow In my_data_table.Rows
                employee_list.Items.Add(data_row(0).ToString())
                employee_list.Items(employee_list.Items.Count - 1).SubItems.Add(data_row(1).ToString())
                employee_list.Items(employee_list.Items.Count - 1).SubItems.Add(data_row(2).ToString())
                employee_list.Items(employee_list.Items.Count - 1).SubItems.Add(data_row(3).ToString())
            Next
            my_conn.Close()

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error!")
        End Try

    End Sub

    ' Manage Button
    Private Sub manage_btn_Click(sender As Object, e As EventArgs) Handles manage_btn.Click
        Me.Close()
        employee_management.Show()
    End Sub
End Class