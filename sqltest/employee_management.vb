Imports System.Runtime.CompilerServices
Imports MySql.Data.MySqlClient
Imports System.Data
Imports System.Drawing.Text

Public Class employee_management

    ' This is a connection
    Dim my_conn As MySqlConnection
    Dim my_command As MySqlCommand
    Dim my_adapter As MySqlDataAdapter

    Private Sub employee_management_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ' Automatically Loads the table into ListView
        my_conn = New MySqlConnection
        my_conn.ConnectionString = "server=localhost;userid=root;password=1234;database=gamestocks"
        Dim my_reader As MySqlDataReader

        Try

            my_conn.Open()
            Dim my_query As String

            ' EMPLOYEE LIST '
            my_adapter = New MySqlDataAdapter("select * from employee", my_conn)
            Dim my_data_table As New DataTable
            my_adapter.Fill(my_data_table)
            employeeList.Items.Clear()

            For Each data_row As DataRow In my_data_table.Rows
                employeeList.Items.Add(data_row(0).ToString())  ' Adds the first Column
                employeeList.Items(employeeList.Items.Count - 1).SubItems.Add(data_row(1).ToString())
                employeeList.Items(employeeList.Items.Count - 1).SubItems.Add(data_row(2).ToString())
                employeeList.Items(employeeList.Items.Count - 1).SubItems.Add(data_row(3).ToString())
                employeeList.Items(employeeList.Items.Count - 1).SubItems.Add(data_row(4).ToString())
                employeeList.Items(employeeList.Items.Count - 1).SubItems.Add(data_row(5).ToString())
            Next

            ' PROFESSION LIST '
            my_adapter = New MySqlDataAdapter("select * from employeeprofession", my_conn)
            Dim my_data_table2 As New DataTable
            my_adapter.Fill(my_data_table2)
            professionList.Items.Clear()

            For Each data_row2 As DataRow In my_data_table2.Rows
                professionList.Items.Add(data_row2(0).ToString())  ' Adds the first Column
                professionList.Items(professionList.Items.Count - 1).SubItems.Add(data_row2(1).ToString())
                professionList.Items(professionList.Items.Count - 1).SubItems.Add(data_row2(2).ToString())
            Next

            my_conn.Close()

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error!")
        End Try

    End Sub

    ' Refresh Btn
    Private Sub refBtn_Click(sender As Object, e As EventArgs) Handles refBtn.Click
        ' Automatically Loads the table into ListView
        my_conn = New MySqlConnection
        my_conn.ConnectionString = "server=localhost;userid=root;password=1234;database=gamestocks"
        Dim my_reader As MySqlDataReader

        Try

            my_conn.Open()
            Dim my_query As String

            ' EMPLOYEE LIST '
            my_adapter = New MySqlDataAdapter("select * from employee", my_conn)
            Dim my_data_table As New DataTable
            my_adapter.Fill(my_data_table)
            employeeList.Items.Clear()

            For Each data_row As DataRow In my_data_table.Rows
                employeeList.Items.Add(data_row(0).ToString())  ' Adds the first Column
                employeeList.Items(employeeList.Items.Count - 1).SubItems.Add(data_row(1).ToString())
                employeeList.Items(employeeList.Items.Count - 1).SubItems.Add(data_row(2).ToString())
                employeeList.Items(employeeList.Items.Count - 1).SubItems.Add(data_row(3).ToString())
                employeeList.Items(employeeList.Items.Count - 1).SubItems.Add(data_row(4).ToString())
                employeeList.Items(employeeList.Items.Count - 1).SubItems.Add(data_row(5).ToString())
            Next

            ' PROFESSION LIST '
            my_adapter = New MySqlDataAdapter("select * from employeeprofession", my_conn)
            Dim my_data_table2 As New DataTable
            my_adapter.Fill(my_data_table2)
            professionList.Items.Clear()

            For Each data_row2 As DataRow In my_data_table2.Rows
                professionList.Items.Add(data_row2(0).ToString())  ' Adds the first Column
                professionList.Items(professionList.Items.Count - 1).SubItems.Add(data_row2(1).ToString())
                professionList.Items(professionList.Items.Count - 1).SubItems.Add(data_row2(2).ToString())
            Next

            my_conn.Close()

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error!")
        End Try
    End Sub

    ' Profession List CLick Event '
    Private Sub professionList_SelectedIndexChanged(sender As Object, e As EventArgs) Handles professionList.SelectedIndexChanged
        If professionList.SelectedItems.Count > 0 Then
            Dim items As ListViewItem = professionList.SelectedItems(0)
            profidBox.Text = items.SubItems(0).Text
            profnameBox.Text = items.SubItems(1).Text
            profincomeBox.Text = items.SubItems(2).Text
        End If
    End Sub

    ' Profession Add Button
    Private Sub profaddBtn_Click(sender As Object, e As EventArgs) Handles profaddBtn.Click

        my_conn = New MySqlConnection
        my_conn.ConnectionString = "server=localhost;userid=root;password=1234;database=gamestocks"

        Try

            my_conn.Open()
            my_command = New MySqlCommand("INSERT INTO `gamestocks`.`employeeprofession` (`profession_name`, `daily_income`) VALUES (@profname, @profincome)", my_conn)

            my_command.Parameters.Add("@profname", MySqlDbType.VarChar).Value = profnameBox.Text
            my_command.Parameters.Add("@profincome", MySqlDbType.VarChar).Value = profincomeBox.Text

            If my_command.ExecuteNonQuery() = 1 Then
                MsgBox("Data added successfully!", MsgBoxStyle.Information, "Information")
            Else
                MsgBox("Data not ADDED!", MsgBoxStyle.Critical, "Error!")
            End If

            my_conn.Close()
            profidBox.Text = ""
            profnameBox.Text = ""
            profincomeBox.Text = ""

        Catch ex As Exception

            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error!")

        End Try

    End Sub

    ' Profession Update Button
    Private Sub profupdBtn_Click(sender As Object, e As EventArgs) Handles profupdBtn.Click
        my_conn = New MySqlConnection
        my_conn.ConnectionString = "server=localhost;userid=root;password=1234;database=gamestocks"

        Try

            my_conn.Open()
            my_command = New MySqlCommand("UPDATE `gamestocks`.`employeeprofession` SET `profession_name` = @profname, `daily_income` = @profincome WHERE (`prof_id` = @profid)", my_conn)

            my_command.Parameters.Add("@profid", MySqlDbType.VarChar).Value = profidBox.Text
            my_command.Parameters.Add("@profname", MySqlDbType.VarChar).Value = profnameBox.Text
            my_command.Parameters.Add("@profincome", MySqlDbType.VarChar).Value = profincomeBox.Text

            If my_command.ExecuteNonQuery() = 1 Then
                MsgBox("Data updated successfully!", MsgBoxStyle.Information, "Information")
            Else
                MsgBox("Data not UPDATED!", MsgBoxStyle.Critical, "Error!")
            End If

            my_conn.Close()
            profidBox.Text = ""
            profnameBox.Text = ""
            profincomeBox.Text = ""

        Catch ex As Exception

            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error!")

        End Try
    End Sub

    ' Profession Delete Button
    Private Sub profdelBtn_Click(sender As Object, e As EventArgs) Handles profdelBtn.Click
        my_conn = New MySqlConnection
        my_conn.ConnectionString = "server=localhost;userid=root;password=1234;database=gamestocks"

        Try

            my_conn.Open()
            my_command = New MySqlCommand("DELETE FROM `gamestocks`.`employeeprofession` WHERE (`prof_id` = @profid)", my_conn)

            my_command.Parameters.Add("@profid", MySqlDbType.VarChar).Value = profidBox.Text
            my_command.Parameters.Add("@profname", MySqlDbType.VarChar).Value = profnameBox.Text
            my_command.Parameters.Add("@profincome", MySqlDbType.VarChar).Value = profincomeBox.Text

            If my_command.ExecuteNonQuery() = 1 Then
                MsgBox("Data deleted successfully!", MsgBoxStyle.Information, "Information")
            Else
                MsgBox("Data not DELETED!", MsgBoxStyle.Critical, "Error!")
            End If

            my_conn.Close()
            profidBox.Text = ""
            profnameBox.Text = ""
            profincomeBox.Text = ""

        Catch ex As Exception

            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error!")

        End Try
    End Sub

    ' Employee List
    Private Sub employeeList_SelectedIndexChanged(sender As Object, e As EventArgs) Handles employeeList.SelectedIndexChanged
        If employeeList.SelectedItems.Count > 0 Then
            Dim items As ListViewItem = employeeList.SelectedItems(0)
            employeeidBox.Text = items.SubItems(0).Text
            employeefnameBox.Text = items.SubItems(1).Text
            employeemnameBox.Text = items.SubItems(2).Text
            employeelnameBox.Text = items.SubItems(3).Text
            employeeprofBox.Text = items.SubItems(4).Text
            employeedateBox.Text = items.SubItems(5).Text
        End If
    End Sub

    ' Add Button
    Private Sub employeeaddbtn_Click(sender As Object, e As EventArgs) Handles employeeaddbtn.Click
        my_conn = New MySqlConnection
        my_conn.ConnectionString = "server=localhost;userid=root;password=1234;database=gamestocks"

        Try

            my_conn.Open()
            my_command = New MySqlCommand("INSERT INTO `gamestocks`.`employee` (`fname`, `mname`, `lname`, `profession_id`, `date_started`) VALUES (@employfname, @employmname, @employlname, @employprof, @employdate)", my_conn)

            my_command.Parameters.Add("@employid", MySqlDbType.Int64).Value = employeeidBox.Text
            my_command.Parameters.Add("@employfname", MySqlDbType.VarChar).Value = employeefnameBox.Text
            my_command.Parameters.Add("@employmname", MySqlDbType.VarChar).Value = employeemnameBox.Text
            my_command.Parameters.Add("@employlname", MySqlDbType.VarChar).Value = employeelnameBox.Text
            my_command.Parameters.Add("@employprof", MySqlDbType.Int64).Value = employeeprofBox.Text
            my_command.Parameters.Add("@employdate", MySqlDbType.VarChar).Value = employeedateBox.Text

            If my_command.ExecuteNonQuery() = 1 Then
                MsgBox("Data added successfully!", MsgBoxStyle.Information, "Information")
            Else
                MsgBox("Data not ADDED!", MsgBoxStyle.Critical, "Error!")
            End If

            my_conn.Close()
            employeeidBox.Text = ""
            employeefnameBox.Text = ""
            employeemnameBox.Text = ""
            employeelnameBox.Text = ""
            employeeprofBox.Text = ""
            employeedateBox.Text = ""

        Catch ex As Exception

            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error!")

        End Try
    End Sub

    ' Update Button
    Private Sub employeeupdbtn_Click(sender As Object, e As EventArgs) Handles employeeupdbtn.Click
        my_conn = New MySqlConnection
        my_conn.ConnectionString = "server=localhost;userid=root;password=1234;database=gamestocks"

        Try

            my_conn.Open()
            my_command = New MySqlCommand("UPDATE `gamestocks`.`employee` SET `fname` = @employfname, `mname` = @employmname, `lname` = @employlname, `profession_id` = @employprof, `date_started` = @employdate WHERE (`employee_id` = @employid)", my_conn)

            my_command.Parameters.Add("@employid", MySqlDbType.Int64).Value = employeeidBox.Text
            my_command.Parameters.Add("@employfname", MySqlDbType.VarChar).Value = employeefnameBox.Text
            my_command.Parameters.Add("@employmname", MySqlDbType.VarChar).Value = employeemnameBox.Text
            my_command.Parameters.Add("@employlname", MySqlDbType.VarChar).Value = employeelnameBox.Text
            my_command.Parameters.Add("@employprof", MySqlDbType.Int64).Value = employeeprofBox.Text
            my_command.Parameters.Add("@employdate", MySqlDbType.VarChar).Value = employeedateBox.Text

            If my_command.ExecuteNonQuery() = 1 Then
                MsgBox("Data updated successfully!", MsgBoxStyle.Information, "Information")
            Else
                MsgBox("Data not UPDATED!", MsgBoxStyle.Critical, "Error!")
            End If

            my_conn.Close()
            employeeidBox.Text = ""
            employeefnameBox.Text = ""
            employeemnameBox.Text = ""
            employeelnameBox.Text = ""
            employeeprofBox.Text = ""
            employeedateBox.Text = ""

        Catch ex As Exception

            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error!")

        End Try
    End Sub

    ' Delete Button
    Private Sub employeedelbtn_Click(sender As Object, e As EventArgs) Handles employeedelbtn.Click

        my_conn = New MySqlConnection
        my_conn.ConnectionString = "server=localhost;userid=root;password=1234;database=gamestocks"

        Try

            my_conn.Open()
            my_command = New MySqlCommand("DELETE FROM `gamestocks`.`employee` WHERE (`employee_id` = @employid)", my_conn)

            my_command.Parameters.Add("@employid", MySqlDbType.Int64).Value = employeeidBox.Text
            my_command.Parameters.Add("@employfname", MySqlDbType.VarChar).Value = employeefnameBox.Text
            my_command.Parameters.Add("@employmname", MySqlDbType.VarChar).Value = employeemnameBox.Text
            my_command.Parameters.Add("@employlname", MySqlDbType.VarChar).Value = employeelnameBox.Text
            my_command.Parameters.Add("@employprof", MySqlDbType.Int64).Value = employeeprofBox.Text
            my_command.Parameters.Add("@employdate", MySqlDbType.VarChar).Value = employeedateBox.Text

            If my_command.ExecuteNonQuery() = 1 Then
                MsgBox("Data deleted successfully!", MsgBoxStyle.Information, "Information")
            Else
                MsgBox("Data not DELETED!", MsgBoxStyle.Critical, "Error!")
            End If

            my_conn.Close()
            employeeidBox.Text = ""
            employeefnameBox.Text = ""
            employeemnameBox.Text = ""
            employeelnameBox.Text = ""
            employeeprofBox.Text = ""
            employeedateBox.Text = ""

        Catch ex As Exception

            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error!")

        End Try

    End Sub

End Class