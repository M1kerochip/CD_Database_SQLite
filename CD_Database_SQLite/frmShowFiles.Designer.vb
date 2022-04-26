<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmShowFiles
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmShowFiles))
        Me.DataGridViewMain = New System.Windows.Forms.DataGridView()
        Me.btnShowFiles = New System.Windows.Forms.Button()
        Me.txtSQLText = New System.Windows.Forms.TextBox()
        CType(Me.DataGridViewMain, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridViewMain
        '
        Me.DataGridViewMain.AllowUserToAddRows = False
        Me.DataGridViewMain.AllowUserToDeleteRows = False
        Me.DataGridViewMain.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridViewMain.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewMain.Location = New System.Drawing.Point(12, 12)
        Me.DataGridViewMain.MultiSelect = False
        Me.DataGridViewMain.Name = "DataGridViewMain"
        Me.DataGridViewMain.Size = New System.Drawing.Size(776, 418)
        Me.DataGridViewMain.TabIndex = 0
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
        'txtSQLText
        '
        Me.txtSQLText.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtSQLText.Location = New System.Drawing.Point(13, 436)
        Me.txtSQLText.Multiline = True
        Me.txtSQLText.Name = "txtSQLText"
        Me.txtSQLText.Size = New System.Drawing.Size(694, 41)
        Me.txtSQLText.TabIndex = 2
        Me.txtSQLText.Text = "select * from Files inner join Volumes on Files.Volume_ID = Volumes.ID order by D" &
    "irectory,Filename asc"
        '
        'Show_Episodes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 480)
        Me.Controls.Add(Me.txtSQLText)
        Me.Controls.Add(Me.btnShowFiles)
        Me.Controls.Add(Me.DataGridViewMain)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Show_Episodes"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Files: "
        CType(Me.DataGridViewMain, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DataGridViewMain As DataGridView
    Friend WithEvents btnShowFiles As Button
    Friend WithEvents txtSQLText As TextBox
End Class
