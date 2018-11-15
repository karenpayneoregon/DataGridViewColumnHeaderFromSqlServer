Public Module DataExtensions
    <Runtime.CompilerServices.Extension>
    Public Function GetStringSafe(pReader As IDataReader, pField As String) As String

        Return If(TypeOf pReader(pField) Is DBNull, Nothing, pReader(pField).ToString())

    End Function
    <Runtime.CompilerServices.Extension>
    Public Function GetInt32Safe(pReader As IDataReader, pField As String) As Integer
        Return pReader.GetInt32Safe(pField, 0)
    End Function

    <Runtime.CompilerServices.Extension>
    Public Function GetInt32Safe(pReader As IDataReader, pField As String, pDefaultValue As Integer) As Integer

        Dim value = pReader(pField)
        Return If(TypeOf value Is Integer, CInt(Fix(value)), pDefaultValue)

    End Function
    <Runtime.CompilerServices.Extension>
    Public Function GetDoubleSafe(pReader As IDataReader, pField As String) As Double
        Return pReader.GetDoubleSafe(pField, 0)
    End Function
    <Runtime.CompilerServices.Extension>
    Public Function GetDoubleSafe(pReader As IDataReader, pField As String, pDefaultValue As Long) As Double

        Dim value = pReader(pField)
        Return If(TypeOf value Is Double, CDbl(value), pDefaultValue)

    End Function

    <Runtime.CompilerServices.Extension>
    Public Function GetDateTimeSafe(pReader As IDataReader, pField As String) As Date

        Return pReader.GetDateTimeSafe(pField, Date.MinValue)

    End Function
    <Runtime.CompilerServices.Extension>
    Public Function GetDateTimeSafe(pReader As IDataReader, pField As String, pDefaultValue As Date) As Date

        Dim value = pReader(pField)
        Return If(TypeOf value Is Date, CDate(value), pDefaultValue)

    End Function

End Module
