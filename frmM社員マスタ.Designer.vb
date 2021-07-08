<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmM社員マスタ
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txt社員ID = New System.Windows.Forms.TextBox()
        Me.txt氏名 = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txt技能ランク = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtふりがな = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txt職種コード = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txt権限コード = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txt入社月日 = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txt所属部 = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txt所属課 = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txt役職 = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.txt退社月日 = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.txt郵便番号 = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.txt電話番号 = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.txt住所 = New System.Windows.Forms.TextBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.txt略歴 = New System.Windows.Forms.TextBox()
        Me.btn登録 = New System.Windows.Forms.Button()
        Me.dgv一覧 = New System.Windows.Forms.DataGridView()
        Me.colID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col社員ID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col氏名 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colふりがな = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col技能ランク = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col入社月日 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col職種コード = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col権限コード = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col所属部 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col所属課 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col役職 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col退社 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col退社月日 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col電話番号 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col郵便番号 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col住所 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col都道府県 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col市区郡 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col町村域 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col建物 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col略歴 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btn入社月日 = New System.Windows.Forms.Button()
        Me.btn退社月日 = New System.Windows.Forms.Button()
        Me.btnクリア = New System.Windows.Forms.Button()
        Me.btn取得 = New System.Windows.Forms.Button()
        CType(Me.dgv一覧, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(69, 23)
        Me.Label2.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(80, 24)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "社員ID"
        '
        'txt社員ID
        '
        Me.txt社員ID.Location = New System.Drawing.Point(157, 18)
        Me.txt社員ID.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.txt社員ID.Name = "txt社員ID"
        Me.txt社員ID.ReadOnly = True
        Me.txt社員ID.Size = New System.Drawing.Size(170, 31)
        Me.txt社員ID.TabIndex = 1
        '
        'txt氏名
        '
        Me.txt氏名.ImeMode = System.Windows.Forms.ImeMode.[On]
        Me.txt氏名.Location = New System.Drawing.Point(157, 97)
        Me.txt氏名.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.txt氏名.Name = "txt氏名"
        Me.txt氏名.Size = New System.Drawing.Size(205, 31)
        Me.txt氏名.TabIndex = 8
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(398, 104)
        Me.Label3.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(0, 24)
        Me.Label3.TabIndex = 4
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(398, 104)
        Me.Label4.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(0, 24)
        Me.Label4.TabIndex = 6
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(91, 102)
        Me.Label5.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(58, 24)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "氏名"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(39, 226)
        Me.Label6.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(110, 24)
        Me.Label6.TabIndex = 26
        Me.Label6.Text = "技能ランク"
        '
        'txt技能ランク
        '
        Me.txt技能ランク.Location = New System.Drawing.Point(157, 221)
        Me.txt技能ランク.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.txt技能ランク.Name = "txt技能ランク"
        Me.txt技能ランク.Size = New System.Drawing.Size(202, 31)
        Me.txt技能ランク.TabIndex = 27
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(62, 68)
        Me.Label7.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(86, 24)
        Me.Label7.TabIndex = 5
        Me.Label7.Text = "ふりがな"
        '
        'txtふりがな
        '
        Me.txtふりがな.Location = New System.Drawing.Point(157, 63)
        Me.txtふりがな.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.txtふりがな.Name = "txtふりがな"
        Me.txtふりがな.Size = New System.Drawing.Size(205, 31)
        Me.txtふりがな.TabIndex = 6
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(398, 227)
        Me.Label8.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(112, 24)
        Me.Label8.TabIndex = 28
        Me.Label8.Text = "職種コード"
        '
        'txt職種コード
        '
        Me.txt職種コード.Location = New System.Drawing.Point(519, 222)
        Me.txt職種コード.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.txt職種コード.Name = "txt職種コード"
        Me.txt職種コード.Size = New System.Drawing.Size(202, 31)
        Me.txt職種コード.TabIndex = 29
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(398, 24)
        Me.Label9.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(112, 24)
        Me.Label9.TabIndex = 3
        Me.Label9.Text = "権限コード"
        '
        'txt権限コード
        '
        Me.txt権限コード.Location = New System.Drawing.Point(519, 19)
        Me.txt権限コード.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.txt権限コード.Name = "txt権限コード"
        Me.txt権限コード.Size = New System.Drawing.Size(127, 31)
        Me.txt権限コード.TabIndex = 4
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(42, 148)
        Me.Label10.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(106, 24)
        Me.Label10.TabIndex = 16
        Me.Label10.Text = "入社月日"
        '
        'txt入社月日
        '
        Me.txt入社月日.Location = New System.Drawing.Point(157, 143)
        Me.txt入社月日.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.txt入社月日.Name = "txt入社月日"
        Me.txt入社月日.Size = New System.Drawing.Size(170, 31)
        Me.txt入社月日.TabIndex = 17
        Me.txt入社月日.Text = "yyyy/MM/dd"
        Me.txt入社月日.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(66, 191)
        Me.Label11.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(82, 24)
        Me.Label11.TabIndex = 22
        Me.Label11.Text = "所属部"
        '
        'txt所属部
        '
        Me.txt所属部.Location = New System.Drawing.Point(157, 187)
        Me.txt所属部.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.txt所属部.Name = "txt所属部"
        Me.txt所属部.Size = New System.Drawing.Size(202, 31)
        Me.txt所属部.TabIndex = 23
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(429, 196)
        Me.Label12.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(82, 24)
        Me.Label12.TabIndex = 24
        Me.Label12.Text = "所属課"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'txt所属課
        '
        Me.txt所属課.Location = New System.Drawing.Point(519, 188)
        Me.txt所属課.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.txt所属課.Name = "txt所属課"
        Me.txt所属課.Size = New System.Drawing.Size(202, 31)
        Me.txt所属課.TabIndex = 25
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(771, 227)
        Me.Label13.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(58, 24)
        Me.Label13.TabIndex = 30
        Me.Label13.Text = "役職"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'txt役職
        '
        Me.txt役職.Location = New System.Drawing.Point(846, 222)
        Me.txt役職.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.txt役職.Name = "txt役職"
        Me.txt役職.Size = New System.Drawing.Size(202, 31)
        Me.txt役職.TabIndex = 31
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(404, 149)
        Me.Label14.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(106, 24)
        Me.Label14.TabIndex = 19
        Me.Label14.Text = "退社月日"
        '
        'txt退社月日
        '
        Me.txt退社月日.Location = New System.Drawing.Point(519, 144)
        Me.txt退社月日.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.txt退社月日.Name = "txt退社月日"
        Me.txt退社月日.Size = New System.Drawing.Size(170, 31)
        Me.txt退社月日.TabIndex = 20
        Me.txt退社月日.Text = "yyyy/MM/dd"
        Me.txt退社月日.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(404, 69)
        Me.Label15.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(106, 24)
        Me.Label15.TabIndex = 9
        Me.Label15.Text = "郵便番号"
        '
        'txt郵便番号
        '
        Me.txt郵便番号.ImeMode = System.Windows.Forms.ImeMode.Disable
        Me.txt郵便番号.Location = New System.Drawing.Point(519, 64)
        Me.txt郵便番号.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.txt郵便番号.Name = "txt郵便番号"
        Me.txt郵便番号.Size = New System.Drawing.Size(127, 31)
        Me.txt郵便番号.TabIndex = 10
        Me.txt郵便番号.Text = "4050075"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(404, 104)
        Me.Label16.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(106, 24)
        Me.Label16.TabIndex = 14
        Me.Label16.Text = "電話番号"
        '
        'txt電話番号
        '
        Me.txt電話番号.ImeMode = System.Windows.Forms.ImeMode.Off
        Me.txt電話番号.Location = New System.Drawing.Point(519, 99)
        Me.txt電話番号.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.txt電話番号.Name = "txt電話番号"
        Me.txt電話番号.Size = New System.Drawing.Size(202, 31)
        Me.txt電話番号.TabIndex = 15
        Me.txt電話番号.Text = "090-0000-0000"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(772, 68)
        Me.Label17.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(58, 24)
        Me.Label17.TabIndex = 12
        Me.Label17.Text = "住所"
        '
        'txt住所
        '
        Me.txt住所.Location = New System.Drawing.Point(846, 63)
        Me.txt住所.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.txt住所.Name = "txt住所"
        Me.txt住所.Size = New System.Drawing.Size(673, 31)
        Me.txt住所.TabIndex = 13
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(91, 270)
        Me.Label18.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(58, 24)
        Me.Label18.TabIndex = 32
        Me.Label18.Text = "略歴"
        '
        'txt略歴
        '
        Me.txt略歴.ImeMode = System.Windows.Forms.ImeMode.[On]
        Me.txt略歴.Location = New System.Drawing.Point(157, 267)
        Me.txt略歴.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.txt略歴.Multiline = True
        Me.txt略歴.Name = "txt略歴"
        Me.txt略歴.Size = New System.Drawing.Size(1115, 62)
        Me.txt略歴.TabIndex = 33
        '
        'btn登録
        '
        Me.btn登録.Location = New System.Drawing.Point(1326, 267)
        Me.btn登録.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btn登録.Name = "btn登録"
        Me.btn登録.Size = New System.Drawing.Size(195, 63)
        Me.btn登録.TabIndex = 34
        Me.btn登録.Text = "登録"
        Me.btn登録.UseVisualStyleBackColor = True
        '
        'dgv一覧
        '
        Me.dgv一覧.AllowUserToAddRows = False
        Me.dgv一覧.AllowUserToDeleteRows = False
        Me.dgv一覧.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgv一覧.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv一覧.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colID, Me.col社員ID, Me.col氏名, Me.colふりがな, Me.col技能ランク, Me.col入社月日, Me.col職種コード, Me.col権限コード, Me.col所属部, Me.col所属課, Me.col役職, Me.col退社, Me.col退社月日, Me.col電話番号, Me.col郵便番号, Me.col住所, Me.col都道府県, Me.col市区郡, Me.col町村域, Me.col建物, Me.col略歴})
        Me.dgv一覧.Location = New System.Drawing.Point(14, 337)
        Me.dgv一覧.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.dgv一覧.Name = "dgv一覧"
        Me.dgv一覧.ReadOnly = True
        Me.dgv一覧.RowHeadersVisible = False
        Me.dgv一覧.RowHeadersWidth = 51
        Me.dgv一覧.RowTemplate.Height = 30
        Me.dgv一覧.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv一覧.Size = New System.Drawing.Size(1505, 507)
        Me.dgv一覧.TabIndex = 35
        Me.dgv一覧.TabStop = False
        '
        'colID
        '
        Me.colID.DataPropertyName = "ID"
        Me.colID.Frozen = True
        Me.colID.HeaderText = "ID"
        Me.colID.MinimumWidth = 6
        Me.colID.Name = "colID"
        Me.colID.ReadOnly = True
        Me.colID.Visible = False
        Me.colID.Width = 60
        '
        'col社員ID
        '
        Me.col社員ID.DataPropertyName = "社員ID"
        Me.col社員ID.HeaderText = "社員ID"
        Me.col社員ID.MinimumWidth = 6
        Me.col社員ID.Name = "col社員ID"
        Me.col社員ID.ReadOnly = True
        Me.col社員ID.Width = 120
        '
        'col氏名
        '
        Me.col氏名.DataPropertyName = "氏名"
        Me.col氏名.HeaderText = "氏名"
        Me.col氏名.MinimumWidth = 6
        Me.col氏名.Name = "col氏名"
        Me.col氏名.ReadOnly = True
        Me.col氏名.Width = 120
        '
        'colふりがな
        '
        Me.colふりがな.DataPropertyName = "ふりがな"
        Me.colふりがな.HeaderText = "ふりがな"
        Me.colふりがな.MinimumWidth = 6
        Me.colふりがな.Name = "colふりがな"
        Me.colふりがな.ReadOnly = True
        Me.colふりがな.Width = 150
        '
        'col技能ランク
        '
        Me.col技能ランク.DataPropertyName = "技能ランク"
        Me.col技能ランク.HeaderText = "技能ランク"
        Me.col技能ランク.MinimumWidth = 6
        Me.col技能ランク.Name = "col技能ランク"
        Me.col技能ランク.ReadOnly = True
        Me.col技能ランク.Width = 120
        '
        'col入社月日
        '
        Me.col入社月日.DataPropertyName = "入社月日"
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.Format = "yyyy/MM/dd"
        Me.col入社月日.DefaultCellStyle = DataGridViewCellStyle1
        Me.col入社月日.HeaderText = "入社月日"
        Me.col入社月日.MinimumWidth = 6
        Me.col入社月日.Name = "col入社月日"
        Me.col入社月日.ReadOnly = True
        Me.col入社月日.Width = 120
        '
        'col職種コード
        '
        Me.col職種コード.DataPropertyName = "職種コード"
        Me.col職種コード.HeaderText = "職種コード"
        Me.col職種コード.MinimumWidth = 6
        Me.col職種コード.Name = "col職種コード"
        Me.col職種コード.ReadOnly = True
        Me.col職種コード.Width = 120
        '
        'col権限コード
        '
        Me.col権限コード.DataPropertyName = "権限コード"
        Me.col権限コード.HeaderText = "権限コード"
        Me.col権限コード.MinimumWidth = 6
        Me.col権限コード.Name = "col権限コード"
        Me.col権限コード.ReadOnly = True
        Me.col権限コード.Width = 120
        '
        'col所属部
        '
        Me.col所属部.DataPropertyName = "所属部"
        Me.col所属部.HeaderText = "所属部"
        Me.col所属部.MinimumWidth = 6
        Me.col所属部.Name = "col所属部"
        Me.col所属部.ReadOnly = True
        Me.col所属部.Width = 150
        '
        'col所属課
        '
        Me.col所属課.DataPropertyName = "所属課"
        Me.col所属課.HeaderText = "所属課"
        Me.col所属課.MinimumWidth = 6
        Me.col所属課.Name = "col所属課"
        Me.col所属課.ReadOnly = True
        Me.col所属課.Width = 150
        '
        'col役職
        '
        Me.col役職.DataPropertyName = "役職"
        Me.col役職.HeaderText = "役職"
        Me.col役職.MinimumWidth = 6
        Me.col役職.Name = "col役職"
        Me.col役職.ReadOnly = True
        Me.col役職.Width = 120
        '
        'col退社
        '
        Me.col退社.DataPropertyName = "退社"
        Me.col退社.HeaderText = "退社"
        Me.col退社.MinimumWidth = 6
        Me.col退社.Name = "col退社"
        Me.col退社.ReadOnly = True
        Me.col退社.Visible = False
        Me.col退社.Width = 120
        '
        'col退社月日
        '
        Me.col退社月日.DataPropertyName = "退社月日"
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.Format = "yyyy/MM/dd"
        Me.col退社月日.DefaultCellStyle = DataGridViewCellStyle2
        Me.col退社月日.HeaderText = "退社月日"
        Me.col退社月日.MinimumWidth = 6
        Me.col退社月日.Name = "col退社月日"
        Me.col退社月日.ReadOnly = True
        Me.col退社月日.Width = 120
        '
        'col電話番号
        '
        Me.col電話番号.DataPropertyName = "電話番号"
        Me.col電話番号.HeaderText = "電話番号"
        Me.col電話番号.MinimumWidth = 6
        Me.col電話番号.Name = "col電話番号"
        Me.col電話番号.ReadOnly = True
        Me.col電話番号.Width = 120
        '
        'col郵便番号
        '
        Me.col郵便番号.DataPropertyName = "郵便番号"
        Me.col郵便番号.HeaderText = "郵便番号"
        Me.col郵便番号.MinimumWidth = 6
        Me.col郵便番号.Name = "col郵便番号"
        Me.col郵便番号.ReadOnly = True
        Me.col郵便番号.Width = 120
        '
        'col住所
        '
        Me.col住所.DataPropertyName = "住所"
        Me.col住所.HeaderText = "住所"
        Me.col住所.MinimumWidth = 6
        Me.col住所.Name = "col住所"
        Me.col住所.ReadOnly = True
        Me.col住所.Width = 200
        '
        'col都道府県
        '
        Me.col都道府県.DataPropertyName = "都道府県"
        Me.col都道府県.HeaderText = "都道府県"
        Me.col都道府県.MinimumWidth = 6
        Me.col都道府県.Name = "col都道府県"
        Me.col都道府県.ReadOnly = True
        Me.col都道府県.Visible = False
        Me.col都道府県.Width = 120
        '
        'col市区郡
        '
        Me.col市区郡.DataPropertyName = "市区郡"
        Me.col市区郡.HeaderText = "市区郡"
        Me.col市区郡.MinimumWidth = 6
        Me.col市区郡.Name = "col市区郡"
        Me.col市区郡.ReadOnly = True
        Me.col市区郡.Visible = False
        Me.col市区郡.Width = 120
        '
        'col町村域
        '
        Me.col町村域.DataPropertyName = "町村域"
        Me.col町村域.HeaderText = "町村域"
        Me.col町村域.MinimumWidth = 6
        Me.col町村域.Name = "col町村域"
        Me.col町村域.ReadOnly = True
        Me.col町村域.Visible = False
        Me.col町村域.Width = 120
        '
        'col建物
        '
        Me.col建物.DataPropertyName = "建物"
        Me.col建物.HeaderText = "建物"
        Me.col建物.MinimumWidth = 6
        Me.col建物.Name = "col建物"
        Me.col建物.ReadOnly = True
        Me.col建物.Visible = False
        Me.col建物.Width = 120
        '
        'col略歴
        '
        Me.col略歴.DataPropertyName = "略歴"
        Me.col略歴.HeaderText = "略歴"
        Me.col略歴.MinimumWidth = 6
        Me.col略歴.Name = "col略歴"
        Me.col略歴.ReadOnly = True
        Me.col略歴.Width = 200
        '
        'btn入社月日
        '
        Me.btn入社月日.Location = New System.Drawing.Point(330, 143)
        Me.btn入社月日.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btn入社月日.Name = "btn入社月日"
        Me.btn入社月日.Size = New System.Drawing.Size(34, 34)
        Me.btn入社月日.TabIndex = 18
        Me.btn入社月日.TabStop = False
        Me.btn入社月日.UseVisualStyleBackColor = True
        '
        'btn退社月日
        '
        Me.btn退社月日.Location = New System.Drawing.Point(692, 144)
        Me.btn退社月日.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btn退社月日.Name = "btn退社月日"
        Me.btn退社月日.Size = New System.Drawing.Size(34, 34)
        Me.btn退社月日.TabIndex = 21
        Me.btn退社月日.TabStop = False
        Me.btn退社月日.UseVisualStyleBackColor = True
        '
        'btnクリア
        '
        Me.btnクリア.Location = New System.Drawing.Point(330, 18)
        Me.btnクリア.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnクリア.Name = "btnクリア"
        Me.btnクリア.Size = New System.Drawing.Size(34, 34)
        Me.btnクリア.TabIndex = 2
        Me.btnクリア.TabStop = False
        Me.btnクリア.Text = "+"
        Me.btnクリア.UseVisualStyleBackColor = True
        '
        'btn取得
        '
        Me.btn取得.Location = New System.Drawing.Point(655, 62)
        Me.btn取得.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btn取得.Name = "btn取得"
        Me.btn取得.Size = New System.Drawing.Size(34, 34)
        Me.btn取得.TabIndex = 11
        Me.btn取得.Text = "+"
        Me.btn取得.UseVisualStyleBackColor = True
        '
        'frmM社員マスタ
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(13.0!, 24.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1539, 961)
        Me.Controls.Add(Me.btn取得)
        Me.Controls.Add(Me.btnクリア)
        Me.Controls.Add(Me.btn退社月日)
        Me.Controls.Add(Me.btn入社月日)
        Me.Controls.Add(Me.dgv一覧)
        Me.Controls.Add(Me.btn登録)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.txt略歴)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.txt住所)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.txt電話番号)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.txt郵便番号)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.txt退社月日)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.txt役職)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.txt所属課)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.txt所属部)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.txt入社月日)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.txt権限コード)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txt職種コード)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtふりがな)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txt技能ランク)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txt氏名)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txt社員ID)
        Me.Controls.Add(Me.Label2)
        Me.Margin = New System.Windows.Forms.Padding(10, 10, 10, 10)
        Me.Name = "frmM社員マスタ"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "社員マスタ"
        Me.Controls.SetChildIndex(Me.Label2, 0)
        Me.Controls.SetChildIndex(Me.txt社員ID, 0)
        Me.Controls.SetChildIndex(Me.Label3, 0)
        Me.Controls.SetChildIndex(Me.txt氏名, 0)
        Me.Controls.SetChildIndex(Me.Label4, 0)
        Me.Controls.SetChildIndex(Me.Label5, 0)
        Me.Controls.SetChildIndex(Me.txt技能ランク, 0)
        Me.Controls.SetChildIndex(Me.Label6, 0)
        Me.Controls.SetChildIndex(Me.txtふりがな, 0)
        Me.Controls.SetChildIndex(Me.Label7, 0)
        Me.Controls.SetChildIndex(Me.txt職種コード, 0)
        Me.Controls.SetChildIndex(Me.Label8, 0)
        Me.Controls.SetChildIndex(Me.txt権限コード, 0)
        Me.Controls.SetChildIndex(Me.Label9, 0)
        Me.Controls.SetChildIndex(Me.txt入社月日, 0)
        Me.Controls.SetChildIndex(Me.Label10, 0)
        Me.Controls.SetChildIndex(Me.txt所属部, 0)
        Me.Controls.SetChildIndex(Me.Label11, 0)
        Me.Controls.SetChildIndex(Me.txt所属課, 0)
        Me.Controls.SetChildIndex(Me.Label12, 0)
        Me.Controls.SetChildIndex(Me.txt役職, 0)
        Me.Controls.SetChildIndex(Me.Label13, 0)
        Me.Controls.SetChildIndex(Me.txt退社月日, 0)
        Me.Controls.SetChildIndex(Me.Label14, 0)
        Me.Controls.SetChildIndex(Me.txt郵便番号, 0)
        Me.Controls.SetChildIndex(Me.Label15, 0)
        Me.Controls.SetChildIndex(Me.txt電話番号, 0)
        Me.Controls.SetChildIndex(Me.Label16, 0)
        Me.Controls.SetChildIndex(Me.txt住所, 0)
        Me.Controls.SetChildIndex(Me.Label17, 0)
        Me.Controls.SetChildIndex(Me.txt略歴, 0)
        Me.Controls.SetChildIndex(Me.Label18, 0)
        Me.Controls.SetChildIndex(Me.btn登録, 0)
        Me.Controls.SetChildIndex(Me.dgv一覧, 0)
        Me.Controls.SetChildIndex(Me.btn入社月日, 0)
        Me.Controls.SetChildIndex(Me.btn退社月日, 0)
        Me.Controls.SetChildIndex(Me.btnクリア, 0)
        Me.Controls.SetChildIndex(Me.btn取得, 0)
        CType(Me.dgv一覧, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label2 As Label
    Friend WithEvents txt社員ID As TextBox
    Friend WithEvents txt氏名 As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents txt技能ランク As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txtふりがな As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents txt職種コード As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents txt権限コード As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents txt入社月日 As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents txt所属部 As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents txt所属課 As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents txt役職 As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents txt退社月日 As TextBox
    Friend WithEvents Label15 As Label
    Friend WithEvents txt郵便番号 As TextBox
    Friend WithEvents Label16 As Label
    Friend WithEvents txt電話番号 As TextBox
    Friend WithEvents Label17 As Label
    Friend WithEvents txt住所 As TextBox
    Friend WithEvents Label18 As Label
    Friend WithEvents txt略歴 As TextBox
    Friend WithEvents btn登録 As Button
    Friend WithEvents dgv一覧 As DataGridView
    Friend WithEvents btn入社月日 As Button
    Friend WithEvents btn退社月日 As Button
    Friend WithEvents btnクリア As Button
    Friend WithEvents btn取得 As Button
    Friend WithEvents colID As DataGridViewTextBoxColumn
    Friend WithEvents col社員ID As DataGridViewTextBoxColumn
    Friend WithEvents col氏名 As DataGridViewTextBoxColumn
    Friend WithEvents colふりがな As DataGridViewTextBoxColumn
    Friend WithEvents col技能ランク As DataGridViewTextBoxColumn
    Friend WithEvents col入社月日 As DataGridViewTextBoxColumn
    Friend WithEvents col職種コード As DataGridViewTextBoxColumn
    Friend WithEvents col権限コード As DataGridViewTextBoxColumn
    Friend WithEvents col所属部 As DataGridViewTextBoxColumn
    Friend WithEvents col所属課 As DataGridViewTextBoxColumn
    Friend WithEvents col役職 As DataGridViewTextBoxColumn
    Friend WithEvents col退社 As DataGridViewTextBoxColumn
    Friend WithEvents col退社月日 As DataGridViewTextBoxColumn
    Friend WithEvents col電話番号 As DataGridViewTextBoxColumn
    Friend WithEvents col郵便番号 As DataGridViewTextBoxColumn
    Friend WithEvents col住所 As DataGridViewTextBoxColumn
    Friend WithEvents col都道府県 As DataGridViewTextBoxColumn
    Friend WithEvents col市区郡 As DataGridViewTextBoxColumn
    Friend WithEvents col町村域 As DataGridViewTextBoxColumn
    Friend WithEvents col建物 As DataGridViewTextBoxColumn
    Friend WithEvents col略歴 As DataGridViewTextBoxColumn
End Class
