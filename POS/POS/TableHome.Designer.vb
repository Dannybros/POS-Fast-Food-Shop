﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class TableHome
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.ListView_menu = New System.Windows.Forms.ListView()
        Me.ImageListTable = New System.Windows.Forms.ImageList(Me.components)
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1200, 123)
        Me.Panel1.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(486, 34)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(229, 55)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Table List"
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.ListView_menu)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(0, 123)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1200, 527)
        Me.Panel2.TabIndex = 1
        '
        'ListView_menu
        '
        Me.ListView_menu.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ListView_menu.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.ListView_menu.HideSelection = False
        Me.ListView_menu.LargeImageList = Me.ImageListTable
        Me.ListView_menu.Location = New System.Drawing.Point(0, 0)
        Me.ListView_menu.Name = "ListView_menu"
        Me.ListView_menu.Size = New System.Drawing.Size(1200, 527)
        Me.ListView_menu.TabIndex = 1
        Me.ListView_menu.UseCompatibleStateImageBehavior = False
        '
        'ImageListTable
        '
        Me.ImageListTable.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit
        Me.ImageListTable.ImageSize = New System.Drawing.Size(200, 100)
        Me.ImageListTable.TransparentColor = System.Drawing.Color.Transparent
        '
        'TableHome
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1200, 650)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "TableHome"
        Me.Text = "TableHome"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents ImageListTable As ImageList
    Friend WithEvents Label1 As Label
    Friend WithEvents ListView_menu As ListView
End Class
