Public Class editOwnerDetails
    Public Property CurrentAccount As Form1.Account

    Private Sub EditOwnerDetailsForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If CurrentAccount IsNot Nothing Then
            txtName.Text = CurrentAccount.getName()
            txtAge.Text = CurrentAccount.getAge().ToString()
            txtSex.Text = CurrentAccount.getSex()
            txtAddress.Text = CurrentAccount.getAdd()
        End If
    End Sub

    Private Sub btnSaveOwner_Click_1(sender As Object, e As EventArgs) Handles btnSaveOwner.Click
        If CurrentAccount IsNot Nothing Then
            CurrentAccount.setCreds(txtName.Text, txtAddress.Text, Val(txtAge.Text), txtSex.Text)
        End If
        Me.Close()
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

End Class