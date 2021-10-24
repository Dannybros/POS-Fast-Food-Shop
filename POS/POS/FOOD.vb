Imports MySql.Data.MySqlClient

Public Class FOOD
    Dim connection As New MySqlConnection("datasource = localhost; port = 3306; username = root; password=; database = fast_food")

    Public Function delProducts(ByVal id As Integer) As Boolean
        Dim command As New MySqlCommand("DELETE FROM `products` WHERE `id`= @employeeID", connection)
        '@fn, @ln, @bdt, @address, @phone, @email, @image
        command.Parameters.Add("@employeeID", MySqlDbType.VarChar).Value = id

        connection.Open()

        If command.ExecuteNonQuery() = 1 Then
            Return True
        Else
            Return False
        End If
    End Function
End Class
