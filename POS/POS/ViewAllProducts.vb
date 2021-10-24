Imports System.IO
Imports MySql.Data.MySqlClient

Public Class ViewAllProducts
    Dim connection As New MySqlConnection("datasource = localhost; port = 3306; username = root; password=; database = fast_food")

    Private Sub ViewAllProducts_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        refresh()
    End Sub

    Public Sub refresh()
        Dim cmd As New MySqlCommand("SELECT * FROM `products`", connection)
        Dim adapter As New MySqlDataAdapter(cmd)
        Dim table As New DataTable()
        adapter.Fill(table)

        DataGridView1.ReadOnly = True
        DataGridView1.AllowUserToAddRows = False
        DataGridView1.RowTemplate.Height = 50
        Dim imgc As New DataGridViewImageColumn
        DataGridView1.DataSource = table
        imgc = DataGridView1.Columns(6)
        imgc.ImageLayout = DataGridViewImageCellLayout.Stretch

        txtID.Text = ""
        txt_ProductName.Text = ""
        txt_PriceSmall.Text = ""
        txt_PriceMedium.Text = ""
        txt_PriceLarge.Text = ""
        ProductPicture.Image = Nothing
    End Sub

    Private Sub DataGridView1_Click(sender As Object, e As EventArgs) Handles DataGridView1.Click
        txtID.Text = DataGridView1.CurrentRow.Cells(1).Value.ToString
        txt_ProductName.Text = DataGridView1.CurrentRow.Cells(2).Value.ToString
        txt_PriceSmall.Text = DataGridView1.CurrentRow.Cells(3).Value.ToString
        txt_PriceMedium.Text = DataGridView1.CurrentRow.Cells(4).Value
        txt_PriceLarge.Text = DataGridView1.CurrentRow.Cells(5).Value.ToString

        Dim pic As Byte()
        pic = DataGridView1.CurrentRow.Cells(6).Value
        Dim picture As New MemoryStream(pic)
        ProductPicture.Image = Image.FromStream(picture)

    End Sub

    Private Sub btn_Del_Click(sender As Object, e As EventArgs) Handles btn_Del.Click
        Dim delete As String = "DELETE FROM `products` WHERE `Product_ID`=" & txtID.Text
        Dim cmd As New MySqlCommand(delete, connection)
        connection.Open()
        If cmd.ExecuteNonQuery = 1 Then
            MsgBox("Deleted!!")
            refresh()
            AddProducts.refesh()
        End If
        connection.Close()
    End Sub

    Private Sub btn_Update_Click(sender As Object, e As EventArgs) Handles btn_Update.Click
        Dim ms As New MemoryStream
        ProductPicture.Image.Save(ms, ProductPicture.Image.RawFormat)
        Dim img() As Byte
        img = ms.ToArray()
        Dim insertQuery As String = "UPDATE `products` SET `Name`='" & txt_ProductName.Text & "',`Small_size`='" & txt_PriceSmall.Text & "',`Medium_size`='" & txt_PriceMedium.Text & "',`Large_size`='" & txt_PriceLarge.Text & "',`Product_Image`=@img WHERE `Product_ID`=" & txtID.Text
        Dim cmd As New MySqlCommand(insertQuery, connection)
        cmd.Parameters.Add("@img", MySqlDbType.LongBlob).Value = img

        connection.Open()
        If cmd.ExecuteNonQuery = 1 Then
            MsgBox("Updated!!")
            refresh()
            AddProducts.refesh()
        End If
        connection.Close()
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        valuetosearch(TextBox1.Text)
    End Sub
    Public Sub valuetosearch(text As String)

        Dim cmd As New MySqlCommand("SELECT * FROM `products` WHERE CONCAT (`Product_ID`,`Name`) LIKE '%" & text & "%'", connection)
        Dim adapter As New MySqlDataAdapter(cmd)
        Dim table As New DataTable()
        adapter.Fill(table)


        DataGridView1.AllowUserToAddRows = False
        DataGridView1.RowTemplate.Height = 50
        Dim imgc As New DataGridViewImageColumn
        DataGridView1.DataSource = table
        imgc = DataGridView1.Columns(6)
        imgc.ImageLayout = DataGridViewImageCellLayout.Stretch
    End Sub
End Class