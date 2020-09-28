<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ReportGeneration
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ReportGeneration))
        Me.tcReport = New System.Windows.Forms.TabControl()
        Me.tpDate = New System.Windows.Forms.TabPage()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.cbDate = New System.Windows.Forms.ComboBox()
        Me.btnPrintDate = New System.Windows.Forms.Button()
        Me.lvDate = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader5 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.btnDateReport = New System.Windows.Forms.Button()
        Me.tpMovie = New System.Windows.Forms.TabPage()
        Me.btnBack1 = New System.Windows.Forms.Button()
        Me.btnPrintMovie = New System.Windows.Forms.Button()
        Me.lvMovie = New System.Windows.Forms.ListView()
        Me.ColumnHeader6 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader7 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader8 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader9 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader10 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.btnMovieReport = New System.Windows.Forms.Button()
        Me.cbMovie = New System.Windows.Forms.ComboBox()
        Me.PrintForm1 = New Microsoft.VisualBasic.PowerPacks.Printing.PrintForm(Me.components)
        Me.PrintPreviewDialog1 = New System.Windows.Forms.PrintPreviewDialog()
        Me.tcReport.SuspendLayout()
        Me.tpDate.SuspendLayout()
        Me.tpMovie.SuspendLayout()
        Me.SuspendLayout()
        '
        'tcReport
        '
        Me.tcReport.Controls.Add(Me.tpDate)
        Me.tcReport.Controls.Add(Me.tpMovie)
        Me.tcReport.Location = New System.Drawing.Point(0, -1)
        Me.tcReport.Name = "tcReport"
        Me.tcReport.SelectedIndex = 0
        Me.tcReport.Size = New System.Drawing.Size(437, 491)
        Me.tcReport.TabIndex = 0
        '
        'tpDate
        '
        Me.tpDate.Controls.Add(Me.btnBack)
        Me.tpDate.Controls.Add(Me.cbDate)
        Me.tpDate.Controls.Add(Me.btnPrintDate)
        Me.tpDate.Controls.Add(Me.lvDate)
        Me.tpDate.Controls.Add(Me.btnDateReport)
        Me.tpDate.Location = New System.Drawing.Point(4, 22)
        Me.tpDate.Name = "tpDate"
        Me.tpDate.Padding = New System.Windows.Forms.Padding(3)
        Me.tpDate.Size = New System.Drawing.Size(429, 465)
        Me.tpDate.TabIndex = 0
        Me.tpDate.Text = "Date"
        Me.tpDate.UseVisualStyleBackColor = True
        '
        'btnBack
        '
        Me.btnBack.Location = New System.Drawing.Point(248, 425)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(75, 23)
        Me.btnBack.TabIndex = 5
        Me.btnBack.Text = "Back"
        Me.btnBack.UseVisualStyleBackColor = True
        '
        'cbDate
        '
        Me.cbDate.FormattingEnabled = True
        Me.cbDate.Location = New System.Drawing.Point(111, 22)
        Me.cbDate.Name = "cbDate"
        Me.cbDate.Size = New System.Drawing.Size(121, 21)
        Me.cbDate.TabIndex = 4
        '
        'btnPrintDate
        '
        Me.btnPrintDate.Location = New System.Drawing.Point(330, 425)
        Me.btnPrintDate.Name = "btnPrintDate"
        Me.btnPrintDate.Size = New System.Drawing.Size(75, 23)
        Me.btnPrintDate.TabIndex = 3
        Me.btnPrintDate.Text = "Print"
        Me.btnPrintDate.UseVisualStyleBackColor = True
        '
        'lvDate
        '
        Me.lvDate.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4, Me.ColumnHeader5})
        Me.lvDate.Location = New System.Drawing.Point(6, 71)
        Me.lvDate.Name = "lvDate"
        Me.lvDate.Size = New System.Drawing.Size(420, 335)
        Me.lvDate.TabIndex = 2
        Me.lvDate.UseCompatibleStateImageBehavior = False
        Me.lvDate.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Movie Name"
        Me.ColumnHeader1.Width = 100
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Time"
        Me.ColumnHeader2.Width = 80
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Status"
        Me.ColumnHeader3.Width = 80
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Seat Number"
        Me.ColumnHeader4.Width = 80
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "Price"
        Me.ColumnHeader5.Width = 80
        '
        'btnDateReport
        '
        Me.btnDateReport.Location = New System.Drawing.Point(248, 22)
        Me.btnDateReport.Name = "btnDateReport"
        Me.btnDateReport.Size = New System.Drawing.Size(75, 23)
        Me.btnDateReport.TabIndex = 1
        Me.btnDateReport.Text = "Generate" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.btnDateReport.UseVisualStyleBackColor = True
        '
        'tpMovie
        '
        Me.tpMovie.Controls.Add(Me.btnBack1)
        Me.tpMovie.Controls.Add(Me.btnPrintMovie)
        Me.tpMovie.Controls.Add(Me.lvMovie)
        Me.tpMovie.Controls.Add(Me.btnMovieReport)
        Me.tpMovie.Controls.Add(Me.cbMovie)
        Me.tpMovie.Location = New System.Drawing.Point(4, 22)
        Me.tpMovie.Name = "tpMovie"
        Me.tpMovie.Padding = New System.Windows.Forms.Padding(3)
        Me.tpMovie.Size = New System.Drawing.Size(429, 465)
        Me.tpMovie.TabIndex = 1
        Me.tpMovie.Text = "Movie"
        Me.tpMovie.UseVisualStyleBackColor = True
        '
        'btnBack1
        '
        Me.btnBack1.Location = New System.Drawing.Point(250, 434)
        Me.btnBack1.Name = "btnBack1"
        Me.btnBack1.Size = New System.Drawing.Size(75, 23)
        Me.btnBack1.TabIndex = 4
        Me.btnBack1.Text = "Back"
        Me.btnBack1.UseVisualStyleBackColor = True
        '
        'btnPrintMovie
        '
        Me.btnPrintMovie.Location = New System.Drawing.Point(331, 434)
        Me.btnPrintMovie.Name = "btnPrintMovie"
        Me.btnPrintMovie.Size = New System.Drawing.Size(75, 23)
        Me.btnPrintMovie.TabIndex = 3
        Me.btnPrintMovie.Text = "Print"
        Me.btnPrintMovie.UseVisualStyleBackColor = True
        '
        'lvMovie
        '
        Me.lvMovie.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader6, Me.ColumnHeader7, Me.ColumnHeader8, Me.ColumnHeader9, Me.ColumnHeader10})
        Me.lvMovie.Location = New System.Drawing.Point(3, 70)
        Me.lvMovie.Name = "lvMovie"
        Me.lvMovie.Size = New System.Drawing.Size(423, 335)
        Me.lvMovie.TabIndex = 2
        Me.lvMovie.UseCompatibleStateImageBehavior = False
        Me.lvMovie.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader6
        '
        Me.ColumnHeader6.Text = "Date"
        Me.ColumnHeader6.Width = 80
        '
        'ColumnHeader7
        '
        Me.ColumnHeader7.Text = "Time"
        Me.ColumnHeader7.Width = 80
        '
        'ColumnHeader8
        '
        Me.ColumnHeader8.Text = "Status"
        Me.ColumnHeader8.Width = 80
        '
        'ColumnHeader9
        '
        Me.ColumnHeader9.Text = "Seat Number"
        Me.ColumnHeader9.Width = 80
        '
        'ColumnHeader10
        '
        Me.ColumnHeader10.Text = "Price"
        Me.ColumnHeader10.Width = 80
        '
        'btnMovieReport
        '
        Me.btnMovieReport.Location = New System.Drawing.Point(268, 31)
        Me.btnMovieReport.Name = "btnMovieReport"
        Me.btnMovieReport.Size = New System.Drawing.Size(75, 23)
        Me.btnMovieReport.TabIndex = 1
        Me.btnMovieReport.Text = "Generate"
        Me.btnMovieReport.UseVisualStyleBackColor = True
        '
        'cbMovie
        '
        Me.cbMovie.FormattingEnabled = True
        Me.cbMovie.Location = New System.Drawing.Point(124, 31)
        Me.cbMovie.Name = "cbMovie"
        Me.cbMovie.Size = New System.Drawing.Size(121, 21)
        Me.cbMovie.TabIndex = 0
        '
        'PrintForm1
        '
        Me.PrintForm1.DocumentName = "document"
        Me.PrintForm1.Form = Me
        Me.PrintForm1.PrintAction = System.Drawing.Printing.PrintAction.PrintToPrinter
        Me.PrintForm1.PrinterSettings = CType(resources.GetObject("PrintForm1.PrinterSettings"), System.Drawing.Printing.PrinterSettings)
        Me.PrintForm1.PrintFileName = Nothing
        '
        'PrintPreviewDialog1
        '
        Me.PrintPreviewDialog1.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.ClientSize = New System.Drawing.Size(400, 300)
        Me.PrintPreviewDialog1.Enabled = True
        Me.PrintPreviewDialog1.Icon = CType(resources.GetObject("PrintPreviewDialog1.Icon"), System.Drawing.Icon)
        Me.PrintPreviewDialog1.Name = "PrintPreviewDialog1"
        Me.PrintPreviewDialog1.Visible = False
        '
        'ReportGeneration
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(437, 490)
        Me.ControlBox = False
        Me.Controls.Add(Me.tcReport)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "ReportGeneration"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Report Generation"
        Me.tcReport.ResumeLayout(False)
        Me.tpDate.ResumeLayout(False)
        Me.tpMovie.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents tcReport As System.Windows.Forms.TabControl
    Friend WithEvents tpDate As System.Windows.Forms.TabPage
    Friend WithEvents lvDate As System.Windows.Forms.ListView
    Friend WithEvents btnDateReport As System.Windows.Forms.Button
    Friend WithEvents tpMovie As System.Windows.Forms.TabPage
    Friend WithEvents lvMovie As System.Windows.Forms.ListView
    Friend WithEvents btnMovieReport As System.Windows.Forms.Button
    Friend WithEvents cbMovie As System.Windows.Forms.ComboBox
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader4 As System.Windows.Forms.ColumnHeader
    Friend WithEvents btnPrintDate As System.Windows.Forms.Button
    Friend WithEvents ColumnHeader5 As System.Windows.Forms.ColumnHeader
    Friend WithEvents btnPrintMovie As System.Windows.Forms.Button
    Friend WithEvents ColumnHeader6 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader7 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader8 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader9 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader10 As System.Windows.Forms.ColumnHeader
    Friend WithEvents btnBack As System.Windows.Forms.Button
    Friend WithEvents cbDate As System.Windows.Forms.ComboBox
    Friend WithEvents btnBack1 As System.Windows.Forms.Button
    Friend WithEvents PrintForm1 As Microsoft.VisualBasic.PowerPacks.Printing.PrintForm
    Friend WithEvents PrintPreviewDialog1 As System.Windows.Forms.PrintPreviewDialog
End Class
