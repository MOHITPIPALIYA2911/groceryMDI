Public Class Form1


    Private Sub ManageGroceryToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ManageGroceryToolStripMenuItem.Click
        Dim mngGrocery As New groceryMaster
        mngGrocery.MdiParent = Me
        mngGrocery.Show()
    End Sub

    Private Sub GroceryStockToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GroceryStockToolStripMenuItem.Click
        Dim stkGrocery As New stockGrocery
        stkGrocery.MdiParent = Me
        stkGrocery.Show()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim mngGrocery As New groceryMaster
        mngGrocery.MdiParent = Me
        mngGrocery.Show()
    End Sub
End Class
