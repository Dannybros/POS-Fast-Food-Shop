<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Specific_Order
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
        Me.rdb_large = New System.Windows.Forms.RadioButton()
        Me.rdb_medium = New System.Windows.Forms.RadioButton()
        Me.rdb_small = New System.Windows.Forms.RadioButton()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lbl_menu_name = New System.Windows.Forms.Label()
        Me.lbl_menu_id = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lbl_large = New System.Windows.Forms.Label()
        Me.lbl_medium = New System.Windows.Forms.Label()
        Me.lbl_small = New System.Windows.Forms.Label()
        Me.btn_order = New System.Windows.Forms.Button()
        Me.txt_amount = New System.Windows.Forms.TextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'rdb_large
        '
        Me.rdb_large.AutoSize = True
        Me.rdb_large.Location = New System.Drawing.Point(255, 152)
        Me.rdb_large.Name = "rdb_large"
        Me.rdb_large.Size = New System.Drawing.Size(73, 17)
        Me.rdb_large.TabIndex = 32
        Me.rdb_large.TabStop = True
        Me.rdb_large.Text = "Large size"
        Me.rdb_large.UseVisualStyleBackColor = True
        '
        'rdb_medium
        '
        Me.rdb_medium.AutoSize = True
        Me.rdb_medium.Location = New System.Drawing.Point(255, 92)
        Me.rdb_medium.Name = "rdb_medium"
        Me.rdb_medium.Size = New System.Drawing.Size(85, 17)
        Me.rdb_medium.TabIndex = 31
        Me.rdb_medium.TabStop = True
        Me.rdb_medium.Text = "Medium Size"
        Me.rdb_medium.UseVisualStyleBackColor = True
        '
        'rdb_small
        '
        Me.rdb_small.AutoSize = True
        Me.rdb_small.Location = New System.Drawing.Point(255, 33)
        Me.rdb_small.Name = "rdb_small"
        Me.rdb_small.Size = New System.Drawing.Size(73, 17)
        Me.rdb_small.TabIndex = 30
        Me.rdb_small.TabStop = True
        Me.rdb_small.Text = "Small Size"
        Me.rdb_small.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(245, 222)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(43, 13)
        Me.Label3.TabIndex = 29
        Me.Label3.Text = "Amount"
        '
        'lbl_menu_name
        '
        Me.lbl_menu_name.AutoSize = True
        Me.lbl_menu_name.Location = New System.Drawing.Point(121, 58)
        Me.lbl_menu_name.Name = "lbl_menu_name"
        Me.lbl_menu_name.Size = New System.Drawing.Size(13, 13)
        Me.lbl_menu_name.TabIndex = 28
        Me.lbl_menu_name.Text = "0"
        '
        'lbl_menu_id
        '
        Me.lbl_menu_id.AutoSize = True
        Me.lbl_menu_id.Location = New System.Drawing.Point(121, 31)
        Me.lbl_menu_id.Name = "lbl_menu_id"
        Me.lbl_menu_id.Size = New System.Drawing.Size(13, 13)
        Me.lbl_menu_id.TabIndex = 27
        Me.lbl_menu_id.Text = "0"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(66, 58)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(35, 13)
        Me.Label2.TabIndex = 26
        Me.Label2.Text = "Name"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(66, 31)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(21, 13)
        Me.Label1.TabIndex = 25
        Me.Label1.Text = "ID:"
        '
        'lbl_large
        '
        Me.lbl_large.AutoSize = True
        Me.lbl_large.Location = New System.Drawing.Point(389, 156)
        Me.lbl_large.Name = "lbl_large"
        Me.lbl_large.Size = New System.Drawing.Size(39, 13)
        Me.lbl_large.TabIndex = 24
        Me.lbl_large.Text = "Label3"
        '
        'lbl_medium
        '
        Me.lbl_medium.AutoSize = True
        Me.lbl_medium.Location = New System.Drawing.Point(389, 94)
        Me.lbl_medium.Name = "lbl_medium"
        Me.lbl_medium.Size = New System.Drawing.Size(39, 13)
        Me.lbl_medium.TabIndex = 23
        Me.lbl_medium.Text = "Label2"
        '
        'lbl_small
        '
        Me.lbl_small.AutoSize = True
        Me.lbl_small.Location = New System.Drawing.Point(389, 35)
        Me.lbl_small.Name = "lbl_small"
        Me.lbl_small.Size = New System.Drawing.Size(39, 13)
        Me.lbl_small.TabIndex = 22
        Me.lbl_small.Text = "Label1"
        '
        'btn_order
        '
        Me.btn_order.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_order.Location = New System.Drawing.Point(194, 297)
        Me.btn_order.Name = "btn_order"
        Me.btn_order.Size = New System.Drawing.Size(75, 23)
        Me.btn_order.TabIndex = 21
        Me.btn_order.Text = "Order"
        Me.btn_order.UseVisualStyleBackColor = True
        '
        'txt_amount
        '
        Me.txt_amount.Location = New System.Drawing.Point(292, 219)
        Me.txt_amount.Name = "txt_amount"
        Me.txt_amount.Size = New System.Drawing.Size(100, 20)
        Me.txt_amount.TabIndex = 20
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.PictureBox1.Location = New System.Drawing.Point(59, 87)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(145, 141)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 19
        Me.PictureBox1.TabStop = False
        '
        'Specific_Order
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(487, 341)
        Me.Controls.Add(Me.rdb_large)
        Me.Controls.Add(Me.rdb_medium)
        Me.Controls.Add(Me.rdb_small)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lbl_menu_name)
        Me.Controls.Add(Me.lbl_menu_id)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lbl_large)
        Me.Controls.Add(Me.lbl_medium)
        Me.Controls.Add(Me.lbl_small)
        Me.Controls.Add(Me.btn_order)
        Me.Controls.Add(Me.txt_amount)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "Specific_Order"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Specific_Order"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents rdb_large As RadioButton
    Friend WithEvents rdb_medium As RadioButton
    Friend WithEvents rdb_small As RadioButton
    Friend WithEvents Label3 As Label
    Friend WithEvents lbl_menu_name As Label
    Friend WithEvents lbl_menu_id As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents lbl_large As Label
    Friend WithEvents lbl_medium As Label
    Friend WithEvents lbl_small As Label
    Friend WithEvents btn_order As Button
    Friend WithEvents txt_amount As TextBox
    Friend WithEvents PictureBox1 As PictureBox
End Class
