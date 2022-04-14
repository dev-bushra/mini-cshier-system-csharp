Public Class breakfastform

    Private Sub breakfastform_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            reloadDtg("Select pro_id as 'code number' ,Item_name as 'Item Name',Product_name as 'Product name',price as 'Price',size as 'Size' From foods_list where category = 'BreakFast'", gtd_food)
            gtd_food.Columns(0).Visible = False



        Catch ex As Exception
            ' MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub gtd_food_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles gtd_food.CellContentClick

    End Sub

    Private Sub gtd_food_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles gtd_food.DoubleClick
        casher(gtd_food)
        Me.Close()
    End Sub
End Class