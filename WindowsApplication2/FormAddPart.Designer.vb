<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormAddPart
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
        Dim PART_NAMELabel As System.Windows.Forms.Label
        Dim PART_CAT_NAMELabel As System.Windows.Forms.Label
        Dim LABORLabel As System.Windows.Forms.Label
        Dim DESCLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormAddPart))
        Me.DelPartsDataSet = New WindowsApplication2.DelPartsDataSet()
        Me.PartsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PartsTableAdapter = New WindowsApplication2.DelPartsDataSetTableAdapters.PartsTableAdapter()
        Me.TableAdapterManager = New WindowsApplication2.DelPartsDataSetTableAdapters.TableAdapterManager()
        Me.PartsBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.PartsBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.ButtonAddPart = New System.Windows.Forms.Button()
        Me.ComboBoxCategory = New System.Windows.Forms.ComboBox()
        Me.Parts_CategoryBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TextBoxName = New System.Windows.Forms.TextBox()
        Me.TextBoxLabor = New System.Windows.Forms.TextBox()
        Me.TextBoxPrice = New System.Windows.Forms.TextBox()
        Me.TextBoxDesc = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.ToolTip2 = New System.Windows.Forms.ToolTip(Me.components)
        Me.ToolTipName = New System.Windows.Forms.ToolTip(Me.components)
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        PART_NAMELabel = New System.Windows.Forms.Label()
        PART_CAT_NAMELabel = New System.Windows.Forms.Label()
        LABORLabel = New System.Windows.Forms.Label()
        DESCLabel = New System.Windows.Forms.Label()
        CType(Me.DelPartsDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PartsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PartsBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PartsBindingNavigator.SuspendLayout()
        CType(Me.Parts_CategoryBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
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
        'PART_CAT_NAMELabel
        '
        PART_CAT_NAMELabel.AutoSize = True
        PART_CAT_NAMELabel.Location = New System.Drawing.Point(370, 33)
        PART_CAT_NAMELabel.Name = "PART_CAT_NAMELabel"
        PART_CAT_NAMELabel.Size = New System.Drawing.Size(93, 16)
        PART_CAT_NAMELabel.TabIndex = 5
        PART_CAT_NAMELabel.Text = "Part Category:"
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
        'DESCLabel
        '
        DESCLabel.AutoSize = True
        DESCLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DESCLabel.Location = New System.Drawing.Point(5, 11)
        DESCLabel.Name = "DESCLabel"
        DESCLabel.Size = New System.Drawing.Size(93, 20)
        DESCLabel.TabIndex = 11
        DESCLabel.Text = "Description:"
        AddHandler DESCLabel.Click, AddressOf Me.DESCLabel_Click
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
        'PartsBindingNavigator
        '
        Me.PartsBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.PartsBindingNavigator.BindingSource = Me.PartsBindingSource
        Me.PartsBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.PartsBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.PartsBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.PartsBindingNavigatorSaveItem})
        Me.PartsBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.PartsBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.PartsBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.PartsBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.PartsBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.PartsBindingNavigator.Name = "PartsBindingNavigator"
        Me.PartsBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.PartsBindingNavigator.Size = New System.Drawing.Size(884, 25)
        Me.PartsBindingNavigator.TabIndex = 0
        Me.PartsBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorAddNewItem.Text = "Add new"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(35, 22)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorDeleteItem.Text = "Delete"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveFirstItem.Text = "Move first"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMovePreviousItem.Text = "Move previous"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Position"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 23)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Current position"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveNextItem.Text = "Move next"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveLastItem.Text = "Move last"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'PartsBindingNavigatorSaveItem
        '
        Me.PartsBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.PartsBindingNavigatorSaveItem.Image = CType(resources.GetObject("PartsBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.PartsBindingNavigatorSaveItem.Name = "PartsBindingNavigatorSaveItem"
        Me.PartsBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.PartsBindingNavigatorSaveItem.Text = "Save Data"
        '
        'ButtonAddPart
        '
        Me.ButtonAddPart.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonAddPart.Location = New System.Drawing.Point(646, 369)
        Me.ButtonAddPart.Name = "ButtonAddPart"
        Me.ButtonAddPart.Size = New System.Drawing.Size(195, 69)
        Me.ButtonAddPart.TabIndex = 13
        Me.ButtonAddPart.Text = "Add Part"
        Me.ButtonAddPart.UseVisualStyleBackColor = True
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
        'Parts_CategoryBindingSource
        '
        Me.Parts_CategoryBindingSource.DataMember = "Parts_Category"
        Me.Parts_CategoryBindingSource.DataSource = Me.DelPartsDataSet
        '
        'TextBoxName
        '
        Me.TextBoxName.Location = New System.Drawing.Point(104, 30)
        Me.TextBoxName.Name = "TextBoxName"
        Me.TextBoxName.Size = New System.Drawing.Size(215, 22)
        Me.TextBoxName.TabIndex = 15
        '
        'TextBoxLabor
        '
        Me.TextBoxLabor.Location = New System.Drawing.Point(486, 44)
        Me.TextBoxLabor.Name = "TextBoxLabor"
        Me.TextBoxLabor.Size = New System.Drawing.Size(257, 20)
        Me.TextBoxLabor.TabIndex = 16
        '
        'TextBoxPrice
        '
        Me.TextBoxPrice.Location = New System.Drawing.Point(104, 40)
        Me.TextBoxPrice.Name = "TextBoxPrice"
        Me.TextBoxPrice.Size = New System.Drawing.Size(215, 20)
        Me.TextBoxPrice.TabIndex = 17
        '
        'TextBoxDesc
        '
        Me.TextBoxDesc.Location = New System.Drawing.Point(104, 31)
        Me.TextBoxDesc.MaximumSize = New System.Drawing.Size(100000, 50)
        Me.TextBoxDesc.MinimumSize = New System.Drawing.Size(100, 50)
        Me.TextBoxDesc.Name = "TextBoxDesc"
        Me.TextBoxDesc.Size = New System.Drawing.Size(639, 20)
        Me.TextBoxDesc.TabIndex = 18
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
        'ToolTipName
        '
        Me.ToolTipName.ToolTipTitle = "asdfasdfasdf"
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
        Me.Panel1.Location = New System.Drawing.Point(45, 39)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(796, 78)
        Me.Panel1.TabIndex = 20
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
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel3.Controls.Add(Me.Label3)
        Me.Panel3.Controls.Add(Me.TextBoxPrice)
        Me.Panel3.Controls.Add(Me.Label1)
        Me.Panel3.Controls.Add(Me.TextBoxLabor)
        Me.Panel3.Controls.Add(LABORLabel)
        Me.Panel3.Location = New System.Drawing.Point(45, 133)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(796, 100)
        Me.Panel3.TabIndex = 22
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
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.TextBoxDesc)
        Me.Panel2.Controls.Add(DESCLabel)
        Me.Panel2.Location = New System.Drawing.Point(45, 253)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(796, 100)
        Me.Panel2.TabIndex = 23
        '
        'FormAddPart
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(884, 462)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.ButtonAddPart)
        Me.Controls.Add(Me.PartsBindingNavigator)
        Me.Name = "FormAddPart"
        Me.Text = "Add New Part"
        CType(Me.DelPartsDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PartsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PartsBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PartsBindingNavigator.ResumeLayout(False)
        Me.PartsBindingNavigator.PerformLayout()
        CType(Me.Parts_CategoryBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DelPartsDataSet As WindowsApplication2.DelPartsDataSet
    Friend WithEvents PartsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents PartsTableAdapter As WindowsApplication2.DelPartsDataSetTableAdapters.PartsTableAdapter
    Friend WithEvents TableAdapterManager As WindowsApplication2.DelPartsDataSetTableAdapters.TableAdapterManager
    Friend WithEvents PartsBindingNavigator As System.Windows.Forms.BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As System.Windows.Forms.ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents PartsBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents ButtonAddPart As System.Windows.Forms.Button
    Friend WithEvents ComboBoxCategory As System.Windows.Forms.ComboBox
    Friend WithEvents TextBoxName As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxLabor As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxPrice As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxDesc As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents ToolTip2 As System.Windows.Forms.ToolTip
    Friend WithEvents ToolTipName As System.Windows.Forms.ToolTip
    Friend WithEvents Parts_CategoryBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label

End Class
