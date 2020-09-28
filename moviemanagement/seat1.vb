Public Class seat1
    Dim seatstatus(25) As Integer
    Dim existflag As Boolean = False
    Sub savereservedseat()
        strsql = "INSERT INTO Seat (ScheduleID, Seat1, Seat2, Seat3, Seat4, Seat5, Seat6, Seat7, Seat8, Seat9, Seat10, " _
        + "Seat11, Seat12, Seat13, Seat14, Seat15, Seat16, Seat17, Seat18, Seat19, Seat20, Seat21, Seat22, Seat23, Seat24) values(" _
        & schedid & ", " _
        & seatstatus(1) & ", " _
        & seatstatus(2) & ", " _
        & seatstatus(3) & ", " _
        & seatstatus(4) & ", " _
        & seatstatus(5) & ", " _
        & seatstatus(6) & ", " _
        & seatstatus(7) & ", " _
        & seatstatus(8) & ", " _
        & seatstatus(9) & ", " _
        & seatstatus(10) & ", " _
        & seatstatus(11) & ", " _
        & seatstatus(12) & ", " _
        & seatstatus(13) & ", " _
        & seatstatus(14) & ", " _
        & seatstatus(15) & ", " _
        & seatstatus(16) & ", " _
        & seatstatus(17) & ", " _
        & seatstatus(18) & ", " _
        & seatstatus(19) & ", " _
        & seatstatus(20) & ", " _
        & seatstatus(21) & ", " _
        & seatstatus(22) & ", " _
        & seatstatus(23) & ", " _
        & seatstatus(24) & ")"

        Dim acscmd As New OleDb.OleDbCommand
        acscmd.CommandText = strsql
        acscmd.Connection = acsconn
        acscmd.ExecuteNonQuery()
        acscmd.Dispose()
    End Sub

    Sub loadseat()
        strsql = "select * from Seat where ScheduleID = " & schedid

        Dim acscmd As New OleDb.OleDbCommand
        acscmd.CommandText = strsql
        acscmd.Connection = acsconn
        acsdr = acscmd.ExecuteReader


        While (acsdr.Read())
            seatstatus(1) = acsdr("Seat1")
            seatstatus(2) = acsdr("Seat2")
            seatstatus(3) = acsdr("Seat3")
            seatstatus(4) = acsdr("Seat4")
            seatstatus(5) = acsdr("Seat5")
            seatstatus(6) = acsdr("Seat6")
            seatstatus(7) = acsdr("Seat7")
            seatstatus(8) = acsdr("Seat8")
            seatstatus(9) = acsdr("Seat9")
            seatstatus(10) = acsdr("Seat10")
            seatstatus(11) = acsdr("Seat11")
            seatstatus(12) = acsdr("Seat12")
            seatstatus(13) = acsdr("Seat13")
            seatstatus(14) = acsdr("Seat14")
            seatstatus(15) = acsdr("Seat15")
            seatstatus(16) = acsdr("Seat16")
            seatstatus(17) = acsdr("Seat17")
            seatstatus(18) = acsdr("Seat18")
            seatstatus(19) = acsdr("Seat19")
            seatstatus(20) = acsdr("Seat20")
            seatstatus(21) = acsdr("Seat21")
            seatstatus(22) = acsdr("Seat22")
            seatstatus(23) = acsdr("Seat23")
            seatstatus(24) = acsdr("Seat24")
        End While

        fillseat(seatstatus(1), a1)
        fillseat(seatstatus(2), a2)
        fillseat(seatstatus(3), a3)
        fillseat(seatstatus(4), a4)
        fillseat(seatstatus(5), a5)
        fillseat(seatstatus(6), a6)
        fillseat(seatstatus(7), b1)
        fillseat(seatstatus(8), b2)
        fillseat(seatstatus(9), b3)
        fillseat(seatstatus(10), b4)
        fillseat(seatstatus(11), b5)
        fillseat(seatstatus(12), b6)
        fillseat(seatstatus(13), c1)
        fillseat(seatstatus(14), c2)
        fillseat(seatstatus(15), c3)
        fillseat(seatstatus(16), c4)
        fillseat(seatstatus(17), c5)
        fillseat(seatstatus(18), c6)
        fillseat(seatstatus(19), d1)
        fillseat(seatstatus(20), d2)
        fillseat(seatstatus(21), d3)
        fillseat(seatstatus(22), d4)
        fillseat(seatstatus(23), d5)
        fillseat(seatstatus(24), d6)


        acscmd.Dispose()
        acsdr.Close()
    End Sub
    Sub updatereservedseat()
        strsql = "update Seat set ScheduleID = " & schedid & ", " _
        & "Seat1 = " & seatstatus(1) & ", " _
        & "Seat2 = " & seatstatus(2) & ", " _
        & "Seat3 = " & seatstatus(3) & ", " _
        & "Seat4 = " & seatstatus(4) & ", " _
        & "Seat5 = " & seatstatus(5) & ", " _
        & "Seat6 = " & seatstatus(6) & ", " _
        & "Seat7 = " & seatstatus(7) & ", " _
        & "Seat8 = " & seatstatus(8) & ", " _
        & "Seat9 = " & seatstatus(9) & ", " _
        & "Seat10 = " & seatstatus(10) & ", " _
        & "Seat11 = " & seatstatus(11) & ", " _
        & "Seat12 = " & seatstatus(12) & ", " _
        & "Seat13 = " & seatstatus(13) & ", " _
        & "Seat14 = " & seatstatus(14) & ", " _
        & "Seat15 = " & seatstatus(15) & ", " _
        & "Seat16 = " & seatstatus(16) & ", " _
        & "Seat17 = " & seatstatus(17) & ", " _
        & "Seat18 = " & seatstatus(18) & ", " _
        & "Seat19 = " & seatstatus(19) & ", " _
        & "Seat20 = " & seatstatus(20) & ", " _
        & "Seat21 = " & seatstatus(21) & ", " _
        & "Seat22 = " & seatstatus(22) & ", " _
        & "Seat23 = " & seatstatus(23) & ", " _
        & "Seat24 = " & seatstatus(24) & " where ScheduleID = " & schedid


        Dim acscmd As New OleDb.OleDbCommand
        acscmd.CommandText = strsql
        acscmd.Connection = acsconn
        acscmd.ExecuteNonQuery()
        acscmd.Dispose()
    End Sub
    Sub fillseat(ByVal state As Integer, ByVal seat As CheckBox)
        If state = 1 Then
            seat.CheckState = CheckState.Unchecked
            seat.Image = My.Resources.chair2
            seat.Enabled = False
        Else
            seat.CheckState = CheckState.Unchecked
            seat.Image = My.Resources.chair
            seat.Enabled = True
        End If

    End Sub
    Sub checkexisting()
        strsql = "select ScheduleID from Seat"
        Dim acscmd As New OleDb.OleDbCommand
        acscmd.CommandText = strsql
        acscmd.Connection = acsconn
        acsdr = acscmd.ExecuteReader

        While (acsdr.Read())
            If (acsdr("ScheduleID")) = schedid Then
                existflag = True
            Else
                seatstatus(25) = 0
            End If
        End While

        acscmd.Dispose()
        acsdr.Close()
        acsdr.Close()
    End Sub
    Private Sub seat1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Module1.connect()
        checkexisting()
        loadseat()
    End Sub

    Private Sub btnReserved_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReserved.Click
        Dim i As Integer
        seatselectednum = 0
        If a1.Checked = True Then
            seatstatus(1) = 1
            seatpicked(i) = "a1"
            i += 1
            seatselectednum += 1
        End If
        If a2.Checked = True Then
            seatstatus(2) = 1
            seatpicked(i) = "a2"
            i += 1
            seatselectednum += 1
        End If
        If a3.Checked = True Then
            seatstatus(3) = 1
            seatpicked(i) = "a3"
            i += 1
            seatselectednum += 1
        End If
        If a4.Checked = True Then
            seatstatus(4) = 1
            seatpicked(i) = "a4"
            i += 1
            seatselectednum += 1
        End If
        If a5.Checked = True Then
            seatstatus(5) = 1
            seatpicked(i) = "a5"
            i += 1
            seatselectednum += 1
        End If
        If a6.Checked = True Then
            seatstatus(6) = 1
            seatpicked(i) = "a6"
            i += 1
            seatselectednum += 1
        End If
        If b1.Checked = True Then
            seatstatus(7) = 1
            seatpicked(i) = "b1"
            i += 1
            seatselectednum += 1
        End If
        If b2.Checked = True Then
            seatstatus(8) = 1
            seatpicked(i) = "b2"
            i += 1
            seatselectednum += 1
        End If
        If b3.Checked = True Then
            seatstatus(9) = 1
            seatpicked(i) = "b3"
            i += 1
            seatselectednum += 1
        End If
        If b4.Checked = True Then
            seatstatus(10) = 1
            seatpicked(i) = "b4"
            i += 1
            seatselectednum += 1
        End If
        If b5.Checked = True Then
            seatstatus(11) = 1
            seatpicked(i) = "b5"
            i += 1
            seatselectednum += 1
        End If
        If b6.Checked = True Then
            seatstatus(12) = 1
            seatpicked(i) = "b6"
            i += 1
            seatselectednum += 1
        End If
        If c1.Checked = True Then
            seatstatus(13) = 1
            seatpicked(i) = "c1"
            i += 1
            seatselectednum += 1
        End If
        If c2.Checked = True Then
            seatstatus(14) = 1
            seatpicked(i) = "c2"
            i += 1
            seatselectednum += 1
        End If
        If c3.Checked = True Then
            seatstatus(15) = 1
            seatpicked(i) = "c3"
            i += 1
            seatselectednum += 1
        End If
        If c4.Checked = True Then
            seatstatus(16) = 1
            seatpicked(i) = "c4"
            i += 1
            seatselectednum += 1
        End If
        If c5.Checked = True Then
            seatstatus(17) = 1
            seatpicked(i) = "c5"
            i += 1
            seatselectednum += 1
        End If
        If c6.Checked = True Then
            seatstatus(18) = 1
            seatpicked(i) = "c6"
            i += 1
            seatselectednum += 1
        End If
        If d1.Checked = True Then
            seatstatus(19) = 1
            seatpicked(i) = "d1"
            i += 1
            seatselectednum += 1
        End If
        If d2.Checked = True Then
            seatstatus(20) = 1
            seatpicked(i) = "d2"
            i += 1
            seatselectednum += 1
        End If
        If d3.Checked = True Then
            seatstatus(21) = 1
            seatpicked(i) = "d3"
            i += 1
            seatselectednum += 1
        End If
        If d4.Checked = True Then
            seatstatus(22) = 1
            seatpicked(i) = "d4"
            i += 1
            seatselectednum += 1
        End If
        If d5.Checked = True Then
            seatstatus(23) = 1
            seatpicked(i) = "d5"
            i += 1
            seatselectednum += 1
        End If
        If d6.Checked = True Then
            seatstatus(24) = 1
            seatpicked(i) = "d6"
            i += 1
            seatselectednum += 1
        End If
        If existflag = False Then
            savereservedseat()
        Else
            updatereservedseat()
        End If
        loadseat()
    End Sub

    Private Sub btnPay_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPay.Click
        ticket.Show()
        Me.Close()
    End Sub

    Private Sub btnBack_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBack.Click
        Dim result As DialogResult
        result = MessageBox.Show("Do You Want to Back?", "Back", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)
        If result = Windows.Forms.DialogResult.OK Then
            ticket.Show()
            Me.Close()
        End If
    End Sub
End Class