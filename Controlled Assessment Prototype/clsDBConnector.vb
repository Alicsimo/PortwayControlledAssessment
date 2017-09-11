Imports System.Data.OleDb
Public Class ClsDBConnector
    Dim con As New OleDbConnection
    Dim dbProvider As String
    Dim dbSource As String
    Dim da As OleDb.OleDbDataAdapter
    Dim ds As New DataSet
    Sub connect(x)
        If My.Computer.FileSystem.FileExists(x) Then
            dbProvider = "PROVIDER=Microsoft.ACE.OLEDB.12.0;"
            dbSource = "Data Source = " & x
            con.ConnectionString = dbProvider & dbSource
            Console.WriteLine ("Connected to local database.")
        Else
            con.ConnectionString = "Provider=SQLOLEDB; " &
                              "Server=tcp:portway-db.database.windows.net,1433; " &
                              "Database=portway-db; " &
                              "Uid=alexh@portway-db; " &
                              "Pwd=Warhammer40k;"
            Console.WriteLine("Connected to remote database.")
        End If
        con.Open()
    End Sub
    Sub close()
        con.Close()
        'closes connection to database and states so to the user
    End Sub
    Function sqlSelect(ByVal sqlString As String)
        da = New OleDbDataAdapter(sqlString, con)
        'create a new data-adapter object & tell it to use the SQL statement and connection info provided.

        ds.Clear() 'wipes the data-set clean

        da.Fill(ds, "Results")
        'executes the SQL query and fills the dataset "Results" with the data

        Return ds 'sends the data back to the calling code
    End Function
End Class
