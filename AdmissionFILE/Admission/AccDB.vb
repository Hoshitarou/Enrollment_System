Imports System.Data.OleDb
Imports System.IO
Imports System.Web.UI.WebControls

Module AccDB

    Dim workingDirectory = Environment.CurrentDirectory
    Dim conStr = $"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={Directory.GetParent(workingDirectory).Parent.Parent.Parent.FullName}\Database\EnrollmentSystem.accdb"
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
            Application.Exit()
        End Try

    End Sub

    Public Sub DoUpdate(sql As String)

        Dim command As New OleDbCommand(sql, con)
        command.ExecuteNonQuery()


    End Sub

    Public Function DoIncrement(sql As String) As String

        Return Integer.Parse((DoScalar(sql) + 1).ToString())

    End Function

    Public Sub DoDisplayToDataGridView(sql As String, dgv As DataGridView)

        Dim da As New OleDbDataAdapter(sql, con)
        Dim table As New DataTable
        da.Fill(table)

        dgv.DataSource = table

    End Sub

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
