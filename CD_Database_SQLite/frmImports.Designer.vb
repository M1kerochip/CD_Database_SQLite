<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmImports
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmImports))
        Me.btnImportCD = New System.Windows.Forms.Button()
        Me.btnCreateDatabase = New System.Windows.Forms.Button()
        Me.OpenFileDialogDirFile = New System.Windows.Forms.OpenFileDialog()
        Me.btnImportAllFiles = New System.Windows.Forms.Button()
        Me.txtDirectory = New System.Windows.Forms.TextBox()
        Me.btnSetDir = New System.Windows.Forms.Button()
        Me.FolderBrowserDialog1 = New System.Windows.Forms.FolderBrowserDialog()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.pbSingleFile = New System.Windows.Forms.ProgressBar()
        Me.pbFilesInDir = New System.Windows.Forms.ProgressBar()
        Me.lblCurrentFile = New System.Windows.Forms.Label()
        Me.chkInMemory = New System.Windows.Forms.CheckBox()
        Me.chkRemoveDirLetter = New System.Windows.Forms.CheckBox()
        Me.cmbDriveList = New System.Windows.Forms.ComboBox()
        Me.btnImportDrive = New System.Windows.Forms.Button()
        Me.lblDriveList = New System.Windows.Forms.Label()
        Me.StatusStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnImportCD
        '
        Me.btnImportCD.Location = New System.Drawing.Point(38, 129)
        Me.btnImportCD.Name = "btnImportCD"
        Me.btnImportCD.Size = New System.Drawing.Size(590, 81)
        Me.btnImportCD.TabIndex = 1
        Me.btnImportCD.Text = "Import Single DIR file"
        Me.btnImportCD.UseVisualStyleBackColor = True
        '
        'btnCreateDatabase
        '
        Me.btnCreateDatabase.Location = New System.Drawing.Point(38, 29)
        Me.btnCreateDatabase.Name = "btnCreateDatabase"
        Me.btnCreateDatabase.Size = New System.Drawing.Size(590, 49)
        Me.btnCreateDatabase.TabIndex = 2
        Me.btnCreateDatabase.Text = "Create Database"
        Me.btnCreateDatabase.UseVisualStyleBackColor = True
        '
        'btnImportAllFiles
        '
        Me.btnImportAllFiles.Location = New System.Drawing.Point(38, 291)
        Me.btnImportAllFiles.Name = "btnImportAllFiles"
        Me.btnImportAllFiles.Size = New System.Drawing.Size(590, 81)
        Me.btnImportAllFiles.TabIndex = 3
        Me.btnImportAllFiles.Text = "Import All files in the Directory Above"
        Me.btnImportAllFiles.UseVisualStyleBackColor = True
        '
        'txtDirectory
        '
        Me.txtDirectory.Location = New System.Drawing.Point(38, 265)
        Me.txtDirectory.Name = "txtDirectory"
        Me.txtDirectory.Size = New System.Drawing.Size(560, 20)
        Me.txtDirectory.TabIndex = 4
        '
        'btnSetDir
        '
        Me.btnSetDir.Location = New System.Drawing.Point(604, 265)
        Me.btnSetDir.Name = "btnSetDir"
        Me.btnSetDir.Size = New System.Drawing.Size(24, 20)
        Me.btnSetDir.TabIndex = 5
        Me.btnSetDir.Text = "..."
        Me.btnSetDir.UseVisualStyleBackColor = True
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel1})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 532)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(675, 22)
        Me.StatusStrip1.TabIndex = 6
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(119, 17)
        Me.ToolStripStatusLabel1.Text = "ToolStripStatusLabel1"
        '
        'pbSingleFile
        '
        Me.pbSingleFile.Location = New System.Drawing.Point(38, 217)
        Me.pbSingleFile.Name = "pbSingleFile"
        Me.pbSingleFile.Size = New System.Drawing.Size(590, 23)
        Me.pbSingleFile.Step = 1
        Me.pbSingleFile.TabIndex = 7
        '
        'pbFilesInDir
        '
        Me.pbFilesInDir.Location = New System.Drawing.Point(38, 378)
        Me.pbFilesInDir.Name = "pbFilesInDir"
        Me.pbFilesInDir.Size = New System.Drawing.Size(590, 23)
        Me.pbFilesInDir.Step = 1
        Me.pbFilesInDir.TabIndex = 8
        '
        'lblCurrentFile
        '
        Me.lblCurrentFile.AutoSize = True
        Me.lblCurrentFile.Location = New System.Drawing.Point(38, 408)
        Me.lblCurrentFile.Name = "lblCurrentFile"
        Me.lblCurrentFile.Size = New System.Drawing.Size(52, 13)
        Me.lblCurrentFile.TabIndex = 9
        Me.lblCurrentFile.Text = "Filename!"
        '
        'chkInMemory
        '
        Me.chkInMemory.AutoSize = True
        Me.chkInMemory.Location = New System.Drawing.Point(38, 84)
        Me.chkInMemory.Name = "chkInMemory"
        Me.chkInMemory.Size = New System.Drawing.Size(287, 17)
        Me.chkInMemory.TabIndex = 10
        Me.chkInMemory.Text = "Create SQLite database in Memory, rather than on disk."
        Me.chkInMemory.UseVisualStyleBackColor = True
        '
        'chkRemoveDirLetter
        '
        Me.chkRemoveDirLetter.AutoSize = True
        Me.chkRemoveDirLetter.Checked = True
        Me.chkRemoveDirLetter.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkRemoveDirLetter.Location = New System.Drawing.Point(459, 84)
        Me.chkRemoveDirLetter.Name = "chkRemoveDirLetter"
        Me.chkRemoveDirLetter.Size = New System.Drawing.Size(169, 17)
        Me.chkRemoveDirLetter.TabIndex = 11
        Me.chkRemoveDirLetter.Text = "Remove Directory Drive Letter"
        Me.chkRemoveDirLetter.UseVisualStyleBackColor = True
        '
        'cmbDriveList
        '
        Me.cmbDriveList.FormattingEnabled = True
        Me.cmbDriveList.Location = New System.Drawing.Point(38, 493)
        Me.cmbDriveList.Name = "cmbDriveList"
        Me.cmbDriveList.Size = New System.Drawing.Size(443, 21)
        Me.cmbDriveList.TabIndex = 12
        '
        'btnImportDrive
        '
        Me.btnImportDrive.Location = New System.Drawing.Point(487, 491)
        Me.btnImportDrive.Name = "btnImportDrive"
        Me.btnImportDrive.Size = New System.Drawing.Size(141, 23)
        Me.btnImportDrive.TabIndex = 13
        Me.btnImportDrive.Text = "Import Drive"
        Me.btnImportDrive.UseVisualStyleBackColor = True
        '
        'lblDriveList
        '
        Me.lblDriveList.AutoSize = True
        Me.lblDriveList.Location = New System.Drawing.Point(35, 477)
        Me.lblDriveList.Name = "lblDriveList"
        Me.lblDriveList.Size = New System.Drawing.Size(51, 13)
        Me.lblDriveList.TabIndex = 14
        Me.lblDriveList.Text = "Drive List"
        '
        'frmImports
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(675, 554)
        Me.Controls.Add(Me.lblDriveList)
        Me.Controls.Add(Me.btnImportDrive)
        Me.Controls.Add(Me.cmbDriveList)
        Me.Controls.Add(Me.chkRemoveDirLetter)
        Me.Controls.Add(Me.chkInMemory)
        Me.Controls.Add(Me.lblCurrentFile)
        Me.Controls.Add(Me.pbFilesInDir)
        Me.Controls.Add(Me.pbSingleFile)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.btnSetDir)
        Me.Controls.Add(Me.txtDirectory)
        Me.Controls.Add(Me.btnImportAllFiles)
        Me.Controls.Add(Me.btnCreateDatabase)
        Me.Controls.Add(Me.btnImportCD)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmImports"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Imports"
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnImportCD As Button
    Friend WithEvents btnCreateDatabase As Button
    Friend WithEvents OpenFileDialogDirFile As OpenFileDialog
    Friend WithEvents btnImportAllFiles As Button
    Friend WithEvents txtDirectory As TextBox
    Friend WithEvents btnSetDir As Button
    Friend WithEvents FolderBrowserDialog1 As FolderBrowserDialog
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents pbSingleFile As ProgressBar
    Friend WithEvents pbFilesInDir As ProgressBar
    Friend WithEvents lblCurrentFile As Label
    Friend WithEvents chkInMemory As CheckBox
    Friend WithEvents ToolStripStatusLabel1 As ToolStripStatusLabel
    Friend WithEvents chkRemoveDirLetter As CheckBox
    Friend WithEvents cmbDriveList As ComboBox
    Friend WithEvents btnImportDrive As Button
    Friend WithEvents lblDriveList As Label
End Class
