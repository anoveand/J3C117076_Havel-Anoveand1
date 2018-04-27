Public Class Form2

    Private Sub Label15_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtgrade.Click

    End Sub

    Private Sub hitung_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles hitung.Click
        Dim a, b, c, d, aa, bb, cc, dd, total As Integer
        Dim grade As String
        a = ntk.Text
        b = ntb.Text
        c = nuts.Text
        d = nuas.Text
        aa = btk.Text
        bb = btb.Text
        cc = buts.Text
        dd = buas.Text


        total = (a * aa) / 100 + (b * bb) / 100 + (c * cc) / 100 + (d * dd) / 100
        txttotal.Text = total

        If total > 80 Then
            grade = "A"
        ElseIf total > 70 Then
            grade = "B"
        ElseIf total > 60 Then
            grade = "C"
        ElseIf total > 50 Then
            grade = "D"
        ElseIf total < 50 Then
            grade = "E"
        End If
        txtgrade.Text = grade

        If aa + bb + cc + dd > 100 Then
            txttotal.Text = "..................."
            txtgrade.Text = "..................."
            MessageBox.Show("Tidak bisa memproses. Presentasi bobot melebihi 100%!", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)

        ElseIf aa + bb + cc + dd < 100 Then
            txttotal.Text = "..................."
            txtgrade.Text = "..................."
            MessageBox.Show("Tidak bisa memproses. Presentasi bobot kurang!", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If


    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        ntk.Clear()
        ntb.Clear()
        nuts.Clear()
        nuas.Clear()
        btk.Clear()
        btb.Clear()
        buts.Clear()
        buas.Clear()
        txttotal.Text = "..................."
        txtgrade.Text = "..................."
        ntk.Focus()

    End Sub
End Class