Imports System.Windows.Forms

Public Class Dialog3
    Private TBLAAcctNum As String
    Public Property AccNum As String
        Get
            Return TBLAAcctNum
        End Get
        Set(ByVal value As String)
            TBLAAcctNum = value
        End Set
    End Property
    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        AccNum = DAccountNumberBox.Text
        Me.Close()
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        AccNum = "N/S"
    End Sub
End Class
