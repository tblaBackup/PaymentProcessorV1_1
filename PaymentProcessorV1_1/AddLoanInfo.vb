Public Class AddLoanInfo
    Public Event loanCreated()
    Private Sub CheckBox1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox1.CheckedChanged
        NumericUpDown4.Enabled = CheckBox1.Checked
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        RaiseEvent loanCreated()
    End Sub
End Class
