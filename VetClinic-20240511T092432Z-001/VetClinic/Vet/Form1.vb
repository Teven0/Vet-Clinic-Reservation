Public Class Form1
    Public listAccount As New List(Of Account)
    Public allSched As New List(Of Form1.Schedule)
    Public curAccount As Account
    Public curPets As Pets

    Public Sub New()

        InitializeComponent()

        Dim sisi As New Account
        sisi.setCred("temp", "temp", "temp", 12, "temp")
        listAccount.Add(sisi)


    End Sub
    Class Account
        Private strName As String
        Private strPass As String
        Private intAge As Integer
        Private strSex As String
        Private strAdd As String
        Private listPets As New List(Of Pets)
        Private listSched As New List(Of Schedule)

        Public Sub setCred(ByVal name As String, ByVal pass As String, ByVal address As String, ByVal age As Integer, ByVal sex As String)
            strName = name
            strPass = pass
            intAge = age
            strSex = sex
            strAdd = address
        End Sub

        Public Sub setCreds(ByVal name As String, ByVal address As String, ByVal age As Integer, ByVal sex As String)
            strName = name
            intAge = age
            strSex = sex
            strAdd = address
        End Sub
        Public Sub addPet(ByRef pet As Pets)
            listPets.Add(pet)
        End Sub
        Public Sub addAppointment(ByVal appointment As Schedule)
            listSched.Add(appointment)
        End Sub
        Public Sub removeAppointment(ByVal appointment As Schedule)
            listSched.Remove(appointment)
        End Sub
        Public Function getName() As String
            Return strName
        End Function
        Public Function getPass() As String
            Return strPass
        End Function
        Public Function getAge() As Integer
            Return intAge
        End Function
        Public Function getSex() As String
            Return strSex
        End Function
        Public Function getAdd() As String
            Return strAdd
        End Function
        Public Function getPets() As List(Of Pets)
            Return listPets
        End Function
        Public Function getSched() As List(Of Schedule)
            Return listSched
        End Function

    End Class

    Class Pets
        Private strName As String
        Private intAge As Integer
        Private strBirth As String
        Private intWeight As String
        Private strType As String
        Private strVacs As String
        Private strVisit As String

        Public Sub setInfo(ByVal name As String, ByVal age As Integer, ByVal birth As String, ByVal weight As String, ByVal type As String, ByVal vacs As String)
            strName = name
            intAge = age
            strBirth = birth
            intWeight = weight
            strType = type
            strVacs = vacs
        End Sub
        Public Sub addAppoint(ByVal strDate As String)
            strVisit = strDate
        End Sub
        Public Sub setLatestVisit(ByVal strLatestVisit As String)
            strVisit = strLatestVisit
        End Sub
        Public Function getName() As String
            Return strName
        End Function
        Public Function getAge() As Integer
            Return intAge
        End Function
        Public Function getbirth() As String
            Return strBirth
        End Function
        Public Function getWeight() As String
            Return intWeight
        End Function
        Public Function getPType() As String
            Return strType
        End Function
        Public Function getVacs() As String
            Return strVacs
        End Function
        Public Function getVisit() As String
            Return strVisit
        End Function
    End Class
    Class Schedule
        Private strDate As String
        Private strProcedure As String
        Private intPrice As Integer
        Private strOwner As String
        Private pet As Pets

        Public Sub setDate(ByVal strDate As String)
            Me.strDate = strDate
            pet.addAppoint(strDate)
        End Sub
        Public Sub setProcedure(ByVal proce As String, ByVal price As Integer)
            strProcedure = proce
            intPrice = price
        End Sub
        Public Sub setPet(ByRef pet As Pets)
            Me.pet = pet
        End Sub
        Public Sub setOwner(ByVal name As String)
            strOwner = name
        End Sub

        Public Function getDate() As String
            Return strDate
        End Function
        Public Function getProcedure() As String
            Return strProcedure
        End Function
        Public Function getPrice() As Integer
            Return intPrice
        End Function
        Public Function getPet() As Pets
            Return pet
        End Function
        Public Function getOwner() As String
            Return strOwner
        End Function
    End Class
    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Form2.Show()
        Me.Hide()
    End Sub

    Private Sub btnLog_Click(sender As Object, e As EventArgs) Handles btnLog.Click
        Dim counter As Integer = 0
        Do While counter < listAccount.Count
            If txtUser.Text = listAccount(counter).getName And txtPass.Text = listAccount(counter).getPass Then
                curAccount = listAccount(counter)
                MsgBox("Welcome User")
                Form3.txtUser.Text = listAccount(counter).getName
                Form3.Show()
                Me.Hide()
                txtUser.Clear()
                txtPass.Clear()
                Exit Do
            ElseIf txtUser.Text = "admin" And txtPass.Text = "admin" Then
                MsgBox("Welcome Admin!")
                Admin.Show()
                Me.Hide()
                txtUser.Clear()
                txtPass.Clear()
                Exit Do
            End If
            counter += 1
        Loop
    End Sub

End Class
