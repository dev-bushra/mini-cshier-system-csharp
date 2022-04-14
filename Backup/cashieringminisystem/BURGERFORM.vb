Public Class BURGERFORM

    Private Sub BURGERFORM_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            reloadDtg("Select pro_id as 'code number' ,Item_name as 'Item Name',Product_name as 'Product name',price as 'Price',size as 'Size' From foods_list where category = 'Burger'", dgburger)
            dgburger.Columns(0).Visible = False



        Catch ex As Exception
            ' MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged
        reloadDtg("Select pro_id as 'code number' ,Item_name as 'Item Name',Product_name as 'Product name',price as 'Price',size as 'Size' From foods_list where category = 'Burger' AND " & _
                  " (Product_name LIKE '%" & TextBox1.Text & "%' OR Item_name  LIKE '%" & TextBox1.Text & "%')", dgburger)
        dgburger.Columns(0).Visible = False
    End Sub

    Private Sub dgburger_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dgburger.DoubleClick
  
        Try
            casher(dgburger)
            Me.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class