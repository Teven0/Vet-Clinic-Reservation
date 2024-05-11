
Imports Vet.Form1
Public Class Form3

    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        pnlApps.Hide()
        pnlBill.Hide()
        pnlOwner.Show()
        pnlPet.Hide()
        pnlReg.Hide()
        pnlSched.Hide()

        For Each pets In Form1.curAccount.getPets
            cmbPets.Items.Add(pets.getName)
        Next
        For Each pets In Form1.curAccount.getPets
            cmbPetSchedName.Items.Add(pets.getName)
        Next
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Form1.Show()
        Me.Close()
    End Sub

    Private Sub btnLog_Click(sender As Object, e As EventArgs) Handles btnLog.Click
        pnlOwner.Show()
        pnlApps.Hide()
        pnlBill.Hide()
        pnlPet.Hide()
        pnlReg.Hide()
        pnlSched.Hide()

        txtOwnerName.Text = Form1.curAccount.getName
        txtOwnerAdds.Text = Form1.curAccount.getAdd
        txtOwnerAge.Text = Form1.curAccount.getAge
        txtOwnerSex.Text = Form1.curAccount.getSex
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        pnlOwner.Hide()
        pnlApps.Hide()
        pnlBill.Hide()
        pnlPet.Hide()
        pnlReg.Show()
        pnlSched.Hide()
    End Sub

    Private Sub btnRegPet_Click(sender As Object, e As EventArgs) Handles btnRegPet.Click
        Dim newPet As New Form1.Pets
        newPet.setInfo(txtRegPetName.Text, Val(txtRegPetAge.Text), dtpRegPetBirth.Text, txtRegPetWeight.Text, cmbRegPetType.Text, cmbVacState.Text)
        Form1.curAccount.addPet(newPet)
        MsgBox("Pet Registered Successfully", vbInformation)
        cmbPets.Items.Add(newPet.getName)
        cmbPetSchedName.Items.Add(newPet.getName)
        txtRegPetAge.Clear()
        txtRegPetName.Clear()
        txtRegPetWeight.Clear()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        pnlOwner.Hide()
        pnlApps.Hide()
        pnlBill.Hide()
        pnlPet.Show()
        pnlReg.Hide()
        pnlSched.Hide()

    End Sub

    Private Sub cmbPets_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbPets.SelectedIndexChanged
        For Each pets In Form1.curAccount.getPets
            If cmbPets.Text = pets.getName Then
                txtPetType.Text = pets.getPType
                txtPetAge.Text = pets.getAge
                txtPetWeight.Text = pets.getWeight
                txtPetBirth.Text = pets.getbirth
                txtPetStatus.Text = pets.getVacs
                txtNextVisit.Text = pets.getVisit
            End If
        Next
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        pnlOwner.Hide()
        pnlApps.Hide()
        pnlBill.Hide()
        pnlPet.Hide()
        pnlReg.Hide()
        pnlSched.Show()

    End Sub

    Dim tempPrice As Integer
    Dim pricePet As Pets
    Dim AppsCounter = 0

    Private Sub cmbProd_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbProd.SelectedIndexChanged
        For Each pets In Form1.curAccount.getPets
            If cmbPetSchedName.Text = pets.getName Then

                If cmbProd.Text = "Check-Up" Then
                    Select Case pets.getPType
                        Case "Feline"
                            txtPrice.Text = "500"
                            tempPrice = 500
                        Case "Canine"
                            txtPrice.Text = "400"
                            tempPrice = 400
                        Case "Reptile"
                            txtPrice.Text = "600"
                            tempPrice = 600

                    End Select
                ElseIf cmbProd.Text = "Vaccine" Then
                    Select Case pets.getPType
                        Case "Feline"
                            txtPrice.Text = "1000"
                            tempPrice = 1000
                        Case "Canine"
                            txtPrice.Text = "1500"
                            tempPrice = 1500
                        Case "Reptile"
                            txtPrice.Text = "2000"
                            tempPrice = 2000

                    End Select
                End If

                pricePet = pets
            End If
        Next
    End Sub

    Private Sub btnSchedApp_Click(sender As Object, e As EventArgs) Handles btnSchedApp.Click
        If dtpAppDate.Text.Contains("Sunday") Then
            MsgBox("Vet is Closed in Sundays.", vbCritical)
        Else
            For Each schedule In Form1.allSched
                If dtpAppDate.Text = schedule.getDate Then
                    MsgBox("An Appointment is already at this day.", vbCritical)
                    Exit Sub
                End If
            Next
            Dim newSched As New Form1.Schedule
            newSched.setPet(pricePet)
            newSched.setDate(dtpAppDate.Text)
            newSched.setProcedure(cmbProd.Text, tempPrice)
            newSched.setOwner(Form1.curAccount.getName)
            pricePet.setLatestVisit(dtpAppDate.Text)
            Form1.curAccount.addAppointment(newSched)
            Form1.allSched.Add(newSched)
            MsgBox("Schedule Created!")

            Apps.Items.Add(newSched.getPet.getName)
            Apps.Items(AppsCounter).SubItems.add(newSched.getDate)
            Apps.Items(AppsCounter).SubItems.add(newSched.getProcedure)

            Bills.Items.Add(newSched.getPet.getPType)
            Bills.Items(AppsCounter).SubItems.add(newSched.getProcedure)
            Bills.Items(AppsCounter).SubItems.add(newSched.getPrice)

            AppsCounter += 1
        End If
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        pnlOwner.Hide()
        pnlApps.Show()
        pnlBill.Hide()
        pnlPet.Hide()
        pnlReg.Hide()
        pnlSched.Hide()

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        pnlOwner.Hide()
        pnlApps.Hide()
        pnlBill.Show()
        pnlPet.Hide()
        pnlReg.Hide()
        pnlSched.Hide()

        Dim intTots As String
        For Each schedule In Form1.curAccount.getSched
            intTots += schedule.getPrice
        Next

        txtTotalPrice.Text = intTots
    End Sub

    Private Sub btnPay_Click(sender As Object, e As EventArgs) Handles btnPay.Click
        If Val(txtTotalPrice.Text = "" Or txtPayment.Text = "") Then
            MsgBox("Please Enter Payment first!", vbCritical)
        ElseIf Val(txtTotalPrice.Text > txtPayment.Text) Then
            MsgBox("Insufficient Amount Entered!", vbCritical)
        ElseIf (txtTotalPrice.Text <= txtPayment.Text) Then
            MsgBox("Payment SuccessFul!", vbInformation)
        End If
    End Sub

    Private Sub btnEditPet_Click(sender As Object, e As EventArgs) Handles btnEditPet.Click
        If cmbPets.SelectedIndex > -1 Then
            Dim selectedPetName As String = cmbPets.SelectedItem.ToString()
            Dim petToEdit As Pets = Nothing

            For Each pet As Pets In Form1.curAccount.getPets()
                If pet.getName() = selectedPetName Then
                    petToEdit = pet
                    txtPetAge.Clear()
                    txtPetBirth.Clear()
                    txtPetStatus.Clear()
                    txtPetType.Clear()
                    txtPetWeight.Clear()
                    RefreshPetList()
                    Exit For
                End If
            Next

            If petToEdit IsNot Nothing Then
                Using frmEditPet As New editPetDetails()
                    frmEditPet.CurrentPet = petToEdit
                    If frmEditPet.ShowDialog() = DialogResult.OK Then
                        RefreshPetList()
                    End If
                End Using
            Else
                MsgBox("Pet not found", vbExclamation)
            End If
        End If
    End Sub

    Private Sub RefreshPetList()
        cmbPets.Items.Clear()
        For Each Pets In Form1.curAccount.getPets
            cmbPets.Items.Add(Pets.getName)
        Next
    End Sub

    Private Sub btnDeletePet_Click(sender As Object, e As EventArgs) Handles btnDeletePet.Click
        If cmbPets.SelectedIndex > -1 Then
            Dim selectedPetName As String = cmbPets.SelectedItem.ToString()
            Dim petToDelete As Pets = Nothing

            For Each pet As Pets In Form1.curAccount.getPets()
                If pet.getName() = selectedPetName Then
                    petToDelete = pet
                    txtPetAge.Clear()
                    txtPetBirth.Clear()
                    txtPetStatus.Clear()
                    txtPetType.Clear()
                    txtPetWeight.Clear()
                    Exit For
                End If
            Next

            If petToDelete IsNot Nothing Then
                Form1.curAccount.getPets().Remove(petToDelete)
                RefreshPetList()
                MsgBox("Pet deleted successfully.", vbInformation)
            Else
                MsgBox("Pet not found", vbExclamation)
            End If
        End If
    End Sub

    Private Sub btnEditOwner_Click(sender As Object, e As EventArgs) Handles btnEditOwner.Click
        Using frmEditOwner As New editOwnerDetails()
            frmEditOwner.CurrentAccount = Form1.curAccount
            If frmEditOwner.ShowDialog() = DialogResult.OK Then
                txtOwnerName.Text = Form1.curAccount.getName()
                txtOwnerAdds.Text = Form1.curAccount.getAdd()
                txtOwnerAge.Text = Form1.curAccount.getAge()
                txtOwnerSex.Text = Form1.curAccount.getSex()
            End If
        End Using
    End Sub

End Class
