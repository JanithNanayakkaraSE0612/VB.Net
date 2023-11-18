Public Class resultSheet
    Dim txtB, txtC, txtP, txtE, txtT, txtA, txtR, txtG As Double
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnAverage.Click

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Close()

    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtAvg.Text = ""
        txtBio.Text = ""
        txtChe.Text = ""
        txtEng.Text = ""
        txtGrade.Text = ""
        txtPhy.Text = ""
        txtRes.Text = ""
        txtTot.Text = ""
    End Sub

    Private Sub btnTotal_Click(sender As Object, e As EventArgs) Handles btnTotal.Click
        txtB = Val(txtBio.Text)
        txtC = Val(txtChe.Text)
        txtP = Val(txtPhy.Text)
        txtE = Val(txtEng.Text)
        txtT = txtB + txtC + txtP + txtE
        txtTot.Text = txtT

    End Sub
End Class
