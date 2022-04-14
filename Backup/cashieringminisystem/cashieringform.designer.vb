<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class cashieringform
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(cashieringform))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.dtgcart = New System.Windows.Forms.DataGridView
        Me.Label13 = New System.Windows.Forms.Label
        Me.txtoverall = New System.Windows.Forms.TextBox
        Me.btnbooks = New System.Windows.Forms.Button
        Me.Button2 = New System.Windows.Forms.Button
        Me.Label15 = New System.Windows.Forms.Label
        Me.txtchange = New System.Windows.Forms.TextBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.txtvat = New System.Windows.Forms.TextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.txtamount = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.txttotprice = New System.Windows.Forms.TextBox
        Me.txtqty = New System.Windows.Forms.TextBox
        Me.txtprice = New System.Windows.Forms.TextBox
        Me.txtpname = New System.Windows.Forms.TextBox
        Me.lblproductid = New System.Windows.Forms.Label
        Me.Button1 = New System.Windows.Forms.Button
        Me.btnautonumber = New System.Windows.Forms.Button
        Me.btnreports = New System.Windows.Forms.Button
        Me.btnsetting = New System.Windows.Forms.Button
        Me.btnuser = New System.Windows.Forms.Button
        Me.btntrans = New System.Windows.Forms.Button
        Me.PictureBox2 = New System.Windows.Forms.PictureBox
        Me.PictureBox3 = New System.Windows.Forms.PictureBox
        Me.PictureBox4 = New System.Windows.Forms.PictureBox
        Me.PictureBox5 = New System.Windows.Forms.PictureBox
        Me.PictureBox6 = New System.Windows.Forms.PictureBox
        Me.PictureBox8 = New System.Windows.Forms.PictureBox
        Me.dtgorder = New System.Windows.Forms.DataGridView
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        Me.Label12 = New System.Windows.Forms.Label
        Me.Label14 = New System.Windows.Forms.Label
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.btnlogout = New System.Windows.Forms.Button
        Me.GroupBox1.SuspendLayout()
        CType(Me.dtgcart, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtgorder, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Gray
        Me.GroupBox1.Controls.Add(Me.dtgcart)
        Me.GroupBox1.Controls.Add(Me.Label13)
        Me.GroupBox1.Controls.Add(Me.txtoverall)
        Me.GroupBox1.Controls.Add(Me.btnbooks)
        Me.GroupBox1.Controls.Add(Me.Button2)
        Me.GroupBox1.Controls.Add(Me.Label15)
        Me.GroupBox1.Controls.Add(Me.txtchange)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.txtvat)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.txtamount)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txttotprice)
        Me.GroupBox1.Controls.Add(Me.txtqty)
        Me.GroupBox1.Controls.Add(Me.txtprice)
        Me.GroupBox1.Controls.Add(Me.txtpname)
        Me.GroupBox1.Controls.Add(Me.lblproductid)
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.btnautonumber)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(436, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(581, 334)
        Me.GroupBox1.TabIndex = 26
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "CASHIERING DETAILS"
        '
        'dtgcart
        '
        Me.dtgcart.AllowUserToAddRows = False
        Me.dtgcart.AllowUserToDeleteRows = False
        Me.dtgcart.AllowUserToResizeColumns = False
        Me.dtgcart.AllowUserToResizeRows = False
        Me.dtgcart.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dtgcart.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dtgcart.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        Me.dtgcart.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtgcart.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.dtgcart.Location = New System.Drawing.Point(6, 153)
        Me.dtgcart.Name = "dtgcart"
        Me.dtgcart.RowHeadersVisible = False
        Me.dtgcart.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dtgcart.Size = New System.Drawing.Size(565, 85)
        Me.dtgcart.TabIndex = 49
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(19, 249)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(111, 16)
        Me.Label13.TabIndex = 51
        Me.Label13.Text = "Over All Price :"
        '
        'txtoverall
        '
        Me.txtoverall.Enabled = False
        Me.txtoverall.Location = New System.Drawing.Point(136, 241)
        Me.txtoverall.Multiline = True
        Me.txtoverall.Name = "txtoverall"
        Me.txtoverall.Size = New System.Drawing.Size(159, 38)
        Me.txtoverall.TabIndex = 50
        '
        'btnbooks
        '
        Me.btnbooks.BackColor = System.Drawing.Color.Blue
        Me.btnbooks.Location = New System.Drawing.Point(463, 286)
        Me.btnbooks.Name = "btnbooks"
        Me.btnbooks.Size = New System.Drawing.Size(108, 37)
        Me.btnbooks.TabIndex = 19
        Me.btnbooks.Text = "SAVE"
        Me.btnbooks.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.Blue
        Me.Button2.Location = New System.Drawing.Point(395, 109)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(176, 38)
        Me.Button2.TabIndex = 30
        Me.Button2.Text = "Add to Cart"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(32, 296)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(98, 16)
        Me.Label15.TabIndex = 29
        Me.Label15.Text = "Amount Pay :"
        '
        'txtchange
        '
        Me.txtchange.Enabled = False
        Me.txtchange.Location = New System.Drawing.Point(380, 241)
        Me.txtchange.Multiline = True
        Me.txtchange.Name = "txtchange"
        Me.txtchange.Size = New System.Drawing.Size(176, 38)
        Me.txtchange.TabIndex = 18
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(309, 248)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(65, 16)
        Me.Label7.TabIndex = 24
        Me.Label7.Text = "Change:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(354, 87)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(35, 16)
        Me.Label8.TabIndex = 26
        Me.Label8.Text = "Vat:"
        '
        'txtvat
        '
        Me.txtvat.Enabled = False
        Me.txtvat.Location = New System.Drawing.Point(395, 65)
        Me.txtvat.Multiline = True
        Me.txtvat.Name = "txtvat"
        Me.txtvat.Size = New System.Drawing.Size(176, 38)
        Me.txtvat.TabIndex = 25
        Me.txtvat.Text = "12%"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(301, 37)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(88, 16)
        Me.Label6.TabIndex = 23
        Me.Label6.Text = "Total Price:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(21, 222)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(0, 16)
        Me.Label5.TabIndex = 22
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(45, 120)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(68, 16)
        Me.Label4.TabIndex = 21
        Me.Label4.Text = "Quantity:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(65, 87)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(48, 16)
        Me.Label3.TabIndex = 20
        Me.Label3.Text = "Price:"
        '
        'txtamount
        '
        Me.txtamount.Location = New System.Drawing.Point(136, 286)
        Me.txtamount.Multiline = True
        Me.txtamount.Name = "txtamount"
        Me.txtamount.Size = New System.Drawing.Size(159, 38)
        Me.txtamount.TabIndex = 28
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(11, 40)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(107, 16)
        Me.Label2.TabIndex = 19
        Me.Label2.Text = "Product name:"
        '
        'txttotprice
        '
        Me.txttotprice.Enabled = False
        Me.txttotprice.Location = New System.Drawing.Point(395, 18)
        Me.txttotprice.Multiline = True
        Me.txttotprice.Name = "txttotprice"
        Me.txttotprice.Size = New System.Drawing.Size(176, 38)
        Me.txttotprice.TabIndex = 17
        '
        'txtqty
        '
        Me.txtqty.Location = New System.Drawing.Point(119, 109)
        Me.txtqty.Multiline = True
        Me.txtqty.Name = "txtqty"
        Me.txtqty.Size = New System.Drawing.Size(176, 38)
        Me.txtqty.TabIndex = 16
        '
        'txtprice
        '
        Me.txtprice.Enabled = False
        Me.txtprice.Location = New System.Drawing.Point(119, 65)
        Me.txtprice.Multiline = True
        Me.txtprice.Name = "txtprice"
        Me.txtprice.Size = New System.Drawing.Size(176, 38)
        Me.txtprice.TabIndex = 15
        '
        'txtpname
        '
        Me.txtpname.Enabled = False
        Me.txtpname.Location = New System.Drawing.Point(119, 21)
        Me.txtpname.Multiline = True
        Me.txtpname.Name = "txtpname"
        Me.txtpname.Size = New System.Drawing.Size(176, 35)
        Me.txtpname.TabIndex = 14
        '
        'lblproductid
        '
        Me.lblproductid.AutoSize = True
        Me.lblproductid.Location = New System.Drawing.Point(243, 24)
        Me.lblproductid.Name = "lblproductid"
        Me.lblproductid.Size = New System.Drawing.Size(21, 16)
        Me.lblproductid.TabIndex = 30
        Me.lblproductid.Text = "id"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Red
        Me.Button1.Location = New System.Drawing.Point(329, 180)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(102, 26)
        Me.Button1.TabIndex = 27
        Me.Button1.Text = "CANCEL"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'btnautonumber
        '
        Me.btnautonumber.BackColor = System.Drawing.Color.Lime
        Me.btnautonumber.Location = New System.Drawing.Point(371, 287)
        Me.btnautonumber.Name = "btnautonumber"
        Me.btnautonumber.Size = New System.Drawing.Size(86, 37)
        Me.btnautonumber.TabIndex = 25
        Me.btnautonumber.Text = "NEW"
        Me.btnautonumber.UseVisualStyleBackColor = False
        '
        'btnreports
        '
        Me.btnreports.Location = New System.Drawing.Point(284, 181)
        Me.btnreports.Name = "btnreports"
        Me.btnreports.Size = New System.Drawing.Size(73, 26)
        Me.btnreports.TabIndex = 24
        Me.btnreports.Text = "Reports"
        Me.btnreports.UseVisualStyleBackColor = True
        '
        'btnsetting
        '
        Me.btnsetting.Location = New System.Drawing.Point(200, 181)
        Me.btnsetting.Name = "btnsetting"
        Me.btnsetting.Size = New System.Drawing.Size(82, 26)
        Me.btnsetting.TabIndex = 23
        Me.btnsetting.Text = "Settings"
        Me.btnsetting.UseVisualStyleBackColor = True
        '
        'btnuser
        '
        Me.btnuser.Location = New System.Drawing.Point(162, 224)
        Me.btnuser.Name = "btnuser"
        Me.btnuser.Size = New System.Drawing.Size(142, 26)
        Me.btnuser.TabIndex = 22
        Me.btnuser.Text = "Manage User"
        Me.btnuser.UseVisualStyleBackColor = True
        '
        'btntrans
        '
        Me.btntrans.Location = New System.Drawing.Point(15, 224)
        Me.btntrans.Name = "btntrans"
        Me.btntrans.Size = New System.Drawing.Size(141, 26)
        Me.btntrans.TabIndex = 21
        Me.btntrans.Text = "Foods"
        Me.btntrans.UseVisualStyleBackColor = True
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.Green
        Me.PictureBox2.BackgroundImage = CType(resources.GetObject("PictureBox2.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(15, 12)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(415, 206)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 30
        Me.PictureBox2.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Image)
        Me.PictureBox3.Location = New System.Drawing.Point(12, 258)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(115, 109)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 31
        Me.PictureBox3.TabStop = False
        '
        'PictureBox4
        '
        Me.PictureBox4.Image = CType(resources.GetObject("PictureBox4.Image"), System.Drawing.Image)
        Me.PictureBox4.Location = New System.Drawing.Point(146, 258)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(115, 109)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox4.TabIndex = 32
        Me.PictureBox4.TabStop = False
        '
        'PictureBox5
        '
        Me.PictureBox5.Image = CType(resources.GetObject("PictureBox5.Image"), System.Drawing.Image)
        Me.PictureBox5.Location = New System.Drawing.Point(284, 258)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(115, 109)
        Me.PictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox5.TabIndex = 33
        Me.PictureBox5.TabStop = False
        '
        'PictureBox6
        '
        Me.PictureBox6.Image = CType(resources.GetObject("PictureBox6.Image"), System.Drawing.Image)
        Me.PictureBox6.Location = New System.Drawing.Point(39, 402)
        Me.PictureBox6.Name = "PictureBox6"
        Me.PictureBox6.Size = New System.Drawing.Size(170, 109)
        Me.PictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox6.TabIndex = 34
        Me.PictureBox6.TabStop = False
        '
        'PictureBox8
        '
        Me.PictureBox8.Image = CType(resources.GetObject("PictureBox8.Image"), System.Drawing.Image)
        Me.PictureBox8.Location = New System.Drawing.Point(235, 400)
        Me.PictureBox8.Name = "PictureBox8"
        Me.PictureBox8.Size = New System.Drawing.Size(164, 111)
        Me.PictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox8.TabIndex = 36
        Me.PictureBox8.TabStop = False
        '
        'dtgorder
        '
        Me.dtgorder.AllowUserToAddRows = False
        Me.dtgorder.AllowUserToDeleteRows = False
        Me.dtgorder.AllowUserToResizeColumns = False
        Me.dtgorder.AllowUserToResizeRows = False
        Me.dtgorder.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dtgorder.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dtgorder.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        Me.dtgorder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtgorder.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.dtgorder.Location = New System.Drawing.Point(14, 18)
        Me.dtgorder.Name = "dtgorder"
        Me.dtgorder.RowHeadersVisible = False
        Me.dtgorder.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dtgorder.Size = New System.Drawing.Size(557, 152)
        Me.dtgorder.TabIndex = 40
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(27, 370)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(65, 15)
        Me.Label9.TabIndex = 41
        Me.Label9.Text = "BURGER"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(170, 370)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(59, 15)
        Me.Label10.TabIndex = 42
        Me.Label10.Text = "DRINKS"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(314, 370)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(71, 15)
        Me.Label11.TabIndex = 43
        Me.Label11.Text = "DESSERT"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(291, 526)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(85, 15)
        Me.Label12.TabIndex = 44
        Me.Label12.Text = "BREAKFAST"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(56, 526)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(100, 15)
        Me.Label14.TabIndex = 46
        Me.Label14.Text = "VALUE MEALS"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.dtgorder)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.Color.Lime
        Me.GroupBox2.Location = New System.Drawing.Point(436, 362)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(581, 179)
        Me.GroupBox2.TabIndex = 47
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "List of costumer order"
        '
        'btnlogout
        '
        Me.btnlogout.Location = New System.Drawing.Point(310, 224)
        Me.btnlogout.Name = "btnlogout"
        Me.btnlogout.Size = New System.Drawing.Size(111, 26)
        Me.btnlogout.TabIndex = 48
        Me.btnlogout.Text = "Logout"
        Me.btnlogout.UseVisualStyleBackColor = True
        '
        'cashieringform
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Gray
        Me.ClientSize = New System.Drawing.Size(1040, 553)
        Me.Controls.Add(Me.btnlogout)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.PictureBox8)
        Me.Controls.Add(Me.PictureBox6)
        Me.Controls.Add(Me.PictureBox5)
        Me.Controls.Add(Me.PictureBox4)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnuser)
        Me.Controls.Add(Me.btntrans)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.btnreports)
        Me.Controls.Add(Me.btnsetting)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.Name = "cashieringform"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.dtgcart, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtgorder, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtvat As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtchange As System.Windows.Forms.TextBox
    Friend WithEvents txttotprice As System.Windows.Forms.TextBox
    Friend WithEvents txtqty As System.Windows.Forms.TextBox
    Friend WithEvents txtprice As System.Windows.Forms.TextBox
    Friend WithEvents txtpname As System.Windows.Forms.TextBox
    Friend WithEvents btnreports As System.Windows.Forms.Button
    Friend WithEvents btnautonumber As System.Windows.Forms.Button
    Friend WithEvents btnsetting As System.Windows.Forms.Button
    Friend WithEvents btnuser As System.Windows.Forms.Button
    Friend WithEvents btntrans As System.Windows.Forms.Button
    Friend WithEvents btnbooks As System.Windows.Forms.Button
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox4 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox5 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox6 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox8 As System.Windows.Forms.PictureBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents dtgorder As System.Windows.Forms.DataGridView
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents btnlogout As System.Windows.Forms.Button
    Friend WithEvents txtamount As System.Windows.Forms.TextBox
    Friend WithEvents lblproductid As System.Windows.Forms.Label
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents txtoverall As System.Windows.Forms.TextBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents dtgcart As System.Windows.Forms.DataGridView
End Class
