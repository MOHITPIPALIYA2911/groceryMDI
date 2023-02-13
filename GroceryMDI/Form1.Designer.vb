<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.GroceryToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ManageGroceryToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GroceryStockToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.GroceryToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(844, 24)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'GroceryToolStripMenuItem
        '
        Me.GroceryToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ManageGroceryToolStripMenuItem, Me.GroceryStockToolStripMenuItem})
        Me.GroceryToolStripMenuItem.Name = "GroceryToolStripMenuItem"
        Me.GroceryToolStripMenuItem.Size = New System.Drawing.Size(60, 20)
        Me.GroceryToolStripMenuItem.Text = "Grocery"
        '
        'ManageGroceryToolStripMenuItem
        '
        Me.ManageGroceryToolStripMenuItem.Name = "ManageGroceryToolStripMenuItem"
        Me.ManageGroceryToolStripMenuItem.Size = New System.Drawing.Size(160, 22)
        Me.ManageGroceryToolStripMenuItem.Text = "Manage grocery"
        '
        'GroceryStockToolStripMenuItem
        '
        Me.GroceryStockToolStripMenuItem.Name = "GroceryStockToolStripMenuItem"
        Me.GroceryStockToolStripMenuItem.Size = New System.Drawing.Size(160, 22)
        Me.GroceryStockToolStripMenuItem.Text = "Grocery stock"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(844, 486)
        Me.Controls.Add(Me.MenuStrip1)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.Text = "Grocery MDI App"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents GroceryToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ManageGroceryToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GroceryStockToolStripMenuItem As ToolStripMenuItem
End Class
