Public Class Form1

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Try

            reloadtxt("SELECT * FROM cashier_user WHERE username= '" & TextBox1.Text & "' and pass = '" & TextBox2.Text & "'")

            If dt.Rows.Count > 0 Then
                If dt.Rows(0).Item("User_status") = "Owner" Then
                    MsgBox("Welcome " & dt.Rows(0).Item("User_status"))

                    Me.Hide()
                    With cashieringform
                        .Show()
                    End With

                ElseIf dt.Rows(0).Item("User_status") = "cashier" Then
                    MsgBox("Welcome " & dt.Rows(0).Item("User_status"))
                    Me.Hide()
                    With cashieringform
                        .Show()

                   

                        '.Size = New System.Drawing.Size(322, 298)
                    End With

                End If

            Else
                MsgBox("Acount doest not exits!", MsgBoxStyle.Information)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        da.Dispose()
    End Sub
   
    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Me.Close()
    End Sub
End Class
