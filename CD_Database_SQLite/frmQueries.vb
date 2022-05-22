Public Class frmQueries

    Private Sub UpdateForm()
        Dim SQL As New SQLite_Funcs
        Dim SQLTxt As String = "Select Query_Name from Queries order by Query_Name asc"

        SQL.FillInListBox(SQLTxt, lbQueries, False)
        Me.Text = "Queries: " + Me.lbQueries.Items.Count.ToString("N0")

        lbQueries.SelectedIndex = -1
    End Sub

    Private Sub frmQueries_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        UpdateForm()
    End Sub

    Private Sub btnTest_Click(sender As Object, e As EventArgs) Handles btnTest.Click
        Dim files_form As New frmShowFiles
        files_form.Show()
        files_form.txtSQLText.Text = txtQuery.Text
        Dim SQL As New SQLite_Funcs

        Dim SQLTxt As String = txtQuery.Text

        SQL.FillInDataGridView(SQLTxt, files_form.DataGridViewMain, False)
        files_form.Text = "Files: " + files_form.DataGridViewMain.Rows.Count.ToString("N0")
    End Sub

    Private Sub btnSaveQuery_Click(sender As Object, e As EventArgs) Handles btnSaveQuery.Click
        If txtQueryName.Text.Trim <> "" Then
            'Saving An Edit
            Dim RES As String = InputBox("Save This Query to the Query list, with the name below." + vbCrLf + "Click OK to save, or Cancel to cancel saving." & vbCrLf & "To save with a new name, change the selected text.", "Save Existing Query", txtQueryName.Text, -1, -1)
            If RES <> "" Then
                'Query is to be saved

                Dim SQL As New SQLite_Funcs

                Dim SQLID As Int64 = SQL.GetSQLQueryIDByName(txtQueryName.Text, False)

                If SQLID <> -1 Then
                    Dim res1 As Boolean
                    Dim res2 As Boolean

                    If RES = txtQueryName.Text Then
                        'No New Name is required
                        res1 = True  'Default this to True (For Msgbox, after updates. ie if no new name is required)
                        res2 = SQL.UpdateSQLQueryQueryByID(SQLID, txtQuery.Text, False)
                    Else
                        'Query is to be renamed
                        res2 = SQL.UpdateSQLQueryQueryByID(SQLID, txtQuery.Text, False)
                        res1 = SQL.UpdateSQLQueryNameByID(SQLID, RES, False)
                    End If
                    If (res1 = False) Or (res2 = False) Then
                        MessageBox.Show("Unable to update SQL Query")
                    Else
                        txtQueryName.Text = ""
                        txtQuery.Text = ""
                    End If
                Else
                    'not Found
                    MessageBox.Show("Unable to locate SQL Query to update")
                End If

                UpdateForm() 'Show the new Query
            Else
                'Do Nothing
            End If

        Else
            'Saving A New Query
            Dim RES As String = InputBox("Save a new Query to the Query list, with the name below." + vbCrLf + "Click OK to save, or Cancel to cancel saving. The Query needs a name to save.", "Save New Query", txtQueryName.Text, -1, -1)
            If RES <> "" Then
                'Query is to be saved

                Dim SQL As New SQLite_Funcs

                Dim SaveRes As Boolean = SQL.AddNewSQLQuery(RES, txtQuery.Text, False)

                If SaveRes = True Then
                    'saved ok

                Else
                    'didn't save!

                End If

                UpdateForm() 'Show the new Query

            End If

        End If
    End Sub

    ''' <summary>
    ''' Handles Both clicking BtnLaunch, and lbQueries.DoubleClick
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btnLaunch_Click(sender As Object, e As EventArgs) Handles btnLaunch.Click, lbQueries.DoubleClick
        If lbQueries.SelectedIndex > -1 Then
            Dim Str As String
            Dim SQL1 As New SQLite_Funcs

            Str = SQL1.GetSQLQueryByName(lbQueries.GetItemText(lbQueries.SelectedItem), False)

            If Str <> "" Then
                Dim files_form As New frmShowFiles
                files_form.Show()
                files_form.txtSQLText.Text = Str
                Dim SQL As New SQLite_Funcs

                Dim SQLTxt As String = Str

                SQL.FillInDataGridView(SQLTxt, files_form.DataGridViewMain, False)
                files_form.Text = "Files: " + files_form.DataGridViewMain.Rows.Count.ToString("N0")

            Else

            End If

        Else
            'Nothing selected
        End If
    End Sub

    Private Sub btnEditQuery_Click(sender As Object, e As EventArgs) Handles btnEditQuery.Click
        If lbQueries.SelectedIndex > -1 Then
            Dim Str As String
            Dim SQL1 As New SQLite_Funcs

            Str = SQL1.GetSQLQueryByName(lbQueries.GetItemText(lbQueries.SelectedItem), False)

            If Str <> "" Then
                txtQuery.Text = Str
                txtQueryName.Text = lbQueries.GetItemText(lbQueries.SelectedItem)
            Else

            End If

        Else
            'Nothing selected
        End If
    End Sub

    Private Sub btnDeleteQuery_Click(sender As Object, e As EventArgs) Handles btnDeleteQuery.Click
        If lbQueries.SelectedIndex > -1 Then
            'Something was selected
            If MessageBox.Show("Delete Selected Query?", "Delete Query from Database", MessageBoxButtons.YesNo) = DialogResult.Yes Then
                'delete the query
                Dim ID As Int64 = -1
                Dim SQL As New SQLite_Funcs

                ID = SQL.GetSQLQueryIDByName(lbQueries.GetItemText(lbQueries.SelectedItem), False)
                If ID > -1 Then
                    Dim res As Boolean
                    res = SQL.DeleteSQLQueryByID(ID, False)
                    If res = True Then
                        txtQueryName.Text = ""  'Deletes cancel an edit in progress
                    End If

                    UpdateForm()
                Else

                End If
            Else
                'Do nothing
            End If
        Else
            'Nothing selected
        End If
    End Sub

End Class