Public Class ManualAmort
    Public Event amortEntered()
    Public LoanID As Integer
    Public AmortInfo As DataTable
    Public AmortID As Integer
    Public Event amortSelected()
    Public editMode As Boolean
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        RaiseEvent amortEntered()
    End Sub

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        LoanID = -1
        editMode = False
    End Sub

    Private Sub ManualAmort_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Not LoanID = -1 Then
            myGlobalz.loadGrid(AmortInfo, DataGridView1)
        End If
    End Sub

    Private Sub DataGridView1_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        RaiseEvent amortSelected()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        NumericUpDown4.Value = NumericUpDown1.Value - NumericUpDown3.Value
    End Sub

End Class
