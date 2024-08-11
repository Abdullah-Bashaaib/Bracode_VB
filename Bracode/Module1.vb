Imports System.Data.SqlClient

Module Module1
    Public con As New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Projects\Bracode\Bracode\Database1.mdf;Integrated Security=True")
    Public dt_item As New DataTable

    Public Sub load_item()
        Try
            dt_item.Clear()
            Dim com As New SqlCommand("SELECT * FROM Item", con)
            con.Open()
            dt_item.Load(com.ExecuteReader)
            con.Close()

        Catch ex As Exception
            con.Close()

        End Try
    End Sub
End Module
