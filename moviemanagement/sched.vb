Public Class sched
    Dim movieduration As DateTime
    Sub fillcombo()

        strsql = "select MovieName from Movie"
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
    Sub defaultcbHall()
        With cbHall.Items
            .Clear()
            .Add("1")
            .Add("2")
            .Add("3")
            .Add("4")
            .Add("5")
        End With
    End Sub
    Sub hallverifying()
        Try
            Dim hallnumber As Integer
            strsql = "select distinct HallNum from Schedule where Date='" & dtpSelectDate.Text & "'"
            Dim acscmd As New OleDb.OleDbCommand
            acscmd.CommandText = strsql
            acscmd.Connection = acsconn
            acsdr = acscmd.ExecuteReader

            While (acsdr.Read())
                Int32.TryParse(acsdr("HallNum"), hallnumber)
                cbHall.Items.RemoveAt(hallnumber - 1)
            End While

            acscmd.Dispose()
            acsdr.Close()
        Catch
            MessageBox.Show("Error on searching HallNum. Please contact developer for more details.", "System Fail", MessageBoxButtons.OK, MessageBoxIcon.Stop)
        End Try
    End Sub
    Sub getmovielength()
        strsql = "select MovieLength from Movie where MovieName ='" & cbMovie.Text & "'"
        Dim acscmd As New OleDb.OleDbCommand
        acscmd.CommandText = strsql
        acscmd.Connection = acsconn
        acsdr = acscmd.ExecuteReader

        While (acsdr.Read())
            movieduration = acsdr("MovieLength")
        End While

    End Sub
    Sub addmovieduration(ByVal movieduration As DateTime, ByVal dtp1 As DateTimePicker, ByVal dtp2 As DateTimePicker)
        Dim hour As Integer = movieduration.Hour
        Dim minute As Integer = movieduration.Minute
        Dim second As Integer = movieduration.Second
        Dim dt1 As DateTime = dtp1.Text
        Dim dt2 As DateTime = dt1.AddHours(hour).AddMinutes(minute).AddSeconds(second)
        dtp2.Text = dt2.ToString("h:mm:ss tt")
    End Sub

    Sub saverecord(ByVal dtpf As String, ByVal dtpt As String)
        strsql = "INSERT INTO Schedule ([MovieName], [Date], [HallNum], [From], [To]) values ('" _
       & cbMovie.Text & "', '" _
       & dtpSelectDate.Text & "', " _
       & cbHall.Text & ", '" _
       & dtpf & "', '" _
       & dtpt & "')"

        Dim acscmd As New OleDb.OleDbCommand
        acscmd.CommandText = strsql
        acscmd.Connection = acsconn
        acscmd.ExecuteNonQuery()
        acscmd.Dispose()

    End Sub
    Sub defaultdtp()
        dtpf1.Format = DateTimePickerFormat.Custom
        dtpf1.CustomFormat = " "
        dtpt1.Format = DateTimePickerFormat.Custom
        dtpt1.CustomFormat = " "
        dtpf2.Format = DateTimePickerFormat.Custom
        dtpf2.CustomFormat = " "
        dtpt2.Format = DateTimePickerFormat.Custom
        dtpt2.CustomFormat = " "
        dtpf3.Format = DateTimePickerFormat.Custom
        dtpf3.CustomFormat = " "
        dtpt3.Format = DateTimePickerFormat.Custom
        dtpt3.CustomFormat = " "
        dtpf4.Format = DateTimePickerFormat.Custom
        dtpf4.CustomFormat = " "
        dtpt4.Format = DateTimePickerFormat.Custom
        dtpt4.CustomFormat = " "
        dtpf5.Format = DateTimePickerFormat.Custom
        dtpf5.CustomFormat = " "
        dtpt5.Format = DateTimePickerFormat.Custom
        dtpt5.CustomFormat = " "
        dtpf6.Format = DateTimePickerFormat.Custom
        dtpf6.CustomFormat = " "
        dtpt6.Format = DateTimePickerFormat.Custom
        dtpt6.CustomFormat = " "
        dtpf7.Format = DateTimePickerFormat.Custom
        dtpf7.CustomFormat = " "
        dtpt7.Format = DateTimePickerFormat.Custom
        dtpt7.CustomFormat = " "
        dtpf8.Format = DateTimePickerFormat.Custom
        dtpf8.CustomFormat = " "
        dtpt8.Format = DateTimePickerFormat.Custom
        dtpt8.CustomFormat = " "
        dtpf9.Format = DateTimePickerFormat.Custom
        dtpf9.CustomFormat = " "
        dtpt9.Format = DateTimePickerFormat.Custom
        dtpt9.CustomFormat = " "
        dtpf10.Format = DateTimePickerFormat.Custom
        dtpf10.CustomFormat = " "
        dtpt10.Format = DateTimePickerFormat.Custom
        dtpt10.CustomFormat = " "


    End Sub

    Public Sub ClearTextFields(ByVal parent As Control)
        For Each ctl As Control In Me.Controls
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
    Sub dtpformat(ByVal sender1 As DateTimePicker, ByVal sender2 As DateTimePicker)
        sender1.Format = DateTimePickerFormat.Custom
        sender1.CustomFormat = "h:mm:ss tt"
        sender2.Format = DateTimePickerFormat.Custom
        sender2.CustomFormat = "h:mm:ss tt"

    End Sub

    Private Sub sched_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Module1.connect()
        defaultcbHall()
        defaultdtp()
        Me.fillcombo()
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        Dim result As DialogResult
        result = MessageBox.Show("This is a irreversible process. Are you sure with the data u want to save?", "Save", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)
        If result = Windows.Forms.DialogResult.OK Then
            If dtpf1.CustomFormat <> " " Then
                saverecord(dtpf1.Text, dtpt1.Text)
            End If
            If dtpf2.CustomFormat <> " " Then
                saverecord(dtpf2.Text, dtpt2.Text)
            End If
            If dtpf3.CustomFormat <> " " Then
                saverecord(dtpf3.Text, dtpt3.Text)
            End If
            If dtpf4.CustomFormat <> " " Then
                saverecord(dtpf4.Text, dtpt4.Text)
            End If
            If dtpf5.CustomFormat <> " " Then
                saverecord(dtpf5.Text, dtpt5.Text)
            End If
            If dtpf6.CustomFormat <> " " Then
                saverecord(dtpf6.Text, dtpt6.Text)
            End If
            If dtpf7.CustomFormat <> " " Then
                saverecord(dtpf7.Text, dtpt7.Text)
            End If
            If dtpf8.CustomFormat <> " " Then
                saverecord(dtpf8.Text, dtpt8.Text)
            End If
            If dtpf9.CustomFormat <> " " Then
                saverecord(dtpf9.Text, dtpt9.Text)
            End If
            If dtpf10.CustomFormat <> " " Then
                saverecord(dtpf10.Text, dtpt10.Text)
            End If
            defaultdtp()
            ClearTextFields(Me)
            MsgBox("saved")
        End If
    End Sub

    Private Sub dtpf1_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles dtpf1.MouseDown
        dtpformat(dtpt1, dtpf1)
        dtpt1.Enabled = True
    End Sub

    Private Sub dtpf2_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles dtpf2.MouseDown
        dtpformat(dtpt2, dtpf2)
        dtpt2.Enabled = True
    End Sub

    Private Sub dtpf3_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles dtpf3.MouseDown
        dtpformat(dtpt3, dtpf3)
        dtpt3.Enabled = True
    End Sub

    Private Sub dtpf4_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles dtpf4.MouseDown
        dtpformat(dtpt4, dtpf4)
        dtpt4.Enabled = True
    End Sub

    Private Sub dtpf5_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles dtpf5.MouseDown
        dtpformat(dtpt5, dtpf5)
        dtpt5.Enabled = True
    End Sub

    Private Sub dtpf6_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles dtpf6.MouseDown
        dtpformat(dtpt6, dtpf6)
        dtpt6.Enabled = True
    End Sub

    Private Sub dtpf7_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles dtpf7.MouseDown
        dtpformat(dtpt7, dtpf7)
        dtpt7.Enabled = True
    End Sub

    Private Sub dtpf8_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles dtpf8.MouseDown
        dtpformat(dtpt8, dtpf8)
        dtpt8.Enabled = True
    End Sub

    Private Sub dtpf9_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles dtpf9.MouseDown
        dtpformat(dtpt9, dtpf9)
        dtpt9.Enabled = True
    End Sub

    Private Sub dtpf10_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles dtpf10.MouseDown
        dtpformat(dtpt10, dtpf10)
        dtpt10.Enabled = True
    End Sub

    Private Sub btnBack_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBack.Click
        Dim result As DialogResult
        result = MessageBox.Show("Do You Want to Back?", "Back", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)
        If result = Windows.Forms.DialogResult.OK Then
            ticket.Show()
            Me.Hide()
        End If
    End Sub

    Private Sub cbMovie_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbMovie.SelectedIndexChanged
        getmovielength()
    End Sub

    Private Sub dtpt1_MouseDown1(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles dtpt1.MouseDown
        addmovieduration(movieduration, dtpf1, dtpt1)
    End Sub

    Private Sub dtpt2_MouseDown1(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles dtpt2.MouseDown
        addmovieduration(movieduration, dtpf2, dtpt2)
    End Sub

    Private Sub dtpt3_MouseDown1(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles dtpt3.MouseDown
        addmovieduration(movieduration, dtpf3, dtpt3)
    End Sub

    Private Sub dtpt4_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles dtpt4.MouseDown
        addmovieduration(movieduration, dtpf4, dtpt4)
    End Sub

    Private Sub dtpt5_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles dtpt5.MouseDown
        addmovieduration(movieduration, dtpf5, dtpt5)
    End Sub

    Private Sub dtpt6_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles dtpt6.MouseDown
        addmovieduration(movieduration, dtpf6, dtpt6)
    End Sub

    Private Sub dtpt7_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles dtpt7.MouseDown
        addmovieduration(movieduration, dtpf7, dtpt7)
    End Sub

    Private Sub dtpt8_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles dtpt8.MouseDown
        addmovieduration(movieduration, dtpf8, dtpt8)
    End Sub

    Private Sub dtpt9_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles dtpt9.MouseDown
        addmovieduration(movieduration, dtpf9, dtpt9)
    End Sub

    Private Sub dtpt10_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles dtpt10.MouseDown
        addmovieduration(movieduration, dtpf10, dtpt10)
    End Sub

    Private Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click
        defaultdtp()
        ClearTextFields(Me)
    End Sub

    Private Sub dtpSelectDate_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles dtpSelectDate.TextChanged
        defaultcbHall()
        hallverifying()
    End Sub
End Class
