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

    Private Sub cmbHeaderSize_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbHeaderSize.SelectedIndexChanged
        'None
        'ColumnHeader
        'AllCellsExceptHeader
        'AllCells
        'DisplayedCellsExceptHeader
        'DisplayedCells
        'Fill

        Select Case cmbHeaderSize.SelectedIndex
            Case 0
                DataGridViewMain.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None

            Case 1
                DataGridViewMain.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.ColumnHeader

            Case 2
                DataGridViewMain.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCellsExceptHeader

            Case 3
                DataGridViewMain.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells

            Case 4
                DataGridViewMain.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCellsExceptHeader

            Case 5
                DataGridViewMain.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells

            Case 6
                DataGridViewMain.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill

        End Select

    End Sub

    Private Sub cmbCellStyle_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbCellStyle.SelectedIndexChanged
        'None
        'Single
        'Raised
        'Sunken
        'SingleVertical
        'RaisedVertical
        'SunkenVertical
        'SingleHorizontal
        'RaisedHorizontal
        'SunkenHorizontal

        Select Case cmbCellStyle.SelectedIndex
            Case 0
                DataGridViewMain.CellBorderStyle = DataGridViewCellBorderStyle.None

            Case 1
                DataGridViewMain.CellBorderStyle = DataGridViewCellBorderStyle.Single

            Case 2
                DataGridViewMain.CellBorderStyle = DataGridViewCellBorderStyle.Raised

            Case 3
                DataGridViewMain.CellBorderStyle = DataGridViewCellBorderStyle.Sunken

            Case 4
                DataGridViewMain.CellBorderStyle = DataGridViewCellBorderStyle.SingleVertical

            Case 5
                DataGridViewMain.CellBorderStyle = DataGridViewCellBorderStyle.RaisedVertical

            Case 6
                DataGridViewMain.CellBorderStyle = DataGridViewCellBorderStyle.SunkenVertical

            Case 7
                DataGridViewMain.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal

            Case 8
                DataGridViewMain.CellBorderStyle = DataGridViewCellBorderStyle.RaisedHorizontal

            Case 9
                DataGridViewMain.CellBorderStyle = DataGridViewCellBorderStyle.SunkenHorizontal

        End Select
    End Sub

    Private Sub chkDark_CheckedChanged(sender As Object, e As EventArgs) Handles chkDark.CheckedChanged, chkAlternating.CheckedChanged
        If chkDark.Checked Then
            ' Dark
            DataGridViewMain.BackgroundColor = Color.FromArgb(64, 64, 64)
            DataGridViewMain.RowsDefaultCellStyle.BackColor = Color.FromArgb(64, 64, 64)
            DataGridViewMain.RowsDefaultCellStyle.ForeColor = Color.White
            If chkAlternating.Checked Then
                DataGridViewMain.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(48, 48, 48)
                DataGridViewMain.AlternatingRowsDefaultCellStyle.ForeColor = Color.White
            Else
                DataGridViewMain.AlternatingRowsDefaultCellStyle.BackColor = DataGridViewMain.RowsDefaultCellStyle.BackColor
                DataGridViewMain.AlternatingRowsDefaultCellStyle.ForeColor = DataGridViewMain.RowsDefaultCellStyle.ForeColor
            End If
        Else
            'Light
            DataGridViewMain.BackgroundColor = Color.White
            DataGridViewMain.RowsDefaultCellStyle.BackColor = Color.White
            DataGridViewMain.RowsDefaultCellStyle.ForeColor = Color.Black
            If chkAlternating.Checked Then
                DataGridViewMain.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(240, 240, 240)
                DataGridViewMain.AlternatingRowsDefaultCellStyle.ForeColor = Color.Black
            Else
                DataGridViewMain.AlternatingRowsDefaultCellStyle.BackColor = DataGridViewMain.RowsDefaultCellStyle.BackColor
                DataGridViewMain.AlternatingRowsDefaultCellStyle.ForeColor = DataGridViewMain.RowsDefaultCellStyle.ForeColor
            End If
        End If
        txtSQLText.BackColor = DataGridViewMain.BackgroundColor
        txtSQLText.ForeColor = DataGridViewMain.RowsDefaultCellStyle.ForeColor
        cmbHeaderSize.BackColor = DataGridViewMain.BackgroundColor
        cmbHeaderSize.ForeColor = DataGridViewMain.RowsDefaultCellStyle.ForeColor
        cmbCellStyle.BackColor = DataGridViewMain.BackgroundColor
        cmbCellStyle.ForeColor = DataGridViewMain.RowsDefaultCellStyle.ForeColor
    End Sub

    Private Sub AddFolderRenameToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddFolderRenameToolStripMenuItem.Click
        Dim FolderName As String

        FolderName = InputBox("Please Input corrected Folder name for selected files:", "Folders:", "")

        If FolderName <> "" Then
            If DataGridViewMain.RowCount > 0 Then
                If DataGridViewMain.SelectedRows.Count > 0 Then
                    For Each row As DataGridViewRow In DataGridViewMain.SelectedRows
                        'FolderName += DataGridViewMain.Rows.Item(row.Index).Cells(0).Value.ToString
                        Dim SQL As New SQLite_Funcs
                        SQL.AddCorrectedFileorFolderToDatabase(CInt(DataGridViewMain.Rows.Item(row.Index).Cells(0).Value), FolderName, True)
                    Next
                Else
                    MessageBox.Show("Nothing selected.")
                End If
            Else
                MessageBox.Show("No Data to rename!")
            End If
        End If
    End Sub

    Private Sub AddFileRenameToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddFileRenameToolStripMenuItem.Click
        If DataGridViewMain.RowCount > 0 Then
            If DataGridViewMain.SelectedRows.Count <> 1 Then
                MessageBox.Show("One file at a time")
            Else
                Dim FolderName As String

                FolderName = InputBox("Please Input corrected Filename for selected file:", "File:", "")

                If FolderName <> "" Then
                    If DataGridViewMain.SelectedRows.Count = 1 Then
                        Dim SQL As New SQLite_Funcs
                        SQL.AddCorrectedFileorFolderToDatabase(CInt(DataGridViewMain.Rows.Item(DataGridViewMain.SelectedRows(0).Index).Cells(0).Value), FolderName, False)
                    End If
                End If

            End If
        Else
            MessageBox.Show("No Data to rename!")
        End If
    End Sub

    Private Sub btnFont_Click(sender As Object, e As EventArgs) Handles btnFont.Click
        If FontDialogShowFiles.ShowDialog <> Windows.Forms.DialogResult.Cancel Then
            DataGridViewMain.Font = FontDialogShowFiles.Font
            txtSQLText.Font = FontDialogShowFiles.Font
        End If
    End Sub
End Class