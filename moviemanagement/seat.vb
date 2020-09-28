Public Class seat
    Private Sub btnReserved_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReserved.Click
        Dim i As Integer = 0
        'reservedseatnumber = 0
        For Each ctrl As Control In Me.Controls
            If TypeOf ctrl Is CheckBox Then
                Dim cb As CheckBox = DirectCast(ctrl, CheckBox)
                If cb.Checked Then
                    cb.Image = My.Resources.chair2
                    cb.CheckState = CheckState.Unchecked
                    cb.Enabled = False
                    ' reservedseatnumber += 1
                    'totalticket += 1
                    'soldticketnumber(i) = cb.Name
                    i += 1
                End If
            End If
        Next
    End Sub

    Private Sub btnBack_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBack.Click
        Me.Hide()
    End Sub

    Private Sub btnPay_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPay.Click
        Me.Hide()
    End Sub

    Private Sub seat_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class