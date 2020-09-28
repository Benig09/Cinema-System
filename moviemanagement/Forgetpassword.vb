Public Class Forgetpassword
    Dim usernameexist, correctic, existID As Boolean
    Sub verifyID()
        existID = False
        Try
            strsql = "select StaffID from Staff"
            Dim acscmd As New OleDb.OleDbCommand
            acscmd.CommandText = strsql
            acscmd.Connection = acsconn
            acsda.SelectCommand = acscmd
            acsdr = acscmd.ExecuteReader

            While (acsdr.Read())
                If acsdr("StaffID") = txtStaffID.Text Then
                    existID = True
                End If
            End While
        Catch
            epID.SetError(txtStaffID, "Invalid ID")
        End Try
        If existID = False Then
            epID.SetError(txtStaffID, "Invalid ID")
        Else
            epID.Clear()
        End If
    End Sub
    Sub verifyIC()
        correctic = False
        Try
            strsql = "select IC from Staff where StaffID = " & txtStaffID.Text
            Dim acscmd As New OleDb.OleDbCommand
            acscmd.CommandText = strsql
            acscmd.Connection = acsconn
            acsda.SelectCommand = acscmd
            acsdr = acscmd.ExecuteReader
            While (acsdr.Read())
                If acsdr("IC") = txtIC.Text Then
                    correctic = True
                End If
            End While
        Catch
            epIC.SetError(txtIC, "Incorrect IC number.")
        End Try
        If correctic = False Then
            epIC.SetError(txtIC, "Incorrect IC number.")
        Else
            epIC.Clear()
        End If
    End Sub
    Sub verifyusername()
        usernameexist = False
        Try
            strsql = "select Username from Login where StaffID = " & txtStaffID.Text
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
    Sub updatepassword()
        Try
            strsql = "update Login set [Password] ='" & txtPassword.Text & "'" _
            & "where [Username] ='" & txtUsername.Text & "'"
            Dim acscmd As New OleDb.OleDbCommand
            acscmd.CommandText = strsql
            acscmd.Connection = acsconn
            acsda.SelectCommand = acscmd
            acsdr = acscmd.ExecuteReader
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
    Private Sub Forgetpassword_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnSavechange_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSavechange.Click
        verifyID()
        verifyIC()
        verifyusername()
        If txtConfirm.Text = "" Then
            epConfirm.SetError(txtConfirm, "Please re-type your password.")
        ElseIf txtConfirm.Text = txtPassword.Text Then
            If existID = True And correctic = True And usernameexist = True Then
                epConfirm.Clear()
                Dim result As DialogResult
                result = MessageBox.Show("Do you want to save changes?", "Save", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)
                If result = Windows.Forms.DialogResult.OK Then
                    updatepassword()
                    ClearTextFields(Me)
                    Login.Show()
                    Me.Hide()
                End If
            End If
        End If
    End Sub

    Private Sub txtStaffID_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtStaffID.TextChanged
        epID.Clear()
    End Sub

    Private Sub txtIC_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtIC.TextChanged
        epIC.Clear()
    End Sub

    Private Sub txtUsername_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtUsername.TextChanged
        epUsername.Clear()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim result As DialogResult
        result = MessageBox.Show("Do You Want to Back?", "Back", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)
        If result = Windows.Forms.DialogResult.OK Then
            Login.Show()
            Me.Hide()
        End If
    End Sub
End Class