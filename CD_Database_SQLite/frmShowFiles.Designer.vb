<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmShowFiles
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmShowFiles))
        Me.btnShowFiles = New System.Windows.Forms.Button()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.DataGridViewMain = New System.Windows.Forms.DataGridView()
        Me.ContextMenuStripFileFolder = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.AddFolderRenameToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.AddFileRenameToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.txtSQLText = New System.Windows.Forms.TextBox()
        Me.cmbHeaderSize = New System.Windows.Forms.ComboBox()
        Me.cmbCellStyle = New System.Windows.Forms.ComboBox()
        Me.chkDark = New System.Windows.Forms.CheckBox()
        Me.chkAlternating = New System.Windows.Forms.CheckBox()
        Me.btnFont = New System.Windows.Forms.Button()
        Me.FontDialogShowFiles = New System.Windows.Forms.FontDialog()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.DataGridViewMain, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenuStripFileFolder.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnShowFiles
        '
        Me.btnShowFiles.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnShowFiles.Location = New System.Drawing.Point(713, 445)
        Me.btnShowFiles.Name = "btnShowFiles"
        Me.btnShowFiles.Size = New System.Drawing.Size(75, 23)
        Me.btnShowFiles.TabIndex = 1
        Me.btnShowFiles.Text = "Show Files"
        Me.btnShowFiles.UseVisualStyleBackColor = True
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SplitContainer1.Location = New System.Drawing.Point(12, 12)
        Me.SplitContainer1.Name = "SplitContainer1"
        Me.SplitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.DataGridViewMain)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.txtSQLText)
        Me.SplitContainer1.Size = New System.Drawing.Size(776, 427)
        Me.SplitContainer1.SplitterDistance = 380
        Me.SplitContainer1.TabIndex = 3
        '
        'DataGridViewMain
        '
        Me.DataGridViewMain.AllowUserToAddRows = False
        Me.DataGridViewMain.AllowUserToDeleteRows = False
        Me.DataGridViewMain.AllowUserToOrderColumns = True
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.White
        Me.DataGridViewMain.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridViewMain.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCellsExceptHeader
        Me.DataGridViewMain.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.DataGridViewMain.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical
        Me.DataGridViewMain.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewMain.ContextMenuStrip = Me.ContextMenuStripFileFolder
        Me.DataGridViewMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridViewMain.Location = New System.Drawing.Point(0, 0)
        Me.DataGridViewMain.Name = "DataGridViewMain"
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        Me.DataGridViewMain.RowsDefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridViewMain.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridViewMain.Size = New System.Drawing.Size(776, 380)
        Me.DataGridViewMain.TabIndex = 2
        '
        'ContextMenuStripFileFolder
        '
        Me.ContextMenuStripFileFolder.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AddFolderRenameToolStripMenuItem, Me.ToolStripSeparator1, Me.AddFileRenameToolStripMenuItem})
        Me.ContextMenuStripFileFolder.Name = "ContextMenuStripFileFolder"
        Me.ContextMenuStripFileFolder.Size = New System.Drawing.Size(207, 54)
        '
        'AddFolderRenameToolStripMenuItem
        '
        Me.AddFolderRenameToolStripMenuItem.Name = "AddFolderRenameToolStripMenuItem"
        Me.AddFolderRenameToolStripMenuItem.Size = New System.Drawing.Size(206, 22)
        Me.AddFolderRenameToolStripMenuItem.Text = "Add Folder Correction"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(203, 6)
        '
        'AddFileRenameToolStripMenuItem
        '
        Me.AddFileRenameToolStripMenuItem.Name = "AddFileRenameToolStripMenuItem"
        Me.AddFileRenameToolStripMenuItem.Size = New System.Drawing.Size(206, 22)
        Me.AddFileRenameToolStripMenuItem.Text = "Add Filename Correction"
        '
        'txtSQLText
        '
        Me.txtSQLText.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtSQLText.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtSQLText.ForeColor = System.Drawing.Color.White
        Me.txtSQLText.Location = New System.Drawing.Point(0, 0)
        Me.txtSQLText.Multiline = True
        Me.txtSQLText.Name = "txtSQLText"
        Me.txtSQLText.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtSQLText.Size = New System.Drawing.Size(776, 43)
        Me.txtSQLText.TabIndex = 3
        Me.txtSQLText.Text = "select * from Files inner join Volumes on Files.Volume_ID = Volumes.ID order by D" &
    "irectory,Filename asc"
        '
        'cmbHeaderSize
        '
        Me.cmbHeaderSize.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.cmbHeaderSize.FormattingEnabled = True
        Me.cmbHeaderSize.Items.AddRange(New Object() {"None", "ColumnHeader", "AllCellsExceptHeader", "AllCells", "DisplayedCellsExceptHeader", "DisplayedCells", "Fill"})
        Me.cmbHeaderSize.Location = New System.Drawing.Point(12, 447)
        Me.cmbHeaderSize.Name = "cmbHeaderSize"
        Me.cmbHeaderSize.Size = New System.Drawing.Size(160, 21)
        Me.cmbHeaderSize.TabIndex = 4
        Me.cmbHeaderSize.Text = "AllCellsExceptHeader"
        '
        'cmbCellStyle
        '
        Me.cmbCellStyle.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.cmbCellStyle.FormattingEnabled = True
        Me.cmbCellStyle.Items.AddRange(New Object() {"None", "Single", "Raised", "Sunken", "SingleVertical", "RaisedVertical", "SunkenVertical", "SingleHorizontal", "RaisedHorizontal", "SunkenHorizontal"})
        Me.cmbCellStyle.Location = New System.Drawing.Point(178, 447)
        Me.cmbCellStyle.Name = "cmbCellStyle"
        Me.cmbCellStyle.Size = New System.Drawing.Size(180, 21)
        Me.cmbCellStyle.TabIndex = 5
        Me.cmbCellStyle.Text = "SingleVertical"
        '
        'chkDark
        '
        Me.chkDark.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.chkDark.AutoSize = True
        Me.chkDark.Checked = True
        Me.chkDark.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkDark.Location = New System.Drawing.Point(364, 449)
        Me.chkDark.Name = "chkDark"
        Me.chkDark.Size = New System.Drawing.Size(71, 17)
        Me.chkDark.TabIndex = 6
        Me.chkDark.Text = "Dark Grid"
        Me.chkDark.UseVisualStyleBackColor = True
        '
        'chkAlternating
        '
        Me.chkAlternating.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.chkAlternating.AutoSize = True
        Me.chkAlternating.Checked = True
        Me.chkAlternating.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkAlternating.Location = New System.Drawing.Point(441, 449)
        Me.chkAlternating.Name = "chkAlternating"
        Me.chkAlternating.Size = New System.Drawing.Size(131, 17)
        Me.chkAlternating.TabIndex = 7
        Me.chkAlternating.Text = "Alternate Row Colours"
        Me.chkAlternating.UseVisualStyleBackColor = True
        '
        'btnFont
        '
        Me.btnFont.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnFont.Location = New System.Drawing.Point(578, 445)
        Me.btnFont.Name = "btnFont"
        Me.btnFont.Size = New System.Drawing.Size(75, 23)
        Me.btnFont.TabIndex = 8
        Me.btnFont.Text = "Font"
        Me.btnFont.UseVisualStyleBackColor = True
        '
        'frmShowFiles
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 480)
        Me.Controls.Add(Me.btnFont)
        Me.Controls.Add(Me.chkAlternating)
        Me.Controls.Add(Me.chkDark)
        Me.Controls.Add(Me.cmbCellStyle)
        Me.Controls.Add(Me.cmbHeaderSize)
        Me.Controls.Add(Me.btnShowFiles)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmShowFiles"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Files: "
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.Panel2.PerformLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        CType(Me.DataGridViewMain, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextMenuStripFileFolder.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnShowFiles As Button
    Friend WithEvents SplitContainer1 As SplitContainer
    Friend WithEvents txtSQLText As TextBox
    Friend WithEvents DataGridViewMain As DataGridView
    Friend WithEvents cmbHeaderSize As ComboBox
    Friend WithEvents cmbCellStyle As ComboBox
    Friend WithEvents chkDark As CheckBox
    Friend WithEvents chkAlternating As CheckBox
    Friend WithEvents ContextMenuStripFileFolder As ContextMenuStrip
    Friend WithEvents AddFolderRenameToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AddFileRenameToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents btnFont As Button
    Friend WithEvents FontDialogShowFiles As FontDialog
End Class
