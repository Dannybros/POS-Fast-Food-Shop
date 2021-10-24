Imports MySql.Data.MySqlClient
Imports System.IO

Public Class AddProducts

    Dim connection As New MySqlConnection("datasource = localhost; port = 3306; username = root; password=; database =fast_food")

    Public Sub refesh()
        Dim cmd As New MySqlCommand("SELECT `Product_ID`, `Name`,  `Product_Image` FROM `products`", connection)
        Dim adapter As New MySqlDataAdapter(cmd)
        Dim table As New DataTable()
        adapter.Fill(table)

        DataGridView1.ReadOnly = True
        DataGridView1.AllowUserToAddRows = False
        DataGridView1.RowTemplate.Height = 80
        Dim imgc As New DataGridViewImageColumn
        DataGridView1.DataSource = table
        imgc = DataGridView1.Columns(2)
        imgc.ImageLayout = DataGridViewImageCellLayout.Stretch

        txtID.Text = ""
        txt_ProductName.Text = ""
        txt_PriceSmall.Text = ""
        txt_PriceMedium.Text = ""
        txt_PriceLarge.Text = ""
        ProductPicture.Image = Nothing

        LabelTotal.Text = "Total: " & DataGridView1.Rows.Count
    End Sub

    Private Sub btn_Save_Click(sender As Object, e As EventArgs) Handles btn_Save.Click

        If txtID.Text.Trim() = "" Or txt_ProductName.Text.Trim() = "" Or txt_PriceSmall.Text.Trim() = "" Or txt_PriceMedium.Text.Trim() = "" Or
            txt_PriceLarge.Text.Trim() = "" Or ProductPicture.Image Is Nothing Then
            MsgBox("One or more fields are missing!!")
            Return
        End If
        If IsNumeric(txt_PriceSmall) Or IsNumeric(txt_PriceMedium) Or IsNumeric(txt_PriceLarge) Then
            MsgBox("Please insert Number in Price text!!!")
        Else
            Dim cmd As New MySqlCommand("INSERT INTO `products`(`Product_ID`, `Name`, `Small_size`, `Medium_size`, `Large_size`, `Product_Image`) VALUES (@id, @Name, @Small, @Medium, @Large, @image)", connection)

            cmd.Parameters.Add("@id", MySqlDbType.Int32).Value = txtID.Text
            cmd.Parameters.Add("@Name", MySqlDbType.VarChar).Value = txt_ProductName.Text
            cmd.Parameters.Add("@Small", MySqlDbType.Float).Value = txt_PriceSmall.Text
            cmd.Parameters.Add("@Medium", MySqlDbType.Float).Value = txt_PriceMedium.Text
            cmd.Parameters.AddWithValue("@Large", MySqlDbType.Float).Value = txt_PriceLarge.Text

            Dim ms As New MemoryStream
            ProductPicture.Image.Save(ms, ProductPicture.Image.RawFormat)
            Dim image As Byte()
            image = ms.ToArray()

            cmd.Parameters.Add("@image", MySqlDbType.LongBlob).Value = image

            connection.Open()
            If (cmd.ExecuteNonQuery = 0) Then
                MsgBox("Failed")
            Else
                MsgBox("saved")
                refesh()
                Sale.refresh_food()
            End If
            connection.Close()
        End If
    End Sub

    Private Sub btn_upload_Click(sender As Object, e As EventArgs) Handles btn_upload.Click
        Dim opf As New OpenFileDialog()
        opf.Filter = "Select image(*.jpg; *.png; *.gif)|*.jpg; *.png; *.gif"

        If opf.ShowDialog = DialogResult.OK Then
            ProductPicture.Image = Image.FromFile(opf.FileName)
        End If

    End Sub

    Private Sub AddProducts_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        refesh()
    End Sub


    Private Sub Label5_Click(sender As Object, e As EventArgs) 
        Sale.Show()
    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        valuetosearch(txtSearch.Text)
    End Sub
    Public Sub valuetosearch(text As String)

        Dim cmd As New MySqlCommand("SELECT * FROM `products` WHERE CONCAT (`Product_ID`,`Name`) LIKE '%" & text & "%'", connection)
        Dim adapter As New MySqlDataAdapter(cmd)
        Dim table As New DataTable()
        adapter.Fill(table)


        DataGridView1.AllowUserToAddRows = False
        DataGridView1.RowTemplate.Height = 50

        DataGridView1.DataSource = table

    End Sub

    Private Sub DataGridView1_DoubleClick(sender As Object, e As EventArgs) Handles DataGridView1.DoubleClick
        Dim view As New ViewAllProducts
        view.Show()
    End Sub


End Class