Imports System.Data.SqlClient

Public Interface IDataObject

    Function getInsertQuery() As String
    Function getInsertParameters() As List(Of SqlParameter)

End Interface
