Public Class Register
    Dim existID As Boolean
    Dim existusername As Boolean

    Sub checkID()
        Dim staffid As Integer = -1
        strsql = "select StaffID from Staff where StaffID = " & txtStaffID.Text
        Dim acscmd As New OleDb.OleDbCommand
        acscmd.CommandText = strsql
        acscmd.Connection = acsconn
        acsda.SelectCommand = acscmd
        acsdr = acscmd.ExecuteReader

        While (acsdr.Read())
            staffid = acsdr("StaffID")
        End While
        If staffid = txtStaffID.Text Then
            existID = True
        Else
            existID = False
            epID.SetError(txtStaffID, "Staff ID already in use.")
        End If

    End Sub

    Sub checkusername()
        Dim getname As String = ""

        strsql = "select Username from Login where Username ='" & txtUsername.Text & "'"
        Dim acscmd As New OleDb.OleDbCommand
        acscmd.CommandText = strsql
        acscmd.Connection = acsconn
        acsda.SelectCommand = acscmd
        acsdr = acscmd.ExecuteReader

        While (acsdr.Read())
            getname = acsdr("Username")
        End While
        If txtUsername.Text = getname Then
            existusername = True
            epUsername.SetError(txtUsername, "Username already in use.")
        Else
            existusername = False
        End If

    End Sub
    Sub registeraccount()
        strsql = "INSERT INTO Login ([Username], [StaffID], [Password], [Status]) values ('" _
                   & txtUsername.Text & "', '" _
                    & txtStaffID.Text & "', '" _
                   & txtPassword.Text & "', '" _
                   & cbStatus.Text & "')"
        Dim acscmd As New OleDb.OleDbCommand
        acscmd.CommandText = strsql
        acscmd.Connection = acsconn
        acscmd.ExecuteNonQuery()
        acscmd.Dispose()
        MessageBox.Show("Account Saved", "Save", MessageBoxButtons.OK, MessageBoxIcon.Information)
        txtConfirm.Text = ""
        txtStaffID.Text = ""
        txtUsername.Text = ""
        txtPassword.Text = ""
        cbStatus.Text = ""
    End Sub

    Private Sub btnRegister_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRegister.Click
        checkID()
        checkusername()
        If existID = True And existusername = False Then
            If txtPassword.Text = txtConfirm.Text Then
                registeraccount()
            Else
                MessageBox.Show("Password is not same with Confirm Password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information)
                txtConfirm.Text = ""
                txtPassword.Text = ""
                txtPassword.Focus()
            End If
        End If
    End Sub

    Private Sub btnBack_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBack.Click
        Dim result As DialogResult
        result = MessageBox.Show("Do You Want to Back to Main Menu?", "Back", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)
        If result = Windows.Forms.DialogResult.OK Then
            MainMenu1.Show()
            Me.Close()
        End If
    End Sub

    Private Sub Register_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub txtUsername_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtUsername.TextChanged
        epUsername.Clear()
    End Sub

    Private Sub txtStaffID_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtStaffID.TextChanged
        epID.Clear()
    End Sub

    Private Sub cbStatus_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cbStatus.SelectedIndexChanged

    End Sub
End Class