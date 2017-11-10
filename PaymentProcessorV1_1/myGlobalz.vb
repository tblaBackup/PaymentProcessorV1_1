Imports System.Reflection
Imports System.ComponentModel

Public Class myGlobalz
    Public Shared Sub loadGrid(ByVal input As DataTable, ByRef Datagridview1 As DataGridView)
        Datagridview1.DataSource = input
    End Sub
    Public Shared Function ToDataTable(Of T)(ByVal data As IList(Of T)) As DataTable
        Dim properties As PropertyDescriptorCollection = TypeDescriptor.GetProperties(GetType(T))
        Dim table As New DataTable()
        For Each prop As PropertyDescriptor In properties
            table.Columns.Add(prop.Name, If(Nullable.GetUnderlyingType(prop.PropertyType), prop.PropertyType))
        Next
        For Each item As T In data
            Dim row As DataRow = table.NewRow()
            For Each prop As PropertyDescriptor In properties
                row(prop.Name) = If(prop.GetValue(item), DBNull.Value)
            Next
            table.Rows.Add(row)
        Next
        Return table
    End Function

End Class
