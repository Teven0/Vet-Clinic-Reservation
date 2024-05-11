Public Class Admin

    Private Sub Admin_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim counter = 0
        For Each schedule In Form1.allSched
            adminSched.Items.Add(schedule.getOwner)
            adminSched.Items(counter).SubItems.Add(schedule.getPet.getName)
            adminSched.Items(counter).SubItems.Add(schedule.getPet.getPType)
            adminSched.Items(counter).SubItems.Add(schedule.getProcedure)
            adminSched.Items(counter).SubItems.Add(schedule.getPet.getVacs)
            adminSched.Items(counter).SubItems.Add(schedule.getDate)
            counter += 1
        Next

        For Each account In Form1.listAccount
            cmbOwners.Items.Add(account.getName)
        Next
    End Sub

    Dim acc As String

    Private Sub cmbOwners_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbOwners.SelectedIndexChanged
        cmbPets.Items.Clear()
        For Each account In Form1.listAccount
            If cmbOwners.Text = account.getName Then
                For Each pet In account.getPets
                    cmbPets.Items.Add(pet.getName)
                Next
            End If
        Next
    End Sub

End Class