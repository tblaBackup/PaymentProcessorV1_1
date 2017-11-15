Public Class Printer
    Public WriteOnly Property _PrintForm As Boolean
        Set(ByVal value As Boolean)
            If value = True Then
                Me.Refresh()
                PrintForm1.Form = Me
                PrintForm1.PrintAction = Printing.PrintAction.PrintToPreview
                PrintForm1.Print(Me, PowerPacks.Printing.PrintForm.PrintOption.CompatibleModeClientAreaOnly)
            End If
        End Set
    End Property
    Public CustomerName As String
    Public customerAddress As String
    Public PaymentAmount As Double
    Public DatePaid As Date
    Public ReceiptNumber As Integer
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Button1.Visible = False
        _PrintForm = True
        Button1.Visible = True
        Me.Close()
    End Sub

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Me.NameLbl.Text = CustomerName
        Me.AddressLbl.Text = customerAddress
        Me.AmtLbl.Text = PaymentAmount
        Me.DateLbl.Text = DatePaid.ToShortDateString

    End Sub
End Class