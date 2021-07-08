Imports System.Data
Imports System.Data.SqlClient

Public Class FrmM得意先
    Private msSQL As String
    Private mCommand As SqlCommand
    Private mSDA As New SqlDataAdapter
    Private dtbl得意先一覧 As New DataTable

    Private Sub 客先総括台帳_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call subクリア()

        dtbl得意先一覧 = dtbl得意先取得()
        dgv一覧.DataSource = dtbl得意先一覧

        Dim kid As Integer = 客先ID最大取得()
        txt企業ID.Text = kid.ToString("0000")

        ' txt基番.Text = 客先基番最大取得()
    End Sub

    Private Function dtbl得意先取得() As DataTable
        Dim cDB As New clsDB
        Dim getTable As New DataTable

        '表示
        msSQL = "SELECT * FROM MST_企業項目"
        '  msSQL += " ORDER BY 抹消月日"

        mCommand = cDB.getsqlComand(msSQL)
        mSDA.SelectCommand = mCommand

        Call mSDA.Fill(getTable) ''データセット作成
        Return getTable

    End Function

    Private Sub dgv一覧_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv一覧.CellClick
        If e.RowIndex < 0 Then Exit Sub
        If e.ColumnIndex < 0 Then Exit Sub

        With dgv一覧.Rows(e.RowIndex)
            txtID.Text = Trim(.Cells("ID").Value.ToString)
            txt企業ID.Text = Trim(.Cells("企業ID").Value.ToString)
            ' txt一般呼称.Text = dgv一覧.Rows(e.RowIndex).Cells("").Value.ToString
            Txtふりがな.Text = Trim(.Cells("フリガナ").Value.ToString)
            txt企業名.Text = Trim(.Cells("企業名").Value.ToString)

            txt代表者名.Text = Trim(.Cells("col法人名").Value.ToString)
            Txt支店名.Text = Trim(.Cells("col所轄").Value.ToString)

            TxtTEL.Text = Trim(.Cells("col電話番号").Value.ToString)
            txtFax.Text = Trim(.Cells("colFAX番号").Value.ToString)
            Txt郵便番号.Text = Trim(.Cells("col郵便番号").Value.ToString)
            txt住所.Text = Trim(.Cells("col都道府県").Value.ToString +
                .Cells("col市区郡").Value.ToString +
                .Cells("col町村域").Value.ToString +
                .Cells("col建物").Value.ToString)

            txt担当者名.Text = Trim(.Cells("col地域区分").Value.ToString)

            '  If String.IsNullOrEmpty(.Cells("col抹消月日").ToString) Then
            '    'If .Cells("col抹消月日").ToString Is Nothing Then
            'If .Cells("col抹消").Value = True Then
            '    MsgBox("抹消ON")
            'Else
            '    MsgBox("抹消OFF")
            'End If
            If .Cells("col抹消月日").Value.ToString = "" Then
                txt登録日.Text = ""
            Else
                'Dim dt As Date = .Cells("col抹消月日").Value.ToString
                'txt抹消月日.Text = dt.ToString("yyyy/MM/dd")
                'End If

                txt登録日.Text = Trim(.Cells("col抹消月日").Value.ToString)
                ' MsgBox(Trim(.Cells("col抹消月日").Value.ToString))
                '     txt抹消月日.Text = Trim(.Cells("col抹消月日").Value.ToString("yyyy/MM/dd"))
            End If

            txt備考.Text = Trim(.Cells("col経歴").Value.ToString)

            ' Txt未収金額.Text = Trim(Format(.Cells("col未収金額").Value.ToString, "#,##0"))
            '       Txt未収金額.Text = Trim(.Cells("col未収金額").Value.ToString())

        End With
    End Sub

    Private Sub dgv一覧_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles dgv一覧.CellFormatting
        'Dim strStatus As String
        'Dim setColor As Color

        'If e.RowIndex >= 0 Then
        '    strStatus = dgv一覧.Rows(e.RowIndex).Cells("col抹消月日").Value.ToString  ''連番情報取得

        '    Select Case strStatus
        '        Case <> ""
        '            setColor = Color.LightGray
        '    End Select

        '    If strStatus <> "" Then
        '        Dim i_RowCount As Integer
        '        For i_RowCount = 0 To dgv一覧.ColumnCount - 1
        '            dgv一覧.Rows(e.RowIndex).Cells(i_RowCount).Style.BackColor = setColor

        '        Next
        '    End If
        'End If
    End Sub

    Private Sub btn抹消月日_Click(sender As Object, e As EventArgs) Handles btn登録日追加.Click
        Dim sfrm As New sfrm日付選択
        Call sfrm.ShowDialog()
        txt登録日.Text = sfrm.日付
    End Sub

    Private Sub btnクリア_Click(sender As Object, e As EventArgs) Handles btnクリア.Click
        Call subクリア()

        Dim kid As Integer = 客先ID最大取得()
        txt企業ID.Text = kid.ToString("0000")

        ' txt基番.Text = 客先基番最大取得()
    End Sub

    Private Sub subクリア()
        txtID.Text = ""
        txt企業ID.Text = ""
        Txtふりがな.Text = ""
        '  Txt前組織.Text = ""
        txt企業名.Text = ""
        '  Txt後組織.Text = ""
        Txt支店名.Text = ""
        TxtTEL.Text = ""
        txtFax.Text = ""
        Txt郵便番号.Text = ""
        txt住所.Text = ""
        txt担当者名.Text = ""
        txt登録日.Text = ""
        txt備考.Text = ""
        '   Txt未収金額.Text = ""
        txtメルアド.Text = ""
        txt代表者名.Text = ""

    End Sub
    '
    ' 機能      : 客先ID（ID)の最大数を取得する
    '
    ' 返り値    : 最大数に１を加算する
    '
    ' 機能説明  : 
    '
    ' 備考      : 
    '
    Private Function 客先ID最大取得() As Integer
        Dim cDB As New clsDB
        Dim msSQL As String
        Dim myTable As New DataTable

        msSQL = " SELECT * FROM MST_企業項目 "
        msSQL += " ORDER BY 企業ID DESC "

        mCommand = cDB.getsqlComand(msSQL)
        mSDA.SelectCommand = mCommand

        Call mSDA.Fill(myTable) ''データセット作成

        If myTable.Rows.Count = 0 Then
            Return 1

        Else
            Return myTable.Rows(0).Item("企業ID") + 1
            ' Return myTable.Rows(0)("ID") + 1

        End If

        Call cDB.Close()
    End Function
    'Private Function 客先基番最大取得() As Integer
    '    Dim cDB As New clsDB
    '    Dim msSQL As String
    '    Dim myTable As New DataTable

    '    msSQL = " SELECT * FROM MST_得意先 "
    '    msSQL += " ORDER BY 客先基番 DESC "

    '    mCommand = cDB.getsqlComand(msSQL)
    '    mSDA.SelectCommand = mCommand

    '    Call mSDA.Fill(myTable) ''データセット作成

    '    If myTable.Rows.Count = 0 Then
    '        Return 1

    '    Else
    '        Return myTable.Rows(0).Item("客先基番") + 1
    '        ' Return myTable.Rows(0)("ID") + 1

    '    End If

    '    Call cDB.Close()
    'End Function

    Private Sub btn取得_Click(sender As Object, e As EventArgs) Handles btn取得.Click
        Dim subForm As New sfrm住所検索
        subForm.検索郵便 = Txt郵便番号.Text
        Call subForm.ShowDialog()

        Txt郵便番号.Text = subForm.検索郵便
        txt住所.Text = subForm.検索住所
    End Sub

    Private Sub btn登録_Click(sender As Object, e As EventArgs) Handles btn登録.Click
        Dim cDB As New clsDB
        Dim msSQL As String
        Dim myTable As New DataTable
        '' 登録する社名は必須
        With txt企業名
            Select Case .Text
                Case ""
                    MessageBox.Show("登録する社名は省略できません。", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Call .Focus()
                    Exit Sub
                Case Else
            End Select
        End With

        ''存在チェック
        msSQL = " SELECT * FROM MST_得意先"
        msSQL += " WHERE 客先ID = '" & txt企業ID.Text & "'"

        mCommand = cDB.getsqlComand(msSQL)
        mSDA.SelectCommand = mCommand

        Call mSDA.Fill(myTable) ''データセット作成

        If myTable.Rows.Count = 0 Then

            ''新規追加
            msSQL = " INSERT INTO MST_得意先 ("
            msSQL += "企業ID"
            msSQL += ",企業名"
            msSQL += ",支店名？"
            msSQL += ",代表者名"
            msSQL += " ,担当者名"
            msSQL += ",郵便番号"
            msSQL += ",住所"
            msSQL += " ,電話番号"
            msSQL += " ,FAX番号"
            msSQL += " ,メールアドレス"
            msSQL += " ,HPアドレス"
            msSQL += " ,"
            'msSQL += " ,都道府県"　　　　'lbl都道府県save　（10）
            'msSQL += " ,市区郡"　　　　　'lbl市区郡save　(20)
            'msSQL += " ,町村域"　　　　　'lbl町村域save  (20)
            'msSQL += " ,建物"　　　　　　'lbl建物save   (30)
            msSQL += " ,地域区分"　　　　　'txt地域区分
            msSQL += " ,抹消"　　　　　'
            msSQL += " ,抹消月日"　　　　　'txt抹消月日
            msSQL += " ,経歴"　　　　　'txt経歴
            msSQL += " ,未収金額"　　　　　'Txt未収金額
            msSQL += " )"
            msSQL += " VALUES("
            msSQL += "'" & Trim(txt企業ID.Text) & " ',"
            msSQL += "'" & Trim(txt企業名.Text) & " ',"
            msSQL += "'" & Trim(Txtふりがな.Text) & " ',"
            '  msSQL += "'" & Trim(Txt前組織.Text) & " ',"
            msSQL += "'" & Trim(txt企業名.Text) & " ',"
            '   msSQL += "'" & Trim(Txt後組織.Text) & " ',"
            msSQL += "'" & Trim(Txt支店名.Text) & " ',"
            msSQL += "'" & Trim(Txtふりがな.Text) & " ',"
            msSQL += "'" & Trim(TxtTEL.Text) & " ',"
            msSQL += "'" & Trim(txtFax.Text) & " ',"
            msSQL += "'" & Trim(Txt郵便番号.Text) & " ',"
            msSQL += "'" & Trim(txt住所.Text) & "',"
            msSQL += "'" & Trim(txt担当者名.Text) & " ',"
            If txt登録日.Text.Length = 0 Then
                msSQL += "'0',null,"       '抹消0、日付なし
            Else
                msSQL += "'1'," & Trim(txt登録日.Text) & " ',"
            End If
            msSQL += "'" & Trim(txt備考.Text) & " ',"
            '   msSQL += "'" & Trim(Txt未収金額.Text) & " '"
            msSQL += ")"

        Else

            ''更新
            msSQL = " UPDATE MST_得意先 SET "
            msSQL += "一般呼称 = '" & Trim(txt企業名.Text) & "'"
            msSQL += ",呼ふり = '" & Trim(Txtふりがな.Text) & "'"      'Txtふりがな
            '   msSQL += ",前組織 = '" & Trim(Txt前組織.Text) & "'"      'Txt前組織
            msSQL += ",法人名 = '" & Trim(txt企業名.Text) & "'"      'txt一般呼称
            '   msSQL += ",後組織 = '" & Trim(Txt後組織.Text) & "'"      'Txt後組織
            msSQL += ",所轄 = '" & Trim(Txt支店名.Text) & "'"      'Txt支所轄
            msSQL += " ,法ふり = '" & Trim(Txtふりがな.Text) & "'"     '.txtふりがな
            msSQL += ", 電話番号 = '" & Trim(TxtTEL.Text) & "'"     'TxtTEL
            msSQL += ", FAX番号 = '" & Trim(txtFax.Text) & "'"     'txtFax
            msSQL += ", 郵便番号 = '" & Trim(Txt郵便番号.Text) & "'"     'Txt郵便番号
            msSQL += " ,住所 = '" & Trim(txt住所.Text) & "'"     'Txt住所

            If txt登録日.Text.Length = 0 Then
                msSQL += ",抹消 = '0'"
                msSQL += ",抹消月日 = null"   ' & Trim(txt抹消月日.Text) & "'"
            Else
                msSQL += ",抹消 = '1'"
                msSQL += ",抹消月日 = '" & Trim(txt登録日.Text) & "'"
            End If
            msSQL += ",経歴 = '" & Trim(txt備考.Text) & " '"
            '    msSQL += ",未収金額 = '" & Trim(Txt未収金額.Text) & " '"

            msSQL += " WHERE 客先ID = '" & txt企業ID.Text & "'"

        End If
        mCommand = cDB.getsqlComand(msSQL)
        Call mCommand.ExecuteNonQuery()

        ''クリア
        Call subクリア()
        ''再表示
        dtbl得意先一覧 = dtbl得意先取得()
        dgv一覧.DataSource = dtbl得意先一覧
        txt企業ID.Text = 客先ID最大取得()

        Call txt企業ID.Focus()
        Call cDB.Close()

    End Sub

End Class