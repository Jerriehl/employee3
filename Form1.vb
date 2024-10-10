Imports MySql.Data.MySqlClient

Public Class Form1
    Dim sqlQuery As String
    Dim da As New MySqlDataAdapter
    Dim dt As DataTable
    Dim conn As New MySqlConnection
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DbConnect()
    End Sub

    Private Sub btnclose_Click(sender As Object, e As EventArgs) Handles btnclose.Click
        End
    End Sub

    Private Sub btnload_Click(sender As Object, e As EventArgs) Handles btnload.Click
        Try
            sqlQuery = "Select * from employee"
            da = New MySqlDataAdapter(sqlQuery, conn)
            dt = New DataTable
            'fill the data from mysql table
            da.Fill(dt)
            'set teh source of datagrid view

            datarecord.DataSource = dt

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
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
End Class
