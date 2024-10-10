Imports MySql.Data.MySqlClient
Module Module1
    Dim conn As New MySqlConnection
    Public Sub DbConnect()


        Dim dbname As String = "dbit2a"
        Dim username As String = "root"
        Dim password As String = "admin" 'mysql server password'
        Dim server As String = "127.0.0.1" 'pc ip address'
        'check if connection id is open'
        If Not conn Is Nothing Then
            conn.Close()
            'establish new connection'
            conn.ConnectionString = "server =" & server & ";user id =" & username & ";password =" & password & ";database =" & dbname & ""
            Try
                conn.Open() 'open connection
                MsgBox("connected")
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
    End Sub
End Module
