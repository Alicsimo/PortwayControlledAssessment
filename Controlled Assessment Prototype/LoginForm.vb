

Public Class LoginForm
    Private Sub LoginForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblIncorrectLogin.Visible = False
    End Sub

    Dim db As New ClsDBConnector
    Dim ds As New DataSet

    '-OK
    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOK.Click
        Dim sql As String
        If radStaff.Checked = True Then
            db.connect("E:\CA Prototype\Controlled Assessment Prototype\StaffLogin.accdb")
            sql = "SELECT * FROM tblStaffLogins WHERE Username='" & txbUsername.Text & "'AND Password='" & txbPassword.Text & "'"
            ds = db.sqlSelect(sql)

            Dim recordCount As Integer = 0
            Dim xCounter As Integer = 0
            recordCount = ds.Tables("Results").Rows.Count
            db.close()
            If recordCount = 1 Then
                DatabaseStaff.Show()
                Me.Close()
            Else
                lblIncorrectLogin.Visible = True
            End If
        End If

        If radGuest.Checked = True Then
            DatabaseGuest.Show()
            Me.Close()
        End If
    End Sub

    '-CANCEL
    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnHelp.Click
        MsgBox("Welcome to Portway's membership database. In order to view the database, please insert your Name into the Username box and press Enter. If you are a staff member and have your password then please select the staff box.")
    End Sub

    '-STAFF
    Private Sub radStaff_CheckedChanged(sender As Object, e As EventArgs) Handles radStaff.CheckedChanged
        txbPassword.Visible = True
        lblPass.Visible = True

        If radGuest.Checked = True Then
            'DatabaseGuest.btnMoreOps.Visible = True
        End If
    End Sub

    '-GUEST
    Private Sub radGuest_CheckedChanged(sender As Object, e As EventArgs) Handles radGuest.CheckedChanged
        txbPassword.Visible = False
        lblPass.Visible = False

    End Sub
End Class
