Imports MySql.Data.MySqlClient

Public Class Registration
    Private Sub Label9_Click(sender As Object, e As EventArgs) Handles Label9.Click
        Me.Show()
        LoginForm.Show()
    End Sub

    Private Sub txtFirstName_Enter(sender As Object, e As EventArgs) Handles txtFirstName.Enter
        LabelFN.ForeColor = Color.White
    End Sub

    Private Sub txtFirstName_Leave(sender As Object, e As EventArgs) Handles txtFirstName.Leave
        LabelFN.ForeColor = Color.Black
    End Sub

    Private Sub txtLastName_Enter(sender As Object, e As EventArgs) Handles txtLastName.Enter
        LabelLN.ForeColor = Color.White
    End Sub

    Private Sub txtLastName_Leave(sender As Object, e As EventArgs) Handles txtLastName.Leave
        LabelLN.ForeColor = Color.Black
    End Sub

    Private Sub txtUsername_Enter(sender As Object, e As EventArgs) Handles txtUsername.Enter
        LabelUsername.ForeColor = Color.White
    End Sub

    Private Sub txtUsername_Leave(sender As Object, e As EventArgs) Handles txtUsername.Leave
        LabelUsername.ForeColor = Color.Black
    End Sub

    Private Sub txtEmail_Enter(sender As Object, e As EventArgs) Handles txtEmail.Enter
        LabelEmail.ForeColor = Color.White
    End Sub

    Private Sub txtEmail_Leave(sender As Object, e As EventArgs) Handles txtEmail.Leave
        LabelEmail.ForeColor = Color.Black
    End Sub

    Private Sub txtPass_Enter(sender As Object, e As EventArgs) Handles txtPass.Enter
        LabelPass.ForeColor = Color.White
    End Sub

    Private Sub txtPass_Leave(sender As Object, e As EventArgs) Handles txtPass.Leave
        LabelPass.ForeColor = Color.Black
    End Sub

    Private Sub txtPass2_Enter(sender As Object, e As EventArgs) Handles txtPass2.Enter
        LabelPass2.ForeColor = Color.White
    End Sub

    Private Sub txtPass2_Leave(sender As Object, e As EventArgs) Handles txtPass2.Leave
        LabelPass2.ForeColor = Color.Black
    End Sub

    Private Sub txtPhone_Enter(sender As Object, e As EventArgs) Handles txtPhone.Enter
        LablePhone.ForeColor = Color.White
    End Sub

    Private Sub txtPhone_Leave(sender As Object, e As EventArgs) Handles txtPhone.Leave
        LablePhone.ForeColor = Color.Black
    End Sub

    Public Function usernameExist(ByVal username As String) As Boolean
        Dim con As New My_Connection()
        Dim table As New DataTable()
        Dim adapter As New MySqlDataAdapter()
        Dim command As New MySqlCommand("SELECT * FROM `users_tbl` WHERE 'username' = @usn", con.getConnection())
        command.Parameters.Add("@usn", MySqlDbType.VarChar).Value = username

        adapter.SelectCommand = command
        adapter.Fill(table)

        If table.Rows.Count > 0 Then
            Return True
        Else
            Return False
        End If

    End Function

    Private Sub ButtonRegister_Click(sender As Object, e As EventArgs) Handles ButtonRegister.Click
        Dim fname As String = txtFirstName.Text
        Dim lname As String = txtLastName.Text
        Dim mail As String = txtEmail.Text
        Dim phone As String = txtPhone.Text
        Dim username As String = txtUsername.Text
        Dim password As String = txtPass.Text
        Dim cpassword As String = txtPass2.Text

        If fname.Trim() = "" Or lname.Trim() = "" Or mail.Trim() = "" Or phone.Trim() = "" Or username.Trim() = "" Or password.Trim() = "" Or cpassword.Trim() = "" Then
            MessageBox.Show("one or more fields is empty", "Empty fields", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

        ElseIf Not String.Equals(password, cpassword) Then
            MessageBox.Show("confirm password is incorrect", "password error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

        ElseIf usernameExist(username) Then

            MsgBox("this username is already taken")

        Else

            Dim conn As New My_Connection()
            Dim command As New MySqlCommand("INSERT INTO `users_tbl`(`first_name`, `last_name`, `email`, `phone`, `username`, `password`) VALUES (@fn, @ln, @mail, @phone, @usn, @pass)", conn.getConnection())

            command.Parameters.Add("@fn", MySqlDbType.VarChar).Value = fname
            command.Parameters.Add("@ln", MySqlDbType.VarChar).Value = lname
            command.Parameters.Add("@mail", MySqlDbType.VarChar).Value = mail
            command.Parameters.Add("@phone", MySqlDbType.VarChar).Value = phone
            command.Parameters.Add("@usn", MySqlDbType.VarChar).Value = username
            command.Parameters.Add("@pass", MySqlDbType.VarChar).Value = password

            command.Connection.Open()
            conn.openConnection()
            If command.ExecuteNonQuery() = 1 Then

                MsgBox("Sign up successfully")
                conn.closeConnection()
                Me.Hide()
                LoginForm.Show()

            Else
                MsgBox("sign up failed")
                conn.closeConnection()

            End If
        End If

    End Sub
    Private Sub NumberOnly(sender As Object, e As KeyPressEventArgs) Handles txtPhone.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub Label9_MouseEnter(sender As Object, e As EventArgs) Handles Label9.MouseEnter
        Label9.ForeColor = Color.Yellow
    End Sub

    Private Sub Label9_MouseLeave(sender As Object, e As EventArgs) Handles Label9.MouseLeave
        Label9.ForeColor = Color.White
    End Sub

    Private Sub Registeration_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class