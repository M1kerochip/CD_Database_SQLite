Public Class frmImports

    Private Sub btnCreateDatabase_Click(sender As Object, e As EventArgs) Handles btnCreateDatabase.Click

        Dim SQL As New SQLite_Funcs
        SQL.DataBaseInMemory = chkInMemory.Checked
        SQL.CreateDatabase()

    End Sub

    Private Sub btnImportCD_Click(sender As Object, e As EventArgs) Handles btnImportCD.Click

        OpenFileDialogDirFile.Filter = "All Files *.*|*.*"

        If OpenFileDialogDirFile.ShowDialog = DialogResult.OK Then
            StatusStrip1.Items.Item(0).Text = "Start Time: " & CStr(Now)
            lblCurrentFile.Text = OpenFileDialogDirFile.FileName
            Me.Refresh()
            Application.DoEvents()

            Dim SQL As New SQLite_Funcs
            SQL.DataBaseInMemory = chkInMemory.Checked
            If chkInMemory.Checked Then
                If IO.File.Exists(Application.StartupPath + "\" + SQL.DatabaseName) Then SQL.ReadDatabaseFromDisktoMemory()
            End If
            SQL.ImportDIRFile(OpenFileDialogDirFile.FileName, chkRemoveDirLetter.Checked)
            If chkInMemory.Checked Then
                SQL.SaveDatabaseInMemoryToDisk()
            End If
            StatusStrip1.Items.Item(0).Text += "   Finish Time: " & CStr(Now)
        End If

    End Sub

    Private Sub btnImportAllFiles_Click(sender As Object, e As EventArgs) Handles btnImportAllFiles.Click

        If IO.Directory.Exists(txtDirectory.Text) Then

            Dim FilesInFolder = IO.Directory.GetFiles(txtDirectory.Text).Count  'Count number of files in directory
            pbFilesInDir.Maximum = FilesInFolder    'Sets the progress bar max to number of files

            StatusStrip1.Items.Item(0).Text = "Start Time: " & CStr(Now)

            For Each DirFile In IO.Directory.GetFiles(txtDirectory.Text)
                lblCurrentFile.Text = DirFile
                Me.Refresh()

                Dim SQL As New SQLite_Funcs
                SQL.DataBaseInMemory = chkInMemory.Checked
                SQL.ImportDIRFile(DirFile, chkRemoveDirLetter.Checked)
                pbFilesInDir.PerformStep()  'move on progress bar for files by one
            Next
            StatusStrip1.Items.Item(0).Text += "   Finish Time: " & CStr(Now)

            If chkInMemory.Checked Then
                Dim SQL As New SQLite_Funcs
                SQL.SaveDatabaseInMemoryToDisk()
                StatusStrip1.Items.Item(0).Text += "   Disk Write Finish: " & CStr(Now)
            End If

        Else
            MessageBox.Show("Directory doesn't exist: " + vbCrLf + txtDirectory.Text)
        End If

    End Sub

    Private Sub btnSetDir_Click(sender As Object, e As EventArgs) Handles btnSetDir.Click
        If FolderBrowserDialog1.ShowDialog() = DialogResult.OK Then
            txtDirectory.Text = FolderBrowserDialog1.SelectedPath
        End If
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs)
        Me.Refresh()
        Application.DoEvents()
    End Sub
End Class
