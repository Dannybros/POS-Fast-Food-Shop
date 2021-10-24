<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddProducts
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.txt_ProductName = New System.Windows.Forms.TextBox()
        Me.ProductName = New System.Windows.Forms.Label()
        Me.txtID = New System.Windows.Forms.TextBox()
        Me.ProductID = New System.Windows.Forms.Label()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.txt_PriceLarge = New System.Windows.Forms.TextBox()
        Me.txt_PriceMedium = New System.Windows.Forms.TextBox()
        Me.btn_upload = New System.Windows.Forms.Button()
        Me.txt_PriceSmall = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btn_Save = New System.Windows.Forms.Button()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.ProductPicture = New System.Windows.Forms.PictureBox()
        Me.GroupBoxPrice = New System.Windows.Forms.GroupBox()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.LabelTotal = New System.Windows.Forms.Label()
        Me.TabPage1.SuspendLayout()
        CType(Me.ProductPicture, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBoxPrice.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txt_ProductName
        '
        Me.txt_ProductName.Location = New System.Drawing.Point(122, 66)
        Me.txt_ProductName.Name = "txt_ProductName"
        Me.txt_ProductName.Size = New System.Drawing.Size(236, 20)
        Me.txt_ProductName.TabIndex = 10
        '
        'ProductName
        '
        Me.ProductName.AutoSize = True
        Me.ProductName.Location = New System.Drawing.Point(18, 69)
        Me.ProductName.Name = "ProductName"
        Me.ProductName.Size = New System.Drawing.Size(72, 13)
        Me.ProductName.TabIndex = 9
        Me.ProductName.Text = "ProductName"
        '
        'txtID
        '
        Me.txtID.Location = New System.Drawing.Point(122, 24)
        Me.txtID.Name = "txtID"
        Me.txtID.Size = New System.Drawing.Size(178, 20)
        Me.txtID.TabIndex = 8
        '
        'ProductID
        '
        Me.ProductID.AutoSize = True
        Me.ProductID.Location = New System.Drawing.Point(18, 27)
        Me.ProductID.Name = "ProductID"
        Me.ProductID.Size = New System.Drawing.Size(55, 13)
        Me.ProductID.TabIndex = 7
        Me.ProductID.Text = "ProductID"
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'txt_PriceLarge
        '
        Me.txt_PriceLarge.Location = New System.Drawing.Point(169, 94)
        Me.txt_PriceLarge.Name = "txt_PriceLarge"
        Me.txt_PriceLarge.Size = New System.Drawing.Size(131, 20)
        Me.txt_PriceLarge.TabIndex = 16
        '
        'txt_PriceMedium
        '
        Me.txt_PriceMedium.Location = New System.Drawing.Point(169, 61)
        Me.txt_PriceMedium.Name = "txt_PriceMedium"
        Me.txt_PriceMedium.Size = New System.Drawing.Size(131, 20)
        Me.txt_PriceMedium.TabIndex = 15
        '
        'btn_upload
        '
        Me.btn_upload.Location = New System.Drawing.Point(209, 401)
        Me.btn_upload.Name = "btn_upload"
        Me.btn_upload.Size = New System.Drawing.Size(75, 23)
        Me.btn_upload.TabIndex = 13
        Me.btn_upload.Text = "Upload"
        Me.btn_upload.UseVisualStyleBackColor = True
        '
        'txt_PriceSmall
        '
        Me.txt_PriceSmall.Location = New System.Drawing.Point(169, 28)
        Me.txt_PriceSmall.Name = "txt_PriceSmall"
        Me.txt_PriceSmall.Size = New System.Drawing.Size(131, 20)
        Me.txt_PriceSmall.TabIndex = 12
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(51, 97)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(90, 13)
        Me.Label4.TabIndex = 14
        Me.Label4.Text = "Price (Large Size)"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(51, 64)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(100, 13)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = "Price (Medium Size)"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(51, 31)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(89, 13)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "Price (Small SIze)"
        '
        'btn_Save
        '
        Me.btn_Save.BackColor = System.Drawing.Color.Aqua
        Me.btn_Save.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_Save.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Save.Location = New System.Drawing.Point(175, 471)
        Me.btn_Save.Name = "btn_Save"
        Me.btn_Save.Size = New System.Drawing.Size(149, 64)
        Me.btn_Save.TabIndex = 14
        Me.btn_Save.Text = "Save"
        Me.btn_Save.UseVisualStyleBackColor = False
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.btn_Save)
        Me.TabPage1.Controls.Add(Me.btn_upload)
        Me.TabPage1.Controls.Add(Me.ProductPicture)
        Me.TabPage1.Controls.Add(Me.GroupBoxPrice)
        Me.TabPage1.Controls.Add(Me.txt_ProductName)
        Me.TabPage1.Controls.Add(Me.ProductName)
        Me.TabPage1.Controls.Add(Me.txtID)
        Me.TabPage1.Controls.Add(Me.ProductID)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(491, 541)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Add Menu"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'ProductPicture
        '
        Me.ProductPicture.BackColor = System.Drawing.Color.Gray
        Me.ProductPicture.Location = New System.Drawing.Point(159, 258)
        Me.ProductPicture.Name = "ProductPicture"
        Me.ProductPicture.Size = New System.Drawing.Size(165, 137)
        Me.ProductPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.ProductPicture.TabIndex = 12
        Me.ProductPicture.TabStop = False
        '
        'GroupBoxPrice
        '
        Me.GroupBoxPrice.Controls.Add(Me.txt_PriceLarge)
        Me.GroupBoxPrice.Controls.Add(Me.txt_PriceMedium)
        Me.GroupBoxPrice.Controls.Add(Me.txt_PriceSmall)
        Me.GroupBoxPrice.Controls.Add(Me.Label4)
        Me.GroupBoxPrice.Controls.Add(Me.Label2)
        Me.GroupBoxPrice.Controls.Add(Me.Label3)
        Me.GroupBoxPrice.Location = New System.Drawing.Point(40, 105)
        Me.GroupBoxPrice.Name = "GroupBoxPrice"
        Me.GroupBoxPrice.Size = New System.Drawing.Size(359, 136)
        Me.GroupBoxPrice.TabIndex = 11
        Me.GroupBoxPrice.TabStop = False
        Me.GroupBoxPrice.Text = "Price"
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Location = New System.Drawing.Point(537, 25)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(499, 567)
        Me.TabControl1.TabIndex = 12
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(57, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(41, 13)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "Search"
        '
        'txtSearch
        '
        Me.txtSearch.Location = New System.Drawing.Point(104, 22)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(227, 20)
        Me.txtSearch.TabIndex = 10
        '
        'DataGridView1
        '
        Me.DataGridView1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(34, 60)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(373, 543)
        Me.DataGridView1.TabIndex = 9
        '
        'LabelTotal
        '
        Me.LabelTotal.AutoSize = True
        Me.LabelTotal.ForeColor = System.Drawing.Color.DarkGreen
        Me.LabelTotal.Location = New System.Drawing.Point(374, 25)
        Me.LabelTotal.Name = "LabelTotal"
        Me.LabelTotal.Size = New System.Drawing.Size(31, 13)
        Me.LabelTotal.TabIndex = 13
        Me.LabelTotal.Text = "Total"
        '
        'AddProducts
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1200, 650)
        Me.Controls.Add(Me.LabelTotal)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtSearch)
        Me.Controls.Add(Me.DataGridView1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "AddProducts"
        Me.Text = "AddProducts"
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        CType(Me.ProductPicture, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBoxPrice.ResumeLayout(False)
        Me.GroupBoxPrice.PerformLayout()
        Me.TabControl1.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txt_ProductName As TextBox
    Friend WithEvents ProductName As Label
    Friend WithEvents txtID As TextBox
    Friend WithEvents ProductID As Label
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents txt_PriceLarge As TextBox
    Friend WithEvents txt_PriceMedium As TextBox
    Friend WithEvents btn_upload As Button
    Friend WithEvents ProductPicture As PictureBox
    Friend WithEvents txt_PriceSmall As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents btn_Save As Button
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents GroupBoxPrice As GroupBox
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents Label1 As Label
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents LabelTotal As Label
End Class
