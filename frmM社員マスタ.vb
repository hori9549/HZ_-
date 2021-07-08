''--2020/08/14  堀内良幸
Imports System.Data
Imports System.Data.SqlClient
Public Class frmM社員マスタ
    Private msSQL As String
    Private mCommand As SqlCommand
    Private mSDA As New SqlDataAdapter
    Private dtbl社員マスタ As New DataTable


    Private Sub 社員マスター_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call subクリア()

        dtbl社員マスタ = dtbl社員取得()
        dgv一覧.DataSource = dtbl社員マスタ

        Dim sid As Integer = 社員ID最大取得()
        txt社員ID.Text = sid.ToString("0000")
    End Sub

    Private Function dtbl社員取得() As DataTable
        Dim cDB As New clsDB
        Dim getデータ As New DataTable

        '表示
        msSQL = "SELECT * FROM MST_社員 "
        msSQL += "ORDER BY 退社月日,社員ID"

        mCommand = cDB.getsqlComand(msSQL)
        mSDA.SelectCommand = mCommand

        Call mSDA.Fill(getデータ) ''データセット作成
        Return getデータ

    End Function

    Private Sub btn入社月日_Click(sender As Object, e As EventArgs) Handles btn入社月日.Click
        Dim sfrm As New sfrm日付選択
        Call sfrm.ShowDialog()
        txt入社月日.Text = sfrm.日付
    End Sub

    Private Sub btn退社月日_Click(sender As Object, e As EventArgs) Handles btn退社月日.Click
        Dim sfrm As New sfrm日付選択
        Call sfrm.ShowDialog()
        txt退社月日.Text = sfrm.日付
    End Sub

    Private Sub dgv一覧_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv一覧.CellClick
        If e.RowIndex < 0 Then Exit Sub
        If e.ColumnIndex < 0 Then Exit Sub

        'IDを取得
        Dim selID As String
        selID = dgv一覧.Rows(e.RowIndex).Cells("colID").Value.ToString

        '取得したIDを持つレコードを取り出す
        Dim cDB As New clsDB
        Dim dtblSelectData As New DataTable

        msSQL = "select * FROM MST_社員 "
        msSQL += "where ID=　" & "'" & selID & "'"

        mCommand = cDB.getsqlComand(msSQL)
        mSDA.SelectCommand = mCommand

        Call mSDA.Fill(dtblSelectData) ''データセット作成
        With dtblSelectData.Rows(0)
            txt社員ID.Text = Trim(.Item("社員ID").ToString)
            txt氏名.Text = Trim(.Item("氏名").ToString)
            txt技能ランク.Text = Trim(.Item("技能ランク").ToString)
            txtふりがな.Text = Trim(.Item("ふりがな").ToString)
            If .Item("入社月日").ToString = "" Then
                txt入社月日.Text = ""
            Else
                txt入社月日.Text = CDate(.Item("入社月日")).ToString("yyyy/MM/dd")
            End If

            txt職種コード.Text = Trim(.Item("職種コード").ToString)
            txt権限コード.Text = Trim(.Item("権限コード").ToString)
            txt所属部.Text = Trim(.Item("所属部").ToString)
            txt所属課.Text = Trim(.Item("所属課").ToString)
            txt役職.Text = Trim(.Item("役職").ToString)

            ''----NULL条件演算子(?.)を使ったCode-------------
            Dim td As String = .Item("退社月日")?.ToString
            'If td.va Then

            'End If
            ''----------------------------------------------------

            ''----NULL条件演算子(?.)をつかわないCode-------------
            'If .Item("退社月日").ToString = "" Then
            '    txt退社月日.Text = ""
            'Else
            '    txt退社月日.Text = CDate(.Item("退社月日")).ToString("yyyy/MM/dd")
            'End If
            '----------------------------------------------------

            txt電話番号.Text = Trim(.Item("電話番号").ToString)
            txt郵便番号.Text = Trim(.Item("郵便番号").ToString())

            ''[住所]が存在する場合
            ''[住所]がなくて[都道府県]が存在する場合で表示元が異なる
            ''[住所],[都道府県]ともにない場合
            If .Item("住所").ToString.Length > 0 Then
                txt住所.Text = Trim(.Item("住所").ToString)
            Else
                If .Item("都道府県").ToString.Length > 0 Then
                    txt住所.Text = Trim(.Item("都道府県").ToString) &
                        Trim(.Item("市区郡").ToString) &
                                                Trim(.Item("町村域").ToString) &
                        Trim(.Item("建物").ToString)
                Else
                    txt住所.Text = ""
                End If
            End If

            txt略歴.Text = Trim(.Item("略歴").ToString)
        End With
    End Sub

    Private Sub btnクリア_Click(sender As Object, e As EventArgs) Handles btnクリア.Click
        Call subクリア()

        Dim sid As Integer = 社員ID最大取得()
        txt社員ID.Text = sid.ToString("0000")

        ' txt社員ID.Text = 社員ID最大取得()
    End Sub

    Private Sub subクリア()
        txt社員ID.Text = ""
        txt氏名.Text = ""
        txt技能ランク.Text = ""
        txtふりがな.Text = ""
        txt入社月日.Text = ""
        txt職種コード.Text = ""
        txt権限コード.Text = ""
        txt所属部.Text = ""
        txt所属課.Text = ""
        txt役職.Text = ""
        txt退社月日.Text = ""
        txt電話番号.Text = ""
        txt郵便番号.Text = ""
        txt住所.Text = ""
        txt略歴.Text = ""
    End Sub

    Private Sub dgv一覧_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles dgv一覧.CellFormatting
        Dim strStatus As String
        Dim setColor As Color

        If e.RowIndex >= 0 Then
            ''MsgBox(dgv_ASSYList.Rows(e.RowIndex).Cells(0).Value)
            strStatus = dgv一覧.Rows(e.RowIndex).Cells("col退社月日").Value.ToString  ''連番情報取得

            Select Case strStatus
                Case <> "" ''欠品
                    setColor = Color.LightGray
            End Select

            If strStatus <> "" Then
                Dim i_RowCount As Integer
                For i_RowCount = 0 To dgv一覧.ColumnCount - 1
                    dgv一覧.Rows(e.RowIndex).Cells(i_RowCount).Style.BackColor = setColor

                Next
            End If
        End If
    End Sub
    '
    ' 機能      : 社員ID（ID)の最大数を取得する
    '
    ' 返り値    : 最大数に１を加算する
    '
    ' 機能説明  : 
    '
    ' 備考      : 
    '
    Private Function 社員ID最大取得() As Integer
        Dim cDB As New clsDB
        Dim msSQL As String
        Dim myTable As New DataTable

        msSQL = " SELECT * FROM MST_社員"
        msSQL += " ORDER BY 社員ID DESC"

        mCommand = cDB.getsqlComand(msSQL)
        mSDA.SelectCommand = mCommand

        Call mSDA.Fill(myTable) ''データセット作成

        If myTable.Rows.Count = 0 Then
            Return 1

        Else
            Return myTable.Rows(0).Item("社員ID") + 1
            ' Return myTable.Rows(0)("ID") + 1

        End If

        Call cDB.Close()
    End Function

    Private Sub btn登録_Click(sender As Object, e As EventArgs) Handles btn登録.Click
        Dim cDB As New clsDB
        Dim msSQL As String
        Dim myTable As New DataTable
        ''氏名入力は必須
        With txt氏名
            Select Case .Text
                Case ""
                    MessageBox.Show("氏名は必須入力項目です", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Call .Focus()
                    Exit Sub
                Case Else
            End Select
        End With
        ''入社月日は必須、日付として正しいか
        With txt入社月日
            Select Case .Text
                Case ""
                    MessageBox.Show("入社月日は必須項目です", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Call .Focus()
                    Exit Sub
                Case Else
                    Dim str As String = .Text
                    Dim dt As DateTime
                    If DateTime.TryParse(str, dt) Then
                        .Text = dt.ToString("yyyy / MM / dd")
                    Else
                        MessageBox.Show("入社月日の入力が正しくありません", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error)

                        Call .Focus()
                        Exit Sub
                    End If
            End Select
        End With
        ''存在チェック
        msSQL = " SELECT * FROM MST_社員"
        msSQL += " WHERE  社員ID = " & txt社員ID.Text

        mCommand = cDB.getsqlComand(msSQL)
        mSDA.SelectCommand = mCommand

        Call mSDA.Fill(myTable) ''データセット作成

        If myTable.Rows.Count = 0 Then

            ''新規追加
            msSQL = " INSERT INTO MST_社員 ("
            '   msSQL += "ID,"
            msSQL += "社員ID"
            msSQL += ",氏名"
            msSQL += ",技能ランク"
            msSQL += ",フリガナ"
            msSQL += ",入社月日"
            msSQL += ",職種コード"
            msSQL += ",権限コード"
            msSQL += ",所属部"
            msSQL += ",所属課"
            msSQL += ",役職"
            msSQL += ",退社月日"
            msSQL += ",郵便番号"
            msSQL += ",住所"
            msSQL += ",略歴"
            msSQL += " )"
            msSQL += " VALUES("
            msSQL += "'" & Trim(txt社員ID.Text) & " ',"
            '  msSQL += "null,"
            msSQL += "'" & Trim(txt氏名.Text) & " ',"
            msSQL += "'" & Trim(txt技能ランク.Text) & " ',"
            msSQL += "'" & Trim(txtふりがな.Text) & " ',"
            msSQL += "'" & Trim(txt入社月日.Text) & " ',"
            msSQL += "'" & Trim(txt職種コード.Text) & " ',"
            msSQL += "'" & Trim(txt権限コード.Text) & " ',"
            msSQL += "'" & Trim(txt所属部.Text) & " ',"
            msSQL += "'" & Trim(txt所属課.Text) & " ',"
            msSQL += "'" & Trim(txt役職.Text) & " ',"
            If txt退社月日.Text = "" Then
                msSQL += "NULL,"
            Else
                msSQL += "'" & Trim(txt退社月日.Text) & " ',"

            End If
            msSQL += "'" & Trim(txt郵便番号.Text) & " ',"
            msSQL += "'" & Trim(txt住所.Text) & " ',"
            msSQL += "'" & Trim(txt略歴.Text) & " '"
            msSQL += ")"

        Else

            ''更新
            msSQL = " UPDATE MST_社員 SET "
            ' msSQL += " 社員ID = '" & Trim(txt社員ID.Text) & "'"
            ' msSQL += "社員ID = null"
            msSQL += "氏名 = '" & Trim(txt氏名.Text) & "'"
            msSQL += ",技能ランク = '" & Trim(txt技能ランク.Text) & "'"
            msSQL += ",フリガナ = '" & Trim(txtふりがな.Text) & "'"
            msSQL += ",入社月日 = '" & Trim(txt入社月日.Text) & "'"
            msSQL += ",職種コード = '" & Trim(txt職種コード.Text) & "'"
            msSQL += ",権限コード = '" & Trim(txt権限コード.Text) & "'"
            msSQL += ",所属部 = '" & Trim(txt所属部.Text) & "'"
            msSQL += ",所属課 = '" & Trim(txt所属課.Text) & "'"
            msSQL += ",役職 = '" & Trim(txt役職.Text) & "'"
            If txt退社月日.Text = "" Then
                msSQL += ",退社月日 =NULL"
            Else
                msSQL += ",退社月日 = '" & Trim(txt退社月日.Text) & "'"
            End If
            msSQL += ",電話番号 = '" & Trim(txt電話番号.Text) & "'"
            msSQL += ",郵便番号 = '" & Trim(txt郵便番号.Text) & "'"
            msSQL += ",住所 = '" & Trim(txt住所.Text) & "'"
            msSQL += ",略歴 = '" & Trim(txt略歴.Text) & "'"

            msSQL += " WHERE 社員ID = "
            msSQL += txt社員ID.Text

        End If
        mCommand = cDB.getsqlComand(msSQL)
        Call mCommand.ExecuteNonQuery()

        ''クリア
        Call subクリア()
        ''再表示
        dtbl社員マスタ = dtbl社員取得()
        dgv一覧.DataSource = dtbl社員マスタ
        txt社員ID.Text = 社員ID最大取得()

        Call txt社員ID.Focus()
        Call cDB.Close()

    End Sub

    Private Sub btn取得_Click(sender As Object, e As EventArgs) Handles btn取得.Click
        Dim subForm As New sfrm住所検索
        subForm.検索郵便 = txt郵便番号.Text
        Call subForm.ShowDialog()

        txt郵便番号.Text = subForm.検索郵便
        txt住所.Text = subForm.検索住所

        ''Call txt住所.Select(0, Len(txt住所.Text))

    End Sub

End Class