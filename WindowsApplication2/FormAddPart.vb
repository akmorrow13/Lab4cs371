﻿Public Class FormAddPart

    Private Sub PartsBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles PartsBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.PartsBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DelPartsDataSet)

    End Sub

    Private Sub DESCLabel_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxCategory.SelectedIndexChanged

    End Sub

    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles TextBoxPrice.TextChanged

    End Sub


    ' Adds a new part to the parts table of the Parts database

    Private Sub ButtonAddPart_Click(sender As Object, e As EventArgs) Handles ButtonAddPart.Click

        ' Validate user inputs for new part
        Dim valid As Boolean
        Dim id As Integer

        valid = validInputs()

        If valid Then
            Try
                id = Me.PartsTableAdapter.ScalarMaxPARTID()
                MessageBox.Show(id)
                Me.PartsTableAdapter.InsertNewPart(id + 1, TextBoxName.Text, ComboBoxCategory.SelectedValue, TextBoxLabor.Text, TextBoxPrice.Text, TextBoxDesc.Text)
            Catch ex As Exception
                handleSQLException()
                Return
            End Try
            ' validation succeeded. Insert new part in database

        Else
            Return
        End If

    End Sub

    Function validInputs() As Boolean

        ' Validate part name

        If (TextBoxName.Equals("") Or TextBoxName.Equals(vbNull)) Then
            MessageBox.Show("Please enter a valid name")
            Return False
        End If

        ' validate description

        If (TextBoxDesc.Equals("") Or TextBoxDesc.Equals(vbNull)) Then
            MessageBox.Show("Please enter a valid description")
            Return False
        End If

        ' validate price

        If (Not IsNumeric(TextBoxPrice.Text)) Then
            MessageBox.Show("Please enter a valid price")
            Return False
        ElseIf (TextBoxPrice.Text < 0) Then
            MessageBox.Show("Please enter a valid price")
            Return False
        End If

        ' validate labor cost

        If (Not IsNumeric(TextBoxLabor.Text)) Then
            MessageBox.Show("Please enter a valid labor cost")
            Return False
        ElseIf (TextBoxLabor.Text < 0) Then
            MessageBox.Show("Please enter a valid labor cost")
            Return False
        End If

        Return True

    End Function


    ' Handles form load for creating a new part to be added to the database

    Private Sub FormAddPart_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ' Auto populate combo box for part categories

        Me.PartsTableAdapter.Fill(Me.DelPartsDataSet.Parts)

        Dim tableAdapter As New DelPartsDataSetTableAdapters.PartsTableAdapter()
        Dim categoryList As EnumerableRowCollection(Of DelPartsDataSet.PartsRow)

        Try
            categoryList = tableAdapter.GetDataByCategoryName.AsEnumerable
        Catch ex As Exception
            handleSQLException()
            Return
        End Try

        ComboBoxCategory.ValueMember = categoryList.ToString
        ComboBoxCategory.DisplayMember = categoryList.ToString

    End Sub


    ' Handles SQL exceptions
    Private Sub handleSQLException()
        MessageBox.Show("An SQL Error has occured. Please contact your local Administrator")
        Return
    End Sub
End Class
