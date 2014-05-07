Public Class Form1

    Private Sub FuncionarioBindingNavigatorSaveItem_Click(sender As System.Object, e As System.EventArgs) Handles FuncionarioBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.FuncionarioBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DS_Sesion)

    End Sub

    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'DS_Sesion.Funcionario' Puede moverla o quitarla según sea necesario.
        Me.FuncionarioTableAdapter.Fill(Me.DS_Sesion.Funcionario)

    End Sub
End Class
