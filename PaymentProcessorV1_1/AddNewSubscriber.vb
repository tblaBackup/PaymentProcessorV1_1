Public Class AddNewSubscriber
    Public Event LoanSubmited()
    Public Event Cre8Client()
    Public Event cre8CustAccNum()
    Public CustID As Integer
    Public AccNum As String
    Public CustAccNum As Integer
    Public Sub ClientCreated() Handles BasicCustomerInformation1.clientSubmitted
        Dim opener As New Dialog3
        opener.FNameBox.Text = BasicCustomerInformation1.TextBox1.Text
        opener.LNameBox.Text = BasicCustomerInformation1.TextBox2.Text
        opener.Addr1Box.Text = BasicCustomerInformation1.TextBox3.Text
        opener.Addr2Box.Text = BasicCustomerInformation1.TextBox4.Text
        opener.Addr3Box.Text = BasicCustomerInformation1.TextBox5.Text
        RaiseEvent Cre8Client()
        Dim response = opener.ShowDialog
        Select Case response
            Case vbOK
                AccNum = opener.AccNum
                RaiseEvent cre8CustAccNum()
                AddLoanInfo1.Enabled = True
                AddLoanInfo1.TextBox1.Text = opener.DAccountNumberBox.Text

        End Select
    End Sub
    Public Sub LoanCreated() Handles AddLoanInfo1.loanCreated
        'Create Loan
        RaiseEvent LoanSubmited()
    End Sub
End Class
