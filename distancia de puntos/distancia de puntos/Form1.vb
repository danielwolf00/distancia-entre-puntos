Public Class Form1
    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles txtX1.TextChanged

    End Sub

    Private Sub btnLimpair_Click(sender As Object, e As EventArgs) Handles btnLimpair.Click
        txtX1.Text = ""
        txtX2.Text = ""
        txtY1.Text = ""
        txtY2.Text = ""
        txtDistancia.Text = ""

    End Sub

    Private Sub btnCalcular_Click(sender As Object, e As EventArgs) Handles btnCalcular.Click
        Dim x1 As Double
        Dim x2 As Double
        Dim y1 As Double
        Dim y2 As Double

        x1 = txtX1.Text
        x2 = txtX2.Text
        y1 = txtY1.Text
        y2 = txtY2.Text

        txtDistancia.Text = Math.Round(Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2)), 4)

    End Sub

    Private Sub btnexit_Click(sender As Object, e As EventArgs) Handles btnexit.Click
        End
    End Sub
End Class
