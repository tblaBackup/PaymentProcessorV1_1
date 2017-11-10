Imports System.Windows.Forms

Public Class Dialog2
    Public searchString As String
    Public SearchConstraint As String
    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        If CheckBox1.Checked Then
            SearchConstraint = "First Name"
            searchString = TextBox1.Text
        End If
        If CheckBox2.Checked Then
            SearchConstraint = "Last Name"
            searchString = TextBox2.Text
        End If
        If CheckBox3.Checked Then
            SearchConstraint = "Account Number"
            searchString = TextBox3.Text
        End If
        Me.Close()
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub CheckBox1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox1.CheckedChanged
        TextBox1.Enabled = CheckBox1.Checked
        If CheckBox1.Checked Then
            CheckBox2.Checked = False
            CheckBox3.Checked = False
            TextBox1.Focus()
        End If
    End Sub

    Private Sub CheckBox2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox2.CheckedChanged
        TextBox2.Enabled = CheckBox2.Checked
        If CheckBox2.Checked Then
            CheckBox1.Checked = False
            CheckBox3.Checked = False
            TextBox2.Focus()
        End If
    End Sub

    Private Sub CheckBox3_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox3.CheckedChanged
        TextBox3.Enabled = CheckBox3.Checked
        If CheckBox3.Checked Then
            CheckBox2.Checked = False
            CheckBox1.Checked = False
            TextBox3.Focus()
        End If
    End Sub
End Class
