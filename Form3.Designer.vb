<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.HomeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AddToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.rbName = New System.Windows.Forms.RadioButton()
        Me.rbCat = New System.Windows.Forms.RadioButton()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.cbCat2 = New System.Windows.Forms.ComboBox()
        Me.lblID = New System.Windows.Forms.Label()
        Me.cbCat = New System.Windows.Forms.ComboBox()
        Me.txtItem = New System.Windows.Forms.TextBox()
        Me.txtQty = New System.Windows.Forms.TextBox()
        Me.txtLoc = New System.Windows.Forms.TextBox()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 33)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(305, 20)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Inventory Management System (IMS)"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.HomeToolStripMenuItem, Me.AddToolStripMenuItem, Me.ExitToolStripMenuItem, Me.AboutToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(476, 24)
        Me.MenuStrip1.TabIndex = 4
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'HomeToolStripMenuItem
        '
        Me.HomeToolStripMenuItem.Name = "HomeToolStripMenuItem"
        Me.HomeToolStripMenuItem.Size = New System.Drawing.Size(52, 20)
        Me.HomeToolStripMenuItem.Text = "Home"
        '
        'AddToolStripMenuItem
        '
        Me.AddToolStripMenuItem.Name = "AddToolStripMenuItem"
        Me.AddToolStripMenuItem.Size = New System.Drawing.Size(41, 20)
        Me.AddToolStripMenuItem.Text = "Add"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(38, 20)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(52, 20)
        Me.AboutToolStripMenuItem.Text = "About"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 68)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(21, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "ID:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 96)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(61, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Item Name:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 122)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(52, 13)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Category:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(14, 156)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(49, 13)
        Me.Label6.TabIndex = 8
        Me.Label6.Text = "Quantity:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(12, 183)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(51, 13)
        Me.Label7.TabIndex = 9
        Me.Label7.Text = "Location:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Fuchsia
        Me.Label5.Location = New System.Drawing.Point(248, 95)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(60, 16)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Search:"
        '
        'rbName
        '
        Me.rbName.AutoSize = True
        Me.rbName.Location = New System.Drawing.Point(251, 114)
        Me.rbName.Name = "rbName"
        Me.rbName.Size = New System.Drawing.Size(56, 17)
        Me.rbName.TabIndex = 11
        Me.rbName.TabStop = True
        Me.rbName.Text = "Name:"
        Me.rbName.UseVisualStyleBackColor = True
        '
        'rbCat
        '
        Me.rbCat.AutoSize = True
        Me.rbCat.Location = New System.Drawing.Point(251, 138)
        Me.rbCat.Name = "rbCat"
        Me.rbCat.Size = New System.Drawing.Size(70, 17)
        Me.rbCat.TabIndex = 12
        Me.rbCat.TabStop = True
        Me.rbCat.Text = "Category:"
        Me.rbCat.UseVisualStyleBackColor = True
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(357, 114)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(105, 20)
        Me.txtName.TabIndex = 13
        '
        'cbCat2
        '
        Me.cbCat2.FormattingEnabled = True
        Me.cbCat2.Items.AddRange(New Object() {"Furniture", "Stationary", "IT Equipment", "Other"})
        Me.cbCat2.Location = New System.Drawing.Point(357, 141)
        Me.cbCat2.Name = "cbCat2"
        Me.cbCat2.Size = New System.Drawing.Size(105, 21)
        Me.cbCat2.TabIndex = 14
        '
        'lblID
        '
        Me.lblID.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblID.Location = New System.Drawing.Point(80, 67)
        Me.lblID.Name = "lblID"
        Me.lblID.Size = New System.Drawing.Size(64, 22)
        Me.lblID.TabIndex = 15
        '
        'cbCat
        '
        Me.cbCat.FormattingEnabled = True
        Me.cbCat.Items.AddRange(New Object() {"Furniture", "Stationary", "IT Equipment", "Other"})
        Me.cbCat.Location = New System.Drawing.Point(80, 119)
        Me.cbCat.Name = "cbCat"
        Me.cbCat.Size = New System.Drawing.Size(134, 21)
        Me.cbCat.TabIndex = 16
        '
        'txtItem
        '
        Me.txtItem.Location = New System.Drawing.Point(80, 93)
        Me.txtItem.Name = "txtItem"
        Me.txtItem.Size = New System.Drawing.Size(134, 20)
        Me.txtItem.TabIndex = 17
        '
        'txtQty
        '
        Me.txtQty.Location = New System.Drawing.Point(80, 149)
        Me.txtQty.Name = "txtQty"
        Me.txtQty.Size = New System.Drawing.Size(134, 20)
        Me.txtQty.TabIndex = 18
        '
        'txtLoc
        '
        Me.txtLoc.Location = New System.Drawing.Point(80, 176)
        Me.txtLoc.Name = "txtLoc"
        Me.txtLoc.Size = New System.Drawing.Size(134, 20)
        Me.txtLoc.TabIndex = 19
        '
        'btnUpdate
        '
        Me.btnUpdate.Location = New System.Drawing.Point(30, 213)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(75, 23)
        Me.btnUpdate.TabIndex = 20
        Me.btnUpdate.Text = "Update"
        Me.btnUpdate.UseVisualStyleBackColor = True
        '
        'btnDelete
        '
        Me.btnDelete.Location = New System.Drawing.Point(111, 213)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(75, 23)
        Me.btnDelete.TabIndex = 21
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(192, 213)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(75, 23)
        Me.btnClear.TabIndex = 22
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnSearch
        '
        Me.btnSearch.Location = New System.Drawing.Point(251, 173)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(75, 23)
        Me.btnSearch.TabIndex = 23
        Me.btnSearch.Text = "Search"
        Me.btnSearch.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(30, 245)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(407, 150)
        Me.DataGridView1.TabIndex = 24
        '
        'Form3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(476, 407)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.btnSearch)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnUpdate)
        Me.Controls.Add(Me.txtLoc)
        Me.Controls.Add(Me.txtQty)
        Me.Controls.Add(Me.txtItem)
        Me.Controls.Add(Me.cbCat)
        Me.Controls.Add(Me.lblID)
        Me.Controls.Add(Me.cbCat2)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.rbCat)
        Me.Controls.Add(Me.rbName)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form3"
        Me.Text = "Form3"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents HomeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AddToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents rbName As RadioButton
    Friend WithEvents rbCat As RadioButton
    Friend WithEvents txtName As TextBox
    Friend WithEvents cbCat2 As ComboBox
    Friend WithEvents lblID As Label
    Friend WithEvents cbCat As ComboBox
    Friend WithEvents txtItem As TextBox
    Friend WithEvents txtQty As TextBox
    Friend WithEvents txtLoc As TextBox
    Friend WithEvents btnUpdate As Button
    Friend WithEvents btnDelete As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents btnSearch As Button
    Friend WithEvents DataGridView1 As DataGridView
End Class
