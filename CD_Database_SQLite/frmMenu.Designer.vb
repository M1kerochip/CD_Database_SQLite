<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMenu
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMenu))
        Me.btnDatabase = New System.Windows.Forms.Button()
        Me.btnDisplayFiles = New System.Windows.Forms.Button()
        Me.lblProgramName = New System.Windows.Forms.Label()
        Me.linklblProject = New System.Windows.Forms.LinkLabel()
        Me.btnSeries = New System.Windows.Forms.Button()
        Me.btnRenameFiles = New System.Windows.Forms.Button()
        Me.btnRenameFolder = New System.Windows.Forms.Button()
        Me.bntQueries = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnDatabase
        '
        Me.btnDatabase.Location = New System.Drawing.Point(12, 65)
        Me.btnDatabase.Name = "btnDatabase"
        Me.btnDatabase.Size = New System.Drawing.Size(300, 88)
        Me.btnDatabase.TabIndex = 0
        Me.btnDatabase.Text = "Database Function"
        Me.btnDatabase.UseVisualStyleBackColor = True
        '
        'btnDisplayFiles
        '
        Me.btnDisplayFiles.Location = New System.Drawing.Point(12, 333)
        Me.btnDisplayFiles.Name = "btnDisplayFiles"
        Me.btnDisplayFiles.Size = New System.Drawing.Size(608, 81)
        Me.btnDisplayFiles.TabIndex = 1
        Me.btnDisplayFiles.Text = "Display All Files"
        Me.btnDisplayFiles.UseVisualStyleBackColor = True
        '
        'lblProgramName
        '
        Me.lblProgramName.AutoSize = True
        Me.lblProgramName.Location = New System.Drawing.Point(9, 23)
        Me.lblProgramName.Name = "lblProgramName"
        Me.lblProgramName.Size = New System.Drawing.Size(96, 13)
        Me.lblProgramName.TabIndex = 3
        Me.lblProgramName.Text = "File Database v1.4"
        '
        'linklblProject
        '
        Me.linklblProject.AutoSize = True
        Me.linklblProject.Location = New System.Drawing.Point(531, 23)
        Me.linklblProject.Name = "linklblProject"
        Me.linklblProject.Size = New System.Drawing.Size(89, 13)
        Me.linklblProject.TabIndex = 4
        Me.linklblProject.TabStop = True
        Me.linklblProject.Text = "Project on Github"
        '
        'btnSeries
        '
        Me.btnSeries.Enabled = False
        Me.btnSeries.Location = New System.Drawing.Point(12, 159)
        Me.btnSeries.Name = "btnSeries"
        Me.btnSeries.Size = New System.Drawing.Size(300, 81)
        Me.btnSeries.TabIndex = 5
        Me.btnSeries.Text = "Series / Links"
        Me.btnSeries.UseVisualStyleBackColor = True
        '
        'btnRenameFiles
        '
        Me.btnRenameFiles.Enabled = False
        Me.btnRenameFiles.Location = New System.Drawing.Point(12, 246)
        Me.btnRenameFiles.Name = "btnRenameFiles"
        Me.btnRenameFiles.Size = New System.Drawing.Size(300, 81)
        Me.btnRenameFiles.TabIndex = 6
        Me.btnRenameFiles.Text = "Rename Files"
        Me.btnRenameFiles.UseVisualStyleBackColor = True
        '
        'btnRenameFolder
        '
        Me.btnRenameFolder.Enabled = False
        Me.btnRenameFolder.Location = New System.Drawing.Point(320, 246)
        Me.btnRenameFolder.Name = "btnRenameFolder"
        Me.btnRenameFolder.Size = New System.Drawing.Size(300, 81)
        Me.btnRenameFolder.TabIndex = 7
        Me.btnRenameFolder.Text = "Rename Folders"
        Me.btnRenameFolder.UseVisualStyleBackColor = True
        '
        'bntQueries
        '
        Me.bntQueries.BackgroundImage = Global.CD_Database_SQLite.My.Resources.Resources.find_g7cd1dc75c_640
        Me.bntQueries.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.bntQueries.Location = New System.Drawing.Point(318, 65)
        Me.bntQueries.Name = "bntQueries"
        Me.bntQueries.Size = New System.Drawing.Size(302, 88)
        Me.bntQueries.TabIndex = 2
        Me.bntQueries.Text = "Queries"
        Me.bntQueries.UseVisualStyleBackColor = True
        '
        'frmMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(630, 429)
        Me.Controls.Add(Me.btnRenameFolder)
        Me.Controls.Add(Me.btnRenameFiles)
        Me.Controls.Add(Me.btnSeries)
        Me.Controls.Add(Me.linklblProject)
        Me.Controls.Add(Me.lblProgramName)
        Me.Controls.Add(Me.bntQueries)
        Me.Controls.Add(Me.btnDisplayFiles)
        Me.Controls.Add(Me.btnDatabase)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frmMenu"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "File Database Menu"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnDatabase As Button
    Friend WithEvents btnDisplayFiles As Button
    Friend WithEvents bntQueries As Button
    Friend WithEvents lblProgramName As Label
    Friend WithEvents linklblProject As LinkLabel
    Friend WithEvents btnSeries As Button
    Friend WithEvents btnRenameFiles As Button
    Friend WithEvents btnRenameFolder As Button
End Class
