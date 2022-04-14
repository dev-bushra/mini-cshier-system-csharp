<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class add_product
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
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Idproduct = New System.Windows.Forms.TextBox
        Me.Idcode = New System.Windows.Forms.TextBox
        Me.foodname = New System.Windows.Forms.TextBox
        Me.price = New System.Windows.Forms.TextBox
        Me.fsize = New System.Windows.Forms.ComboBox
        Me.photos = New System.Windows.Forms.PictureBox
        Me.Button1 = New System.Windows.Forms.Button
        Me.fsave = New System.Windows.Forms.Button
        Me.fupdate = New System.Windows.Forms.Button
        Me.fdelete = New System.Windows.Forms.Button
        Me.fclear = New System.Windows.Forms.Button
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.cbocateg = New System.Windows.Forms.ComboBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.dglist = New System.Windows.Forms.DataGridView
        Me.fclose = New System.Windows.Forms.Button
        CType(Me.photos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.dglist, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(219, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(145, 25)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "ADD FOODS"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(68, 31)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(84, 16)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Product ID:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(28, 63)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(124, 16)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Item Code name:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(62, 94)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(90, 16)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Food name:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(104, 159)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(48, 16)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Price:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(104, 200)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(42, 16)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Size:"
        '
        'Idproduct
        '
        Me.Idproduct.Location = New System.Drawing.Point(158, 30)
        Me.Idproduct.Name = "Idproduct"
        Me.Idproduct.Size = New System.Drawing.Size(195, 20)
        Me.Idproduct.TabIndex = 6
        '
        'Idcode
        '
        Me.Idcode.Location = New System.Drawing.Point(158, 63)
        Me.Idcode.Name = "Idcode"
        Me.Idcode.Size = New System.Drawing.Size(195, 20)
        Me.Idcode.TabIndex = 7
        '
        'foodname
        '
        Me.foodname.Location = New System.Drawing.Point(158, 93)
        Me.foodname.Name = "foodname"
        Me.foodname.Size = New System.Drawing.Size(195, 20)
        Me.foodname.TabIndex = 8
        '
        'price
        '
        Me.price.Location = New System.Drawing.Point(158, 155)
        Me.price.Name = "price"
        Me.price.Size = New System.Drawing.Size(195, 20)
        Me.price.TabIndex = 9
        '
        'fsize
        '
        Me.fsize.FormattingEnabled = True
        Me.fsize.Items.AddRange(New Object() {"Small", "Medium", "Large"})
        Me.fsize.Location = New System.Drawing.Point(158, 195)
        Me.fsize.Name = "fsize"
        Me.fsize.Size = New System.Drawing.Size(195, 21)
        Me.fsize.TabIndex = 45
        '
        'photos
        '
        Me.photos.Location = New System.Drawing.Point(390, 30)
        Me.photos.Name = "photos"
        Me.photos.Size = New System.Drawing.Size(153, 134)
        Me.photos.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.photos.TabIndex = 46
        Me.photos.TabStop = False
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(390, 171)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(153, 23)
        Me.Button1.TabIndex = 47
        Me.Button1.Text = "Browse"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'fsave
        '
        Me.fsave.Location = New System.Drawing.Point(20, 272)
        Me.fsave.Name = "fsave"
        Me.fsave.Size = New System.Drawing.Size(96, 23)
        Me.fsave.TabIndex = 48
        Me.fsave.Text = "Save"
        Me.fsave.UseVisualStyleBackColor = True
        '
        'fupdate
        '
        Me.fupdate.Location = New System.Drawing.Point(122, 272)
        Me.fupdate.Name = "fupdate"
        Me.fupdate.Size = New System.Drawing.Size(105, 23)
        Me.fupdate.TabIndex = 49
        Me.fupdate.Text = "Update"
        Me.fupdate.UseVisualStyleBackColor = True
        '
        'fdelete
        '
        Me.fdelete.Location = New System.Drawing.Point(359, 272)
        Me.fdelete.Name = "fdelete"
        Me.fdelete.Size = New System.Drawing.Size(113, 23)
        Me.fdelete.TabIndex = 50
        Me.fdelete.Text = "Delete"
        Me.fdelete.UseVisualStyleBackColor = True
        '
        'fclear
        '
        Me.fclear.Location = New System.Drawing.Point(233, 272)
        Me.fclear.Name = "fclear"
        Me.fclear.Size = New System.Drawing.Size(120, 23)
        Me.fclear.TabIndex = 51
        Me.fclear.Text = "Clear"
        Me.fclear.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.GroupBox1.Controls.Add(Me.cbocateg)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.photos)
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.Idproduct)
        Me.GroupBox1.Controls.Add(Me.Idcode)
        Me.GroupBox1.Controls.Add(Me.fsize)
        Me.GroupBox1.Controls.Add(Me.foodname)
        Me.GroupBox1.Controls.Add(Me.price)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.GroupBox1.Location = New System.Drawing.Point(17, 37)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(565, 229)
        Me.GroupBox1.TabIndex = 53
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Inter Food Informations"
        '
        'cbocateg
        '
        Me.cbocateg.FormattingEnabled = True
        Me.cbocateg.Items.AddRange(New Object() {"Burger", "Drinks", "Value Meal", "BreakFast", "Desert"})
        Me.cbocateg.Location = New System.Drawing.Point(158, 119)
        Me.cbocateg.Name = "cbocateg"
        Me.cbocateg.Size = New System.Drawing.Size(195, 21)
        Me.cbocateg.TabIndex = 49
        Me.cbocateg.Text = "-----Select-----"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(68, 120)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(79, 16)
        Me.Label7.TabIndex = 48
        Me.Label7.Text = "Category :"
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.dglist)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(17, 311)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(576, 194)
        Me.GroupBox2.TabIndex = 54
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "List of Product"
        '
        'dglist
        '
        Me.dglist.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dglist.Location = New System.Drawing.Point(6, 21)
        Me.dglist.Name = "dglist"
        Me.dglist.Size = New System.Drawing.Size(564, 158)
        Me.dglist.TabIndex = 0
        '
        'fclose
        '
        Me.fclose.Location = New System.Drawing.Point(478, 272)
        Me.fclose.Name = "fclose"
        Me.fclose.Size = New System.Drawing.Size(104, 23)
        Me.fclose.TabIndex = 55
        Me.fclose.Text = "Close"
        Me.fclose.UseVisualStyleBackColor = True
        '
        'add_product
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Silver
        Me.ClientSize = New System.Drawing.Size(604, 517)
        Me.Controls.Add(Me.fclose)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.fclear)
        Me.Controls.Add(Me.fdelete)
        Me.Controls.Add(Me.fupdate)
        Me.Controls.Add(Me.fsave)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.Name = "add_product"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Product"
        CType(Me.photos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.dglist, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Idproduct As System.Windows.Forms.TextBox
    Friend WithEvents Idcode As System.Windows.Forms.TextBox
    Friend WithEvents foodname As System.Windows.Forms.TextBox
    Friend WithEvents price As System.Windows.Forms.TextBox
    Friend WithEvents fsize As System.Windows.Forms.ComboBox
    Friend WithEvents photos As System.Windows.Forms.PictureBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents fsave As System.Windows.Forms.Button
    Friend WithEvents fupdate As System.Windows.Forms.Button
    Friend WithEvents fdelete As System.Windows.Forms.Button
    Friend WithEvents fclear As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents dglist As System.Windows.Forms.DataGridView
    Friend WithEvents fclose As System.Windows.Forms.Button
    Friend WithEvents cbocateg As System.Windows.Forms.ComboBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
End Class
