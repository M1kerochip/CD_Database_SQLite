Public Class frmImports

    Private Sub btnCreateDatabase_Click(sender As Object, e As EventArgs) Handles btnCreateDatabase.Click

        Dim SQL As New SQLite_Funcs
        SQL.DataBaseInMemory = chkInMemory.Checked
        SQL.CreateDatabase()

    End Sub

    Private Sub ImportFile(ByVal FileToImport As String, ByVal RemoveDirLetter As Boolean, ByVal InMemory As Boolean)
        StatusStrip1.Items.Item(0).Text = "Start Time: " & CStr(Now)
        lblCurrentFile.Text = FileToImport
        Me.Refresh()
        Application.DoEvents()

        Dim SQL As New SQLite_Funcs
        SQL.DataBaseInMemory = InMemory

        If InMemory = True Then
            If IO.File.Exists(Application.StartupPath + "\" + SQL.DatabaseName) Then SQL.ReadDatabaseFromDisktoMemory()
        End If

        SQL.ImportDIRFile(FileToImport, RemoveDirLetter)

        If InMemory = True Then
            SQL.SaveDatabaseInMemoryToDisk()
        End If

        StatusStrip1.Items.Item(0).Text += "   Finish Time: " & CStr(Now)
    End Sub

    Private Sub btnImportCD_Click(sender As Object, e As EventArgs) Handles btnImportCD.Click

        OpenFileDialogDirFile.Filter = "All Files *.*|*.*"

        If OpenFileDialogDirFile.ShowDialog = DialogResult.OK Then
            ImportFile(OpenFileDialogDirFile.FileName, chkRemoveDirLetter.Checked, chkInMemory.Checked)
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

    Private Sub frmImports_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cmbDriveList.Items.Clear()

        For Each drive In Environment.GetLogicalDrives
            Dim Driver As IO.DriveInfo = New IO.DriveInfo(drive)

            If Driver.DriveType = IO.DriveType.Removable Or Driver.DriveType = IO.DriveType.Fixed Or Driver.DriveType = IO.DriveType.CDRom Then
                If Driver.IsReady Then
                    cmbDriveList.Items.Add(Driver.Name & " " & Driver.VolumeLabel)
                Else
                    cmbDriveList.Items.Add(Driver.Name)
                End If

            End If
        Next
    End Sub

    Private Sub btnImportDrive_Click(sender As Object, e As EventArgs) Handles btnImportDrive.Click
        If cmbDriveList.Text <> "" Then
            If MessageBox.Show("Import Drive from the list?", "Import Drive Contents", MessageBoxButtons.YesNo) = DialogResult.Yes Then
                Dim DirToRead As String = cmbDriveList.Text.Substring(0, 3)

                If cmbDriveList.FindString(cmbDriveList.Text) = -1 Then 'If the user has typed in a specific address, eg a mountpoint etc.
                    DirToRead = cmbDriveList.Text.TrimEnd(IO.Path.DirectorySeparatorChar) + IO.Path.DirectorySeparatorChar 'ensure last character is a backslash
                End If

                Dim mProcess As New Process

                    'mProcess.StartInfo.WorkingDirectory = ""
                    mProcess.StartInfo.FileName = "cmd.exe"
                    mProcess.StartInfo.Arguments = "/c DIR.exe " + DirToRead + "*.* /a /s > Temp.txt"
                    mProcess.StartInfo.UseShellExecute = False
                    mProcess.StartInfo.CreateNoWindow = False

                    mProcess = Process.Start(mProcess.StartInfo)
                    mProcess.WaitForExit()

                    If IO.File.Exists("Temp.txt") Then
                        ImportFile("Temp.txt", chkRemoveDirLetter.Checked, chkInMemory.Checked)
                    Else

                    End If

                End If

            Else
            MessageBox.Show("Please select a drive, or enter a mountpoint to import")
        End If
    End Sub
End Class
