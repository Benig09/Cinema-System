<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Forgetpassword
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Forgetpassword))
        Me.Button1 = New System.Windows.Forms.Button()
        Me.btnSavechange = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtStaffID = New System.Windows.Forms.TextBox()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.txtUsername = New System.Windows.Forms.TextBox()
        Me.txtConfirm = New System.Windows.Forms.TextBox()
        Me.txtIC = New System.Windows.Forms.TextBox()
        Me.epID = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.epIC = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.epUsername = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.epConfirm = New System.Windows.Forms.ErrorProvider(Me.components)
        CType(Me.epID, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.epIC, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.epUsername, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.epConfirm, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(219, 205)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Back"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'btnSavechange
        '
        Me.btnSavechange.Location = New System.Drawing.Point(118, 205)
        Me.btnSavechange.Name = "btnSavechange"
        Me.btnSavechange.Size = New System.Drawing.Size(84, 23)
        Me.btnSavechange.TabIndex = 1
        Me.btnSavechange.Text = "Save change"
        Me.btnSavechange.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(57, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(49, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Staff ID :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(45, 52)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(61, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "IC number :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(45, 88)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(61, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Username :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(23, 124)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(83, 13)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "New password :"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(9, 160)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(97, 13)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "Confirm Password :"
        '
        'txtStaffID
        '
        Me.txtStaffID.Location = New System.Drawing.Point(118, 13)
        Me.txtStaffID.Name = "txtStaffID"
        Me.txtStaffID.Size = New System.Drawing.Size(154, 20)
        Me.txtStaffID.TabIndex = 7
        '
        'txtPassword
        '
        Me.txtPassword.Location = New System.Drawing.Point(118, 121)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.Size = New System.Drawing.Size(154, 20)
        Me.txtPassword.TabIndex = 8
        '
        'txtUsername
        '
        Me.txtUsername.Location = New System.Drawing.Point(118, 85)
        Me.txtUsername.Name = "txtUsername"
        Me.txtUsername.Size = New System.Drawing.Size(154, 20)
        Me.txtUsername.TabIndex = 9
        '
        'txtConfirm
        '
        Me.txtConfirm.Location = New System.Drawing.Point(118, 157)
        Me.txtConfirm.Name = "txtConfirm"
        Me.txtConfirm.Size = New System.Drawing.Size(154, 20)
        Me.txtConfirm.TabIndex = 10
        '
        'txtIC
        '
        Me.txtIC.Location = New System.Drawing.Point(118, 49)
        Me.txtIC.Name = "txtIC"
        Me.txtIC.Size = New System.Drawing.Size(154, 20)
        Me.txtIC.TabIndex = 11
        '
        'epID
        '
        Me.epID.ContainerControl = Me
        '
        'epIC
        '
        Me.epIC.ContainerControl = Me
        '
        'epUsername
        '
        Me.epUsername.ContainerControl = Me
        '
        'epConfirm
        '
        Me.epConfirm.ContainerControl = Me
        '
        'Forgetpassword
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(317, 262)
        Me.Controls.Add(Me.txtIC)
        Me.Controls.Add(Me.txtConfirm)
        Me.Controls.Add(Me.txtUsername)
        Me.Controls.Add(Me.txtPassword)
        Me.Controls.Add(Me.txtStaffID)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnSavechange)
        Me.Controls.Add(Me.Button1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Forgetpassword"
        Me.Text = "Forgetpassword"
        CType(Me.epID, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.epIC, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.epUsername, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.epConfirm, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents btnSavechange As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtStaffID As System.Windows.Forms.TextBox
    Friend WithEvents txtPassword As System.Windows.Forms.TextBox
    Friend WithEvents txtUsername As System.Windows.Forms.TextBox
    Friend WithEvents txtConfirm As System.Windows.Forms.TextBox
    Friend WithEvents txtIC As System.Windows.Forms.TextBox
    Friend WithEvents epID As System.Windows.Forms.ErrorProvider
    Friend WithEvents epIC As System.Windows.Forms.ErrorProvider
    Friend WithEvents epUsername As System.Windows.Forms.ErrorProvider
    Friend WithEvents epConfirm As System.Windows.Forms.ErrorProvider
End Class
