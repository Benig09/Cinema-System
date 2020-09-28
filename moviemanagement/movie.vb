Public Class movie
    Public tempid As Integer
    Sub generateid()

        strsql = "select Top 1 MovieID from Movie order by MovieID desc"

        Dim acscmd As New OleDb.OleDbCommand
        acscmd.CommandText = strsql
        acscmd.Connection = acsconn
        acsda.SelectCommand = acscmd
        acsdr = acscmd.ExecuteReader


        If (acsdr.Read()) Then
            tempid = acsdr("MovieID") + 1
        End If

        acscmd.Dispose()
        acsdr.Close()

        txtMovieID.Text = tempid

    End Sub

    Sub filllistview()
        strsql = "select * from Movie"
        Dim acscmd As New OleDb.OleDbCommand
        acscmd.CommandText = strsql
        acscmd.Connection = acsconn
        acsda.SelectCommand = acscmd
        acsdr = acscmd.ExecuteReader

        ListView1.Items.Clear()

        While (acsdr.Read())
            With ListView1.Items.Add(acsdr("MovieID"))
                .subitems.add(acsdr("MovieName"))
                .subitems.add(acsdr("MovieLength"))
                .subitems.add(acsdr("Genre"))
                .subitems.add(acsdr("Rating"))
                .subitems.add(acsdr("LaunchingDate"))
                .subitems.add(acsdr("Remark"))
                .subitems.add(acsdr("MoviePic"))
            End With
        End While

        acscmd.Dispose()
        acsdr.Close()
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

    Private Sub movie_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Module1.connect()
        txtMovieID.Enabled = False
        Me.generateid()
        Me.filllistview()
        btnUpdate.Enabled = False
        btnDelete.Enabled = False
    End Sub

    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        generateid()
        strsql = "INSERT INTO Movie ([MovieName], [MovieLength], [Genre], [Rating], [LaunchingDate],[Remark],[MoviePic]) values ('" _
       & txtMovieName.Text & "', '" _
       & dtpMovieLength.Text & "', '" _
       & cbGenre.Text & "', '" _
       & cbRating.Text & "', '" _
        & dtpLaunching.Text & "', '" _
        & txtRemark.Text & "', '" _
        & txtPic.Text & "')"

        Dim acscmd As New OleDb.OleDbCommand
        acscmd.CommandText = strsql
        acscmd.Connection = acsconn
        acscmd.ExecuteNonQuery()
        acscmd.Dispose()

        MsgBox("saved")

        Me.filllistview()
        ClearTextFields(Me)
        generateid()
        pbimage.Image = Nothing
    End Sub

    Private Sub ListView1_MouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles ListView1.MouseDoubleClick
        With ListView1.SelectedItems(0)
            txtMovieID.Text = .SubItems(0).Text
            txtMovieName.Text = .SubItems(1).Text
            dtpMovieLength.Text = .SubItems(2).Text
            cbGenre.Text = .SubItems(3).Text
            cbRating.Text = .SubItems(4).Text
            dtpLaunching.Text = .SubItems(5).Text
            txtRemark.Text = .SubItems(6).Text
            txtPic.Text = .SubItems(7).Text
        End With
        btnAdd.Enabled = False
        btnDelete.Enabled = True
        btnUpdate.Enabled = True
        pbimage.ImageLocation = txtPic.Text
    End Sub

    Private Sub btnUpdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUpdate.Click

        strsql = "update Movie set MovieName ='" & txtMovieName.Text & "'," _
       & "MovieLength ='" & dtpMovieLength.Text & "'," _
       & "Genre ='" & cbGenre.Text & "'," _
       & "Rating ='" & cbRating.Text & "'," _
       & "LaunchingDate ='" & dtpLaunching.Text & "'," _
       & "Remark ='" & txtRemark.Text & "'," _
       & "MoviePic ='" & txtPic.Text & "'" _
       & "where MovieID = " & txtMovieID.Text

        Dim acscmd As New OleDb.OleDbCommand
        acscmd.CommandText = strsql
        acscmd.Connection = acsconn
        acscmd.ExecuteNonQuery()
        acscmd.Dispose()

        MsgBox("updated")

        Me.filllistview()
        ClearTextFields(Me)
        generateid()
        btnAdd.Enabled = True
        btnDelete.Enabled = False
        btnUpdate.Enabled = False
        pbimage.Image = Nothing
    End Sub

    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        strsql = "delete * from Movie where MovieID = " & txtMovieID.Text

        Dim acscmd As New OleDb.OleDbCommand
        acscmd.CommandText = strsql
        acscmd.Connection = acsconn
        acscmd.ExecuteNonQuery()
        acscmd.Dispose()

        MsgBox("deleted")
        Me.filllistview()

        ClearTextFields(Me)
        generateid()
        btnAdd.Enabled = True
        btnDelete.Enabled = False
        btnUpdate.Enabled = False
        pbimage.Image = Nothing
    End Sub

    Private Sub btnBrowse_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBrowse.Click
        Dim myfile As New OpenFileDialog

        myfile.InitialDirectory = "C:\System Pictures"
        myfile.Filter = "All Files|*.*|Bitmaps|*.bmp|GIFs|*.gif|JPEGs|*.jpg|PNGs|*.png"
        myfile.FilterIndex = 1
        If myfile.ShowDialog() = DialogResult.OK Then
            If Dir(myfile.FileName) <> "" Then
                txtPic.Text = myfile.FileName
                pbimage.ImageLocation = myfile.FileName
            Else
                MsgBox("File Not Found", MsgBoxStyle.Critical)
            End If
        End If

    End Sub
    Private Sub btnBack_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBack.Click
        Dim result As DialogResult
        result = MessageBox.Show("Do You Want to Back?", "Back", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)
        If result = Windows.Forms.DialogResult.OK Then
            MainMenu1.Show()
            Me.Hide()
        End If
    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        Dim result As DialogResult
        result = MessageBox.Show("Do you want to exit?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If result = Windows.Forms.DialogResult.Yes Then
            Me.Close()
        End If
    End Sub

    Private Sub txtMovieID_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtMovieID.TextChanged

    End Sub
End Class