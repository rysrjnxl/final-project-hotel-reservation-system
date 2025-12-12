Imports MySql.Data.MySqlClient

Module DatabaseModule
    Public connString As String = "Server=localhost;Database=hotel_db;Uid=root;Pwd=admin1234;"
    Public conn As New MySqlConnection(connString)

    Public Function TestConnection() As Boolean
        Try
            If conn.State = ConnectionState.Closed Then conn.Open()
            Return True
        Catch ex As Exception
            MsgBox("Database Error: " & ex.Message)
            Return False
        End Try
    End Function

    Public Sub ExecuteQuery(query As String)
        Try
            If conn.State = ConnectionState.Closed Then conn.Open()
            Dim cmd As New MySqlCommand(query, conn)
            cmd.ExecuteNonQuery()
            conn.Close()
        Catch ex As Exception
            MsgBox("Error: " & ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub

    Public Function GetData(query As String) As DataTable
        Dim dt As New DataTable
        Try
            If conn.State = ConnectionState.Closed Then conn.Open()
            Dim da As New MySqlDataAdapter(query, conn)
            da.Fill(dt)
            conn.Close()
            Return dt
        Catch ex As Exception
            MsgBox("Error loading data: " & ex.Message)
            Return Nothing
        Finally
            conn.Close()
        End Try
    End Function
End Module