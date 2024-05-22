Imports System.Data.OleDb

Module AccDB

    Dim conStr = $"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={Application.StartupPath}\EnrollmentSystem.accdb"
    Public con As New OleDbConnection(conStr)
    Public isConnectionTested = False

    Public Sub TestConnection()

        If isConnectionTested Then

            Return

        End If

        Try

            If ConnectionState.Open Then

                con.Close()

            End If

            con.Open()
            isConnectionTested = True

        Catch ex As Exception
            MessageBox.Show("At AccDB " + vbNewLine + ex.Message)
        End Try

    End Sub

    Public Function InserIntoBuilder(table As String, column As String, value As String) As String

        Return $"INSERT INTO {table} ({column}) VALUES ({value})"

    End Function

    Public Class MieInsertInto
        Private table As String

        Public Sub New(table As String)
            Me.table = table
        End Sub

        Private columnFormat As String
        Private valueFormat As String

        Public Sub AddValueToColumn(column As String, value As String)
            columnFormat += $"{column}, "
            valueFormat += $"'{value}', "
        End Sub

        Public Sub ExecuteNonQuery()

            Dim sql = $"INSERT INTO {table} ({columnFormat.Substring(0, columnFormat.Length - 2)}) VALUES ({valueFormat.Substring(0, valueFormat.Length - 2)})"
            MessageBox.Show(sql)
            Dim command As New OleDbCommand(sql, con)
            command.ExecuteNonQuery()

        End Sub

    End Class

End Module
