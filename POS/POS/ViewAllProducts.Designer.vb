<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ViewAllProducts
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
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.txt_ProductName = New System.Windows.Forms.TextBox()
        Me.txtID = New System.Windows.Forms.TextBox()
        Me.ProductName = New System.Windows.Forms.Label()
        Me.ProductID = New System.Windows.Forms.Label()
        Me.txt_PriceLarge = New System.Windows.Forms.TextBox()
        Me.txt_PriceMedium = New System.Windows.Forms.TextBox()
        Me.btn_upload = New System.Windows.Forms.Button()
        Me.ProductPicture = New System.Windows.Forms.PictureBox()
        Me.txt_PriceSmall = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btn_Del = New System.Windows.Forms.Button()
        Me.btn_Update = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.GroupBoxPrice = New System.Windows.Forms.GroupBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.ProductPicture, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.GroupBoxPrice.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(67, 68)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(290, 20)
        Me.TextBox1.TabIndex = 5
        '
        'txt_ProductName
        '
        Me.txt_ProductName.Location = New System.Drawing.Point(143, 60)
        Me.txt_ProductName.Name = "txt_ProductName"
        Me.txt_ProductName.Size = New System.Drawing.Size(154, 20)
        Me.txt_ProductName.TabIndex = 18
        '
        'txtID
        '
        Me.txtID.Location = New System.Drawing.Point(143, 18)
        Me.txtID.Name = "txtID"
        Me.txtID.Size = New System.Drawing.Size(91, 20)
        Me.txtID.TabIndex = 16
        '
        'ProductName
        '
        Me.ProductName.AutoSize = True
        Me.ProductName.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ProductName.Location = New System.Drawing.Point(39, 63)
        Me.ProductName.Name = "ProductName"
        Me.ProductName.Size = New System.Drawing.Size(72, 13)
        Me.ProductName.TabIndex = 17
        Me.ProductName.Text = "ProductName"
        '
        'ProductID
        '
        Me.ProductID.AutoSize = True
        Me.ProductID.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ProductID.Location = New System.Drawing.Point(39, 21)
        Me.ProductID.Name = "ProductID"
        Me.ProductID.Size = New System.Drawing.Size(55, 13)
        Me.ProductID.TabIndex = 15
        Me.ProductID.Text = "ProductID"
        '
        'txt_PriceLarge
        '
        Me.txt_PriceLarge.Location = New System.Drawing.Point(130, 90)
        Me.txt_PriceLarge.Name = "txt_PriceLarge"
        Me.txt_PriceLarge.Size = New System.Drawing.Size(91, 20)
        Me.txt_PriceLarge.TabIndex = 16
        '
        'txt_PriceMedium
        '
        Me.txt_PriceMedium.Location = New System.Drawing.Point(130, 57)
        Me.txt_PriceMedium.Name = "txt_PriceMedium"
        Me.txt_PriceMedium.Size = New System.Drawing.Size(91, 20)
        Me.txt_PriceMedium.TabIndex = 15
        '
        'btn_upload
        '
        Me.btn_upload.Location = New System.Drawing.Point(246, 278)
        Me.btn_upload.Name = "btn_upload"
        Me.btn_upload.Size = New System.Drawing.Size(75, 23)
        Me.btn_upload.TabIndex = 21
        Me.btn_upload.Text = "Upload"
        Me.btn_upload.UseVisualStyleBackColor = True
        '
        'ProductPicture
        '
        Me.ProductPicture.BackColor = System.Drawing.Color.Gray
        Me.ProductPicture.Location = New System.Drawing.Point(92, 248)
        Me.ProductPicture.Name = "ProductPicture"
        Me.ProductPicture.Size = New System.Drawing.Size(132, 115)
        Me.ProductPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.ProductPicture.TabIndex = 20
        Me.ProductPicture.TabStop = False
        '
        'txt_PriceSmall
        '
        Me.txt_PriceSmall.Location = New System.Drawing.Point(130, 24)
        Me.txt_PriceSmall.Name = "txt_PriceSmall"
        Me.txt_PriceSmall.Size = New System.Drawing.Size(91, 20)
        Me.txt_PriceSmall.TabIndex = 12
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 93)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(90, 13)
        Me.Label4.TabIndex = 14
        Me.Label4.Text = "Price (Large Size)"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 60)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(100, 13)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = "Price (Medium Size)"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 27)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(89, 13)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "Price (Small SIze)"
        '
        'btn_Del
        '
        Me.btn_Del.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Del.Location = New System.Drawing.Point(205, 395)
        Me.btn_Del.Name = "btn_Del"
        Me.btn_Del.Size = New System.Drawing.Size(147, 64)
        Me.btn_Del.TabIndex = 23
        Me.btn_Del.Text = "Delete"
        Me.btn_Del.UseVisualStyleBackColor = True
        '
        'btn_Update
        '
        Me.btn_Update.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Update.Location = New System.Drawing.Point(26, 395)
        Me.btn_Update.Name = "btn_Update"
        Me.btn_Update.Size = New System.Drawing.Size(151, 64)
        Me.btn_Update.TabIndex = 22
        Me.btn_Update.Text = "Update"
        Me.btn_Update.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.btn_Del)
        Me.Panel1.Controls.Add(Me.btn_Update)
        Me.Panel1.Controls.Add(Me.btn_upload)
        Me.Panel1.Controls.Add(Me.ProductPicture)
        Me.Panel1.Controls.Add(Me.GroupBoxPrice)
        Me.Panel1.Controls.Add(Me.txt_ProductName)
        Me.Panel1.Controls.Add(Me.txtID)
        Me.Panel1.Controls.Add(Me.ProductName)
        Me.Panel1.Controls.Add(Me.ProductID)
        Me.Panel1.Location = New System.Drawing.Point(759, 27)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(360, 462)
        Me.Panel1.TabIndex = 4
        '
        'GroupBoxPrice
        '
        Me.GroupBoxPrice.Controls.Add(Me.txt_PriceLarge)
        Me.GroupBoxPrice.Controls.Add(Me.txt_PriceMedium)
        Me.GroupBoxPrice.Controls.Add(Me.txt_PriceSmall)
        Me.GroupBoxPrice.Controls.Add(Me.Label4)
        Me.GroupBoxPrice.Controls.Add(Me.Label2)
        Me.GroupBoxPrice.Controls.Add(Me.Label3)
        Me.GroupBoxPrice.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.GroupBoxPrice.Location = New System.Drawing.Point(61, 99)
        Me.GroupBoxPrice.Name = "GroupBoxPrice"
        Me.GroupBoxPrice.Size = New System.Drawing.Size(236, 136)
        Me.GroupBoxPrice.TabIndex = 19
        Me.GroupBoxPrice.TabStop = False
        Me.GroupBoxPrice.Text = "Price"
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(10, 103)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(734, 344)
        Me.DataGridView1.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.SystemColors.Control
        Me.Label1.Location = New System.Drawing.Point(12, 71)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(41, 13)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Search"
        '
        'ViewAllProducts
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(67, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1128, 517)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "ViewAllProducts"
        Me.Text = "ViewAllProducts"
        CType(Me.ProductPicture, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.GroupBoxPrice.ResumeLayout(False)
        Me.GroupBoxPrice.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents txt_ProductName As TextBox
    Friend WithEvents txtID As TextBox
    Friend WithEvents ProductName As Label
    Friend WithEvents ProductID As Label
    Friend WithEvents txt_PriceLarge As TextBox
    Friend WithEvents txt_PriceMedium As TextBox
    Friend WithEvents btn_upload As Button
    Friend WithEvents ProductPicture As PictureBox
    Friend WithEvents txt_PriceSmall As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents btn_Del As Button
    Friend WithEvents btn_Update As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents GroupBoxPrice As GroupBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Label1 As Label
End Class
