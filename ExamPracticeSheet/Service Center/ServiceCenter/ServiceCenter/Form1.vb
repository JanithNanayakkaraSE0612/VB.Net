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
End Class
