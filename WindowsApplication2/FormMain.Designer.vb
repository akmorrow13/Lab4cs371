<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormMain
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
        Me.components = New System.ComponentModel.Container()
        Dim DESCLabel As System.Windows.Forms.Label
        Dim LABORLabel As System.Windows.Forms.Label
        Dim PART_NAMELabel As System.Windows.Forms.Label
        Dim PART_CAT_NAMELabel As System.Windows.Forms.Label
        Me.MenuStrip = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SearchPartsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AddPartToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.TabControlAddPart = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.TextBoxDesc = New System.Windows.Forms.TextBox()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TextBoxPrice = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBoxLabor = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBoxName = New System.Windows.Forms.TextBox()
        Me.ComboBoxCategory = New System.Windows.Forms.ComboBox()
        Me.ButtonAddPart = New System.Windows.Forms.Button()
        Me.DelPartsDataSet = New WindowsApplication2.DelPartsDataSet()
        Me.PartsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PartsTableAdapter = New WindowsApplication2.DelPartsDataSetTableAdapters.PartsTableAdapter()
        Me.TableAdapterManager = New WindowsApplication2.DelPartsDataSetTableAdapters.TableAdapterManager()
        DESCLabel = New System.Windows.Forms.Label()
        LABORLabel = New System.Windows.Forms.Label()
        PART_NAMELabel = New System.Windows.Forms.Label()
        PART_CAT_NAMELabel = New System.Windows.Forms.Label()
        Me.MenuStrip.SuspendLayout()
        Me.TabControlAddPart.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.DelPartsDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PartsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip
        '
        Me.MenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem})
        Me.MenuStrip.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip.Name = "MenuStrip"
        Me.MenuStrip.Size = New System.Drawing.Size(853, 24)
        Me.MenuStrip.TabIndex = 5
        Me.MenuStrip.Text = "MenuStrip"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SearchPartsToolStripMenuItem, Me.AddPartToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'SearchPartsToolStripMenuItem
        '
        Me.SearchPartsToolStripMenuItem.Name = "SearchPartsToolStripMenuItem"
        Me.SearchPartsToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.SearchPartsToolStripMenuItem.Text = "Search Parts"
        '
        'AddPartToolStripMenuItem
        '
        Me.AddPartToolStripMenuItem.Name = "AddPartToolStripMenuItem"
        Me.AddPartToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.AddPartToolStripMenuItem.Text = "Add Part"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'TabControlAddPart
        '
        Me.TabControlAddPart.Controls.Add(Me.TabPage1)
        Me.TabControlAddPart.Controls.Add(Me.TabPage2)
        Me.TabControlAddPart.Location = New System.Drawing.Point(10, 41)
        Me.TabControlAddPart.Name = "TabControlAddPart"
        Me.TabControlAddPart.SelectedIndex = 0
        Me.TabControlAddPart.Size = New System.Drawing.Size(831, 471)
        Me.TabControlAddPart.TabIndex = 9
        '
        'TabPage1
        '
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(729, 384)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "View Parts"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'TabPage2
        '
        Me.TabPage2.AutoScroll = True
        Me.TabPage2.Controls.Add(Me.Panel2)
        Me.TabPage2.Controls.Add(Me.Panel3)
        Me.TabPage2.Controls.Add(Me.Panel1)
        Me.TabPage2.Controls.Add(Me.ButtonAddPart)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(823, 445)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Add New Part"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.TextBoxDesc)
        Me.Panel2.Controls.Add(DESCLabel)
        Me.Panel2.Location = New System.Drawing.Point(8, 249)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(796, 100)
        Me.Panel2.TabIndex = 27
        '
        'TextBoxDesc
        '
        Me.TextBoxDesc.Location = New System.Drawing.Point(104, 31)
        Me.TextBoxDesc.MaximumSize = New System.Drawing.Size(100000, 50)
        Me.TextBoxDesc.MinimumSize = New System.Drawing.Size(100, 50)
        Me.TextBoxDesc.Name = "TextBoxDesc"
        Me.TextBoxDesc.Size = New System.Drawing.Size(639, 50)
        Me.TextBoxDesc.TabIndex = 18
        '
        'DESCLabel
        '
        DESCLabel.AutoSize = True
        DESCLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DESCLabel.Location = New System.Drawing.Point(5, 11)
        DESCLabel.Name = "DESCLabel"
        DESCLabel.Size = New System.Drawing.Size(93, 20)
        DESCLabel.TabIndex = 11
        DESCLabel.Text = "Description:"
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel3.Controls.Add(Me.Label3)
        Me.Panel3.Controls.Add(Me.TextBoxPrice)
        Me.Panel3.Controls.Add(Me.Label1)
        Me.Panel3.Controls.Add(Me.TextBoxLabor)
        Me.Panel3.Controls.Add(LABORLabel)
        Me.Panel3.Location = New System.Drawing.Point(8, 131)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(796, 100)
        Me.Panel3.TabIndex = 26
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(3, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(132, 20)
        Me.Label3.TabIndex = 20
        Me.Label3.Text = "Pricing and Labor"
        '
        'TextBoxPrice
        '
        Me.TextBoxPrice.Location = New System.Drawing.Point(104, 40)
        Me.TextBoxPrice.Name = "TextBoxPrice"
        Me.TextBoxPrice.Size = New System.Drawing.Size(215, 20)
        Me.TextBoxPrice.TabIndex = 17
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(27, 40)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(52, 16)
        Me.Label1.TabIndex = 19
        Me.Label1.Text = "Price: $"
        '
        'TextBoxLabor
        '
        Me.TextBoxLabor.Location = New System.Drawing.Point(486, 44)
        Me.TextBoxLabor.Name = "TextBoxLabor"
        Me.TextBoxLabor.Size = New System.Drawing.Size(257, 20)
        Me.TextBoxLabor.TabIndex = 16
        '
        'LABORLabel
        '
        LABORLabel.AutoSize = True
        LABORLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        LABORLabel.Location = New System.Drawing.Point(370, 47)
        LABORLabel.Name = "LABORLabel"
        LABORLabel.Size = New System.Drawing.Size(56, 16)
        LABORLabel.TabIndex = 7
        LABORLabel.Text = "Labor: $"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.TextBoxName)
        Me.Panel1.Controls.Add(PART_NAMELabel)
        Me.Panel1.Controls.Add(Me.ComboBoxCategory)
        Me.Panel1.Controls.Add(PART_CAT_NAMELabel)
        Me.Panel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel1.Location = New System.Drawing.Point(8, 29)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(796, 78)
        Me.Panel1.TabIndex = 25
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(13, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(66, 20)
        Me.Label2.TabIndex = 16
        Me.Label2.Text = "General"
        '
        'TextBoxName
        '
        Me.TextBoxName.Location = New System.Drawing.Point(104, 30)
        Me.TextBoxName.Name = "TextBoxName"
        Me.TextBoxName.Size = New System.Drawing.Size(215, 22)
        Me.TextBoxName.TabIndex = 15
        '
        'PART_NAMELabel
        '
        PART_NAMELabel.AutoSize = True
        PART_NAMELabel.Location = New System.Drawing.Point(27, 33)
        PART_NAMELabel.Name = "PART_NAMELabel"
        PART_NAMELabel.Size = New System.Drawing.Size(75, 16)
        PART_NAMELabel.TabIndex = 3
        PART_NAMELabel.Text = "Part Name:"
        '
        'ComboBoxCategory
        '
        Me.ComboBoxCategory.DataSource = Me.PartsBindingSource
        Me.ComboBoxCategory.DisplayMember = "PART_CAT_NAME"
        Me.ComboBoxCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBoxCategory.FormattingEnabled = True
        Me.ComboBoxCategory.Location = New System.Drawing.Point(486, 29)
        Me.ComboBoxCategory.Name = "ComboBoxCategory"
        Me.ComboBoxCategory.Size = New System.Drawing.Size(257, 24)
        Me.ComboBoxCategory.TabIndex = 14
        Me.ComboBoxCategory.ValueMember = "PART_CAT_NAME"
        '
        'PART_CAT_NAMELabel
        '
        PART_CAT_NAMELabel.AutoSize = True
        PART_CAT_NAMELabel.Location = New System.Drawing.Point(370, 33)
        PART_CAT_NAMELabel.Name = "PART_CAT_NAMELabel"
        PART_CAT_NAMELabel.Size = New System.Drawing.Size(93, 16)
        PART_CAT_NAMELabel.TabIndex = 5
        PART_CAT_NAMELabel.Text = "Part Category:"
        '
        'ButtonAddPart
        '
        Me.ButtonAddPart.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonAddPart.Location = New System.Drawing.Point(609, 355)
        Me.ButtonAddPart.Name = "ButtonAddPart"
        Me.ButtonAddPart.Size = New System.Drawing.Size(195, 69)
        Me.ButtonAddPart.TabIndex = 24
        Me.ButtonAddPart.Text = "Add Part"
        Me.ButtonAddPart.UseVisualStyleBackColor = True
        '
        'DelPartsDataSet
        '
        Me.DelPartsDataSet.DataSetName = "DelPartsDataSet"
        Me.DelPartsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'PartsBindingSource
        '
        Me.PartsBindingSource.DataMember = "Parts"
        Me.PartsBindingSource.DataSource = Me.DelPartsDataSet
        '
        'PartsTableAdapter
        '
        Me.PartsTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.OrderCostTableAdapter = Nothing
        Me.TableAdapterManager.OrderStatusTableAdapter = Nothing
        Me.TableAdapterManager.PartsTableAdapter = Me.PartsTableAdapter
        Me.TableAdapterManager.UpdateOrder = WindowsApplication2.DelPartsDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'FormMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(853, 534)
        Me.Controls.Add(Me.TabControlAddPart)
        Me.Controls.Add(Me.MenuStrip)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip
        Me.Name = "FormMain"
        Me.Text = "Parts Management"
        Me.MenuStrip.ResumeLayout(False)
        Me.MenuStrip.PerformLayout()
        Me.TabControlAddPart.ResumeLayout(False)
        Me.TabPage2.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.DelPartsDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PartsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolTip As System.Windows.Forms.ToolTip
    Friend WithEvents MenuStrip As System.Windows.Forms.MenuStrip
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SearchPartsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AddPartToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TabControlAddPart As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents TextBoxDesc As System.Windows.Forms.TextBox
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TextBoxPrice As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TextBoxLabor As System.Windows.Forms.TextBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TextBoxName As System.Windows.Forms.TextBox
    Friend WithEvents ComboBoxCategory As System.Windows.Forms.ComboBox
    Friend WithEvents ButtonAddPart As System.Windows.Forms.Button
    Friend WithEvents DelPartsDataSet As WindowsApplication2.DelPartsDataSet
    Friend WithEvents PartsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents PartsTableAdapter As WindowsApplication2.DelPartsDataSetTableAdapters.PartsTableAdapter
    Friend WithEvents TableAdapterManager As WindowsApplication2.DelPartsDataSetTableAdapters.TableAdapterManager

End Class
