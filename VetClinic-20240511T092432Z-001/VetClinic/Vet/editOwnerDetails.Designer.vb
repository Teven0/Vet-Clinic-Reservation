<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class editOwnerDetails
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
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnSaveOwner = New System.Windows.Forms.Button()
        Me.txtSex = New System.Windows.Forms.ComboBox()
        Me.txtAddress = New System.Windows.Forms.TextBox()
        Me.txtAge = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblUser = New System.Windows.Forms.Label()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(237, 300)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(330, 34)
        Me.btnCancel.TabIndex = 20
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'btnSaveOwner
        '
        Me.btnSaveOwner.AutoSize = True
        Me.btnSaveOwner.Location = New System.Drawing.Point(237, 260)
        Me.btnSaveOwner.Name = "btnSaveOwner"
        Me.btnSaveOwner.Size = New System.Drawing.Size(330, 34)
        Me.btnSaveOwner.TabIndex = 21
        Me.btnSaveOwner.Text = "Save"
        Me.btnSaveOwner.UseVisualStyleBackColor = True
        '
        'txtSex
        '
        Me.txtSex.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.txtSex.FormattingEnabled = True
        Me.txtSex.Items.AddRange(New Object() {"Male", "Female", "Other"})
        Me.txtSex.Location = New System.Drawing.Point(336, 225)
        Me.txtSex.Name = "txtSex"
        Me.txtSex.Size = New System.Drawing.Size(231, 21)
        Me.txtSex.TabIndex = 19
        '
        'txtAddress
        '
        Me.txtAddress.Location = New System.Drawing.Point(336, 197)
        Me.txtAddress.Name = "txtAddress"
        Me.txtAddress.Size = New System.Drawing.Size(231, 20)
        Me.txtAddress.TabIndex = 16
        '
        'txtAge
        '
        Me.txtAge.Location = New System.Drawing.Point(336, 171)
        Me.txtAge.Name = "txtAge"
        Me.txtAge.Size = New System.Drawing.Size(231, 20)
        Me.txtAge.TabIndex = 17
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Sylfaen", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(233, 225)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(32, 22)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Sex"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Sylfaen", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(233, 196)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(62, 22)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "Address"
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(336, 144)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(231, 20)
        Me.txtName.TabIndex = 18
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Sylfaen", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(233, 170)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(36, 22)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "Age"
        '
        'lblUser
        '
        Me.lblUser.AutoSize = True
        Me.lblUser.Font = New System.Drawing.Font("Sylfaen", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUser.Location = New System.Drawing.Point(233, 143)
        Me.lblUser.Name = "lblUser"
        Me.lblUser.Size = New System.Drawing.Size(49, 22)
        Me.lblUser.TabIndex = 13
        Me.lblUser.Text = "Name"
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Stencil", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.Location = New System.Drawing.Point(236, 87)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(322, 38)
        Me.lblTitle.TabIndex = 14
        Me.lblTitle.Text = "EDIT OWNER DETAIL"
        '
        'editOwnerDetails
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnSaveOwner)
        Me.Controls.Add(Me.txtSex)
        Me.Controls.Add(Me.txtAddress)
        Me.Controls.Add(Me.txtAge)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblUser)
        Me.Controls.Add(Me.lblTitle)
        Me.Name = "editOwnerDetails"
        Me.Text = "editOwnerDetails"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnCancel As Button
    Friend WithEvents btnSaveOwner As Button
    Friend WithEvents txtSex As ComboBox
    Friend WithEvents txtAddress As TextBox
    Friend WithEvents txtAge As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtName As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents lblUser As Label
    Friend WithEvents lblTitle As Label
End Class
