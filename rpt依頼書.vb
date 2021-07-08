Imports GrapeCity.ActiveReports
Imports GrapeCity.ActiveReports.Document

Public Class rpt依頼書
    ''プロパティ
    Private get依頼書 As DataTable
    Public WriteOnly Property 依頼書() As DataTable
        Set(ByVal value As DataTable)
            get依頼書 = value
        End Set
    End Property

    Private Sub rpt依頼書_DataInitialize(sender As Object, e As EventArgs) Handles Me.DataInitialize
        Fields.Add("受付番号")
        Fields.Add("依頼書番号")
        Fields.Add("請伝番号")
        Fields.Add("受付日")
        Fields.Add("受付者")
        Fields.Add("担当者")
        Fields.Add("作業者")
        Fields.Add("客先ID")
        Fields.Add("一般呼称")
        Fields.Add("訪問先担当者")
        Fields.Add("作業名称")
        Fields.Add("完了")
        Fields.Add("請求金額")
        Fields.Add("請求完了日")
        Fields.Add("竣工予定日")
        Fields.Add("依頼内容")
        Fields.Add("予定日")
        Fields.Add("予定時間")
        Fields.Add("契約物件")
        Fields.Add("契約番号")
        Fields.Add("契約内容")
        Fields.Add("依頼元ID")
        Fields.Add("依頼元")
        Fields.Add("依頼元担当者")
        Fields.Add("請求先ID")
        Fields.Add("請求先")
        Fields.Add("請求先担当者")
        Fields.Add("機械コード")
        Fields.Add("その他")
        Fields.Add("写真")
        Fields.Add("点検表")
        Fields.Add("データ")
        Fields.Add("見積作成")
        Fields.Add("様子確認")
        Fields.Add("未写真")
        Fields.Add("未点検表")
        Fields.Add("未データ")
        Fields.Add("有償出")
        Fields.Add("有償見")
        Fields.Add("無償")
        Fields.Add("年間契約")
        Fields.Add("入金確認")
        Fields.Add("営業処理")
        Fields.Add("クレーム")
    End Sub

    Private Sub rpt依頼書_FetchData(sender As Object, eArgs As FetchEventArgs) Handles Me.FetchData
        Static i_RowCount As Integer
        Dim ci As New System.Globalization.CultureInfo("ja-JP", False)
        ci.DateTimeFormat.Calendar = New System.Globalization.JapaneseCalendar()

        Try

            Me.Fields("受付番号").Value = get依頼書.Rows(i_RowCount)("受付番号")
            Me.Fields("依頼書番号").Value = get依頼書.Rows(i_RowCount)("依頼書番号")
            Me.Fields("請伝番号").Value = get依頼書.Rows(i_RowCount)("請伝番号")

            If get依頼書.Rows(i_RowCount)("受付日").ToString = "" Then
                Me.Fields("受付日").Value = ""
            Else
                Me.Fields("受付日").Value = CDate(get依頼書.Rows(i_RowCount)("受付日")).ToString("yyyy/MM/dd")
            End If

            Me.Fields("受付者").Value = get依頼書.Rows(i_RowCount)("受付者")
            Me.Fields("担当者").Value = get依頼書.Rows(i_RowCount)("担当者")
            Me.Fields("作業者").Value = get依頼書.Rows(i_RowCount)("作業者")
            Me.Fields("客先ID").Value = get依頼書.Rows(i_RowCount)("客先ID")
            Me.Fields("一般呼称").Value = get依頼書.Rows(i_RowCount)("一般呼称")
            Me.Fields("訪問先担当者").Value = get依頼書.Rows(i_RowCount)("訪問先担当者")
            Me.Fields("作業名称").Value = get依頼書.Rows(i_RowCount)("作業名称")
            Me.Fields("完了").Value = get依頼書.Rows(i_RowCount)("完了")
            Me.Fields("請求金額").Value = CDec(get依頼書.Rows(i_RowCount)("請求金額")).ToString("#,##0")
            If get依頼書.Rows(i_RowCount)("請求完了日").ToString = "" Then
                Me.Fields("請求完了日").Value = ""
            Else
                Me.Fields("請求完了日").Value = CDate(get依頼書.Rows(i_RowCount)("請求完了日")).ToString("yyyy/MM/dd")
            End If
            If get依頼書.Rows(i_RowCount)("竣工予定日").ToString = "" Then
                Me.Fields("竣工予定日").Value = ""
            Else
                Me.Fields("竣工予定日").Value = CDate(get依頼書.Rows(i_RowCount)("竣工予定日")).ToString("yyyy/MM/dd")
            End If

            Me.Fields("依頼内容").Value = get依頼書.Rows(i_RowCount)("依頼内容")

            If get依頼書.Rows(i_RowCount)("予定日").ToString = "" Then
                Me.Fields("予定日").Value = ""
            Else
                Me.Fields("予定日").Value = CDate(get依頼書.Rows(i_RowCount)("予定日")).ToString("yyyy/MM/dd")
            End If

            Me.Fields("予定時間").Value = get依頼書.Rows(i_RowCount)("予定時間")
            Me.Fields("契約物件").Value = get依頼書.Rows(i_RowCount)("契約物件")
            Me.Fields("契約番号").Value = get依頼書.Rows(i_RowCount)("契約番号")
            Me.Fields("契約内容").Value = get依頼書.Rows(i_RowCount)("契約内容")
            Me.Fields("依頼元ID").Value = get依頼書.Rows(i_RowCount)("依頼元ID")
            Me.Fields("依頼元").Value = get依頼書.Rows(i_RowCount)("依頼元")
            Me.Fields("依頼元担当者").Value = get依頼書.Rows(i_RowCount)("依頼元担当者")
            Me.Fields("請求先ID").Value = get依頼書.Rows(i_RowCount)("請求先ID")
            Me.Fields("請求先").Value = get依頼書.Rows(i_RowCount)("請求先")
            Me.Fields("請求先担当者").Value = get依頼書.Rows(i_RowCount)("請求先担当者")
            Me.Fields("機械コード").Value = get依頼書.Rows(i_RowCount)("機械コード")
            Me.Fields("その他").Value = get依頼書.Rows(i_RowCount)("その他")
            Me.Fields("写真").Value = get依頼書.Rows(i_RowCount)("写真")
            Me.Fields("点検表").Value = get依頼書.Rows(i_RowCount)("点検表")
            Me.Fields("データ").Value = get依頼書.Rows(i_RowCount)("データ")
            Me.Fields("見積作成").Value = get依頼書.Rows(i_RowCount)("見積作成")
            Me.Fields("様子確認").Value = get依頼書.Rows(i_RowCount)("様子確認")
            Me.Fields("未写真").Value = get依頼書.Rows(i_RowCount)("未写真")
            Me.Fields("未点検表").Value = get依頼書.Rows(i_RowCount)("未点検表")
            Me.Fields("未データ").Value = get依頼書.Rows(i_RowCount)("未データ")
            Me.Fields("有償出").Value = get依頼書.Rows(i_RowCount)("有償出")
            Me.Fields("有償見").Value = get依頼書.Rows(i_RowCount)("有償見")
            Me.Fields("無償").Value = get依頼書.Rows(i_RowCount)("無償")
            Me.Fields("年間契約").Value = get依頼書.Rows(i_RowCount)("年間契約")
            Me.Fields("入金確認").Value = get依頼書.Rows(i_RowCount)("入金確認")
            Me.Fields("営業処理").Value = get依頼書.Rows(i_RowCount)("営業処理")
            Me.Fields("クレーム").Value = get依頼書.Rows(i_RowCount)("クレーム")

            i_RowCount += 1

            eArgs.EOF = False
        Catch ex As Exception

            eArgs.EOF = True

        End Try
    End Sub
End Class
