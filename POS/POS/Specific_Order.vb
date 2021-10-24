Public Class Specific_Order
    Private Sub btn_order_Click(sender As Object, e As EventArgs) Handles btn_order.Click
        Dim array_item(7) As String
        With Sale
            array_item(0) = .listview_sale.Items.Count + 1
            array_item(1) = lbl_menu_id.Text
            array_item(2) = lbl_menu_name.Text

            Dim size As String
            If rdb_small.Checked Then
                size = rdb_small.Text
            ElseIf rdb_medium.Checked Then
                size = rdb_medium.Text
            Else
                size = rdb_large.Text
            End If
            array_item(3) = size

            array_item(4) = txt_amount.Text

            Dim price As Integer
            If rdb_small.Checked Then
                price = lbl_small.Text
            ElseIf rdb_medium.Checked Then
                price = lbl_medium.Text
            Else
                price = lbl_large.Text
            End If
            array_item(5) = price

            array_item(6) = array_item(4) * array_item(5)
        End With


        Dim itm As New ListViewItem(array_item)
        Sale.listview_sale.Items.Add(itm)

        txt_amount.Text = ""
        Me.Hide()

    End Sub

    Private Sub Specific_Order_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub rdb_small_CheckedChanged(sender As Object, e As EventArgs) Handles rdb_small.CheckedChanged
        txt_amount.Select()
    End Sub

    Private Sub rdb_medium_CheckedChanged(sender As Object, e As EventArgs) Handles rdb_medium.CheckedChanged
        txt_amount.Select()
    End Sub

    Private Sub rdb_large_CheckedChanged(sender As Object, e As EventArgs) Handles rdb_large.CheckedChanged
        txt_amount.Select()
    End Sub
End Class