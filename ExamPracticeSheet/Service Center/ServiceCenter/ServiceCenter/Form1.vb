Public Class Form1
    Dim No, Na, BS, Ded, NS, Bo As String


    Private Sub btnExist_Click(sender As Object, e As EventArgs) Handles btnExist.Click
        Close()
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtNo.Text = ""
        txtName.Text = ""
        txtBS.Text = ""
        txtDed.Text = ""
        txtNS.Text = ""
        txtB.Text = ""
    End Sub

    Private Sub btnNetSalary_Click(sender As Object, e As EventArgs) Handles btnNetSalary.Click
        BS = Val(txtBS.Text)
        Ded = Val(txtDed.Text)
        NS = BS - Ded
        txtNS.Text = NS
    End Sub

    Private Sub btnBonus_Click(sender As Object, e As EventArgs) Handles btnBonus.Click
        BS = Val(txtBS.Text)
        Ded = Val(txtDed.Text)
        NS = BS - Ded
        If (NS < 10000) Then
            txtB.Text = "50"
        ElseIf (10000 >= NS) Then
            txtB.Text = "125"
        ElseIf (15000 >= NS) Then
            txtB.Text = "150"
        ElseIf (20000 >= NS) Then
            txtB.Text = "200"
        End If
    End Sub
End Class
