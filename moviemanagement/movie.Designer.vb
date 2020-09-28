<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class movie
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(movie))
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtMovieID = New System.Windows.Forms.TextBox()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.dtpLaunching = New System.Windows.Forms.DateTimePicker()
        Me.txtPic = New System.Windows.Forms.TextBox()
        Me.btnBrowse = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtRemark = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.cbRating = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cbGenre = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtMovieName = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.ID = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.MovieName = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.MovieLength = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Genre = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Ratings = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.LaunchingDate = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Remark = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.MoviePic = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.dtpMovieLength = New System.Windows.Forms.DateTimePicker()
        Me.pbimage = New System.Windows.Forms.PictureBox()
        Me.btnExit = New System.Windows.Forms.Button()
        CType(Me.pbimage, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(52, 20)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(70, 17)
        Me.Label9.TabIndex = 131
        Me.Label9.Text = "Movie ID :"
        '
        'txtMovieID
        '
        Me.txtMovieID.Location = New System.Drawing.Point(135, 15)
        Me.txtMovieID.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtMovieID.Name = "txtMovieID"
        Me.txtMovieID.Size = New System.Drawing.Size(132, 22)
        Me.txtMovieID.TabIndex = 130
        '
        'btnDelete
        '
        Me.btnDelete.Location = New System.Drawing.Point(685, 160)
        Me.btnDelete.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(116, 33)
        Me.btnDelete.TabIndex = 129
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'btnBack
        '
        Me.btnBack.Location = New System.Drawing.Point(568, 502)
        Me.btnBack.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(116, 32)
        Me.btnBack.TabIndex = 128
        Me.btnBack.Text = "&Back"
        Me.btnBack.UseVisualStyleBackColor = True
        '
        'btnUpdate
        '
        Me.btnUpdate.Location = New System.Drawing.Point(685, 119)
        Me.btnUpdate.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(116, 32)
        Me.btnUpdate.TabIndex = 127
        Me.btnUpdate.Text = "Update"
        Me.btnUpdate.UseVisualStyleBackColor = True
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(685, 80)
        Me.btnAdd.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(116, 32)
        Me.btnAdd.TabIndex = 126
        Me.btnAdd.Text = "Add Movie"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'dtpLaunching
        '
        Me.dtpLaunching.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpLaunching.Location = New System.Drawing.Point(135, 177)
        Me.dtpLaunching.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.dtpLaunching.Name = "dtpLaunching"
        Me.dtpLaunching.Size = New System.Drawing.Size(163, 22)
        Me.dtpLaunching.TabIndex = 125
        '
        'txtPic
        '
        Me.txtPic.Location = New System.Drawing.Point(339, 23)
        Me.txtPic.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtPic.Name = "txtPic"
        Me.txtPic.Size = New System.Drawing.Size(209, 22)
        Me.txtPic.TabIndex = 124
        '
        'btnBrowse
        '
        Me.btnBrowse.Location = New System.Drawing.Point(556, 20)
        Me.btnBrowse.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnBrowse.Name = "btnBrowse"
        Me.btnBrowse.Size = New System.Drawing.Size(100, 28)
        Me.btnBrowse.TabIndex = 122
        Me.btnBrowse.Text = "Browse"
        Me.btnBrowse.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(335, 1)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(100, 17)
        Me.Label8.TabIndex = 121
        Me.Label8.Text = "Movie picture :"
        '
        'txtRemark
        '
        Me.txtRemark.Location = New System.Drawing.Point(136, 217)
        Me.txtRemark.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtRemark.Multiline = True
        Me.txtRemark.Name = "txtRemark"
        Me.txtRemark.Size = New System.Drawing.Size(171, 88)
        Me.txtRemark.TabIndex = 120
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(60, 215)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(65, 17)
        Me.Label7.TabIndex = 119
        Me.Label7.Text = "Remark :"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(8, 177)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(116, 17)
        Me.Label6.TabIndex = 118
        Me.Label6.Text = "Launching Date :"
        '
        'cbRating
        '
        Me.cbRating.FormattingEnabled = True
        Me.cbRating.Items.AddRange(New Object() {"U", "PG-13", "PG-18"})
        Me.cbRating.Location = New System.Drawing.Point(137, 144)
        Me.cbRating.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cbRating.Name = "cbRating"
        Me.cbRating.Size = New System.Drawing.Size(160, 24)
        Me.cbRating.TabIndex = 117
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(36, 148)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(93, 17)
        Me.Label5.TabIndex = 116
        Me.Label5.Text = "Film Ratings :"
        '
        'cbGenre
        '
        Me.cbGenre.FormattingEnabled = True
        Me.cbGenre.Items.AddRange(New Object() {"Action", "Adventure", "Cartoon", "Comedy", "Crime", "Historical", "Horror", "Mystery", "Science fiction", "Other..."})
        Me.cbGenre.Location = New System.Drawing.Point(137, 111)
        Me.cbGenre.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cbGenre.Name = "cbGenre"
        Me.cbGenre.Size = New System.Drawing.Size(160, 24)
        Me.cbGenre.TabIndex = 115
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(71, 114)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(56, 17)
        Me.Label4.TabIndex = 114
        Me.Label4.Text = "Genre :"
        '
        'txtMovieName
        '
        Me.txtMovieName.Location = New System.Drawing.Point(136, 47)
        Me.txtMovieName.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtMovieName.Name = "txtMovieName"
        Me.txtMovieName.Size = New System.Drawing.Size(132, 22)
        Me.txtMovieName.TabIndex = 112
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(25, 82)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(101, 17)
        Me.Label2.TabIndex = 110
        Me.Label2.Text = "Movie Length :" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(25, 55)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(94, 17)
        Me.Label1.TabIndex = 109
        Me.Label1.Text = "Movie Name :"
        '
        'ListView1
        '
        Me.ListView1.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ID, Me.MovieName, Me.MovieLength, Me.Genre, Me.Ratings, Me.LaunchingDate, Me.Remark, Me.MoviePic})
        Me.ListView1.FullRowSelect = True
        Me.ListView1.GridLines = True
        Me.ListView1.Location = New System.Drawing.Point(19, 313)
        Me.ListView1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(801, 181)
        Me.ListView1.TabIndex = 108
        Me.ListView1.UseCompatibleStateImageBehavior = False
        Me.ListView1.View = System.Windows.Forms.View.Details
        '
        'ID
        '
        Me.ID.Text = "ID"
        '
        'MovieName
        '
        Me.MovieName.Text = "MovieName"
        Me.MovieName.Width = 76
        '
        'MovieLength
        '
        Me.MovieLength.Text = "MovieLength"
        Me.MovieLength.Width = 81
        '
        'Genre
        '
        Me.Genre.Text = "Genre"
        '
        'Ratings
        '
        Me.Ratings.Text = "Ratings"
        '
        'LaunchingDate
        '
        Me.LaunchingDate.Text = "Launching Date"
        Me.LaunchingDate.Width = 89
        '
        'Remark
        '
        Me.Remark.Text = "Remark"
        '
        'MoviePic
        '
        Me.MoviePic.Text = "MoviePic"
        Me.MoviePic.Width = 113
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'dtpMovieLength
        '
        Me.dtpMovieLength.CustomFormat = "h:mm:ss "
        Me.dtpMovieLength.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpMovieLength.Location = New System.Drawing.Point(135, 79)
        Me.dtpMovieLength.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.dtpMovieLength.Name = "dtpMovieLength"
        Me.dtpMovieLength.Size = New System.Drawing.Size(163, 22)
        Me.dtpMovieLength.TabIndex = 132
        Me.dtpMovieLength.Value = New Date(2014, 12, 6, 2, 0, 0, 0)
        '
        'pbimage
        '
        Me.pbimage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pbimage.Location = New System.Drawing.Point(339, 55)
        Me.pbimage.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.pbimage.Name = "pbimage"
        Me.pbimage.Size = New System.Drawing.Size(318, 248)
        Me.pbimage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbimage.TabIndex = 123
        Me.pbimage.TabStop = False
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(705, 502)
        Me.btnExit.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(116, 32)
        Me.btnExit.TabIndex = 133
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'movie
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(841, 548)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.dtpMovieLength)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.txtMovieID)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.btnUpdate)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.dtpLaunching)
        Me.Controls.Add(Me.txtPic)
        Me.Controls.Add(Me.pbimage)
        Me.Controls.Add(Me.btnBrowse)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txtRemark)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.cbRating)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.cbGenre)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtMovieName)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ListView1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "movie"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Movie Management"
        CType(Me.pbimage, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtMovieID As System.Windows.Forms.TextBox
    Friend WithEvents btnDelete As System.Windows.Forms.Button
    Friend WithEvents btnBack As System.Windows.Forms.Button
    Friend WithEvents btnUpdate As System.Windows.Forms.Button
    Friend WithEvents btnAdd As System.Windows.Forms.Button
    Friend WithEvents dtpLaunching As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtPic As System.Windows.Forms.TextBox
    Friend WithEvents pbimage As System.Windows.Forms.PictureBox
    Friend WithEvents btnBrowse As System.Windows.Forms.Button
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtRemark As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents cbRating As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents cbGenre As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtMovieName As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ListView1 As System.Windows.Forms.ListView
    Friend WithEvents ID As System.Windows.Forms.ColumnHeader
    Friend WithEvents MovieName As System.Windows.Forms.ColumnHeader
    Friend WithEvents MovieLength As System.Windows.Forms.ColumnHeader
    Friend WithEvents Genre As System.Windows.Forms.ColumnHeader
    Friend WithEvents Ratings As System.Windows.Forms.ColumnHeader
    Friend WithEvents LaunchingDate As System.Windows.Forms.ColumnHeader
    Friend WithEvents MoviePic As System.Windows.Forms.ColumnHeader
    Friend WithEvents Remark As System.Windows.Forms.ColumnHeader
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents dtpMovieLength As System.Windows.Forms.DateTimePicker
    Friend WithEvents btnExit As System.Windows.Forms.Button
End Class
