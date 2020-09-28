Public Class price1
    Dim tempid As Integer
    Sub generateid()
        strsql = "select Top 1 PriceID from Price order by PriceID desc"

        Dim acscmd As New OleDb.OleDbCommand
        acscmd.CommandText = strsql
        acscmd.Connection = acsconn
        acsda.SelectCommand = acscmd
        acsdr = acscmd.ExecuteReader


        If (acsdr.Read()) Then
            tempid = acsdr("PriceID") + 1
        End If

        acscmd.Dispose()
        acsdr.Close()

        txtid.Text = tempid
    End Sub
    Sub addprice()
        strsql = "insert into Price (Status, Price) values ('" _
        & txtstatus.Text & "', " _
        & txtprice.Text & ")"

        Dim acscmd As New OleDb.OleDbCommand
        acscmd.CommandText = strsql
        acscmd.Connection = acsconn
        acscmd.ExecuteNonQuery()
        acscmd.Dispose()

        MsgBox("saved")

        Me.filllistview()
        txtstatus.Text = ""
        txtprice.Text = ""
        generateid()
    End Sub
    Sub updateprice()
        strsql = "update Price set Status ='" & txtstatus.Text & "'," _
        & "Price = " & txtprice.Text _
        & " where PriceID = " & txtid.Text

        Dim acscmd As New OleDb.OleDbCommand
        acscmd.CommandText = strsql
        acscmd.Connection = acsconn
        acscmd.ExecuteNonQuery()
        acscmd.Dispose()

        MsgBox("updated")

        'Me.filllistview()
        'generateid()
        'txtstatus.Text = ""
        'txtprice.Text = ""
    End Sub
    Sub deleteprice()
        strsql = "delete * from Price where PriceID = " & txtid.Text

        Dim acscmd As New OleDb.OleDbCommand
        acscmd.CommandText = strsql
        acscmd.Connection = acsconn
        acscmd.ExecuteNonQuery()
        acscmd.Dispose()

        MsgBox("deleted")
        Me.filllistview()

        txtid.Text = ""
        txtstatus.Text = ""
        txtprice.Text = ""

    End Sub
    Sub filllistview()
        strsql = "select * from Price"
        Dim acscmd As New OleDb.OleDbCommand
        acscmd.CommandText = strsql
        acscmd.Connection = acsconn
        acsda.SelectCommand = acscmd
        acsdr = acscmd.ExecuteReader

        lvPriceList.Items.Clear()

        While (acsdr.Read())
            With lvPriceList.Items.Add(acsdr("PriceID"))
                .subitems.add(acsdr("Status"))
                .subitems.add(acsdr("Price"))
            End With
        End While

        acscmd.Dispose()
        acsdr.Close()
    End Sub

    Private Sub Form2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        generateid()
        filllistview()
        btnUpdate.Enabled = False
        btnDelete.Enabled = False
    End Sub

    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        addprice()
    End Sub

    Private Sub btnUpdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUpdate.Click
        updateprice()
        btnUpdate.Enabled = False
        btnAdd.Enabled = True
        filllistview()
        generateid()
        txtstatus.Text = ""
        txtprice.Text = ""
    End Sub

    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        deleteprice()
        btnDelete.Enabled = False
        btnAdd.Enabled = True
        generateid()
    End Sub

    Private Sub btnBack_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBack.Click
        Dim result As DialogResult
        result = MessageBox.Show("Do You Want to Back?", "Back", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)
        If result = Windows.Forms.DialogResult.OK Then
            ticket.Show()
            Me.Hide()
        End If
    End Sub

    Private Sub lvPriceList_MouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles lvPriceList.MouseDoubleClick
        With lvPriceList.SelectedItems(0)
            txtid.Text = .SubItems(0).Text
            txtstatus.Text = .SubItems(1).Text
            txtprice.Text = .SubItems(2).Text
        End With
        btnUpdate.Enabled = True
        btnAdd.Enabled = False
        btnDelete.Enabled = True
    End Sub
End Class