Public Class frmMenu
    Private Sub btnDatabase_Click(sender As Object, e As EventArgs) Handles btnDatabase.Click
        frmImports.Show()
    End Sub

    Private Sub btnDisplayFiles_Click(sender As Object, e As EventArgs) Handles btnDisplayFiles.Click
        Dim files_form As New frmShowFiles
        files_form.Show()

    End Sub

    Private Sub bntQueries_Click(sender As Object, e As EventArgs) Handles bntQueries.Click
        frmQueries.Show()
    End Sub

    Private Sub linklblProject_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles linklblProject.LinkClicked
        System.Diagnostics.Process.Start("https://github.com/M1kerochip/CD_Database_SQLite")
    End Sub
End Class