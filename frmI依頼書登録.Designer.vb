<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmI依頼書登録
    'Inherits System.Windows.Forms.Form
    Inherits frmベース

    'フォームがコンポーネントの一覧をクリーンアップするために dispose をオーバーライドします。
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

    'Windows フォーム デザイナーで必要です。
    Private components As System.ComponentModel.IContainer

    'メモ: 以下のプロシージャは Windows フォーム デザイナーで必要です。
    'Windows フォーム デザイナーを使用して変更できます。  
    'コード エディターを使って変更しないでください。
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.chk未写真 = New System.Windows.Forms.CheckBox()
        Me.chk未点検表 = New System.Windows.Forms.CheckBox()
        Me.chk様子確認 = New System.Windows.Forms.CheckBox()
        Me.chk未データ = New System.Windows.Forms.CheckBox()
        Me.chk点検表 = New System.Windows.Forms.CheckBox()
        Me.chkデータ = New System.Windows.Forms.CheckBox()
        Me.lblデータ = New System.Windows.Forms.Label()
        Me.lblその他 = New System.Windows.Forms.Label()
        Me.txtその他 = New System.Windows.Forms.TextBox()
        Me.txt依頼元ID = New System.Windows.Forms.TextBox()
        Me.txt依頼元担当者 = New System.Windows.Forms.TextBox()
        Me.txt一般呼称 = New System.Windows.Forms.TextBox()
        Me.Txt依頼元 = New System.Windows.Forms.TextBox()
        Me.lbl作業名称 = New System.Windows.Forms.Label()
        Me.txt作業名称 = New System.Windows.Forms.TextBox()
        Me.txt訪問先担当者 = New System.Windows.Forms.TextBox()
        Me.cmb作業者 = New System.Windows.Forms.ComboBox()
        Me.chk見積作成 = New System.Windows.Forms.CheckBox()
        Me.cmb担当者 = New System.Windows.Forms.ComboBox()
        Me.lbl担当者 = New System.Windows.Forms.Label()
        Me.cmb受付者 = New System.Windows.Forms.ComboBox()
        Me.lbl受付者 = New System.Windows.Forms.Label()
        Me.cmb依頼コード = New System.Windows.Forms.ComboBox()
        Me.lb依頼コード = New System.Windows.Forms.Label()
        Me.txt機械コード = New System.Windows.Forms.TextBox()
        Me.lbl機械コード = New System.Windows.Forms.Label()
        Me.txt作業者 = New System.Windows.Forms.Label()
        Me.grp未処理案件 = New System.Windows.Forms.GroupBox()
        Me.chk写真 = New System.Windows.Forms.CheckBox()
        Me.btn印刷 = New System.Windows.Forms.Button()
        Me.grp添付書類 = New System.Windows.Forms.GroupBox()
        Me.grp無償処理 = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtクレーム = New System.Windows.Forms.TextBox()
        Me.lblクレーム処理 = New System.Windows.Forms.Label()
        Me.cmb営業処理 = New System.Windows.Forms.ComboBox()
        Me.lbl営業処理 = New System.Windows.Forms.Label()
        Me.grp費用処理 = New System.Windows.Forms.GroupBox()
        Me.chk無償 = New System.Windows.Forms.CheckBox()
        Me.lbl年間契約 = New System.Windows.Forms.Label()
        Me.chk有償見 = New System.Windows.Forms.CheckBox()
        Me.lbl有償見 = New System.Windows.Forms.Label()
        Me.chk年間契約 = New System.Windows.Forms.CheckBox()
        Me.lbl有償出 = New System.Windows.Forms.Label()
        Me.chk有償出 = New System.Windows.Forms.CheckBox()
        Me.txt請求金額 = New System.Windows.Forms.TextBox()
        Me.lbl請求金額 = New System.Windows.Forms.Label()
        Me.txt完了日 = New System.Windows.Forms.TextBox()
        Me.txt竣工予定日 = New System.Windows.Forms.TextBox()
        Me.lbl竣工予定日日 = New System.Windows.Forms.Label()
        Me.txt予定時間 = New System.Windows.Forms.TextBox()
        Me.lbl予定時間 = New System.Windows.Forms.Label()
        Me.txt予定日 = New System.Windows.Forms.TextBox()
        Me.lbl予定日 = New System.Windows.Forms.Label()
        Me.lbl契約内容 = New System.Windows.Forms.Label()
        Me.cmb契約番号 = New System.Windows.Forms.ComboBox()
        Me.lbl契約番号 = New System.Windows.Forms.Label()
        Me.chk契約物件 = New System.Windows.Forms.CheckBox()
        Me.txt契約内容 = New System.Windows.Forms.TextBox()
        Me.txt受付日 = New System.Windows.Forms.TextBox()
        Me.txt依頼書番号 = New System.Windows.Forms.TextBox()
        Me.txt受付番号 = New System.Windows.Forms.TextBox()
        Me.lbl契約物件 = New System.Windows.Forms.Label()
        Me.lbl受付日 = New System.Windows.Forms.Label()
        Me.lbl依頼者番号 = New System.Windows.Forms.Label()
        Me.lbl受付番号 = New System.Windows.Forms.Label()
        Me.txt客先ID = New System.Windows.Forms.TextBox()
        Me.lbl訪問先担当者 = New System.Windows.Forms.Label()
        Me.ibl客先ID = New System.Windows.Forms.Label()
        Me.lbl依頼元ID = New System.Windows.Forms.Label()
        Me.lbl請求先担当者 = New System.Windows.Forms.Label()
        Me.lbl請求先 = New System.Windows.Forms.Label()
        Me.txt請求先ID = New System.Windows.Forms.TextBox()
        Me.txt請求先担当者 = New System.Windows.Forms.TextBox()
        Me.txt請求先 = New System.Windows.Forms.TextBox()
        Me.lbl依頼内容 = New System.Windows.Forms.Label()
        Me.txt依頼内容 = New System.Windows.Forms.TextBox()
        Me.lbl入金確認 = New System.Windows.Forms.Label()
        Me.lbl完了日 = New System.Windows.Forms.Label()
        Me.btn受付日 = New System.Windows.Forms.Button()
        Me.btn予定日 = New System.Windows.Forms.Button()
        Me.btn竣工予定日 = New System.Windows.Forms.Button()
        Me.btn完了日 = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.chk入金確認 = New System.Windows.Forms.CheckBox()
        Me.dgv一覧 = New System.Windows.Forms.DataGridView()
        Me.col受付番号 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col依頼書番号 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col請伝番号 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col受付日 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col受付者 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col担当者 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col作業者 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col客先ID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col一般呼称 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col訪問先担当者 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col完了 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col請求金額 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col請求完了日 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col竣工予定日 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col依頼内容 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col予定日 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col予定時間 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col契約物件 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col契約番号 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col契約内容 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col依頼元ID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col依頼元 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col依頼元担当者 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col請求先ID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col請求先 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col請求先担当者 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col機械コード = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colその他 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col写真 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col点検表 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colデータ = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col見積作成 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col様子確認 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col未写真 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col未点検表 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col未データ = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col有償出 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col有償見 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col無償 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col年間契約 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col入金確認 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col営業処理 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colクレーム = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btn登録 = New System.Windows.Forms.Button()
        Me.grp未処理案件.SuspendLayout()
        Me.grp添付書類.SuspendLayout()
        Me.grp無償処理.SuspendLayout()
        Me.grp費用処理.SuspendLayout()
        CType(Me.dgv一覧, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'chk未写真
        '
        Me.chk未写真.AutoSize = True
        Me.chk未写真.Location = New System.Drawing.Point(375, 29)
        Me.chk未写真.Margin = New System.Windows.Forms.Padding(8)
        Me.chk未写真.Name = "chk未写真"
        Me.chk未写真.Size = New System.Drawing.Size(66, 23)
        Me.chk未写真.TabIndex = 54
        Me.chk未写真.Text = "写真"
        Me.chk未写真.UseVisualStyleBackColor = True
        '
        'chk未点検表
        '
        Me.chk未点検表.AutoSize = True
        Me.chk未点検表.Location = New System.Drawing.Point(483, 29)
        Me.chk未点検表.Margin = New System.Windows.Forms.Padding(8)
        Me.chk未点検表.Name = "chk未点検表"
        Me.chk未点検表.Size = New System.Drawing.Size(85, 23)
        Me.chk未点検表.TabIndex = 52
        Me.chk未点検表.Text = "点検表"
        Me.chk未点検表.UseVisualStyleBackColor = True
        '
        'chk様子確認
        '
        Me.chk様子確認.AutoSize = True
        Me.chk様子確認.Location = New System.Drawing.Point(135, 29)
        Me.chk様子確認.Margin = New System.Windows.Forms.Padding(8)
        Me.chk様子確認.Name = "chk様子確認"
        Me.chk様子確認.Size = New System.Drawing.Size(104, 23)
        Me.chk様子確認.TabIndex = 50
        Me.chk様子確認.Text = "様子確認"
        Me.chk様子確認.UseVisualStyleBackColor = True
        '
        'chk未データ
        '
        Me.chk未データ.AutoSize = True
        Me.chk未データ.Location = New System.Drawing.Point(255, 29)
        Me.chk未データ.Margin = New System.Windows.Forms.Padding(8)
        Me.chk未データ.Name = "chk未データ"
        Me.chk未データ.Size = New System.Drawing.Size(73, 23)
        Me.chk未データ.TabIndex = 48
        Me.chk未データ.Text = "データ"
        Me.chk未データ.UseVisualStyleBackColor = True
        '
        'chk点検表
        '
        Me.chk点検表.AutoSize = True
        Me.chk点検表.Location = New System.Drawing.Point(187, 24)
        Me.chk点検表.Margin = New System.Windows.Forms.Padding(8)
        Me.chk点検表.Name = "chk点検表"
        Me.chk点検表.Size = New System.Drawing.Size(85, 23)
        Me.chk点検表.TabIndex = 52
        Me.chk点検表.Text = "点検表"
        Me.chk点検表.UseVisualStyleBackColor = True
        '
        'chkデータ
        '
        Me.chkデータ.AutoSize = True
        Me.chkデータ.Location = New System.Drawing.Point(16, 24)
        Me.chkデータ.Margin = New System.Windows.Forms.Padding(8)
        Me.chkデータ.Name = "chkデータ"
        Me.chkデータ.Size = New System.Drawing.Size(73, 23)
        Me.chkデータ.TabIndex = 50
        Me.chkデータ.Text = "データ"
        Me.chkデータ.UseVisualStyleBackColor = True
        '
        'lblデータ
        '
        Me.lblデータ.AutoSize = True
        Me.lblデータ.Location = New System.Drawing.Point(73, 55)
        Me.lblデータ.Margin = New System.Windows.Forms.Padding(8, 0, 8, 0)
        Me.lblデータ.Name = "lblデータ"
        Me.lblデータ.Size = New System.Drawing.Size(0, 19)
        Me.lblデータ.TabIndex = 49
        '
        'lblその他
        '
        Me.lblその他.AutoSize = True
        Me.lblその他.Location = New System.Drawing.Point(81, 250)
        Me.lblその他.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.lblその他.Name = "lblその他"
        Me.lblその他.Size = New System.Drawing.Size(58, 19)
        Me.lblその他.TabIndex = 55
        Me.lblその他.Text = "その他" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'txtその他
        '
        Me.txtその他.Location = New System.Drawing.Point(141, 250)
        Me.txtその他.Margin = New System.Windows.Forms.Padding(5)
        Me.txtその他.Multiline = True
        Me.txtその他.Name = "txtその他"
        Me.txtその他.Size = New System.Drawing.Size(1030, 68)
        Me.txtその他.TabIndex = 56
        '
        'txt依頼元ID
        '
        Me.txt依頼元ID.Location = New System.Drawing.Point(652, 153)
        Me.txt依頼元ID.Margin = New System.Windows.Forms.Padding(7, 5, 7, 5)
        Me.txt依頼元ID.Name = "txt依頼元ID"
        Me.txt依頼元ID.Size = New System.Drawing.Size(71, 26)
        Me.txt依頼元ID.TabIndex = 38
        '
        'txt依頼元担当者
        '
        Me.txt依頼元担当者.Location = New System.Drawing.Point(1022, 153)
        Me.txt依頼元担当者.Margin = New System.Windows.Forms.Padding(7, 5, 7, 5)
        Me.txt依頼元担当者.Name = "txt依頼元担当者"
        Me.txt依頼元担当者.Size = New System.Drawing.Size(148, 26)
        Me.txt依頼元担当者.TabIndex = 41
        '
        'txt一般呼称
        '
        Me.txt一般呼称.Location = New System.Drawing.Point(722, 124)
        Me.txt一般呼称.Margin = New System.Windows.Forms.Padding(7, 5, 7, 5)
        Me.txt一般呼称.Name = "txt一般呼称"
        Me.txt一般呼称.Size = New System.Drawing.Size(223, 26)
        Me.txt一般呼称.TabIndex = 29
        '
        'Txt依頼元
        '
        Me.Txt依頼元.Location = New System.Drawing.Point(722, 153)
        Me.Txt依頼元.Margin = New System.Windows.Forms.Padding(7, 5, 7, 5)
        Me.Txt依頼元.Name = "Txt依頼元"
        Me.Txt依頼元.Size = New System.Drawing.Size(223, 26)
        Me.Txt依頼元.TabIndex = 39
        '
        'lbl作業名称
        '
        Me.lbl作業名称.AutoSize = True
        Me.lbl作業名称.Location = New System.Drawing.Point(566, 17)
        Me.lbl作業名称.Margin = New System.Windows.Forms.Padding(7, 0, 7, 0)
        Me.lbl作業名称.Name = "lbl作業名称"
        Me.lbl作業名称.Size = New System.Drawing.Size(85, 19)
        Me.lbl作業名称.TabIndex = 4
        Me.lbl作業名称.Text = "作業名称"
        Me.lbl作業名称.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'txt作業名称
        '
        Me.txt作業名称.Location = New System.Drawing.Point(652, 13)
        Me.txt作業名称.Margin = New System.Windows.Forms.Padding(7, 5, 7, 5)
        Me.txt作業名称.Name = "txt作業名称"
        Me.txt作業名称.Size = New System.Drawing.Size(516, 26)
        Me.txt作業名称.TabIndex = 5
        '
        'txt訪問先担当者
        '
        Me.txt訪問先担当者.Location = New System.Drawing.Point(1022, 124)
        Me.txt訪問先担当者.Margin = New System.Windows.Forms.Padding(7, 5, 7, 5)
        Me.txt訪問先担当者.Name = "txt訪問先担当者"
        Me.txt訪問先担当者.Size = New System.Drawing.Size(148, 26)
        Me.txt訪問先担当者.TabIndex = 31
        '
        'cmb作業者
        '
        Me.cmb作業者.FormattingEnabled = True
        Me.cmb作業者.Location = New System.Drawing.Point(389, 124)
        Me.cmb作業者.Margin = New System.Windows.Forms.Padding(7, 3, 7, 3)
        Me.cmb作業者.Name = "cmb作業者"
        Me.cmb作業者.Size = New System.Drawing.Size(144, 27)
        Me.cmb作業者.TabIndex = 26
        '
        'chk見積作成
        '
        Me.chk見積作成.AutoSize = True
        Me.chk見積作成.Location = New System.Drawing.Point(13, 29)
        Me.chk見積作成.Margin = New System.Windows.Forms.Padding(8)
        Me.chk見積作成.Name = "chk見積作成"
        Me.chk見積作成.Size = New System.Drawing.Size(104, 23)
        Me.chk見積作成.TabIndex = 0
        Me.chk見積作成.Text = "見積作成"
        Me.chk見積作成.UseVisualStyleBackColor = True
        '
        'cmb担当者
        '
        Me.cmb担当者.FormattingEnabled = True
        Me.cmb担当者.Location = New System.Drawing.Point(389, 96)
        Me.cmb担当者.Margin = New System.Windows.Forms.Padding(7, 3, 7, 3)
        Me.cmb担当者.Name = "cmb担当者"
        Me.cmb担当者.Size = New System.Drawing.Size(144, 27)
        Me.cmb担当者.TabIndex = 22
        '
        'lbl担当者
        '
        Me.lbl担当者.AutoSize = True
        Me.lbl担当者.Location = New System.Drawing.Point(322, 100)
        Me.lbl担当者.Margin = New System.Windows.Forms.Padding(7, 0, 7, 0)
        Me.lbl担当者.Name = "lbl担当者"
        Me.lbl担当者.Size = New System.Drawing.Size(66, 19)
        Me.lbl担当者.TabIndex = 21
        Me.lbl担当者.Text = "担当者"
        Me.lbl担当者.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'cmb受付者
        '
        Me.cmb受付者.FormattingEnabled = True
        Me.cmb受付者.Location = New System.Drawing.Point(389, 68)
        Me.cmb受付者.Margin = New System.Windows.Forms.Padding(7, 3, 7, 3)
        Me.cmb受付者.Name = "cmb受付者"
        Me.cmb受付者.Size = New System.Drawing.Size(144, 27)
        Me.cmb受付者.TabIndex = 16
        '
        'lbl受付者
        '
        Me.lbl受付者.AutoSize = True
        Me.lbl受付者.Location = New System.Drawing.Point(322, 72)
        Me.lbl受付者.Margin = New System.Windows.Forms.Padding(7, 0, 7, 0)
        Me.lbl受付者.Name = "lbl受付者"
        Me.lbl受付者.Size = New System.Drawing.Size(66, 19)
        Me.lbl受付者.TabIndex = 15
        Me.lbl受付者.Text = "受付者"
        Me.lbl受付者.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'cmb依頼コード
        '
        Me.cmb依頼コード.FormattingEnabled = True
        Me.cmb依頼コード.Location = New System.Drawing.Point(389, 40)
        Me.cmb依頼コード.Margin = New System.Windows.Forms.Padding(7, 3, 7, 3)
        Me.cmb依頼コード.Name = "cmb依頼コード"
        Me.cmb依頼コード.Size = New System.Drawing.Size(144, 27)
        Me.cmb依頼コード.TabIndex = 9
        '
        'lb依頼コード
        '
        Me.lb依頼コード.AutoSize = True
        Me.lb依頼コード.Location = New System.Drawing.Point(298, 44)
        Me.lb依頼コード.Margin = New System.Windows.Forms.Padding(7, 0, 7, 0)
        Me.lb依頼コード.Name = "lb依頼コード"
        Me.lb依頼コード.Size = New System.Drawing.Size(90, 19)
        Me.lb依頼コード.TabIndex = 8
        Me.lb依頼コード.Text = "依頼コード"
        Me.lb依頼コード.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'txt機械コード
        '
        Me.txt機械コード.Location = New System.Drawing.Point(389, 12)
        Me.txt機械コード.Margin = New System.Windows.Forms.Padding(7, 3, 7, 3)
        Me.txt機械コード.Name = "txt機械コード"
        Me.txt機械コード.Size = New System.Drawing.Size(144, 26)
        Me.txt機械コード.TabIndex = 3
        '
        'lbl機械コード
        '
        Me.lbl機械コード.AutoSize = True
        Me.lbl機械コード.Location = New System.Drawing.Point(298, 16)
        Me.lbl機械コード.Margin = New System.Windows.Forms.Padding(7, 0, 7, 0)
        Me.lbl機械コード.Name = "lbl機械コード"
        Me.lbl機械コード.Size = New System.Drawing.Size(90, 19)
        Me.lbl機械コード.TabIndex = 2
        Me.lbl機械コード.Text = "機械コード"
        Me.lbl機械コード.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'txt作業者
        '
        Me.txt作業者.AutoSize = True
        Me.txt作業者.Location = New System.Drawing.Point(321, 128)
        Me.txt作業者.Margin = New System.Windows.Forms.Padding(7, 0, 7, 0)
        Me.txt作業者.Name = "txt作業者"
        Me.txt作業者.Size = New System.Drawing.Size(66, 19)
        Me.txt作業者.TabIndex = 25
        Me.txt作業者.Text = "作業者"
        Me.txt作業者.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'grp未処理案件
        '
        Me.grp未処理案件.Controls.Add(Me.chk未写真)
        Me.grp未処理案件.Controls.Add(Me.chk未点検表)
        Me.grp未処理案件.Controls.Add(Me.chk様子確認)
        Me.grp未処理案件.Controls.Add(Me.chk未データ)
        Me.grp未処理案件.Controls.Add(Me.chk見積作成)
        Me.grp未処理案件.Location = New System.Drawing.Point(11, 406)
        Me.grp未処理案件.Margin = New System.Windows.Forms.Padding(8)
        Me.grp未処理案件.Name = "grp未処理案件"
        Me.grp未処理案件.Padding = New System.Windows.Forms.Padding(8)
        Me.grp未処理案件.Size = New System.Drawing.Size(815, 67)
        Me.grp未処理案件.TabIndex = 62
        Me.grp未処理案件.TabStop = False
        Me.grp未処理案件.Text = "未処理案件"
        '
        'chk写真
        '
        Me.chk写真.AutoSize = True
        Me.chk写真.Location = New System.Drawing.Point(105, 24)
        Me.chk写真.Margin = New System.Windows.Forms.Padding(8)
        Me.chk写真.Name = "chk写真"
        Me.chk写真.Size = New System.Drawing.Size(66, 23)
        Me.chk写真.TabIndex = 48
        Me.chk写真.Text = "写真"
        Me.chk写真.UseVisualStyleBackColor = True
        '
        'btn印刷
        '
        Me.btn印刷.Location = New System.Drawing.Point(758, 676)
        Me.btn印刷.Margin = New System.Windows.Forms.Padding(5)
        Me.btn印刷.Name = "btn印刷"
        Me.btn印刷.Size = New System.Drawing.Size(187, 71)
        Me.btn印刷.TabIndex = 65
        Me.btn印刷.Text = "印刷"
        Me.btn印刷.UseVisualStyleBackColor = True
        '
        'grp添付書類
        '
        Me.grp添付書類.Controls.Add(Me.chk点検表)
        Me.grp添付書類.Controls.Add(Me.chkデータ)
        Me.grp添付書類.Controls.Add(Me.lblデータ)
        Me.grp添付書類.Controls.Add(Me.chk写真)
        Me.grp添付書類.Location = New System.Drawing.Point(468, 351)
        Me.grp添付書類.Margin = New System.Windows.Forms.Padding(8)
        Me.grp添付書類.Name = "grp添付書類"
        Me.grp添付書類.Padding = New System.Windows.Forms.Padding(8)
        Me.grp添付書類.Size = New System.Drawing.Size(358, 65)
        Me.grp添付書類.TabIndex = 60
        Me.grp添付書類.TabStop = False
        Me.grp添付書類.Text = "添付書類"
        '
        'grp無償処理
        '
        Me.grp無償処理.Controls.Add(Me.Label1)
        Me.grp無償処理.Controls.Add(Me.txtクレーム)
        Me.grp無償処理.Controls.Add(Me.lblクレーム処理)
        Me.grp無償処理.Controls.Add(Me.cmb営業処理)
        Me.grp無償処理.Controls.Add(Me.lbl営業処理)
        Me.grp無償処理.Location = New System.Drawing.Point(825, 351)
        Me.grp無償処理.Margin = New System.Windows.Forms.Padding(8)
        Me.grp無償処理.Name = "grp無償処理"
        Me.grp無償処理.Padding = New System.Windows.Forms.Padding(8)
        Me.grp無償処理.Size = New System.Drawing.Size(346, 122)
        Me.grp無償処理.TabIndex = 61
        Me.grp無償処理.TabStop = False
        Me.grp無償処理.Text = "無償処理"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(11, 89)
        Me.Label1.Margin = New System.Windows.Forms.Padding(8, 0, 8, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(255, 19)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "クレーム処理は依頼書番号入力" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'txtクレーム
        '
        Me.txtクレーム.Location = New System.Drawing.Point(119, 55)
        Me.txtクレーム.Margin = New System.Windows.Forms.Padding(8)
        Me.txtクレーム.Name = "txtクレーム"
        Me.txtクレーム.Size = New System.Drawing.Size(210, 26)
        Me.txtクレーム.TabIndex = 3
        '
        'lblクレーム処理
        '
        Me.lblクレーム処理.AutoSize = True
        Me.lblクレーム処理.Location = New System.Drawing.Point(11, 59)
        Me.lblクレーム処理.Margin = New System.Windows.Forms.Padding(8, 0, 8, 0)
        Me.lblクレーム処理.Name = "lblクレーム処理"
        Me.lblクレーム処理.Size = New System.Drawing.Size(106, 19)
        Me.lblクレーム処理.TabIndex = 2
        Me.lblクレーム処理.Text = "クレーム処理"
        '
        'cmb営業処理
        '
        Me.cmb営業処理.FormattingEnabled = True
        Me.cmb営業処理.Location = New System.Drawing.Point(119, 24)
        Me.cmb営業処理.Margin = New System.Windows.Forms.Padding(8)
        Me.cmb営業処理.Name = "cmb営業処理"
        Me.cmb営業処理.Size = New System.Drawing.Size(210, 27)
        Me.cmb営業処理.TabIndex = 1
        '
        'lbl営業処理
        '
        Me.lbl営業処理.AutoSize = True
        Me.lbl営業処理.Location = New System.Drawing.Point(32, 28)
        Me.lbl営業処理.Margin = New System.Windows.Forms.Padding(8, 0, 8, 0)
        Me.lbl営業処理.Name = "lbl営業処理"
        Me.lbl営業処理.Size = New System.Drawing.Size(85, 19)
        Me.lbl営業処理.TabIndex = 0
        Me.lbl営業処理.Text = "営業処理"
        '
        'grp費用処理
        '
        Me.grp費用処理.Controls.Add(Me.chk無償)
        Me.grp費用処理.Controls.Add(Me.lbl年間契約)
        Me.grp費用処理.Controls.Add(Me.chk有償見)
        Me.grp費用処理.Controls.Add(Me.lbl有償見)
        Me.grp費用処理.Controls.Add(Me.chk年間契約)
        Me.grp費用処理.Controls.Add(Me.lbl有償出)
        Me.grp費用処理.Controls.Add(Me.chk有償出)
        Me.grp費用処理.Location = New System.Drawing.Point(11, 351)
        Me.grp費用処理.Margin = New System.Windows.Forms.Padding(8)
        Me.grp費用処理.Name = "grp費用処理"
        Me.grp費用処理.Padding = New System.Windows.Forms.Padding(8)
        Me.grp費用処理.Size = New System.Drawing.Size(467, 65)
        Me.grp費用処理.TabIndex = 59
        Me.grp費用処理.TabStop = False
        Me.grp費用処理.Text = "費用処理"
        '
        'chk無償
        '
        Me.chk無償.AutoSize = True
        Me.chk無償.Location = New System.Drawing.Point(375, 25)
        Me.chk無償.Margin = New System.Windows.Forms.Padding(8)
        Me.chk無償.Name = "chk無償"
        Me.chk無償.Size = New System.Drawing.Size(66, 23)
        Me.chk無償.TabIndex = 52
        Me.chk無償.Text = "無償"
        Me.chk無償.UseVisualStyleBackColor = True
        '
        'lbl年間契約
        '
        Me.lbl年間契約.AutoSize = True
        Me.lbl年間契約.Location = New System.Drawing.Point(62, 168)
        Me.lbl年間契約.Margin = New System.Windows.Forms.Padding(8, 0, 8, 0)
        Me.lbl年間契約.Name = "lbl年間契約"
        Me.lbl年間契約.Size = New System.Drawing.Size(0, 19)
        Me.lbl年間契約.TabIndex = 51
        '
        'chk有償見
        '
        Me.chk有償見.AutoSize = True
        Me.chk有償見.Location = New System.Drawing.Point(134, 25)
        Me.chk有償見.Margin = New System.Windows.Forms.Padding(8)
        Me.chk有償見.Name = "chk有償見"
        Me.chk有償見.Size = New System.Drawing.Size(105, 23)
        Me.chk有償見.TabIndex = 50
        Me.chk有償見.Text = "有償【見】"
        Me.chk有償見.UseVisualStyleBackColor = True
        '
        'lbl有償見
        '
        Me.lbl有償見.AutoSize = True
        Me.lbl有償見.Location = New System.Drawing.Point(62, 109)
        Me.lbl有償見.Margin = New System.Windows.Forms.Padding(8, 0, 8, 0)
        Me.lbl有償見.Name = "lbl有償見"
        Me.lbl有償見.Size = New System.Drawing.Size(0, 19)
        Me.lbl有償見.TabIndex = 49
        '
        'chk年間契約
        '
        Me.chk年間契約.AutoSize = True
        Me.chk年間契約.Location = New System.Drawing.Point(255, 25)
        Me.chk年間契約.Margin = New System.Windows.Forms.Padding(8)
        Me.chk年間契約.Name = "chk年間契約"
        Me.chk年間契約.Size = New System.Drawing.Size(104, 23)
        Me.chk年間契約.TabIndex = 48
        Me.chk年間契約.Text = "年間契約"
        Me.chk年間契約.UseVisualStyleBackColor = True
        '
        'lbl有償出
        '
        Me.lbl有償出.AutoSize = True
        Me.lbl有償出.Location = New System.Drawing.Point(62, 54)
        Me.lbl有償出.Margin = New System.Windows.Forms.Padding(8, 0, 8, 0)
        Me.lbl有償出.Name = "lbl有償出"
        Me.lbl有償出.Size = New System.Drawing.Size(0, 19)
        Me.lbl有償出.TabIndex = 47
        '
        'chk有償出
        '
        Me.chk有償出.AutoSize = True
        Me.chk有償出.Location = New System.Drawing.Point(13, 25)
        Me.chk有償出.Margin = New System.Windows.Forms.Padding(8)
        Me.chk有償出.Name = "chk有償出"
        Me.chk有償出.Size = New System.Drawing.Size(105, 23)
        Me.chk有償出.TabIndex = 0
        Me.chk有償出.Text = "有償【出】"
        Me.chk有償出.UseVisualStyleBackColor = True
        '
        'txt請求金額
        '
        Me.txt請求金額.Location = New System.Drawing.Point(389, 222)
        Me.txt請求金額.Margin = New System.Windows.Forms.Padding(7, 3, 7, 3)
        Me.txt請求金額.Name = "txt請求金額"
        Me.txt請求金額.Size = New System.Drawing.Size(144, 26)
        Me.txt請求金額.TabIndex = 49
        Me.txt請求金額.Text = "\0"
        Me.txt請求金額.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lbl請求金額
        '
        Me.lbl請求金額.AutoSize = True
        Me.lbl請求金額.Location = New System.Drawing.Point(302, 226)
        Me.lbl請求金額.Margin = New System.Windows.Forms.Padding(8, 0, 8, 0)
        Me.lbl請求金額.Name = "lbl請求金額"
        Me.lbl請求金額.Size = New System.Drawing.Size(85, 19)
        Me.lbl請求金額.TabIndex = 48
        Me.lbl請求金額.Text = "請求金額"
        '
        'txt完了日
        '
        Me.txt完了日.Location = New System.Drawing.Point(141, 222)
        Me.txt完了日.Margin = New System.Windows.Forms.Padding(7, 3, 7, 3)
        Me.txt完了日.Name = "txt完了日"
        Me.txt完了日.Size = New System.Drawing.Size(118, 26)
        Me.txt完了日.TabIndex = 46
        '
        'txt竣工予定日
        '
        Me.txt竣工予定日.Location = New System.Drawing.Point(141, 181)
        Me.txt竣工予定日.Margin = New System.Windows.Forms.Padding(7, 3, 7, 3)
        Me.txt竣工予定日.Name = "txt竣工予定日"
        Me.txt竣工予定日.Size = New System.Drawing.Size(118, 26)
        Me.txt竣工予定日.TabIndex = 43
        '
        'lbl竣工予定日日
        '
        Me.lbl竣工予定日日.AutoSize = True
        Me.lbl竣工予定日日.Location = New System.Drawing.Point(35, 184)
        Me.lbl竣工予定日日.Margin = New System.Windows.Forms.Padding(7, 0, 7, 0)
        Me.lbl竣工予定日日.Name = "lbl竣工予定日日"
        Me.lbl竣工予定日日.Size = New System.Drawing.Size(104, 19)
        Me.lbl竣工予定日日.TabIndex = 42
        Me.lbl竣工予定日日.Text = "竣工予定日"
        Me.lbl竣工予定日日.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'txt予定時間
        '
        Me.txt予定時間.Location = New System.Drawing.Point(389, 153)
        Me.txt予定時間.Margin = New System.Windows.Forms.Padding(7, 3, 7, 3)
        Me.txt予定時間.Name = "txt予定時間"
        Me.txt予定時間.Size = New System.Drawing.Size(144, 26)
        Me.txt予定時間.TabIndex = 36
        '
        'lbl予定時間
        '
        Me.lbl予定時間.AutoSize = True
        Me.lbl予定時間.Location = New System.Drawing.Point(302, 157)
        Me.lbl予定時間.Margin = New System.Windows.Forms.Padding(7, 0, 7, 0)
        Me.lbl予定時間.Name = "lbl予定時間"
        Me.lbl予定時間.Size = New System.Drawing.Size(85, 19)
        Me.lbl予定時間.TabIndex = 35
        Me.lbl予定時間.Text = "予定時間"
        Me.lbl予定時間.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'txt予定日
        '
        Me.txt予定日.Location = New System.Drawing.Point(141, 153)
        Me.txt予定日.Margin = New System.Windows.Forms.Padding(7, 3, 7, 3)
        Me.txt予定日.Name = "txt予定日"
        Me.txt予定日.Size = New System.Drawing.Size(118, 26)
        Me.txt予定日.TabIndex = 33
        '
        'lbl予定日
        '
        Me.lbl予定日.AutoSize = True
        Me.lbl予定日.Location = New System.Drawing.Point(73, 157)
        Me.lbl予定日.Margin = New System.Windows.Forms.Padding(7, 0, 7, 0)
        Me.lbl予定日.Name = "lbl予定日"
        Me.lbl予定日.Size = New System.Drawing.Size(66, 19)
        Me.lbl予定日.TabIndex = 32
        Me.lbl予定日.Text = "予定日"
        Me.lbl予定日.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lbl契約内容
        '
        Me.lbl契約内容.AutoSize = True
        Me.lbl契約内容.Location = New System.Drawing.Point(566, 72)
        Me.lbl契約内容.Margin = New System.Windows.Forms.Padding(7, 0, 7, 0)
        Me.lbl契約内容.Name = "lbl契約内容"
        Me.lbl契約内容.Size = New System.Drawing.Size(85, 19)
        Me.lbl契約内容.TabIndex = 17
        Me.lbl契約内容.Text = "契約内容"
        Me.lbl契約内容.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'cmb契約番号
        '
        Me.cmb契約番号.FormattingEnabled = True
        Me.cmb契約番号.Location = New System.Drawing.Point(141, 124)
        Me.cmb契約番号.Margin = New System.Windows.Forms.Padding(7, 3, 7, 3)
        Me.cmb契約番号.Name = "cmb契約番号"
        Me.cmb契約番号.Size = New System.Drawing.Size(144, 27)
        Me.cmb契約番号.TabIndex = 24
        '
        'lbl契約番号
        '
        Me.lbl契約番号.AutoSize = True
        Me.lbl契約番号.Location = New System.Drawing.Point(53, 128)
        Me.lbl契約番号.Margin = New System.Windows.Forms.Padding(7, 0, 7, 0)
        Me.lbl契約番号.Name = "lbl契約番号"
        Me.lbl契約番号.Size = New System.Drawing.Size(85, 19)
        Me.lbl契約番号.TabIndex = 23
        Me.lbl契約番号.Text = "契約番号"
        Me.lbl契約番号.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'chk契約物件
        '
        Me.chk契約物件.AutoSize = True
        Me.chk契約物件.Location = New System.Drawing.Point(141, 102)
        Me.chk契約物件.Margin = New System.Windows.Forms.Padding(7, 3, 7, 3)
        Me.chk契約物件.Name = "chk契約物件"
        Me.chk契約物件.Size = New System.Drawing.Size(15, 14)
        Me.chk契約物件.TabIndex = 20
        Me.chk契約物件.UseVisualStyleBackColor = True
        '
        'txt契約内容
        '
        Me.txt契約内容.Location = New System.Drawing.Point(652, 67)
        Me.txt契約内容.Margin = New System.Windows.Forms.Padding(7, 3, 7, 3)
        Me.txt契約内容.Name = "txt契約内容"
        Me.txt契約内容.Size = New System.Drawing.Size(516, 26)
        Me.txt契約内容.TabIndex = 18
        '
        'txt受付日
        '
        Me.txt受付日.Location = New System.Drawing.Point(141, 68)
        Me.txt受付日.Margin = New System.Windows.Forms.Padding(7, 3, 7, 3)
        Me.txt受付日.Name = "txt受付日"
        Me.txt受付日.Size = New System.Drawing.Size(118, 26)
        Me.txt受付日.TabIndex = 13
        '
        'txt依頼書番号
        '
        Me.txt依頼書番号.Location = New System.Drawing.Point(141, 40)
        Me.txt依頼書番号.Margin = New System.Windows.Forms.Padding(7, 3, 7, 3)
        Me.txt依頼書番号.Name = "txt依頼書番号"
        Me.txt依頼書番号.Size = New System.Drawing.Size(144, 26)
        Me.txt依頼書番号.TabIndex = 7
        '
        'txt受付番号
        '
        Me.txt受付番号.Location = New System.Drawing.Point(141, 12)
        Me.txt受付番号.Margin = New System.Windows.Forms.Padding(7, 3, 7, 3)
        Me.txt受付番号.Name = "txt受付番号"
        Me.txt受付番号.Size = New System.Drawing.Size(144, 26)
        Me.txt受付番号.TabIndex = 1
        '
        'lbl契約物件
        '
        Me.lbl契約物件.AutoSize = True
        Me.lbl契約物件.Location = New System.Drawing.Point(49, 100)
        Me.lbl契約物件.Margin = New System.Windows.Forms.Padding(7, 0, 7, 0)
        Me.lbl契約物件.Name = "lbl契約物件"
        Me.lbl契約物件.Size = New System.Drawing.Size(85, 19)
        Me.lbl契約物件.TabIndex = 19
        Me.lbl契約物件.Text = "契約物件"
        Me.lbl契約物件.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lbl受付日
        '
        Me.lbl受付日.AutoSize = True
        Me.lbl受付日.Location = New System.Drawing.Point(72, 72)
        Me.lbl受付日.Margin = New System.Windows.Forms.Padding(7, 0, 7, 0)
        Me.lbl受付日.Name = "lbl受付日"
        Me.lbl受付日.Size = New System.Drawing.Size(66, 19)
        Me.lbl受付日.TabIndex = 12
        Me.lbl受付日.Text = "受付日"
        Me.lbl受付日.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lbl依頼者番号
        '
        Me.lbl依頼者番号.AutoSize = True
        Me.lbl依頼者番号.Location = New System.Drawing.Point(34, 44)
        Me.lbl依頼者番号.Margin = New System.Windows.Forms.Padding(7, 0, 7, 0)
        Me.lbl依頼者番号.Name = "lbl依頼者番号"
        Me.lbl依頼者番号.Size = New System.Drawing.Size(104, 19)
        Me.lbl依頼者番号.TabIndex = 6
        Me.lbl依頼者番号.Text = "依頼書番号"
        Me.lbl依頼者番号.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lbl受付番号
        '
        Me.lbl受付番号.AutoSize = True
        Me.lbl受付番号.Location = New System.Drawing.Point(53, 16)
        Me.lbl受付番号.Margin = New System.Windows.Forms.Padding(7, 0, 7, 0)
        Me.lbl受付番号.Name = "lbl受付番号"
        Me.lbl受付番号.Size = New System.Drawing.Size(85, 19)
        Me.lbl受付番号.TabIndex = 0
        Me.lbl受付番号.Text = "受付番号"
        Me.lbl受付番号.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'txt客先ID
        '
        Me.txt客先ID.Location = New System.Drawing.Point(652, 124)
        Me.txt客先ID.Margin = New System.Windows.Forms.Padding(7, 5, 7, 5)
        Me.txt客先ID.Name = "txt客先ID"
        Me.txt客先ID.Size = New System.Drawing.Size(71, 26)
        Me.txt客先ID.TabIndex = 28
        '
        'lbl訪問先担当者
        '
        Me.lbl訪問先担当者.AutoSize = True
        Me.lbl訪問先担当者.Location = New System.Drawing.Point(970, 128)
        Me.lbl訪問先担当者.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.lbl訪問先担当者.Name = "lbl訪問先担当者"
        Me.lbl訪問先担当者.Size = New System.Drawing.Size(47, 19)
        Me.lbl訪問先担当者.TabIndex = 30
        Me.lbl訪問先担当者.Text = "担当"
        '
        'ibl客先ID
        '
        Me.ibl客先ID.AutoSize = True
        Me.ibl客先ID.Location = New System.Drawing.Point(584, 128)
        Me.ibl客先ID.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.ibl客先ID.Name = "ibl客先ID"
        Me.ibl客先ID.Size = New System.Drawing.Size(66, 19)
        Me.ibl客先ID.TabIndex = 27
        Me.ibl客先ID.Text = "訪問先"
        '
        'lbl依頼元ID
        '
        Me.lbl依頼元ID.AutoSize = True
        Me.lbl依頼元ID.Location = New System.Drawing.Point(585, 157)
        Me.lbl依頼元ID.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.lbl依頼元ID.Name = "lbl依頼元ID"
        Me.lbl依頼元ID.Size = New System.Drawing.Size(66, 19)
        Me.lbl依頼元ID.TabIndex = 37
        Me.lbl依頼元ID.Text = "依頼元"
        '
        'lbl請求先担当者
        '
        Me.lbl請求先担当者.AutoSize = True
        Me.lbl請求先担当者.Location = New System.Drawing.Point(969, 226)
        Me.lbl請求先担当者.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.lbl請求先担当者.Name = "lbl請求先担当者"
        Me.lbl請求先担当者.Size = New System.Drawing.Size(47, 19)
        Me.lbl請求先担当者.TabIndex = 53
        Me.lbl請求先担当者.Text = "担当"
        '
        'lbl請求先
        '
        Me.lbl請求先.AutoSize = True
        Me.lbl請求先.Location = New System.Drawing.Point(585, 226)
        Me.lbl請求先.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.lbl請求先.Name = "lbl請求先"
        Me.lbl請求先.Size = New System.Drawing.Size(66, 19)
        Me.lbl請求先.TabIndex = 50
        Me.lbl請求先.Text = "請求先"
        '
        'txt請求先ID
        '
        Me.txt請求先ID.Location = New System.Drawing.Point(652, 222)
        Me.txt請求先ID.Margin = New System.Windows.Forms.Padding(7, 5, 7, 5)
        Me.txt請求先ID.Name = "txt請求先ID"
        Me.txt請求先ID.Size = New System.Drawing.Size(71, 26)
        Me.txt請求先ID.TabIndex = 51
        '
        'txt請求先担当者
        '
        Me.txt請求先担当者.Location = New System.Drawing.Point(1022, 222)
        Me.txt請求先担当者.Margin = New System.Windows.Forms.Padding(7, 5, 7, 5)
        Me.txt請求先担当者.Name = "txt請求先担当者"
        Me.txt請求先担当者.Size = New System.Drawing.Size(148, 26)
        Me.txt請求先担当者.TabIndex = 54
        '
        'txt請求先
        '
        Me.txt請求先.Location = New System.Drawing.Point(722, 222)
        Me.txt請求先.Margin = New System.Windows.Forms.Padding(7, 5, 7, 5)
        Me.txt請求先.Name = "txt請求先"
        Me.txt請求先.Size = New System.Drawing.Size(223, 26)
        Me.txt請求先.TabIndex = 52
        '
        'lbl依頼内容
        '
        Me.lbl依頼内容.AutoSize = True
        Me.lbl依頼内容.Location = New System.Drawing.Point(561, 44)
        Me.lbl依頼内容.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.lbl依頼内容.Name = "lbl依頼内容"
        Me.lbl依頼内容.Size = New System.Drawing.Size(85, 19)
        Me.lbl依頼内容.TabIndex = 10
        Me.lbl依頼内容.Text = "依頼内容"
        '
        'txt依頼内容
        '
        Me.txt依頼内容.Location = New System.Drawing.Point(652, 40)
        Me.txt依頼内容.Margin = New System.Windows.Forms.Padding(7, 5, 7, 5)
        Me.txt依頼内容.Name = "txt依頼内容"
        Me.txt依頼内容.Size = New System.Drawing.Size(516, 26)
        Me.txt依頼内容.TabIndex = 11
        '
        'lbl入金確認
        '
        Me.lbl入金確認.AutoSize = True
        Me.lbl入金確認.Location = New System.Drawing.Point(53, 324)
        Me.lbl入金確認.Margin = New System.Windows.Forms.Padding(7, 0, 7, 0)
        Me.lbl入金確認.Name = "lbl入金確認"
        Me.lbl入金確認.Size = New System.Drawing.Size(85, 19)
        Me.lbl入金確認.TabIndex = 57
        Me.lbl入金確認.Text = "入金確認"
        Me.lbl入金確認.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lbl完了日
        '
        Me.lbl完了日.AutoSize = True
        Me.lbl完了日.Location = New System.Drawing.Point(75, 226)
        Me.lbl完了日.Margin = New System.Windows.Forms.Padding(7, 0, 7, 0)
        Me.lbl完了日.Name = "lbl完了日"
        Me.lbl完了日.Size = New System.Drawing.Size(66, 19)
        Me.lbl完了日.TabIndex = 45
        Me.lbl完了日.Text = "完了日"
        Me.lbl完了日.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'btn受付日
        '
        Me.btn受付日.Location = New System.Drawing.Point(259, 68)
        Me.btn受付日.Name = "btn受付日"
        Me.btn受付日.Size = New System.Drawing.Size(26, 27)
        Me.btn受付日.TabIndex = 14
        Me.btn受付日.TabStop = False
        Me.btn受付日.UseVisualStyleBackColor = True
        '
        'btn予定日
        '
        Me.btn予定日.Location = New System.Drawing.Point(259, 153)
        Me.btn予定日.Name = "btn予定日"
        Me.btn予定日.Size = New System.Drawing.Size(26, 27)
        Me.btn予定日.TabIndex = 34
        Me.btn予定日.TabStop = False
        Me.btn予定日.UseVisualStyleBackColor = True
        '
        'btn竣工予定日
        '
        Me.btn竣工予定日.Location = New System.Drawing.Point(259, 181)
        Me.btn竣工予定日.Name = "btn竣工予定日"
        Me.btn竣工予定日.Size = New System.Drawing.Size(26, 27)
        Me.btn竣工予定日.TabIndex = 44
        Me.btn竣工予定日.TabStop = False
        Me.btn竣工予定日.UseVisualStyleBackColor = True
        '
        'btn完了日
        '
        Me.btn完了日.Location = New System.Drawing.Point(259, 222)
        Me.btn完了日.Name = "btn完了日"
        Me.btn完了日.Size = New System.Drawing.Size(26, 27)
        Me.btn完了日.TabIndex = 47
        Me.btn完了日.TabStop = False
        Me.btn完了日.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(972, 157)
        Me.Label2.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(47, 19)
        Me.Label2.TabIndex = 40
        Me.Label2.Text = "担当"
        '
        'chk入金確認
        '
        Me.chk入金確認.AutoSize = True
        Me.chk入金確認.Location = New System.Drawing.Point(145, 329)
        Me.chk入金確認.Margin = New System.Windows.Forms.Padding(7, 3, 7, 3)
        Me.chk入金確認.Name = "chk入金確認"
        Me.chk入金確認.Size = New System.Drawing.Size(15, 14)
        Me.chk入金確認.TabIndex = 58
        Me.chk入金確認.UseVisualStyleBackColor = True
        '
        'dgv一覧
        '
        Me.dgv一覧.AllowUserToAddRows = False
        Me.dgv一覧.AllowUserToDeleteRows = False
        Me.dgv一覧.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgv一覧.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv一覧.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.col受付番号, Me.col依頼書番号, Me.col請伝番号, Me.col受付日, Me.col受付者, Me.col担当者, Me.col作業者, Me.col客先ID, Me.col一般呼称, Me.col訪問先担当者, Me.col完了, Me.col請求金額, Me.col請求完了日, Me.col竣工予定日, Me.col依頼内容, Me.col予定日, Me.col予定時間, Me.col契約物件, Me.col契約番号, Me.col契約内容, Me.col依頼元ID, Me.col依頼元, Me.col依頼元担当者, Me.col請求先ID, Me.col請求先, Me.col請求先担当者, Me.col機械コード, Me.colその他, Me.col写真, Me.col点検表, Me.colデータ, Me.col見積作成, Me.col様子確認, Me.col未写真, Me.col未点検表, Me.col未データ, Me.col有償出, Me.col有償見, Me.col無償, Me.col年間契約, Me.col入金確認, Me.col営業処理, Me.colクレーム})
        Me.dgv一覧.Location = New System.Drawing.Point(14, 484)
        Me.dgv一覧.Name = "dgv一覧"
        Me.dgv一覧.ReadOnly = True
        Me.dgv一覧.RowHeadersVisible = False
        Me.dgv一覧.RowTemplate.Height = 30
        Me.dgv一覧.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv一覧.Size = New System.Drawing.Size(1158, 186)
        Me.dgv一覧.TabIndex = 63
        Me.dgv一覧.TabStop = False
        '
        'col受付番号
        '
        Me.col受付番号.DataPropertyName = "受付番号"
        Me.col受付番号.Frozen = True
        Me.col受付番号.HeaderText = "受付番号"
        Me.col受付番号.Name = "col受付番号"
        Me.col受付番号.ReadOnly = True
        Me.col受付番号.Visible = False
        Me.col受付番号.Width = 60
        '
        'col依頼書番号
        '
        Me.col依頼書番号.DataPropertyName = "依頼書番号"
        Me.col依頼書番号.Frozen = True
        Me.col依頼書番号.HeaderText = "依頼書番号"
        Me.col依頼書番号.Name = "col依頼書番号"
        Me.col依頼書番号.ReadOnly = True
        Me.col依頼書番号.Width = 150
        '
        'col請伝番号
        '
        Me.col請伝番号.DataPropertyName = "請伝番号"
        Me.col請伝番号.Frozen = True
        Me.col請伝番号.HeaderText = "請伝番号"
        Me.col請伝番号.Name = "col請伝番号"
        Me.col請伝番号.ReadOnly = True
        Me.col請伝番号.Width = 120
        '
        'col受付日
        '
        Me.col受付日.DataPropertyName = "受付日"
        Me.col受付日.HeaderText = "受付日"
        Me.col受付日.Name = "col受付日"
        Me.col受付日.ReadOnly = True
        Me.col受付日.Width = 150
        '
        'col受付者
        '
        Me.col受付者.DataPropertyName = "受付者"
        Me.col受付者.HeaderText = "受付者"
        Me.col受付者.Name = "col受付者"
        Me.col受付者.ReadOnly = True
        Me.col受付者.Width = 120
        '
        'col担当者
        '
        Me.col担当者.DataPropertyName = "担当者"
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.Format = "yyyy/MM/dd"
        Me.col担当者.DefaultCellStyle = DataGridViewCellStyle1
        Me.col担当者.HeaderText = "担当者"
        Me.col担当者.Name = "col担当者"
        Me.col担当者.ReadOnly = True
        Me.col担当者.Width = 120
        '
        'col作業者
        '
        Me.col作業者.DataPropertyName = "作業者"
        Me.col作業者.HeaderText = "作業者"
        Me.col作業者.Name = "col作業者"
        Me.col作業者.ReadOnly = True
        Me.col作業者.Width = 120
        '
        'col客先ID
        '
        Me.col客先ID.DataPropertyName = "客先ID"
        Me.col客先ID.HeaderText = "客先ID"
        Me.col客先ID.Name = "col客先ID"
        Me.col客先ID.ReadOnly = True
        Me.col客先ID.Width = 120
        '
        'col一般呼称
        '
        Me.col一般呼称.DataPropertyName = "一般呼称"
        Me.col一般呼称.HeaderText = "一般呼称"
        Me.col一般呼称.Name = "col一般呼称"
        Me.col一般呼称.ReadOnly = True
        Me.col一般呼称.Width = 150
        '
        'col訪問先担当者
        '
        Me.col訪問先担当者.DataPropertyName = "訪問先担当者"
        Me.col訪問先担当者.HeaderText = "訪問先担当者"
        Me.col訪問先担当者.Name = "col訪問先担当者"
        Me.col訪問先担当者.ReadOnly = True
        Me.col訪問先担当者.Width = 150
        '
        'col完了
        '
        Me.col完了.DataPropertyName = "完了"
        Me.col完了.HeaderText = "完了"
        Me.col完了.Name = "col完了"
        Me.col完了.ReadOnly = True
        Me.col完了.Width = 150
        '
        'col請求金額
        '
        Me.col請求金額.DataPropertyName = "請求金額"
        Me.col請求金額.HeaderText = "請求金額"
        Me.col請求金額.Name = "col請求金額"
        Me.col請求金額.ReadOnly = True
        Me.col請求金額.Width = 120
        '
        'col請求完了日
        '
        Me.col請求完了日.DataPropertyName = "請求完了日"
        Me.col請求完了日.HeaderText = "請求完了日"
        Me.col請求完了日.Name = "col請求完了日"
        Me.col請求完了日.ReadOnly = True
        Me.col請求完了日.Width = 200
        '
        'col竣工予定日
        '
        Me.col竣工予定日.DataPropertyName = "竣工予定日"
        Me.col竣工予定日.HeaderText = "竣工予定日"
        Me.col竣工予定日.Name = "col竣工予定日"
        Me.col竣工予定日.ReadOnly = True
        Me.col竣工予定日.Visible = False
        Me.col竣工予定日.Width = 120
        '
        'col依頼内容
        '
        Me.col依頼内容.DataPropertyName = "依頼内容"
        Me.col依頼内容.HeaderText = "依頼内容"
        Me.col依頼内容.Name = "col依頼内容"
        Me.col依頼内容.ReadOnly = True
        Me.col依頼内容.Visible = False
        Me.col依頼内容.Width = 120
        '
        'col予定日
        '
        Me.col予定日.DataPropertyName = "予定日"
        Me.col予定日.HeaderText = "予定日"
        Me.col予定日.Name = "col予定日"
        Me.col予定日.ReadOnly = True
        Me.col予定日.Visible = False
        Me.col予定日.Width = 120
        '
        'col予定時間
        '
        Me.col予定時間.DataPropertyName = "予定時間"
        Me.col予定時間.HeaderText = "予定時間"
        Me.col予定時間.Name = "col予定時間"
        Me.col予定時間.ReadOnly = True
        Me.col予定時間.Width = 120
        '
        'col契約物件
        '
        Me.col契約物件.DataPropertyName = "契約物件"
        Me.col契約物件.HeaderText = "契約物件"
        Me.col契約物件.Name = "col契約物件"
        Me.col契約物件.ReadOnly = True
        Me.col契約物件.Visible = False
        Me.col契約物件.Width = 120
        '
        'col契約番号
        '
        Me.col契約番号.DataPropertyName = "契約番号"
        Me.col契約番号.HeaderText = "契約番号"
        Me.col契約番号.Name = "col契約番号"
        Me.col契約番号.ReadOnly = True
        Me.col契約番号.Visible = False
        Me.col契約番号.Width = 120
        '
        'col契約内容
        '
        Me.col契約内容.DataPropertyName = "契約内容"
        Me.col契約内容.HeaderText = "契約内容"
        Me.col契約内容.Name = "col契約内容"
        Me.col契約内容.ReadOnly = True
        '
        'col依頼元ID
        '
        Me.col依頼元ID.DataPropertyName = "依頼元ID"
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.Format = "yyyy/MM/dd"
        Me.col依頼元ID.DefaultCellStyle = DataGridViewCellStyle2
        Me.col依頼元ID.HeaderText = "依頼元ID"
        Me.col依頼元ID.Name = "col依頼元ID"
        Me.col依頼元ID.ReadOnly = True
        Me.col依頼元ID.Width = 120
        '
        'col依頼元
        '
        Me.col依頼元.DataPropertyName = "依頼元"
        Me.col依頼元.HeaderText = "依頼元"
        Me.col依頼元.Name = "col依頼元"
        Me.col依頼元.ReadOnly = True
        Me.col依頼元.Width = 200
        '
        'col依頼元担当者
        '
        Me.col依頼元担当者.DataPropertyName = "依頼元担当者"
        Me.col依頼元担当者.HeaderText = "依頼元担当者"
        Me.col依頼元担当者.Name = "col依頼元担当者"
        Me.col依頼元担当者.ReadOnly = True
        Me.col依頼元担当者.Width = 120
        '
        'col請求先ID
        '
        Me.col請求先ID.DataPropertyName = "請求先ID"
        Me.col請求先ID.HeaderText = "請求先ID"
        Me.col請求先ID.Name = "col請求先ID"
        Me.col請求先ID.ReadOnly = True
        '
        'col請求先
        '
        Me.col請求先.DataPropertyName = "請求先"
        Me.col請求先.HeaderText = "請求先"
        Me.col請求先.Name = "col請求先"
        Me.col請求先.ReadOnly = True
        '
        'col請求先担当者
        '
        Me.col請求先担当者.DataPropertyName = "請求先担当者"
        Me.col請求先担当者.HeaderText = "請求先担当者"
        Me.col請求先担当者.Name = "col請求先担当者"
        Me.col請求先担当者.ReadOnly = True
        '
        'col機械コード
        '
        Me.col機械コード.DataPropertyName = "機械コード"
        Me.col機械コード.HeaderText = "機械コード"
        Me.col機械コード.Name = "col機械コード"
        Me.col機械コード.ReadOnly = True
        '
        'colその他
        '
        Me.colその他.DataPropertyName = "その他"
        Me.colその他.HeaderText = "その他"
        Me.colその他.Name = "colその他"
        Me.colその他.ReadOnly = True
        '
        'col写真
        '
        Me.col写真.DataPropertyName = "写真"
        Me.col写真.HeaderText = "写真"
        Me.col写真.Name = "col写真"
        Me.col写真.ReadOnly = True
        '
        'col点検表
        '
        Me.col点検表.DataPropertyName = "点検表"
        Me.col点検表.HeaderText = "点検表"
        Me.col点検表.Name = "col点検表"
        Me.col点検表.ReadOnly = True
        '
        'colデータ
        '
        Me.colデータ.DataPropertyName = "データ"
        Me.colデータ.HeaderText = "データ"
        Me.colデータ.Name = "colデータ"
        Me.colデータ.ReadOnly = True
        '
        'col見積作成
        '
        Me.col見積作成.DataPropertyName = "見積作成"
        Me.col見積作成.HeaderText = "見積作成"
        Me.col見積作成.Name = "col見積作成"
        Me.col見積作成.ReadOnly = True
        '
        'col様子確認
        '
        Me.col様子確認.DataPropertyName = "様子確認"
        Me.col様子確認.HeaderText = "様子確認"
        Me.col様子確認.Name = "col様子確認"
        Me.col様子確認.ReadOnly = True
        '
        'col未写真
        '
        Me.col未写真.DataPropertyName = "未写真"
        Me.col未写真.HeaderText = "未写真"
        Me.col未写真.Name = "col未写真"
        Me.col未写真.ReadOnly = True
        '
        'col未点検表
        '
        Me.col未点検表.DataPropertyName = "未点検表"
        Me.col未点検表.HeaderText = "未点検表"
        Me.col未点検表.Name = "col未点検表"
        Me.col未点検表.ReadOnly = True
        '
        'col未データ
        '
        Me.col未データ.DataPropertyName = "未データ"
        Me.col未データ.HeaderText = "未データ"
        Me.col未データ.Name = "col未データ"
        Me.col未データ.ReadOnly = True
        '
        'col有償出
        '
        Me.col有償出.DataPropertyName = "有償【出】"
        Me.col有償出.HeaderText = "有償【出】"
        Me.col有償出.Name = "col有償出"
        Me.col有償出.ReadOnly = True
        '
        'col有償見
        '
        Me.col有償見.DataPropertyName = "有償【見】"
        Me.col有償見.HeaderText = "有償【見】"
        Me.col有償見.Name = "col有償見"
        Me.col有償見.ReadOnly = True
        '
        'col無償
        '
        Me.col無償.DataPropertyName = "無償"
        Me.col無償.HeaderText = "無償"
        Me.col無償.Name = "col無償"
        Me.col無償.ReadOnly = True
        '
        'col年間契約
        '
        Me.col年間契約.DataPropertyName = "年間契約"
        Me.col年間契約.HeaderText = "年間契約"
        Me.col年間契約.Name = "col年間契約"
        Me.col年間契約.ReadOnly = True
        '
        'col入金確認
        '
        Me.col入金確認.DataPropertyName = "入金確認"
        Me.col入金確認.HeaderText = "入金確認"
        Me.col入金確認.Name = "col入金確認"
        Me.col入金確認.ReadOnly = True
        '
        'col営業処理
        '
        Me.col営業処理.DataPropertyName = "営業処理"
        Me.col営業処理.HeaderText = "営業処理"
        Me.col営業処理.Name = "col営業処理"
        Me.col営業処理.ReadOnly = True
        '
        'colクレーム
        '
        Me.colクレーム.DataPropertyName = "クレーム"
        Me.colクレーム.HeaderText = "クレーム"
        Me.colクレーム.Name = "colクレーム"
        Me.colクレーム.ReadOnly = True
        '
        'btn登録
        '
        Me.btn登録.ForeColor = System.Drawing.Color.Green
        Me.btn登録.Location = New System.Drawing.Point(13, 676)
        Me.btn登録.Margin = New System.Windows.Forms.Padding(5)
        Me.btn登録.Name = "btn登録"
        Me.btn登録.Size = New System.Drawing.Size(187, 71)
        Me.btn登録.TabIndex = 64
        Me.btn登録.Text = "登録"
        Me.btn登録.UseVisualStyleBackColor = True
        '
        'frmI依頼書登録
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1184, 761)
        Me.Controls.Add(Me.btn登録)
        Me.Controls.Add(Me.dgv一覧)
        Me.Controls.Add(Me.chk入金確認)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btn完了日)
        Me.Controls.Add(Me.btn竣工予定日)
        Me.Controls.Add(Me.btn予定日)
        Me.Controls.Add(Me.btn受付日)
        Me.Controls.Add(Me.grp添付書類)
        Me.Controls.Add(Me.lbl入金確認)
        Me.Controls.Add(Me.lbl依頼内容)
        Me.Controls.Add(Me.txt依頼内容)
        Me.Controls.Add(Me.lbl請求先担当者)
        Me.Controls.Add(Me.lbl請求先)
        Me.Controls.Add(Me.txt請求先ID)
        Me.Controls.Add(Me.txt請求先担当者)
        Me.Controls.Add(Me.txt請求先)
        Me.Controls.Add(Me.lbl依頼元ID)
        Me.Controls.Add(Me.ibl客先ID)
        Me.Controls.Add(Me.lbl訪問先担当者)
        Me.Controls.Add(Me.txt客先ID)
        Me.Controls.Add(Me.lblその他)
        Me.Controls.Add(Me.txtその他)
        Me.Controls.Add(Me.txt依頼元ID)
        Me.Controls.Add(Me.txt依頼元担当者)
        Me.Controls.Add(Me.txt一般呼称)
        Me.Controls.Add(Me.Txt依頼元)
        Me.Controls.Add(Me.lbl作業名称)
        Me.Controls.Add(Me.txt作業名称)
        Me.Controls.Add(Me.txt訪問先担当者)
        Me.Controls.Add(Me.cmb作業者)
        Me.Controls.Add(Me.cmb担当者)
        Me.Controls.Add(Me.lbl担当者)
        Me.Controls.Add(Me.cmb受付者)
        Me.Controls.Add(Me.lbl受付者)
        Me.Controls.Add(Me.cmb依頼コード)
        Me.Controls.Add(Me.lb依頼コード)
        Me.Controls.Add(Me.txt機械コード)
        Me.Controls.Add(Me.lbl機械コード)
        Me.Controls.Add(Me.txt作業者)
        Me.Controls.Add(Me.grp未処理案件)
        Me.Controls.Add(Me.btn印刷)
        Me.Controls.Add(Me.grp無償処理)
        Me.Controls.Add(Me.grp費用処理)
        Me.Controls.Add(Me.txt請求金額)
        Me.Controls.Add(Me.lbl請求金額)
        Me.Controls.Add(Me.txt完了日)
        Me.Controls.Add(Me.lbl完了日)
        Me.Controls.Add(Me.txt竣工予定日)
        Me.Controls.Add(Me.lbl竣工予定日日)
        Me.Controls.Add(Me.txt予定時間)
        Me.Controls.Add(Me.lbl予定時間)
        Me.Controls.Add(Me.txt予定日)
        Me.Controls.Add(Me.lbl予定日)
        Me.Controls.Add(Me.lbl契約内容)
        Me.Controls.Add(Me.cmb契約番号)
        Me.Controls.Add(Me.lbl契約番号)
        Me.Controls.Add(Me.chk契約物件)
        Me.Controls.Add(Me.txt契約内容)
        Me.Controls.Add(Me.txt受付日)
        Me.Controls.Add(Me.txt依頼書番号)
        Me.Controls.Add(Me.txt受付番号)
        Me.Controls.Add(Me.lbl契約物件)
        Me.Controls.Add(Me.lbl受付日)
        Me.Controls.Add(Me.lbl依頼者番号)
        Me.Controls.Add(Me.lbl受付番号)
        Me.Margin = New System.Windows.Forms.Padding(8)
        Me.Name = "frmI依頼書登録"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "依頼書登録"
        Me.Controls.SetChildIndex(Me.lbl受付番号, 0)
        Me.Controls.SetChildIndex(Me.lbl依頼者番号, 0)
        Me.Controls.SetChildIndex(Me.lbl受付日, 0)
        Me.Controls.SetChildIndex(Me.lbl契約物件, 0)
        Me.Controls.SetChildIndex(Me.txt受付番号, 0)
        Me.Controls.SetChildIndex(Me.txt依頼書番号, 0)
        Me.Controls.SetChildIndex(Me.txt受付日, 0)
        Me.Controls.SetChildIndex(Me.txt契約内容, 0)
        Me.Controls.SetChildIndex(Me.chk契約物件, 0)
        Me.Controls.SetChildIndex(Me.lbl契約番号, 0)
        Me.Controls.SetChildIndex(Me.cmb契約番号, 0)
        Me.Controls.SetChildIndex(Me.lbl契約内容, 0)
        Me.Controls.SetChildIndex(Me.lbl予定日, 0)
        Me.Controls.SetChildIndex(Me.txt予定日, 0)
        Me.Controls.SetChildIndex(Me.lbl予定時間, 0)
        Me.Controls.SetChildIndex(Me.txt予定時間, 0)
        Me.Controls.SetChildIndex(Me.lbl竣工予定日日, 0)
        Me.Controls.SetChildIndex(Me.txt竣工予定日, 0)
        Me.Controls.SetChildIndex(Me.lbl完了日, 0)
        Me.Controls.SetChildIndex(Me.txt完了日, 0)
        Me.Controls.SetChildIndex(Me.lbl請求金額, 0)
        Me.Controls.SetChildIndex(Me.txt請求金額, 0)
        Me.Controls.SetChildIndex(Me.grp費用処理, 0)
        Me.Controls.SetChildIndex(Me.grp無償処理, 0)
        Me.Controls.SetChildIndex(Me.btn印刷, 0)
        Me.Controls.SetChildIndex(Me.grp未処理案件, 0)
        Me.Controls.SetChildIndex(Me.txt作業者, 0)
        Me.Controls.SetChildIndex(Me.lbl機械コード, 0)
        Me.Controls.SetChildIndex(Me.txt機械コード, 0)
        Me.Controls.SetChildIndex(Me.lb依頼コード, 0)
        Me.Controls.SetChildIndex(Me.cmb依頼コード, 0)
        Me.Controls.SetChildIndex(Me.lbl受付者, 0)
        Me.Controls.SetChildIndex(Me.cmb受付者, 0)
        Me.Controls.SetChildIndex(Me.lbl担当者, 0)
        Me.Controls.SetChildIndex(Me.cmb担当者, 0)
        Me.Controls.SetChildIndex(Me.cmb作業者, 0)
        Me.Controls.SetChildIndex(Me.txt訪問先担当者, 0)
        Me.Controls.SetChildIndex(Me.txt作業名称, 0)
        Me.Controls.SetChildIndex(Me.lbl作業名称, 0)
        Me.Controls.SetChildIndex(Me.Txt依頼元, 0)
        Me.Controls.SetChildIndex(Me.txt一般呼称, 0)
        Me.Controls.SetChildIndex(Me.txt依頼元担当者, 0)
        Me.Controls.SetChildIndex(Me.txt依頼元ID, 0)
        Me.Controls.SetChildIndex(Me.txtその他, 0)
        Me.Controls.SetChildIndex(Me.lblその他, 0)
        Me.Controls.SetChildIndex(Me.txt客先ID, 0)
        Me.Controls.SetChildIndex(Me.lbl訪問先担当者, 0)
        Me.Controls.SetChildIndex(Me.ibl客先ID, 0)
        Me.Controls.SetChildIndex(Me.lbl依頼元ID, 0)
        Me.Controls.SetChildIndex(Me.txt請求先, 0)
        Me.Controls.SetChildIndex(Me.txt請求先担当者, 0)
        Me.Controls.SetChildIndex(Me.txt請求先ID, 0)
        Me.Controls.SetChildIndex(Me.lbl請求先, 0)
        Me.Controls.SetChildIndex(Me.lbl請求先担当者, 0)
        Me.Controls.SetChildIndex(Me.txt依頼内容, 0)
        Me.Controls.SetChildIndex(Me.lbl依頼内容, 0)
        Me.Controls.SetChildIndex(Me.lbl入金確認, 0)
        Me.Controls.SetChildIndex(Me.grp添付書類, 0)
        Me.Controls.SetChildIndex(Me.btn受付日, 0)
        Me.Controls.SetChildIndex(Me.btn予定日, 0)
        Me.Controls.SetChildIndex(Me.btn竣工予定日, 0)
        Me.Controls.SetChildIndex(Me.btn完了日, 0)
        Me.Controls.SetChildIndex(Me.Label2, 0)
        Me.Controls.SetChildIndex(Me.chk入金確認, 0)
        Me.Controls.SetChildIndex(Me.dgv一覧, 0)
        Me.Controls.SetChildIndex(Me.btn登録, 0)
        Me.grp未処理案件.ResumeLayout(False)
        Me.grp未処理案件.PerformLayout()
        Me.grp添付書類.ResumeLayout(False)
        Me.grp添付書類.PerformLayout()
        Me.grp無償処理.ResumeLayout(False)
        Me.grp無償処理.PerformLayout()
        Me.grp費用処理.ResumeLayout(False)
        Me.grp費用処理.PerformLayout()
        CType(Me.dgv一覧, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents chk未写真 As CheckBox
    Friend WithEvents chk未点検表 As CheckBox
    Friend WithEvents chk様子確認 As CheckBox
    Friend WithEvents chk未データ As CheckBox
    Friend WithEvents chk点検表 As CheckBox
    Friend WithEvents chkデータ As CheckBox
    Friend WithEvents lblデータ As Label
    Friend WithEvents lblその他 As Label
    Friend WithEvents txtその他 As TextBox
    Friend WithEvents txt依頼元ID As TextBox
    Friend WithEvents txt依頼元担当者 As TextBox
    Friend WithEvents txt一般呼称 As TextBox
    Friend WithEvents Txt依頼元 As TextBox
    Friend WithEvents lbl作業名称 As Label
    Friend WithEvents txt作業名称 As TextBox
    Friend WithEvents txt訪問先担当者 As TextBox
    Private WithEvents cmb作業者 As ComboBox
    Friend WithEvents chk見積作成 As CheckBox
    Private WithEvents cmb担当者 As ComboBox
    Private WithEvents lbl担当者 As Label
    Private WithEvents cmb受付者 As ComboBox
    Private WithEvents lbl受付者 As Label
    Private WithEvents cmb依頼コード As ComboBox
    Private WithEvents lb依頼コード As Label
    Private WithEvents txt機械コード As TextBox
    Private WithEvents lbl機械コード As Label
    Private WithEvents txt作業者 As Label
    Friend WithEvents grp未処理案件 As GroupBox
    Friend WithEvents chk写真 As CheckBox
    Friend WithEvents btn印刷 As Button
    Friend WithEvents grp添付書類 As GroupBox
    Friend WithEvents grp無償処理 As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtクレーム As TextBox
    Friend WithEvents lblクレーム処理 As Label
    Friend WithEvents cmb営業処理 As ComboBox
    Friend WithEvents lbl営業処理 As Label
    Friend WithEvents grp費用処理 As GroupBox
    Friend WithEvents chk無償 As CheckBox
    Friend WithEvents lbl年間契約 As Label
    Friend WithEvents chk有償見 As CheckBox
    Friend WithEvents lbl有償見 As Label
    Friend WithEvents chk年間契約 As CheckBox
    Friend WithEvents lbl有償出 As Label
    Friend WithEvents chk有償出 As CheckBox
    Private WithEvents txt請求金額 As TextBox
    Friend WithEvents lbl請求金額 As Label
    Private WithEvents txt完了日 As TextBox
    Private WithEvents txt竣工予定日 As TextBox
    Private WithEvents lbl竣工予定日日 As Label
    Private WithEvents txt予定時間 As TextBox
    Private WithEvents lbl予定時間 As Label
    Private WithEvents txt予定日 As TextBox
    Private WithEvents lbl予定日 As Label
    Private WithEvents lbl契約内容 As Label
    Private WithEvents cmb契約番号 As ComboBox
    Private WithEvents lbl契約番号 As Label
    Private WithEvents chk契約物件 As CheckBox
    Private WithEvents txt契約内容 As TextBox
    Private WithEvents txt受付日 As TextBox
    Private WithEvents txt依頼書番号 As TextBox
    Private WithEvents txt受付番号 As TextBox
    Private WithEvents lbl契約物件 As Label
    Private WithEvents lbl受付日 As Label
    Private WithEvents lbl依頼者番号 As Label
    Private WithEvents lbl受付番号 As Label
    Friend WithEvents txt客先ID As TextBox
    Friend WithEvents lbl訪問先担当者 As Label
    Friend WithEvents ibl客先ID As Label
    Friend WithEvents lbl依頼元ID As Label
    Friend WithEvents lbl請求先担当者 As Label
    Friend WithEvents lbl請求先 As Label
    Friend WithEvents txt請求先ID As TextBox
    Friend WithEvents txt請求先担当者 As TextBox
    Friend WithEvents txt請求先 As TextBox
    Friend WithEvents lbl依頼内容 As Label
    Friend WithEvents txt依頼内容 As TextBox
    Private WithEvents lbl入金確認 As Label
    Private WithEvents lbl完了日 As Label
    Friend WithEvents btn受付日 As Button
    Friend WithEvents btn予定日 As Button
    Friend WithEvents btn竣工予定日 As Button
    Friend WithEvents btn完了日 As Button
    Friend WithEvents Label2 As Label
    Private WithEvents chk入金確認 As CheckBox
    Friend WithEvents dgv一覧 As DataGridView
    Friend WithEvents col受付番号 As DataGridViewTextBoxColumn
    Friend WithEvents col依頼書番号 As DataGridViewTextBoxColumn
    Friend WithEvents col請伝番号 As DataGridViewTextBoxColumn
    Friend WithEvents col受付日 As DataGridViewTextBoxColumn
    Friend WithEvents col受付者 As DataGridViewTextBoxColumn
    Friend WithEvents col担当者 As DataGridViewTextBoxColumn
    Friend WithEvents col作業者 As DataGridViewTextBoxColumn
    Friend WithEvents col客先ID As DataGridViewTextBoxColumn
    Friend WithEvents col一般呼称 As DataGridViewTextBoxColumn
    Friend WithEvents col訪問先担当者 As DataGridViewTextBoxColumn
    Friend WithEvents col完了 As DataGridViewTextBoxColumn
    Friend WithEvents col請求金額 As DataGridViewTextBoxColumn
    Friend WithEvents col請求完了日 As DataGridViewTextBoxColumn
    Friend WithEvents col竣工予定日 As DataGridViewTextBoxColumn
    Friend WithEvents col依頼内容 As DataGridViewTextBoxColumn
    Friend WithEvents col予定日 As DataGridViewTextBoxColumn
    Friend WithEvents col予定時間 As DataGridViewTextBoxColumn
    Friend WithEvents col契約物件 As DataGridViewTextBoxColumn
    Friend WithEvents col契約番号 As DataGridViewTextBoxColumn
    Friend WithEvents col契約内容 As DataGridViewTextBoxColumn
    Friend WithEvents col依頼元ID As DataGridViewTextBoxColumn
    Friend WithEvents col依頼元 As DataGridViewTextBoxColumn
    Friend WithEvents col依頼元担当者 As DataGridViewTextBoxColumn
    Friend WithEvents col請求先ID As DataGridViewTextBoxColumn
    Friend WithEvents col請求先 As DataGridViewTextBoxColumn
    Friend WithEvents col請求先担当者 As DataGridViewTextBoxColumn
    Friend WithEvents col機械コード As DataGridViewTextBoxColumn
    Friend WithEvents colその他 As DataGridViewTextBoxColumn
    Friend WithEvents col写真 As DataGridViewTextBoxColumn
    Friend WithEvents col点検表 As DataGridViewTextBoxColumn
    Friend WithEvents colデータ As DataGridViewTextBoxColumn
    Friend WithEvents col見積作成 As DataGridViewTextBoxColumn
    Friend WithEvents col様子確認 As DataGridViewTextBoxColumn
    Friend WithEvents col未写真 As DataGridViewTextBoxColumn
    Friend WithEvents col未点検表 As DataGridViewTextBoxColumn
    Friend WithEvents col未データ As DataGridViewTextBoxColumn
    Friend WithEvents col有償出 As DataGridViewTextBoxColumn
    Friend WithEvents col有償見 As DataGridViewTextBoxColumn
    Friend WithEvents col無償 As DataGridViewTextBoxColumn
    Friend WithEvents col年間契約 As DataGridViewTextBoxColumn
    Friend WithEvents col入金確認 As DataGridViewTextBoxColumn
    Friend WithEvents col営業処理 As DataGridViewTextBoxColumn
    Friend WithEvents colクレーム As DataGridViewTextBoxColumn
    Friend WithEvents btn登録 As Button
End Class
