Imports MySql.Data.MySqlClient

Public Class Form1

    Dim connection As New MySqlConnection("datasource = localhost; port = 3306; username = root; password=; database = test4")

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        refresh_food()
    End Sub

    Public Sub refresh_food()

        Dim cmd As New MySqlCommand("Select `Product_ID`, `Name`, `Product_Image` FROM `products`", connection)
        Dim adapter As New MySqlDataAdapter(cmd)
        Dim table As New DataTable
        adapter.Fill(table)

        Load_Sale_item(ImageList1, ListView_menu, table, My.Resources.original, "Product_Image", "Product_ID", "Name")
    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click
        AddProducts.Show()
    End Sub

    Private Sub txt_search_TextChanged(sender As Object, e As EventArgs) Handles txt_search.TextChanged

    End Sub

    Private Sub txt_search_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_search.KeyDown
        If e.KeyData = Keys.Enter Then
            Dim cmd As New MySqlCommand("SELECT `Product_ID`, `Name`, `Product_Image` FROM `products` WHERE CONCAT (`Product_ID`, `Name`) LIKE '%" & txt_search.Text & "%'")
            Dim adapter As New MySqlDataAdapter(cmd)
            Dim table As New DataTable
            adapter.Fill(table)

            Load_Sale_item(ImageList1, ListView_menu, table, My.Resources.original, "Product_Image", "Product_ID", "Name")
        End If
    End Sub

    Private Sub ListView_menu_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListView_menu.SelectedIndexChanged
        Dim select_menu As String = ListView_menu.FocusedItem.Text
        Dim menu_split() As String = select_menu.Split(":")
        menu_split(0) = menu_split(0).ToString.Trim

        Dim cmd As New MySqlCommand("SELECT * FROM `products` WHERE `Product_ID` = '" & menu_split(0) & "'", connection)
        Dim adapter As New MySqlDataAdapter(cmd)
        Dim table As New DataTable
        adapter.Fill(table)

        Dim small, medium, large As Integer
        small = table.Rows(0)("Small_size")
        medium = table.Rows(0)("Medium_size")
        large = table.Rows(0)("Large_size")

        Dim menu_id, menu_name As String
        menu_id = table.Rows(0)("Product_ID")
        menu_name = table.Rows(0)("Name")

        With Specific_Order

            .lbl_small.Text = small
            .lbl_medium.Text = medium
            .lbl_large.Text = large
            .lbl_menu_id.Text = menu_id
            .lbl_menu_name.Text = menu_name
        End With

        Specific_Order.Show()
        Specific_Order.TopMost = True

    End Sub

    Private Sub btn_sum_Click(sender As Object, e As EventArgs) Handles btn_sum.Click
        txt_sum.Text = "$" + Sum_Column_Currency(listview_sale, 6)
    End Sub

    Private Sub btn_Del_All_Click(sender As Object, e As EventArgs) Handles btn_Del_All.Click
        Dim iclear As DialogResult
        iclear = MessageBox.Show("Do you wish to clear every orders?", "Information", MessageBoxButtons.YesNo)

        If iclear = DialogResult.Yes Then
            listview_sale.Items.Clear()
            txt_sum.Text = ""
            txt_search.Text = ""
        End If

    End Sub

    Private Sub btn_delete_select_Click(sender As Object, e As EventArgs) Handles btn_delete_select.Click
        Dim iclear As DialogResult
        iclear = MessageBox.Show("Do you wish to clear current order?", "Information", MessageBoxButtons.YesNo)

        If iclear = DialogResult.Yes Then
            listview_sale.Items.Remove(listview_sale.FocusedItem)
            txt_sum.Text = ""
            txt_search.Text = ""
        End If
    End Sub
End Class
