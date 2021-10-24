Imports System.IO
Imports MySql.Data.MySqlClient

Public Class EMPLOYEE
    Dim db As New My_Connection()

    Public Function insertStudent(ByVal fname As String, ByVal lname As String, ByVal bdate As Date, ByVal phone As String, ByVal address As String, ByVal email As String, ByVal image As MemoryStream) As Boolean

        Dim connection As New MySqlConnection("datasource = localhost; port = 3306; username = root; password=; database = fast_food")

        Dim command As New MySqlCommand("INSERT INTO `employee_tbl`(`first_name`, `last_name`, `birthdate`, `address`, `phone`, `email`, `image`) VALUES (@fn, @ln, @bdt, @address, @phone, @email, @image)", connection)
        '@fn, @ln, @bdt, @address, @phone, @email, @image
        command.Parameters.Add("@fn", MySqlDbType.VarChar).Value = fname
        command.Parameters.Add("@ln", MySqlDbType.VarChar).Value = lname
        command.Parameters.Add("@bdt", MySqlDbType.DateTime).Value = bdate
        command.Parameters.Add("@address", MySqlDbType.VarChar).Value = address
        command.Parameters.Add("@phone", MySqlDbType.VarChar).Value = phone
        command.Parameters.Add("@email", MySqlDbType.VarChar).Value = email
        command.Parameters.Add("@image", MySqlDbType.LongBlob).Value = image.ToArray()

        connection.Open()
        If command.ExecuteNonQuery() = 1 Then
            Return True
        Else
            Return False
        End If
        connection.Close()

    End Function

    Function getEmployee(ByVal command As MySqlCommand) As DataTable

        command.Connection = db.getConnection

        Dim table As New DataTable
        Dim adapter As New MySqlDataAdapter(command)

        adapter.Fill(table)
        Return table

    End Function

    Public Function delEmployee(ByVal id As Integer) As Boolean
        Dim command As New MySqlCommand("DELETE FROM `employee_tbl` WHERE `id`= @employeeID", db.getConnection)
        '@fn, @ln, @bdt, @address, @phone, @email, @image
        command.Parameters.Add("@employeeID", MySqlDbType.VarChar).Value = id

        command.Connection.Open()
        db.openConnection()
        If command.ExecuteNonQuery() = 1 Then
            Return True
        Else
            Return False
        End If
    End Function

    Public Function updateEmployee(ByVal id As Integer, ByVal fname As String, ByVal lname As String, ByVal bdate As Date, ByVal phone As String, ByVal address As String, ByVal email As String, ByVal image As MemoryStream) As Boolean

        Dim command As New MySqlCommand("UPDATE `employee_tbl` SET `first_name`=@fn,`last_name`=@ln,`birthdate`= @bdt,`address`=@address,`phone`=@phone,`email`=@email,`image`=@image WHERE id = @ID", db.getConnection)
        '@fn, @ln, @bdt, @address, @phone, @email, @image
        command.Parameters.Add("@ID", MySqlDbType.Int32).Value = id
        command.Parameters.Add("@fn", MySqlDbType.VarChar).Value = fname
        command.Parameters.Add("@ln", MySqlDbType.VarChar).Value = lname
        command.Parameters.Add("@bdt", MySqlDbType.DateTime).Value = bdate
        command.Parameters.Add("@address", MySqlDbType.VarChar).Value = address
        command.Parameters.Add("@phone", MySqlDbType.VarChar).Value = phone
        command.Parameters.Add("@email", MySqlDbType.VarChar).Value = email
        command.Parameters.Add("@image", MySqlDbType.LongBlob).Value = image.ToArray()

        command.Connection.Open()
        db.openConnection()
        If command.ExecuteNonQuery() = 1 Then
            Return True
        Else
            Return False
        End If

    End Function


End Class
