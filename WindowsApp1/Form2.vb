Imports BackendLibrary

Public Class Form2
    Private ReadOnly _bsCustomers As New BindingSource
    Private ReadOnly _operations As DataOperations = New DataOperations
    ''' <summary>
    ''' - Populate a DataGridView with a single table.
    ''' - Set header text using information returned from parsing each columns description property
    ''' * Note in this code there is zero check for if the column exists in the DataGridView while
    '''   in form3 a check is done to see if the column exists in the underlying DataTable. 
    ''' </summary>
    Private Sub Form2_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        ' DataGridViewColumns have been setup in the designer
        ' Each column names is a field name prefixed with col e.g. CompanyName is colCompanyName
        DataGridView1.AutoGenerateColumns = False

        ' Get customer data into DataTable
        _bsCustomers.DataSource = _operations.GetCustomers()

        DataGridView1.DataSource = _bsCustomers

        ' Get column details for customers table
        Dim results = _operations.ColumnDetails("Customers")

        If _operations.IsSuccessFul Then
            ' Set column header text and hide column with no description
            ' In Form1 Column name is used to reference columns while
            ' here col is prefixed as each DataGridViewColum plus the underlying field name
            For Each dataColumn As DataColumn In results
                If dataColumn.Visible Then
                    DataGridView1.Columns($"col{dataColumn.Name}").HeaderText = dataColumn.Description
                Else
                    DataGridView1.Columns($"col{dataColumn.Name}").Visible = False
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