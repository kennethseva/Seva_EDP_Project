Imports System.Runtime.CompilerServices
Imports MySql.Data.MySqlClient
Imports System.Data
Public Class brands

    ' This is a connection
    Dim my_conn As MySqlConnection
    Dim my_command As MySqlCommand
    Dim my_adapter As MySqlDataAdapter

    ' Main Screen / Form Load
    Private Sub brands_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ' Try to load the data
        my_conn = New MySqlConnection
        my_conn.ConnectionString = "server=localhost;userid=root;password=1234;database=gamestocks"
        Dim my_reader As MySqlDataReader

        Try
            my_conn.Open()
            Dim my_query As String

            my_adapter = New MySqlDataAdapter("select * from gamestocks.producttypes", my_conn)
            Dim my_data_table As New DataTable
            my_adapter.Fill(my_data_table)
            type_list.Items.Clear()

            For Each data_row As DataRow In my_data_table.Rows
                type_list.Items.Add(data_row(0).ToString())
                type_list.Items(type_list.Items.Count - 1).SubItems.Add(data_row(1).ToString())
            Next

            my_adapter = New MySqlDataAdapter("select * from gamestocks.productbrands", my_conn)
            Dim my_data_table2 As New DataTable
            my_adapter.Fill(my_data_table2)
            brand_list.Items.Clear()

            For Each data_row2 As DataRow In my_data_table2.Rows
                brand_list.Items.Add(data_row2(0).ToString())
                brand_list.Items(brand_list.Items.Count - 1).SubItems.Add(data_row2(1).ToString())
            Next

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error!")
        End Try
        my_conn.Close()

    End Sub

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

    ' Refresh the table
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        my_conn = New MySqlConnection
        my_conn.ConnectionString = "server=localhost;userid=root;password=1234;database=gamestocks"
        Dim my_reader As MySqlDataReader

        Try
            my_conn.Open()
            Dim my_query As String

            my_adapter = New MySqlDataAdapter("select * from gamestocks.producttypes", my_conn)
            Dim my_data_table As New DataTable
            my_adapter.Fill(my_data_table)
            type_list.Items.Clear()

            For Each data_row As DataRow In my_data_table.Rows
                type_list.Items.Add(data_row(0).ToString())
                type_list.Items(type_list.Items.Count - 1).SubItems.Add(data_row(1).ToString())
            Next

            my_adapter = New MySqlDataAdapter("select * from gamestocks.productbrands", my_conn)
            Dim my_data_table2 As New DataTable
            my_adapter.Fill(my_data_table2)
            brand_list.Items.Clear()

            For Each data_row2 As DataRow In my_data_table2.Rows
                brand_list.Items.Add(data_row2(0).ToString())
                brand_list.Items(brand_list.Items.Count - 1).SubItems.Add(data_row2(1).ToString())
            Next
            my_conn.Close()

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error!")
        End Try

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub manage_btn_Click(sender As Object, e As EventArgs) Handles manage_btn.Click
        Me.Close()
        stocks_crud.Show()
    End Sub
End Class