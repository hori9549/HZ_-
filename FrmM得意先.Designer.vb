<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmM得意先
    'Inherits System.Windows.Forms.Form
    Inherits frmベース

    'フォームがコンポーネントの一覧をクリーンアップするために dispose をオーバーライドします。
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

    'Windows フォーム デザイナーで必要です。
    Private components As System.ComponentModel.IContainer

    'メモ: 以下のプロシージャは Windows フォーム デザイナーで必要です。
    'Windows フォーム デザイナーを使用して変更できます。  
    'コード エディターを使って変更しないでください。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.txt企業ID = New System.Windows.Forms.TextBox()
        Me.lbl客先ID = New System.Windows.Forms.Label()
        Me.Btn未収金額 = New System.Windows.Forms.Button()
        Me.txt担当者名 = New System.Windows.Forms.TextBox()
        Me.Txt支店名 = New System.Windows.Forms.TextBox()
        Me.txt企業名 = New System.Windows.Forms.TextBox()
        Me.lbl地域コード = New System.Windows.Forms.Label()
        Me.Lbl支所轄 = New System.Windows.Forms.Label()
        Me.lbl正式法人名 = New System.Windows.Forms.Label()
        Me.txt住所 = New System.Windows.Forms.TextBox()
        Me.txtFax = New System.Windows.Forms.TextBox()
        Me.LblFAX = New System.Windows.Forms.Label()
        Me.Txt郵便番号 = New System.Windows.Forms.TextBox()
        Me.lbl郵便番号 = New System.Windows.Forms.Label()
        Me.TxtTEL = New System.Windows.Forms.TextBox()
        Me.lblTEL = New System.Windows.Forms.Label()
        Me.Txtふりがな = New System.Windows.Forms.TextBox()
        Me.Lblふりがな = New System.Windows.Forms.Label()
        Me.btn売上経歴 = New System.Windows.Forms.Button()
        Me.btn年間作業予定検索 = New System.Windows.Forms.Button()
        Me.Btn納入機器検索 = New System.Windows.Forms.Button()
        Me.btn客先担当者検索 = New System.Windows.Forms.Button()
        Me.txt備考 = New System.Windows.Forms.TextBox()
        Me.lbl一般呼称 = New System.Windows.Forms.Label()
        Me.txt登録日 = New System.Windows.Forms.TextBox()
        Me.txtID = New System.Windows.Forms.TextBox()
        Me.lbl抹消月日 = New System.Windows.Forms.Label()
        Me.lbl基番 = New System.Windows.Forms.Label()
        Me.btn登録 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dgv一覧 = New System.Windows.Forms.DataGridView()
        Me.btn登録日追加 = New System.Windows.Forms.Button()
        Me.btnクリア = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btn取得 = New System.Windows.Forms.Button()
        Me.txt代表者名 = New System.Windows.Forms.TextBox()
        Me.txtメルアド = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtHPアド = New System.Windows.Forms.TextBox()
        Me.btn更新日追加 = New System.Windows.Forms.Button()
        Me.txt更新日 = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        CType(Me.dgv一覧, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txt企業ID
        '
        Me.txt企業ID.Location = New System.Drawing.Point(357, 18)
        Me.txt企業ID.Margin = New System.Windows.Forms.Padding(6)
        Me.txt企業ID.Name = "txt企業ID"
        Me.txt企業ID.ReadOnly = True
        Me.txt企業ID.Size = New System.Drawing.Size(94, 31)
        Me.txt企業ID.TabIndex = 3
        Me.txt企業ID.Text = "1070"
        '
        'lbl客先ID
        '
        Me.lbl客先ID.AutoSize = True
        Me.lbl客先ID.Location = New System.Drawing.Point(272, 23)
        Me.lbl客先ID.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.lbl客先ID.Name = "lbl客先ID"
        Me.lbl客先ID.Size = New System.Drawing.Size(80, 24)
        Me.lbl客先ID.TabIndex = 2
        Me.lbl客先ID.Text = "企業ID"
        '
        'Btn未収金額
        '
        Me.Btn未収金額.Location = New System.Drawing.Point(16, 854)
        Me.Btn未収金額.Margin = New System.Windows.Forms.Padding(6)
        Me.Btn未収金額.Name = "Btn未収金額"
        Me.Btn未収金額.Size = New System.Drawing.Size(243, 58)
        Me.Btn未収金額.TabIndex = 31
        Me.Btn未収金額.Text = "未収金額"
        Me.Btn未収金額.UseVisualStyleBackColor = True
        '
        'txt担当者名
        '
        Me.txt担当者名.Location = New System.Drawing.Point(839, 139)
        Me.txt担当者名.Margin = New System.Windows.Forms.Padding(6)
        Me.txt担当者名.Name = "txt担当者名"
        Me.txt担当者名.Size = New System.Drawing.Size(212, 31)
        Me.txt担当者名.TabIndex = 17
        '
        'Txt支店名
        '
        Me.Txt支店名.Location = New System.Drawing.Point(836, 101)
        Me.Txt支店名.Margin = New System.Windows.Forms.Padding(6)
        Me.Txt支店名.Name = "Txt支店名"
        Me.Txt支店名.Size = New System.Drawing.Size(395, 31)
        Me.Txt支店名.TabIndex = 11
        '
        'txt企業名
        '
        Me.txt企業名.ImeMode = System.Windows.Forms.ImeMode.[On]
        Me.txt企業名.Location = New System.Drawing.Point(159, 101)
        Me.txt企業名.Margin = New System.Windows.Forms.Padding(6)
        Me.txt企業名.MaxLength = 50
        Me.txt企業名.Name = "txt企業名"
        Me.txt企業名.Size = New System.Drawing.Size(537, 31)
        Me.txt企業名.TabIndex = 8
        '
        'lbl地域コード
        '
        Me.lbl地域コード.AutoSize = True
        Me.lbl地域コード.Location = New System.Drawing.Point(900, 222)
        Me.lbl地域コード.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.lbl地域コード.Name = "lbl地域コード"
        Me.lbl地域コード.Size = New System.Drawing.Size(0, 24)
        Me.lbl地域コード.TabIndex = 20
        '
        'Lbl支所轄
        '
        Me.Lbl支所轄.AutoSize = True
        Me.Lbl支所轄.Location = New System.Drawing.Point(738, 105)
        Me.Lbl支所轄.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Lbl支所轄.Name = "Lbl支所轄"
        Me.Lbl支所轄.Size = New System.Drawing.Size(0, 24)
        Me.Lbl支所轄.TabIndex = 10
        '
        'lbl正式法人名
        '
        Me.lbl正式法人名.AutoSize = True
        Me.lbl正式法人名.Location = New System.Drawing.Point(94, 228)
        Me.lbl正式法人名.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.lbl正式法人名.Name = "lbl正式法人名"
        Me.lbl正式法人名.Size = New System.Drawing.Size(58, 24)
        Me.lbl正式法人名.TabIndex = 14
        Me.lbl正式法人名.Text = "住所"
        '
        'txt住所
        '
        Me.txt住所.Location = New System.Drawing.Point(159, 228)
        Me.txt住所.Margin = New System.Windows.Forms.Padding(6)
        Me.txt住所.MaxLength = 50
        Me.txt住所.Name = "txt住所"
        Me.txt住所.Size = New System.Drawing.Size(714, 31)
        Me.txt住所.TabIndex = 15
        '
        'txtFax
        '
        Me.txtFax.ImeMode = System.Windows.Forms.ImeMode.Disable
        Me.txtFax.Location = New System.Drawing.Point(480, 271)
        Me.txtFax.Margin = New System.Windows.Forms.Padding(6)
        Me.txtFax.MaxLength = 10
        Me.txtFax.Name = "txtFax"
        Me.txtFax.Size = New System.Drawing.Size(199, 31)
        Me.txtFax.TabIndex = 15
        '
        'LblFAX
        '
        Me.LblFAX.AutoSize = True
        Me.LblFAX.Location = New System.Drawing.Point(432, 292)
        Me.LblFAX.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.LblFAX.Name = "LblFAX"
        Me.LblFAX.Size = New System.Drawing.Size(0, 24)
        Me.LblFAX.TabIndex = 14
        '
        'Txt郵便番号
        '
        Me.Txt郵便番号.Location = New System.Drawing.Point(160, 187)
        Me.Txt郵便番号.Margin = New System.Windows.Forms.Padding(6)
        Me.Txt郵便番号.MaxLength = 10
        Me.Txt郵便番号.Name = "Txt郵便番号"
        Me.Txt郵便番号.Size = New System.Drawing.Size(199, 31)
        Me.Txt郵便番号.TabIndex = 13
        Me.Txt郵便番号.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lbl郵便番号
        '
        Me.lbl郵便番号.AutoSize = True
        Me.lbl郵便番号.Location = New System.Drawing.Point(42, 187)
        Me.lbl郵便番号.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.lbl郵便番号.Name = "lbl郵便番号"
        Me.lbl郵便番号.Size = New System.Drawing.Size(106, 24)
        Me.lbl郵便番号.TabIndex = 12
        Me.lbl郵便番号.Text = "郵便番号"
        '
        'TxtTEL
        '
        Me.TxtTEL.ImeMode = System.Windows.Forms.ImeMode.Disable
        Me.TxtTEL.Location = New System.Drawing.Point(160, 271)
        Me.TxtTEL.Margin = New System.Windows.Forms.Padding(6)
        Me.TxtTEL.MaxLength = 10
        Me.TxtTEL.Name = "TxtTEL"
        Me.TxtTEL.Size = New System.Drawing.Size(199, 31)
        Me.TxtTEL.TabIndex = 13
        '
        'lblTEL
        '
        Me.lblTEL.AutoSize = True
        Me.lblTEL.Location = New System.Drawing.Point(99, 271)
        Me.lblTEL.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.lblTEL.Name = "lblTEL"
        Me.lblTEL.Size = New System.Drawing.Size(51, 24)
        Me.lblTEL.TabIndex = 12
        Me.lblTEL.Text = "TEL"
        '
        'Txtふりがな
        '
        Me.Txtふりがな.Location = New System.Drawing.Point(159, 63)
        Me.Txtふりがな.Margin = New System.Windows.Forms.Padding(6)
        Me.Txtふりがな.MaxLength = 50
        Me.Txtふりがな.Name = "Txtふりがな"
        Me.Txtふりがな.Size = New System.Drawing.Size(537, 31)
        Me.Txtふりがな.TabIndex = 5
        '
        'Lblふりがな
        '
        Me.Lblふりがな.AutoSize = True
        Me.Lblふりがな.Location = New System.Drawing.Point(65, 68)
        Me.Lblふりがな.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Lblふりがな.Name = "Lblふりがな"
        Me.Lblふりがな.Size = New System.Drawing.Size(86, 24)
        Me.Lblふりがな.TabIndex = 4
        Me.Lblふりがな.Text = "ふりがな"
        '
        'btn売上経歴
        '
        Me.btn売上経歴.Location = New System.Drawing.Point(989, 854)
        Me.btn売上経歴.Margin = New System.Windows.Forms.Padding(6)
        Me.btn売上経歴.Name = "btn売上経歴"
        Me.btn売上経歴.Size = New System.Drawing.Size(243, 58)
        Me.btn売上経歴.TabIndex = 35
        Me.btn売上経歴.Text = "売上経歴"
        Me.btn売上経歴.UseVisualStyleBackColor = True
        '
        'btn年間作業予定検索
        '
        Me.btn年間作業予定検索.Location = New System.Drawing.Point(786, 854)
        Me.btn年間作業予定検索.Margin = New System.Windows.Forms.Padding(6)
        Me.btn年間作業予定検索.Name = "btn年間作業予定検索"
        Me.btn年間作業予定検索.Size = New System.Drawing.Size(231, 58)
        Me.btn年間作業予定検索.TabIndex = 34
        Me.btn年間作業予定検索.Text = "年間作業予定検索"
        Me.btn年間作業予定検索.UseVisualStyleBackColor = True
        '
        'Btn納入機器検索
        '
        Me.Btn納入機器検索.Location = New System.Drawing.Point(530, 854)
        Me.Btn納入機器検索.Margin = New System.Windows.Forms.Padding(6)
        Me.Btn納入機器検索.Name = "Btn納入機器検索"
        Me.Btn納入機器検索.Size = New System.Drawing.Size(243, 58)
        Me.Btn納入機器検索.TabIndex = 33
        Me.Btn納入機器検索.Text = "納入機器検索"
        Me.Btn納入機器検索.UseVisualStyleBackColor = True
        '
        'btn客先担当者検索
        '
        Me.btn客先担当者検索.Location = New System.Drawing.Point(274, 854)
        Me.btn客先担当者検索.Margin = New System.Windows.Forms.Padding(6)
        Me.btn客先担当者検索.Name = "btn客先担当者検索"
        Me.btn客先担当者検索.Size = New System.Drawing.Size(243, 58)
        Me.btn客先担当者検索.TabIndex = 32
        Me.btn客先担当者検索.Text = "客先担当者検索"
        Me.btn客先担当者検索.UseVisualStyleBackColor = True
        '
        'txt備考
        '
        Me.txt備考.Location = New System.Drawing.Point(147, 378)
        Me.txt備考.Margin = New System.Windows.Forms.Padding(6)
        Me.txt備考.Multiline = True
        Me.txt備考.Name = "txt備考"
        Me.txt備考.Size = New System.Drawing.Size(1023, 83)
        Me.txt備考.TabIndex = 21
        '
        'lbl一般呼称
        '
        Me.lbl一般呼称.AutoSize = True
        Me.lbl一般呼称.Location = New System.Drawing.Point(65, 105)
        Me.lbl一般呼称.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.lbl一般呼称.Name = "lbl一般呼称"
        Me.lbl一般呼称.Size = New System.Drawing.Size(82, 24)
        Me.lbl一般呼称.TabIndex = 6
        Me.lbl一般呼称.Text = "企業名"
        '
        'txt登録日
        '
        Me.txt登録日.ImeMode = System.Windows.Forms.ImeMode.Disable
        Me.txt登録日.Location = New System.Drawing.Point(836, 18)
        Me.txt登録日.Margin = New System.Windows.Forms.Padding(6)
        Me.txt登録日.Name = "txt登録日"
        Me.txt登録日.ReadOnly = True
        Me.txt登録日.Size = New System.Drawing.Size(142, 31)
        Me.txt登録日.TabIndex = 26
        Me.txt登録日.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtID
        '
        Me.txtID.Location = New System.Drawing.Point(159, 18)
        Me.txtID.Margin = New System.Windows.Forms.Padding(6)
        Me.txtID.Name = "txtID"
        Me.txtID.ReadOnly = True
        Me.txtID.Size = New System.Drawing.Size(94, 31)
        Me.txtID.TabIndex = 1
        Me.txtID.Text = "1070"
        '
        'lbl抹消月日
        '
        Me.lbl抹消月日.AutoSize = True
        Me.lbl抹消月日.Location = New System.Drawing.Point(723, 23)
        Me.lbl抹消月日.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.lbl抹消月日.Name = "lbl抹消月日"
        Me.lbl抹消月日.Size = New System.Drawing.Size(82, 24)
        Me.lbl抹消月日.TabIndex = 25
        Me.lbl抹消月日.Text = "登録日"
        '
        'lbl基番
        '
        Me.lbl基番.AutoSize = True
        Me.lbl基番.Location = New System.Drawing.Point(94, 23)
        Me.lbl基番.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.lbl基番.Name = "lbl基番"
        Me.lbl基番.Size = New System.Drawing.Size(32, 24)
        Me.lbl基番.TabIndex = 0
        Me.lbl基番.Text = "ID"
        '
        'btn登録
        '
        Me.btn登録.Location = New System.Drawing.Point(1326, 307)
        Me.btn登録.Margin = New System.Windows.Forms.Padding(4)
        Me.btn登録.Name = "btn登録"
        Me.btn登録.Size = New System.Drawing.Size(195, 63)
        Me.btn登録.TabIndex = 24
        Me.btn登録.Text = "登録"
        Me.btn登録.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(82, 378)
        Me.Label1.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(58, 24)
        Me.Label1.TabIndex = 20
        Me.Label1.Text = "備考"
        '
        'dgv一覧
        '
        Me.dgv一覧.AllowUserToAddRows = False
        Me.dgv一覧.AllowUserToDeleteRows = False
        Me.dgv一覧.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgv一覧.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv一覧.Location = New System.Drawing.Point(4, 487)
        Me.dgv一覧.Margin = New System.Windows.Forms.Padding(4)
        Me.dgv一覧.Name = "dgv一覧"
        Me.dgv一覧.ReadOnly = True
        Me.dgv一覧.RowHeadersVisible = False
        Me.dgv一覧.RowHeadersWidth = 51
        Me.dgv一覧.RowTemplate.Height = 30
        Me.dgv一覧.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv一覧.Size = New System.Drawing.Size(1505, 360)
        Me.dgv一覧.TabIndex = 27
        Me.dgv一覧.TabStop = False
        '
        'btn登録日追加
        '
        Me.btn登録日追加.Location = New System.Drawing.Point(979, 18)
        Me.btn登録日追加.Margin = New System.Windows.Forms.Padding(4)
        Me.btn登録日追加.Name = "btn登録日追加"
        Me.btn登録日追加.Size = New System.Drawing.Size(34, 34)
        Me.btn登録日追加.TabIndex = 29
        Me.btn登録日追加.TabStop = False
        Me.btn登録日追加.UseVisualStyleBackColor = True
        '
        'btnクリア
        '
        Me.btnクリア.Location = New System.Drawing.Point(452, 18)
        Me.btnクリア.Margin = New System.Windows.Forms.Padding(4)
        Me.btnクリア.Name = "btnクリア"
        Me.btnクリア.Size = New System.Drawing.Size(34, 34)
        Me.btnクリア.TabIndex = 102
        Me.btnクリア.TabStop = False
        Me.btnクリア.Text = "+"
        Me.btnクリア.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(422, 275)
        Me.Label2.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(52, 24)
        Me.Label2.TabIndex = 103
        Me.Label2.Text = "FAX"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(750, 105)
        Me.Label3.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(82, 24)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "支店名"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(720, 144)
        Me.Label4.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(106, 24)
        Me.Label4.TabIndex = 16
        Me.Label4.Text = "担当者名"
        '
        'btn取得
        '
        Me.btn取得.Location = New System.Drawing.Point(369, 187)
        Me.btn取得.Margin = New System.Windows.Forms.Padding(4)
        Me.btn取得.Name = "btn取得"
        Me.btn取得.Size = New System.Drawing.Size(34, 34)
        Me.btn取得.TabIndex = 104
        Me.btn取得.Text = "+"
        Me.btn取得.UseVisualStyleBackColor = True
        '
        'txt代表者名
        '
        Me.txt代表者名.ImeMode = System.Windows.Forms.ImeMode.[On]
        Me.txt代表者名.Location = New System.Drawing.Point(159, 144)
        Me.txt代表者名.Margin = New System.Windows.Forms.Padding(6)
        Me.txt代表者名.MaxLength = 50
        Me.txt代表者名.Name = "txt代表者名"
        Me.txt代表者名.Size = New System.Drawing.Size(350, 31)
        Me.txt代表者名.TabIndex = 105
        '
        'txtメルアド
        '
        Me.txtメルアド.ImeMode = System.Windows.Forms.ImeMode.Disable
        Me.txtメルアド.Location = New System.Drawing.Point(159, 314)
        Me.txtメルアド.Margin = New System.Windows.Forms.Padding(6)
        Me.txtメルアド.MaxLength = 50
        Me.txtメルアド.Name = "txtメルアド"
        Me.txtメルアド.Size = New System.Drawing.Size(350, 31)
        Me.txtメルアド.TabIndex = 106
        Me.txtメルアド.Text = "" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.txtメルアド.Visible = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(41, 147)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(106, 24)
        Me.Label5.TabIndex = 107
        Me.Label5.Text = "代表者名"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(12, 315)
        Me.Label7.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(138, 24)
        Me.Label7.TabIndex = 109
        Me.Label7.Text = "メールアドレス"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(576, 317)
        Me.Label6.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(111, 24)
        Me.Label6.TabIndex = 111
        Me.Label6.Text = "HPアドレス"
        '
        'txtHPアド
        '
        Me.txtHPアド.ImeMode = System.Windows.Forms.ImeMode.Disable
        Me.txtHPアド.Location = New System.Drawing.Point(723, 316)
        Me.txtHPアド.Margin = New System.Windows.Forms.Padding(6)
        Me.txtHPアド.MaxLength = 50
        Me.txtHPアド.Name = "txtHPアド"
        Me.txtHPアド.Size = New System.Drawing.Size(350, 31)
        Me.txtHPアド.TabIndex = 110
        Me.txtHPアド.Text = "" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.txtHPアド.Visible = False
        '
        'btn更新日追加
        '
        Me.btn更新日追加.Location = New System.Drawing.Point(979, 58)
        Me.btn更新日追加.Margin = New System.Windows.Forms.Padding(4)
        Me.btn更新日追加.Name = "btn更新日追加"
        Me.btn更新日追加.Size = New System.Drawing.Size(34, 34)
        Me.btn更新日追加.TabIndex = 114
        Me.btn更新日追加.TabStop = False
        Me.btn更新日追加.UseVisualStyleBackColor = True
        '
        'txt更新日
        '
        Me.txt更新日.ImeMode = System.Windows.Forms.ImeMode.Disable
        Me.txt更新日.Location = New System.Drawing.Point(836, 58)
        Me.txt更新日.Margin = New System.Windows.Forms.Padding(6)
        Me.txt更新日.Name = "txt更新日"
        Me.txt更新日.ReadOnly = True
        Me.txt更新日.Size = New System.Drawing.Size(142, 31)
        Me.txt更新日.TabIndex = 113
        Me.txt更新日.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(723, 63)
        Me.Label8.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(82, 24)
        Me.Label8.TabIndex = 112
        Me.Label8.Text = "更新日"
        '
        'FrmM得意先
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(13.0!, 24.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1539, 961)
        Me.Controls.Add(Me.btn更新日追加)
        Me.Controls.Add(Me.txt更新日)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtHPアド)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtメルアド)
        Me.Controls.Add(Me.txt代表者名)
        Me.Controls.Add(Me.btn取得)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnクリア)
        Me.Controls.Add(Me.btn登録日追加)
        Me.Controls.Add(Me.dgv一覧)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btn登録)
        Me.Controls.Add(Me.txt企業ID)
        Me.Controls.Add(Me.lbl客先ID)
        Me.Controls.Add(Me.Btn未収金額)
        Me.Controls.Add(Me.txt担当者名)
        Me.Controls.Add(Me.Txt支店名)
        Me.Controls.Add(Me.txt企業名)
        Me.Controls.Add(Me.lbl地域コード)
        Me.Controls.Add(Me.Lbl支所轄)
        Me.Controls.Add(Me.lbl正式法人名)
        Me.Controls.Add(Me.txt住所)
        Me.Controls.Add(Me.txtFax)
        Me.Controls.Add(Me.LblFAX)
        Me.Controls.Add(Me.Txt郵便番号)
        Me.Controls.Add(Me.lbl郵便番号)
        Me.Controls.Add(Me.TxtTEL)
        Me.Controls.Add(Me.lblTEL)
        Me.Controls.Add(Me.Txtふりがな)
        Me.Controls.Add(Me.Lblふりがな)
        Me.Controls.Add(Me.btn売上経歴)
        Me.Controls.Add(Me.btn年間作業予定検索)
        Me.Controls.Add(Me.Btn納入機器検索)
        Me.Controls.Add(Me.btn客先担当者検索)
        Me.Controls.Add(Me.txt備考)
        Me.Controls.Add(Me.lbl一般呼称)
        Me.Controls.Add(Me.txt登録日)
        Me.Controls.Add(Me.txtID)
        Me.Controls.Add(Me.lbl抹消月日)
        Me.Controls.Add(Me.lbl基番)
        Me.Margin = New System.Windows.Forms.Padding(10)
        Me.Name = "FrmM得意先"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "得意先マスタ"
        Me.Controls.SetChildIndex(Me.lbl基番, 0)
        Me.Controls.SetChildIndex(Me.lbl抹消月日, 0)
        Me.Controls.SetChildIndex(Me.txtID, 0)
        Me.Controls.SetChildIndex(Me.txt登録日, 0)
        Me.Controls.SetChildIndex(Me.lbl一般呼称, 0)
        Me.Controls.SetChildIndex(Me.txt備考, 0)
        Me.Controls.SetChildIndex(Me.btn客先担当者検索, 0)
        Me.Controls.SetChildIndex(Me.Btn納入機器検索, 0)
        Me.Controls.SetChildIndex(Me.btn年間作業予定検索, 0)
        Me.Controls.SetChildIndex(Me.btn売上経歴, 0)
        Me.Controls.SetChildIndex(Me.Lblふりがな, 0)
        Me.Controls.SetChildIndex(Me.Txtふりがな, 0)
        Me.Controls.SetChildIndex(Me.lblTEL, 0)
        Me.Controls.SetChildIndex(Me.TxtTEL, 0)
        Me.Controls.SetChildIndex(Me.lbl郵便番号, 0)
        Me.Controls.SetChildIndex(Me.Txt郵便番号, 0)
        Me.Controls.SetChildIndex(Me.LblFAX, 0)
        Me.Controls.SetChildIndex(Me.txtFax, 0)
        Me.Controls.SetChildIndex(Me.txt住所, 0)
        Me.Controls.SetChildIndex(Me.lbl正式法人名, 0)
        Me.Controls.SetChildIndex(Me.Lbl支所轄, 0)
        Me.Controls.SetChildIndex(Me.lbl地域コード, 0)
        Me.Controls.SetChildIndex(Me.txt企業名, 0)
        Me.Controls.SetChildIndex(Me.Txt支店名, 0)
        Me.Controls.SetChildIndex(Me.txt担当者名, 0)
        Me.Controls.SetChildIndex(Me.Btn未収金額, 0)
        Me.Controls.SetChildIndex(Me.lbl客先ID, 0)
        Me.Controls.SetChildIndex(Me.txt企業ID, 0)
        Me.Controls.SetChildIndex(Me.btn登録, 0)
        Me.Controls.SetChildIndex(Me.Label1, 0)
        Me.Controls.SetChildIndex(Me.dgv一覧, 0)
        Me.Controls.SetChildIndex(Me.btn登録日追加, 0)
        Me.Controls.SetChildIndex(Me.btnクリア, 0)
        Me.Controls.SetChildIndex(Me.Label2, 0)
        Me.Controls.SetChildIndex(Me.Label3, 0)
        Me.Controls.SetChildIndex(Me.Label4, 0)
        Me.Controls.SetChildIndex(Me.btn取得, 0)
        Me.Controls.SetChildIndex(Me.txt代表者名, 0)
        Me.Controls.SetChildIndex(Me.txtメルアド, 0)
        Me.Controls.SetChildIndex(Me.Label5, 0)
        Me.Controls.SetChildIndex(Me.Label7, 0)
        Me.Controls.SetChildIndex(Me.txtHPアド, 0)
        Me.Controls.SetChildIndex(Me.Label6, 0)
        Me.Controls.SetChildIndex(Me.Label8, 0)
        Me.Controls.SetChildIndex(Me.txt更新日, 0)
        Me.Controls.SetChildIndex(Me.btn更新日追加, 0)
        CType(Me.dgv一覧, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txt企業ID As TextBox
    Friend WithEvents lbl客先ID As Label
    Friend WithEvents Btn未収金額 As Button
    Friend WithEvents txt担当者名 As TextBox
    Friend WithEvents Txt支店名 As TextBox
    Friend WithEvents txt企業名 As TextBox
    Friend WithEvents lbl地域コード As Label
    Friend WithEvents Lbl支所轄 As Label
    Friend WithEvents lbl正式法人名 As Label
    Friend WithEvents txt住所 As TextBox
    Friend WithEvents txtFax As TextBox
    Friend WithEvents LblFAX As Label
    Friend WithEvents Txt郵便番号 As TextBox
    Friend WithEvents lbl郵便番号 As Label
    Friend WithEvents TxtTEL As TextBox
    Friend WithEvents lblTEL As Label
    Friend WithEvents Txtふりがな As TextBox
    Friend WithEvents Lblふりがな As Label
    Friend WithEvents btn売上経歴 As Button
    Friend WithEvents btn年間作業予定検索 As Button
    Friend WithEvents Btn納入機器検索 As Button
    Friend WithEvents btn客先担当者検索 As Button
    Friend WithEvents txt備考 As TextBox
    Friend WithEvents lbl一般呼称 As Label
    Friend WithEvents txt登録日 As TextBox
    Friend WithEvents txtID As TextBox
    Friend WithEvents lbl抹消月日 As Label
    Friend WithEvents lbl基番 As Label
    Friend WithEvents btn登録 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents dgv一覧 As DataGridView
    Friend WithEvents btn登録日追加 As Button
    Friend WithEvents btnクリア As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents btn取得 As Button
    Friend WithEvents txt代表者名 As TextBox
    Friend WithEvents txtメルアド As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents txtHPアド As TextBox
    Friend WithEvents btn更新日追加 As Button
    Friend WithEvents txt更新日 As TextBox
    Friend WithEvents Label8 As Label
End Class
