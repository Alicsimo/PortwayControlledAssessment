Public Class DatabaseStaff
    Dim db As New ClsDBConnector
    Dim ds As New DataSet

    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        LoginForm.Show()
        Me.Close()
    End Sub

    Private Sub btnAdmin_Click(sender As Object, e As EventArgs) Handles btnAdmin.Click
        AdminConsole.Show()
        Me.Close()
    End Sub

    Private Sub DatabaseStaff_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim sql As String

        db.connect("E:\CA Prototype\Controlled Assessment Prototype\PortwayDatabase.accdb")
        sql = "SELECT * FROM tblMembers WHERE MemberName LIKE '%" & txtName.Text & "%'"
        ds = db.sqlSelect(Sql)

        'MsgBox(ds.Tables("Results").Rows.Count())

        Dim recordCount As Integer = 0
        Dim xCounter As Integer = 0
        recordCount = ds.Tables("Results").Rows.Count   'Counts the number of records
        lsvStaff.Items.Clear()                          'Clears list view
        Do Until xCounter = recordCount                 'Adds all records available based on given query
            lsvStaff.Items.Add(ds.Tables("Results").Rows(xCounter).Item(0))
            lsvStaff.Items(xCounter).SubItems.Add(ds.Tables("Results").Rows(xCounter).Item(1))
            lsvStaff.Items(xCounter).SubItems.Add(ds.Tables("Results").Rows(xCounter).Item(2))
            lsvStaff.Items(xCounter).SubItems.Add(ds.Tables("Results").Rows(xCounter).Item(3))
            lsvStaff.Items(xCounter).SubItems.Add(ds.Tables("Results").Rows(xCounter).Item(4))
            lsvStaff.Items(xCounter).SubItems.Add(ds.Tables("Results").Rows(xCounter).Item(5))
            lsvStaff.Items(xCounter).SubItems.Add(ds.Tables("Results").Rows(xCounter).Item(6))
            lsvStaff.Items(xCounter).SubItems.Add(ds.Tables("Results").Rows(xCounter).Item(0))
            xCounter = xCounter + 1
        Loop
        db.close()

        'cmbAge.SelectedIndex = 0
        'cmbClub.SelectedIndex = 0
        'cmbTime.SelectedIndex = 0
        'cmbType.SelectedIndex = 0
    End Sub

    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        'Dim sql As String

        db.connect("E:\CA Prototype\Controlled Assessment Prototype\PortwayDatabase.accdb")
        'sql = "SELECT * FROM tblMembers WHERE MemberName LIKE '%" & txbName.Text & "%'"
        'ds = db.sqlSelect(sql)

        Dim recordCount As Integer = 0
        Dim xCounter As Integer = 0
        recordCount = ds.Tables("Results").Rows.Count   'Counts the number of records
        lsvStaff.Items.Clear()                          'Clears list view
        Do Until xCounter = recordCount                 'Adds all records available based on given query
            lsvStaff.Items.Add(ds.Tables("Results").Rows(xCounter).Item(0))
            lsvStaff.Items(xCounter).SubItems.Add(ds.Tables("Results").Rows(xCounter).Item(1))
            lsvStaff.Items(xCounter).SubItems.Add(ds.Tables("Results").Rows(xCounter).Item(2))
            lsvStaff.Items(xCounter).SubItems.Add(ds.Tables("Results").Rows(xCounter).Item(3))
            lsvStaff.Items(xCounter).SubItems.Add(ds.Tables("Results").Rows(xCounter).Item(4))
            lsvStaff.Items(xCounter).SubItems.Add(ds.Tables("Results").Rows(xCounter).Item(5))
            lsvStaff.Items(xCounter).SubItems.Add(ds.Tables("Results").Rows(xCounter).Item(6))
            lsvStaff.Items(xCounter).SubItems.Add(ds.Tables("Results").Rows(xCounter).Item(0))
            xCounter = xCounter + 1
        Loop
        db.close()
    End Sub

    Private Sub btnSearchName_Click(sender As Object, e As EventArgs) Handles btnSearchName.Click
        Dim sql As String
        sql = "SELECT * FROM tblMembers WHERE MemberName LIKE '%" & txtName.Text & "%'"


        db.connect("E:\CA Prototype\Controlled Assessment Prototype\PortwayDatabase.accdb")

        ds = db.sqlSelect(sql)
        'sends the above sql statement into the sqlSelect funtion inside the DBConnector Class

        'MsgBox(ds.Tables("Results").Rows.Count())
        'shows the number of rows of data returned

        Dim recordCount As Integer = 0
        Dim xCounter As Integer = 0
        recordCount = ds.Tables("Results").Rows.Count   'Counts the number of records
        lsvStaff.Items.Clear()                          'Clears list view
        Do Until xCounter = recordCount                 'Adds all records available based on given query
            lsvStaff.Items.Add(ds.Tables("Results").Rows(xCounter).Item(0))
            lsvStaff.Items(xCounter).SubItems.Add(ds.Tables("Results").Rows(xCounter).Item(1))
            lsvStaff.Items(xCounter).SubItems.Add(ds.Tables("Results").Rows(xCounter).Item(2))
            lsvStaff.Items(xCounter).SubItems.Add(ds.Tables("Results").Rows(xCounter).Item(3))
            lsvStaff.Items(xCounter).SubItems.Add(ds.Tables("Results").Rows(xCounter).Item(4))
            lsvStaff.Items(xCounter).SubItems.Add(ds.Tables("Results").Rows(xCounter).Item(5))
            lsvStaff.Items(xCounter).SubItems.Add(ds.Tables("Results").Rows(xCounter).Item(6))
            lsvStaff.Items(xCounter).SubItems.Add(ds.Tables("Results").Rows(xCounter).Item(0))
            xCounter = xCounter + 1
        Loop

        db.close()
    End Sub

    Private Sub btnSearchAge_Click(sender As Object, e As EventArgs) Handles btnSearchAge.Click
        Dim sql As String
        sql = "SELECT * FROM tblMembers WHERE MemberAge LIKE '%" & txtAge.Text & "%'"


        db.connect("E:\CA Prototype\Controlled Assessment Prototype\PortwayDatabase.accdb")

        ds = db.sqlSelect(sql)
        'sends the above sql statement into the sqlSelect funtion inside the DBConnector Class

        'MsgBox(ds.Tables("Results").Rows.Count())
        'shows the number of rows of data returned

        Dim recordCount As Integer = 0
        Dim xCounter As Integer = 0
        recordCount = ds.Tables("Results").Rows.Count   'Counts the number of records
        lsvStaff.Items.Clear()                          'Clears list view
        Do Until xCounter = recordCount                 'Adds all records available based on given query
            lsvStaff.Items.Add(ds.Tables("Results").Rows(xCounter).Item(0))
            lsvStaff.Items(xCounter).SubItems.Add(ds.Tables("Results").Rows(xCounter).Item(1))
            lsvStaff.Items(xCounter).SubItems.Add(ds.Tables("Results").Rows(xCounter).Item(2))
            lsvStaff.Items(xCounter).SubItems.Add(ds.Tables("Results").Rows(xCounter).Item(3))
            lsvStaff.Items(xCounter).SubItems.Add(ds.Tables("Results").Rows(xCounter).Item(4))
            lsvStaff.Items(xCounter).SubItems.Add(ds.Tables("Results").Rows(xCounter).Item(5))
            lsvStaff.Items(xCounter).SubItems.Add(ds.Tables("Results").Rows(xCounter).Item(6))
            lsvStaff.Items(xCounter).SubItems.Add(ds.Tables("Results").Rows(xCounter).Item(0))
            xCounter = xCounter + 1
        Loop

        db.close()
    End Sub

    Private Sub btnSearchClub_Click(sender As Object, e As EventArgs) Handles btnSearchClub.Click
        Dim sql As String
        sql = "SELECT * FROM tblMembers WHERE MemberClub LIKE '%" & txtClub.Text & "%'"


        db.connect("E:\CA Prototype\Controlled Assessment Prototype\PortwayDatabase.accdb")

        ds = db.sqlSelect(sql)
        'sends the above sql statement into the sqlSelect funtion inside the DBConnector Class

        'MsgBox(ds.Tables("Results").Rows.Count())
        'shows the number of rows of data returned

        Dim recordCount As Integer = 0
        Dim xCounter As Integer = 0
        recordCount = ds.Tables("Results").Rows.Count   'Counts the number of records
        lsvStaff.Items.Clear()                          'Clears list view
        Do Until xCounter = recordCount                 'Adds all records available based on given query
            lsvStaff.Items.Add(ds.Tables("Results").Rows(xCounter).Item(0))
            lsvStaff.Items(xCounter).SubItems.Add(ds.Tables("Results").Rows(xCounter).Item(1))
            lsvStaff.Items(xCounter).SubItems.Add(ds.Tables("Results").Rows(xCounter).Item(2))
            lsvStaff.Items(xCounter).SubItems.Add(ds.Tables("Results").Rows(xCounter).Item(3))
            lsvStaff.Items(xCounter).SubItems.Add(ds.Tables("Results").Rows(xCounter).Item(4))
            lsvStaff.Items(xCounter).SubItems.Add(ds.Tables("Results").Rows(xCounter).Item(5))
            lsvStaff.Items(xCounter).SubItems.Add(ds.Tables("Results").Rows(xCounter).Item(6))
            lsvStaff.Items(xCounter).SubItems.Add(ds.Tables("Results").Rows(xCounter).Item(0))
            xCounter = xCounter + 1
        Loop

        db.close()
    End Sub

    Private Sub btnSearchTime_Click(sender As Object, e As EventArgs) Handles btnSearchTime.Click
        Dim sql As String
        sql = "SELECT * FROM tblMembers WHERE MemberTime LIKE '%" & txtTime.Text & "%'"


        db.connect("E:\CA Prototype\Controlled Assessment Prototype\PortwayDatabase.accdb")

        ds = db.sqlSelect(sql)
        'sends the above sql statement into the sqlSelect funtion inside the DBConnector Class

        'MsgBox(ds.Tables("Results").Rows.Count())
        'shows the number of rows of data returned

        Dim recordCount As Integer = 0
        Dim xCounter As Integer = 0
        recordCount = ds.Tables("Results").Rows.Count   'Counts the number of records
        lsvStaff.Items.Clear()                          'Clears list view
        Do Until xCounter = recordCount                 'Adds all records available based on given query
            lsvStaff.Items.Add(ds.Tables("Results").Rows(xCounter).Item(0))
            lsvStaff.Items(xCounter).SubItems.Add(ds.Tables("Results").Rows(xCounter).Item(1))
            lsvStaff.Items(xCounter).SubItems.Add(ds.Tables("Results").Rows(xCounter).Item(2))
            lsvStaff.Items(xCounter).SubItems.Add(ds.Tables("Results").Rows(xCounter).Item(3))
            lsvStaff.Items(xCounter).SubItems.Add(ds.Tables("Results").Rows(xCounter).Item(4))
            lsvStaff.Items(xCounter).SubItems.Add(ds.Tables("Results").Rows(xCounter).Item(5))
            lsvStaff.Items(xCounter).SubItems.Add(ds.Tables("Results").Rows(xCounter).Item(6))
            lsvStaff.Items(xCounter).SubItems.Add(ds.Tables("Results").Rows(xCounter).Item(0))
            xCounter = xCounter + 1
        Loop

        db.close()
    End Sub

    Private Sub btnSearchType_Click(sender As Object, e As EventArgs) Handles btnSearchType.Click
        Dim sql As String
        sql = "SELECT * FROM tblMembers WHERE MemberType LIKE '%" & txtType.Text & "%'"


        db.connect("E:\CA Prototype\Controlled Assessment Prototype\PortwayDatabase.accdb")

        ds = db.sqlSelect(sql)
        'sends the above sql statement into the sqlSelect funtion inside the DBConnector Class

        'MsgBox(ds.Tables("Results").Rows.Count())
        'shows the number of rows of data returned

        Dim recordCount As Integer = 0
        Dim xCounter As Integer = 0
        recordCount = ds.Tables("Results").Rows.Count   'Counts the number of records
        lsvStaff.Items.Clear()                          'Clears list view
        Do Until xCounter = recordCount                 'Adds all records available based on given query
            lsvStaff.Items.Add(ds.Tables("Results").Rows(xCounter).Item(0))
            lsvStaff.Items(xCounter).SubItems.Add(ds.Tables("Results").Rows(xCounter).Item(1))
            lsvStaff.Items(xCounter).SubItems.Add(ds.Tables("Results").Rows(xCounter).Item(2))
            lsvStaff.Items(xCounter).SubItems.Add(ds.Tables("Results").Rows(xCounter).Item(3))
            lsvStaff.Items(xCounter).SubItems.Add(ds.Tables("Results").Rows(xCounter).Item(4))
            lsvStaff.Items(xCounter).SubItems.Add(ds.Tables("Results").Rows(xCounter).Item(5))
            lsvStaff.Items(xCounter).SubItems.Add(ds.Tables("Results").Rows(xCounter).Item(6))
            lsvStaff.Items(xCounter).SubItems.Add(ds.Tables("Results").Rows(xCounter).Item(0))
            xCounter = xCounter + 1
        Loop

        db.close()
    End Sub
End Class