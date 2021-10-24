Imports System.IO
Imports MySql.Data.MySqlClient

Public Class ViewDatagridFullForm
    Dim employee As New EMPLOYEE
    Dim updateEmployee As New UpdateDeleteEmployeeForm()
    Dim command As New MySqlCommand("SELECT * FROM `employee_tbl")

    Private Sub ViewDatagridFullForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        refesh(command)

    End Sub
    Private Sub DataGridView1_DoubleClick(sender As Object, e As EventArgs) Handles DataGridView1.DoubleClick

        updateEmployee.txtID.Text = DataGridView1.CurrentRow.Cells(0).Value.ToString
        updateEmployee.txtFirstName.Text = DataGridView1.CurrentRow.Cells(1).Value.ToString
        updateEmployee.txtLastName.Text = DataGridView1.CurrentRow.Cells(2).Value.ToString
        updateEmployee.DateTimePicker1.Text = DataGridView1.CurrentRow.Cells(3).Value
        updateEmployee.txtAddress.Text = DataGridView1.CurrentRow.Cells(4).Value.ToString
        updateEmployee.txtPhone.Text = DataGridView1.CurrentRow.Cells(5).Value.ToString
        updateEmployee.txtEmail.Text = DataGridView1.CurrentRow.Cells(6).Value.ToString

        Dim pic As Byte()
        pic = DataGridView1.CurrentRow.Cells(7).Value
        Dim picture As New MemoryStream(pic)
        updateEmployee.pbImageInput.Image = Image.FromStream(picture)
        updateEmployee.Show()
        refesh(command)
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click

        updateEmployee.txtID.Text = DataGridView1.CurrentRow.Cells(0).Value.ToString
        updateEmployee.txtFirstName.Text = DataGridView1.CurrentRow.Cells(1).Value.ToString
        updateEmployee.txtLastName.Text = DataGridView1.CurrentRow.Cells(2).Value.ToString
        updateEmployee.DateTimePicker1.Text = DataGridView1.CurrentRow.Cells(3).Value
        updateEmployee.txtAddress.Text = DataGridView1.CurrentRow.Cells(4).Value.ToString
        updateEmployee.txtPhone.Text = DataGridView1.CurrentRow.Cells(5).Value.ToString
        updateEmployee.txtEmail.Text = DataGridView1.CurrentRow.Cells(6).Value.ToString

        Dim pic As Byte()
        pic = DataGridView1.CurrentRow.Cells(7).Value
        Dim picture As New MemoryStream(pic)
        updateEmployee.pbImageInput.Image = Image.FromStream(picture)
        updateEmployee.Show()

    End Sub

    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click

        refesh(command)
    End Sub
    Sub refesh(ByVal command As MySqlCommand)

        DataGridView1.ReadOnly = True
        DataGridView1.RowTemplate.Height = 80
        DataGridView1.DataSource = employee.getEmployee(command)


        Dim picCol As New DataGridViewImageColumn()

        picCol = DataGridView1.Columns(7)
        picCol.ImageLayout = DataGridViewImageCellLayout.Stretch

        DataGridView1.AllowUserToAddRows = False


    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        Dim command As New MySqlCommand("SELECT * FROM `employee_tbl` WHERE CONCAT(`first_name`,`last_name`,`phone`)LIKE'%" & txtSearch.Text & "%'")
        refesh(command)
    End Sub
End Class