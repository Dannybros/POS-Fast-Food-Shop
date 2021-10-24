Imports System.IO
Imports MySql.Data.MySqlClient

Public Class UpdateDeleteEmployeeForm
    Dim employee As New EMPLOYEE
    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click

        Try
            Dim employeeId As Integer = Convert.ToInt32(txtID.Text)
            Dim idelete As DialogResult
            idelete = MessageBox.Show("Do you want to delete?", "Delete Employee", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning)
            If idelete = DialogResult.OK Then
                If employee.delEmployee(employeeId) Then
                    MsgBox("Employee has been eliminated", MsgBoxStyle.Information, "Easy Mission")
                    Me.Hide()
                    Dim command As New MySqlCommand("SELECT * FROM `employee_tbl")
                    EmployeeForm.refesh(command)
                Else
                    MsgBox("Employee couldn't be eliminated", MsgBoxStyle.Information, "Employee Too Strong")
                End If
            End If

        Catch ex As Exception
            MsgBox("Please enter Valid ID")
        End Try

    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
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
                Dim id As Integer = Convert.ToInt32(txtID.Text)
                pbImageInput.Image.Save(image, pbImageInput.Image.RawFormat)
                If employee.updateEmployee(id, fname, lname, bdt, address, phone, email, image) Then
                    MsgBox("Updated successfully", MsgBoxStyle.Information, "Edit Student")
                    Me.Hide()
                    Dim command As New MySqlCommand("SELECT * FROM `employee_tbl")
                    EmployeeForm.refesh(command)
                Else
                    MsgBox("Error, try again", MsgBoxStyle.Critical, "Edit Student")
                End If
            Else
                MsgBox("one or more fields are empty", MsgBoxStyle.Critical, "Edit Student")
            End If
        End If

    End Sub

    Function verif() As Boolean

        If txtID.Text.Trim() = "" Or txtFirstName.Text.Trim() = "" Or txtLastName.Text.Trim() = "" Or txtPhone.Text.Trim() = "" Or txtEmail.Text.Trim() = "" Or
            txtAddress.Text.Trim() = "" Or pbImageInput.Image Is Nothing Then

            Return False

        Else
            Return True
        End If


    End Function

    Private Sub btnUpload_Click(sender As Object, e As EventArgs) Handles btnUpload.Click
        Dim opf As New OpenFileDialog
        opf.Filter = "Select Image(*.jpg; *.png; *.gif)|*.jpg; *.png; *.gif"

        If opf.ShowDialog = DialogResult.OK Then
            pbImageInput.Image = Image.FromFile(opf.FileName)
        End If

    End Sub
End Class