Imports System.Data.OleDb
Imports System.IO
Imports System.Text
Imports CsvHelper


Public Class frmCSV
    Private Sub frmCSV_Load(sender As Object, e As EventArgs) Handles MyBase.Load



    End Sub

    'Import BTN
    Private Sub import_btn_Click(sender As Object, e As EventArgs) Handles import_btn.Click

        'Show the OpenFileDialog
        Dim open_files As New OpenFileDialog()
        open_files.Filter = "CSV files (*.csv)|*.csv|All files (*.*)|*.*"
        open_files.FilterIndex = 1
        open_files.RestoreDirectory = True

        If open_files.ShowDialog() = System.Windows.Forms.DialogResult.OK Then

            Try

                'Create a DataTable to store the data from the CSV file
                Dim dt As New DataTable()

                'Read the contents of the CSV file
                Using sr As New System.IO.StreamReader(open_files.FileName)

                    Dim line As String = sr.ReadLine()
                    Dim headers() As String = line.Split(","c)
                    For Each header As String In headers
                        dt.Columns.Add(header)
                    Next

                    While Not sr.EndOfStream
                        Dim values() As String = sr.ReadLine().Split(","c)
                        If values.Length = dt.Columns.Count Then
                            dt.Rows.Add(values)
                        End If

                    End While

                End Using
                'Datatable through GridView
                grid_data.DataSource = dt

            Catch ex As Exception

                MsgBox("Error: " & ex.Message, MsgBoxStyle.Critical, "Error!")

            End Try

        End If

    End Sub

    'EXPORT BTN
    Private Sub export_btrn_Click(sender As Object, e As EventArgs) Handles export_btrn.Click

        Dim csvData As New StringBuilder()
        Dim headerRow As String = ""

        For Each Column As DataGridViewColumn In grid_data.Columns
            headerRow += Column.HeaderText + ","
        Next
        headerRow = headerRow.TrimEnd(","c)
        csvData.AppendLine(headerRow)

        For Each row As DataGridViewRow In grid_data.Rows
            Dim rowData As String = ""
            For Each cell As DataGridViewCell In row.Cells
                If cell.Value IsNot Nothing Then
                    rowData += cell.Value.ToString() + ","
                Else
                    rowData += ","
                End If
            Next
            rowData = rowData.TrimEnd(","c)
            csvData.AppendLine(rowData)
        Next

        Dim savePath As String = "C:\Users\Kenneth\Documents\School\SCHOOL BSIT-3C\EDP\ExcelExports\exported.csv"
        File.WriteAllText(savePath, csvData.ToString)

        MsgBox("Export Success!", MsgBoxStyle.Information, "CSV Export")

    End Sub

End Class