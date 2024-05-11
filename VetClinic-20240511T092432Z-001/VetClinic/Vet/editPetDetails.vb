Public Class editPetDetails
    Public Property CurrentPet As Form1.Pets

    Private Sub editPetDetails_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If CurrentPet IsNot Nothing Then
            txtPetName.Text = CurrentPet.getName()
            txtPetAge.Text = CurrentPet.getAge().ToString()
            txtPetBirthday.Value = CurrentPet.getbirth()
            txtPetWeight.Text = CurrentPet.getWeight()
            cmbPetType.Text = CurrentPet.getPType()
            cmbVaccineStatus.Text = CurrentPet.getVacs()
        End If
    End Sub

    Private Sub btnSaveChanges_Click(sender As Object, e As EventArgs) Handles btnSaveChanges.Click
        If CurrentPet IsNot Nothing Then
            CurrentPet.setInfo(txtPetName.Text, Val(txtPetAge.Text), txtPetBirthday.Text, txtPetWeight.Text, cmbPetType.Text, cmbVaccineStatus.Text)
            Me.Close()
        End If
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub


End Class