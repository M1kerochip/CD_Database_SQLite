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
        Me.bntQueries = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.SuspendLayout()
        '
        'btnDatabase
        '
        Me.btnDatabase.Location = New System.Drawing.Point(12, 65)
        Me.btnDatabase.Name = "btnDatabase"
        Me.btnDatabase.Size = New System.Drawing.Size(590, 81)
        Me.btnDatabase.TabIndex = 0
        Me.btnDatabase.Text = "Database Function"
        Me.btnDatabase.UseVisualStyleBackColor = True
        '
        'btnDisplayFiles
        '
        Me.btnDisplayFiles.Location = New System.Drawing.Point(12, 152)
        Me.btnDisplayFiles.Name = "btnDisplayFiles"
        Me.btnDisplayFiles.Size = New System.Drawing.Size(590, 81)
        Me.btnDisplayFiles.TabIndex = 1
        Me.btnDisplayFiles.Text = "Display All Files"
        Me.btnDisplayFiles.UseVisualStyleBackColor = True
        '
        'bntQueries
        '
        Me.bntQueries.Location = New System.Drawing.Point(12, 239)
        Me.bntQueries.Name = "bntQueries"
        Me.bntQueries.Size = New System.Drawing.Size(590, 81)
        Me.bntQueries.TabIndex = 2
        Me.bntQueries.Text = "Queries"
        Me.bntQueries.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(39, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Label1"
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.Location = New System.Drawing.Point(543, 23)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(59, 13)
        Me.LinkLabel1.TabIndex = 4
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "LinkLabel1"
        '
        'frmMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(616, 337)
        Me.Controls.Add(Me.LinkLabel1)
        Me.Controls.Add(Me.Label1)
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
    Friend WithEvents Label1 As Label
    Friend WithEvents LinkLabel1 As LinkLabel
End Class
