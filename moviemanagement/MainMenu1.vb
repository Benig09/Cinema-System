Public Class MainMenu1

    Private Sub tabManager_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tabManager.Click

    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        Dim result As DialogResult
        result = MessageBox.Show("Do you want to exit?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If result = Windows.Forms.DialogResult.Yes Then
            Me.Close()
        End If
    End Sub

    Private Sub btnExit2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit2.Click
        Dim result As DialogResult
        result = MessageBox.Show("Do you want to exit?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If result = Windows.Forms.DialogResult.Yes Then
            Me.Close()
        End If
    End Sub

    Private Sub btnTicketManagement_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTicketManagement.Click
        ticket.Show()
        Me.Hide()
    End Sub

    Private Sub btnMemberManagement_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMemberManagement.Click
        member.btnClose.Enabled = False
        member.Show()
        Me.Hide()
    End Sub

    Private Sub btnMovieManagement_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMovieManagement.Click
        movie.Show()
        Me.Hide()
    End Sub

    Private Sub btnStaffManagement_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnStaffManagement.Click
        Staffmanagement.Show()
        Me.Hide()
    End Sub

    Private Sub btnRegister_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRegister.Click
        Register.Show()
        Me.Hide()
    End Sub

    Private Sub btnBack_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBack.Click
        Dim result As DialogResult
        result = MessageBox.Show("Do You Want to Back to Login Page?", "Back", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)
        If result = Windows.Forms.DialogResult.OK Then
            Login.userexist = False
            If Login.statusrank = False Then
                Me.tabMainMenu.TabPages.Add(Me.tabManager)
                ticket.btnNewSchedule.Enabled = True
                ticket.btnPrice.Enabled = True
            End If
            With Login
                .txtPassword.Text = ""
                .txtUsername.Text = ""
            End With
            Login.Show()
            Me.Hide()
        End If
    End Sub

    Private Sub btnBack2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBack2.Click
        Dim result As DialogResult
        result = MessageBox.Show("Do You Want to Back to Login Page?", "Back", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)
        If result = Windows.Forms.DialogResult.OK Then
            Login.userexist = False
            If Login.statusrank = False Then
                Me.tabMainMenu.TabPages.Add(Me.tabManager)
                ticket.btnNewSchedule.Enabled = True
                ticket.btnPrice.Enabled = True
            End If
            With Login
                .txtPassword.Text = ""
                .txtUsername.Text = ""
            End With
            Login.Show()
            Me.Hide()
        End If
    End Sub

    Private Sub tabStaff_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tabStaff.Click

    End Sub

    Private Sub btnReportGeneration_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReportGeneration.Click
        ReportGeneration.Show()
        Me.Close()
    End Sub
End Class