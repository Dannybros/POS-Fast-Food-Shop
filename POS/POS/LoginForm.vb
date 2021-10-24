Imports MySql.Data.MySqlClient

Public Class LoginForm
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim conn As New My_Connection()
        Dim adapter As New MySqlDataAdapter()
        Dim table As New DataTable()
        Dim command As New MySqlCommand("SELECT `username`, `password` FROM `users_tbl` WHERE `username` = @usn AND`password` = @pass", conn.getConnection())

        command.Parameters.Add("@usn", MySqlDbType.VarChar).Value = txtUsername.Text
        command.Parameters.Add("@pass", MySqlDbType.VarChar).Value = txtPassword.Text
        adapter.SelectCommand = command
        adapter.Fill(table)

        If table.Rows.Count > 0 Then
            Dim ipass As DialogResult
            ipass = MessageBox.Show("Do you really wish to see top secret file ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If ipass = DialogResult.Yes Then
                Me.Hide()
                HomeForm.Show()
            Else
                MessageBox.Show("You still has to enter")
                Me.Hide()
                HomeForm.Show()
            End If
        Else
            MsgBox("Log in failed")
        End If

    End Sub


    Private Sub Label4_MouseEnter(sender As Object, e As EventArgs) Handles Label4.MouseEnter
        Label4.ForeColor = Color.White
    End Sub

    Private Sub Label4_MouseLeave(sender As Object, e As EventArgs) Handles Label4.MouseLeave
        Label4.ForeColor = Color.Yellow
    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click
        Me.Hide()
        Registration.Show()

    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        txtPassword.PasswordChar = ""
        If CheckBox1.Checked = False Then
            txtPassword.PasswordChar = "*"
        End If
    End Sub
End Class
