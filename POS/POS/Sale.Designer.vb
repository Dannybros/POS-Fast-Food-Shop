<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Sale
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.btn_Del_All = New System.Windows.Forms.Button()
        Me.txt_sum = New System.Windows.Forms.TextBox()
        Me.btn_sum = New System.Windows.Forms.Button()
        Me.ImageListfood = New System.Windows.Forms.ImageList(Me.components)
        Me.ListView_menu = New System.Windows.Forms.ListView()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_search = New System.Windows.Forms.TextBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btn_delete_select = New System.Windows.Forms.Button()
        Me.ColumnHeader7 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader5 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.listview_sale = New System.Windows.Forms.ListView()
        Me.ColumnHeader6 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.txt_change = New System.Windows.Forms.TextBox()
        Me.btn_change = New System.Windows.Forms.Button()
        Me.txt_cash = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel3.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btn_Del_All
        '
        Me.btn_Del_All.Location = New System.Drawing.Point(356, 37)
        Me.btn_Del_All.Name = "btn_Del_All"
        Me.btn_Del_All.Size = New System.Drawing.Size(75, 23)
        Me.btn_Del_All.TabIndex = 12
        Me.btn_Del_All.Text = "Delete All"
        Me.btn_Del_All.UseVisualStyleBackColor = True
        '
        'txt_sum
        '
        Me.txt_sum.BackColor = System.Drawing.SystemColors.InfoText
        Me.txt_sum.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_sum.ForeColor = System.Drawing.SystemColors.Window
        Me.txt_sum.Location = New System.Drawing.Point(134, 12)
        Me.txt_sum.Name = "txt_sum"
        Me.txt_sum.Size = New System.Drawing.Size(253, 62)
        Me.txt_sum.TabIndex = 10
        Me.txt_sum.Text = "0.00"
        Me.txt_sum.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'btn_sum
        '
        Me.btn_sum.Location = New System.Drawing.Point(31, 33)
        Me.btn_sum.Name = "btn_sum"
        Me.btn_sum.Size = New System.Drawing.Size(75, 23)
        Me.btn_sum.TabIndex = 3
        Me.btn_sum.Text = "Total"
        Me.btn_sum.UseVisualStyleBackColor = True
        '
        'ImageListfood
        '
        Me.ImageListfood.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit
        Me.ImageListfood.ImageSize = New System.Drawing.Size(120, 90)
        Me.ImageListfood.TransparentColor = System.Drawing.Color.Transparent
        '
        'ListView_menu
        '
        Me.ListView_menu.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ListView_menu.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.ListView_menu.HideSelection = False
        Me.ListView_menu.LargeImageList = Me.ImageListfood
        Me.ListView_menu.Location = New System.Drawing.Point(0, 0)
        Me.ListView_menu.Name = "ListView_menu"
        Me.ListView_menu.Size = New System.Drawing.Size(702, 563)
        Me.ListView_menu.TabIndex = 0
        Me.ListView_menu.UseCompatibleStateImageBehavior = False
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.ListView_menu)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel3.Location = New System.Drawing.Point(0, 87)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(702, 563)
        Me.Panel3.TabIndex = 5
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(362, 47)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(41, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Search"
        '
        'txt_search
        '
        Me.txt_search.Location = New System.Drawing.Point(419, 42)
        Me.txt_search.Name = "txt_search"
        Me.txt_search.Size = New System.Drawing.Size(222, 20)
        Me.txt_search.TabIndex = 0
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Controls.Add(Me.txt_search)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(702, 87)
        Me.Panel2.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(45, 45)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(49, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Go Back"
        '
        'btn_delete_select
        '
        Me.btn_delete_select.Location = New System.Drawing.Point(56, 37)
        Me.btn_delete_select.Name = "btn_delete_select"
        Me.btn_delete_select.Size = New System.Drawing.Size(75, 23)
        Me.btn_delete_select.TabIndex = 11
        Me.btn_delete_select.Text = "Delete"
        Me.btn_delete_select.UseVisualStyleBackColor = True
        '
        'ColumnHeader7
        '
        Me.ColumnHeader7.Text = "Total Bill"
        Me.ColumnHeader7.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "Amount"
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Size"
        Me.ColumnHeader4.Width = 82
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "List"
        Me.ColumnHeader3.Width = 85
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "ID"
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "*"
        Me.ColumnHeader1.Width = 33
        '
        'listview_sale
        '
        Me.listview_sale.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4, Me.ColumnHeader5, Me.ColumnHeader6, Me.ColumnHeader7})
        Me.listview_sale.FullRowSelect = True
        Me.listview_sale.GridLines = True
        Me.listview_sale.HideSelection = False
        Me.listview_sale.Location = New System.Drawing.Point(19, 66)
        Me.listview_sale.Name = "listview_sale"
        Me.listview_sale.Size = New System.Drawing.Size(457, 356)
        Me.listview_sale.TabIndex = 1
        Me.listview_sale.UseCompatibleStateImageBehavior = False
        Me.listview_sale.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader6
        '
        Me.ColumnHeader6.Text = "Price"
        Me.ColumnHeader6.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.txt_change)
        Me.Panel4.Controls.Add(Me.btn_change)
        Me.Panel4.Controls.Add(Me.txt_cash)
        Me.Panel4.Controls.Add(Me.txt_sum)
        Me.Panel4.Controls.Add(Me.btn_sum)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel4.Location = New System.Drawing.Point(0, 428)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(498, 222)
        Me.Panel4.TabIndex = 2
        '
        'txt_change
        '
        Me.txt_change.BackColor = System.Drawing.SystemColors.InfoText
        Me.txt_change.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_change.ForeColor = System.Drawing.SystemColors.Window
        Me.txt_change.Location = New System.Drawing.Point(134, 145)
        Me.txt_change.Name = "txt_change"
        Me.txt_change.Size = New System.Drawing.Size(253, 62)
        Me.txt_change.TabIndex = 14
        Me.txt_change.Text = "0.00"
        Me.txt_change.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'btn_change
        '
        Me.btn_change.Location = New System.Drawing.Point(31, 166)
        Me.btn_change.Name = "btn_change"
        Me.btn_change.Size = New System.Drawing.Size(75, 23)
        Me.btn_change.TabIndex = 13
        Me.btn_change.Text = "Change"
        Me.btn_change.UseVisualStyleBackColor = True
        '
        'txt_cash
        '
        Me.txt_cash.BackColor = System.Drawing.SystemColors.InfoText
        Me.txt_cash.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_cash.ForeColor = System.Drawing.SystemColors.Window
        Me.txt_cash.Location = New System.Drawing.Point(134, 80)
        Me.txt_cash.Name = "txt_cash"
        Me.txt_cash.Size = New System.Drawing.Size(253, 62)
        Me.txt_cash.TabIndex = 12
        Me.txt_cash.Text = "0.00"
        Me.txt_cash.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.btn_Del_All)
        Me.Panel1.Controls.Add(Me.btn_delete_select)
        Me.Panel1.Controls.Add(Me.Panel4)
        Me.Panel1.Controls.Add(Me.listview_sale)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel1.Location = New System.Drawing.Point(702, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(498, 650)
        Me.Panel1.TabIndex = 3
        '
        'Sale
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1200, 650)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Sale"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Sale"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel3.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btn_Del_All As Button
    Friend WithEvents txt_sum As TextBox
    Friend WithEvents btn_sum As Button
    Friend WithEvents ImageListfood As ImageList
    Friend WithEvents ListView_menu As ListView
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents txt_search As TextBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents btn_delete_select As Button
    Friend WithEvents ColumnHeader7 As ColumnHeader
    Friend WithEvents ColumnHeader5 As ColumnHeader
    Friend WithEvents ColumnHeader4 As ColumnHeader
    Friend WithEvents ColumnHeader3 As ColumnHeader
    Friend WithEvents ColumnHeader2 As ColumnHeader
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents listview_sale As ListView
    Friend WithEvents ColumnHeader6 As ColumnHeader
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents txt_change As TextBox
    Friend WithEvents btn_change As Button
    Friend WithEvents txt_cash As TextBox
    Friend WithEvents Label2 As Label
End Class
