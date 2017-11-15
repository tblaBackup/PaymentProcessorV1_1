Public Class ManualAmort
    Public Event amortEntered()
    Public LoanID As Integer
    Public AmortInfo As DataTable
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        RaiseEvent amortEntered()
    End Sub

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        LoanID = -1
    End Sub

    Private Sub ManualAmort_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Not LoanID = -1 Then
            myGlobalz.loadGrid(AmortInfo, DataGridView1)
        End If
    End Sub

    Private Sub NumericUpDown3_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NumericUpDown3.Leave
        NumericUpDown4.Value = NumericUpDown1.Value - NumericUpDown3.Value
    End Sub
End Class
