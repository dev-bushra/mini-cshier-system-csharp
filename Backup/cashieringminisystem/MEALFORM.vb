Public Class MEALFORM

    Private Sub Label8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub MEALFORM_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            reloadDtg("Select pro_id as 'code number' ,Item_name as 'Item Name',Product_name as 'Product name',price as 'Price',size as 'Size' From foods_list where category = 'Value Meal'", dgvalue)
            dgvalue.Columns(0).Visible = False



        Catch ex As Exception
            ' MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged
        Try
            reloadDtg("Select pro_id as 'code number' ,Item_name as 'Item Name',Product_name as 'Product name',price as 'Price',size as 'Size' From foods_list where category = 'Value Meal' AND " & _
                      " (Product_name LIKE '%" & TextBox1.Text & "%' OR Item_name  LIKE '%" & TextBox1.Text & "%')", dgvalue)
            dgvalue.Columns(0).Visible = False



        Catch ex As Exception
            ' MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub dgvalue_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvalue.CellContentClick

    End Sub

    Private Sub dgvalue_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgvalue.DoubleClick
        casher(dgvalue)
        Me.Close()
    End Sub
End Class