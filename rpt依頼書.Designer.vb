<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class rpt依頼書
    Inherits GrapeCity.ActiveReports.SectionReport

    'フォームがコンポーネントの一覧をクリーンアップするために dispose をオーバーライドします。
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
        End If
        MyBase.Dispose(disposing)
    End Sub

    'メモ: 以下のプロシージャは ActiveReports デザイナーで必要です。
    'ActiveReports デザイナーを使用して変更できます。  
    'コード エディターを使って変更しないでください。
    Private WithEvents PageHeader As GrapeCity.ActiveReports.SectionReportModel.PageHeader
    Private WithEvents Detail As GrapeCity.ActiveReports.SectionReportModel.Detail
    Private WithEvents PageFooter As GrapeCity.ActiveReports.SectionReportModel.PageFooter
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(rpt依頼書))
        Me.PageHeader = New GrapeCity.ActiveReports.SectionReportModel.PageHeader()
        Me.Label1 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.txt受付番号 = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.Label2 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.Label3 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.txt受付者 = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.Label4 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.txt依頼書番号 = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.Label5 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.txt担当者 = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.Label6 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.txt受付日 = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.Label7 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.txt作業者 = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.Label8 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.txt訪問先 = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.txt一般呼称 = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.Label9 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.Label10 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.txt作業名称 = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.txt依頼内容 = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.chk契約番号 = New GrapeCity.ActiveReports.SectionReportModel.CheckBox()
        Me.Label11 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.Label12 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.txt契約番号 = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.Label13 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.txt契約内容 = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.Label14 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.txt機械コード = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.Label15 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.txt予定日 = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.txt竣工予定日 = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.Label16 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.txt請求完了日 = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.Label17 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.Label18 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.txtその他 = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.chk完了 = New GrapeCity.ActiveReports.SectionReportModel.CheckBox()
        Me.Label19 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.Label20 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.txt請求金額 = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.Label21 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.txt依頼元ID = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.txt依頼元 = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.Label22 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.txt請求先ID = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.txt請求先 = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.Label23 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.Label24 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.txt依頼元担当者 = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.txt請求先担当者 = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.chk写真 = New GrapeCity.ActiveReports.SectionReportModel.CheckBox()
        Me.chk未写真 = New GrapeCity.ActiveReports.SectionReportModel.CheckBox()
        Me.chk見積作成 = New GrapeCity.ActiveReports.SectionReportModel.CheckBox()
        Me.chk点検表 = New GrapeCity.ActiveReports.SectionReportModel.CheckBox()
        Me.chk未点検表 = New GrapeCity.ActiveReports.SectionReportModel.CheckBox()
        Me.chk様子確認 = New GrapeCity.ActiveReports.SectionReportModel.CheckBox()
        Me.chk運転データ = New GrapeCity.ActiveReports.SectionReportModel.CheckBox()
        Me.chk未データ = New GrapeCity.ActiveReports.SectionReportModel.CheckBox()
        Me.Detail = New GrapeCity.ActiveReports.SectionReportModel.Detail()
        Me.PageFooter = New GrapeCity.ActiveReports.SectionReportModel.PageFooter()
        Me.Shape1 = New GrapeCity.ActiveReports.SectionReportModel.Shape()
        Me.Shape2 = New GrapeCity.ActiveReports.SectionReportModel.Shape()
        Me.Shape3 = New GrapeCity.ActiveReports.SectionReportModel.Shape()
        Me.Shape4 = New GrapeCity.ActiveReports.SectionReportModel.Shape()
        Me.Shape5 = New GrapeCity.ActiveReports.SectionReportModel.Shape()
        Me.Label25 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.Label26 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.Label27 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.Label28 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.Label29 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.bar依頼書番号 = New GrapeCity.ActiveReports.SectionReportModel.Barcode()
        CType(Me.Label1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt受付番号, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt受付者, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt依頼書番号, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt担当者, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt受付日, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt作業者, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt訪問先, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt一般呼称, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label10, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt作業名称, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt依頼内容, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chk契約番号, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label11, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label12, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt契約番号, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label13, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt契約内容, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label14, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt機械コード, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label15, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt予定日, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt竣工予定日, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label16, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt請求完了日, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label17, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label18, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtその他, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chk完了, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label19, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label20, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt請求金額, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label21, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt依頼元ID, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt依頼元, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label22, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt請求先ID, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt請求先, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label23, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label24, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt依頼元担当者, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt請求先担当者, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chk写真, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chk未写真, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chk見積作成, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chk点検表, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chk未点検表, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chk様子確認, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chk運転データ, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chk未データ, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label25, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label26, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label27, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label28, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label29, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'PageHeader
        '
        Me.PageHeader.Controls.AddRange(New GrapeCity.ActiveReports.SectionReportModel.ARControl() {Me.Label12, Me.chk完了, Me.Label17, Me.txt請求完了日, Me.Label16, Me.txt竣工予定日, Me.txt予定日, Me.Label15, Me.Label14, Me.txt機械コード, Me.Label1, Me.txt受付番号, Me.Label2, Me.Label3, Me.txt受付者, Me.Label4, Me.txt依頼書番号, Me.Label5, Me.txt担当者, Me.Label6, Me.txt受付日, Me.Label7, Me.txt作業者, Me.Label8, Me.txt訪問先, Me.txt一般呼称, Me.Label9, Me.Label10, Me.txt作業名称, Me.txt依頼内容, Me.Label11, Me.txt契約番号, Me.Label13, Me.txt契約内容, Me.Label18, Me.txtその他, Me.Label19, Me.Label20, Me.txt請求金額, Me.Label21, Me.txt依頼元ID, Me.txt依頼元, Me.Label22, Me.txt請求先ID, Me.txt請求先, Me.Label23, Me.Label24, Me.txt依頼元担当者, Me.txt請求先担当者, Me.chk写真, Me.chk未写真, Me.chk見積作成, Me.chk点検表, Me.chk未点検表, Me.chk様子確認, Me.chk運転データ, Me.chk未データ, Me.chk契約番号, Me.bar依頼書番号})
        Me.PageHeader.Height = 3.71875!
        Me.PageHeader.Name = "PageHeader"
        '
        'Label1
        '
        Me.Label1.Border.BottomStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.Label1.Border.LeftStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.Label1.Border.RightStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.Label1.Border.TopStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.Label1.Height = 0.2!
        Me.Label1.HyperLink = Nothing
        Me.Label1.Left = 0!
        Me.Label1.Name = "Label1"
        Me.Label1.Style = "font-weight: bold; text-align: right; vertical-align: middle"
        Me.Label1.Text = "受付番号"
        Me.Label1.Top = 0.357!
        Me.Label1.Width = 1.0!
        '
        'txt受付番号
        '
        Me.txt受付番号.Border.BottomStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.txt受付番号.Border.LeftStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.txt受付番号.Border.RightStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.txt受付番号.Border.TopStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.txt受付番号.DataField = "受付番号"
        Me.txt受付番号.Height = 0.2!
        Me.txt受付番号.Left = 1.0!
        Me.txt受付番号.Name = "txt受付番号"
        Me.txt受付番号.Style = "vertical-align: middle"
        Me.txt受付番号.Text = Nothing
        Me.txt受付番号.Top = 0.357!
        Me.txt受付番号.Width = 1.0!
        '
        'Label2
        '
        Me.Label2.Height = 0.357!
        Me.Label2.HyperLink = Nothing
        Me.Label2.Left = 0!
        Me.Label2.Name = "Label2"
        Me.Label2.Style = "font-size: 20.25pt; font-weight: bold"
        Me.Label2.Text = "《作　業　依　頼　書》　"
        Me.Label2.Top = 0!
        Me.Label2.Width = 7.667!
        '
        'Label3
        '
        Me.Label3.Border.BottomStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.Label3.Border.LeftStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.Label3.Border.RightStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.Label3.Border.TopStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.Label3.Height = 0.2!
        Me.Label3.HyperLink = Nothing
        Me.Label3.Left = 2.0!
        Me.Label3.Name = "Label3"
        Me.Label3.Style = "font-weight: bold; text-align: right; vertical-align: middle"
        Me.Label3.Text = "受付者"
        Me.Label3.Top = 0.357!
        Me.Label3.Width = 1.0!
        '
        'txt受付者
        '
        Me.txt受付者.Border.BottomStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.txt受付者.Border.LeftStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.txt受付者.Border.RightStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.txt受付者.Border.TopStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.txt受付者.DataField = "受付者"
        Me.txt受付者.Height = 0.2!
        Me.txt受付者.Left = 3.0!
        Me.txt受付者.Name = "txt受付者"
        Me.txt受付者.Style = "vertical-align: middle"
        Me.txt受付者.Text = Nothing
        Me.txt受付者.Top = 0.357!
        Me.txt受付者.Width = 1.0!
        '
        'Label4
        '
        Me.Label4.Border.BottomStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.Label4.Border.LeftStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.Label4.Border.RightStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.Label4.Border.TopStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.Label4.Height = 0.2!
        Me.Label4.HyperLink = Nothing
        Me.Label4.Left = 0!
        Me.Label4.Name = "Label4"
        Me.Label4.Style = "font-weight: bold; text-align: right; vertical-align: middle"
        Me.Label4.Text = "依頼書番号"
        Me.Label4.Top = 0.5570001!
        Me.Label4.Width = 1.0!
        '
        'txt依頼書番号
        '
        Me.txt依頼書番号.Border.BottomStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.txt依頼書番号.Border.LeftStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.txt依頼書番号.Border.RightStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.txt依頼書番号.Border.TopStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.txt依頼書番号.DataField = "依頼書番号"
        Me.txt依頼書番号.Height = 0.2!
        Me.txt依頼書番号.Left = 1.0!
        Me.txt依頼書番号.Name = "txt依頼書番号"
        Me.txt依頼書番号.Style = "vertical-align: middle"
        Me.txt依頼書番号.Text = Nothing
        Me.txt依頼書番号.Top = 0.5570001!
        Me.txt依頼書番号.Width = 1.0!
        '
        'Label5
        '
        Me.Label5.Border.BottomStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.Label5.Border.LeftStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.Label5.Border.RightStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.Label5.Border.TopStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.Label5.Height = 0.2!
        Me.Label5.HyperLink = Nothing
        Me.Label5.Left = 2.0!
        Me.Label5.Name = "Label5"
        Me.Label5.Style = "font-weight: bold; text-align: right; vertical-align: middle"
        Me.Label5.Text = "担当者"
        Me.Label5.Top = 0.5570001!
        Me.Label5.Width = 1.0!
        '
        'txt担当者
        '
        Me.txt担当者.Border.BottomStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.txt担当者.Border.LeftStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.txt担当者.Border.RightStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.txt担当者.Border.TopStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.txt担当者.DataField = "担当者"
        Me.txt担当者.Height = 0.2!
        Me.txt担当者.Left = 3.0!
        Me.txt担当者.Name = "txt担当者"
        Me.txt担当者.Style = "vertical-align: middle"
        Me.txt担当者.Text = Nothing
        Me.txt担当者.Top = 0.5570001!
        Me.txt担当者.Width = 1.0!
        '
        'Label6
        '
        Me.Label6.Border.BottomStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.Label6.Border.LeftStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.Label6.Border.RightStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.Label6.Border.TopStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.Label6.Height = 0.2!
        Me.Label6.HyperLink = Nothing
        Me.Label6.Left = 0!
        Me.Label6.Name = "Label6"
        Me.Label6.Style = "font-weight: bold; text-align: right; vertical-align: middle"
        Me.Label6.Text = "受付日"
        Me.Label6.Top = 0.757!
        Me.Label6.Width = 1.0!
        '
        'txt受付日
        '
        Me.txt受付日.Border.BottomStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.txt受付日.Border.LeftStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.txt受付日.Border.RightStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.txt受付日.Border.TopStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.txt受付日.DataField = "受付日"
        Me.txt受付日.Height = 0.2!
        Me.txt受付日.Left = 1.0!
        Me.txt受付日.Name = "txt受付日"
        Me.txt受付日.Style = "vertical-align: middle"
        Me.txt受付日.Text = Nothing
        Me.txt受付日.Top = 0.757!
        Me.txt受付日.Width = 1.0!
        '
        'Label7
        '
        Me.Label7.Border.BottomStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.Label7.Border.LeftStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.Label7.Border.RightStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.Label7.Border.TopStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.Label7.Height = 0.2!
        Me.Label7.HyperLink = Nothing
        Me.Label7.Left = 2.0!
        Me.Label7.Name = "Label7"
        Me.Label7.Style = "font-weight: bold; text-align: right; vertical-align: middle"
        Me.Label7.Text = "作業者"
        Me.Label7.Top = 0.757!
        Me.Label7.Width = 1.0!
        '
        'txt作業者
        '
        Me.txt作業者.Border.BottomStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.txt作業者.Border.LeftStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.txt作業者.Border.RightStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.txt作業者.Border.TopStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.txt作業者.DataField = "作業者"
        Me.txt作業者.Height = 0.2!
        Me.txt作業者.Left = 3.0!
        Me.txt作業者.Name = "txt作業者"
        Me.txt作業者.Style = "vertical-align: middle"
        Me.txt作業者.Text = Nothing
        Me.txt作業者.Top = 0.757!
        Me.txt作業者.Width = 1.0!
        '
        'Label8
        '
        Me.Label8.Border.BottomStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.Label8.Border.LeftStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.Label8.Border.RightStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.Label8.Border.TopStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.Label8.Height = 0.2!
        Me.Label8.HyperLink = Nothing
        Me.Label8.Left = 4.089!
        Me.Label8.Name = "Label8"
        Me.Label8.Style = "font-weight: bold; text-align: right; vertical-align: middle"
        Me.Label8.Text = "訪問先"
        Me.Label8.Top = 0.357!
        Me.Label8.Width = 1.0!
        '
        'txt訪問先
        '
        Me.txt訪問先.Border.BottomStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.txt訪問先.Border.LeftStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.txt訪問先.Border.RightStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.txt訪問先.Border.TopStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.txt訪問先.DataField = "客先ID"
        Me.txt訪問先.Height = 0.2!
        Me.txt訪問先.Left = 5.089!
        Me.txt訪問先.Name = "txt訪問先"
        Me.txt訪問先.Style = "vertical-align: middle"
        Me.txt訪問先.Text = Nothing
        Me.txt訪問先.Top = 0.357!
        Me.txt訪問先.Width = 0.5100002!
        '
        'txt一般呼称
        '
        Me.txt一般呼称.Border.BottomStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.txt一般呼称.Border.LeftStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.txt一般呼称.Border.RightStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.txt一般呼称.Border.TopStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.txt一般呼称.DataField = "一般呼称"
        Me.txt一般呼称.Height = 0.2!
        Me.txt一般呼称.Left = 5.599!
        Me.txt一般呼称.Name = "txt一般呼称"
        Me.txt一般呼称.Style = "vertical-align: middle"
        Me.txt一般呼称.Text = Nothing
        Me.txt一般呼称.Top = 0.357!
        Me.txt一般呼称.Width = 2.067999!
        '
        'Label9
        '
        Me.Label9.Border.BottomStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.Label9.Border.LeftStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.Label9.Border.RightStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.Label9.Border.TopStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.Label9.Height = 0.2!
        Me.Label9.HyperLink = Nothing
        Me.Label9.Left = 4.089!
        Me.Label9.Name = "Label9"
        Me.Label9.Style = "font-weight: bold; text-align: right; vertical-align: middle"
        Me.Label9.Text = "作業名称"
        Me.Label9.Top = 0.5570001!
        Me.Label9.Width = 1.0!
        '
        'Label10
        '
        Me.Label10.Border.BottomStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.Label10.Border.LeftStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.Label10.Border.RightStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.Label10.Border.TopStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.Label10.Height = 0.2!
        Me.Label10.HyperLink = Nothing
        Me.Label10.Left = 4.089!
        Me.Label10.Name = "Label10"
        Me.Label10.Style = "font-weight: bold; text-align: right; vertical-align: middle"
        Me.Label10.Text = "依頼内容"
        Me.Label10.Top = 0.757!
        Me.Label10.Width = 1.0!
        '
        'txt作業名称
        '
        Me.txt作業名称.Border.BottomStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.txt作業名称.Border.LeftStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.txt作業名称.Border.RightStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.txt作業名称.Border.TopStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.txt作業名称.DataField = "作業名称"
        Me.txt作業名称.Height = 0.2!
        Me.txt作業名称.Left = 5.089!
        Me.txt作業名称.Name = "txt作業名称"
        Me.txt作業名称.Style = "vertical-align: middle"
        Me.txt作業名称.Text = Nothing
        Me.txt作業名称.Top = 0.5570001!
        Me.txt作業名称.Width = 2.578!
        '
        'txt依頼内容
        '
        Me.txt依頼内容.Border.BottomStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.txt依頼内容.Border.LeftStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.txt依頼内容.Border.RightStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.txt依頼内容.Border.TopStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.txt依頼内容.DataField = "依頼内容"
        Me.txt依頼内容.Height = 0.2!
        Me.txt依頼内容.Left = 5.089!
        Me.txt依頼内容.Name = "txt依頼内容"
        Me.txt依頼内容.Style = "vertical-align: middle"
        Me.txt依頼内容.Text = Nothing
        Me.txt依頼内容.Top = 0.757!
        Me.txt依頼内容.Width = 2.578!
        '
        'chk契約番号
        '
        Me.chk契約番号.DataField = "契約番号"
        Me.chk契約番号.Height = 0.2!
        Me.chk契約番号.Left = 1.0!
        Me.chk契約番号.Name = "chk契約番号"
        Me.chk契約番号.Style = ""
        Me.chk契約番号.Text = ""
        Me.chk契約番号.Top = 1.036!
        Me.chk契約番号.Width = 1.0!
        '
        'Label11
        '
        Me.Label11.Border.BottomStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.Label11.Border.LeftStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.Label11.Border.RightStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.Label11.Border.TopStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.Label11.Height = 0.2!
        Me.Label11.HyperLink = Nothing
        Me.Label11.Left = 0!
        Me.Label11.Name = "Label11"
        Me.Label11.Style = "font-weight: bold; text-align: right; vertical-align: middle"
        Me.Label11.Text = "契約物件"
        Me.Label11.Top = 1.036!
        Me.Label11.Width = 1.0!
        '
        'Label12
        '
        Me.Label12.Border.BottomStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.Label12.Border.LeftStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.Label12.Border.RightStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.Label12.Border.TopStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.Label12.Height = 0.2!
        Me.Label12.HyperLink = Nothing
        Me.Label12.Left = 1.0!
        Me.Label12.Name = "Label12"
        Me.Label12.Style = "font-weight: bold; text-align: right; vertical-align: middle"
        Me.Label12.Text = "契約番号"
        Me.Label12.Top = 1.036!
        Me.Label12.Width = 0.9999998!
        '
        'txt契約番号
        '
        Me.txt契約番号.Border.BottomStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.txt契約番号.Border.LeftStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.txt契約番号.Border.RightStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.txt契約番号.Border.TopStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.txt契約番号.DataField = "契約番号"
        Me.txt契約番号.Height = 0.2!
        Me.txt契約番号.Left = 2.0!
        Me.txt契約番号.Name = "txt契約番号"
        Me.txt契約番号.Style = "vertical-align: middle"
        Me.txt契約番号.Text = Nothing
        Me.txt契約番号.Top = 1.036!
        Me.txt契約番号.Width = 2.0!
        '
        'Label13
        '
        Me.Label13.Border.BottomStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.Label13.Border.LeftStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.Label13.Border.RightStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.Label13.Border.TopStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.Label13.Height = 0.2!
        Me.Label13.HyperLink = Nothing
        Me.Label13.Left = 0!
        Me.Label13.Name = "Label13"
        Me.Label13.Style = "font-weight: bold; text-align: right; vertical-align: middle"
        Me.Label13.Text = "契約内容"
        Me.Label13.Top = 1.236!
        Me.Label13.Width = 1.0!
        '
        'txt契約内容
        '
        Me.txt契約内容.Border.BottomStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.txt契約内容.Border.LeftStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.txt契約内容.Border.RightStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.txt契約内容.Border.TopStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.txt契約内容.DataField = "契約内容"
        Me.txt契約内容.Height = 0.2!
        Me.txt契約内容.Left = 1.0!
        Me.txt契約内容.Name = "txt契約内容"
        Me.txt契約内容.Style = "vertical-align: middle"
        Me.txt契約内容.Text = Nothing
        Me.txt契約内容.Top = 1.236!
        Me.txt契約内容.Width = 3.0!
        '
        'Label14
        '
        Me.Label14.Border.BottomStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.Label14.Border.LeftStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.Label14.Border.RightStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.Label14.Border.TopStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.Label14.Height = 0.2!
        Me.Label14.HyperLink = Nothing
        Me.Label14.Left = 0!
        Me.Label14.Name = "Label14"
        Me.Label14.Style = "font-weight: bold; text-align: right; vertical-align: middle"
        Me.Label14.Text = "機械コード"
        Me.Label14.Top = 1.525!
        Me.Label14.Width = 1.0!
        '
        'txt機械コード
        '
        Me.txt機械コード.Border.BottomStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.txt機械コード.Border.LeftStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.txt機械コード.Border.RightStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.txt機械コード.Border.TopStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.txt機械コード.DataField = "機械コード"
        Me.txt機械コード.Height = 0.2!
        Me.txt機械コード.Left = 1.0!
        Me.txt機械コード.Name = "txt機械コード"
        Me.txt機械コード.Style = "vertical-align: middle"
        Me.txt機械コード.Text = Nothing
        Me.txt機械コード.Top = 1.525!
        Me.txt機械コード.Width = 1.0!
        '
        'Label15
        '
        Me.Label15.Border.BottomStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.Label15.Border.LeftStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.Label15.Border.RightStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.Label15.Border.TopStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.Label15.Height = 0.2!
        Me.Label15.HyperLink = Nothing
        Me.Label15.Left = 0!
        Me.Label15.Name = "Label15"
        Me.Label15.Style = "font-weight: bold; text-align: right; vertical-align: middle"
        Me.Label15.Text = "予定日"
        Me.Label15.Top = 1.725!
        Me.Label15.Width = 1.0!
        '
        'txt予定日
        '
        Me.txt予定日.Border.BottomStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.txt予定日.Border.LeftStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.txt予定日.Border.RightStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.txt予定日.Border.TopStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.txt予定日.DataField = "予定日"
        Me.txt予定日.Height = 0.2!
        Me.txt予定日.Left = 1.0!
        Me.txt予定日.Name = "txt予定日"
        Me.txt予定日.Style = "vertical-align: middle"
        Me.txt予定日.Text = Nothing
        Me.txt予定日.Top = 1.725!
        Me.txt予定日.Width = 1.0!
        '
        'txt竣工予定日
        '
        Me.txt竣工予定日.Border.BottomStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.txt竣工予定日.Border.LeftStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.txt竣工予定日.Border.RightStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.txt竣工予定日.Border.TopStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.txt竣工予定日.DataField = "竣工予定日"
        Me.txt竣工予定日.Height = 0.2!
        Me.txt竣工予定日.Left = 3.0!
        Me.txt竣工予定日.Name = "txt竣工予定日"
        Me.txt竣工予定日.Style = "vertical-align: middle"
        Me.txt竣工予定日.Text = Nothing
        Me.txt竣工予定日.Top = 1.725!
        Me.txt竣工予定日.Width = 1.0!
        '
        'Label16
        '
        Me.Label16.Border.BottomStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.Label16.Border.LeftStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.Label16.Border.RightStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.Label16.Border.TopStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.Label16.Height = 0.2!
        Me.Label16.HyperLink = Nothing
        Me.Label16.Left = 2.0!
        Me.Label16.Name = "Label16"
        Me.Label16.Style = "font-weight: bold; text-align: right; vertical-align: middle"
        Me.Label16.Text = "竣工予定日"
        Me.Label16.Top = 1.725!
        Me.Label16.Width = 1.0!
        '
        'txt請求完了日
        '
        Me.txt請求完了日.Border.BottomStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.txt請求完了日.Border.LeftStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.txt請求完了日.Border.RightStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.txt請求完了日.Border.TopStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.txt請求完了日.DataField = "請求完了日"
        Me.txt請求完了日.Height = 0.2!
        Me.txt請求完了日.Left = 3.0!
        Me.txt請求完了日.Name = "txt請求完了日"
        Me.txt請求完了日.Style = "vertical-align: middle"
        Me.txt請求完了日.Text = Nothing
        Me.txt請求完了日.Top = 1.925!
        Me.txt請求完了日.Width = 1.0!
        '
        'Label17
        '
        Me.Label17.Border.BottomStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.Label17.Border.LeftStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.Label17.Border.RightStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.Label17.Border.TopStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.Label17.Height = 0.2!
        Me.Label17.HyperLink = Nothing
        Me.Label17.Left = 2.0!
        Me.Label17.Name = "Label17"
        Me.Label17.Style = "font-weight: bold; text-align: right; vertical-align: middle"
        Me.Label17.Text = "請求完了日"
        Me.Label17.Top = 1.925!
        Me.Label17.Width = 1.0!
        '
        'Label18
        '
        Me.Label18.Border.BottomStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.Label18.Border.LeftStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.Label18.Border.RightStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.Label18.Border.TopStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.Label18.Height = 1.089!
        Me.Label18.HyperLink = Nothing
        Me.Label18.Left = 4.089!
        Me.Label18.Name = "Label18"
        Me.Label18.Style = "font-weight: bold; text-align: right; vertical-align: top"
        Me.Label18.Text = "その他"
        Me.Label18.Top = 0.957!
        Me.Label18.Width = 1.0!
        '
        'txtその他
        '
        Me.txtその他.Border.BottomStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.txtその他.Border.LeftStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.txtその他.Border.RightStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.txtその他.Border.TopStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.txtその他.DataField = "その他"
        Me.txtその他.Height = 1.089!
        Me.txtその他.Left = 5.089!
        Me.txtその他.Name = "txtその他"
        Me.txtその他.Style = "vertical-align: middle"
        Me.txtその他.Text = Nothing
        Me.txtその他.Top = 0.957!
        Me.txtその他.Width = 2.578!
        '
        'chk完了
        '
        Me.chk完了.Border.BottomStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.chk完了.Border.LeftStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.chk完了.Border.RightStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.chk完了.Border.TopStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.chk完了.DataField = "完了"
        Me.chk完了.Height = 0.2!
        Me.chk完了.Left = 1.0!
        Me.chk完了.Name = "chk完了"
        Me.chk完了.Style = ""
        Me.chk完了.Text = ""
        Me.chk完了.Top = 1.925!
        Me.chk完了.Width = 1.0!
        '
        'Label19
        '
        Me.Label19.Border.BottomStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.Label19.Border.LeftStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.Label19.Border.RightStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.Label19.Border.TopStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.Label19.Height = 0.2!
        Me.Label19.HyperLink = Nothing
        Me.Label19.Left = 0!
        Me.Label19.Name = "Label19"
        Me.Label19.Style = "font-weight: bold; text-align: right; vertical-align: middle"
        Me.Label19.Text = "完了"
        Me.Label19.Top = 1.925!
        Me.Label19.Width = 1.0!
        '
        'Label20
        '
        Me.Label20.Border.BottomStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.Label20.Border.LeftStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.Label20.Border.RightStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.Label20.Border.TopStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.Label20.Height = 0.2!
        Me.Label20.HyperLink = Nothing
        Me.Label20.Left = 0!
        Me.Label20.Name = "Label20"
        Me.Label20.Style = "font-weight: bold; text-align: right; vertical-align: middle"
        Me.Label20.Text = "請求金額"
        Me.Label20.Top = 2.125!
        Me.Label20.Width = 1.0!
        '
        'txt請求金額
        '
        Me.txt請求金額.Border.BottomStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.txt請求金額.Border.LeftStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.txt請求金額.Border.RightStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.txt請求金額.Border.TopStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.txt請求金額.DataField = "請求金額"
        Me.txt請求金額.Height = 0.2!
        Me.txt請求金額.Left = 1.0!
        Me.txt請求金額.Name = "txt請求金額"
        Me.txt請求金額.Style = "vertical-align: middle"
        Me.txt請求金額.Text = Nothing
        Me.txt請求金額.Top = 2.125!
        Me.txt請求金額.Width = 1.0!
        '
        'Label21
        '
        Me.Label21.Border.BottomStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.Label21.Border.LeftStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.Label21.Border.RightStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.Label21.Border.TopStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.Label21.Height = 0.2!
        Me.Label21.HyperLink = Nothing
        Me.Label21.Left = 0!
        Me.Label21.Name = "Label21"
        Me.Label21.Style = "font-weight: bold; text-align: right; vertical-align: middle"
        Me.Label21.Text = "依頼元"
        Me.Label21.Top = 2.325!
        Me.Label21.Width = 1.0!
        '
        'txt依頼元ID
        '
        Me.txt依頼元ID.Border.BottomStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.txt依頼元ID.Border.LeftStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.txt依頼元ID.Border.RightStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.txt依頼元ID.Border.TopStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.txt依頼元ID.DataField = "依頼元ID"
        Me.txt依頼元ID.Height = 0.2!
        Me.txt依頼元ID.Left = 1.0!
        Me.txt依頼元ID.Name = "txt依頼元ID"
        Me.txt依頼元ID.Style = "vertical-align: middle"
        Me.txt依頼元ID.Text = Nothing
        Me.txt依頼元ID.Top = 2.325!
        Me.txt依頼元ID.Width = 0.5100002!
        '
        'txt依頼元
        '
        Me.txt依頼元.Border.BottomStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.txt依頼元.Border.LeftStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.txt依頼元.Border.RightStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.txt依頼元.Border.TopStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.txt依頼元.DataField = "依頼元"
        Me.txt依頼元.Height = 0.2!
        Me.txt依頼元.Left = 1.510001!
        Me.txt依頼元.Name = "txt依頼元"
        Me.txt依頼元.Style = "vertical-align: middle"
        Me.txt依頼元.Text = Nothing
        Me.txt依頼元.Top = 2.325!
        Me.txt依頼元.Width = 2.579!
        '
        'Label22
        '
        Me.Label22.Border.BottomStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.Label22.Border.LeftStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.Label22.Border.RightStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.Label22.Border.TopStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.Label22.Height = 0.2!
        Me.Label22.HyperLink = Nothing
        Me.Label22.Left = 0!
        Me.Label22.Name = "Label22"
        Me.Label22.Style = "font-weight: bold; text-align: right; vertical-align: middle"
        Me.Label22.Text = "請求先"
        Me.Label22.Top = 2.525!
        Me.Label22.Width = 1.0!
        '
        'txt請求先ID
        '
        Me.txt請求先ID.Border.BottomStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.txt請求先ID.Border.LeftStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.txt請求先ID.Border.RightStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.txt請求先ID.Border.TopStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.txt請求先ID.DataField = "請求先ID"
        Me.txt請求先ID.Height = 0.2!
        Me.txt請求先ID.Left = 1.0!
        Me.txt請求先ID.Name = "txt請求先ID"
        Me.txt請求先ID.Style = "vertical-align: middle"
        Me.txt請求先ID.Text = Nothing
        Me.txt請求先ID.Top = 2.525!
        Me.txt請求先ID.Width = 0.5100002!
        '
        'txt請求先
        '
        Me.txt請求先.Border.BottomStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.txt請求先.Border.LeftStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.txt請求先.Border.RightStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.txt請求先.Border.TopStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.txt請求先.DataField = "請求先"
        Me.txt請求先.Height = 0.2!
        Me.txt請求先.Left = 1.510001!
        Me.txt請求先.Name = "txt請求先"
        Me.txt請求先.Style = "vertical-align: middle"
        Me.txt請求先.Text = Nothing
        Me.txt請求先.Top = 2.525!
        Me.txt請求先.Width = 2.579!
        '
        'Label23
        '
        Me.Label23.Border.BottomStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.Label23.Border.LeftStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.Label23.Border.RightStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.Label23.Border.TopStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.Label23.Height = 0.2!
        Me.Label23.HyperLink = Nothing
        Me.Label23.Left = 4.089!
        Me.Label23.Name = "Label23"
        Me.Label23.Style = "font-weight: bold; text-align: right; vertical-align: middle"
        Me.Label23.Text = "担当者"
        Me.Label23.Top = 2.325!
        Me.Label23.Width = 1.0!
        '
        'Label24
        '
        Me.Label24.Border.BottomStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.Label24.Border.LeftStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.Label24.Border.RightStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.Label24.Border.TopStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.Label24.Height = 0.2!
        Me.Label24.HyperLink = Nothing
        Me.Label24.Left = 4.089!
        Me.Label24.Name = "Label24"
        Me.Label24.Style = "font-weight: bold; text-align: right; vertical-align: middle"
        Me.Label24.Text = "担当者"
        Me.Label24.Top = 2.525!
        Me.Label24.Width = 1.0!
        '
        'txt依頼元担当者
        '
        Me.txt依頼元担当者.Border.BottomStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.txt依頼元担当者.Border.LeftStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.txt依頼元担当者.Border.RightStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.txt依頼元担当者.Border.TopStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.txt依頼元担当者.DataField = "依頼元担当者"
        Me.txt依頼元担当者.Height = 0.2!
        Me.txt依頼元担当者.Left = 5.089!
        Me.txt依頼元担当者.Name = "txt依頼元担当者"
        Me.txt依頼元担当者.Style = "vertical-align: middle"
        Me.txt依頼元担当者.Text = Nothing
        Me.txt依頼元担当者.Top = 2.325!
        Me.txt依頼元担当者.Width = 1.0!
        '
        'txt請求先担当者
        '
        Me.txt請求先担当者.Border.BottomStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.txt請求先担当者.Border.LeftStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.txt請求先担当者.Border.RightStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.txt請求先担当者.Border.TopStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.txt請求先担当者.DataField = "請求先担当者"
        Me.txt請求先担当者.Height = 0.2!
        Me.txt請求先担当者.Left = 5.089!
        Me.txt請求先担当者.Name = "txt請求先担当者"
        Me.txt請求先担当者.Style = "vertical-align: middle"
        Me.txt請求先担当者.Text = Nothing
        Me.txt請求先担当者.Top = 2.525!
        Me.txt請求先担当者.Width = 1.0!
        '
        'chk写真
        '
        Me.chk写真.DataField = "写真"
        Me.chk写真.Height = 0.2!
        Me.chk写真.Left = 0!
        Me.chk写真.Name = "chk写真"
        Me.chk写真.Style = ""
        Me.chk写真.Text = "写真"
        Me.chk写真.Top = 2.78!
        Me.chk写真.Width = 1.0!
        '
        'chk未写真
        '
        Me.chk未写真.DataField = "未写真"
        Me.chk未写真.Height = 0.2!
        Me.chk未写真.Left = 1.0!
        Me.chk未写真.Name = "chk未写真"
        Me.chk未写真.Style = ""
        Me.chk未写真.Text = "未写真"
        Me.chk未写真.Top = 2.78!
        Me.chk未写真.Width = 1.0!
        '
        'chk見積作成
        '
        Me.chk見積作成.DataField = "見積作成"
        Me.chk見積作成.Height = 0.2!
        Me.chk見積作成.Left = 2.0!
        Me.chk見積作成.Name = "chk見積作成"
        Me.chk見積作成.Style = ""
        Me.chk見積作成.Text = "見積作成"
        Me.chk見積作成.Top = 2.78!
        Me.chk見積作成.Width = 1.0!
        '
        'chk点検表
        '
        Me.chk点検表.DataField = "点検表"
        Me.chk点検表.Height = 0.2!
        Me.chk点検表.Left = 0!
        Me.chk点検表.Name = "chk点検表"
        Me.chk点検表.Style = ""
        Me.chk点検表.Text = "点検表"
        Me.chk点検表.Top = 2.98!
        Me.chk点検表.Width = 1.0!
        '
        'chk未点検表
        '
        Me.chk未点検表.DataField = "未点検表"
        Me.chk未点検表.Height = 0.2!
        Me.chk未点検表.Left = 1.0!
        Me.chk未点検表.Name = "chk未点検表"
        Me.chk未点検表.Style = ""
        Me.chk未点検表.Text = "未点検表"
        Me.chk未点検表.Top = 2.98!
        Me.chk未点検表.Width = 1.0!
        '
        'chk様子確認
        '
        Me.chk様子確認.DataField = "様子確認"
        Me.chk様子確認.Height = 0.2!
        Me.chk様子確認.Left = 2.0!
        Me.chk様子確認.Name = "chk様子確認"
        Me.chk様子確認.Style = ""
        Me.chk様子確認.Text = "様子確認"
        Me.chk様子確認.Top = 2.98!
        Me.chk様子確認.Width = 1.0!
        '
        'chk運転データ
        '
        Me.chk運転データ.DataField = "運転データ"
        Me.chk運転データ.Height = 0.2!
        Me.chk運転データ.Left = 0!
        Me.chk運転データ.Name = "chk運転データ"
        Me.chk運転データ.Style = ""
        Me.chk運転データ.Text = "運転データ"
        Me.chk運転データ.Top = 3.18!
        Me.chk運転データ.Width = 1.0!
        '
        'chk未データ
        '
        Me.chk未データ.DataField = "未データ"
        Me.chk未データ.Height = 0.2!
        Me.chk未データ.Left = 1.0!
        Me.chk未データ.Name = "chk未データ"
        Me.chk未データ.Style = ""
        Me.chk未データ.Text = "未データ"
        Me.chk未データ.Top = 3.18!
        Me.chk未データ.Width = 1.0!
        '
        'Detail
        '
        Me.Detail.Height = 1.125!
        Me.Detail.Name = "Detail"
        '
        'PageFooter
        '
        Me.PageFooter.Controls.AddRange(New GrapeCity.ActiveReports.SectionReportModel.ARControl() {Me.Shape1, Me.Shape2, Me.Shape3, Me.Shape4, Me.Shape5, Me.Label25, Me.Label26, Me.Label27, Me.Label28, Me.Label29})
        Me.PageFooter.Height = 1.0!
        Me.PageFooter.Name = "PageFooter"
        '
        'Shape1
        '
        Me.Shape1.Height = 1.0!
        Me.Shape1.Left = 2.667001!
        Me.Shape1.Name = "Shape1"
        Me.Shape1.RoundingRadius = New GrapeCity.ActiveReports.Controls.CornersRadius(10.0!, Nothing, Nothing, Nothing, Nothing)
        Me.Shape1.Top = 0!
        Me.Shape1.Width = 1.0!
        '
        'Shape2
        '
        Me.Shape2.Height = 1.0!
        Me.Shape2.Left = 3.667!
        Me.Shape2.Name = "Shape2"
        Me.Shape2.RoundingRadius = New GrapeCity.ActiveReports.Controls.CornersRadius(10.0!, Nothing, Nothing, Nothing, Nothing)
        Me.Shape2.Top = 0!
        Me.Shape2.Width = 1.0!
        '
        'Shape3
        '
        Me.Shape3.Height = 1.0!
        Me.Shape3.Left = 4.667!
        Me.Shape3.Name = "Shape3"
        Me.Shape3.RoundingRadius = New GrapeCity.ActiveReports.Controls.CornersRadius(10.0!, Nothing, Nothing, Nothing, Nothing)
        Me.Shape3.Top = 0!
        Me.Shape3.Width = 1.0!
        '
        'Shape4
        '
        Me.Shape4.Height = 1.0!
        Me.Shape4.Left = 5.667!
        Me.Shape4.Name = "Shape4"
        Me.Shape4.RoundingRadius = New GrapeCity.ActiveReports.Controls.CornersRadius(10.0!, Nothing, Nothing, Nothing, Nothing)
        Me.Shape4.Top = 0!
        Me.Shape4.Width = 1.0!
        '
        'Shape5
        '
        Me.Shape5.Height = 1.0!
        Me.Shape5.Left = 6.667!
        Me.Shape5.Name = "Shape5"
        Me.Shape5.RoundingRadius = New GrapeCity.ActiveReports.Controls.CornersRadius(10.0!, Nothing, Nothing, Nothing, Nothing)
        Me.Shape5.Top = 0!
        Me.Shape5.Width = 1.0!
        '
        'Label25
        '
        Me.Label25.Height = 0.2!
        Me.Label25.HyperLink = Nothing
        Me.Label25.Left = 2.666999!
        Me.Label25.Name = "Label25"
        Me.Label25.Style = "text-align: center; vertical-align: middle"
        Me.Label25.Text = "受付責任者"
        Me.Label25.Top = 0!
        Me.Label25.Width = 1.0!
        '
        'Label26
        '
        Me.Label26.Height = 0.2!
        Me.Label26.HyperLink = Nothing
        Me.Label26.Left = 3.666999!
        Me.Label26.Name = "Label26"
        Me.Label26.Style = "text-align: center; vertical-align: middle"
        Me.Label26.Text = "作業者"
        Me.Label26.Top = 0!
        Me.Label26.Width = 1.0!
        '
        'Label27
        '
        Me.Label27.Height = 0.2!
        Me.Label27.HyperLink = Nothing
        Me.Label27.Left = 4.666999!
        Me.Label27.Name = "Label27"
        Me.Label27.Style = "text-align: center; vertical-align: middle"
        Me.Label27.Text = "担当者"
        Me.Label27.Top = 0!
        Me.Label27.Width = 1.0!
        '
        'Label28
        '
        Me.Label28.Height = 0.2!
        Me.Label28.HyperLink = Nothing
        Me.Label28.Left = 5.666999!
        Me.Label28.Name = "Label28"
        Me.Label28.Style = "text-align: center; vertical-align: middle"
        Me.Label28.Text = "部署責任者"
        Me.Label28.Top = 0!
        Me.Label28.Width = 1.0!
        '
        'Label29
        '
        Me.Label29.Height = 0.2!
        Me.Label29.HyperLink = Nothing
        Me.Label29.Left = 6.667!
        Me.Label29.Name = "Label29"
        Me.Label29.Style = "text-align: center; vertical-align: middle"
        Me.Label29.Text = "専務"
        Me.Label29.Top = 0!
        Me.Label29.Width = 1.0!
        '
        'bar依頼書番号
        '
        Me.bar依頼書番号.CaptionPosition = GrapeCity.ActiveReports.SectionReportModel.BarCodeCaptionPosition.Below
        Me.bar依頼書番号.DataField = "依頼書番号"
        Me.bar依頼書番号.Font = New System.Drawing.Font("Courier New", 8.0!)
        Me.bar依頼書番号.Height = 0.357!
        Me.bar依頼書番号.Left = 5.787!
        Me.bar依頼書番号.Name = "bar依頼書番号"
        Me.bar依頼書番号.QuietZoneBottom = 0!
        Me.bar依頼書番号.QuietZoneLeft = 0!
        Me.bar依頼書番号.QuietZoneRight = 0!
        Me.bar依頼書番号.QuietZoneTop = 0!
        Me.bar依頼書番号.Style = GrapeCity.ActiveReports.SectionReportModel.BarCodeStyle.Code39
        Me.bar依頼書番号.Text = "Barcode1"
        Me.bar依頼書番号.Top = 0!
        Me.bar依頼書番号.Width = 1.88!
        '
        'rpt依頼書
        '
        Me.MasterReport = False
        Me.PageSettings.DefaultPaperSize = False
        Me.PageSettings.Margins.Bottom = 0.2!
        Me.PageSettings.Margins.Left = 0.2!
        Me.PageSettings.Margins.Right = 0.2!
        Me.PageSettings.Margins.Top = 0.25!
        Me.PageSettings.Orientation = GrapeCity.ActiveReports.Document.Section.PageOrientation.Portrait
        Me.PageSettings.PaperHeight = 11.69291!
        Me.PageSettings.PaperKind = System.Drawing.Printing.PaperKind.A4
        Me.PageSettings.PaperWidth = 8.267716!
        Me.PrintWidth = 7.708751!
        Me.Sections.Add(Me.PageHeader)
        Me.Sections.Add(Me.Detail)
        Me.Sections.Add(Me.PageFooter)
        Me.StyleSheet.Add(New DDCssLib.StyleSheetRule("font-style: normal; text-decoration: none; font-weight: normal; font-size: 10pt; " &
            "color: Black; font-family: ""MS UI Gothic""; ddo-char-set: 128", "Normal"))
        Me.StyleSheet.Add(New DDCssLib.StyleSheetRule("font-size: 16pt; font-weight: bold; font-family: ""MS UI Gothic""; ddo-char-set: 12" &
            "8", "Heading1", "Normal"))
        Me.StyleSheet.Add(New DDCssLib.StyleSheetRule("font-size: 14pt; font-weight: bold; font-style: inherit; font-family: ""MS UI Goth" &
            "ic""; ddo-char-set: 128", "Heading2", "Normal"))
        Me.StyleSheet.Add(New DDCssLib.StyleSheetRule("font-size: 13pt; font-weight: bold; ddo-char-set: 128", "Heading3", "Normal"))
        CType(Me.Label1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt受付番号, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt受付者, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt依頼書番号, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt担当者, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt受付日, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt作業者, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt訪問先, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt一般呼称, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label10, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt作業名称, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt依頼内容, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chk契約番号, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label11, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label12, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt契約番号, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label13, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt契約内容, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label14, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt機械コード, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label15, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt予定日, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt竣工予定日, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label16, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt請求完了日, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label17, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label18, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtその他, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chk完了, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label19, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label20, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt請求金額, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label21, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt依頼元ID, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt依頼元, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label22, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt請求先ID, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt請求先, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label23, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label24, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt依頼元担当者, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt請求先担当者, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chk写真, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chk未写真, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chk見積作成, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chk点検表, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chk未点検表, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chk様子確認, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chk運転データ, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chk未データ, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label25, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label26, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label27, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label28, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label29, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub

    Private WithEvents Label1 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private WithEvents txt受付番号 As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private WithEvents Label2 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private WithEvents Label3 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private WithEvents txt受付者 As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private WithEvents Label4 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private WithEvents txt依頼書番号 As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private WithEvents Label5 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private WithEvents txt担当者 As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private WithEvents Label6 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private WithEvents txt受付日 As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private WithEvents Label7 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private WithEvents txt作業者 As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private WithEvents Label8 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private WithEvents txt訪問先 As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private WithEvents txt一般呼称 As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private WithEvents Label9 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private WithEvents Label10 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private WithEvents txt作業名称 As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private WithEvents txt依頼内容 As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private WithEvents chk契約番号 As GrapeCity.ActiveReports.SectionReportModel.CheckBox
    Private WithEvents Label11 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private WithEvents Label12 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private WithEvents txt契約番号 As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private WithEvents Label13 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private WithEvents txt契約内容 As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private WithEvents Label14 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private WithEvents txt機械コード As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private WithEvents Label15 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private WithEvents txt予定日 As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private WithEvents txt竣工予定日 As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private WithEvents Label16 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private WithEvents txt請求完了日 As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private WithEvents Label17 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private WithEvents Label18 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private WithEvents txtその他 As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private WithEvents chk完了 As GrapeCity.ActiveReports.SectionReportModel.CheckBox
    Private WithEvents Label19 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private WithEvents Label20 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private WithEvents txt請求金額 As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private WithEvents Label21 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private WithEvents txt依頼元ID As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private WithEvents txt依頼元 As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private WithEvents Label22 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private WithEvents txt請求先ID As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private WithEvents txt請求先 As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private WithEvents Label23 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private WithEvents Label24 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private WithEvents txt依頼元担当者 As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private WithEvents txt請求先担当者 As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private WithEvents chk写真 As GrapeCity.ActiveReports.SectionReportModel.CheckBox
    Private WithEvents chk未写真 As GrapeCity.ActiveReports.SectionReportModel.CheckBox
    Private WithEvents chk見積作成 As GrapeCity.ActiveReports.SectionReportModel.CheckBox
    Private WithEvents chk点検表 As GrapeCity.ActiveReports.SectionReportModel.CheckBox
    Private WithEvents chk未点検表 As GrapeCity.ActiveReports.SectionReportModel.CheckBox
    Private WithEvents chk様子確認 As GrapeCity.ActiveReports.SectionReportModel.CheckBox
    Private WithEvents chk運転データ As GrapeCity.ActiveReports.SectionReportModel.CheckBox
    Private WithEvents chk未データ As GrapeCity.ActiveReports.SectionReportModel.CheckBox
    Private WithEvents Shape1 As GrapeCity.ActiveReports.SectionReportModel.Shape
    Private WithEvents Shape2 As GrapeCity.ActiveReports.SectionReportModel.Shape
    Private WithEvents Shape3 As GrapeCity.ActiveReports.SectionReportModel.Shape
    Private WithEvents Shape4 As GrapeCity.ActiveReports.SectionReportModel.Shape
    Private WithEvents Shape5 As GrapeCity.ActiveReports.SectionReportModel.Shape
    Private WithEvents Label25 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private WithEvents Label26 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private WithEvents Label27 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private WithEvents Label28 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private WithEvents Label29 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private WithEvents bar依頼書番号 As GrapeCity.ActiveReports.SectionReportModel.Barcode
End Class
