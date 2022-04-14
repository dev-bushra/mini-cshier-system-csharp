Public Class cashieringform
    Dim productid As String = ""

    Private Sub cashieringform_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        Form1.Show()
        Form1.Focus()
    End Sub
    Private Sub cashieringform_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        sql = "SELECT  Product_name as 'Product name',price as 'Price', `category` as 'Category',  `QTY` as 'Quantity', `TOTALPRICE` as 'TotalPrice' FROM `foods_list`  f,`tblpayments` p WHERE f.`pro_id`=p.`pro_id`"
        reloadDtg(sql, dtgorder)
        dtgcart.ColumnCount = 4
        dtgcart.Columns(0).Name = "Product Id"
        dtgcart.Columns(1).Name = "Product Name"
        dtgcart.Columns(2).Name = "Quantity"
        dtgcart.Columns(3).Name = "Total Price"
    End Sub

    Private Sub Label7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label7.Click

    End Sub

    Private Sub PictureBox3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox3.Click
        BURGERFORM.Show()
    End Sub

    Private Sub PictureBox4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox4.Click
        DRINKSFORM.Show()
    End Sub

    Private Sub PictureBox5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox5.Click
        DESSERTFORM.Show()
    End Sub

    Private Sub PictureBox6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox6.Click
        MEALFORM.Show()
    End Sub

    Private Sub PictureBox8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox8.Click
        breakfastform.Show()
    End Sub

    Private Sub btnuser_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnuser.Click
        adduser.Show()
    End Sub

    Private Sub btntrans_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btntrans.Click
        add_product.Show()
    End Sub

   
    Private Sub txtqty_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtqty.TextChanged
        Try
            If txtqty.Text = "" Then
                txttotprice.Clear()
            Else
                Dim wvat As Double
                wvat = Val(txtprice.Text) * 0.12
                txttotprice.Text = Val(txtprice.Text) * Val(txtqty.Text) + wvat
            End If
          
        Catch ex As Exception

        End Try
    End Sub

    Private Sub txtamount_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtamount.TextChanged
        Try
            If txtamount.Text = "" Then
                txtchange.Text = ""
            Else
                txtchange.Text = Double.Parse(txtamount.Text) - Double.Parse(txtoverall.Text)
            End If

        Catch ex As Exception

        End Try
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click

        Try
            txtoverall.Text = Val(txtoverall.Text) + Val(txttotprice.Text)
        Catch ex As Exception

        End Try

 
        Dim row As String() = New String() {lblproductid.Text, txtpname.Text, _
                                           txtqty.Text, _
                                           txttotprice.Text}
        dtgcart.Rows.Add(row)




    End Sub

 
    Private Sub dtgcart_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles dtgcart.DoubleClick
        Try
            dtgcart.Rows.Remove(dtgcart.CurrentRow)
            txtoverall.Text = Double.Parse(txtoverall.Text) - dtgcart.CurrentRow.Cells(2).Value
        Catch ex As Exception
            txtoverall.Text = ""
            'MsgBox(ex.Message)
        End Try
    End Sub
 
    Private Sub btnbooks_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnbooks.Click
        Try

            sql = "SELECT concat(`STRT`, `END`) FROM `autonum` WHERE  `ID`=1"
            reloadtxt(sql)


            For Each row As DataGridViewRow In dtgcart.Rows
                sql = "INSERT INTO `tblpayments` (`PAYMENTID`,`pro_id`,  `QTY`, `TOTALPRICE`) " _
                & " values ('" & dt.Rows(0).Item(0) & "','" & row.Cells(0).Value & "', '" & row.Cells(2).Value & "','" _
                & row.Cells(3).Value & "')"
                createNomsg(sql)
            Next





            sql = "INSERT INTO `tblsummary` (`PAYMENTID`, `OVERALLPRICE`, `CHANGE`) " _
            & " VALUES ('" & dt.Rows(0).Item(0) & "','" & txtoverall.Text & "','" & txtchange.Text & "')"
            create(sql)

            sql = "SELECT s.`PAYMENTID`, `Item_name`, `Product_name`, `price` `QTY`, `TOTALPRICE`,`OVERALLPRICE`, `CHANGE` FROM  `foods_list` f,`tblpayments` p,`tblsummary`  s WHERE f.`pro_id`=p.`pro_id` AND s.`PAYMENTID`=p.`PAYMENTID`  AND p.`PAYMENTID` ='" & dt.Rows(0).Item(0) & "'"
            reports(sql, "receipt", receipt.CrystalReportViewer1)

            sql = "UPDATE `autonum` SET `END`=`END`+ `INC` WHERE  `ID`=1"
            createNomsg(sql)

            sql = "SELECT  Product_name as 'Product name',price as 'Price', `category` as 'Category',  `QTY` as 'Quantity', `TOTALPRICE` as 'TotalPrice' FROM `foods_list`  f,`tblpayments` p WHERE f.`pro_id`=p.`pro_id`"
            reloadDtg(sql, dtgorder)

            cleartext(GroupBox1)
            dtgcart.Rows.Clear()

     
            receipt.Show()
            receipt.Focus()
        Catch ex As Exception

        End Try



    End Sub

    Private Sub btnlogout_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnlogout.Click
        Me.Close()
        Form1.Show()
        Form1.Focus()
    End Sub

    Private Sub btnautonumber_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnautonumber.Click
        cleartext(GroupBox1)
        dtgcart.Rows.Clear()
        txtvat.Text = "12%"
    End Sub
End Class