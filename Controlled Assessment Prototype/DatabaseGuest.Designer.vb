<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DatabaseGuest
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
        Me.lsvGuest = New System.Windows.Forms.ListView()
        Me.colName = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colAge = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colClub = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colTime = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colType = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnRefresh = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtType = New System.Windows.Forms.TextBox()
        Me.txtTime = New System.Windows.Forms.TextBox()
        Me.txtClub = New System.Windows.Forms.TextBox()
        Me.txtAge = New System.Windows.Forms.TextBox()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.btnSearchType = New System.Windows.Forms.Button()
        Me.btnSearchTime = New System.Windows.Forms.Button()
        Me.btnSearchClub = New System.Windows.Forms.Button()
        Me.btnSearchAge = New System.Windows.Forms.Button()
        Me.btnSearchName = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnLogout
        '
        Me.btnLogout.Location = New System.Drawing.Point(3, 2)
        Me.btnLogout.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnLogout.Name = "btnLogout"
        Me.btnLogout.Size = New System.Drawing.Size(75, 28)
        Me.btnLogout.TabIndex = 0
        Me.btnLogout.Text = "Log Out"
        Me.btnLogout.UseVisualStyleBackColor = True
        '
        'lsvGuest
        '
        Me.lsvGuest.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.colName, Me.colAge, Me.colClub, Me.colTime, Me.colType})
        Me.lsvGuest.Location = New System.Drawing.Point(81, 34)
        Me.lsvGuest.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.lsvGuest.Name = "lsvGuest"
        Me.lsvGuest.Size = New System.Drawing.Size(744, 598)
        Me.lsvGuest.TabIndex = 1
        Me.lsvGuest.UseCompatibleStateImageBehavior = False
        Me.lsvGuest.View = System.Windows.Forms.View.Details
        '
        'colName
        '
        Me.colName.Text = "Name"
        '
        'colAge
        '
        Me.colAge.Text = "Age"
        '
        'colClub
        '
        Me.colClub.Text = "Club"
        '
        'colTime
        '
        Me.colTime.Text = "Time"
        '
        'colType
        '
        Me.colType.Text = "Type of Time"
        Me.colType.Width = 108
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
        Me.Label2.TabIndex = 19
        Me.Label2.Text = "Portway Swimming Club Database"
        '
        'btnRefresh
        '
        Me.btnRefresh.BackColor = System.Drawing.Color.White
        Me.btnRefresh.BackgroundImage = Global.Controlled_Assessment_Prototype.My.Resources.Resources.Refresh_Button
        Me.btnRefresh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnRefresh.Location = New System.Drawing.Point(796, 2)
        Me.btnRefresh.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnRefresh.Name = "btnRefresh"
        Me.btnRefresh.Size = New System.Drawing.Size(31, 28)
        Me.btnRefresh.TabIndex = 12
        Me.btnRefresh.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(933, 34)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(59, 17)
        Me.Label1.TabIndex = 30
        Me.Label1.Text = "Search"
        '
        'txtType
        '
        Me.txtType.Location = New System.Drawing.Point(884, 364)
        Me.txtType.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtType.Name = "txtType"
        Me.txtType.Size = New System.Drawing.Size(160, 22)
        Me.txtType.TabIndex = 45
        Me.txtType.Text = "Type of TIming"
        '
        'txtTime
        '
        Me.txtTime.Location = New System.Drawing.Point(884, 287)
        Me.txtTime.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtTime.Name = "txtTime"
        Me.txtTime.Size = New System.Drawing.Size(160, 22)
        Me.txtTime.TabIndex = 44
        Me.txtTime.Text = "Time"
        '
        'txtClub
        '
        Me.txtClub.Location = New System.Drawing.Point(884, 209)
        Me.txtClub.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtClub.Name = "txtClub"
        Me.txtClub.Size = New System.Drawing.Size(160, 22)
        Me.txtClub.TabIndex = 43
        Me.txtClub.Text = "Club"
        '
        'txtAge
        '
        Me.txtAge.Location = New System.Drawing.Point(884, 132)
        Me.txtAge.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtAge.Name = "txtAge"
        Me.txtAge.Size = New System.Drawing.Size(160, 22)
        Me.txtAge.TabIndex = 42
        Me.txtAge.Text = "Age"
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(884, 54)
        Me.txtName.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(160, 22)
        Me.txtName.TabIndex = 41
        Me.txtName.Text = "Name"
        '
        'btnSearchType
        '
        Me.btnSearchType.Location = New System.Drawing.Point(884, 396)
        Me.btnSearchType.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnSearchType.Name = "btnSearchType"
        Me.btnSearchType.Size = New System.Drawing.Size(161, 28)
        Me.btnSearchType.TabIndex = 40
        Me.btnSearchType.Text = "Type of Timing"
        Me.btnSearchType.UseVisualStyleBackColor = True
        '
        'btnSearchTime
        '
        Me.btnSearchTime.Location = New System.Drawing.Point(884, 319)
        Me.btnSearchTime.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnSearchTime.Name = "btnSearchTime"
        Me.btnSearchTime.Size = New System.Drawing.Size(161, 28)
        Me.btnSearchTime.TabIndex = 39
        Me.btnSearchTime.Text = "Time"
        Me.btnSearchTime.UseVisualStyleBackColor = True
        '
        'btnSearchClub
        '
        Me.btnSearchClub.Location = New System.Drawing.Point(884, 241)
        Me.btnSearchClub.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnSearchClub.Name = "btnSearchClub"
        Me.btnSearchClub.Size = New System.Drawing.Size(161, 28)
        Me.btnSearchClub.TabIndex = 38
        Me.btnSearchClub.Text = "Club"
        Me.btnSearchClub.UseVisualStyleBackColor = True
        '
        'btnSearchAge
        '
        Me.btnSearchAge.Location = New System.Drawing.Point(884, 164)
        Me.btnSearchAge.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnSearchAge.Name = "btnSearchAge"
        Me.btnSearchAge.Size = New System.Drawing.Size(161, 28)
        Me.btnSearchAge.TabIndex = 37
        Me.btnSearchAge.Text = "Age"
        Me.btnSearchAge.UseVisualStyleBackColor = True
        '
        'btnSearchName
        '
        Me.btnSearchName.Location = New System.Drawing.Point(884, 86)
        Me.btnSearchName.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnSearchName.Name = "btnSearchName"
        Me.btnSearchName.Size = New System.Drawing.Size(161, 28)
        Me.btnSearchName.TabIndex = 36
        Me.btnSearchName.Text = "Name"
        Me.btnSearchName.UseVisualStyleBackColor = True
        '
        'DatabaseGuest
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1061, 647)
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
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnRefresh)
        Me.Controls.Add(Me.lsvGuest)
        Me.Controls.Add(Me.btnLogout)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "DatabaseGuest"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "DatabaseGuest"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnLogout As System.Windows.Forms.Button
    Friend WithEvents lsvGuest As System.Windows.Forms.ListView
    Friend WithEvents btnRefresh As System.Windows.Forms.Button
    Friend WithEvents colName As System.Windows.Forms.ColumnHeader
    Friend WithEvents colAge As System.Windows.Forms.ColumnHeader
    Friend WithEvents colClub As System.Windows.Forms.ColumnHeader
    Friend WithEvents colTime As System.Windows.Forms.ColumnHeader
    Friend WithEvents colType As System.Windows.Forms.ColumnHeader
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtType As System.Windows.Forms.TextBox
    Friend WithEvents txtTime As System.Windows.Forms.TextBox
    Friend WithEvents txtClub As System.Windows.Forms.TextBox
    Friend WithEvents txtAge As System.Windows.Forms.TextBox
    Friend WithEvents txtName As System.Windows.Forms.TextBox
    Friend WithEvents btnSearchType As System.Windows.Forms.Button
    Friend WithEvents btnSearchTime As System.Windows.Forms.Button
    Friend WithEvents btnSearchClub As System.Windows.Forms.Button
    Friend WithEvents btnSearchAge As System.Windows.Forms.Button
    Friend WithEvents btnSearchName As System.Windows.Forms.Button
End Class
