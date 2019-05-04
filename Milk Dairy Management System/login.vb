Public Class Login
    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Query_Select("select * from Users where UName like '" & Tb_Username.Text & "' and PWord like '" & Tb_Password.Text & "'")
        If dr.Read Then

            user_id = Tb_Username.Text
            Tb_Username.Clear()
            Tb_Password.Clear()
            MDIParent_Main.Show()
        Else
            MessageBox.Show("Username or Password Does Not Match")
        End If
    End Sub
End Class
