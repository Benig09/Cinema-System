Public Class member
    Dim firststatus As Boolean = False
    Dim laststattus As Boolean = False
    Dim icstatus As Boolean = False
    Public tempid As Integer
    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        firsterror()
        lasterror()
        icerror()
        If firststatus = True And laststattus = True And icstatus = True Then
            strsql = "INSERT INTO Member ([FirstName], [LastName], [IC], [Email], [Address], [City], [Poscode], [State] ) values ('" _
       & txtFirstName.Text & "', '" _
       & txtLastName.Text & "', '" _
       & txtIC.Text & "', '" _
       & txtEmail.Text & "', '" _
       & txtAddress.Text & "', '" _
       & txtCity.Text & "', '" _
       & txtPoscode.Text & "', '" _
       & txtState.Text & "')"

            Dim acscmd As New OleDb.OleDbCommand
            acscmd.CommandText = strsql
            acscmd.Connection = acsconn
            acscmd.ExecuteNonQuery()
            acscmd.Dispose()

            MsgBox("System Updated")
            Me.filllistview()
            ClearTextFields(Me)
            generateid()
            Me.Show()
            disableallflag()

        End If

    End Sub

    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        Dim result As DialogResult
        result = MessageBox.Show("Do You Want to Delete?", "Delete", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)
        If result = Windows.Forms.DialogResult.OK Then
            strsql = "delete * from Member where MemberID = " & txtID.Text

            Dim acscmd As New OleDb.OleDbCommand
            acscmd.CommandText = strsql
            acscmd.Connection = acsconn
            acscmd.ExecuteNonQuery()
            acscmd.Dispose()

            MsgBox("Removed From System")
            Me.filllistview()
            txtFirstName.Focus()
            btnEdit.Enabled = False
            btnDelete.Enabled = False
            txtID.Clear()
            ClearTextFields(Me)
            btnAdd.Enabled = True
        End If
    End Sub

    Private Sub btnBack_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBack.Click
        MainMenu1.Show()
        Me.Hide()
    End Sub


    Sub filllistview()
        strsql = "select * from Member order by MemberID"
        Dim acscmd As New OleDb.OleDbCommand
        acscmd.CommandText = strsql
        acscmd.Connection = acsconn
        acsdr = acscmd.ExecuteReader

        ListView1.Items.Clear()

        While (acsdr.Read())
            With ListView1.Items.Add(acsdr("MemberID"))
                .subitems.add(acsdr("FirstName"))
                .subitems.add(acsdr("LastName"))
                .subitems.add(acsdr("IC"))
                .subitems.add(acsdr("Address"))
                .subitems.add(acsdr("Email"))
                .subitems.add(acsdr("City"))
                .subitems.add(acsdr("Poscode"))
                .subitems.add(acsdr("State"))
            End With
        End While

        acscmd.Dispose()
        acsdr.Close()
    End Sub

    Sub generateid()

        strsql = "select TOP 1 MemberID from Member order by MemberID desc"

        Dim acscmd As New OleDb.OleDbCommand
        acscmd.CommandText = strsql
        acscmd.Connection = acsconn
        acsdr = acscmd.ExecuteReader


        If (acsdr.Read()) Then
            tempid = acsdr("MemberID") + 1
        End If
        acscmd.Dispose()
        acsdr.Close()

        txtID.Text = tempid


    End Sub

    Private Sub memberManagement_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Module1.connect()
        Me.filllistview()
        generateid()
        txtID.Enabled = False
        btnEdit.Enabled = False
        btnDelete.Enabled = False


    End Sub

    Private Sub btnEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEdit.Click

        firsterror()
        lasterror()
        icerror()
        If firststatus = True And laststattus = True And icstatus = True Then
            strsql = "update Member set FirstName ='" & txtFirstName.Text & "'," _
          & "LastName ='" & txtLastName.Text & "'," _
          & "IC ='" & txtIC.Text & "'," _
          & "Email ='" & txtEmail.Text & "'," _
          & "Address ='" & txtAddress.Text & "'," _
          & "City ='" & txtCity.Text & "'," _
          & "Poscode ='" & txtPoscode.Text & "'," _
          & "State ='" & txtState.Text & "'" _
          & "where MemberID = " & txtID.Text



            Dim acscmd As New OleDb.OleDbCommand
            acscmd.CommandText = strsql
            acscmd.Connection = acsconn
            acscmd.ExecuteNonQuery()
            acscmd.Dispose()

            MsgBox("updated")
            btnEdit.Enabled = False
            btnDelete.Enabled = False
            disableallflag()
            Me.filllistview()
            ClearTextFields(Me)
            btnAdd.Enabled = True
        End If
    End Sub

    Private Sub ListView1_MouseDoubleClick1(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles ListView1.MouseDoubleClick

        With ListView1.SelectedItems(0)
            txtID.Text = .SubItems(0).Text
            txtAddress.Text = .SubItems(4).Text
            txtIC.Text = .SubItems(3).Text
            txtLastName.Text = .SubItems(2).Text
            txtFirstName.Text = .SubItems(1).Text
            txtEmail.Text = .SubItems(5).Text
            txtState.Text = .SubItems(8).Text
            txtPoscode.Text = .SubItems(7).Text
            txtCity.Text = .SubItems(6).Text
        End With
        btnAdd.Enabled = False
        btnDelete.Enabled = True
        btnEdit.Enabled = True


    End Sub
    Sub searchrecord(ByVal searchword As String)
        strsql = "select * from Member where FirstName like '" & searchword & "%'"
        Dim acscmd As New OleDb.OleDbCommand
        acscmd.CommandText = strsql
        acscmd.Connection = acsconn
        acsdr = acscmd.ExecuteReader

        ListView1.Items.Clear()

        While (acsdr.Read())
            With ListView1.Items.Add(acsdr("MemberID"))
                .subitems.add(acsdr("FirstName"))
                .subitems.add(acsdr("LastName"))
                .subitems.add(acsdr("IC"))
                .subitems.add(acsdr("Address"))
                .subitems.add(acsdr("Email"))
                .subitems.add(acsdr("City"))
                .subitems.add(acsdr("Poscode"))
                .subitems.add(acsdr("State"))
            End With
        End While

        acscmd.Dispose()
        acsdr.Close()
    End Sub

    Private Sub txtMemberName_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtMemberName.TextChanged
        searchrecord(txtMemberName.Text)
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnclear1.Click
        ClearTextFields(Me)
        btnAdd.Enabled = True

        btnEdit.Enabled = False
        btnDelete.Enabled = False
        txtFirstName.Focus()
        generateid()
        filllistview()



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

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Hide()
    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        Dim result As DialogResult
        result = MessageBox.Show("Do you want to exit?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If result = Windows.Forms.DialogResult.Yes Then
            Me.Close()
        End If
    End Sub

    Sub firsterror()
        If txtFirstName.Text = "" Then
            ErrorProvider1.SetError(txtFirstName, "Cannot leave textbox blank")
            MsgBox("Must Fill In The First Name")
        ElseIf IsNumeric(txtFirstName.Text) Then
            MsgBox("First Name Must be in Alphabet")
        Else
            ErrorProvider1.Clear()
            firststatus = True
        End If
    End Sub
    Sub disableallflag()
        firststatus = False
        laststattus = False
        icstatus = False
    End Sub
    Sub icerror()
        If txtIC.Text = "" Then
            ErrorProvider3.SetError(txtIC, "Cannot leave textbox blank")
            MsgBox("Must Fill In The IC Number")
        ElseIf Not IsNumeric(txtIC.Text) Then
            ErrorProvider3.SetError(txtIC, "Must be in Digits")
            MsgBox("IC Number Must be in Digits")
        Else
            ErrorProvider3.Clear()
            icstatus = True
        End If
    End Sub
    Sub lasterror()
        If txtLastName.Text = "" Then
            ErrorProvider2.SetError(txtLastName, "Cannot leave textbox blank")
            MsgBox("Must Fill In The Last Name")
        ElseIf IsNumeric(txtLastName.Text) Then
            MsgBox("Last Name Must be in Alphabet")
        Else
            ErrorProvider2.Clear()
            laststattus = True
        End If
    End Sub

    Private Sub ListView1_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles ListView1.SelectedIndexChanged

    End Sub
End Class