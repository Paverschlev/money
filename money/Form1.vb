Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load


    End Sub
    Dim wallet_money As Integer = 0
    Dim times As Integer = 0
    Dim SA_SP(11), systemtime(11), money(11) As Label
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles moneyBotton.Click
        If Not IsNumeric(moneychange.Text) Then
            MessageBox.Show("請輸入數字")
            Exit Sub
        End If
        times = times + 1
        If times > 10 Then
            times = 1
        End If
        Select Case SA_SPlist.SelectedIndex
            Case 0
                wallet_money = Val(walletmoney_now.Text) + Val(moneychange.Text)
                walletmoney_now.Text = Val(wallet_money)
                SA_SP(times) = Me.Controls("SA_SP" & times)
                money(times) = Me.Controls("money" & times)
                systemtime(times) = Me.Controls("systemtime" & times)
                SA_SP(times).Text = "存入"
                money(times).Text = Val(moneychange.Text)
                systemtime(times).Text = Format(Now, "yyyy/m/d h:m:s")
            Case 1
                wallet_money = Val(walletmoney_now.Text) - Val(moneychange.Text)
                walletmoney_now.Text = Val(wallet_money)
                SA_SP(times) = Me.Controls("SA_SP" & times)
                money(times) = Me.Controls("money" & times)
                systemtime(times) = Me.Controls("systemtime" & times)
                SA_SP(times).Text = "花費"
                money(times).Text = "-" & moneychange.Text
                systemtime(times).Text = Format(Now, "yyyy/m/d h:m:s")
        End Select
        moneychange.Text = ""
    End Sub

    Private Sub systemtime_Click(sender As Object, e As EventArgs) Handles system_time.Click

    End Sub
End Class
