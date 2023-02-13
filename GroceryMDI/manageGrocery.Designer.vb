<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class manageGrocery
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.GridView = New System.Windows.Forms.DataGridView()
        Me.btnsw = New System.Windows.Forms.Button()
        Me.btnsrc = New System.Windows.Forms.Button()
        Me.txtitem = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnadd = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtqn = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtnm = New System.Windows.Forms.TextBox()
        Me.txtpr = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtno = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtmrp = New System.Windows.Forms.TextBox()
        Me.btnupdt = New System.Windows.Forms.Button()
        Me.btndlt = New System.Windows.Forms.Button()
        CType(Me.GridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GridView
        '
        Me.GridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.GridView.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.GridView.Location = New System.Drawing.Point(0, 197)
        Me.GridView.Name = "GridView"
        Me.GridView.RowTemplate.Height = 25
        Me.GridView.Size = New System.Drawing.Size(734, 199)
        Me.GridView.TabIndex = 0
        '
        'btnsw
        '
        Me.btnsw.Location = New System.Drawing.Point(566, 130)
        Me.btnsw.Name = "btnsw"
        Me.btnsw.Size = New System.Drawing.Size(107, 23)
        Me.btnsw.TabIndex = 1
        Me.btnsw.Text = "Show all"
        Me.btnsw.UseVisualStyleBackColor = True
        '
        'btnsrc
        '
        Me.btnsrc.Location = New System.Drawing.Point(269, 168)
        Me.btnsrc.Name = "btnsrc"
        Me.btnsrc.Size = New System.Drawing.Size(107, 23)
        Me.btnsrc.TabIndex = 2
        Me.btnsrc.Text = "Search item"
        Me.btnsrc.UseVisualStyleBackColor = True
        '
        'txtitem
        '
        Me.txtitem.Location = New System.Drawing.Point(12, 168)
        Me.txtitem.Name = "txtitem"
        Me.txtitem.Size = New System.Drawing.Size(251, 23)
        Me.txtitem.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label1.ForeColor = System.Drawing.Color.DimGray
        Me.Label1.Location = New System.Drawing.Point(289, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(177, 37)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Grocery Store"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnadd)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.txtqn)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.txtnm)
        Me.GroupBox1.Controls.Add(Me.txtpr)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txtno)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.txtmrp)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 47)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(481, 115)
        Me.GroupBox1.TabIndex = 5
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Add item"
        '
        'btnadd
        '
        Me.btnadd.Location = New System.Drawing.Point(311, 86)
        Me.btnadd.Name = "btnadd"
        Me.btnadd.Size = New System.Drawing.Size(107, 23)
        Me.btnadd.TabIndex = 12
        Me.btnadd.Text = "Add item"
        Me.btnadd.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(271, 57)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(53, 15)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "Quantity"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(24, 54)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(39, 15)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Name"
        '
        'txtqn
        '
        Me.txtqn.Location = New System.Drawing.Point(336, 54)
        Me.txtqn.Name = "txtqn"
        Me.txtqn.Size = New System.Drawing.Size(125, 23)
        Me.txtqn.TabIndex = 10
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(271, 28)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(54, 15)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Sell price"
        '
        'txtnm
        '
        Me.txtnm.Location = New System.Drawing.Point(109, 51)
        Me.txtnm.Name = "txtnm"
        Me.txtnm.Size = New System.Drawing.Size(125, 23)
        Me.txtnm.TabIndex = 2
        '
        'txtpr
        '
        Me.txtpr.Location = New System.Drawing.Point(336, 25)
        Me.txtpr.Name = "txtpr"
        Me.txtpr.Size = New System.Drawing.Size(125, 23)
        Me.txtpr.TabIndex = 8
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(24, 28)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(76, 15)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Item number"
        '
        'txtno
        '
        Me.txtno.Location = New System.Drawing.Point(109, 22)
        Me.txtno.Name = "txtno"
        Me.txtno.Size = New System.Drawing.Size(125, 23)
        Me.txtno.TabIndex = 0
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(24, 83)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(32, 15)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "MRP"
        '
        'txtmrp
        '
        Me.txtmrp.Location = New System.Drawing.Point(109, 80)
        Me.txtmrp.Name = "txtmrp"
        Me.txtmrp.Size = New System.Drawing.Size(125, 23)
        Me.txtmrp.TabIndex = 6
        '
        'btnupdt
        '
        Me.btnupdt.Location = New System.Drawing.Point(566, 58)
        Me.btnupdt.Name = "btnupdt"
        Me.btnupdt.Size = New System.Drawing.Size(107, 23)
        Me.btnupdt.TabIndex = 6
        Me.btnupdt.Text = "Update"
        Me.btnupdt.UseVisualStyleBackColor = True
        '
        'btndlt
        '
        Me.btndlt.Location = New System.Drawing.Point(566, 93)
        Me.btndlt.Name = "btndlt"
        Me.btndlt.Size = New System.Drawing.Size(107, 23)
        Me.btndlt.TabIndex = 7
        Me.btndlt.Text = "Delete"
        Me.btndlt.UseVisualStyleBackColor = True
        '
        'manageGrocery
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(734, 396)
        Me.Controls.Add(Me.btndlt)
        Me.Controls.Add(Me.btnupdt)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtitem)
        Me.Controls.Add(Me.btnsrc)
        Me.Controls.Add(Me.btnsw)
        Me.Controls.Add(Me.GridView)
        Me.Name = "manageGrocery"
        Me.Text = "manageGrocery"
        CType(Me.GridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GridView As DataGridView
    Friend WithEvents btnsw As Button
    Friend WithEvents btnsrc As Button
    Friend WithEvents txtitem As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtnm As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtno As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtmrp As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtpr As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtqn As TextBox
    Friend WithEvents btnadd As Button
    Friend WithEvents btnupdt As Button
    Friend WithEvents btndlt As Button
End Class
