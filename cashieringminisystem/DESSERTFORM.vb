Public Class DESSERTFORM

    Private Sub DESSERTFORM_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            reloadDtg("Select pro_id as 'code number' ,Item_name as 'Item Name',Product_name as 'Product name',price as 'Price',size as 'Size' From foods_list where category = 'Desert'", dgdessert)
            dgdessert.Columns(0).Visible = False



        Catch ex As Exception
            ' MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged
        reloadDtg("Select pro_id as 'code number' ,Item_name as 'Item Name',Product_name as 'Product name',price as 'Price',size as 'Size' From foods_list where category = 'Desert' AND " & _
                   " (Product_name LIKE '%" & TextBox1.Text & "%' OR Item_name  LIKE '%" & TextBox1.Text & "%')", dgdessert)
        dgdessert.Columns(0).Visible = False
    End Sub
 

    Private Sub dgdessert_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgdessert.DoubleClick
        casher(dgdessert)
        Me.Close()
    End Sub
End Class