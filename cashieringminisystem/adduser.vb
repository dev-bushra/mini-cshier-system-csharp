Imports MySql.Data.MySqlClient
Public Class adduser


    Private Sub adduser_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            cbo_type.Text = "Owner"
              Call btn_New_Click(sender, e)
            If lbl_id.Text = "ID" Then

                btn_update.Enabled = False
                btn_delete.Enabled = False
                btn_saveuser.Enabled = True

            Else
                btn_saveuser.Enabled = True
                btn_update.Enabled = True
                btn_delete.Enabled = True
            End If



        Catch ex As Exception
            ' MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btn_saveuser_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_saveuser.Click
       
        create("insert into cashier_user (Firstname,Lastname,username,pass,User_status) " _
         & "values('" & TextBox1.Text & "','" & txt_name.Text & "','" & txt_username.Text _
         & "','" & txt_pass.Text & "','" & cbo_type.Text _
         & "')")
        TextBox1.Clear()
        txt_name.Clear()
        txt_username.Clear()
        txt_pass.Clear()

        Try
            cbo_type.Text = "Owner"
             Call btn_New_Click(sender, e)
            If lbl_id.Text = "ID" Then

                btn_update.Enabled = False
                btn_delete.Enabled = False
                btn_saveuser.Enabled = True

            Else
                btn_saveuser.Enabled = True
                btn_update.Enabled = True
                btn_delete.Enabled = True
            End If



        Catch ex As Exception
            ' MsgBox(ex.Message)
        End Try

    End Sub
    Public Sub deletes(ByVal sql As String)
        Try
            con.Open()
            With cmd
                .Connection = con
                .CommandText = sql
            End With
            'If MessageBox.Show("Do you want to delete this rocord?", "Delete" _
            '                     , MessageBoxButtons.YesNo, MessageBoxIcon.Information) _
            '                     = Windows.Forms.DialogResult.Yes Then
            result = cmd.ExecuteNonQuery
            If result = 0 Then
                MsgBox("Delete failed.")
            Else
                MsgBox("The data has been deleted in the database.")
            End If
            'End If
            con.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub


    Private Sub btn_update_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_update.Click
        Try
            If txt_name.Text = "" Or txt_pass.Text = "" Or txt_username.Text = "" Then

            Else
                updates("update cashier_user set Firstname = '" & TextBox1.Text & "',Lastname = '" & txt_name.Text & "',username= '" & txt_username.Text _
                            & "',pass='" & txt_pass.Text & "',User_status= '" & cbo_type.Text _
                            & "' where ID = " & lbl_id.Text)
                Call btn_New_Click(sender, e)
               
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

   
 
    Private Sub dtg_listUser_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles dtg_listUser.Click
        Try
            sql = "SELECT * FROM `cashier_user` WHERE `ID` = '" & dtg_listUser.CurrentRow.Cells(0).Value & "'"
            reloadtxt(sql)
            If dt.Rows.Count > 0 Then
                With dt.Rows(0)
                    lbl_id.Text = .Item("ID")
                    TextBox1.Text = .Item("Firstname")
                    txt_name.Text = .Item("Lastname")
                    txt_username.Text = .Item("username")
                    txt_pass.Text = .Item("pass")
                    cbo_type.Text = .Item("User_status")
                End With

            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btn_New_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_New.Click
        cleartext(grp_user)
        reloadDtg("Select ID as 'ID' ,Firstname as 'FirstName',Lastname as 'Lastname',username as 'UserName', User_status as 'User type' From cashier_user", dtg_listUser)
        dtg_listUser.Columns(0).Visible = False
    End Sub

    Private Sub btn_delete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_delete.Click
        sql = "DELETE FROM cashier_user WHERE ID = '" & dtg_listUser.CurrentRow.Cells(0).Value & "'"
        deletes(sql)
        Call btn_New_Click(sender, e)
    End Sub

    Private Sub txtsearch_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtsearch.TextChanged
        reloadDtg("Select ID as 'ID' ,Firstname as 'FirstName',Lastname as 'Lastname',username as 'UserName',  User_status as 'User type' From cashier_user WHERE ID LIKE '%" & txtsearch.Text & "%'", dtg_listUser)
        dtg_listUser.Columns(0).Visible = False
    End Sub

    Private Sub btnclose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnclose.Click
        Me.Close()
    End Sub
End Class