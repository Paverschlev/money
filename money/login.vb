Public Class login
    Public pw As String
    Public t As Integer = 0
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Loginbut.Click
        If PWin.Text <> pw Then
            MsgBox("密碼輸入錯誤", MsgBoxStyle.Critical)
            GoTo ed
        End If

        If PWin.Text = pw Then
            money_wallet.Show()
            Me.Hide()
        End If
ed:
    End Sub

    Private Sub login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.FormBorderStyle = Windows.Forms.FormBorderStyle.FixedSingle
    End Sub
End Class