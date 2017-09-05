Public Class AdminConsole
    Dim db As New ClsDBConnector
    Dim ds As New DataSet
    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        DatabaseStaff.Show()
        Me.Close()
    End Sub

    Private Sub AdminConsole_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cmbClub.SelectedIndex = 0
        cmbType.SelectedIndex = 0
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        'Adding Records
        Dim sql As String
        Dim rowcount As Short = 0

        sql = "INSERT INTO tblMembers (MemberName, MemberAge, MemberClub, MemberTime, MemberType) VALUES ('" & txbName.Text & "', '" & cmbAge.Text & "', '" & cmbClub.SelectedItem & "', '" & txbTime.Text & "', '" & cmbType.SelectedItem & "');"
        db.connect("E:\CA Prototype\Controlled Assessment Prototype\PortwayDatabase.accdb")
        ds = db.sqlSelect(sql)
        db.close()

        If txbName.Text = ("") Then
            MsgBox("Please enter a full name")
        End If
        If cmbAge.Text = ("") Then
            MsgBox("Please choose an age")
        End If
        If cmbClub.Text = ("") Then
            MsgBox("Please choose a club")
        End If
        If txbTime.Text = ("") Then
            MsgBox("Please enter the recorded time")
        End If
        If cmbType.Text = ("") Then
            MsgBox("Please choose how the time was recorded")
        End If

        DatabaseStaff.Show()
        Me.Close()
    End Sub
End Class