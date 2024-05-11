<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class editPetDetails
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.pnlReg = New System.Windows.Forms.Panel()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.txtPetBirthday = New System.Windows.Forms.DateTimePicker()
        Me.cmbVaccineStatus = New System.Windows.Forms.ComboBox()
        Me.cmbPetType = New System.Windows.Forms.ComboBox()
        Me.txtPetName = New System.Windows.Forms.TextBox()
        Me.btnSaveChanges = New System.Windows.Forms.Button()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.txtPetWeight = New System.Windows.Forms.TextBox()
        Me.txtPetAge = New System.Windows.Forms.TextBox()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.pnlReg.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlReg
        '
        Me.pnlReg.Controls.Add(Me.btnCancel)
        Me.pnlReg.Controls.Add(Me.txtPetBirthday)
        Me.pnlReg.Controls.Add(Me.cmbVaccineStatus)
        Me.pnlReg.Controls.Add(Me.cmbPetType)
        Me.pnlReg.Controls.Add(Me.txtPetName)
        Me.pnlReg.Controls.Add(Me.btnSaveChanges)
        Me.pnlReg.Controls.Add(Me.Label16)
        Me.pnlReg.Controls.Add(Me.txtPetWeight)
        Me.pnlReg.Controls.Add(Me.txtPetAge)
        Me.pnlReg.Controls.Add(Me.Label21)
        Me.pnlReg.Controls.Add(Me.Label14)
        Me.pnlReg.Controls.Add(Me.Label15)
        Me.pnlReg.Controls.Add(Me.Label18)
        Me.pnlReg.Controls.Add(Me.Label23)
        Me.pnlReg.Controls.Add(Me.Label22)
        Me.pnlReg.Location = New System.Drawing.Point(24, 36)
        Me.pnlReg.Name = "pnlReg"
        Me.pnlReg.Size = New System.Drawing.Size(398, 323)
        Me.pnlReg.TabIndex = 14
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(250, 285)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(116, 35)
        Me.btnCancel.TabIndex = 16
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'txtPetBirthday
        '
        Me.txtPetBirthday.Location = New System.Drawing.Point(103, 187)
        Me.txtPetBirthday.Name = "txtPetBirthday"
        Me.txtPetBirthday.Size = New System.Drawing.Size(264, 20)
        Me.txtPetBirthday.TabIndex = 15
        '
        'cmbVaccineStatus
        '
        Me.cmbVaccineStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbVaccineStatus.FormattingEnabled = True
        Me.cmbVaccineStatus.Items.AddRange(New Object() {"Complete", "Incomplete"})
        Me.cmbVaccineStatus.Location = New System.Drawing.Point(102, 218)
        Me.cmbVaccineStatus.Name = "cmbVaccineStatus"
        Me.cmbVaccineStatus.Size = New System.Drawing.Size(264, 21)
        Me.cmbVaccineStatus.TabIndex = 14
        '
        'cmbPetType
        '
        Me.cmbPetType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbPetType.FormattingEnabled = True
        Me.cmbPetType.Items.AddRange(New Object() {"Canine", "Feline", "Reptile"})
        Me.cmbPetType.Location = New System.Drawing.Point(103, 93)
        Me.cmbPetType.Name = "cmbPetType"
        Me.cmbPetType.Size = New System.Drawing.Size(264, 21)
        Me.cmbPetType.TabIndex = 14
        '
        'txtPetName
        '
        Me.txtPetName.Location = New System.Drawing.Point(103, 65)
        Me.txtPetName.Name = "txtPetName"
        Me.txtPetName.Size = New System.Drawing.Size(265, 20)
        Me.txtPetName.TabIndex = 13
        '
        'btnSaveChanges
        '
        Me.btnSaveChanges.Location = New System.Drawing.Point(102, 285)
        Me.btnSaveChanges.Name = "btnSaveChanges"
        Me.btnSaveChanges.Size = New System.Drawing.Size(125, 35)
        Me.btnSaveChanges.TabIndex = 10
        Me.btnSaveChanges.Text = "Save Changes"
        Me.btnSaveChanges.UseVisualStyleBackColor = True
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Sylfaen", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(23, 62)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(74, 22)
        Me.Label16.TabIndex = 11
        Me.Label16.Text = "Pet Name"
        '
        'txtPetWeight
        '
        Me.txtPetWeight.Location = New System.Drawing.Point(103, 157)
        Me.txtPetWeight.Name = "txtPetWeight"
        Me.txtPetWeight.Size = New System.Drawing.Size(265, 20)
        Me.txtPetWeight.TabIndex = 13
        '
        'txtPetAge
        '
        Me.txtPetAge.Location = New System.Drawing.Point(103, 126)
        Me.txtPetAge.Name = "txtPetAge"
        Me.txtPetAge.Size = New System.Drawing.Size(265, 20)
        Me.txtPetAge.TabIndex = 13
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Stencil", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.Location = New System.Drawing.Point(97, 12)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(210, 34)
        Me.Label21.TabIndex = 8
        Me.Label21.Text = "Register Pet"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Sylfaen", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(24, 93)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(43, 22)
        Me.Label14.TabIndex = 9
        Me.Label14.Text = "Type"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Sylfaen", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(24, 126)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(36, 22)
        Me.Label15.TabIndex = 10
        Me.Label15.Text = "Age"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Sylfaen", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(23, 218)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(71, 22)
        Me.Label18.TabIndex = 8
        Me.Label18.Text = "Vac State"
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Font = New System.Drawing.Font("Sylfaen", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.Location = New System.Drawing.Point(24, 186)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(67, 22)
        Me.Label23.TabIndex = 8
        Me.Label23.Text = "Birthday"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("Sylfaen", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.Location = New System.Drawing.Point(24, 156)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(60, 22)
        Me.Label22.TabIndex = 8
        Me.Label22.Text = "Weight"
        '
        'editPetDetails
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(446, 394)
        Me.Controls.Add(Me.pnlReg)
        Me.Name = "editPetDetails"
        Me.Text = "Form4"
        Me.pnlReg.ResumeLayout(False)
        Me.pnlReg.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pnlReg As Panel
    Friend WithEvents txtPetBirthday As DateTimePicker
    Friend WithEvents cmbVaccineStatus As ComboBox
    Friend WithEvents cmbPetType As ComboBox
    Friend WithEvents txtPetName As TextBox
    Friend WithEvents btnSaveChanges As Button
    Friend WithEvents Label16 As Label
    Friend WithEvents txtPetWeight As TextBox
    Friend WithEvents txtPetAge As TextBox
    Friend WithEvents Label21 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents Label23 As Label
    Friend WithEvents Label22 As Label
    Friend WithEvents btnCancel As Button
End Class
