Public Class Reset
    Dim usernameexist, correctpassword As Boolean
    Sub verifyusername()
        usernameexist = False
        Try
            strsql = "select Username from Login"
            Dim acscmd As New OleDb.OleDbCommand
            acscmd.CommandText = strsql
            acscmd.Connection = acsconn
            acsda.SelectCommand = acscmd
            acsdr = acscmd.ExecuteReader
            While (acsdr.Read())
                If acsdr("Username") = txtUsername.Text Then
                    usernameexist = True
                End If
            End While
        Catch
            epUsername.SetError(txtUsername, "Username does not exist")
        End Try
        If usernameexist = False Then
            epUsername.SetError(txtUsername, "Username does not exist")
        Else
            epUsername.Clear()
        End If

    End Sub
    Sub verifypassword()
        Dim getpassword As String = ""
        correctpassword = False
        strsql = "select Password from Login where Username ='" & txtUsername.Text & "'"
        Dim acscmd As New OleDb.OleDbCommand
        acscmd.CommandText = strsql
        acscmd.Connection = acsconn
        acsda.SelectCommand = acscmd
        acsdr = acscmd.ExecuteReader

        While (acsdr.Read())
            getpassword = acsdr("Password")
        End While
        If txtCurrent.Text = getpassword Then
            correctpassword = True
        Else
            epPassword.SetError(txtCurrent, "Incorrect password.")
        End If
    End Sub
    Sub updatepassword()
        Try
            strsql = "update Login set [Password] ='" & txtPassword.Text & "'" _
                    & "where [Username] ='" & txtUsername.Text & "'"

            Dim acscmd As New OleDb.OleDbCommand
            acscmd.CommandText = strsql
            acscmd.Connection = acsconn
            acsda.SelectCommand = acscmd
            acsdr = acscmd.ExecuteReader

            MessageBox.Show("Password changed.", "Change password", MessageBoxButtons.OK, MessageBoxIcon.Information)

            acscmd.Dispose()
            acsdr.Close()
        Catch
            MessageBox.Show("Syntax error occur on updating.Please contact developer to fix the problem.", "Update Failed", MessageBoxButtons.OK, MessageBoxIcon.Stop)
        End Try
    End Sub

    Public Sub ClearTextFields(ByVal parent As Control)
        For Each ctl As Control In parent.Controls
            If TypeOf ctl Is TextBox Then
                If Text.Trim() <> String.Empty Then
                    ctl.Text = String.Empty
                End If
            End If
            If TypeOf ctl Is ComboBox Then
                If Text.Trim() <> String.Empty Then
                    ctl.Text = String.Empty
                End If
            End If
        Next
    End Sub

    Private Sub btnBack_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBack.Click
        Dim result As DialogResult
        result = MessageBox.Show("Do You Want to Back to Main Menu?", "Back", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)
        If result = Windows.Forms.DialogResult.OK Then
            Login.Show()
            Me.Hide()
        End If
    End Sub
    Private Sub btnChange_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnChange.Click
        verifyusername()
        verifypassword()
        If usernameexist = True And correctpassword = True Then
            If txtPassword.Text = txtConfirm.Text Then
                Dim result As DialogResult
                result = MessageBox.Show("Do you want to save change?", "Save", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                If result = Windows.Forms.DialogResult.Yes Then
                    updatepassword()
                    ClearTextFields(Me)
                    Login.Show()
                    Me.Hide()
                End If
            Else
                MessageBox.Show("Confirm password does not match with password.", "Change password", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txtPassword.Text = ""
                txtConfirm.Text = ""
                txtPassword.Focus()
            End If
        End If
    End Sub

    Private Sub Reset_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub txtUsername_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtUsername.TextChanged
        epUsername.Clear()
    End Sub

    Private Sub txtPassword_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtPassword.TextChanged
        epPassword.Clear()
    End Sub
End Class