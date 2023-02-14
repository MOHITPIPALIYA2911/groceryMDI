Imports System.Data.OleDb

Public Class stockGrocery
    Private Sub stockGrocery_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim conn As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\HPX\OneDrive\Desktop\VB_Journal\GroceryMDI\GroceryMDIDB.accdb")
        conn.Open()
        Dim adp As New OleDbDataAdapter("select name,quantity from grocery", conn)
        Dim ds As New DataSet()
        adp.Fill(ds, "grocery")
        GridViewstk.DataSource = ds.Tables("grocery")
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub
End Class