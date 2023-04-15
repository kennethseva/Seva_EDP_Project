Imports System.Runtime.CompilerServices
Imports MySql.Data.MySqlClient

Public Class Form1

    ' This is a connection
    Dim my_conn As MySqlConnection
    Dim my_command As MySqlCommand



    ' Function for Test Connection
    Private Sub check_btn_Click(sender As Object, e As EventArgs) Handles check_btn.Click
        my_conn = New MySqlConnection
        my_conn.ConnectionString = "server=localhost;userid=root;password=1234;database=gamestocks"

        Try
            my_conn.Open()
            MessageBox.Show("Connect Test success")
            my_conn.Close()

        Catch ex As MySqlException
            MessageBox.Show(ex.Message)

        Finally
            my_conn.Dispose()

        End Try

    End Sub

    ' Function for Login
    Private Sub log_btn_Click(sender As Object, e As EventArgs) Handles log_btn.Click
        my_conn = New MySqlConnection
        my_conn.ConnectionString = "server=localhost;userid=root;password=1234;database=gamestocks"
        Dim my_reader As MySqlDataReader


        Try
            my_conn.Open()
            Dim my_query As String

            my_query = "select * from gamestocks.employee where fname='" & fname_box.Text & "' and lname='" & lname_box.Text & "'"
            my_command = New MySqlCommand(my_query, my_conn)
            my_reader = my_command.ExecuteReader
            Dim count As Integer
            count = 0

            While my_reader.Read
                count = count + 1

            End While

            If count = 1 Then
                MessageBox.Show("Welcome " & fname_box.Text & " " & lname_box.Text)

                Dim dashboard_form As New dashboard
                dashboard_form.welcome_string = "Welcome " + fname_box.Text + " " + lname_box.Text
                dashboard_form.Show()

                Me.Close()

            ElseIf count > 1 Then
                MessageBox.Show("Fname and Lname are Duplicate")
            Else
                MessageBox.Show("Fname and Lname are not correct")
            End If

            my_conn.Close()

        Catch ex As MySqlException
            MessageBox.Show(ex.Message)

        Finally
            my_conn.Dispose()

        End Try

    End Sub

End Class
