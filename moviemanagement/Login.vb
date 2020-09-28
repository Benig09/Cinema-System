Public Class Login
 
    Dim userpassword As String
    Public Shared userexist As Boolean = False
    Public Shared statusrank As Boolean = True
    Dim userstatus As String
    Sub verifypassword()
        strsql = "select Password from Login where Username ='" & txtUsername.Text & "'"
        Dim acscmd As New OleDb.OleDbCommand
        acscmd.CommandText = strsql
        acscmd.Connection = acsconn
        acsda.SelectCommand = acscmd
        acsdr = acscmd.ExecuteReader

        While (acsdr.Read())
            userpassword = acsdr("Password")
        End While

        If txtPassword.Text = userpassword Then
            userexist = True
        End If
        acscmd.Dispose()
        acsdr.Close()
    End Sub
    Sub identifystatus()
        strsql = "select Status from Login where username ='" & txtUsername.Text & "'"
        Dim acscmd As New OleDb.OleDbCommand
        acscmd.CommandText = strsql
        acscmd.Connection = acsconn
        acsda.SelectCommand = acscmd
        acsdr = acscmd.ExecuteReader

        While (acsdr.Read())
            userstatus = acsdr("Status")
        End While

        acscmd.Dispose()
        acsdr.Close()
    End Sub
    Sub getid()
        strsql = "select StaffID from Login where username ='" & txtUsername.Text & "'"
        Dim acscmd As New OleDb.OleDbCommand
        acscmd.CommandText = strsql
        acscmd.Connection = acsconn
        acsda.SelectCommand = acscmd
        acsdr = acscmd.ExecuteReader

        While (acsdr.Read())
            userstatus = acsdr("StaffID")
        End While

        acscmd.Dispose()
        acsdr.Close()
    End Sub
    Private Sub Login_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        userexist = False
        Module1.connect()
    End Sub

    Private Sub btnLogin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLogin.Click
        If txtPassword.Text <> "" Then
            verifypassword()
            If userexist = True Then
                identifystatus()
                If userstatus = "Staff" Then
                    MainMenu1.tabMainMenu.TabPages.Remove(MainMenu1.tabManager)
                    ticket.btnNewSchedule.Enabled = False
                    ticket.btnPrice.Enabled = False
                    statusrank = False
                ElseIf userstatus = "staff" Then
                    MainMenu1.tabMainMenu.TabPages.Remove(MainMenu1.tabManager)
                    ticket.btnNewSchedule.Enabled = False
                    ticket.btnPrice.Enabled = False
                    statusrank = False
                End If
                Me.Hide()
                MessageBox.Show("Access granted. Welcome to Silver Screen Cinema.", "WELCOME", MessageBoxButtons.OK, MessageBoxIcon.Information)
                MainMenu1.Show()
            Else
                MessageBox.Show("Access denied! Incorrect username/password.", "Login fail", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txtPassword.Text = ""
                txtPassword.Focus()
            End If
        Else
            MessageBox.Show("Please type your password.", "Login fail", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        Dim result As DialogResult
        result = MessageBox.Show("Do you want to exit?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If result = Windows.Forms.DialogResult.Yes Then
            Me.Close()
        Else
            txtUsername.Focus()
        End If
    End Sub

    Private Sub linkreset_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles linkreset.LinkClicked
        Me.Hide()
        Reset.txtUsername.Text = txtUsername.Text
        Reset.Show()
    End Sub

    Private Sub linkForget_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles linkForget.LinkClicked
        Me.Hide()
        Reset.txtUsername.Text = txtUsername.Text
        Forgetpassword.Show()
    End Sub

End Class