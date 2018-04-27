Public Class Form1

    Private Sub hitung_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles hitung.Click
        Dim nama As String
        Dim a, b, c As Integer
        nama = txtnama.Text
        a = n1.Text
        b = n2.Text
        c = n3.Text
        r.Text = (a + b + c) / 3

        If r.Text > 80 Then
            h.Text = "Rp 10 juta"
        ElseIf r.Text > 70 Then
            h.Text = "Rp 7,5 juta"
        Else
            h.Text = "Sertifikat"
        End If

    End Sub

    Private Sub ListBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub ulang_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ulang.Click
        txtnama.Clear()
        n1.Clear()
        n2.Clear()
        n3.Clear()
        r.Text = "................................."
        h.Text = "................................."
        txtnama.Focus()
    End Sub

    Private Sub nextt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles nextt.Click
        Form2.Show()
        Me.Hide()
    End Sub
End Class
