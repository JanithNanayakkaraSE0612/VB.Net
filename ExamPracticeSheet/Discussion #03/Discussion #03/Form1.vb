Public Class frmSalary
    Dim bs, oh, otr, all1, all2, net As Single
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
        all1 = Val(txtAllow1.Text)
        all2 = Val(txtAllow2.Text)
        net = Val(txtNetSal.Text)
    End Sub
End Class
