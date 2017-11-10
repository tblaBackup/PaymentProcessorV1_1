Public Class BasicCustomerInformation
    Public Event clientSubmitted()
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        RaiseEvent clientSubmitted()
    End Sub
End Class
