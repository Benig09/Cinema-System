Imports System.Data.OleDb

Module Module1

    Public acsconn As New OleDbConnection
    Public acsdr As OleDbDataReader
    Public acsda As New OleDbDataAdapter
    Public strsql As String
    Public seatremain As Integer
    Public schedid As Integer
    Public seatselectednum As Integer
    Public maxseatnumber As Integer = 24
    Public seatpicked(maxseatnumber) As String

    Sub connect()
        acsconn.ConnectionString = "provider=microsoft.ace.oledb.12.0; Data Source=" & Application.StartupPath & "\Database4.accdb; persist security info = false;"
        acsconn.ConnectionString = "provider=microsoft.ace.oledb.12.0; data source =C:\Users\benig\Desktop\vb assignment\moviemanagement\moviemanagement\bin\Debug\Database4.accdb; persist security info = false;"
        acsconn.Open()
        If acsconn.State = ConnectionState.Open Then
            MsgBox("Connected")
        End If
    End Sub
End Module
