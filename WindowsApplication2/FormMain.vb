Imports System.Windows.Forms

Public Class FormMain



    ' Exits application

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
    End Sub


    ' Displays form for adding a new part to the database

    Private Sub AddPartToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddPartToolStripMenuItem.Click

        FormAddPart.MdiParent = Me
        FormAddPart.WindowState = FormWindowState.Maximized
        FormAddPart.Show()

    End Sub

    Private Sub ButtonAddPart_Click(sender As Object, e As EventArgs) Handles ButtonAddPart.Click

        ' Validate user inputs for new part
        Dim valid As Boolean
        Dim id As Integer

        valid = validInputs()

        If valid Then
            Try
                id = Me.PartsTableAdapter.ScalarMaxPARTID()
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

    Private Sub PartsBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.PartsBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DelPartsDataSet)

    End Sub

    Private Sub FormMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DelPartsDataSet.Parts' table. You can move, or remove it, as needed.
        Me.PartsTableAdapter.Fill(Me.DelPartsDataSet.Parts)

    End Sub

    ' Handles SQL exceptions
    Private Sub handleSQLException()
        MessageBox.Show("An SQL Error has occured. Please contact your local Administrator")
        Return
    End Sub

End Class

