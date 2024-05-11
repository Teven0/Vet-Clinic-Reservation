<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Admin
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.adminSched = New System.Windows.Forms.ListView()
        Me.strOwner = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.strPet = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Type = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.strProcedure = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.VaccineStatus = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.dateApps = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Label17 = New System.Windows.Forms.Label()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cmbOwners = New System.Windows.Forms.ComboBox()
        Me.cmbPets = New System.Windows.Forms.ComboBox()
        Me.Owner = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cmbVaccine = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'adminSched
        '
        Me.adminSched.BackgroundImageTiled = True
        Me.adminSched.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.strOwner, Me.strPet, Me.Type, Me.strProcedure, Me.VaccineStatus, Me.dateApps})
        Me.adminSched.GridLines = True
        Me.adminSched.HideSelection = False
        Me.adminSched.Location = New System.Drawing.Point(35, 77)
        Me.adminSched.Name = "adminSched"
        Me.adminSched.Size = New System.Drawing.Size(615, 130)
        Me.adminSched.TabIndex = 16
        Me.adminSched.UseCompatibleStateImageBehavior = False
        Me.adminSched.View = System.Windows.Forms.View.Details
        '
        'strOwner
        '
        Me.strOwner.Text = "Owner"
        Me.strOwner.Width = 74
        '
        'strPet
        '
        Me.strPet.Text = "Pet Name"
        Me.strPet.Width = 87
        '
        'Type
        '
        Me.Type.Text = "Type"
        Me.Type.Width = 82
        '
        'strProcedure
        '
        Me.strProcedure.Text = "Procedure"
        Me.strProcedure.Width = 136
        '
        'VaccineStatus
        '
        Me.VaccineStatus.Text = "Vaccine Status"
        Me.VaccineStatus.Width = 97
        '
        'dateApps
        '
        Me.dateApps.Text = "Appointment Date"
        Me.dateApps.Width = 134
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Stencil", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(19, 31)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(243, 34)
        Me.Label17.TabIndex = 15
        Me.Label17.Text = "Welcome Admin"
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(12, 6)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(88, 22)
        Me.btnExit.TabIndex = 17
        Me.btnExit.Text = "LogOut"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Stencil", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(19, 219)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(243, 34)
        Me.Label1.TabIndex = 15
        Me.Label1.Text = "Welcome Admin"
        '
        'cmbOwners
        '
        Me.cmbOwners.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbOwners.FormattingEnabled = True
        Me.cmbOwners.Location = New System.Drawing.Point(145, 256)
        Me.cmbOwners.Name = "cmbOwners"
        Me.cmbOwners.Size = New System.Drawing.Size(231, 21)
        Me.cmbOwners.TabIndex = 18
        '
        'cmbPets
        '
        Me.cmbPets.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbPets.FormattingEnabled = True
        Me.cmbPets.Location = New System.Drawing.Point(145, 283)
        Me.cmbPets.Name = "cmbPets"
        Me.cmbPets.Size = New System.Drawing.Size(231, 21)
        Me.cmbPets.TabIndex = 18
        '
        'Owner
        '
        Me.Owner.AutoSize = True
        Me.Owner.Font = New System.Drawing.Font("Sylfaen", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Owner.Location = New System.Drawing.Point(31, 253)
        Me.Owner.Name = "Owner"
        Me.Owner.Size = New System.Drawing.Size(55, 22)
        Me.Owner.TabIndex = 19
        Me.Owner.Text = "Owner"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Sylfaen", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(31, 282)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(31, 22)
        Me.Label2.TabIndex = 19
        Me.Label2.Text = "Pet"
        '
        'cmbVaccine
        '
        Me.cmbVaccine.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbVaccine.FormattingEnabled = True
        Me.cmbVaccine.Items.AddRange(New Object() {"Complete", "Incomplete"})
        Me.cmbVaccine.Location = New System.Drawing.Point(145, 310)
        Me.cmbVaccine.Name = "cmbVaccine"
        Me.cmbVaccine.Size = New System.Drawing.Size(231, 21)
        Me.cmbVaccine.TabIndex = 18
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Sylfaen", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(31, 309)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(105, 22)
        Me.Label3.TabIndex = 19
        Me.Label3.Text = "Vaccine Status"
        '
        'Admin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(686, 450)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Owner)
        Me.Controls.Add(Me.cmbVaccine)
        Me.Controls.Add(Me.cmbPets)
        Me.Controls.Add(Me.cmbOwners)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.adminSched)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label17)
        Me.Name = "Admin"
        Me.Text = "Admin"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents adminSched As ListView
    Friend WithEvents Type As ColumnHeader
    Friend WithEvents strProcedure As ColumnHeader
    Friend WithEvents strPet As ColumnHeader
    Friend WithEvents Label17 As Label
    Friend WithEvents strOwner As ColumnHeader
    Friend WithEvents btnExit As Button
    Friend WithEvents VaccineStatus As ColumnHeader
    Friend WithEvents Label1 As Label
    Friend WithEvents cmbOwners As ComboBox
    Friend WithEvents cmbPets As ComboBox
    Friend WithEvents Owner As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents cmbVaccine As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents dateApps As ColumnHeader
End Class
