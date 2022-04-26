Public Class frmShowFiles
    Private Sub btnShowFiles_Click(sender As Object, e As EventArgs) Handles btnShowFiles.Click
        Dim SQL As New SQLite_Funcs

        Dim SQLTxt As String
        SQLTxt = "select * from Files inner join Volumes on Files.Volume_ID = Volumes.ID order by Directory,Filename asc"
        If txtSQLText.Text.Trim = "" Then

        Else
            SQLTxt = txtSQLText.Text.Trim
        End If
        SQL.FillInDataGridView(SQLTxt, DataGridViewMain, False)

        Try
            'Me.Text = "Files: " + DataGridViewMain.Rows.Count.ToString("N", System.Globalization.CultureInfo.InvariantCulture)
            Me.Text = "Files: " + DataGridViewMain.Rows.Count.ToString("N0")
        Catch ex As Exception

        End Try

    End Sub
End Class