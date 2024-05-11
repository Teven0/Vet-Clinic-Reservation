Public Class Form2
    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Dim newOwner As New Form1.Account
        newOwner.setCred(txtUser.Text, txtPass.Text, txtAdds.Text, Val(txtAge.Text), cmbSex.Text)
        Form1.listAccount.Add(newOwner)
        MsgBox("Created Account Successfully")
        Form1.Show()
        Me.Close()

    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
        Form1.Show()
    End Sub
End Class