<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DatabaseStaff
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
        Me.btnLogout = New System.Windows.Forms.Button()
        Me.btnAdmin = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnRefresh = New System.Windows.Forms.Button()
        Me.lsvStaff = New System.Windows.Forms.ListView()
        Me.colName = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colAge = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colClub = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.btnSearchName = New System.Windows.Forms.Button()
        Me.btnSearchAge = New System.Windows.Forms.Button()
        Me.btnSearchClub = New System.Windows.Forms.Button()
        Me.btnSearchTime = New System.Windows.Forms.Button()
        Me.btnSearchType = New System.Windows.Forms.Button()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.txtAge = New System.Windows.Forms.TextBox()
        Me.txtClub = New System.Windows.Forms.TextBox()
        Me.txtTime = New System.Windows.Forms.TextBox()
        Me.txtType = New System.Windows.Forms.TextBox()
        Me.txtGender = New System.Windows.Forms.TextBox()
        Me.btnSearchGender = New System.Windows.Forms.Button()
        Me.colStroke = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.btnSearchStroke = New System.Windows.Forms.Button()
        Me.txtStroke = New System.Windows.Forms.TextBox()
        Me.colTime = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colType = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colGender = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.SuspendLayout()
        '
        'btnLogout
        '
        Me.btnLogout.Location = New System.Drawing.Point(3, 2)
        Me.btnLogout.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnLogout.Name = "btnLogout"
        Me.btnLogout.Size = New System.Drawing.Size(75, 28)
        Me.btnLogout.TabIndex = 5
        Me.btnLogout.Text = "Log Out"
        Me.btnLogout.UseVisualStyleBackColor = True
        '
        'btnAdmin
        '
        Me.btnAdmin.BackColor = System.Drawing.Color.Transparent
        Me.btnAdmin.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdmin.ForeColor = System.Drawing.Color.Red
        Me.btnAdmin.Location = New System.Drawing.Point(884, 606)
        Me.btnAdmin.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnAdmin.Name = "btnAdmin"
        Me.btnAdmin.Size = New System.Drawing.Size(161, 28)
        Me.btnAdmin.TabIndex = 10
        Me.btnAdmin.Text = "Admin Tools"
        Me.btnAdmin.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(932, 9)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(59, 17)
        Me.Label1.TabIndex = 17
        Me.Label1.Text = "Search"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, CType(((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic) _
                Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(85, 11)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(297, 20)
        Me.Label2.TabIndex = 18
        Me.Label2.Text = "Portway Swimming Club Database"
        '
        'btnRefresh
        '
        Me.btnRefresh.BackgroundImage = Global.Controlled_Assessment_Prototype.My.Resources.Resources.Refresh_Button
        Me.btnRefresh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnRefresh.Location = New System.Drawing.Point(796, 2)
        Me.btnRefresh.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnRefresh.Name = "btnRefresh"
        Me.btnRefresh.Size = New System.Drawing.Size(31, 28)
        Me.btnRefresh.TabIndex = 11
        Me.btnRefresh.UseVisualStyleBackColor = True
        '
        'lsvStaff
        '
        Me.lsvStaff.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.colName, Me.colAge, Me.colClub, Me.colStroke, Me.colTime, Me.colType, Me.colGender})
        Me.lsvStaff.Location = New System.Drawing.Point(83, 35)
        Me.lsvStaff.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.lsvStaff.Name = "lsvStaff"
        Me.lsvStaff.Size = New System.Drawing.Size(744, 598)
        Me.lsvStaff.TabIndex = 25
        Me.lsvStaff.UseCompatibleStateImageBehavior = False
        Me.lsvStaff.View = System.Windows.Forms.View.Details
        '
        'colName
        '
        Me.colName.Text = "Name"
        Me.colName.Width = 166
        '
        'colAge
        '
        Me.colAge.Text = "Age"
        Me.colAge.Width = 39
        '
        'colClub
        '
        Me.colClub.Text = "Club"
        Me.colClub.Width = 154
        '
        'btnSearchName
        '
        Me.btnSearchName.Location = New System.Drawing.Point(883, 60)
        Me.btnSearchName.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnSearchName.Name = "btnSearchName"
        Me.btnSearchName.Size = New System.Drawing.Size(161, 28)
        Me.btnSearchName.TabIndex = 26
        Me.btnSearchName.Text = "Search Name"
        Me.btnSearchName.UseVisualStyleBackColor = True
        '
        'btnSearchAge
        '
        Me.btnSearchAge.Location = New System.Drawing.Point(883, 138)
        Me.btnSearchAge.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnSearchAge.Name = "btnSearchAge"
        Me.btnSearchAge.Size = New System.Drawing.Size(161, 28)
        Me.btnSearchAge.TabIndex = 27
        Me.btnSearchAge.Text = "Search Age"
        Me.btnSearchAge.UseVisualStyleBackColor = True
        '
        'btnSearchClub
        '
        Me.btnSearchClub.Location = New System.Drawing.Point(883, 215)
        Me.btnSearchClub.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnSearchClub.Name = "btnSearchClub"
        Me.btnSearchClub.Size = New System.Drawing.Size(161, 28)
        Me.btnSearchClub.TabIndex = 28
        Me.btnSearchClub.Text = "Search Club"
        Me.btnSearchClub.UseVisualStyleBackColor = True
        '
        'btnSearchTime
        '
        Me.btnSearchTime.Location = New System.Drawing.Point(882, 351)
        Me.btnSearchTime.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnSearchTime.Name = "btnSearchTime"
        Me.btnSearchTime.Size = New System.Drawing.Size(161, 28)
        Me.btnSearchTime.TabIndex = 29
        Me.btnSearchTime.Text = "Search Time"
        Me.btnSearchTime.UseVisualStyleBackColor = True
        '
        'btnSearchType
        '
        Me.btnSearchType.Location = New System.Drawing.Point(882, 428)
        Me.btnSearchType.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnSearchType.Name = "btnSearchType"
        Me.btnSearchType.Size = New System.Drawing.Size(161, 28)
        Me.btnSearchType.TabIndex = 30
        Me.btnSearchType.Text = "Search Type of Time"
        Me.btnSearchType.UseVisualStyleBackColor = True
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(883, 28)
        Me.txtName.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(160, 22)
        Me.txtName.TabIndex = 31
        Me.txtName.Text = "Name"
        '
        'txtAge
        '
        Me.txtAge.Location = New System.Drawing.Point(883, 106)
        Me.txtAge.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtAge.Name = "txtAge"
        Me.txtAge.Size = New System.Drawing.Size(160, 22)
        Me.txtAge.TabIndex = 32
        Me.txtAge.Text = "Age"
        '
        'txtClub
        '
        Me.txtClub.Location = New System.Drawing.Point(883, 183)
        Me.txtClub.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtClub.Name = "txtClub"
        Me.txtClub.Size = New System.Drawing.Size(160, 22)
        Me.txtClub.TabIndex = 33
        Me.txtClub.Text = "Club"
        '
        'txtTime
        '
        Me.txtTime.Location = New System.Drawing.Point(882, 319)
        Me.txtTime.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtTime.Name = "txtTime"
        Me.txtTime.Size = New System.Drawing.Size(160, 22)
        Me.txtTime.TabIndex = 34
        Me.txtTime.Text = "Time"
        '
        'txtType
        '
        Me.txtType.Location = New System.Drawing.Point(882, 396)
        Me.txtType.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtType.Name = "txtType"
        Me.txtType.Size = New System.Drawing.Size(160, 22)
        Me.txtType.TabIndex = 35
        Me.txtType.Text = "Type of Timing"
        '
        'txtGender
        '
        Me.txtGender.Location = New System.Drawing.Point(883, 474)
        Me.txtGender.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtGender.Name = "txtGender"
        Me.txtGender.Size = New System.Drawing.Size(159, 22)
        Me.txtGender.TabIndex = 36
        Me.txtGender.Text = "Gender"
        '
        'btnSearchGender
        '
        Me.btnSearchGender.Location = New System.Drawing.Point(882, 506)
        Me.btnSearchGender.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnSearchGender.Name = "btnSearchGender"
        Me.btnSearchGender.Size = New System.Drawing.Size(161, 28)
        Me.btnSearchGender.TabIndex = 37
        Me.btnSearchGender.Text = "Search Gender"
        Me.btnSearchGender.UseVisualStyleBackColor = True
        '
        'colStroke
        '
        Me.colStroke.Text = "Stroke"
        Me.colStroke.Width = 90
        '
        'btnSearchStroke
        '
        Me.btnSearchStroke.Location = New System.Drawing.Point(882, 283)
        Me.btnSearchStroke.Margin = New System.Windows.Forms.Padding(4)
        Me.btnSearchStroke.Name = "btnSearchStroke"
        Me.btnSearchStroke.Size = New System.Drawing.Size(161, 28)
        Me.btnSearchStroke.TabIndex = 39
        Me.btnSearchStroke.Text = "Search Stroke"
        Me.btnSearchStroke.UseVisualStyleBackColor = True
        '
        'txtStroke
        '
        Me.txtStroke.Location = New System.Drawing.Point(883, 251)
        Me.txtStroke.Margin = New System.Windows.Forms.Padding(4)
        Me.txtStroke.Name = "txtStroke"
        Me.txtStroke.Size = New System.Drawing.Size(159, 22)
        Me.txtStroke.TabIndex = 38
        Me.txtStroke.Text = "Stroke"
        '
        'colTime
        '
        Me.colTime.Text = "Time"
        Me.colTime.Width = 73
        '
        'colType
        '
        Me.colType.Text = "Type of Time"
        Me.colType.Width = 134
        '
        'colGender
        '
        Me.colGender.Text = "Gender"
        Me.colGender.Width = 84
        '
        'DatabaseStaff
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1061, 647)
        Me.Controls.Add(Me.btnSearchStroke)
        Me.Controls.Add(Me.txtStroke)
        Me.Controls.Add(Me.btnSearchGender)
        Me.Controls.Add(Me.txtGender)
        Me.Controls.Add(Me.txtType)
        Me.Controls.Add(Me.txtTime)
        Me.Controls.Add(Me.txtClub)
        Me.Controls.Add(Me.txtAge)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.btnSearchType)
        Me.Controls.Add(Me.btnSearchTime)
        Me.Controls.Add(Me.btnSearchClub)
        Me.Controls.Add(Me.btnSearchAge)
        Me.Controls.Add(Me.btnSearchName)
        Me.Controls.Add(Me.lsvStaff)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnRefresh)
        Me.Controls.Add(Me.btnAdmin)
        Me.Controls.Add(Me.btnLogout)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "DatabaseStaff"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "DatabaseStaff"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnLogout As System.Windows.Forms.Button
    Friend WithEvents btnAdmin As System.Windows.Forms.Button
    Friend WithEvents btnRefresh As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lsvStaff As System.Windows.Forms.ListView
    Friend WithEvents colName As System.Windows.Forms.ColumnHeader
    Friend WithEvents colAge As System.Windows.Forms.ColumnHeader
    Friend WithEvents colClub As System.Windows.Forms.ColumnHeader
    Friend WithEvents btnSearchName As System.Windows.Forms.Button
    Friend WithEvents btnSearchAge As System.Windows.Forms.Button
    Friend WithEvents btnSearchClub As System.Windows.Forms.Button
    Friend WithEvents btnSearchTime As System.Windows.Forms.Button
    Friend WithEvents btnSearchType As System.Windows.Forms.Button
    Friend WithEvents txtName As System.Windows.Forms.TextBox
    Friend WithEvents txtAge As System.Windows.Forms.TextBox
    Friend WithEvents txtClub As System.Windows.Forms.TextBox
    Friend WithEvents txtTime As System.Windows.Forms.TextBox
    Friend WithEvents txtType As System.Windows.Forms.TextBox
    Friend WithEvents txtGender As System.Windows.Forms.TextBox
    Friend WithEvents btnSearchGender As System.Windows.Forms.Button
    Friend WithEvents colStroke As ColumnHeader
    Friend WithEvents btnSearchStroke As Button
    Friend WithEvents txtStroke As TextBox
    Friend WithEvents colTime As ColumnHeader
    Friend WithEvents colType As ColumnHeader
    Friend WithEvents colGender As ColumnHeader
End Class
