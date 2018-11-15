Imports System.Data.SqlClient

Public Class DataOperations
    Inherits BaseSqlServerConnections
    Public Sub New()
        DefaultCatalog = "NorthWindAzure"
    End Sub
    ''' <summary>
    ''' Get column details, specifically
    ''' - Description for each column
    '''   - Determine if there actually is a description
    '''   - If there is a description it will be used in the header of a DataGridView
    '''   - If no description the column will be hidden in the DataGridView
    ''' </summary>
    ''' <param name="pTableName"></param>
    ''' <returns></returns>
    Public Function ColumnDetails(pTableName As String) As List(Of DataColumn)
        mHasException = False

        Dim columnData = New List(Of DataColumn)
        Dim selectStatement =
        "SELECT  COLUMN_NAME AS ColumnName, ORDINAL_POSITION AS Postion,prop.value AS [Description] " &
        "FROM INFORMATION_SCHEMA.TABLES AS tbl " &
        "INNER JOIN INFORMATION_SCHEMA.COLUMNS AS col ON col.TABLE_NAME = tbl.TABLE_NAME " &
        "INNER JOIN sys.columns AS sc ON sc.object_id = OBJECT_ID(tbl.TABLE_SCHEMA + '.' + tbl.TABLE_NAME) AND sc.name = col.COLUMN_NAME " &
        "LEFT JOIN sys.extended_properties prop ON prop.major_id = sc.object_id AND prop.minor_id = sc.column_id AND prop.name = 'MS_Description' " &
        "WHERE tbl.TABLE_NAME = @TableName " &
        "ORDER BY col.ORDINAL_POSITION"

        Try
            Using cn As New SqlConnection With {.ConnectionString = ConnectionString}
                Using cmd As New SqlCommand With {.Connection = cn}

                    cmd.CommandText = selectStatement
                    cmd.Parameters.AddWithValue("@TableName", pTableName)

                    cn.Open()

                    Dim reader = cmd.ExecuteReader()
                    While reader.Read()
                        columnData.Add(New DataColumn() With {.Name = reader.GetString(0), .Ordinal = reader.GetInt32(1), .Description = reader.GetStringSafe("Description")})
                    End While

                End Using
            End Using
        Catch ex As Exception
            mHasException = True
            mLastException = ex
        End Try

        Return columnData

    End Function
    ''' <summary>
    ''' Return Customers table data
    ''' </summary>
    ''' <returns></returns>
    Public Function GetCustomers() As DataTable
        mHasException = False

        Dim dtCustomers = New DataTable
        Dim selectStatement = "SELECT CustomerIdentifier, CompanyName, ContactName ,Address," &
                            "City,Region,PostalCode,Country,Phone,Fax,ContactTypeIdentifier,ModifiedDate " &
                            "FROM dbo.Customers"

        Try
            Using cn As New SqlConnection With {.ConnectionString = ConnectionString}
                Using cmd As New SqlCommand With {.Connection = cn}
                    cmd.CommandText = selectStatement
                    cn.Open()
                    dtCustomers.Load(cmd.ExecuteReader())
                End Using
            End Using
        Catch ex As Exception
            mHasException = True
            mLastException = ex
        End Try

        Return dtCustomers

    End Function
    ''' <summary>
    ''' Return a DataTable with a join between Customers and ContactType
    ''' </summary>
    ''' <returns></returns>
    Public Function GetCustomersAndContactTypes() As DataTable
        mHasException = False

        Dim dtCustomers = New DataTable

        Dim selectStatement = "SELECT  C.CustomerIdentifier , C.CompanyName , CT.ContactTitle , C.ContactName , C.[Address] , " &
                                "C.City , C.Region , C.PostalCode , C.Country , C.ContactTypeIdentifier , C.ModifiedDate " &
                                "FROM Customers AS C " &
                                "INNER JOIN ContactType AS CT ON C.ContactTypeIdentifier = CT.ContactTypeIdentifier; "
        Try
            Using cn As New SqlConnection With {.ConnectionString = ConnectionString}
                Using cmd As New SqlCommand With {.Connection = cn}
                    cmd.CommandText = selectStatement
                    cn.Open()
                    dtCustomers.Load(cmd.ExecuteReader())
                End Using
            End Using
        Catch ex As Exception
            mHasException = True
            mLastException = ex
        End Try


        Return dtCustomers

    End Function
End Class
