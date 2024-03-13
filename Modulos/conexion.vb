Imports MySql.Data.MySqlClient
Module Conexion
    Public Function GenerarConnectionString() As String

        Dim server As String = "localhost"
        Dim database As String = "fncc"
        Dim user As String = "root"
        Dim password As String = ""

        Dim connectionString As String = $"Server={server};Database={database};Uid={user};"


        Using connection As New MySqlConnection(connectionString)
            Try
                connection.Open()
                MsgBox("Conexión exitosa")
            Catch ex As Exception
                MsgBox("Error al conectar: " & ex.Message)
            End Try
        End Using
    End Function
End Module
