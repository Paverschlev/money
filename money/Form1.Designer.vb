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
        Me.Label6 = New System.Windows.Forms.Label()
        Me.systemtime7 = New System.Windows.Forms.Label()
        Me.systemtime3 = New System.Windows.Forms.Label()
        Me.SA_SP10 = New System.Windows.Forms.Label()
        Me.money2 = New System.Windows.Forms.Label()
        Me.system_time = New System.Windows.Forms.Label()
        Me.SA_SP9 = New System.Windows.Forms.Label()
        Me.SA_SP1 = New System.Windows.Forms.Label()
        Me.money8 = New System.Windows.Forms.Label()
        Me.money3 = New System.Windows.Forms.Label()
        Me.systemtime6 = New System.Windows.Forms.Label()
        Me.systemtime4 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.systemtime8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.money9 = New System.Windows.Forms.Label()
        Me.systemtime2 = New System.Windows.Forms.Label()
        Me.SA_SP5 = New System.Windows.Forms.Label()
        Me.money1 = New System.Windows.Forms.Label()
        Me.SA_SP8 = New System.Windows.Forms.Label()
        Me.changesmoney = New System.Windows.Forms.Label()
        Me.money7 = New System.Windows.Forms.Label()
        Me.SA_SP2 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.money4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.systemtime5 = New System.Windows.Forms.Label()
        Me.systemtime9 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.money10 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.SA_SP4 = New System.Windows.Forms.Label()
        Me.systemtime1 = New System.Windows.Forms.Label()
        Me.SA_SP6 = New System.Windows.Forms.Label()
        Me.SA_SP7 = New System.Windows.Forms.Label()
        Me.save_spend = New System.Windows.Forms.Label()
        Me.money6 = New System.Windows.Forms.Label()
        Me.SA_SP3 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.money5 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.systemtime10 = New System.Windows.Forms.Label()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'SA_SPlist
        '
        Me.SA_SPlist.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.SA_SPlist.Font = New System.Drawing.Font("新細明體", 20.0!)
        Me.SA_SPlist.FormattingEnabled = True
        Me.SA_SPlist.Items.AddRange(New Object() {"存入", "花費"})
        Me.SA_SPlist.Location = New System.Drawing.Point(135, 60)
        Me.SA_SPlist.Name = "SA_SPlist"
        Me.SA_SPlist.Size = New System.Drawing.Size(82, 35)
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
        Me.Button1.Location = New System.Drawing.Point(223, 60)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(87, 35)
        Me.Button1.TabIndex = 98
        Me.Button1.Text = "確認"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(162, 368)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(141, 48)
        Me.Button2.TabIndex = 99
        Me.Button2.Text = "更改密碼"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AccessibleRole = System.Windows.Forms.AccessibleRole.OutlineButton
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("新細明體", 18.0!)
        Me.Label6.Location = New System.Drawing.Point(19, 221)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(21, 24)
        Me.Label6.TabIndex = 177
        Me.Label6.Text = "5"
        '
        'systemtime7
        '
        Me.systemtime7.AccessibleRole = System.Windows.Forms.AccessibleRole.OutlineButton
        Me.systemtime7.AutoSize = True
        Me.systemtime7.Font = New System.Drawing.Font("新細明體", 18.0!)
        Me.systemtime7.Location = New System.Drawing.Point(277, 269)
        Me.systemtime7.Name = "systemtime7"
        Me.systemtime7.Size = New System.Drawing.Size(26, 24)
        Me.systemtime7.TabIndex = 171
        Me.systemtime7.Text = "--"
        '
        'systemtime3
        '
        Me.systemtime3.AccessibleRole = System.Windows.Forms.AccessibleRole.OutlineButton
        Me.systemtime3.AutoSize = True
        Me.systemtime3.Font = New System.Drawing.Font("新細明體", 18.0!)
        Me.systemtime3.Location = New System.Drawing.Point(277, 173)
        Me.systemtime3.Name = "systemtime3"
        Me.systemtime3.Size = New System.Drawing.Size(26, 24)
        Me.systemtime3.TabIndex = 165
        Me.systemtime3.Text = "--"
        '
        'SA_SP10
        '
        Me.SA_SP10.AccessibleRole = System.Windows.Forms.AccessibleRole.OutlineButton
        Me.SA_SP10.AutoSize = True
        Me.SA_SP10.Font = New System.Drawing.Font("新細明體", 18.0!)
        Me.SA_SP10.Location = New System.Drawing.Point(46, 341)
        Me.SA_SP10.Name = "SA_SP10"
        Me.SA_SP10.Size = New System.Drawing.Size(26, 24)
        Me.SA_SP10.TabIndex = 148
        Me.SA_SP10.Text = "--"
        '
        'money2
        '
        Me.money2.AccessibleRole = System.Windows.Forms.AccessibleRole.OutlineButton
        Me.money2.AutoSize = True
        Me.money2.Font = New System.Drawing.Font("新細明體", 18.0!)
        Me.money2.Location = New System.Drawing.Point(152, 149)
        Me.money2.Name = "money2"
        Me.money2.Size = New System.Drawing.Size(26, 24)
        Me.money2.TabIndex = 154
        Me.money2.Text = "--"
        '
        'system_time
        '
        Me.system_time.AccessibleRole = System.Windows.Forms.AccessibleRole.OutlineButton
        Me.system_time.AutoSize = True
        Me.system_time.Font = New System.Drawing.Font("新細明體", 20.0!)
        Me.system_time.Location = New System.Drawing.Point(255, 98)
        Me.system_time.Name = "system_time"
        Me.system_time.Size = New System.Drawing.Size(66, 27)
        Me.system_time.TabIndex = 142
        Me.system_time.Text = "時間"
        '
        'SA_SP9
        '
        Me.SA_SP9.AccessibleRole = System.Windows.Forms.AccessibleRole.OutlineButton
        Me.SA_SP9.AutoSize = True
        Me.SA_SP9.Font = New System.Drawing.Font("新細明體", 18.0!)
        Me.SA_SP9.Location = New System.Drawing.Point(45, 317)
        Me.SA_SP9.Name = "SA_SP9"
        Me.SA_SP9.Size = New System.Drawing.Size(26, 24)
        Me.SA_SP9.TabIndex = 149
        Me.SA_SP9.Text = "--"
        '
        'SA_SP1
        '
        Me.SA_SP1.AccessibleRole = System.Windows.Forms.AccessibleRole.OutlineButton
        Me.SA_SP1.AutoSize = True
        Me.SA_SP1.Font = New System.Drawing.Font("新細明體", 18.0!)
        Me.SA_SP1.Location = New System.Drawing.Point(45, 125)
        Me.SA_SP1.Name = "SA_SP1"
        Me.SA_SP1.Size = New System.Drawing.Size(26, 24)
        Me.SA_SP1.TabIndex = 143
        Me.SA_SP1.Text = "--"
        '
        'money8
        '
        Me.money8.AccessibleRole = System.Windows.Forms.AccessibleRole.OutlineButton
        Me.money8.AutoSize = True
        Me.money8.Font = New System.Drawing.Font("新細明體", 18.0!)
        Me.money8.Location = New System.Drawing.Point(153, 293)
        Me.money8.Name = "money8"
        Me.money8.Size = New System.Drawing.Size(26, 24)
        Me.money8.TabIndex = 160
        Me.money8.Text = "--"
        '
        'money3
        '
        Me.money3.AccessibleRole = System.Windows.Forms.AccessibleRole.OutlineButton
        Me.money3.AutoSize = True
        Me.money3.Font = New System.Drawing.Font("新細明體", 18.0!)
        Me.money3.Location = New System.Drawing.Point(152, 173)
        Me.money3.Name = "money3"
        Me.money3.Size = New System.Drawing.Size(26, 24)
        Me.money3.TabIndex = 155
        Me.money3.Text = "--"
        '
        'systemtime6
        '
        Me.systemtime6.AccessibleRole = System.Windows.Forms.AccessibleRole.OutlineButton
        Me.systemtime6.AutoSize = True
        Me.systemtime6.Font = New System.Drawing.Font("新細明體", 18.0!)
        Me.systemtime6.Location = New System.Drawing.Point(277, 245)
        Me.systemtime6.Name = "systemtime6"
        Me.systemtime6.Size = New System.Drawing.Size(26, 24)
        Me.systemtime6.TabIndex = 172
        Me.systemtime6.Text = "--"
        '
        'systemtime4
        '
        Me.systemtime4.AccessibleRole = System.Windows.Forms.AccessibleRole.OutlineButton
        Me.systemtime4.AutoSize = True
        Me.systemtime4.Font = New System.Drawing.Font("新細明體", 18.0!)
        Me.systemtime4.Location = New System.Drawing.Point(277, 197)
        Me.systemtime4.Name = "systemtime4"
        Me.systemtime4.Size = New System.Drawing.Size(26, 24)
        Me.systemtime4.TabIndex = 166
        Me.systemtime4.Text = "--"
        '
        'Label1
        '
        Me.Label1.AccessibleRole = System.Windows.Forms.AccessibleRole.OutlineButton
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("新細明體", 18.0!)
        Me.Label1.Location = New System.Drawing.Point(19, 245)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(21, 24)
        Me.Label1.TabIndex = 182
        Me.Label1.Text = "6"
        '
        'Label5
        '
        Me.Label5.AccessibleRole = System.Windows.Forms.AccessibleRole.OutlineButton
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("新細明體", 18.0!)
        Me.Label5.Location = New System.Drawing.Point(7, 341)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(32, 24)
        Me.Label5.TabIndex = 178
        Me.Label5.Text = "10"
        '
        'systemtime8
        '
        Me.systemtime8.AccessibleRole = System.Windows.Forms.AccessibleRole.OutlineButton
        Me.systemtime8.AutoSize = True
        Me.systemtime8.Font = New System.Drawing.Font("新細明體", 18.0!)
        Me.systemtime8.Location = New System.Drawing.Point(278, 293)
        Me.systemtime8.Name = "systemtime8"
        Me.systemtime8.Size = New System.Drawing.Size(26, 24)
        Me.systemtime8.TabIndex = 170
        Me.systemtime8.Text = "--"
        '
        'Label7
        '
        Me.Label7.AccessibleRole = System.Windows.Forms.AccessibleRole.OutlineButton
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("新細明體", 18.0!)
        Me.Label7.Location = New System.Drawing.Point(19, 197)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(21, 24)
        Me.Label7.TabIndex = 176
        Me.Label7.Text = "4"
        '
        'money9
        '
        Me.money9.AccessibleRole = System.Windows.Forms.AccessibleRole.OutlineButton
        Me.money9.AutoSize = True
        Me.money9.Font = New System.Drawing.Font("新細明體", 18.0!)
        Me.money9.Location = New System.Drawing.Point(152, 317)
        Me.money9.Name = "money9"
        Me.money9.Size = New System.Drawing.Size(26, 24)
        Me.money9.TabIndex = 159
        Me.money9.Text = "--"
        '
        'systemtime2
        '
        Me.systemtime2.AccessibleRole = System.Windows.Forms.AccessibleRole.OutlineButton
        Me.systemtime2.AutoSize = True
        Me.systemtime2.Font = New System.Drawing.Font("新細明體", 18.0!)
        Me.systemtime2.Location = New System.Drawing.Point(277, 149)
        Me.systemtime2.Name = "systemtime2"
        Me.systemtime2.Size = New System.Drawing.Size(26, 24)
        Me.systemtime2.TabIndex = 164
        Me.systemtime2.Text = "--"
        '
        'SA_SP5
        '
        Me.SA_SP5.AccessibleRole = System.Windows.Forms.AccessibleRole.OutlineButton
        Me.SA_SP5.AutoSize = True
        Me.SA_SP5.Font = New System.Drawing.Font("新細明體", 18.0!)
        Me.SA_SP5.Location = New System.Drawing.Point(45, 221)
        Me.SA_SP5.Name = "SA_SP5"
        Me.SA_SP5.Size = New System.Drawing.Size(26, 24)
        Me.SA_SP5.TabIndex = 147
        Me.SA_SP5.Text = "--"
        '
        'money1
        '
        Me.money1.AccessibleRole = System.Windows.Forms.AccessibleRole.OutlineButton
        Me.money1.AutoSize = True
        Me.money1.Font = New System.Drawing.Font("新細明體", 18.0!)
        Me.money1.Location = New System.Drawing.Point(152, 125)
        Me.money1.Name = "money1"
        Me.money1.Size = New System.Drawing.Size(26, 24)
        Me.money1.TabIndex = 153
        Me.money1.Text = "--"
        '
        'SA_SP8
        '
        Me.SA_SP8.AccessibleRole = System.Windows.Forms.AccessibleRole.OutlineButton
        Me.SA_SP8.AutoSize = True
        Me.SA_SP8.Font = New System.Drawing.Font("新細明體", 18.0!)
        Me.SA_SP8.Location = New System.Drawing.Point(46, 293)
        Me.SA_SP8.Name = "SA_SP8"
        Me.SA_SP8.Size = New System.Drawing.Size(26, 24)
        Me.SA_SP8.TabIndex = 150
        Me.SA_SP8.Text = "--"
        '
        'changesmoney
        '
        Me.changesmoney.AccessibleRole = System.Windows.Forms.AccessibleRole.OutlineButton
        Me.changesmoney.AutoSize = True
        Me.changesmoney.Font = New System.Drawing.Font("新細明體", 20.0!)
        Me.changesmoney.Location = New System.Drawing.Point(132, 98)
        Me.changesmoney.Name = "changesmoney"
        Me.changesmoney.Size = New System.Drawing.Size(66, 27)
        Me.changesmoney.TabIndex = 141
        Me.changesmoney.Text = "金額"
        '
        'money7
        '
        Me.money7.AccessibleRole = System.Windows.Forms.AccessibleRole.OutlineButton
        Me.money7.AutoSize = True
        Me.money7.Font = New System.Drawing.Font("新細明體", 18.0!)
        Me.money7.Location = New System.Drawing.Point(152, 269)
        Me.money7.Name = "money7"
        Me.money7.Size = New System.Drawing.Size(26, 24)
        Me.money7.TabIndex = 161
        Me.money7.Text = "--"
        '
        'SA_SP2
        '
        Me.SA_SP2.AccessibleRole = System.Windows.Forms.AccessibleRole.OutlineButton
        Me.SA_SP2.AutoSize = True
        Me.SA_SP2.Font = New System.Drawing.Font("新細明體", 18.0!)
        Me.SA_SP2.Location = New System.Drawing.Point(45, 149)
        Me.SA_SP2.Name = "SA_SP2"
        Me.SA_SP2.Size = New System.Drawing.Size(26, 24)
        Me.SA_SP2.TabIndex = 144
        Me.SA_SP2.Text = "--"
        '
        'Label10
        '
        Me.Label10.AccessibleRole = System.Windows.Forms.AccessibleRole.OutlineButton
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("新細明體", 18.0!)
        Me.Label10.Location = New System.Drawing.Point(18, 125)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(21, 24)
        Me.Label10.TabIndex = 173
        Me.Label10.Text = "1"
        '
        'money4
        '
        Me.money4.AccessibleRole = System.Windows.Forms.AccessibleRole.OutlineButton
        Me.money4.AutoSize = True
        Me.money4.Font = New System.Drawing.Font("新細明體", 18.0!)
        Me.money4.Location = New System.Drawing.Point(152, 197)
        Me.money4.Name = "money4"
        Me.money4.Size = New System.Drawing.Size(26, 24)
        Me.money4.TabIndex = 156
        Me.money4.Text = "--"
        '
        'Label2
        '
        Me.Label2.AccessibleRole = System.Windows.Forms.AccessibleRole.OutlineButton
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("新細明體", 18.0!)
        Me.Label2.Location = New System.Drawing.Point(19, 269)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(21, 24)
        Me.Label2.TabIndex = 181
        Me.Label2.Text = "7"
        '
        'systemtime5
        '
        Me.systemtime5.AccessibleRole = System.Windows.Forms.AccessibleRole.OutlineButton
        Me.systemtime5.AutoSize = True
        Me.systemtime5.Font = New System.Drawing.Font("新細明體", 18.0!)
        Me.systemtime5.Location = New System.Drawing.Point(277, 221)
        Me.systemtime5.Name = "systemtime5"
        Me.systemtime5.Size = New System.Drawing.Size(26, 24)
        Me.systemtime5.TabIndex = 167
        Me.systemtime5.Text = "--"
        '
        'systemtime9
        '
        Me.systemtime9.AccessibleRole = System.Windows.Forms.AccessibleRole.OutlineButton
        Me.systemtime9.AutoSize = True
        Me.systemtime9.Font = New System.Drawing.Font("新細明體", 18.0!)
        Me.systemtime9.Location = New System.Drawing.Point(277, 317)
        Me.systemtime9.Name = "systemtime9"
        Me.systemtime9.Size = New System.Drawing.Size(26, 24)
        Me.systemtime9.TabIndex = 169
        Me.systemtime9.Text = "--"
        '
        'Label4
        '
        Me.Label4.AccessibleRole = System.Windows.Forms.AccessibleRole.OutlineButton
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("新細明體", 18.0!)
        Me.Label4.Location = New System.Drawing.Point(18, 317)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(21, 24)
        Me.Label4.TabIndex = 179
        Me.Label4.Text = "9"
        '
        'money10
        '
        Me.money10.AccessibleRole = System.Windows.Forms.AccessibleRole.OutlineButton
        Me.money10.AutoSize = True
        Me.money10.Font = New System.Drawing.Font("新細明體", 18.0!)
        Me.money10.Location = New System.Drawing.Point(153, 341)
        Me.money10.Name = "money10"
        Me.money10.Size = New System.Drawing.Size(26, 24)
        Me.money10.TabIndex = 158
        Me.money10.Text = "--"
        '
        'Label8
        '
        Me.Label8.AccessibleRole = System.Windows.Forms.AccessibleRole.OutlineButton
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("新細明體", 18.0!)
        Me.Label8.Location = New System.Drawing.Point(19, 173)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(21, 24)
        Me.Label8.TabIndex = 175
        Me.Label8.Text = "3"
        '
        'SA_SP4
        '
        Me.SA_SP4.AccessibleRole = System.Windows.Forms.AccessibleRole.OutlineButton
        Me.SA_SP4.AutoSize = True
        Me.SA_SP4.Font = New System.Drawing.Font("新細明體", 18.0!)
        Me.SA_SP4.Location = New System.Drawing.Point(45, 197)
        Me.SA_SP4.Name = "SA_SP4"
        Me.SA_SP4.Size = New System.Drawing.Size(26, 24)
        Me.SA_SP4.TabIndex = 146
        Me.SA_SP4.Text = "--"
        '
        'systemtime1
        '
        Me.systemtime1.AccessibleRole = System.Windows.Forms.AccessibleRole.OutlineButton
        Me.systemtime1.AutoSize = True
        Me.systemtime1.Font = New System.Drawing.Font("新細明體", 18.0!)
        Me.systemtime1.Location = New System.Drawing.Point(277, 125)
        Me.systemtime1.Name = "systemtime1"
        Me.systemtime1.Size = New System.Drawing.Size(26, 24)
        Me.systemtime1.TabIndex = 163
        Me.systemtime1.Text = "--"
        '
        'SA_SP6
        '
        Me.SA_SP6.AccessibleRole = System.Windows.Forms.AccessibleRole.OutlineButton
        Me.SA_SP6.AutoSize = True
        Me.SA_SP6.Font = New System.Drawing.Font("新細明體", 18.0!)
        Me.SA_SP6.Location = New System.Drawing.Point(45, 245)
        Me.SA_SP6.Name = "SA_SP6"
        Me.SA_SP6.Size = New System.Drawing.Size(26, 24)
        Me.SA_SP6.TabIndex = 152
        Me.SA_SP6.Text = "--"
        '
        'SA_SP7
        '
        Me.SA_SP7.AccessibleRole = System.Windows.Forms.AccessibleRole.OutlineButton
        Me.SA_SP7.AutoSize = True
        Me.SA_SP7.Font = New System.Drawing.Font("新細明體", 18.0!)
        Me.SA_SP7.Location = New System.Drawing.Point(45, 269)
        Me.SA_SP7.Name = "SA_SP7"
        Me.SA_SP7.Size = New System.Drawing.Size(26, 24)
        Me.SA_SP7.TabIndex = 151
        Me.SA_SP7.Text = "--"
        '
        'save_spend
        '
        Me.save_spend.AccessibleRole = System.Windows.Forms.AccessibleRole.OutlineButton
        Me.save_spend.AutoSize = True
        Me.save_spend.Font = New System.Drawing.Font("新細明體", 20.0!)
        Me.save_spend.Location = New System.Drawing.Point(12, 98)
        Me.save_spend.Name = "save_spend"
        Me.save_spend.Size = New System.Drawing.Size(73, 27)
        Me.save_spend.TabIndex = 140
        Me.save_spend.Text = "存/取"
        '
        'money6
        '
        Me.money6.AccessibleRole = System.Windows.Forms.AccessibleRole.OutlineButton
        Me.money6.AutoSize = True
        Me.money6.Font = New System.Drawing.Font("新細明體", 18.0!)
        Me.money6.Location = New System.Drawing.Point(152, 245)
        Me.money6.Name = "money6"
        Me.money6.Size = New System.Drawing.Size(26, 24)
        Me.money6.TabIndex = 162
        Me.money6.Text = "--"
        '
        'SA_SP3
        '
        Me.SA_SP3.AccessibleRole = System.Windows.Forms.AccessibleRole.OutlineButton
        Me.SA_SP3.AutoSize = True
        Me.SA_SP3.Font = New System.Drawing.Font("新細明體", 18.0!)
        Me.SA_SP3.Location = New System.Drawing.Point(45, 173)
        Me.SA_SP3.Name = "SA_SP3"
        Me.SA_SP3.Size = New System.Drawing.Size(26, 24)
        Me.SA_SP3.TabIndex = 145
        Me.SA_SP3.Text = "--"
        '
        'Label9
        '
        Me.Label9.AccessibleRole = System.Windows.Forms.AccessibleRole.OutlineButton
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("新細明體", 18.0!)
        Me.Label9.Location = New System.Drawing.Point(19, 149)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(21, 24)
        Me.Label9.TabIndex = 174
        Me.Label9.Text = "2"
        '
        'money5
        '
        Me.money5.AccessibleRole = System.Windows.Forms.AccessibleRole.OutlineButton
        Me.money5.AutoSize = True
        Me.money5.Font = New System.Drawing.Font("新細明體", 18.0!)
        Me.money5.Location = New System.Drawing.Point(152, 221)
        Me.money5.Name = "money5"
        Me.money5.Size = New System.Drawing.Size(26, 24)
        Me.money5.TabIndex = 157
        Me.money5.Text = "--"
        '
        'Label3
        '
        Me.Label3.AccessibleRole = System.Windows.Forms.AccessibleRole.OutlineButton
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("新細明體", 18.0!)
        Me.Label3.Location = New System.Drawing.Point(19, 293)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(21, 24)
        Me.Label3.TabIndex = 180
        Me.Label3.Text = "8"
        '
        'systemtime10
        '
        Me.systemtime10.AccessibleRole = System.Windows.Forms.AccessibleRole.OutlineButton
        Me.systemtime10.AutoSize = True
        Me.systemtime10.Font = New System.Drawing.Font("新細明體", 18.0!)
        Me.systemtime10.Location = New System.Drawing.Point(278, 341)
        Me.systemtime10.Name = "systemtime10"
        Me.systemtime10.Size = New System.Drawing.Size(26, 24)
        Me.systemtime10.TabIndex = 168
        Me.systemtime10.Text = "--"
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(6, 368)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(150, 48)
        Me.Button3.TabIndex = 183
        Me.Button3.Text = "登出"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'money_wallet
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(532, 427)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.systemtime7)
        Me.Controls.Add(Me.systemtime3)
        Me.Controls.Add(Me.SA_SP10)
        Me.Controls.Add(Me.money2)
        Me.Controls.Add(Me.system_time)
        Me.Controls.Add(Me.SA_SP9)
        Me.Controls.Add(Me.SA_SP1)
        Me.Controls.Add(Me.money8)
        Me.Controls.Add(Me.money3)
        Me.Controls.Add(Me.systemtime6)
        Me.Controls.Add(Me.systemtime4)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.systemtime8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.money9)
        Me.Controls.Add(Me.systemtime2)
        Me.Controls.Add(Me.SA_SP5)
        Me.Controls.Add(Me.money1)
        Me.Controls.Add(Me.SA_SP8)
        Me.Controls.Add(Me.changesmoney)
        Me.Controls.Add(Me.money7)
        Me.Controls.Add(Me.SA_SP2)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.money4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.systemtime5)
        Me.Controls.Add(Me.systemtime9)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.money10)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.SA_SP4)
        Me.Controls.Add(Me.systemtime1)
        Me.Controls.Add(Me.SA_SP6)
        Me.Controls.Add(Me.SA_SP7)
        Me.Controls.Add(Me.save_spend)
        Me.Controls.Add(Me.money6)
        Me.Controls.Add(Me.SA_SP3)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.money5)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.systemtime10)
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
    Friend WithEvents Label6 As Label
    Friend WithEvents systemtime7 As Label
    Friend WithEvents systemtime3 As Label
    Friend WithEvents SA_SP10 As Label
    Friend WithEvents money2 As Label
    Friend WithEvents system_time As Label
    Friend WithEvents SA_SP9 As Label
    Friend WithEvents SA_SP1 As Label
    Friend WithEvents money8 As Label
    Friend WithEvents money3 As Label
    Friend WithEvents systemtime6 As Label
    Friend WithEvents systemtime4 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents systemtime8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents money9 As Label
    Friend WithEvents systemtime2 As Label
    Friend WithEvents SA_SP5 As Label
    Friend WithEvents money1 As Label
    Friend WithEvents SA_SP8 As Label
    Friend WithEvents changesmoney As Label
    Friend WithEvents money7 As Label
    Friend WithEvents SA_SP2 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents money4 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents systemtime5 As Label
    Friend WithEvents systemtime9 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents money10 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents SA_SP4 As Label
    Friend WithEvents systemtime1 As Label
    Friend WithEvents SA_SP6 As Label
    Friend WithEvents SA_SP7 As Label
    Friend WithEvents save_spend As Label
    Friend WithEvents money6 As Label
    Friend WithEvents SA_SP3 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents money5 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents systemtime10 As Label
    Friend WithEvents Button3 As Button
End Class
