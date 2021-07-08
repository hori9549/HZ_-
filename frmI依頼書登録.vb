Imports System.Data
Imports System.Data.SqlClient

Public Class frmI依頼書登録
    Private msSQL As String
    Private mCommand As SqlCommand
    Private mSDA As New SqlDataAdapter
    Private dtbl依頼書 As New DataTable

    Private Sub TOB登録書_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dtbl依頼書 = dtbl依頼書取得()
        dgv一覧.DataSource = dtbl依頼書

        Call sub初期化()
    End Sub

    Private Function dtbl依頼書取得() As DataTable
        Dim cDB As New clsDB
        Dim myTable As New DataTable

        '表示
        msSQL = "SELECT * FROM TBL_依頼書"
        msSQL += " ORDER BY 受付番号 DESC"

        mCommand = cDB.getsqlComand(msSQL)
        mSDA.SelectCommand = mCommand

        Call mSDA.Fill(myTable) ''データセット作成
        Return myTable

    End Function

    Private Sub sub初期化()
        txt受付番号.Text = ""
        txt依頼書番号.Text = ""
        txt受付日.Text = ""
        cmb受付者.Text = ""
        cmb担当者.Text = ""
        cmb作業者.Text = ""
        txt客先ID.Text = ""
        txt一般呼称.Text = ""
        txt訪問先担当者.Text = ""
        txt作業名称.Text = ""
        txt請求金額.Text = ""
        txt完了日.Text = ""
        txt竣工予定日.Text = ""
        txt依頼内容.Text = ""
        txt予定日.Text = ""
        txt予定時間.Text = ""
        chk契約物件.Checked = False
        cmb契約番号.Text = ""
        txt契約内容.Text = ""
        txt依頼元ID.Text = ""
        Txt依頼元.Text = ""
        txt依頼元担当者.Text = ""
        txt請求先ID.Text = ""
        txt請求先.Text = ""
        txt請求先担当者.Text = ""
        txt機械コード.Text = ""
        txtその他.Text = ""
        chk写真.Checked = False
        chk点検表.Checked = False
        chkデータ.Checked = False
        chk見積作成.Checked = False
        chk様子確認.Checked = False
        chk未写真.Checked = False
        chk未点検表.Checked = False
        chk未データ.Checked = False
        chk有償出.Checked = False
        chk有償見.Checked = False
        chk無償.Checked = False
        chk年間契約.Checked = False
        chk入金確認.Checked = False
        cmb営業処理.Text = ""
        txtクレーム.Text = ""
    End Sub

    Private Sub sub更新()
        Dim cDB As New clsDB
        Dim myTable As New DataTable

        ''エラーチェック==========================================================================================================
        With txt受付番号
            Select Case .Text
                Case ""
                    MessageBox.Show("受付番号は必須入力項目です", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Call .Focus()
                    Exit Sub
                Case Else
            End Select
        End With

        '登録===================================================================================================================
        Try
            ''存在チェック
            msSQL = " SELECT * FROM TBL_依頼書 "
            msSQL += " WHERE 依頼書番号 = '" & txt依頼書番号.Text & "'"

            mCommand = cDB.getsqlComand(msSQL)
            mSDA.SelectCommand = mCommand

            Call mSDA.Fill(myTable) ''データセット作成

            If myTable.Rows.Count = 0 Then
                ''新規追加
                msSQL = " INSERT INTO TBL_依頼書("

                msSQL += " 依頼書番号"
                msSQL += ",請伝番号"
                msSQL += ",受付日"
                msSQL += ",受付者"
                msSQL += ",担当者"
                msSQL += ",作業者"
                msSQL += ",客先ID"
                msSQL += ",一般呼称"
                msSQL += ",訪問先担当者"
                msSQL += ",作業名称"
                msSQL += ",完了"
                msSQL += ",請求金額"
                msSQL += ",請求完了日"
                msSQL += ",竣工予定日"
                msSQL += ",依頼内容"
                msSQL += ",予定日"
                msSQL += ",予定時間"
                msSQL += ",契約物件"
                msSQL += ",契約番号"
                msSQL += ",契約内容"
                msSQL += ",依頼元ID"
                msSQL += ",依頼元"
                msSQL += ",依頼元担当者"
                msSQL += ",請求先ID"
                msSQL += ",請求先"
                msSQL += ",請求先担当者"
                msSQL += ",機械コード"
                msSQL += ",その他"
                msSQL += ",写真"
                msSQL += ",点検表"
                msSQL += ",データ"
                msSQL += ",見積作成"
                msSQL += ",様子確認"
                msSQL += ",未写真"
                msSQL += ",未点検表"
                msSQL += ",未データ"
                msSQL += ",有償出"
                msSQL += ",有償見"
                msSQL += ",無償"
                msSQL += ",年間契約"
                msSQL += ",入金確認"
                msSQL += ",営業処理"
                msSQL += ",クレーム"

                msSQL += " )VALUES("

                msSQL += "'" & Trim(txt依頼書番号.text) & "'"
                msSQL += ",''"    ''請伝番号
                msSQL += ",'" & Trim(txt受付日.Text) & "'"
                msSQL += ",'" & Trim(cmb受付者.Text) & "'"
                msSQL += ",'" & Trim(cmb担当者.Text) & "'"
                msSQL += ",'" & Trim(txt作業者.Text) & "'"
                msSQL += ",'" & Trim(txt客先ID.Text) & "'"
                msSQL += ",'" & Trim(txt一般呼称.Text) & "'"
                msSQL += ",'" & Trim(txt訪問先担当者.Text) & "'"
                msSQL += ",'" & Trim(txt作業名称.Text) & "'"
                msSQL += ",'0'"  ''完了
                msSQL += ",'" & Trim(txt請求金額.Text) & "'"
                msSQL += ",'NULL'"   ''請求完了日
                msSQL += ",'" & Trim(txt竣工予定日.Text) & "'"
                msSQL += ",'" & Trim(txt依頼内容.Text) & "'"
                msSQL += ",'" & Trim(txt予定日.Text) & "'"
                msSQL += ",'" & Trim(txt予定時間.Text) & "'"
                msSQL += ",'" & Trim(chk契約物件.Checked) & "'"
                msSQL += ",'" & Trim(cmb契約番号.Text) & "'"
                msSQL += ",'" & Trim(txt契約内容.Text) & "'"
                msSQL += ",'" & Trim(txt依頼元ID.Text) & "'"
                msSQL += ",'" & Trim(Txt依頼元.Text) & "'"
                msSQL += ",'" & Trim(txt依頼元担当者.Text) & "'"
                msSQL += ",'" & Trim(txt請求先ID.Text) & "'"
                msSQL += ",'" & Trim(txt請求先.Text) & "'"
                msSQL += ",'" & Trim(txt請求先担当者.Text) & "'"
                msSQL += ",'" & Trim(txt機械コード.Text) & "'"
                msSQL += ",'" & Trim(txtその他.Text) & "'"
                msSQL += ",'" & Trim(chk写真.Checked) & "'"
                msSQL += ",'" & Trim(chk点検表.Checked) & "'"
                msSQL += ",'" & Trim(chkデータ.Checked) & "'"
                msSQL += ",'" & Trim(chk見積作成.Checked) & "'"
                msSQL += ",'" & Trim(chk様子確認.Checked) & "'"
                msSQL += ",'" & Trim(chk未写真.Checked) & "'"
                msSQL += ",'" & Trim(chk未点検表.Checked) & "'"
                msSQL += ",'" & Trim(chk未データ.Checked) & "'"
                msSQL += ",'" & Trim(chk有償出.Checked) & "'"
                msSQL += ",'" & Trim(chk有償見.Checked) & "'"
                msSQL += ",'" & Trim(chk無償.Checked) & "'"
                msSQL += ",'" & Trim(chk年間契約.Checked) & "'"
                msSQL += ",'" & Trim(chk入金確認.Checked) & "'"
                msSQL += ",'" & Trim(cmb営業処理.Text) & "'"
                msSQL += ",'" & Trim(txtクレーム.text) & "'"

                msSQL += " )"

                mCommand = cDB.getsqlComand(msSQL)
                Call mCommand.ExecuteNonQuery()

            Else
                Select Case MessageBox.Show("依頼書番号の上書き更新を行ってもよろしいですか？", "確認", MessageBoxButtons.OKCancel, MessageBoxIcon.Information)
                    Case Windows.Forms.DialogResult.OK
                    Case Else
                        Exit Sub
                End Select

                ''更新
                msSQL = " UPDATE TBL_依頼書 SET "
                If Trim(txt受付日.Text) = "" Then
                    msSQL += " 受付日='NULL'"
                Else
                    msSQL += " 受付日='" & Trim(txt受付日.Text) & "'"
                End If

                msSQL += ",受付者='" & Trim(cmb受付者.Text) & "'"
                msSQL += ",担当者='" & Trim(cmb担当者.Text) & "'"
                msSQL += ",作業者='" & Trim(txt作業者.Text) & "'"
                msSQL += ",客先ID='" & Trim(txt客先ID.Text) & "'"
                msSQL += ",一般呼称='" & Trim(txt一般呼称.Text) & "'"
                msSQL += ",訪問先担当者='" & Trim(txt訪問先担当者.Text) & "'"
                msSQL += ",作業名称='" & Trim(txt作業名称.Text) & "'"
                msSQL += ",完了='0'"  ''完了
                msSQL += ",請求金額='" & Trim(txt請求金額.Text) & "'"
                msSQL += ",請求完了日=NULL"   ''請求完了日
                If Trim(txt竣工予定日.Text) = "" Then
                    msSQL += ",竣工予定日=NULL"
                Else
                    msSQL += ",竣工予定日='" & Trim(txt竣工予定日.Text) & "'"
                End If
                msSQL += ",依頼内容='" & Trim(txt依頼内容.Text) & "'"
                If Trim(txt予定日.Text) = "" Then
                    msSQL += ",予定日=NULL"
                Else
                    msSQL += ",予定日='" & Trim(txt予定日.Text) & "'"
                End If
                If Trim(txt予定時間.Text) = "" Then
                    msSQL += ",予定時間=NULL"
                Else
                    msSQL += ",予定時間='" & Trim(txt予定時間.Text) & "'"
                End If

                msSQL += ",契約物件='" & Trim(chk契約物件.Checked) & "'"
                    msSQL += ",契約番号='" & Trim(cmb契約番号.Text) & "'"
                    msSQL += ",契約内容='" & Trim(txt契約内容.Text) & "'"
                    msSQL += ",依頼元ID='" & Trim(txt依頼元ID.Text) & "'"
                    msSQL += ",依頼元='" & Trim(Txt依頼元.Text) & "'"
                    msSQL += ",依頼元担当者='" & Trim(txt依頼元担当者.Text) & "'"
                    msSQL += ",請求先ID='" & Trim(txt請求先ID.Text) & "'"
                    msSQL += ",請求先='" & Trim(txt請求先.Text) & "'"
                    msSQL += ",請求先担当者='" & Trim(txt請求先担当者.Text) & "'"
                    msSQL += ",機械コード='" & Trim(txt機械コード.Text) & "'"
                msSQL += ",その他='" & Trim(txtその他.Text) & "'"
                If chk写真.Checked = True Then
                    msSQL += ",写真='1'"
                Else
                    msSQL += ",写真='0'"
                End If
                If chk点検表.Checked = True Then
                    msSQL += ",点検表='1'"
                Else
                    msSQL += ",点検表='0'"
                End If
                If chkデータ.Checked = True Then
                    msSQL += ",データ='1'"
                Else
                    msSQL += ",データ='0'"
                End If
                If chk見積作成.Checked = True Then
                    msSQL += ",見積作成='1'"
                Else
                    msSQL += ",見積作成='0'"
                End If
                If chk様子確認.Checked = True Then
                    msSQL += ",様子確認='1'"
                Else
                    msSQL += ",様子確認='0'"
                End If
                If chk未写真.Checked = True Then
                    msSQL += ",未写真='1'"
                Else
                    msSQL += ",未写真='0'"
                End If
                If chk未点検表.Checked = True Then
                    msSQL += ",未点検表='1'"
                Else
                    msSQL += ",未点検表='0'"
                End If
                If chk未データ.Checked = True Then
                    msSQL += ",未データ='1'"
                Else
                    msSQL += ",未データ='0'"
                End If
                If chk有償出.Checked = True Then
                    msSQL += ",有償出='1'"
                Else
                    msSQL += ",有償出='0'"
                End If
                If chk有償見.Checked = True Then
                    msSQL += ",有償見='1'"
                Else
                    msSQL += ",有償見='0'"
                End If
                If chk無償.Checked = True Then
                    msSQL += ",無償='1'"
                Else
                    msSQL += ",無償='0'"
                End If
                If chk年間契約.Checked = True Then
                    msSQL += ",年間契約='1'"
                Else
                    msSQL += ",年間契約='0'"
                End If
                If chk入金確認.Checked = True Then
                    msSQL += ",入金確認='1'"
                Else
                    msSQL += ",入金確認='0'"
                End If

                msSQL += ",営業処理='" & Trim(cmb営業処理.Text) & "'"
                msSQL += ",クレーム='" & Trim(txtクレーム.Text) & "'"
                    msSQL += " WHERE 依頼書番号  = '" & txt依頼書番号.Text & "'"

                    mCommand = cDB.getsqlComand(msSQL)
                    Call mCommand.ExecuteNonQuery()
                End If

                ''再表示============================================================================
                dtbl依頼書 = dtbl依頼書取得()
            dgv一覧.DataSource = dtbl依頼書


            ''クリア============================================================================
            Call sub初期化()
            Call txt依頼書番号.Focus()

            Call cDB.Close()

        Catch ex As Exception
            MessageBox.Show(ex.Message, "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub btn受付日_Click(sender As Object, e As EventArgs) Handles btn受付日.Click
        Dim sfrm As New sfrm日付選択
        Call sfrm.ShowDialog()
        txt受付日.Text = sfrm.日付
    End Sub

    Private Sub btn予定日_Click(sender As Object, e As EventArgs) Handles btn予定日.Click
        Dim sfrm As New sfrm日付選択
        Call sfrm.ShowDialog()
        txt予定日.Text = sfrm.日付
    End Sub

    Private Sub btn竣工予定日_Click(sender As Object, e As EventArgs) Handles btn竣工予定日.Click
        Dim sfrm As New sfrm日付選択
        Call sfrm.ShowDialog()
        txt竣工予定日.Text = sfrm.日付
    End Sub

    Private Sub btn完了日_Click(sender As Object, e As EventArgs) Handles btn完了日.Click
        Dim sfrm As New sfrm日付選択
        Call sfrm.ShowDialog()
        txt完了日.Text = sfrm.日付
    End Sub

    Private Sub dgv一覧_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv一覧.CellClick
        If e.RowIndex < 0 Then Exit Sub
        If e.ColumnIndex < 0 Then Exit Sub

        'txt受付番号.Text = dtbl依頼書.Rows(e.RowIndex).Item("受付番号").ToString

        'txt依頼書番号.Text = dtbl依頼書.Rows(e.RowIndex).Item("依頼書番号").ToString

        'txt受付日.Text = dtbl依頼書.Rows(e.RowIndex).Item("受付日").ToString

        'cmb受付者.Text = dtbl依頼書.Rows(e.RowIndex).Item("受付者").ToString

        'cmb担当者.Text = dtbl依頼書.Rows(e.RowIndex).Item("担当者").ToString

        'cmb作業者.Text = dtbl依頼書.Rows(e.RowIndex).Item("作業者").ToString

        'txt客先ID.Text = dtbl依頼書.Rows(e.RowIndex).Item("客先ID").ToString

        'txt一般呼称.Text = dtbl依頼書.Rows(e.RowIndex).Item("一般呼称").ToString

        'txt訪問先担当者.Text = dtbl依頼書.Rows(e.RowIndex).Item("訪問先担当者").ToString

        'txt作業名称.Text = dtbl依頼書.Rows(e.RowIndex).Item("作業名称").ToString

        'If String.IsNullOrEmpty(dtbl依頼書.Rows(e.RowIndex).Item("請求金額").ToString) Then
        '    txt請求金額.Text = ""
        'Else
        '    txt請求金額.Text = Format(dtbl依頼書.Rows(e.RowIndex).Item("請求金額"), "#,##0").ToString

        'End If

        'txt完了日.Text = dtbl依頼書.Rows(e.RowIndex).Item("請求完了日").ToString

        'txt竣工予定日.Text = dtbl依頼書.Rows(e.RowIndex).Item("竣工予定日").ToString

        'txt依頼内容.Text = dtbl依頼書.Rows(e.RowIndex).Item("依頼内容").ToString

        'txt予定日.Text = dtbl依頼書.Rows(e.RowIndex).Item("予定日").ToString

        'txt予定時間.Text = dtbl依頼書.Rows(e.RowIndex).Item("予定時間").ToString

        'If dtbl依頼書.Rows(e.RowIndex).Item("契約物件") = "1" Then
        '    chk契約物件.Checked = True
        'Else
        '    chk契約物件.Checked = False
        'End If

        'cmb契約番号.Text = dtbl依頼書.Rows(e.RowIndex).Item("契約番号").ToString

        'txt契約内容.Text = dtbl依頼書.Rows(e.RowIndex).Item("契約内容").ToString

        'txt依頼元ID.Text = dtbl依頼書.Rows(e.RowIndex).Item("依頼元ID").ToString

        'Txt依頼元.Text = dtbl依頼書.Rows(e.RowIndex).Item("依頼元").ToString

        'txt依頼元担当者.Text = dtbl依頼書.Rows(e.RowIndex).Item("依頼元担当者").ToString

        'txt請求先ID.Text = dtbl依頼書.Rows(e.RowIndex).Item("請求先ID").ToString

        'txt請求先.Text = dtbl依頼書.Rows(e.RowIndex).Item("請求先").ToString

        'txt請求先担当者.Text = dtbl依頼書.Rows(e.RowIndex).Item("請求先担当者").ToString

        'txt機械コード.Text = dtbl依頼書.Rows(e.RowIndex).Item("機械コード").ToString

        'txtその他.Text = dtbl依頼書.Rows(e.RowIndex).Item("その他").ToString

        'If dtbl依頼書.Rows(e.RowIndex).Item("写真") = "1" Then
        '    chk写真.Checked = True
        'Else
        '    chk写真.Checked = False
        'End If

        'If dtbl依頼書.Rows(e.RowIndex).Item("点検表") = "1" Then
        '    chk点検表.Checked = True
        'Else
        '    chk点検表.Checked = False
        'End If

        'If dtbl依頼書.Rows(e.RowIndex).Item("データ") = "1" Then
        '    chkデータ.Checked = True
        'Else
        '    chkデータ.Checked = False
        'End If

        'If dtbl依頼書.Rows(e.RowIndex).Item("見積作成") = "1" Then
        '    chk見積作成.Checked = True
        'Else
        '    chk見積作成.Checked = False
        'End If

        'If dtbl依頼書.Rows(e.RowIndex).Item("様子確認") = "1" Then
        '    chk様子確認.Checked = True
        'Else
        '    chk様子確認.Checked = False
        'End If

        'If dtbl依頼書.Rows(e.RowIndex).Item("未写真") = "1" Then
        '    chk未写真.Checked = True
        'Else
        '    chk未写真.Checked = False
        'End If

        'If dtbl依頼書.Rows(e.RowIndex).Item("未点検表") = "1" Then
        '    chk未点検表.Checked = True
        'Else
        '    chk未点検表.Checked = False
        'End If

        'If dtbl依頼書.Rows(e.RowIndex).Item("未データ") = "1" Then
        '    chk未データ.Checked = True
        'Else
        '    chk未データ.Checked = False
        'End If

        'If dtbl依頼書.Rows(e.RowIndex).Item("有償出") = "1" Then
        '    chk有償出.Checked = True
        'Else
        '    chk有償出.Checked = False
        'End If

        'If dtbl依頼書.Rows(e.RowIndex).Item("有償見") = "1" Then
        '    chk有償見.Checked = True
        'Else
        '    chk有償見.Checked = False
        'End If

        'If dtbl依頼書.Rows(e.RowIndex).Item("無償") = "1" Then
        '    chk無償.Checked = True
        'Else
        '    chk無償.Checked = False
        'End If

        'If dtbl依頼書.Rows(e.RowIndex).Item("年間契約") = "1" Then
        '    chk年間契約.Checked = True
        'Else
        '    chk年間契約.Checked = False
        'End If

        'If dtbl依頼書.Rows(e.RowIndex).Item("入金確認") = "1" Then
        '    chk入金確認.Checked = True
        'Else
        '    chk入金確認.Checked = False
        'End If

        'cmb営業処理.Text = dtbl依頼書.Rows(e.RowIndex).Item("営業処理").ToString

        'txtクレーム.Text = dtbl依頼書.Rows(e.RowIndex).Item("クレーム").ToString



        '-----------------DGV取得に改造----txt基番.Text = Trim(dgv一覧.Rows(e.RowIndex).Cells("col客先基番").Value.ToString)


        txt受付番号.Text =Trim(dgv一覧.Rows(e.RowIndex).Cells("col受付番号").Value.ToString)

        txt依頼書番号.Text = Trim(dgv一覧.Rows(e.RowIndex).Cells("col依頼書番号").Value.ToString)

        Dim dt As Date = Trim(dgv一覧.Rows(e.RowIndex).Cells("col受付日").Value.ToString)
        ' txt受付日.Text = Trim(dgv一覧.Rows(e.RowIndex).Cells("col受付日").Value.ToString("yyyy / MM / dd"))
        txt受付日.Text = dt.ToString("yyyy / MM / dd")

        cmb受付者.Text =Trim(dgv一覧.Rows(e.RowIndex).Cells("col受付者").Value.ToString)
        
        cmb担当者.Text = Trim(dgv一覧.Rows(e.RowIndex).Cells("col担当者").Value.ToString)
        
        cmb作業者.Text = Trim(dgv一覧.Rows(e.RowIndex).Cells("col作業者").Value.ToString)

        'txt客先ID.Text = dtbl依頼書.Rows(e.Row

        'txt一般呼称.Text = dtbl依頼書.Rows(e.R

        'txt訪問先担当者.Text = dtbl依頼書.Rows

        'txt作業名称.Text = dtbl依頼書.Rows(e.R

        'If String.IsNullOrEmpty(dtbl依頼書.Row
        '    txt請求金額.Text = ""
        'Else
        '    txt請求金額.Text = Format(dtbl依頼

        'End If

        'txt完了日.Text = dtbl依頼書.Rows(e.Row

        'txt竣工予定日.Text = dtbl依頼書.Rows(e

        'txt依頼内容.Text = dtbl依頼書.Rows(e.R

        'txt予定日.Text = dtbl依頼書.Rows(e.Row

        'txt予定時間.Text = dtbl依頼書.Rows(e.R

        'If dtbl依頼書.Rows(e.RowIndex).Item("契
        '    chk契約物件.Checked = True
        'Else
        '    chk契約物件.Checked = False
        'End If

        'cmb契約番号.Text = dtbl依頼書.Rows(e.R

        'txt契約内容.Text = dtbl依頼書.Rows(e.R

        'txt依頼元ID.Text = dtbl依頼書.Rows(e.R

        'Txt依頼元.Text = dtbl依頼書.Rows(e.Row

        'txt依頼元担当者.Text = dtbl依頼書.Rows

        'txt請求先ID.Text = dtbl依頼書.Rows(e.R

        'txt請求先.Text = dtbl依頼書.Rows(e.Row

        'txt請求先担当者.Text = dtbl依頼書.Rows

        'txt機械コード.Text = dtbl依頼書.Rows(e

        'txtその他.Text = dtbl依頼書.Rows(e.Row

        'If dtbl依頼書.Rows(e.RowIndex).Item("写
        '    chk写真.Checked = True
        'Else
        '    chk写真.Checked = False
        'End If

        'If dtbl依頼書.Rows(e.RowIndex).Item("点
        '    chk点検表.Checked = True
        'Else
        '    chk点検表.Checked = False
        'End If

        'If dtbl依頼書.Rows(e.RowIndex).Item("デ
        '    chkデータ.Checked = True
        'Else
        '    chkデータ.Checked = False
        'End If

        'If dtbl依頼書.Rows(e.RowIndex).Item("見
        '    chk見積作成.Checked = True
        'Else
        '    chk見積作成.Checked = False
        'End If

        'If dtbl依頼書.Rows(e.RowIndex).Item("様
        '    chk様子確認.Checked = True
        'Else
        '    chk様子確認.Checked = False
        'End If

        'If dtbl依頼書.Rows(e.RowIndex).Item("未
        '    chk未写真.Checked = True
        'Else
        '    chk未写真.Checked = False
        'End If

        'If dtbl依頼書.Rows(e.RowIndex).Item("未
        '    chk未点検表.Checked = True
        'Else
        '    chk未点検表.Checked = False
        'End If

        'If dtbl依頼書.Rows(e.RowIndex).Item("未
        '    chk未データ.Checked = True
        'Else
        '    chk未データ.Checked = False
        'End If

        'If dtbl依頼書.Rows(e.RowIndex).Item("有
        '    chk有償出.Checked = True
        'Else
        '    chk有償出.Checked = False
        'End If

        'If dtbl依頼書.Rows(e.RowIndex).Item("有
        '    chk有償見.Checked = True
        'Else
        '    chk有償見.Checked = False
        'End If

        'If dtbl依頼書.Rows(e.RowIndex).Item("無
        '    chk無償.Checked = True
        'Else
        '    chk無償.Checked = False
        'End If

        'If dtbl依頼書.Rows(e.RowIndex).Item("年
        '    chk年間契約.Checked = True
        'Else
        '    chk年間契約.Checked = False
        'End If

        'If dtbl依頼書.Rows(e.RowIndex).Item("入
        '    chk入金確認.Checked = True
        'Else
        '    chk入金確認.Checked = False
        'End If

        'cmb営業処理.Text = dtbl依頼書.Rows(e.R

        'txtクレーム.Text = dtbl依頼書.Rows(e.R
    End Sub

    Private Sub btn印刷_Click(sender As Object, e As EventArgs) Handles btn印刷.Click
        'With txt受付番号
        '    Select Case .Text
        '        Case ""
        '            MessageBox.Show("依頼書の選択がされていません。", "情報", MessageBoxButtons.OK, MessageBoxIcon.Information)
        '            Exit Sub
        '    End Select
        'End With

        'Dim rpt As New rpt依頼書
        'Dim dv依頼書 As New DataView(dtbl依頼書)
        'dv依頼書.RowFilter = "受付番号='" & txt受付番号.Text & "'"

        'rpt.依頼書 = dv依頼書.ToTable

        'Call rpt.Run()

        'Dim frmViewer As New sfrmレポート
        'frmViewer.レポートドキュメント = rpt.Document
        'Call frmViewer.ShowDialog()
    End Sub

    Private Sub btn登録_Click(sender As Object, e As EventArgs) Handles btn登録.Click
        Call sub更新()
    End Sub
End Class
