Public Class HomeForm
    Sub switchPanel(ByVal Panel As Form)
        Panel3.Controls.Clear()
        Panel.TopLevel = False
        Panel3.Controls.Add(Panel)
        Panel.Show()
    End Sub
    Private Sub btnHome_Click(sender As Object, e As EventArgs) Handles btnHome.Click

        SidePanel.Height = btnHome.Height
        SidePanel.Top = btnHome.Top
        switchPanel(GeneralForm)
        Label1.Text = "Fast Food Restaurant"
    End Sub

    Private Sub btnMenu_Click(sender As Object, e As EventArgs) Handles btnMenu.Click
        SidePanel.Height = btnMenu.Height
        SidePanel.Top = btnMenu.Top
        switchPanel(EmployeeForm)
        Label1.Text = "Employee page"
    End Sub

    Private Sub btnPayment_Click(sender As Object, e As EventArgs) Handles btnPayment.Click
        SidePanel.Height = btnPayment.Height
        SidePanel.Top = btnPayment.Top
        switchPanel(TableHome)
        Label1.Text = "Sale"
    End Sub

    Private Sub btnFoods_Click(sender As Object, e As EventArgs) Handles btnFoods.Click
        SidePanel.Height = btnFoods.Height
        SidePanel.Top = btnFoods.Top
        switchPanel(AddProducts)
        Label1.Text = "Food Detail"
    End Sub

    Private Sub btnReports_Click(sender As Object, e As EventArgs) Handles btnReports.Click
        SidePanel.Height = btnReports.Height
        SidePanel.Top = btnReports.Top
        switchPanel(TableHome)
        Label1.Text = "Revenue Sale History"
    End Sub


    Private Sub btnLog_out_Click(sender As Object, e As EventArgs) Handles btnLog_out.Click
        Me.Hide()
        LoginForm.Show()
        LoginForm.txtUsername.Text = ""
        LoginForm.txtPassword.Text = ""
        LoginForm.txtUsername.Focus()

    End Sub

    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs) Handles Panel2.Paint
        Timer1.Enabled = True
        lblusername.Text = LoginForm.txtUsername.Text
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        lblDate.Text = DateTime.Now
    End Sub

    Private Sub HomeForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()

    End Sub

End Class