Imports MySql.Data.MySqlClient

Module conectar
    Public Function GetConnection() As MySqlConnection
        Dim connectionString As String = "server=localhost;port=3308;user=root;password=;database=fncc"
        Return New MySqlConnection(connectionString)
    End Function

    Public Sub ExecuteNonQuery(query As String)
        Using connection As MySqlConnection = GetConnection()
            Try
                connection.Open()
                Dim command As New MySqlCommand(query, connection)
                command.ExecuteNonQuery()
            Catch ex As Exception
                MessageBox.Show("Error de conexión: " & ex.Message)
            End Try
        End Using
    End Sub

    Public Function ExecuteQuery(query As String) As DataTable
        Dim dataTable As New DataTable()
        Using connection As MySqlConnection = GetConnection()
            Try
                connection.Open()
                Dim adapter As New MySqlDataAdapter(query, connection)
                adapter.Fill(dataTable)
            Catch ex As Exception
                MessageBox.Show("Error de conexión: " & ex.Message)
            End Try
        End Using
        Return dataTable
    End Function

End Module

