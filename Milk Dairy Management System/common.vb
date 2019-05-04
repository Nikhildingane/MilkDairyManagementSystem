Imports System.Data.SqlClient
Module common
    Public con As New SqlConnection("Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=mdmsDB;Integrated Security=True;Pooling=False")
    Public cmd As New SqlCommand
    Public dr As SqlDataReader
    Public da As SqlDataAdapter
    Public dt As DataTable
    Public ds As New DataSet
    Public user_id As String = ""

    Public Sub con_open()
        If con.State = ConnectionState.Closed Then
            con.Open()
        End If
    End Sub

    Public Sub con_close()
        If con.State = ConnectionState.Open Then
            con.Close()
        End If
    End Sub

    Public Function Query_Inser_Update_Delete(ByVal s As String)
        cmd.CommandText = s
        cmd.Connection = con
        con_close()
        con_open()
        If cmd.ExecuteNonQuery > 0 Then
            Return True
        Else
            Return False
        End If
    End Function

    Public Function Query_Select(ByVal s As String)
        cmd.CommandText = s
        cmd.Connection = con
        con_close()
        con_open()
        dr = cmd.ExecuteReader
    End Function
    Public Function Query_ExecuteScalar(ByVal s As String)
        cmd.CommandText = s
        cmd.Connection = con
        con_close()
        con_open()
        Return cmd.ExecuteScalar
    End Function
    Public Function Query_FillDG(ByVal s As String)
        con_close()
        con_open()
        da = New SqlDataAdapter(s, con)
        dt = New DataTable
        da.Fill(dt)
    End Function

End Module
