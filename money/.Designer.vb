<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class money_wallet
    Inherits System.Windows.Forms.Form

    'Form 覆寫 Dispose 以清除元件清單。
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    '為 Windows Form 設計工具的必要項
    Private components As System.ComponentModel.IContainer

    '注意: 以下為 Windows Form 設計工具所需的程序
    '可以使用 Windows Form 設計工具進行修改。
    '請勿使用程式碼編輯器進行修改。
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.SA_SPlist = New System.Windows.Forms.ComboBox()
        Me.moneychange = New System.Windows.Forms.TextBox()
        Me.walletmoney_now = New System.Windows.Forms.Label()
        Me.wallet = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.critmon = New System.Windows.Forms.TextBox()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.critmonmax = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'SA_SPlist
        '
        Me.SA_SPlist.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.SA_SPlist.Font = New System.Drawing.Font("新細明體", 20.0!)
        Me.SA_SPlist.FormattingEnabled = True
        Me.SA_SPlist.Items.AddRange(New Object() {"存入", "花費(行)", "花費(衣)", "花費(住)", "花費(食)"})
        Me.SA_SPlist.Location = New System.Drawing.Point(135, 60)
        Me.SA_SPlist.Name = "SA_SPlist"
        Me.SA_SPlist.Size = New System.Drawing.Size(120, 35)
        Me.SA_SPlist.Sorted = True
        Me.SA_SPlist.TabIndex = 97
        '
        'moneychange
        '
        Me.moneychange.Font = New System.Drawing.Font("新細明體", 20.0!)
        Me.moneychange.Location = New System.Drawing.Point(6, 60)
        Me.moneychange.Multiline = True
        Me.moneychange.Name = "moneychange"
        Me.moneychange.Size = New System.Drawing.Size(123, 35)
        Me.moneychange.TabIndex = 53
        Me.moneychange.UseSystemPasswordChar = True
        '
        'walletmoney_now
        '
        Me.walletmoney_now.AutoSize = True
        Me.walletmoney_now.Font = New System.Drawing.Font("新細明體", 25.0!)
        Me.walletmoney_now.Location = New System.Drawing.Point(156, 9)
        Me.walletmoney_now.Name = "walletmoney_now"
        Me.walletmoney_now.Size = New System.Drawing.Size(31, 34)
        Me.walletmoney_now.TabIndex = 51
        Me.walletmoney_now.Text = "0"
        '
        'wallet
        '
        Me.wallet.AutoSize = True
        Me.wallet.Font = New System.Drawing.Font("新細明體", 25.0!)
        Me.wallet.Location = New System.Drawing.Point(0, 9)
        Me.wallet.Name = "wallet"
        Me.wallet.Size = New System.Drawing.Size(160, 34)
        Me.wallet.TabIndex = 50
        Me.wallet.Text = "錢包餘額:"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(8, 101)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(135, 52)
        Me.Button1.TabIndex = 98
        Me.Button1.Text = "確認"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(149, 160)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(141, 48)
        Me.Button2.TabIndex = 99
        Me.Button2.Text = "更改密碼"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(6, 214)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(137, 48)
        Me.Button3.TabIndex = 183
        Me.Button3.Text = "登出"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(6, 159)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(137, 49)
        Me.Button4.TabIndex = 184
        Me.Button4.Text = "紀錄"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(149, 214)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(141, 48)
        Me.Button5.TabIndex = 185
        Me.Button5.Text = "發票兌獎"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'critmon
        '
        Me.critmon.Font = New System.Drawing.Font("新細明體", 20.0!)
        Me.critmon.Location = New System.Drawing.Point(3, 267)
        Me.critmon.Name = "critmon"
        Me.critmon.Size = New System.Drawing.Size(140, 39)
        Me.critmon.TabIndex = 186
        '
        'Button6
        '
        Me.Button6.Location = New System.Drawing.Point(149, 268)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(141, 40)
        Me.Button6.TabIndex = 187
        Me.Button6.Text = "設定最高預算"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("新細明體", 20.0!)
        Me.Label1.Location = New System.Drawing.Point(1, 309)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(181, 27)
        Me.Label1.TabIndex = 188
        Me.Label1.Text = "目前最高預算:"
        '
        'critmonmax
        '
        Me.critmonmax.AutoSize = True
        Me.critmonmax.Font = New System.Drawing.Font("新細明體", 20.0!)
        Me.critmonmax.Location = New System.Drawing.Point(180, 311)
        Me.critmonmax.Name = "critmonmax"
        Me.critmonmax.Size = New System.Drawing.Size(39, 27)
        Me.critmonmax.TabIndex = 189
        Me.critmonmax.Text = "無"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("新細明體", 20.0!)
        Me.Label2.ForeColor = System.Drawing.Color.Red
        Me.Label2.Location = New System.Drawing.Point(12, 336)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(83, 27)
        Me.Label2.TabIndex = 190
        Me.Label2.Text = "Label2"
        Me.Label2.Visible = False
        '
        'Button7
        '
        Me.Button7.Location = New System.Drawing.Point(149, 102)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(135, 52)
        Me.Button7.TabIndex = 191
        Me.Button7.Text = "圓餅圖"
        Me.Button7.UseVisualStyleBackColor = True
        '
        'money_wallet
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(383, 378)
        Me.Controls.Add(Me.Button7)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.critmonmax)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.critmon)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.wallet)
        Me.Controls.Add(Me.SA_SPlist)
        Me.Controls.Add(Me.walletmoney_now)
        Me.Controls.Add(Me.moneychange)
        Me.Name = "money_wallet"
        Me.Text = "money"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents SA_SPlist As ComboBox
    Friend WithEvents moneychange As TextBox
    Friend WithEvents walletmoney_now As Label
    Friend WithEvents wallet As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents critmon As TextBox
    Friend WithEvents Button6 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents critmonmax As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Button7 As Button
End Class
