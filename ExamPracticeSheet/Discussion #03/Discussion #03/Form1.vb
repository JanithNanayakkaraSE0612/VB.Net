Public Class frmSalary
    Dim bs, oh, otr, all1, all2, otamt, net As Single
    Dim sex As String
    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles txtOH.TextChanged

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles txtBasicSalary.TextChanged

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Close()
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtBasicSalary.Text = ""
        txtOH.Text = ""
        txtSex.Text = ""
        txtOR.Text = ""
        txtAllow1.Text = ""
        txtAllow2.Text = ""
        txtNetSal.Text = ""
    End Sub

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        bs = Val(txtBasicSalary.Text)
        oh = Val(txtOH.Text)
        sex = txtSex.Text
        otr = bs / 240
        If bs > 40000 Then
            all1 = bs * 10 / 100
        ElseIf bs > 25000 Then
            all1 = bs * 5 / 100
        Else
            all1 = 500
        End If

        If sex = "M" Then
            all2 = 2000
        Else
            all2 = 1000
        End If
        otamt = oh * otr
        txtOR.Text = otr
        txtAllow1.Text = all1
        txtAllow2.Text = all2
        net = bs + otamt + all1 + all2
        txtNetSal.Text = net
    End Sub
End Class
