Public Class ReportGeneration
    Sub filldaterecord()
        Try
            strsql = "select * from Sales where Date1 ='" & cbDate.Text & "'"
            Dim acscmd As New OleDb.OleDbCommand
            acscmd.CommandText = strsql
            acscmd.Connection = acsconn
            acsdr = acscmd.ExecuteReader

            lvDate.Items.Clear()
            While (acsdr.Read())
                With lvDate.Items.Add(acsdr("MovieName"))
                    .subitems.add(acsdr("Time"))
                    .subitems.add(acsdr("Status"))
                    .subitems.add(acsdr("SeatNumber"))
                    .subitems.add(acsdr("Price"))
                End With
            End While
            acscmd.Dispose()
            acsdr.Close()
        Catch
            MessageBox.Show("Syntax error on filling lvDate. Please contact the developer for more information.", "Syantax Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Sub fillmovierecord()
        Try
            strsql = "select * from Sales where MovieName ='" & cbMovie.Text & "'"
            Dim acscmd As New OleDb.OleDbCommand
            acscmd.CommandText = strsql
            acscmd.Connection = acsconn
            acsdr = acscmd.ExecuteReader

            lvMovie.Items.Clear()
            While (acsdr.Read())
                With lvMovie.Items.Add(acsdr("Date1"))
                    .subitems.add(acsdr("Time"))
                    .subitems.add(acsdr("Status"))
                    .subitems.add(acsdr("SeatNumber"))
                    .subitems.add(acsdr("Price"))
                End With
            End While
            acscmd.Dispose()
            acsdr.Close()
        Catch
            MessageBox.Show("Syntax error on filling lvMovie. Please contact the developer for more information.", "Syantax Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Sub fillcbDate()
        strsql = "select distinct Date1 from Sales"
        Dim acscmd As New OleDb.OleDbCommand
        acscmd.CommandText = strsql
        acscmd.Connection = acsconn
        acsda.SelectCommand = acscmd
        acsdr = acscmd.ExecuteReader

        While (acsdr.Read())
            cbDate.Items.Add(acsdr("Date1"))
        End While

        acscmd.Dispose()
        acsdr.Close()
    End Sub
    Sub fillcbMovie()
        strsql = "select distinct MovieName from Sales"
        Dim acscmd As New OleDb.OleDbCommand
        acscmd.CommandText = strsql
        acscmd.Connection = acsconn
        acsda.SelectCommand = acscmd
        acsdr = acscmd.ExecuteReader

        While (acsdr.Read())
            cbMovie.Items.Add(acsdr("MovieName"))
        End While

        acscmd.Dispose()
        acsdr.Close()
    End Sub
    Private Sub btnBack_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBack.Click
        Dim result As DialogResult
        result = MessageBox.Show("Do you want to go back to previous page?", "Back", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)
        If result = Windows.Forms.DialogResult.OK Then
            lvDate.Items.Clear()
            lvMovie.Items.Clear()
            cbDate.Text = ""
            cbMovie.Text = ""
            MainMenu1.Show()
            Me.Hide()
        End If
    End Sub

    Private Sub btnBack1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBack1.Click
        Dim result As DialogResult
        result = MessageBox.Show("Do you want to go back to previous page?", "Back", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)
        If result = Windows.Forms.DialogResult.OK Then
            lvDate.Items.Clear()
            lvMovie.Items.Clear()
            cbDate.Text = ""
            cbMovie.Text = ""
            MainMenu1.Show()
            Me.Hide()
        End If
    End Sub

    Private Sub ReportGeneration_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Module1.connect()
        fillcbDate()
        fillcbMovie()
    End Sub

    Private Sub btnDateReport_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDateReport.Click
        filldaterecord()
    End Sub

    Private Sub btnMovieReport_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMovieReport.Click
        fillmovierecord()
    End Sub

    Private Sub btnPrintMovie_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrintMovie.Click
        PrintForm1.PrintAction = Printing.PrintAction.PrintToPreview
        PrintForm1.Print()
    End Sub

    Private Sub btnPrintDate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrintDate.Click
        PrintForm1.PrintAction = Printing.PrintAction.PrintToPreview
        PrintForm1.Print()
    End Sub
End Class