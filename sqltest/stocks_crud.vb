Imports System.Runtime.CompilerServices
Imports MySql.Data.MySqlClient
Imports System.Data
Imports System.Drawing.Text

Public Class stocks_crud

    Private sampleText1 As New List(Of String)

    ' This is a connection
    Dim my_conn As MySqlConnection
    Dim my_command As MySqlCommand
    Dim my_adapter As MySqlDataAdapter

    ' Main Screen
    Private Sub stocks_crud_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ' Automatically Loads the table into ListView
        my_conn = New MySqlConnection
        my_conn.ConnectionString = "server=localhost;userid=root;password=1234;database=gamestocks"
        Dim my_reader As MySqlDataReader

        Try
            my_conn.Open()
            Dim my_query As String

            my_adapter = New MySqlDataAdapter("select * from products", my_conn)
            Dim my_data_table As New DataTable
            my_adapter.Fill(my_data_table)
            product_list.Items.Clear()

            For Each data_row As DataRow In my_data_table.Rows
                product_list.Items.Add(data_row(0).ToString())  ' Adds the first Column
                product_list.Items(product_list.Items.Count - 1).SubItems.Add(data_row(1).ToString())
                product_list.Items(product_list.Items.Count - 1).SubItems.Add(data_row(2).ToString())
                product_list.Items(product_list.Items.Count - 1).SubItems.Add(data_row(3).ToString())
                product_list.Items(product_list.Items.Count - 1).SubItems.Add(data_row(4).ToString())
                product_list.Items(product_list.Items.Count - 1).SubItems.Add(data_row(5).ToString())

            Next

            my_adapter = New MySqlDataAdapter("select * from gamestocks.producttypes", my_conn)
            Dim my_data_table2 As New DataTable
            my_adapter.Fill(my_data_table2)
            type_list.Items.Clear()

            For Each data_row2 As DataRow In my_data_table2.Rows
                type_list.Items.Add(data_row2(0).ToString())
                type_list.Items(type_list.Items.Count - 1).SubItems.Add(data_row2(1).ToString())
            Next

            my_adapter = New MySqlDataAdapter("select * from gamestocks.productbrands", my_conn)
            Dim my_data_table3 As New DataTable
            my_adapter.Fill(my_data_table3)
            brand_list.Items.Clear()

            For Each data_row3 As DataRow In my_data_table3.Rows
                brand_list.Items.Add(data_row3(0).ToString())
                brand_list.Items(brand_list.Items.Count - 1).SubItems.Add(data_row3(1).ToString())
            Next
            my_conn.Close()

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error!")
        End Try
        ' End of Loading data to table '

    End Sub

    ' Test Connection Button
    Private Sub btn_conn_Click(sender As Object, e As EventArgs) Handles btn_conn.Click
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

    ' Go Back Button
    Private Sub back_btn_Click(sender As Object, e As EventArgs) Handles back_btn.Click
        Me.Close()
        stocks.Show()
    End Sub

    ' Search for their Names
    Private Sub search_btn_Click(sender As Object, e As EventArgs) Handles search_btn.Click

        product_list.SelectedItems.Clear()
        For i = 0 To product_list.Items.Count - 1
            If product_list.Items(i).SubItems(0).Text = searchBox.Text Then
                product_list.Items(i).Selected = True
                productBox.Text = product_list.SelectedItems(0).SubItems(0).Text
                quantityBox.Text = product_list.SelectedItems(0).SubItems(1).Text
                dateBox.Text = product_list.SelectedItems(0).SubItems(2).Text
                typeBox.Text = product_list.SelectedItems(0).SubItems(3).Text
                brandBox.Text = product_list.SelectedItems(0).SubItems(4).Text
            End If
        Next
        product_list.Focus()
    End Sub

    ' Refresh Btn
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles refresh_btn.Click
        ' Automatically Loads the table into ListView
        my_conn = New MySqlConnection
        my_conn.ConnectionString = "server=localhost;userid=root;password=1234;database=gamestocks"
        Dim my_reader As MySqlDataReader

        Try
            my_conn.Open()
            Dim my_query As String

            my_adapter = New MySqlDataAdapter("select * from products", my_conn)
            Dim my_data_table As New DataTable
            my_adapter.Fill(my_data_table)
            product_list.Items.Clear()

            For Each data_row As DataRow In my_data_table.Rows
                product_list.Items.Add(data_row(0).ToString())  ' Adds the first Column
                product_list.Items(product_list.Items.Count - 1).SubItems.Add(data_row(1).ToString())
                product_list.Items(product_list.Items.Count - 1).SubItems.Add(data_row(2).ToString())
                product_list.Items(product_list.Items.Count - 1).SubItems.Add(data_row(3).ToString())
                product_list.Items(product_list.Items.Count - 1).SubItems.Add(data_row(4).ToString())
                product_list.Items(product_list.Items.Count - 1).SubItems.Add(data_row(5).ToString())

            Next

            my_adapter = New MySqlDataAdapter("select * from gamestocks.producttypes", my_conn)
            Dim my_data_table2 As New DataTable
            my_adapter.Fill(my_data_table2)
            type_list.Items.Clear()

            For Each data_row2 As DataRow In my_data_table2.Rows
                type_list.Items.Add(data_row2(0).ToString())
                type_list.Items(type_list.Items.Count - 1).SubItems.Add(data_row2(1).ToString())
            Next

            my_adapter = New MySqlDataAdapter("select * from gamestocks.productbrands", my_conn)
            Dim my_data_table3 As New DataTable
            my_adapter.Fill(my_data_table3)
            brand_list.Items.Clear()

            For Each data_row3 As DataRow In my_data_table3.Rows
                brand_list.Items.Add(data_row3(0).ToString())
                brand_list.Items(brand_list.Items.Count - 1).SubItems.Add(data_row3(1).ToString())
            Next
            my_conn.Close()

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error!")
        End Try
        ' End of Loading data to table '
    End Sub

    ' Insert New Item
    Private Sub addBtn_Click(sender As Object, e As EventArgs) Handles addBtn.Click

        my_conn = New MySqlConnection
        my_conn.ConnectionString = "server=localhost;userid=root;password=1234;database=gamestocks"

        Try

            my_conn.Open()
            my_command = New MySqlCommand("INSERT INTO `gamestocks`.`products` (`product_name`, `date_of_arrival`, `product_type_id`, `product_quantity`, `product_brand`) VALUES (@pname, @pdate, @ptype, @pquantity, @pbrand)", my_conn)

            my_command.Parameters.Add("@pname", MySqlDbType.VarChar).Value = productBox.Text
            my_command.Parameters.Add("@pdate", MySqlDbType.VarChar).Value = dateBox.Text
            my_command.Parameters.Add("@ptype", MySqlDbType.Int64).Value = typeBox.Text
            my_command.Parameters.Add("@pquantity", MySqlDbType.VarChar).Value = quantityBox.Text
            my_command.Parameters.Add("@pbrand", MySqlDbType.Int64).Value = brandBox.Text

            If my_command.ExecuteNonQuery() = 1 Then

                MsgBox("Data added successfully!", MsgBoxStyle.Information, "Information")
            Else
                MsgBox("Data not ADDED!", MsgBoxStyle.Critical, "Error!")

            End If

            my_conn.Close()
            idbox.Text = ""
            productBox.Text = ""
            dateBox.Text = ""
            typeBox.Text = ""
            quantityBox.Text = ""
            brandBox.Text = ""

        Catch ex As Exception

            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error!")

        End Try

    End Sub

    ' Selected Items Event
    Private Sub product_list_SelectedIndexChanged(sender As Object, e As EventArgs) Handles product_list.SelectedIndexChanged

        If product_list.SelectedItems.Count > 0 Then
            Dim items As ListViewItem = product_list.SelectedItems(0)
            idbox.Text = items.SubItems(0).Text
            productBox.Text = items.SubItems(1).Text
            quantityBox.Text = items.SubItems(4).Text
            dateBox.Text = items.SubItems(2).Text
            typeBox.Text = items.SubItems(3).Text
            brandBox.Text = items.SubItems(5).Text
        End If

    End Sub

    ' Item Update
    Private Sub updateBtn_Click(sender As Object, e As EventArgs) Handles updateBtn.Click

        my_conn = New MySqlConnection
        my_conn.ConnectionString = "server=localhost;userid=root;password=1234;database=gamestocks"

        Try

            my_conn.Open()
            my_command = New MySqlCommand("UPDATE `gamestocks`.`products` SET `product_name` = @pname, `date_of_arrival` = @pdate, `product_type_id` = @ptype, `product_quantity` = @pquantity, `product_brand` = @pbrand WHERE (`products_id` = @pid)", my_conn)

            my_command.Parameters.Add("@pid", MySqlDbType.Int64).Value = idbox.Text
            my_command.Parameters.Add("@pname", MySqlDbType.VarChar).Value = productBox.Text
            my_command.Parameters.Add("@pdate", MySqlDbType.VarChar).Value = dateBox.Text
            my_command.Parameters.Add("@ptype", MySqlDbType.Int64).Value = typeBox.Text
            my_command.Parameters.Add("@pquantity", MySqlDbType.VarChar).Value = quantityBox.Text
            my_command.Parameters.Add("@pbrand", MySqlDbType.Int64).Value = brandBox.Text

            If my_command.ExecuteNonQuery() = 1 Then

                MsgBox("Data updated successfully!", MsgBoxStyle.Information, "Information")
            Else
                MsgBox("Data not UPDATED!", MsgBoxStyle.Critical, "Error!")

            End If

            my_conn.Close()
            idbox.Text = ""
            productBox.Text = ""
            dateBox.Text = ""
            typeBox.Text = ""
            quantityBox.Text = ""
            brandBox.Text = ""

        Catch ex As Exception

            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error!")

        End Try

    End Sub

    ' Delete Button
    Private Sub deleteBtn_Click(sender As Object, e As EventArgs) Handles deleteBtn.Click

        my_conn = New MySqlConnection
        my_conn.ConnectionString = "server=localhost;userid=root;password=1234;database=gamestocks"

        Try

            my_conn.Open()
            my_command = New MySqlCommand("DELETE FROM `gamestocks`.`products` WHERE (`products_id` = @pid)", my_conn)

            my_command.Parameters.Add("@pid", MySqlDbType.Int64).Value = idbox.Text

            If my_command.ExecuteNonQuery() = 1 Then

                MsgBox("Data deleted successfully!", MsgBoxStyle.Information, "Information")
            Else
                MsgBox("Data not DELETED!", MsgBoxStyle.Critical, "Error!")

            End If

            my_conn.Close()
            idbox.Text = ""
            productBox.Text = ""
            dateBox.Text = ""
            typeBox.Text = ""
            quantityBox.Text = ""
            brandBox.Text = ""

        Catch ex As Exception

            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error!")

        End Try

    End Sub

    ' Type List to TextBox
    Private Sub type_list_SelectedIndexChanged(sender As Object, e As EventArgs) Handles type_list.SelectedIndexChanged
        If type_list.SelectedItems.Count > 0 Then
            Dim items As ListViewItem = type_list.SelectedItems(0)
            tbidBox.Text = items.SubItems(0).Text
            tbnameBox.Text = items.SubItems(1).Text
        End If
    End Sub

    ' Brand List TextBox
    Private Sub brand_list_SelectedIndexChanged(sender As Object, e As EventArgs) Handles brand_list.SelectedIndexChanged
        If brand_list.SelectedItems.Count > 0 Then
            Dim items As ListViewItem = brand_list.SelectedItems(0)
            tbidBox.Text = items.SubItems(0).Text
            tbnameBox.Text = items.SubItems(1).Text
        End If
    End Sub

    ' Add type BTN
    Private Sub addtypeBtn_Click(sender As Object, e As EventArgs) Handles addtypeBtn.Click
        my_conn = New MySqlConnection
        my_conn.ConnectionString = "server=localhost;userid=root;password=1234;database=gamestocks"

        Try

            my_conn.Open()
            my_command = New MySqlCommand("INSERT INTO `gamestocks`.`producttypes` (`types_id`, `product_type`) VALUES (@ptypeid, @ptypename)", my_conn)

            my_command.Parameters.Add("@ptypeid", MySqlDbType.VarChar).Value = tbidBox.Text
            my_command.Parameters.Add("@ptypename", MySqlDbType.VarChar).Value = tbnameBox.Text

            If my_command.ExecuteNonQuery() = 1 Then

                MsgBox("Data added successfully!", MsgBoxStyle.Information, "Information")
            Else
                MsgBox("Data not ADDED!", MsgBoxStyle.Critical, "Error!")

            End If

            my_conn.Close()
            tbidBox.Text = ""
            tbnameBox.Text = ""

        Catch ex As Exception

            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error!")

        End Try
    End Sub

    ' Update Button
    Private Sub updtypeBtn_Click(sender As Object, e As EventArgs) Handles updtypeBtn.Click
        my_conn = New MySqlConnection
        my_conn.ConnectionString = "server=localhost;userid=root;password=1234;database=gamestocks"

        Try

            my_conn.Open()
            my_command = New MySqlCommand("UPDATE `gamestocks`.`producttypes` SET `product_type` = @ptypename WHERE (`types_id` = @ptypeid)", my_conn)

            my_command.Parameters.Add("@ptypeid", MySqlDbType.VarChar).Value = tbidBox.Text
            my_command.Parameters.Add("@ptypename", MySqlDbType.VarChar).Value = tbnameBox.Text

            If my_command.ExecuteNonQuery() = 1 Then

                MsgBox("Data added successfully!", MsgBoxStyle.Information, "Information")
            Else
                MsgBox("Data not UPDATED!", MsgBoxStyle.Critical, "Error!")

            End If

            my_conn.Close()
            tbidBox.Text = ""
            tbnameBox.Text = ""

        Catch ex As Exception

            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error!")

        End Try
    End Sub

    ' Del Button
    Private Sub deltypeBtn_Click(sender As Object, e As EventArgs) Handles deltypeBtn.Click
        my_conn = New MySqlConnection
        my_conn.ConnectionString = "server=localhost;userid=root;password=1234;database=gamestocks"

        Try

            my_conn.Open()
            my_command = New MySqlCommand("DELETE FROM `gamestocks`.`producttypes` WHERE (`types_id` = @ptypeid)", my_conn)

            my_command.Parameters.Add("@ptypeid", MySqlDbType.VarChar).Value = tbidBox.Text
            my_command.Parameters.Add("@ptypename", MySqlDbType.VarChar).Value = tbnameBox.Text

            If my_command.ExecuteNonQuery() = 1 Then

                MsgBox("Data added successfully!", MsgBoxStyle.Information, "Information")
            Else
                MsgBox("Data not Deleted!", MsgBoxStyle.Critical, "Error!")

            End If

            my_conn.Close()
            tbidBox.Text = ""
            tbnameBox.Text = ""

        Catch ex As Exception

            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error!")

        End Try
    End Sub

    ' Update Brand Button
    Private Sub updbrandBtn_Click(sender As Object, e As EventArgs) Handles updbrandBtn.Click
        my_conn = New MySqlConnection
        my_conn.ConnectionString = "server=localhost;userid=root;password=1234;database=gamestocks"

        Try

            my_conn.Open()
            my_command = New MySqlCommand("UPDATE `gamestocks`.`productbrands` SET `brand_name` = @ptypename WHERE (`brand_id` = @ptypeid);", my_conn)

            my_command.Parameters.Add("@ptypeid", MySqlDbType.VarChar).Value = tbidBox.Text
            my_command.Parameters.Add("@ptypename", MySqlDbType.VarChar).Value = tbnameBox.Text

            If my_command.ExecuteNonQuery() = 1 Then

                MsgBox("Data updated successfully!", MsgBoxStyle.Information, "Information")
            Else
                MsgBox("Data not UPDATED!", MsgBoxStyle.Critical, "Error!")

            End If

            my_conn.Close()
            tbidBox.Text = ""
            tbnameBox.Text = ""

        Catch ex As Exception

            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error!")

        End Try
    End Sub

    ' Add Braddn Button
    Private Sub addbrandBtn_Click(sender As Object, e As EventArgs) Handles addbrandBtn.Click
        my_conn = New MySqlConnection
        my_conn.ConnectionString = "server=localhost;userid=root;password=1234;database=gamestocks"

        Try

            my_conn.Open()
            my_command = New MySqlCommand("INSERT INTO `gamestocks`.`productbrands` (`brand_name`) VALUES (@ptypename)", my_conn)

            my_command.Parameters.Add("@ptypeid", MySqlDbType.VarChar).Value = tbidBox.Text
            my_command.Parameters.Add("@ptypename", MySqlDbType.VarChar).Value = tbnameBox.Text

            If my_command.ExecuteNonQuery() = 1 Then

                MsgBox("Data added successfully!", MsgBoxStyle.Information, "Information")
            Else
                MsgBox("Data not ADDED!", MsgBoxStyle.Critical, "Error!")

            End If

            my_conn.Close()
            tbidBox.Text = ""
            tbnameBox.Text = ""

        Catch ex As Exception

            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error!")

        End Try
    End Sub

    ' Delete Brand
    Private Sub delbrandBtn_Click(sender As Object, e As EventArgs) Handles delbrandBtn.Click
        my_conn = New MySqlConnection
        my_conn.ConnectionString = "server=localhost;userid=root;password=1234;database=gamestocks"

        Try

            my_conn.Open()
            my_command = New MySqlCommand("DELETE FROM `gamestocks`.`productbrands` WHERE (`brand_id` = @ptypeid);", my_conn)

            my_command.Parameters.Add("@ptypeid", MySqlDbType.VarChar).Value = tbidBox.Text
            my_command.Parameters.Add("@ptypename", MySqlDbType.VarChar).Value = tbnameBox.Text

            If my_command.ExecuteNonQuery() = 1 Then

                MsgBox("Data deleted successfully!", MsgBoxStyle.Information, "Information")
            Else
                MsgBox("Data not DELETED!", MsgBoxStyle.Critical, "Error!")

            End If

            my_conn.Close()
            tbidBox.Text = ""
            tbnameBox.Text = ""

        Catch ex As Exception

            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error!")

        End Try
    End Sub
End Class