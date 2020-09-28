<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainMenu1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainMenu1))
        Me.tabMainMenu = New System.Windows.Forms.TabControl()
        Me.tabStaff = New System.Windows.Forms.TabPage()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.btnMemberManagement = New System.Windows.Forms.Button()
        Me.btnTicketManagement = New System.Windows.Forms.Button()
        Me.tabManager = New System.Windows.Forms.TabPage()
        Me.btnExit2 = New System.Windows.Forms.Button()
        Me.btnBack2 = New System.Windows.Forms.Button()
        Me.btnRegister = New System.Windows.Forms.Button()
        Me.btnReportGeneration = New System.Windows.Forms.Button()
        Me.btnStaffManagement = New System.Windows.Forms.Button()
        Me.btnMovieManagement = New System.Windows.Forms.Button()
        Me.tabMainMenu.SuspendLayout()
        Me.tabStaff.SuspendLayout()
        Me.tabManager.SuspendLayout()
        Me.SuspendLayout()
        '
        'tabMainMenu
        '
        Me.tabMainMenu.Controls.Add(Me.tabStaff)
        Me.tabMainMenu.Controls.Add(Me.tabManager)
        Me.tabMainMenu.Location = New System.Drawing.Point(3, 0)
        Me.tabMainMenu.Name = "tabMainMenu"
        Me.tabMainMenu.SelectedIndex = 0
        Me.tabMainMenu.Size = New System.Drawing.Size(498, 346)
        Me.tabMainMenu.TabIndex = 0
        '
        'tabStaff
        '
        Me.tabStaff.BackgroundImage = Global.moviemanagement.My.Resources.Resources.stock_footage_cinema_background_gold
        Me.tabStaff.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.tabStaff.Controls.Add(Me.btnExit)
        Me.tabStaff.Controls.Add(Me.btnBack)
        Me.tabStaff.Controls.Add(Me.btnMemberManagement)
        Me.tabStaff.Controls.Add(Me.btnTicketManagement)
        Me.tabStaff.Location = New System.Drawing.Point(4, 22)
        Me.tabStaff.Name = "tabStaff"
        Me.tabStaff.Padding = New System.Windows.Forms.Padding(3)
        Me.tabStaff.Size = New System.Drawing.Size(490, 320)
        Me.tabStaff.TabIndex = 0
        Me.tabStaff.Text = "Staff"
        Me.tabStaff.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(417, 267)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(55, 32)
        Me.btnExit.TabIndex = 3
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'btnBack
        '
        Me.btnBack.Location = New System.Drawing.Point(342, 267)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(58, 32)
        Me.btnBack.TabIndex = 2
        Me.btnBack.Text = "Back"
        Me.btnBack.UseVisualStyleBackColor = True
        '
        'btnMemberManagement
        '
        Me.btnMemberManagement.Location = New System.Drawing.Point(267, 115)
        Me.btnMemberManagement.Name = "btnMemberManagement"
        Me.btnMemberManagement.Size = New System.Drawing.Size(100, 50)
        Me.btnMemberManagement.TabIndex = 1
        Me.btnMemberManagement.Text = "Member Management"
        Me.btnMemberManagement.UseVisualStyleBackColor = True
        '
        'btnTicketManagement
        '
        Me.btnTicketManagement.Location = New System.Drawing.Point(109, 115)
        Me.btnTicketManagement.Name = "btnTicketManagement"
        Me.btnTicketManagement.Size = New System.Drawing.Size(100, 50)
        Me.btnTicketManagement.TabIndex = 0
        Me.btnTicketManagement.Text = "Ticket Management"
        Me.btnTicketManagement.UseVisualStyleBackColor = True
        '
        'tabManager
        '
        Me.tabManager.BackgroundImage = Global.moviemanagement.My.Resources.Resources.stock_footage_cinema_background_gold
        Me.tabManager.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.tabManager.Controls.Add(Me.btnExit2)
        Me.tabManager.Controls.Add(Me.btnBack2)
        Me.tabManager.Controls.Add(Me.btnRegister)
        Me.tabManager.Controls.Add(Me.btnReportGeneration)
        Me.tabManager.Controls.Add(Me.btnStaffManagement)
        Me.tabManager.Controls.Add(Me.btnMovieManagement)
        Me.tabManager.Location = New System.Drawing.Point(4, 22)
        Me.tabManager.Name = "tabManager"
        Me.tabManager.Padding = New System.Windows.Forms.Padding(3)
        Me.tabManager.Size = New System.Drawing.Size(490, 320)
        Me.tabManager.TabIndex = 1
        Me.tabManager.Text = "Manager"
        Me.tabManager.UseVisualStyleBackColor = True
        '
        'btnExit2
        '
        Me.btnExit2.Location = New System.Drawing.Point(417, 273)
        Me.btnExit2.Name = "btnExit2"
        Me.btnExit2.Size = New System.Drawing.Size(55, 32)
        Me.btnExit2.TabIndex = 5
        Me.btnExit2.Text = "Exit"
        Me.btnExit2.UseVisualStyleBackColor = True
        '
        'btnBack2
        '
        Me.btnBack2.Location = New System.Drawing.Point(342, 273)
        Me.btnBack2.Name = "btnBack2"
        Me.btnBack2.Size = New System.Drawing.Size(58, 32)
        Me.btnBack2.TabIndex = 4
        Me.btnBack2.Text = "Back"
        Me.btnBack2.UseVisualStyleBackColor = True
        '
        'btnRegister
        '
        Me.btnRegister.Location = New System.Drawing.Point(256, 164)
        Me.btnRegister.Name = "btnRegister"
        Me.btnRegister.Size = New System.Drawing.Size(100, 50)
        Me.btnRegister.TabIndex = 3
        Me.btnRegister.Text = "Register Account"
        Me.btnRegister.UseVisualStyleBackColor = True
        '
        'btnReportGeneration
        '
        Me.btnReportGeneration.Location = New System.Drawing.Point(100, 164)
        Me.btnReportGeneration.Name = "btnReportGeneration"
        Me.btnReportGeneration.Size = New System.Drawing.Size(100, 50)
        Me.btnReportGeneration.TabIndex = 2
        Me.btnReportGeneration.Text = "Report Generation"
        Me.btnReportGeneration.UseVisualStyleBackColor = True
        '
        'btnStaffManagement
        '
        Me.btnStaffManagement.BackColor = System.Drawing.Color.Transparent
        Me.btnStaffManagement.Location = New System.Drawing.Point(256, 71)
        Me.btnStaffManagement.Name = "btnStaffManagement"
        Me.btnStaffManagement.Size = New System.Drawing.Size(100, 50)
        Me.btnStaffManagement.TabIndex = 1
        Me.btnStaffManagement.Text = "Staff Management"
        Me.btnStaffManagement.UseVisualStyleBackColor = False
        '
        'btnMovieManagement
        '
        Me.btnMovieManagement.Location = New System.Drawing.Point(100, 71)
        Me.btnMovieManagement.Name = "btnMovieManagement"
        Me.btnMovieManagement.Size = New System.Drawing.Size(100, 50)
        Me.btnMovieManagement.TabIndex = 0
        Me.btnMovieManagement.Text = "Movie Management"
        Me.btnMovieManagement.UseVisualStyleBackColor = True
        '
        'MainMenu1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(503, 349)
        Me.Controls.Add(Me.tabMainMenu)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "MainMenu1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Main Menu"
        Me.tabMainMenu.ResumeLayout(False)
        Me.tabStaff.ResumeLayout(False)
        Me.tabManager.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents tabMainMenu As System.Windows.Forms.TabControl
    Friend WithEvents tabStaff As System.Windows.Forms.TabPage
    Friend WithEvents tabManager As System.Windows.Forms.TabPage
    Friend WithEvents btnMemberManagement As System.Windows.Forms.Button
    Friend WithEvents btnTicketManagement As System.Windows.Forms.Button
    Friend WithEvents btnRegister As System.Windows.Forms.Button
    Friend WithEvents btnReportGeneration As System.Windows.Forms.Button
    Friend WithEvents btnStaffManagement As System.Windows.Forms.Button
    Friend WithEvents btnMovieManagement As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents btnBack As System.Windows.Forms.Button
    Friend WithEvents btnExit2 As System.Windows.Forms.Button
    Friend WithEvents btnBack2 As System.Windows.Forms.Button
End Class
