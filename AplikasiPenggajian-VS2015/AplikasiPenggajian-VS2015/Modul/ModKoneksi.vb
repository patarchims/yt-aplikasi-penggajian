﻿Imports MySql.Data.MySqlClient


Module ModKoneksi
    Public server As String
    Public dtData As New Data.DataTable
    Public conn As New MySqlConnection
    Public sqlcommand As New MySqlCommand
    Public sqlcommand1 As New MySqlCommand
    Public sqlcommand2 As New MySqlCommand
    Public sqladapter As New MySqlDataAdapter 'RD Sql adapter
    Public Konfirmasi As MsgBoxResult
    Public Dr As MySqlDataReader
    Public Dr1 As MySqlDataReader
    Public Cur As New Form
    Public sql, sql1 As String
    Public sqlDetail, sqldelete As String



    Public Sub cekkoneksi()
        'Dim myConn As MySqlConnection = New MySqlConnection("Server=(local)\netsdk;" &
        'uid=sa;pwd=;database=master")
        server = "SERVER= localhost ; USERID = root; PASSWORD =; DATABASE = db_penggajian; Convert Zero Datetime=True;"
        If conn.State = ConnectionState.Closed Then
            conn.ConnectionString = server
            conn.Open()
        End If
    End Sub
    Public Sub tutupkoneksi()
        With conn
            .Dispose()
            .Close()
        End With
    End Sub
End Module
