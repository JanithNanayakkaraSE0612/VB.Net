Imports System.Diagnostics.Eventing.Reader

Public Class resultSheet
    Dim txtB, txtC, txtP, txtE, txtT, txtA, txtR, txtG As Double
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnAverage.Click
        txtB = Val(txtBio.Text)
        txtC = Val(txtChe.Text)
        txtP = Val(txtPhy.Text)
        txtE = Val(txtEng.Text)
        txtT = txtB + txtC + txtP + txtE
        txtA = txtT / 4
        txtAvg.Text = txtA
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

    Private Sub btnResult_Click(sender As Object, e As EventArgs) Handles btnResult.Click
        txtB = Val(txtBio.Text)
        txtC = Val(txtChe.Text)
        txtP = Val(txtPhy.Text)
        txtE = Val(txtEng.Text)
        txtT = txtB + txtC + txtP + txtE
        txtA = txtT / 4
        If (txtA > 50) Then
            txtRes.Text = "Pass"
        Else
            txtRes.Text = "Fail"
        End If
    End Sub

    Private Sub btnGrade_Click(sender As Object, e As EventArgs) Handles btnGrade.Click
        txtB = Val(txtBio.Text)
        txtC = Val(txtChe.Text)
        txtP = Val(txtPhy.Text)
        txtE = Val(txtEng.Text)
        txtT = txtB + txtC + txtP + txtE
        txtA = txtT / 4
        If (txtA >= 75) Then
            txtGrade.Text = "A"
        ElseIf (txtA >= 65) Then
            txtGrade.Text = "B"
        ElseIf If(txtA >= 50) Then
            txtGrade.Text = "C"
        Else
            txtGrade.Text = "F"
        End If
    End Sub
End Class
