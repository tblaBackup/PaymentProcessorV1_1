﻿Public Class Form1
    Public context As New DataClasses1DataContext
    Private Sub loadByFName(ByVal FName As String, ByRef opener As ActiveLoan)
        Dim myQry = (From theCustomers In context.tblCustomers Where theCustomers.CustFName.Contains(FName) Select theCustomers).ToList
        opener.customerTble = myGlobalz.ToDataTable(myQry)
        If opener.customerTble.Rows.Count > 0 Then
            Dim myValue As Integer = opener.customerTble.Rows(0).Item(0)
            Dim myQry2 = (From theloans In context.tblCustAcctNums Where theloans.CustomerID = myValue Select theloans).ToList
            opener.LoansTble = myGlobalz.ToDataTable(myQry2)
            If opener.LoansTble.Rows.Count > 0 Then
                Dim myValue2 As Integer = opener.LoansTble.Rows(0).Item(0)
                Dim myQry3 = (From thePayments In context.tblPayments Where thePayments.LoanID = myValue2 Select thePayments.PaymentID, thePayments.PaymentAmount, thePayments.PaymentDate).ToList
                opener.PaymentsTble = myGlobalz.ToDataTable(myQry3)
            End If

        End If
    End Sub
    Private Sub loadByClientID(ByVal clientID As Integer, ByRef opener As ActiveLoan)
        Dim myQry = (From theCustomers In context.tblCustomers Where theCustomers.CustomerID = clientID Select theCustomers).ToList
        opener.customerTble = myGlobalz.ToDataTable(myQry)
        If opener.customerTble.Rows.Count > 0 Then
            Dim myValue As Integer = opener.customerTble.Rows(0).Item(0)
            Dim myQry2 = (From theloans In context.tblCustAcctNums Where theloans.CustomerID = myValue Select theloans).ToList
            opener.LoansTble = myGlobalz.ToDataTable(myQry2)
            If opener.LoansTble.Rows.Count > 0 Then
                Dim myValue2 As Integer = opener.LoansTble.Rows(0).Item(0)
                Dim myQry3 = (From thePayments In context.tblPayments Where thePayments.LoanID = myValue2 Select thePayments.PaymentID, thePayments.PaymentAmount, thePayments.PaymentDate).ToList
                opener.PaymentsTble = myGlobalz.ToDataTable(myQry3)
            End If

        End If
    End Sub
    Private Sub loadByLName(ByVal lastName As String, ByRef opener As ActiveLoan)
        Dim myQry = (From theCustomers In context.tblCustomers Where theCustomers.CustLName.Contains(lastName)).ToList
        opener.customerTble = myGlobalz.ToDataTable(myQry)
        If opener.customerTble.Rows.Count > 0 Then
            Dim myValue As Integer = opener.customerTble.Rows(0).Item(0)
            Dim myQry2 = (From theloans In context.tblCustAcctNums Where theloans.CustomerID = myValue Select theloans).ToList
            opener.LoansTble = myGlobalz.ToDataTable(myQry2)
            If opener.LoansTble.Rows.Count > 0 Then
                Dim myValue2 As Integer = opener.LoansTble.Rows(0).Item(0)
                Dim myQry3 = (From thePayments In context.tblPayments Where thePayments.LoanID = myValue2 Select thePayments.PaymentID, thePayments.PaymentAmount, thePayments.PaymentDate).ToList
                opener.PaymentsTble = myGlobalz.ToDataTable(myQry3)
            End If

        End If
    End Sub
    Private Sub loadByAccNum(ByVal accNum As String, ByRef opener As ActiveLoan)
        Dim myValue As String = LTrim(RTrim(accNum))
        Dim CustID As Integer = (From theValues In context.tblCustAcctNums Where theValues.TBLAAcctID = myValue).Single.CustomerID
        Dim myQry = (From loans In context.tblLoans Where loans.tblCustAcctNum.CustomerID = CustID Select loans).ToList
        opener.customerTble = myGlobalz.ToDataTable(myQry)
        If opener.customerTble.Rows.Count > 0 Then
            Dim myValue2 As Integer = opener.customerTble.Rows(0).Item(0)
            Dim myQry2 = (From theloans In context.tblCustAcctNums Where theloans.CustomerID = myValue Select theloans).ToList
            opener.LoansTble = myGlobalz.ToDataTable(myQry2)
            If opener.LoansTble.Rows.Count > 0 Then
                Dim myValue3 As Integer = opener.LoansTble.Rows(0).Item(0)
                Dim myQry3 = (From thePayments In context.tblPayments Where thePayments.LoanID = myValue3 Select thePayments.PaymentID, thePayments.PaymentAmount, thePayments.PaymentDate).ToList
                opener.PaymentsTble = myGlobalz.ToDataTable(myQry3)
            End If

        End If
    End Sub
    Private Sub PaymentBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PaymentBtn.Click
        Dim ForAResponse As New Dialog2
        Dim respone = ForAResponse.ShowDialog
        Dim opener As New ActiveLoan
        Select Case respone
            Case Windows.Forms.DialogResult.OK
                Panel1.Controls.Clear()
                Select Case ForAResponse.SearchConstraint
                    Case "First Name"
                        loadByFName(ForAResponse.searchString, opener)
                    Case "Last Name"
                        loadByLName(ForAResponse.searchString, opener)
                    Case "Account Number"
                        loadByAccNum(ForAResponse.searchString, opener)
                End Select
                myGlobalz.loadGrid(opener.customerTble, opener.ActiveCustomer)
                myGlobalz.loadGrid(opener.LoansTble, opener.CustomersLoans)
                myGlobalz.loadGrid(opener.PaymentsTble, opener.PaymentHistory)
                Panel1.Controls.Add(opener)
                AddHandler opener.ActiveCustomer.SelectionChanged, Sub()
                                                                       Dim customerID As Integer = opener.activeCustID
                                                                       Dim theLoans = (From theLoanz In context.CustomersLoans Where theLoanz.CustomerID = customerID Select theLoanz).ToList
                                                                       opener.LoansTble = myGlobalz.ToDataTable(theLoans)
                                                                       Try
                                                                           Dim theLoanID As Integer = opener.LoansTble.Rows(0).Item(0)
                                                                           If theLoanID > 0 Then
                                                                               opener.ProcessPayment1.loanID = theLoanID
                                                                               Dim thePaymentz = (From thePayments In context.tblPayments Where thePayments.LoanID = theLoanID Select thePayments).ToList
                                                                               myGlobalz.loadGrid(opener.LoansTble, opener.CustomersLoans)
                                                                               myGlobalz.loadGrid(opener.PaymentsTble, opener.PaymentHistory)
                                                                           End If
                                                                       Catch ex As Exception
                                                                           opener.CustomersLoans.DataSource = Nothing
                                                                           opener.PaymentHistory.DataSource = Nothing
                                                                       End Try
                                                                   End Sub

                AddHandler opener.CustomersLoans.SelectionChanged, Sub()
                                                                       Dim LoanID As Integer = opener.activeLoanID
                                                                       Dim thePayments = (From thepaymentz In context.tblPayments Where thepaymentz.LoanID = LoanID Select thepaymentz).ToList
                                                                       opener.ProcessPayment1.loanID = LoanID
                                                                       opener.LoansTble = myGlobalz.ToDataTable(thePayments)
                                                                   End Sub
                AddHandler opener.PaymentProcessed, Sub()
                                                        'Code for processing payment
                                                    End Sub
        End Select

    End Sub

    Private Sub SearchBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SearchBtn.Click
        Dim ForAResponse As New Dialog2
        Dim respone = ForAResponse.ShowDialog
        Dim opener As New ActiveLoan
        Select Case respone
            Case Windows.Forms.DialogResult.OK
                Panel1.Controls.Clear()
                Select Case ForAResponse.SearchConstraint
                    Case "First Name"
                        loadByFName(ForAResponse.searchString, opener)
                    Case "Last Name"
                        loadByLName(ForAResponse.searchString, opener)
                    Case "Account Number"
                        loadByAccNum(ForAResponse.searchString, opener)
                End Select
                myGlobalz.loadGrid(opener.customerTble, opener.ActiveCustomer)
                myGlobalz.loadGrid(opener.LoansTble, opener.CustomersLoans)
                myGlobalz.loadGrid(opener.PaymentsTble, opener.PaymentHistory)
                Panel1.Controls.Add(opener)
                AddHandler opener.ActiveCustomer.SelectionChanged, Sub()
                                                                       Dim customerID As Integer = opener.activeCustID
                                                                       Dim theLoans = (From theLoanz In context.CustomersLoans Where theLoanz.CustomerID = customerID Select theLoanz).ToList
                                                                       opener.LoansTble = myGlobalz.ToDataTable(theLoans)
                                                                       Try
                                                                           Dim theLoanID As Integer = opener.LoansTble.Rows(0).Item(0)
                                                                           If theLoanID > 0 Then
                                                                               opener.ProcessPayment1.loanID = theLoanID
                                                                               Dim thePaymentz = (From thePayments In context.tblPayments Where thePayments.LoanID = theLoanID Select thePayments).ToList
                                                                               myGlobalz.loadGrid(opener.LoansTble, opener.CustomersLoans)
                                                                               myGlobalz.loadGrid(opener.PaymentsTble, opener.PaymentHistory)
                                                                           End If
                                                                       Catch ex As Exception
                                                                           opener.CustomersLoans.DataSource = Nothing
                                                                           opener.PaymentHistory.DataSource = Nothing
                                                                       End Try
                                                                   End Sub

                AddHandler opener.CustomersLoans.SelectionChanged, Sub()
                                                                       Dim LoanID As Integer = opener.activeLoanID
                                                                       opener.ProcessPayment1.loanID = LoanID
                                                                       Dim thePayments = (From thepaymentz In context.tblPayments Where thepaymentz.LoanID = LoanID Select thepaymentz).ToList
                                                                       opener.LoansTble = myGlobalz.ToDataTable(thePayments)
                                                                   End Sub
        End Select

    End Sub
    Public Sub clearMainScreen()
        Dim checker As Boolean = False
        Panel1.Controls.Clear()
        Dim opener As New MainUI
        Dim myvalues = (From theCustomers In context.tblCustomers Select theCustomers).ToList
        Dim myTble As DataTable = myGlobalz.ToDataTable(myvalues)
        myGlobalz.loadGrid(myTble, opener.DataGridView1)
        Panel1.Controls.Add(opener)
        'myGlobalz.loadGrid()
    End Sub
    Private Sub HomeBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles HomeBtn.Click
        clearMainScreen()
    End Sub

    Private Sub AddCustBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AddCustBtn.Click
        Panel1.Controls.Clear()
        Dim opener As New AddNewSubscriber
        Panel1.Controls.Add(opener)
        AddHandler opener.Cre8Client, Sub()
                                          context.CreateCustomer(opener.BasicCustomerInformation1.TextBox1.Text, opener.BasicCustomerInformation1.TextBox2.Text, opener.BasicCustomerInformation1.TextBox3.Text, opener.BasicCustomerInformation1.TextBox4.Text, opener.BasicCustomerInformation1.TextBox5.Text)
                                          opener.CustID = context.ReturnLastCust()
                                      End Sub
        AddHandler opener.cre8CustAccNum, Sub()
                                              context.CreateLoanAccNum(opener.CustID, opener.AccNum)
                                              opener.CustAccNum = context.ReturnLastCustAccNum
                                          End Sub

        AddHandler opener.LoanSubmited, Sub()
                                            Dim LoanID As Integer = context.ReturnLastLoan
                                            If opener.AddLoanInfo1.CheckBox1.Checked Then
                                                Dim newScreen As New ManualAmort
                                                newScreen.LoanID = LoanID
                                                newScreen.NumericUpDown1.Value = opener.AddLoanInfo1.NumericUpDown4.Value
                                                Dim results = (From theAmort In context.tblAmorts Where theAmort.LoanID = LoanID Select theAmort Order By theAmort.PaymentNumber Descending).ToList
                                                Try
                                                    Dim aTble As New DataTable
                                                    aTble = myGlobalz.ToDataTable(results)
                                                    myGlobalz.loadGrid(aTble, newScreen.DataGridView1)
                                                Catch ex As Exception
                                                    newScreen.DataGridView1.DataSource = Nothing
                                                End Try
                                                Panel1.Controls.Clear()
                                                Panel1.Controls.Add(newScreen)
                                                AddHandler newScreen.amortEntered, Sub()
                                                                                       context.CreateAmort(newScreen.LoanID, newScreen.NumericUpDown2.Value, newScreen.NumericUpDown1.Value, newScreen.NumericUpDown3.Value, newScreen.NumericUpDown4.Value)
                                                                                       newScreen.NumericUpDown2.Value += 1
                                                                                       results = (From theAmort In context.tblAmorts Where theAmort.LoanID = LoanID Select theAmort Order By theAmort.PaymentNumber Descending).ToList
                                                                                       Try
                                                                                           Dim aTble As New DataTable
                                                                                           aTble = myGlobalz.ToDataTable(results)
                                                                                           myGlobalz.loadGrid(aTble, newScreen.DataGridView1)
                                                                                       Catch ex As Exception
                                                                                           newScreen.DataGridView1.DataSource = Nothing
                                                                                       End Try
                                                                                   End Sub
                                            End If
                                        End Sub
    End Sub

    Private Sub Form1_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Private Sub ToolStripButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton2.Click

    End Sub

    Private Sub ManualAmortToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ManualAmortToolStripMenuItem.Click
        Dim opener As New ManualAmort
        Panel1.Controls.Clear()
        Dim opener2 As New Dialog1
        Dim myResponse = opener2.ShowDialog
        Select Case myResponse
            Case vbOK

        End Select

    End Sub
End Class