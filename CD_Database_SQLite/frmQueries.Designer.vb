<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmQueries
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmQueries))
        Me.txtQuery = New System.Windows.Forms.TextBox()
        Me.lbQueries = New System.Windows.Forms.ListBox()
        Me.btnSaveQuery = New System.Windows.Forms.Button()
        Me.btnEditQuery = New System.Windows.Forms.Button()
        Me.btnDeleteQuery = New System.Windows.Forms.Button()
        Me.btnLaunch = New System.Windows.Forms.Button()
        Me.txtQueryName = New System.Windows.Forms.TextBox()
        Me.btnTest = New System.Windows.Forms.Button()
        Me.chkDark = New System.Windows.Forms.CheckBox()
        Me.FontDialogQueries = New System.Windows.Forms.FontDialog()
        Me.btnFont = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txtQuery
        '
        Me.txtQuery.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtQuery.Location = New System.Drawing.Point(12, 351)
        Me.txtQuery.Multiline = True
        Me.txtQuery.Name = "txtQuery"
        Me.txtQuery.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtQuery.Size = New System.Drawing.Size(776, 153)
        Me.txtQuery.TabIndex = 0
        '
        'lbQueries
        '
        Me.lbQueries.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbQueries.FormattingEnabled = True
        Me.lbQueries.Location = New System.Drawing.Point(12, 12)
        Me.lbQueries.Name = "lbQueries"
        Me.lbQueries.Size = New System.Drawing.Size(776, 303)
        Me.lbQueries.TabIndex = 2
        '
        'btnSaveQuery
        '
        Me.btnSaveQuery.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSaveQuery.Location = New System.Drawing.Point(713, 510)
        Me.btnSaveQuery.Name = "btnSaveQuery"
        Me.btnSaveQuery.Size = New System.Drawing.Size(75, 23)
        Me.btnSaveQuery.TabIndex = 4
        Me.btnSaveQuery.Text = "&Save"
        Me.btnSaveQuery.UseVisualStyleBackColor = True
        '
        'btnEditQuery
        '
        Me.btnEditQuery.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnEditQuery.Location = New System.Drawing.Point(551, 322)
        Me.btnEditQuery.Name = "btnEditQuery"
        Me.btnEditQuery.Size = New System.Drawing.Size(75, 23)
        Me.btnEditQuery.TabIndex = 5
        Me.btnEditQuery.Text = "&Edit"
        Me.btnEditQuery.UseVisualStyleBackColor = True
        '
        'btnDeleteQuery
        '
        Me.btnDeleteQuery.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnDeleteQuery.Location = New System.Drawing.Point(470, 322)
        Me.btnDeleteQuery.Name = "btnDeleteQuery"
        Me.btnDeleteQuery.Size = New System.Drawing.Size(75, 23)
        Me.btnDeleteQuery.TabIndex = 6
        Me.btnDeleteQuery.Text = "&Delete"
        Me.btnDeleteQuery.UseVisualStyleBackColor = True
        '
        'btnLaunch
        '
        Me.btnLaunch.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnLaunch.Location = New System.Drawing.Point(713, 321)
        Me.btnLaunch.Name = "btnLaunch"
        Me.btnLaunch.Size = New System.Drawing.Size(75, 23)
        Me.btnLaunch.TabIndex = 7
        Me.btnLaunch.Text = "&Launch"
        Me.btnLaunch.UseVisualStyleBackColor = True
        '
        'txtQueryName
        '
        Me.txtQueryName.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtQueryName.Location = New System.Drawing.Point(12, 324)
        Me.txtQueryName.Name = "txtQueryName"
        Me.txtQueryName.ReadOnly = True
        Me.txtQueryName.Size = New System.Drawing.Size(452, 20)
        Me.txtQueryName.TabIndex = 9
        '
        'btnTest
        '
        Me.btnTest.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnTest.Location = New System.Drawing.Point(551, 510)
        Me.btnTest.Name = "btnTest"
        Me.btnTest.Size = New System.Drawing.Size(75, 23)
        Me.btnTest.TabIndex = 10
        Me.btnTest.Text = "&Test"
        Me.btnTest.UseVisualStyleBackColor = True
        '
        'chkDark
        '
        Me.chkDark.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.chkDark.AutoSize = True
        Me.chkDark.Checked = True
        Me.chkDark.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkDark.Location = New System.Drawing.Point(12, 514)
        Me.chkDark.Name = "chkDark"
        Me.chkDark.Size = New System.Drawing.Size(71, 17)
        Me.chkDark.TabIndex = 11
        Me.chkDark.Text = "Dark Grid"
        Me.chkDark.UseVisualStyleBackColor = True
        '
        'btnFont
        '
        Me.btnFont.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnFont.Location = New System.Drawing.Point(89, 510)
        Me.btnFont.Name = "btnFont"
        Me.btnFont.Size = New System.Drawing.Size(75, 23)
        Me.btnFont.TabIndex = 12
        Me.btnFont.Text = "Font"
        Me.btnFont.UseVisualStyleBackColor = True
        '
        'frmQueries
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 545)
        Me.Controls.Add(Me.btnFont)
        Me.Controls.Add(Me.chkDark)
        Me.Controls.Add(Me.btnTest)
        Me.Controls.Add(Me.txtQueryName)
        Me.Controls.Add(Me.btnLaunch)
        Me.Controls.Add(Me.btnDeleteQuery)
        Me.Controls.Add(Me.btnEditQuery)
        Me.Controls.Add(Me.btnSaveQuery)
        Me.Controls.Add(Me.lbQueries)
        Me.Controls.Add(Me.txtQuery)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmQueries"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Queries"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtQuery As TextBox
    Friend WithEvents lbQueries As ListBox
    Friend WithEvents btnSaveQuery As Button
    Friend WithEvents btnEditQuery As Button
    Friend WithEvents btnDeleteQuery As Button
    Friend WithEvents btnLaunch As Button
    Friend WithEvents txtQueryName As TextBox
    Friend WithEvents btnTest As Button
    Friend WithEvents chkDark As CheckBox
    Friend WithEvents FontDialogQueries As FontDialog
    Friend WithEvents btnFont As Button
End Class
