Public Class Form1
    Dim sal, newSal As Single
    Private Sub btnExits_Click(sender As Object, e As EventArgs) Handles btnExits.Click
        Close()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        sal = Val(txtBS.Text)
        If rdoAcc.Checked = True Then
            newSal = sal * 105 / 100
        ElseIf rdoCom.Checked = True Then
            newSal = sal * 110 / 100
        ElseIf rdoPro.Checked = True Then
            newSal = sal * 115 / 100
        Else
            MsgBox("Please Select Department", vbOKCancel, "Error")


        End If
        txtNS.Text = newSal

    End Sub
End Class
