Imports System.Runtime.CompilerServices
Imports MySql.Data.MySqlClient
Imports System.Data

Public Class stocks

    ' This is a connection
    Dim my_conn As MySqlConnection
    Dim my_command As MySqlCommand
    Dim my_adapter As MySqlDataAdapter


    ' Main Screen
    Private Sub stocks_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ' Automatically Loads the table into ListView
        my_conn = New MySqlConnection
        my_conn.ConnectionString = "server=localhost;userid=root;password=1234;database=gamestocks"
        Dim my_reader As MySqlDataReader

        Try
            my_conn.Open()
            Dim my_query As String

            my_adapter = New MySqlDataAdapter("select * from product_report", my_conn)
            Dim my_data_table As New DataTable
            my_adapter.Fill(my_data_table)
            product_list.Items.Clear()

            For Each data_row As DataRow In my_data_table.Rows
                product_list.Items.Add(data_row(0).ToString())  ' Adds the first Column
                product_list.Items(product_list.Items.Count - 1).SubItems.Add(data_row(1).ToString())
                product_list.Items(product_list.Items.Count - 1).SubItems.Add(data_row(2).ToString())
                product_list.Items(product_list.Items.Count - 1).SubItems.Add(data_row(3).ToString())
                product_list.Items(product_list.Items.Count - 1).SubItems.Add(data_row(4).ToString())
                ' product_list.Items(product_list.Items.Count - 1).SubItems.Add(data_row(5).ToString())

            Next
            my_conn.Close()

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error!")
        End Try
        ' End of Loading data to table '

    End Sub

    ' Checks for Sql Connection
    Private Sub test_Btn_Click(sender As Object, e As EventArgs) Handles test_Btn.Click
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

    ' Use to refresh the table
    Private Sub refresh_btn_Click(sender As Object, e As EventArgs) Handles refresh_btn.Click

        my_conn = New MySqlConnection
        my_conn.ConnectionString = "server=localhost;userid=root;password=1234;database=gamestocks"
        Dim my_reader As MySqlDataReader

        Try
            my_conn.Open()
            Dim my_query As String

            my_adapter = New MySqlDataAdapter("select * from product_report", my_conn)
            Dim my_data_table As New DataTable
            my_adapter.Fill(my_data_table)
            product_list.Items.Clear()

            For Each data_row As DataRow In my_data_table.Rows
                product_list.Items.Add(data_row(0).ToString())  ' Adds the first Column
                product_list.Items(product_list.Items.Count - 1).SubItems.Add(data_row(1).ToString())
                product_list.Items(product_list.Items.Count - 1).SubItems.Add(data_row(2).ToString())
                product_list.Items(product_list.Items.Count - 1).SubItems.Add(data_row(3).ToString())
                product_list.Items(product_list.Items.Count - 1).SubItems.Add(data_row(4).ToString())
                ' product_list.Items(product_list.Items.Count - 1).SubItems.Add(data_row(5).ToString())

            Next
            my_conn.Close()

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error!")
        End Try


    End Sub

    Private Sub back_btn_Click(sender As Object, e As EventArgs) Handles back_btn.Click
        Me.Close()
    End Sub

    Private Sub product_list_DoubleClick(sender As Object, e As EventArgs) Handles product_list.DoubleClick
        MsgBox("Sample CLick Success!!", MsgBoxStyle.Information, "Message Box")
    End Sub

End Class