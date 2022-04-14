Public Class add_product

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        OpenFileDialog1.Filter = "Picture Files (*)|*.bmp;*.gif;*.jpg"
        If OpenFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            photos.Image = Image.FromFile(OpenFileDialog1.FileName)
        End If
    End Sub

    Private Sub add_product_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            reloadDtg("Select  pro_id as 'code number' ,Item_name as 'Item Name',Product_name as 'Product name',price as 'Price',size as 'Size' From foods_list", dglist)

            dglist.Columns(0).Visible = False



        Catch ex As Exception
            ' MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles fsave.Click
        'MsgBox(OpenFileDialog1.SafeFileName)
        'MsgBox(imagename)
        Dim picname As String = ""
        If OpenFileDialog1.SafeFileName = "" Or OpenFileDialog1.SafeFileName = "OpenFileDialog1" Then
            picname = ""
        Else
            picname = OpenFileDialog1.SafeFileName
        End If



        create("insert into foods_list (pro_id,Item_name,Product_name,category,price,size,Photos)" _
        & "values('" & Idproduct.Text & "','" & Idcode.Text & "','" & foodname.Text _
        & "','" & cbocateg.Text & "',,'" & price.Text & "','" & fsize.Text & "','" & picname & "')")

        My.Computer.FileSystem.CopyFile( _
               OpenFileDialog1.FileName, _
               Application.StartupPath & "/pic/" & picname)
        '''''''''''''''''''''''''''''''''''''''''''
        photos.Image = Nothing
        Idproduct.Clear()
        Idcode.Clear()
        foodname.Clear()
        price.Clear()

        Try
            fsize.Text = "Small"
            reloadDtg("Select pro_id as 'Product ID' ,Item_name as 'Item code name',Product_name as 'Product name' ,category as 'Category',price as 'price',size as 'size' From foods_list", dglist)
            dglist.Columns(0).Visible = False
          


        Catch ex As Exception
            ' MsgBox(ex.Message)
        End Try
    End Sub
 

    Private Sub Idproduct_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Idproduct.TextChanged
       

    End Sub
    Dim imagename As String = ""
    Private Sub dglist_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dglist.DoubleClick
        Try

     
            reloadtxt("select * from foods_list  where `pro_id` = '" & dglist.CurrentRow.Cells(0).Value & "'")

            If dt.Rows.Count > 0 Then
                Idproduct.Text = dt.Rows(0).Item("pro_id")
                Idcode.Text = dt.Rows(0).Item("Item_name")
                foodname.Text = dt.Rows(0).Item("Product_name")
                cbocateg.Text = dt.Rows(0).Item("category")
                price.Text = dt.Rows(0).Item("price")
                fsize.Text = dt.Rows(0).Item("size")
                photos.Image = Image.FromFile(Application.StartupPath & "/pic/" & dt.Rows(0).Item("Photos"))
                imagename = dt.Rows(0).Item("Photos")

            End If




        Catch ex As Exception
            'MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub fupdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles fupdate.Click
        Try
            'MsgBox(OpenFileDialog1.SafeFileName)
            Dim picname As String = ""
            If OpenFileDialog1.SafeFileName = "" Or OpenFileDialog1.SafeFileName = "OpenFileDialog1" Then
                picname = imagename
            Else
                picname = OpenFileDialog1.SafeFileName
            End If

            updates("UPDATE foods_list SET Item_name='" & Idcode.Text & "',Product_name='" & foodname.Text _
            & "',category='" & cbocateg.Text & "',price='" & price.Text & "',size='" & fsize.Text & "',Photos= '" & picname & "' WHERE pro_id='" & Idproduct.Text & "'")
           
            Call fclear_Click(sender, e)

            'My.Computer.FileSystem.CopyFile( _
            ' OpenFileDialog1.FileName, _
            ' Application.StartupPath & "/pic/" & picname)

        Catch ex As Exception

        End Try
    End Sub

    Private Sub fclear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles fclear.Click
        Try
            photos.Image = Nothing
            cleartext(GroupBox1)
            reloadDtg("Select pro_id as 'Product ID' ,Item_name as 'Item code name',Product_name as 'Product name' ,category as 'Category',price as 'price',size as 'size' From foods_list", dglist)
            dglist.Columns(0).Visible = False

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub fdelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles fdelete.Click
        Try
            sql = "DELETE FROM foods_list WHERE pro_id = '" & Idproduct.Text & "'"
            deletes(sql)
            Call fclear_Click(sender, e)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub fclose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles fclose.Click
        Me.Close()
    End Sub

    Private Sub dglist_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dglist.CellContentClick

    End Sub
End Class