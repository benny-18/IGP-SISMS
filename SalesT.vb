Public Class SalesT
    Private Sub btnInSummary_Click(sender As Object, e As EventArgs) Handles btnInSummary.Click
        Me.Hide()
        InSummary.Show()
    End Sub

    Private Sub btnProdList_Click(sender As Object, e As EventArgs) Handles btnProdList.Click
        Me.Hide()
        productslist.Show()
    End Sub

    Private Sub btnHome_Click(sender As Object, e As EventArgs) Handles btnHome.Click
        Me.Hide()
        Home.Show()
    End Sub

    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        Dim diagExit As DialogResult

        diagExit = MessageBox.Show("   Logout from current user?   ", "LNU IGP Trade Park SISMS v0.1", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If diagExit = DialogResult.Yes Then
            Me.Hide()

            Login.uname.Text = ""
            Login.pword.Text = ""
            Login.Show()
        End If
    End Sub
End Class