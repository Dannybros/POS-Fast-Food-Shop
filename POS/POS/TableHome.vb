Imports MySql.Data.MySqlClient

Public Class TableHome
    Dim connection As New MySqlConnection("datasource = localhost; port = 3306; username = root; password=; database = fast_food")

    Public Sub refresh()
        Dim cmd As New MySqlCommand("SELECT `table_name`, `image` FROM `restaurant_tbl`", connection)
        Dim adapter As New MySqlDataAdapter(cmd)
        Dim table As New DataTable()
        adapter.Fill(table)

        Load_table(ImageListTable, ListView_menu, table, My.Resources.table, "image", "table_name", "ready")
    End Sub


    Private Sub TableHome_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        refresh()
    End Sub

    Private Sub ListView_table_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub ListView_menu_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListView_menu.SelectedIndexChanged

        Me.Hide()

        HomeForm.switchPanel(Sale)
        Sale.TopMost = True

    End Sub

End Class