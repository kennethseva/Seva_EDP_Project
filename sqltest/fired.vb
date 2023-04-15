Imports System.Runtime.CompilerServices
Imports MySql.Data.MySqlClient
Imports System.Data
Public Class fired

    ' This is a connection
    Dim my_conn As MySqlConnection
    Dim my_command As MySqlCommand
    Dim my_adapter As MySqlDataAdapter

    Private Sub fired_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        my_conn = New MySqlConnection
        my_conn.ConnectionString = "server=localhost;userid=root;password=1234;database=gamestocks"
        Dim my_reader As MySqlDataReader

        Try

            my_conn.Open()
            Dim my_query As String

            my_adapter = New MySqlDataAdapter("select * from gamestocks.employeefired", my_conn)
            Dim my_data_table As New DataTable
            my_adapter.Fill(my_data_table)
            fired_list.Items.Clear()

            For Each data_row As DataRow In my_data_table.Rows
                fired_list.Items.Add(data_row(0).ToString())
                fired_list.Items(fired_list.Items.Count - 1).SubItems.Add(data_row(1).ToString())
                fired_list.Items(fired_list.Items.Count - 1).SubItems.Add(data_row(2).ToString())
                fired_list.Items(fired_list.Items.Count - 1).SubItems.Add(data_row(3).ToString())
            Next
            my_conn.Close()

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error!")
        End Try

    End Sub

End Class