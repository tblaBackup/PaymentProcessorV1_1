Public Class MainUI
    Public Event clientSelected()
    Private myG As New myGlobalz

    Private Sub DataGridView1_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        RaiseEvent clientSelected()
    End Sub
  

End Class
