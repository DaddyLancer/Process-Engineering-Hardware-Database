Public Class Form1
    Private Sub PCTableBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) 
        Me.Validate()
        Me.PCTableBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.HardwareDatabaseDataSet)

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'HardwareDatabaseDataSet.PCTable' table. You can move, or remove it, as needed.
        Me.PCTableTableAdapter.Fill(Me.HardwareDatabaseDataSet.PCTable)

    End Sub

    Private Sub PCTableBindingNavigator_RefreshItems(sender As Object, e As EventArgs) 

    End Sub
End Class
