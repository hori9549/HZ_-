<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmメニュー
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmメニュー))
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.tab依頼書 = New System.Windows.Forms.TabPage()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.btn依頼書登録 = New System.Windows.Forms.Button()
        Me.tabマスタ = New System.Windows.Forms.TabPage()
        Me.btn郵便番号取込 = New System.Windows.Forms.Button()
        Me.btn得意先マスタ = New System.Windows.Forms.Button()
        Me.btn社員マスタ = New System.Windows.Forms.Button()
        Me.btn区分管理マスタ = New System.Windows.Forms.Button()
        Me.btn環境設定 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblバージョン = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.TabControl1.SuspendLayout()
        Me.tab依頼書.SuspendLayout()
        Me.tabマスタ.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TabControl1.Controls.Add(Me.tab依頼書)
        Me.TabControl1.Controls.Add(Me.tabマスタ)
        Me.TabControl1.Location = New System.Drawing.Point(546, 15)
        Me.TabControl1.Margin = New System.Windows.Forms.Padding(4)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(975, 829)
        Me.TabControl1.TabIndex = 2
        '
        'tab依頼書
        '
        Me.tab依頼書.BackColor = System.Drawing.Color.Transparent
        Me.tab依頼書.Controls.Add(Me.Button4)
        Me.tab依頼書.Controls.Add(Me.Button3)
        Me.tab依頼書.Controls.Add(Me.Button2)
        Me.tab依頼書.Controls.Add(Me.Button1)
        Me.tab依頼書.Controls.Add(Me.btn依頼書登録)
        Me.tab依頼書.Location = New System.Drawing.Point(4, 34)
        Me.tab依頼書.Margin = New System.Windows.Forms.Padding(4)
        Me.tab依頼書.Name = "tab依頼書"
        Me.tab依頼書.Padding = New System.Windows.Forms.Padding(4)
        Me.tab依頼書.Size = New System.Drawing.Size(967, 791)
        Me.tab依頼書.TabIndex = 0
        Me.tab依頼書.Text = "依頼書"
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(333, 85)
        Me.Button4.Margin = New System.Windows.Forms.Padding(4)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(299, 57)
        Me.Button4.TabIndex = 4
        Me.Button4.Text = "購入手配登録"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(640, 85)
        Me.Button3.Margin = New System.Windows.Forms.Padding(4)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(299, 57)
        Me.Button3.TabIndex = 3
        Me.Button3.Text = "作業同期"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(26, 213)
        Me.Button2.Margin = New System.Windows.Forms.Padding(4)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(299, 57)
        Me.Button2.TabIndex = 2
        Me.Button2.Text = "依頼進捗確認"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(26, 85)
        Me.Button1.Margin = New System.Windows.Forms.Padding(4)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(299, 57)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "実績登録"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'btn依頼書登録
        '
        Me.btn依頼書登録.Location = New System.Drawing.Point(26, 20)
        Me.btn依頼書登録.Margin = New System.Windows.Forms.Padding(4)
        Me.btn依頼書登録.Name = "btn依頼書登録"
        Me.btn依頼書登録.Size = New System.Drawing.Size(299, 57)
        Me.btn依頼書登録.TabIndex = 0
        Me.btn依頼書登録.Text = "依頼書登録"
        Me.btn依頼書登録.UseVisualStyleBackColor = True
        '
        'tabマスタ
        '
        Me.tabマスタ.Controls.Add(Me.btn郵便番号取込)
        Me.tabマスタ.Controls.Add(Me.btn得意先マスタ)
        Me.tabマスタ.Controls.Add(Me.btn社員マスタ)
        Me.tabマスタ.Controls.Add(Me.btn区分管理マスタ)
        Me.tabマスタ.Controls.Add(Me.btn環境設定)
        Me.tabマスタ.Location = New System.Drawing.Point(4, 34)
        Me.tabマスタ.Margin = New System.Windows.Forms.Padding(4)
        Me.tabマスタ.Name = "tabマスタ"
        Me.tabマスタ.Size = New System.Drawing.Size(967, 791)
        Me.tabマスタ.TabIndex = 3
        Me.tabマスタ.Text = "マスタ"
        Me.tabマスタ.UseVisualStyleBackColor = True
        '
        'btn郵便番号取込
        '
        Me.btn郵便番号取込.Location = New System.Drawing.Point(640, 707)
        Me.btn郵便番号取込.Margin = New System.Windows.Forms.Padding(4)
        Me.btn郵便番号取込.Name = "btn郵便番号取込"
        Me.btn郵便番号取込.Size = New System.Drawing.Size(299, 57)
        Me.btn郵便番号取込.TabIndex = 9
        Me.btn郵便番号取込.Text = "郵便番号取込"
        Me.btn郵便番号取込.UseVisualStyleBackColor = True
        '
        'btn得意先マスタ
        '
        Me.btn得意先マスタ.Location = New System.Drawing.Point(333, 20)
        Me.btn得意先マスタ.Margin = New System.Windows.Forms.Padding(4)
        Me.btn得意先マスタ.Name = "btn得意先マスタ"
        Me.btn得意先マスタ.Size = New System.Drawing.Size(299, 57)
        Me.btn得意先マスタ.TabIndex = 8
        Me.btn得意先マスタ.Text = "企業マスタ"
        Me.btn得意先マスタ.UseVisualStyleBackColor = True
        '
        'btn社員マスタ
        '
        Me.btn社員マスタ.Location = New System.Drawing.Point(26, 20)
        Me.btn社員マスタ.Margin = New System.Windows.Forms.Padding(4)
        Me.btn社員マスタ.Name = "btn社員マスタ"
        Me.btn社員マスタ.Size = New System.Drawing.Size(299, 57)
        Me.btn社員マスタ.TabIndex = 0
        Me.btn社員マスタ.Text = "会員マスタ"
        Me.btn社員マスタ.UseVisualStyleBackColor = True
        '
        'btn区分管理マスタ
        '
        Me.btn区分管理マスタ.Location = New System.Drawing.Point(333, 707)
        Me.btn区分管理マスタ.Margin = New System.Windows.Forms.Padding(4)
        Me.btn区分管理マスタ.Name = "btn区分管理マスタ"
        Me.btn区分管理マスタ.Size = New System.Drawing.Size(299, 57)
        Me.btn区分管理マスタ.TabIndex = 7
        Me.btn区分管理マスタ.Text = "区分管理マスタ"
        Me.btn区分管理マスタ.UseVisualStyleBackColor = True
        '
        'btn環境設定
        '
        Me.btn環境設定.Location = New System.Drawing.Point(26, 707)
        Me.btn環境設定.Margin = New System.Windows.Forms.Padding(4)
        Me.btn環境設定.Name = "btn環境設定"
        Me.btn環境設定.Size = New System.Drawing.Size(299, 57)
        Me.btn環境設定.TabIndex = 6
        Me.btn環境設定.Text = "環境設定"
        Me.btn環境設定.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("MS UI Gothic", 26.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(82, 34)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(288, 44)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "HZ_カシオペイア"
        '
        'lblバージョン
        '
        Me.lblバージョン.AutoSize = True
        Me.lblバージョン.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblバージョン.Location = New System.Drawing.Point(216, 91)
        Me.lblバージョン.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblバージョン.Name = "lblバージョン"
        Me.lblバージョン.Size = New System.Drawing.Size(111, 24)
        Me.lblバージョン.TabIndex = 1
        Me.lblバージョン.Text = "ver 0.0.0.0"
        '
        'PictureBox1
        '
        Me.PictureBox1.InitialImage = CType(resources.GetObject("PictureBox1.InitialImage"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(16, 117)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(520, 505)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 105
        Me.PictureBox1.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.PictureBox2.Location = New System.Drawing.Point(38, 729)
        Me.PictureBox2.Margin = New System.Windows.Forms.Padding(4)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(366, 87)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox2.TabIndex = 106
        Me.PictureBox2.TabStop = False
        '
        'frmメニュー
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(13.0!, 24.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1539, 961)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblバージョン)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.TabControl1)
        Me.Margin = New System.Windows.Forms.Padding(6)
        Me.Name = "frmメニュー"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "I-SYSTEM"
        Me.Controls.SetChildIndex(Me.TabControl1, 0)
        Me.Controls.SetChildIndex(Me.PictureBox2, 0)
        Me.Controls.SetChildIndex(Me.PictureBox1, 0)
        Me.Controls.SetChildIndex(Me.lblバージョン, 0)
        Me.Controls.SetChildIndex(Me.Label1, 0)
        Me.TabControl1.ResumeLayout(False)
        Me.tab依頼書.ResumeLayout(False)
        Me.tabマスタ.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents tab依頼書 As TabPage
    Friend WithEvents btn依頼書登録 As Button
    Friend WithEvents tabマスタ As TabPage
    Friend WithEvents btn社員マスタ As Button
    Friend WithEvents btn区分管理マスタ As Button
    Friend WithEvents btn環境設定 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents lblバージョン As Label
    Public WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents btn得意先マスタ As Button
    Friend WithEvents btn郵便番号取込 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button3 As Button
End Class
