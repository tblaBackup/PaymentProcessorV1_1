Public Class ProcessPayment
    Public Event processPay()
    Public Amount As Double
    Public loanID As Integer
    Public mrc As Double
    Public DateSubmitted As Date
   
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Amount = NumericUpDown1.Value
        DateSubmitted = DateTimePicker1.Text
        RaiseEvent processPay()
    End Sub
End Class
