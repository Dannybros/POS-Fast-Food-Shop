Imports MySql.Data.MySqlClient

Public Class PaymentForm

    Dim connection As New MySqlConnection("datasource = localhost; port = 3306; username = root; password=; database = fast_food")

    Dim itotal As Decimal
    Dim ichange As Decimal
    Dim itemcost(12) As Decimal

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        For Each txt In {txtBiscuit, txtburrito, txtCash, txtChange, txtCola, txtCookie, txtFruit, txtHamburger, txtIcre_Cream, txtPho, txtPie, txtPizza, txtPudding, txtTaco,
        txtTotal, txtWater}
            txt.Enabled = False
            txt.Text = "0"
        Next

        For Each chb In {ChbApple_pie, ChbBiscuit, ChbBurrito, ChbCoca_Cola, ChbCookies, ChbFruit_Shake, ChbHamburger, ChbIce_Cream, ChbPho,
            ChbPizza, ChbPudding, ChbTaco, ChbTaco}
            chb.Checked = False

        Next

        ComboBox1.Text = ""
        rtfbill.Text = ""
        RichTextBox1.Text = ""
        RichTextBox2.Text = ""
    End Sub

    Private Sub NumberOnly(sender As Object, e As KeyPressEventArgs) Handles txtWater.KeyPress, txtTaco.KeyPress, txtPudding.KeyPress, txtPizza.KeyPress, txtPie.KeyPress, txtPho.KeyPress, txtIcre_Cream.KeyPress, txtHamburger.KeyPress, txtFruit.KeyPress, txtCookie.KeyPress, txtCola.KeyPress, txtburrito.KeyPress, txtBiscuit.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub ChbPho_CheckedChanged(sender As Object, e As EventArgs) Handles ChbPho.CheckedChanged
        txtPho.Enabled = True
        txtPho.Text = ""
        txtPho.Focus()
        If ChbPho.Checked = False Then
            txtPho.Enabled = False
            txtPho.Text = "0"
        End If
    End Sub

    Private Sub ChbBurrito_CheckedChanged(sender As Object, e As EventArgs) Handles ChbBurrito.CheckedChanged
        txtburrito.Enabled = True
        txtburrito.Text = ""
        txtburrito.Focus()
        If ChbBurrito.Checked = False Then
            txtburrito.Enabled = False
            txtburrito.Text = "0"
        End If
    End Sub

    Private Sub ChbHamburger_CheckedChanged(sender As Object, e As EventArgs) Handles ChbHamburger.CheckedChanged
        txtHamburger.Enabled = True
        txtHamburger.Text = ""
        txtHamburger.Focus()
        If ChbHamburger.Checked = False Then
            txtHamburger.Enabled = False
            txtHamburger.Text = "0"
        End If
    End Sub

    Private Sub ChbPizza_CheckedChanged(sender As Object, e As EventArgs) Handles ChbPizza.CheckedChanged
        txtPizza.Enabled = True
        txtPizza.Text = ""
        txtPizza.Focus()
        If ChbPizza.Checked = False Then
            txtPizza.Enabled = False
            txtPizza.Text = "0"
        End If
    End Sub

    Private Sub ChbWater_CheckedChanged(sender As Object, e As EventArgs) Handles ChbWater.CheckedChanged
        txtWater.Enabled = True
        txtWater.Text = ""
        txtWater.Focus()
        If ChbWater.Checked = False Then
            txtWater.Enabled = False
            txtWater.Text = "0"
        End If
    End Sub

    Private Sub ChbCoca_Cola_CheckedChanged(sender As Object, e As EventArgs) Handles ChbCoca_Cola.CheckedChanged
        txtCola.Enabled = True
        txtCola.Text = ""
        txtCola.Focus()
        If ChbCoca_Cola.Checked = False Then
            txtCola.Enabled = False
            txtCola.Text = "0"
        End If
    End Sub

    Private Sub ChbFruit_Shake_CheckedChanged(sender As Object, e As EventArgs) Handles ChbFruit_Shake.CheckedChanged
        txtFruit.Enabled = True
        txtFruit.Text = ""
        txtFruit.Focus()
        If ChbFruit_Shake.Checked = False Then
            txtFruit.Enabled = False
            txtFruit.Text = "0"
        End If
    End Sub

    Private Sub ChbApple_pie_CheckedChanged(sender As Object, e As EventArgs) Handles ChbApple_pie.CheckedChanged
        txtPie.Enabled = True
        txtPie.Text = ""
        txtPie.Focus()
        If ChbApple_pie.Checked = False Then
            txtPie.Enabled = False
            txtPie.Text = "0"
        End If
    End Sub

    Private Sub ChbCookies_CheckedChanged(sender As Object, e As EventArgs) Handles ChbCookies.CheckedChanged
        txtCookie.Enabled = True
        txtCookie.Text = ""
        txtCookie.Focus()
        If ChbCookies.Checked = False Then
            txtCookie.Enabled = False
            txtCookie.Text = "0"
        End If
    End Sub

    Private Sub ChbIce_Cream_CheckedChanged(sender As Object, e As EventArgs) Handles ChbIce_Cream.CheckedChanged
        txtIcre_Cream.Enabled = True
        txtIcre_Cream.Text = ""
        txtIcre_Cream.Focus()
        If ChbIce_Cream.Checked = False Then
            txtIcre_Cream.Enabled = False
            txtIcre_Cream.Text = "0"
        End If
    End Sub

    Private Sub ChbPudding_CheckedChanged(sender As Object, e As EventArgs) Handles ChbPudding.CheckedChanged
        txtPudding.Enabled = True
        txtPudding.Text = ""
        txtPudding.Focus()
        If ChbPudding.Checked = False Then
            txtPudding.Enabled = False
            txtPudding.Text = "0"
        End If
    End Sub

    Private Sub ChbBiscuit_CheckedChanged(sender As Object, e As EventArgs) Handles ChbBiscuit.CheckedChanged
        txtBiscuit.Enabled = True
        txtBiscuit.Text = ""
        txtBiscuit.Focus()
        If ChbBiscuit.Checked = False Then
            txtBiscuit.Enabled = False
            txtBiscuit.Text = "0"
        End If
    End Sub

    Private Sub ChbTaco_CheckedChanged(sender As Object, e As EventArgs) Handles ChbTaco.CheckedChanged
        txtTaco.Enabled = True
        txtTaco.Text = ""
        txtTaco.Focus()
        If ChbTaco.Checked = False Then
            txtTaco.Enabled = False
            txtTaco.Text = "0"
        End If
    End Sub

    Private Sub PaymentForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        For Each txt In {txtBiscuit, txtburrito, txtCash, txtChange, txtCola, txtCookie, txtFruit, txtHamburger, txtIcre_Cream, txtPho, txtPie, txtPizza, txtPudding, txtTaco,
        txtTotal, txtWater}
            txt.Enabled = False
            txt.Text = "0"
        Next

        For Each chb In {ChbApple_pie, ChbBiscuit, ChbBurrito, ChbCoca_Cola, ChbCookies, ChbFruit_Shake, ChbHamburger, ChbIce_Cream, ChbPho,
            ChbPizza, ChbPudding, ChbTaco, ChbTaco}
            chb.Checked = False

        Next

        ComboBox1.Text = ""
        rtfbill.Text = ""
        RichTextBox1.Text = ""
        RichTextBox2.Text = ""

    End Sub

    Private Sub btnTotal_Click(sender As Object, e As EventArgs) Handles btnTotal.Click

        txtTotal.Enabled = True
        txtCash.Enabled = True
        txtCash.Focus()

        itemcost(0) = Convert.ToDecimal(txtTaco.Text) * Label3.Text
        itemcost(1) = Convert.ToDecimal(txtPho.Text) * Label4.Text
        itemcost(2) = Convert.ToDecimal(txtburrito.Text) * Label5.Text
        itemcost(3) = Convert.ToDecimal(txtHamburger.Text) * Label7.Text
        itemcost(4) = Convert.ToDecimal(txtPizza.Text) * Label6.Text
        itemcost(5) = Convert.ToDecimal(txtWater.Text) * Label12.Text
        itemcost(6) = Convert.ToDecimal(txtCola.Text) * Label11.Text
        itemcost(7) = Convert.ToDecimal(txtFruit.Text) * Label10.Text
        itemcost(8) = Convert.ToDecimal(txtPie.Text) * Label18.Text
        itemcost(9) = Convert.ToDecimal(txtCookie.Text) * Label17.Text
        itemcost(10) = Convert.ToDecimal(txtIcre_Cream.Text) * Label16.Text
        itemcost(11) = Convert.ToDecimal(txtPudding.Text) * Label15.Text
        itemcost(12) = Convert.ToDecimal(txtBiscuit.Text) * Label14.Text

        itotal = itemcost(0) + itemcost(1) + itemcost(2) + itemcost(3) + itemcost(4) + itemcost(5) + itemcost(6) + itemcost(7) +
            itemcost(8) + itemcost(9) + itemcost(10) + itemcost(11) + itemcost(12)

        txtTotal.Text = FormatCurrency(itotal)

        For Each chb In {ChbApple_pie, ChbBiscuit, ChbBurrito, ChbCoca_Cola, ChbCookies, ChbFruit_Shake, ChbHamburger, ChbIce_Cream, ChbPho,
            ChbPizza, ChbPudding, ChbTaco, ChbTaco}
            If chb.Checked = True Then
                RichTextBox1.Text += Environment.NewLine + chb.Text + Environment.NewLine
            End If

        Next
        For Each txt In {txtBiscuit, txtburrito, txtCash, txtCola, txtCookie, txtFruit, txtHamburger, txtIcre_Cream, txtPho, txtPie, txtPizza, txtPudding, txtTaco,
        txtWater}
            If txt.Enabled = True Then
                RichTextBox2.Text += Environment.NewLine + txt.Text + Environment.NewLine
            End If
        Next

    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click

        Dim cmd As New MySqlCommand("INSERT INTO `report_tbl`(`Dining_Table`, `cash`, `food`, `amount`) VALUES (@table, @cash, @food, @amount)", connection)
        cmd.Parameters.Add("@table", MySqlDbType.VarChar).Value = ComboBox1.Text
        cmd.Parameters.Add("@cash", MySqlDbType.VarChar).Value = txtTotal.Text
        cmd.Parameters.Add("@food", MySqlDbType.VarChar).Value = RichTextBox1.Text
        cmd.Parameters.Add("@amount", MySqlDbType.VarChar).Value = RichTextBox2.Text

        If ComboBox1.Text = "" Then
            MsgBox("Insert Table.no!!!!")
        Else
            connection.Open()
            If cmd.ExecuteNonQuery() = 1 Then
                MsgBox("Saved succeccfully!!")
            Else
                MsgBox("Query not executed!!!")
            End If

            connection.Close()
        End If


    End Sub

    Private Sub btnChange_Click(sender As Object, e As EventArgs) Handles btnChange.Click
        txtChange.Enabled = True
        ichange = Convert.ToDecimal(txtCash.Text) - itotal
        txtChange.Text = FormatCurrency(ichange)

    End Sub

    Private Sub btnReceipt_Click(sender As Object, e As EventArgs) Handles btnReceipt.Click
        Dim itime As Date = DateTime.Now.ToLongTimeString
        Timer1.Start()
        Dim idate As Date = DateTime.Now.ToLongDateString
        rtfbill.Clear()
        If ComboBox1.Text = "" Then
            MsgBox("Please Enter table No.!!!", MsgBoxStyle.Information, "Information")
        Else
            rtfbill.AppendText(vbTab + "Fast Food Restaurant" + Environment.NewLine)
            rtfbill.AppendText("------------------------------------------------------------------------------------------------------------------------------" + Environment.NewLine)
            rtfbill.AppendText(ComboBox1.Text + ":" + Environment.NewLine)
            rtfbill.AppendText("------------------------------------------------------------------------------------------------------------------------------" + Environment.NewLine)
            rtfbill.AppendText("Taco" + vbTab + vbTab + vbTab + vbTab + txtTaco.Text + Environment.NewLine)
            rtfbill.AppendText("Pho" + vbTab + vbTab + vbTab + vbTab + txtPho.Text + Environment.NewLine)
            rtfbill.AppendText("Burrito" + vbTab + vbTab + vbTab + vbTab + txtburrito.Text + Environment.NewLine)
            rtfbill.AppendText("Hamburger" + vbTab + vbTab + vbTab + txtHamburger.Text + Environment.NewLine)
            rtfbill.AppendText("Piza" + vbTab + vbTab + vbTab + txtPizza.Text + Environment.NewLine)
            rtfbill.AppendText("Water Bottle" + vbTab + vbTab + vbTab + txtWater.Text + Environment.NewLine)
            rtfbill.AppendText("Coca Cola" + vbTab + vbTab + vbTab + txtCola.Text + Environment.NewLine)
            rtfbill.AppendText("Fruit Shake" + vbTab + vbTab + vbTab + vbTab + txtFruit.Text + Environment.NewLine)
            rtfbill.AppendText("Apple Pie" + vbTab + vbTab + vbTab + txtPie.Text + Environment.NewLine)
            rtfbill.AppendText("Cookie" + vbTab + vbTab + vbTab + vbTab + txtCookie.Text + Environment.NewLine)
            rtfbill.AppendText("Ice Cream" + vbTab + vbTab + vbTab + txtIcre_Cream.Text + Environment.NewLine)
            rtfbill.AppendText("Pudding" + vbTab + vbTab + vbTab + vbTab + txtPudding.Text + Environment.NewLine)
            rtfbill.AppendText("Biscuit" + vbTab + vbTab + vbTab + vbTab + txtBiscuit.Text + Environment.NewLine)
            rtfbill.AppendText("------------------------------------------------------------------------------------------------------------------------------" + Environment.NewLine)
            rtfbill.AppendText("Total" + vbTab + vbTab + vbTab + vbTab + txtTotal.Text + Environment.NewLine)
            rtfbill.AppendText("Cash" + vbTab + vbTab + vbTab + vbTab + "$" + txtCash.Text + ".00" + Environment.NewLine)
            rtfbill.AppendText("Change" + vbTab + vbTab + vbTab + vbTab + txtChange.Text + Environment.NewLine)
            rtfbill.AppendText("------------------------------------------------------------------------------------------------------------------------------" + Environment.NewLine)
            rtfbill.AppendText(itime + vbTab + vbTab + vbTab + idate + Environment.NewLine)

        End If

    End Sub

    Private Sub rtfbill_TextChanged(sender As Object, e As EventArgs) Handles rtfbill.TextChanged

    End Sub
End Class