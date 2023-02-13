Imports System.Data.OleDb
Public Class manageGrocery
    Sub view()
        Dim conn As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\HPX\OneDrive\Desktop\VB_Journal\GroceryMDI\GroceryMDIDB.accdb")
        conn.Open()
        Dim adp As New OleDbDataAdapter("select * from grocery", conn)
        Dim ds As New DataSet()
        adp.Fill(ds, "grocery")
        GridView.DataSource = ds.Tables("grocery")
        conn.Close()
        txtmrp.Clear()
        txtnm.Clear()
        txtno.Clear()
        txtpr.Clear()
        txtqn.Clear()
    End Sub

    Private Sub btnadd_Click(sender As Object, e As EventArgs) Handles btnadd.Click
        Dim conn As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\HPX\OneDrive\Desktop\VB_Journal\GroceryMDI\GroceryMDIDB.accdb")
        conn.Open()
        Dim cmd As New OleDbCommand
        cmd.Connection = conn
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "insert into grocery values(" & txtno.Text & ",'" & txtnm.Text & "'," & txtmrp.Text & "," & txtpr.Text & "," & txtqn.Text & ")"
        cmd.ExecuteNonQuery()
        MsgBox("Record inserted successfully!")
        conn.Close()
        view()
    End Sub

    Private Sub btnsrc_Click(sender As Object, e As EventArgs) Handles btnsrc.Click

        Dim conn As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\HPX\OneDrive\Desktop\VB_Journal\GroceryMDI\GroceryMDIDB.accdb")
        conn.Open()
        Dim adp As New OleDbDataAdapter("select * from grocery where name='" & txtitem.Text & "' ", conn)
        Dim ds As New DataSet()
        adp.Fill(ds, "grocery")
        GridView.DataSource = ds.Tables("grocery")
        conn.Close()
    End Sub

    Private Sub btnsw_Click(sender As Object, e As EventArgs) Handles btnsw.Click
        view()
    End Sub

    Private Sub btnupdt_Click(sender As Object, e As EventArgs) Handles btnupdt.Click
        Dim conn As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\HPX\OneDrive\Desktop\VB_Journal\GroceryMDI\GroceryMDIDB.accdb")
        conn.Open()
        Dim cmd As New OleDbCommand
        cmd.Connection = conn
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "update grocery set name='" & txtnm.Text & "', mrp=" & txtmrp.Text & ", sell_price=" & txtpr.Text & ", quantity=" & txtqn.Text & " where item_no= " & txtno.Text & " "
        cmd.ExecuteNonQuery()
        MsgBox("Record updated successfully!")
        conn.Close()
        view()
    End Sub

    Private Sub btndlt_Click(sender As Object, e As EventArgs) Handles btndlt.Click
        Dim conn As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\HPX\OneDrive\Desktop\VB_Journal\GroceryMDI\GroceryMDIDB.accdb")
        conn.Open()
        Dim cmd As New OleDbCommand
        cmd.Connection = conn
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "delete from grocery where item_no= " & txtno.Text & " "
        cmd.ExecuteNonQuery()
        MsgBox("Record deleted successfully!")
        conn.Close()
        view()
    End Sub
End Class