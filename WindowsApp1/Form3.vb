Imports BackendLibrary

Public Class Form3
    Private ReadOnly _bsCustomers As New BindingSource
    Private ReadOnly _operations As DataOperations = New DataOperations
    ''' <summary>
    ''' - Populate a DataGridView with a single table.
    ''' - Set header text using information returned from parsing each columns description property
    ''' * Note in this code there is a check to see if a column exists in the DataGridView for the
    '''   description returned in contactResuls data.
    ''' </summary>
    Private Sub Form3_Shown(sender As Object, e As EventArgs) Handles Me.Shown

        ' get customer data into DataTable
        _bsCustomers.DataSource = _operations.GetCustomersAndContactTypes()
        DataGridView1.DataSource = _bsCustomers


        ' get column details for customers table
        Dim customerResults = _operations.ColumnDetails("Customers")
        Dim contactResults = _operations.ColumnDetails("ContactType")

        If _operations.IsSuccessFul Then
            ' set column header text and hide column with no description
            For Each dataColumn As DataColumn In customerResults
                If DataGridView1.Columns.Contains(dataColumn.Name) Then
                    If dataColumn.Visible Then

                        DataGridView1.Columns(dataColumn.Name).HeaderText = dataColumn.Description
                    Else
                        DataGridView1.Columns(dataColumn.Name).Visible = False
                    End If
                End If
            Next

            For Each dataColumn As DataColumn In contactResults
                If DataGridView1.Columns.Contains(dataColumn.Name) Then
                    If dataColumn.Visible Then
                        DataGridView1.Columns(dataColumn.Name).HeaderText = dataColumn.Description
                    Else
                        DataGridView1.Columns(dataColumn.Name).Visible = False
                    End If
                End If
            Next

            DataGridView1.ExpandColumns
        Else
            MessageBox.Show(_operations.LastExceptionMessage)
        End If
    End Sub

    Private Sub cmdCurrentRow_Click(sender As Object, e As EventArgs) Handles cmdCurrentRow.Click
        '
        ' Cast Current property to a DataRow which provides access to properties of current row
        ' in the DataGridView.
        '
        If _bsCustomers.Current IsNot Nothing Then
            Dim row = CType(_bsCustomers.Current, DataRowView).Row
            MessageBox.Show($"Primary key: {row.Field(Of Integer)("CustomerIdentifier")} Company: {row.Field(Of String)("CompanyName")} ContactType Id: {row.Field(Of Integer)("ContactTypeIdentifier")}")
        End If
    End Sub
End Class