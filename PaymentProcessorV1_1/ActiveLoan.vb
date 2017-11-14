Public Class ActiveLoan
    Public customerTble As DataTable
    Public LoansTble As DataTable
    Public PaymentsTble As DataTable
    Public activeCustID As Integer
    Public activeLoanID As Integer
    Private loading As Boolean
    Public Event clientSelected()
    Public Event loanSelected()
    Public Event PaymentProcessed()
    Public Sub GotPaid() Handles ProcessPayment1.processPay
        RaiseEvent PaymentProcessed()
    End Sub
    Private Sub ActiveCustomer_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles ActiveCustomer.CellClick
        If Not loading Then

            activeCustID = CInt(ActiveCustomer.SelectedRows.Item(0).Cells(0).Value.ToString)
            RaiseEvent clientSelected()


        End If
    End Sub

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        activeCustID = -1
        activeLoanID = -1
        loading = False
    End Sub

    Private Sub CustomersLoans_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles CustomersLoans.CellClick
        If Not loading Then
            If Not activeLoanID = CInt(CustomersLoans.SelectedRows.Item(0).Cells(0).Value.ToString) Then
                activeCustID = CInt(CustomersLoans.SelectedRows.Item(0).Cells(0).Value.ToString)
                RaiseEvent loanSelected()
            End If

        End If
    End Sub
End Class
