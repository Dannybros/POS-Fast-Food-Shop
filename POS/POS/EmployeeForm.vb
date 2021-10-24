Imports MySql.Data.MySqlClient
Imports System.IO

Public Class EmployeeForm

    Dim employee As New EMPLOYEE()
    Dim command As New MySqlCommand("SELECT * FROM `employee_tbl")

    Private Sub btnUpload_Click(sender As Object, e As EventArgs) Handles btnUpload.Click
        Dim opf As New OpenFileDialog()
        opf.Filter = "Select Image(*.jpg;*.png;*.gif)|*.jpg;*.png;*.gif"

        If opf.ShowDialog = DialogResult.OK Then
            pbImageInput.Image = Image.FromFile(opf.FileName)
        End If

    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click

        Dim fname As String = txtFirstName.Text
        Dim lname As String = txtLastName.Text
        Dim bdt As Date = DateTimePicker1.Value
        Dim address As String = txtAddress.Text
        Dim phone As String = txtPhone.Text
        Dim email As String = txtEmail.Text
        Dim image As New MemoryStream

        Dim bornyear As Integer = DateTimePicker1.Value.Year
        Dim currentyear As Integer = Date.Now.Year

        If currentyear - bornyear <= 20 Then
            MsgBox("Employee age must be above 20", MsgBoxStyle.Information, "Alert")
        Else
            If verif() Then
                pbImageInput.Image.Save(image, pbImageInput.Image.RawFormat)
                If employee.insertStudent(fname, lname, bdt, address, phone, email, image) Then
                    MsgBox("New Employee has been added", MsgBoxStyle.Information, "Add Student")

                    txtFirstName.Text = ""
                    txtLastName.Text = ""
                    txtPhone.Text = ""
                    txtEmail.Text = ""
                    txtAddress.Text = ""
                    DateTimePicker1.Value = Date.Now
                    pbImageInput.Image = Nothing
                    refesh(command)
                    LabelTotal.Text = "Total: " & DataGridView1.Rows.Count

                Else
                    MsgBox("Error, try again", MsgBoxStyle.Critical, "Add Student")
                End If
            Else
                MsgBox("one or more fields are empty", MsgBoxStyle.Critical, "Add Student")
            End If
        End If

    End Sub

    Function verif() As Boolean

        If txtFirstName.Text.Trim() = "" Or txtLastName.Text.Trim() = "" Or txtPhone.Text.Trim() = "" Or txtEmail.Text.Trim() = "" Or
            txtAddress.Text.Trim() = "" Or pbImageInput.Image Is Nothing Then

            Return False

        Else
            Return True
        End If


    End Function

    Sub refesh(ByVal command As MySqlCommand)

        DataGridView1.ReadOnly = True
        DataGridView1.RowTemplate.Height = 50
        DataGridView1.DataSource = employee.getEmployee(command)

        Dim picCol As New DataGridViewImageColumn()

        picCol = DataGridView1.Columns(7)
        picCol.ImageLayout = DataGridViewImageCellLayout.Stretch

        DataGridView1.AllowUserToAddRows = False
        LabelTotal.Text = "Total: " & DataGridView1.Rows.Count

    End Sub

    Private Sub txtPhone_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPhone.KeyPress
        If Not Char.IsControl(e.KeyChar) AndAlso Not Char.IsDigit(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub EmployeeForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        refesh(command)

    End Sub

    Private Sub DataGridView1_DoubleClick(sender As Object, e As EventArgs) Handles DataGridView1.DoubleClick
        Dim viewdatagrid As New ViewDatagridFullForm
        viewdatagrid.Show(Me)
    End Sub

    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        refesh(command)

    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        Dim updateEmployee As New UpdateDeleteEmployeeForm()

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

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click

        txtFirstName.Text = ""
        txtLastName.Text = ""
        txtPhone.Text = ""
        txtEmail.Text = ""
        txtAddress.Text = ""
        DateTimePicker1.Value = Date.Now
        pbImageInput.Image = Nothing
        LabelTotal.Text = "Total: " & DataGridView1.Rows.Count

    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        Dim command As New MySqlCommand("SELECT * FROM `employee_tbl` WHERE CONCAT(`first_name`,`last_name`,`phone`)LIKE'%" & txtSearch.Text & "%'")
        refesh(command)
    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        Dim command As New MySqlCommand("SELECT * FROM `employee_tbl` WHERE CONCAT(`first_name`,`last_name`,`phone`)LIKE'%" & txtSearch.Text & "%'")
        refesh(command)
    End Sub
End Class