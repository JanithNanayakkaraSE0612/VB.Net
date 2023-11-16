Public Class frmSalary
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
End Class
