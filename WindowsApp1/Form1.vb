Imports BackendLibrary

Public Class Form1
    Private ReadOnly _bsCustomers As New BindingSource
    Private ReadOnly _operations As DataOperations = New DataOperations
    ''' <summary>
    ''' - Populate a DataGridView with a single table.
    ''' - Set header text using information returned from parsing each columns description property
    ''' * Note in this code there is zero check for if the column exists in the DataGridView while
    '''   in form3 a check is done to see if the column exists in the underlying DataTable. 
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub Form1_Shown(sender As Object, e As EventArgs) Handles Me.Shown

        ' get customer data into DataTable
        _bsCustomers.DataSource = _operations.GetCustomers()
        DataGridView1.DataSource = _bsCustomers


        ' get column details for customers table
        Dim results = _operations.ColumnDetails("Customers")

        If _operations.IsSuccessFul Then
            ' set column header text and hide column with no description
            For Each dataColumn As DataColumn In results
                If dataColumn.Visible Then
                    DataGridView1.Columns(dataColumn.Name).HeaderText = dataColumn.Description
                Else
                    DataGridView1.Columns(dataColumn.Name).Visible = False
                End If
            Next

            DataGridView1.ExpandColumns
        Else
            MessageBox.Show(_operations.LastExceptionMessage)
        End If
    End Sub
    ''' <summary>
    ''' Show ability to get hidden and visible field values
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub cmdCurrentRow_Click(sender As Object, e As EventArgs) Handles cmdCurrentRow.Click
        '
        ' Cast Current property to a DataRow which provides access to properties of current row
        ' in the DataGridView.
        '
        If _bsCustomers.Current IsNot Nothing Then
            Dim row = CType(_bsCustomers.Current, DataRowView).Row
            MessageBox.Show($"Primary key: {row.Field(Of Integer)("CustomerIdentifier")} Company: {row.Field(Of String)("CompanyName")}")
        End If
    End Sub
End Class
Public Module Extensions
    <Runtime.CompilerServices.Extension>
    Public Function FieldLastValue(Of T)(dt As DataTable, pColumnName As String) As T
        Return dt.Rows(dt.Rows.Count - 1).Field(Of T)(dt.Columns(pColumnName))
    End Function
End Module

