Public Class Form1
    Public context As New DataClasses1DataContext
    Private Sub loadByFName(ByVal FName As String, ByRef opener As ActiveLoan)
        Dim myQry = (From theCustomers In context.tblCustomers Where theCustomers.CustFName.Contains(FName) Select theCustomers).ToList
        opener.customerTble = myGlobalz.ToDataTable(myQry)
        If opener.customerTble.Rows.Count > 0 Then
            opener.CustFullName = RTrim(LTrim(opener.customerTble.Rows(0).Item(1))) + " " + RTrim(LTrim(opener.customerTble.Rows(0).Item(2)))
            Dim myValue As Integer = opener.customerTble.Rows(0).Item(0)
            Dim myQry2 = (From theloans In context.tblCustAcctNums Where theloans.CustomerID = myValue Select theloans).ToList
            opener.LoansTble = myGlobalz.ToDataTable(myQry2)
            If opener.LoansTble.Rows.Count > 0 Then
                Dim activeloan As Integer = opener.LoansTble.Rows(0).Item("LoanID")
                opener.activeLoanID = activeloan
                opener.ProcessPayment1.TextBox1.Text = opener.CustFullName
                Dim myQry3 = (From thePayments In context.tblPayments Where thePayments.LoanID = activeloan Select thePayments.PaymentID, thePayments.PaymentAmount, thePayments.PaymentDate).ToList
                opener.PaymentsTble = myGlobalz.ToDataTable(myQry3)
                opener.ProcessPayment1.mrc = (From theloans In context.tblLoans Where theloans.LoanID = activeloan Select theloans).Single.MonthlyInstallment
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
                
        End Select

    End Sub

    Private Sub SearchBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SearchBtn.Click
        Dim myPanel As ActiveLoan = Search()
        prepActiveLoanPanel(myPanel, Panel1)
    End Sub
    Private Sub prepActiveLoanPanel(ByVal activeLoanPane1 As ActiveLoan, ByRef Apanel As Panel)
        Dim activeloanpane As ActiveLoan = activeLoanPane1
        Apanel.Controls.Clear()
        Apanel.Controls.Add(activeLoanPane)
        AddHandler activeloanpane.clientSelected, Sub()
                                                      Dim customerID As Integer = activeloanpane.activeCustID
                                                      Dim theLoans = (From theLoanz In context.CustomersLoans Where theLoanz.CustomerID = customerID Select theLoanz).ToList
                                                      activeloanpane.LoansTble = myGlobalz.ToDataTable(theLoans)
                                                      activeloanpane.CustFullName = RTrim(LTrim(activeloanpane.customerTble.Rows(0).Item(1))) + " " + RTrim(LTrim(activeloanpane.customerTble.Rows(0).Item(2)))
                                                      Try
                                                          Dim theLoanID As Integer = activeloanpane.LoansTble.Rows(0).Item(0)
                                                          activeloanpane.ProcessPayment1.TextBox2.Text = activeloanpane.LoansTble.Rows(0).Item(1).ToString
                                                          activeloanpane.ProcessPayment1.TextBox1.Text = activeloanpane.CustFullName
                                                          If theLoanID > 0 Then
                                                              activeloanpane.ProcessPayment1.loanID = theLoanID
                                                              Dim thePaymentz = (From thePayments In context.tblPayments Where thePayments.LoanID = theLoanID Select thePayments).ToList
                                                              Dim theLoanz = (From Dloans In context.CustomersLoans Where Dloans.LoanID = theLoanID Select Dloans).ToList
                                                              Dim DLoanzTble As DataTable = myGlobalz.ToDataTable(theLoanz)
                                                              Dim thePaymentzTble As DataTable = myGlobalz.ToDataTable(thePaymentz)
                                                              If DLoanzTble.Rows.Count <= 0 Then
                                                                  activeloanpane.CustomersLoans.DataSource = Nothing
                                                                  activeloanpane.PaymentHistory.DataSource = Nothing
                                                              Else
                                                                  myGlobalz.loadGrid(DLoanzTble, activeloanpane.CustomersLoans)
                                                                  activeloanpane.ProcessPayment1.TextBox1.Text = DLoanzTble.Rows(0).Item(1).ToString

                                                                  If thePaymentzTble.Rows.Count <= 0 Then
                                                                      activeloanpane.PaymentHistory.DataSource = Nothing
                                                                  Else
                                                                      myGlobalz.loadGrid(thePaymentzTble, activeloanpane.PaymentHistory)
                                                                  End If
                                                              End If
                                                          End If
                                                      Catch ex As Exception
                                                          activeloanpane.CustomersLoans.DataSource = Nothing
                                                          activeloanpane.PaymentHistory.DataSource = Nothing
                                                      End Try
                                                  End Sub

        AddHandler activeloanpane.loanSelected, Sub()
                                                    Dim LoanID As Integer = activeloanpane.activeLoanID
                                                    activeloanpane.ProcessPayment1.loanID = LoanID
                                                    Dim thePayments = (From thepaymentz In context.tblPayments Where thepaymentz.LoanID = LoanID Select thepaymentz).ToList
                                                    Dim mrc = (From theLoanz In context.tblLoans Where theLoanz.LoanID = LoanID Select theLoanz).Single.MonthlyInstallment
                                                    Dim atble As DataTable = myGlobalz.ToDataTable(thePayments)
                                                    If atble.Rows.Count < 1 Then
                                                        activeloanpane.PaymentHistory.DataSource = Nothing
                                                    Else
                                                        activeloanpane.LoansTble = atble
                                                        myGlobalz.loadGrid(atble, activeloanpane.PaymentHistory)
                                                        activeloanpane.ProcessPayment1.mrc = mrc
                                                    End If
                                                    activeloanpane.ProcessPayment1.TextBox2.Text = activeloanpane.activeLoanID
                                                    activeloanpane.ProcessPayment1.TextBox1.Text = activeloanpane.CustFullName
                                                End Sub
        AddHandler activeloanpane.PaymentProcessed, Sub()
                                                        processPayment(activeloanpane.activeLoanID, activeloanpane.ProcessPayment1.DateSubmitted, activeloanpane.ProcessPayment1.Amount, activeloanpane.ProcessPayment1.mrc)

                                                    End Sub
    End Sub
    Public Sub processPayment(ByVal loanID As Integer, ByVal paymentDate As Date, ByVal PaymentAmount As Double, ByVal MonthlyDue As Double)
        context.InsertIntoCash(PaymentAmount, paymentDate, loanID)
        Dim CashID As Integer = context.ReturnsCashID(PaymentAmount, paymentDate, loanID)
        Dim valueOnHold As Double = 0.0
        Dim fromHolding As Double = 0.0
        Dim OldPosition As Integer = 0 'position in Amort before applying this payment
        Dim NewPosition As Integer = 0
        Try
            valueOnHold = context.SumOnHold(loanID)
        Catch ex As Exception
            valueOnHold = 0
        End Try
        fromHolding = valueOnHold
        valueOnHold += PaymentAmount
        Dim totalPaid As Double = context.ReturnTotalPaymentz(loanID)
        OldPosition = CInt(totalPaid / MonthlyDue)
        NewPosition = CInt((totalPaid + valueOnHold) / MonthlyDue)

        If valueOnHold >= CDbl(MonthlyDue) Then
            Dim numPayments As Integer = NewPosition - OldPosition
            Dim balance As Double = PaymentAmount - (MonthlyDue * numPayments)
            Dim manualAmort As Boolean = True
            Dim interestPayment As Double
            Dim principalPayment As Double
            manualAmort = context.ManualAmortTest(loanID)
            If balance > 0 Then
                context.InsertIntoHolding(balance, loanID)
            End If
            Do While numPayments > 0
                If manualAmort Then
                    interestPayment = context.ReturnInterest(loanID, OldPosition)
                    principalPayment = context.ReturnPrincipal(loanID, OldPosition)
                    OldPosition += 1
                End If
                context.InsertDataIntoTable(paymentDate, MonthlyDue, loanID, interestPayment, principalPayment, CashID)
                numPayments -= 1
            Loop
        ElseIf fromHolding > 0 Then
            context.UpdateAmountInHolding(PaymentAmount, loanID)
        Else
            context.InsertIntoHolding(fromHolding, loanID)
        End If
        printReceipt(CashID, loanID, paymentDate, PaymentAmount)
        context.PrintReceipt(CashID, paymentDate)
    End Sub
    Public Sub printReceipt(ByVal ReceiptID As Integer, ByVal LoanID As Integer, ByVal PaymentDate As Date, ByVal amount As Double)
        Dim opener As New Printer
        opener.Label1.Text = "Receipt#" + ReceiptID.ToString
        opener.NameLbl.Text = context.ReturnFullNameFromLoanID(LoanID)
        opener.AddressLbl.Text = context.ReturnFullAddressFromLoanID(LoanID)
        opener.DateLbl.Text = PaymentDate
        opener.AmtLbl.Text = amount
        opener.Show()
        opener.BringToFront()
    End Sub
    Public Function Search() As ActiveLoan
        Dim ForAResponse As New Dialog2
        ForAResponse.CheckBox1.Checked = True
        Dim respone = ForAResponse.ShowDialog
        Dim opener As New ActiveLoan
        Select Case respone
            Case Windows.Forms.DialogResult.OK
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
                If opener.LoansTble.Rows.Count > 0 Then
                    opener.ProcessPayment1.TextBox2.Text = opener.LoansTble.Rows(0).Item(1).ToString
                End If
        End Select
        Return opener
    End Function
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
                                            context.CreateLoan(opener.LoanPrincipal, opener.interestRate, opener.LoanTerm, opener.startDate, opener.monthlyInstallment, opener.CustAccNum, opener.manualAmort)
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
                                                                                       If newScreen.editMode = False Then
                                                                                           context.CreateAmort(newScreen.LoanID, newScreen.NumericUpDown2.Value, newScreen.NumericUpDown1.Value, newScreen.NumericUpDown3.Value, newScreen.NumericUpDown4.Value)
                                                                                           newScreen.NumericUpDown2.Value += 1
                                                                                       Else
                                                                                           Dim AmortID As Integer = newScreen.DataGridView1.SelectedRows.Item(0).Cells(0).Value
                                                                                           context.UpdateAmort(AmortID, newScreen.NumericUpDown3.Value, newScreen.NumericUpDown4.Value)
                                                                                           newScreen.editMode = False
                                                                                       End If
                                                                                       results = (From theAmort In context.tblAmorts Where theAmort.LoanID = LoanID Select theAmort Order By theAmort.PaymentNumber Descending).ToList
                                                                                       Try
                                                                                           Dim aTble As New DataTable
                                                                                           aTble = myGlobalz.ToDataTable(results)
                                                                                           myGlobalz.loadGrid(aTble, newScreen.DataGridView1)
                                                                                       Catch ex As Exception
                                                                                           newScreen.DataGridView1.DataSource = Nothing
                                                                                       End Try
                                                                                   End Sub
                                                AddHandler newScreen.amortSelected, Sub()
                                                                                        newScreen.NumericUpDown2.Value = newScreen.DataGridView1.SelectedRows.Item(0).Cells(1).Value
                                                                                        newScreen.NumericUpDown1.Value = newScreen.DataGridView1.SelectedRows.Item(0).Cells(2).Value
                                                                                        newScreen.NumericUpDown3.Value = newScreen.DataGridView1.SelectedRows.Item(0).Cells(3).Value
                                                                                        newScreen.NumericUpDown4.Value = newScreen.DataGridView1.SelectedRows.Item(0).Cells(4).Value
                                                                                        newScreen.editMode = True
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
        Dim opener2 As New Dialog2
        Dim myResponse = opener2.ShowDialog
        Select Case myResponse
            Case vbOK
                loadAmortByFName(opener2.TextBox1.Text)
        End Select

    End Sub
    Private Sub loadAmortByFName(ByVal FName As String)
        Dim myValues As DataTable = myGlobalz.ToDataTable((context.ReturnAmortInfoByFName(FName)).ToList)
        If myValues.Rows.Count > 1 Then
            Dim dopener As New Dialog4
            myGlobalz.loadGrid(myValues, dopener.DataGridView1)
            Dim response = dopener.ShowDialog()
            If response = vbOK And dopener.SelectedID > 0 Then
                Dim results = (From theAmort In context.tblAmorts Where theAmort.LoanID = dopener.SelectedID Select theAmort Order By theAmort.PaymentNumber Descending).ToList
                Dim opener2 As New ManualAmort
                opener2.LoanID = dopener.SelectedID
                Panel1.Controls.Clear()
                Dim TheAmortz As DataTable = myGlobalz.ToDataTable(results)
                Try
                    opener2.NumericUpDown1.Value = TheAmortz.Rows(0).Item(2)
                    opener2.NumericUpDown2.Value = TheAmortz.Rows(0).Item(1)
                    opener2.NumericUpDown3.Value = TheAmortz.Rows(0).Item(3)
                    opener2.NumericUpDown4.Value = TheAmortz.Rows(0).Item(4)
                Catch ex As Exception

                End Try
                Panel1.Controls.Add(opener2)
                myGlobalz.loadGrid(TheAmortz, opener2.DataGridView1)
                opener2.editMode = True
                AddHandler opener2.amortSelected, Sub()
                                                      opener2.NumericUpDown2.Value = opener2.DataGridView1.SelectedRows.Item(0).Cells(1).Value
                                                      opener2.NumericUpDown1.Value = opener2.DataGridView1.SelectedRows.Item(0).Cells(2).Value
                                                      opener2.NumericUpDown3.Value = opener2.DataGridView1.SelectedRows.Item(0).Cells(3).Value
                                                      opener2.NumericUpDown4.Value = opener2.DataGridView1.SelectedRows.Item(0).Cells(4).Value
                                                      opener2.editMode = True
                                                  End Sub
                AddHandler opener2.amortEntered, Sub()
                                                     Dim myResponse As Integer = -1
                                                     If opener2.editMode = False Then
                                                         context.CreateAmort(opener2.LoanID, opener2.NumericUpDown2.Value, opener2.NumericUpDown1.Value, opener2.NumericUpDown3.Value, opener2.NumericUpDown4.Value)
                                                         opener2.NumericUpDown2.Value += 1
                                                     Else
                                                         Dim AmortID As Integer = opener2.DataGridView1.SelectedRows.Item(0).Cells(0).Value
                                                         context.UpdateAmort(AmortID, opener2.NumericUpDown3.Value, opener2.NumericUpDown4.Value)
                                                         Dim theValue = (From theAmortes In context.tblAmorts Where theAmortes.LoanID = opener2.LoanID Select theAmortes Order By theAmortes.PaymentNumber Descending).ToList
                                                         Dim myTble As DataTable = myGlobalz.ToDataTable(theValue)
                                                         Dim nextPayment As Integer = myTble.Rows(0).Item(1)
                                                         opener2.NumericUpDown2.Value = nextPayment + 1
                                                         myResponse = MsgBox("Would you like to add more payments to the schedule?", vbYesNo, "How to proceed?")
                                                     End If
                                                     If myResponse = vbYes Then
                                                         opener2.editMode = False
                                                     ElseIf myResponse = vbNo Then
                                                         opener2.editMode = True
                                                     End If
                                                     results = Nothing
                                                     context = New DataClasses1DataContext
                                                     results = (From theAmort In context.tblAmorts Where theAmort.LoanID = opener2.LoanID Select theAmort Order By theAmort.PaymentNumber Descending).ToList
                                                     Try
                                                         Dim aTble As New DataTable
                                                         aTble = myGlobalz.ToDataTable(results)
                                                         myGlobalz.loadGrid(aTble, opener2.DataGridView1)
                                                     Catch ex As Exception
                                                         opener2.DataGridView1.DataSource = Nothing
                                                     End Try
                                                 End Sub
            Else

            End If
        ElseIf myValues.Rows.Count = 1 Then
            Dim myOpener As New ManualAmort
            myOpener.LoanID = myValues.Rows(0).Item(0)
            Dim results = (From theAmort In context.tblAmorts Where theAmort.LoanID = myOpener.LoanID Select theAmort Order By theAmort.PaymentNumber Descending).ToList
            Panel1.Controls.Clear()
            Dim TheAmortz As DataTable = myGlobalz.ToDataTable(results)
            MsgBox(TheAmortz.Rows.Count)
            Try
                myOpener.NumericUpDown1.Value = TheAmortz.Rows(0).Item(2)
                myOpener.NumericUpDown2.Value = TheAmortz.Rows(0).Item(1)
                myOpener.NumericUpDown3.Value = TheAmortz.Rows(0).Item(3)
                myOpener.NumericUpDown4.Value = TheAmortz.Rows(0).Item(4)
            Catch ex As Exception

            End Try
            myOpener.editMode = True
            Panel1.Controls.Add(myOpener)
            myGlobalz.loadGrid(TheAmortz, myOpener.DataGridView1)
            AddHandler myOpener.amortSelected, Sub()
                                                   myOpener.NumericUpDown2.Value = myOpener.DataGridView1.SelectedRows.Item(0).Cells(1).Value
                                                   myOpener.NumericUpDown1.Value = myOpener.DataGridView1.SelectedRows.Item(0).Cells(2).Value
                                                   myOpener.NumericUpDown3.Value = myOpener.DataGridView1.SelectedRows.Item(0).Cells(3).Value
                                                   myOpener.NumericUpDown4.Value = myOpener.DataGridView1.SelectedRows.Item(0).Cells(4).Value
                                                   myOpener.AmortID = myOpener.DataGridView1.SelectedRows.Item(0).Cells(0).Value
                                                   myOpener.editMode = True
                                               End Sub
            AddHandler myOpener.amortEntered, Sub()
                                                  Dim AmortID As Integer = myOpener.DataGridView1.SelectedRows.Item(0).Cells(0).Value
                                                  myOpener.LoanID = (From theAmort In context.tblAmorts Where theAmort.AmortID = AmortID Select theAmort).Single.LoanID
                                                  If myOpener.editMode = False Then
                                                      ' context.CreateAmort(MyOpener.LoanID, MyOpener.NumericUpDown2.Value, MyOpener.NumericUpDown1.Value, MyOpener.NumericUpDown3.Value, MyOpener.NumericUpDown4.Value)

                                                  Else

                                                      context.UpdateAmort(AmortID, myOpener.NumericUpDown3.Value, myOpener.NumericUpDown4.Value)
                                                      'MyOpener.editMode = False
                                                  End If
                                                  results = Nothing
                                                  context = New DataClasses1DataContext
                                                  results = (From theAmort In context.tblAmorts Where theAmort.LoanID = myOpener.LoanID Select theAmort Order By theAmort.PaymentNumber Descending).ToList
                                                  Try
                                                      Dim aTble As New DataTable
                                                      aTble = myGlobalz.ToDataTable(results)
                                                      MsgBox(aTble.Rows(0).Item(3))
                                                      myOpener.DataGridView1.DataSource = Nothing
                                                      myGlobalz.loadGrid(aTble, myOpener.DataGridView1)
                                                  Catch ex As Exception
                                                      myOpener.DataGridView1.DataSource = Nothing
                                                  End Try
                                              End Sub
        End If

    End Sub
    Private Sub ToolStripButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton1.Click
        printReceipt(1, 1, Now(), 1.0)
    End Sub
End Class
