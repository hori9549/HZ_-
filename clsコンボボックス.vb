Imports System.Data
Imports System.Data.SqlClient

Public Class clsコンボボックス
    Private msSQL As String
    Private mCommand As SqlCommand
    Private mSDA As New SqlDataAdapter

    Public Sub 区分コンボ(ByVal setDDL As ComboBox)
        Dim cDB As New clsDB
        Dim getSQL As String
        Dim myTable As New DataTable

        ''検索SQL======================================================
        getSQL = "SELECT DISTINCT (区分名) as 表示,区分"
        getSQL += " FROM MST_区分"
        getSQL += " ORDER BY 区分,区分名"

        mCommand = cDB.getsqlComand(getSQL)
        mSDA.SelectCommand = mCommand

        Call mSDA.Fill(myTable)
        ''=============================================================

        ''空行追加-----------------------------------------------------
        Dim myRow As DataRow = myTable.NewRow
        myRow("区分") = "0"
        myRow("表示") = ""
        Call myTable.Rows.InsertAt(myRow, 0)

        With setDDL
            .DisplayMember = "表示"
            .ValueMember = "区分"

            ''グリッド表示
            .DataSource = myTable.DefaultView
            .SelectedValue = 0

        End With

    End Sub

    Public Sub 口座区分コンボ(ByVal setDDL As ComboBox)
        Dim cDB As New clsDB
        Dim getSQL As String
        Dim myTable As New DataTable

        If Not myTable Is Nothing Then myTable.Clear()
        ''検索SQL======================================================
        getSQL = "SELECT コード,内容"
        getSQL += " FROM MST_区分明細"
        getSQL += " WHERE 区分 = 1 AND 削除フラグ = 0"
        getSQL += " ORDER BY コード"

        mCommand = cDB.getsqlComand(getSQL)
        mSDA.SelectCommand = mCommand

        Call mSDA.Fill(myTable)
        ''=============================================================

        ''空行追加-----------------------------------------------------
        Dim myRow As DataRow = myTable.NewRow
        myRow("コード") = "0"
        myRow("内容") = ""
        Call myTable.Rows.InsertAt(myRow, 0)

        With setDDL
            .DisplayMember = "内容"
            .ValueMember = "コード"

            ''グリッド表示
            .DataSource = myTable.DefaultView
            .SelectedValue = 0

        End With
    End Sub

    Public Sub 材料区分コンボ(ByVal setDDL As ComboBox)
        Dim cDB As New clsDB
        Dim getSQL As String
        Dim myTable As New DataTable

        If Not myTable Is Nothing Then myTable.Clear()
        ''検索SQL======================================================
        getSQL = "SELECT コード,内容"
        getSQL += " FROM MST_区分明細"
        getSQL += " WHERE 区分 = 2 AND 削除フラグ = 0"
        getSQL += " ORDER BY コード"

        mCommand = cDB.getsqlComand(getSQL)
        mSDA.SelectCommand = mCommand

        Call mSDA.Fill(myTable)
        ''=============================================================

        ''空行追加-----------------------------------------------------
        Dim myRow As DataRow = myTable.NewRow
        myRow("コード") = "0"
        myRow("内容") = ""
        Call myTable.Rows.InsertAt(myRow, 0)

        With setDDL
            .DisplayMember = "内容"
            .ValueMember = "コード"

            ''グリッド表示
            .DataSource = myTable.DefaultView
            .SelectedValue = 0

        End With
    End Sub

    Public Sub 石種類コンボ(ByVal setDDL As ComboBox)
        Dim cDB As New clsDB
        Dim getSQL As String
        Dim myTable As New DataTable

        If Not myTable Is Nothing Then myTable.Clear()
        ''検索SQL======================================================
        getSQL = "SELECT コード,(内容 + '(' + 備考 + ')') as 表示"
        getSQL += " FROM MST_区分明細"
        getSQL += " WHERE 区分 = 3 AND 削除フラグ = 0"
        getSQL += " ORDER BY コード"

        mCommand = cDB.getsqlComand(getSQL)
        mSDA.SelectCommand = mCommand

        Call mSDA.Fill(myTable)
        ''=============================================================

        ''空行追加-----------------------------------------------------
        Dim myRow As DataRow = myTable.NewRow
        myRow("コード") = "0"
        myRow("表示") = ""
        Call myTable.Rows.InsertAt(myRow, 0)

        With setDDL
            .DisplayMember = "表示"
            .ValueMember = "コード"

            ''グリッド表示
            .DataSource = myTable.DefaultView
            .SelectedValue = 0

        End With
    End Sub

    Public Sub 石型コンボ(ByVal setDDL As ComboBox)
        Dim cDB As New clsDB
        Dim getSQL As String
        Dim myTable As New DataTable

        If Not myTable Is Nothing Then myTable.Clear()
        ''検索SQL======================================================
        getSQL = "SELECT コード,(内容 + '(' + 備考 + ')') as 表示"
        getSQL += " FROM MST_区分明細"
        getSQL += " WHERE 区分 = 4 AND 削除フラグ = 0"
        getSQL += " ORDER BY コード"

        mCommand = cDB.getsqlComand(getSQL)
        mSDA.SelectCommand = mCommand

        Call mSDA.Fill(myTable)
        ''=============================================================

        ''空行追加-----------------------------------------------------
        Dim myRow As DataRow = myTable.NewRow
        myRow("コード") = "0"
        myRow("表示") = ""
        Call myTable.Rows.InsertAt(myRow, 0)

        With setDDL
            .DisplayMember = "表示"
            .ValueMember = "コード"

            ''グリッド表示
            .DataSource = myTable.DefaultView
            .SelectedValue = 0

        End With
    End Sub

    Public Sub 石カットコンボ(ByVal setDDL As ComboBox)
        Dim cDB As New clsDB
        Dim getSQL As String
        Dim myTable As New DataTable

        If Not myTable Is Nothing Then myTable.Clear()
        ''検索SQL======================================================
        getSQL = "SELECT コード,(内容 + '(' + 備考 + ')') as 表示"
        getSQL += " FROM MST_区分明細"
        getSQL += " WHERE 区分 = 9 AND 削除フラグ = 0"
        getSQL += " ORDER BY コード"

        mCommand = cDB.getsqlComand(getSQL)
        mSDA.SelectCommand = mCommand

        Call mSDA.Fill(myTable)
        ''=============================================================

        ''空行追加-----------------------------------------------------
        Dim myRow As DataRow = myTable.NewRow
        myRow("コード") = "0"
        myRow("表示") = ""
        Call myTable.Rows.InsertAt(myRow, 0)

        With setDDL
            .DisplayMember = "表示"
            .ValueMember = "コード"

            ''グリッド表示
            .DataSource = myTable.DefaultView
            .SelectedValue = 0

        End With
    End Sub

    Public Sub 石サイズコンボ(ByVal setDDL As ComboBox)
        Dim cDB As New clsDB
        Dim getSQL As String
        Dim myTable As New DataTable

        If Not myTable Is Nothing Then myTable.Clear()
        ''検索SQL======================================================
        getSQL = "SELECT コード,(内容 + '(' + 備考 + ')') as 表示"
        getSQL += " FROM MST_区分明細"
        getSQL += " WHERE 区分 = 5 AND 削除フラグ = 0"
        getSQL += " ORDER BY コード"

        mCommand = cDB.getsqlComand(getSQL)
        mSDA.SelectCommand = mCommand

        Call mSDA.Fill(myTable)
        ''=============================================================

        ''空行追加-----------------------------------------------------
        Dim myRow As DataRow = myTable.NewRow
        myRow("コード") = "0"
        myRow("表示") = ""
        Call myTable.Rows.InsertAt(myRow, 0)

        With setDDL
            .DisplayMember = "表示"
            .ValueMember = "コード"

            ''グリッド表示
            .DataSource = myTable.DefaultView
            .SelectedValue = 0

        End With
    End Sub

    Public Sub 単位コンボ(ByVal setDDL As ComboBox)
        Dim cDB As New clsDB
        Dim getSQL As String
        Dim myTable As New DataTable

        If Not myTable Is Nothing Then myTable.Clear()
        ''検索SQL======================================================
        getSQL = "SELECT コード,内容"
        getSQL += " FROM MST_区分明細"
        getSQL += " WHERE 区分 = 6 AND 削除フラグ = 0"
        getSQL += " ORDER BY コード"

        mCommand = cDB.getsqlComand(getSQL)
        mSDA.SelectCommand = mCommand

        Call mSDA.Fill(myTable)
        ''=============================================================

        ''空行追加-----------------------------------------------------
        Dim myRow As DataRow = myTable.NewRow
        myRow("内容") = ""
        myRow("内容") = ""
        Call myTable.Rows.InsertAt(myRow, 0)

        With setDDL
            .DisplayMember = "内容"
            .ValueMember = "内容"

            ''グリッド表示
            .DataSource = myTable.DefaultView
            .SelectedValue = 0

        End With
    End Sub

    Public Sub 手配コンボ(ByVal setDDL As ComboBox)
        Dim cDB As New clsDB
        Dim getSQL As String
        Dim myTable As New DataTable

        If Not myTable Is Nothing Then myTable.Clear()
        ''検索SQL======================================================
        getSQL = "SELECT コード,内容"
        getSQL += " FROM MST_区分明細"
        getSQL += " WHERE 区分 = 7 AND 削除フラグ = 0"
        getSQL += " ORDER BY コード"

        mCommand = cDB.getsqlComand(getSQL)
        mSDA.SelectCommand = mCommand

        Call mSDA.Fill(myTable)
        ''=============================================================

        ''空行追加-----------------------------------------------------
        Dim myRow As DataRow = myTable.NewRow
        myRow("コード") = "0"
        myRow("内容") = ""
        Call myTable.Rows.InsertAt(myRow, 0)

        With setDDL
            .ValueMember = "コード"
            .DisplayMember = "内容"

            ''グリッド表示
            .DataSource = myTable.DefaultView
            .SelectedValue = 0

        End With
    End Sub

    Public Sub 金性コンボ(ByVal setDDL As ComboBox)
        Dim cDB As New clsDB
        Dim getSQL As String
        Dim myTable As New DataTable

        If Not myTable Is Nothing Then myTable.Clear()
        ''検索SQL======================================================
        getSQL = "SELECT コード,(内容 + '(' + 備考 + ')') as 表示"
        getSQL += " FROM MST_区分明細"
        getSQL += " WHERE 区分 = 8 AND 削除フラグ = 0"
        getSQL += " ORDER BY コード"

        mCommand = cDB.getsqlComand(getSQL)
        mSDA.SelectCommand = mCommand

        Call mSDA.Fill(myTable)
        ''=============================================================

        ''空行追加-----------------------------------------------------
        Dim myRow As DataRow = myTable.NewRow
        myRow("コード") = 0
        myRow("表示") = ""
        Call myTable.Rows.InsertAt(myRow, 0)

        With setDDL
            .DisplayMember = "表示"
            .ValueMember = "コード"

            ''グリッド表示
            .DataSource = myTable.DefaultView
            .SelectedValue = 0

        End With
    End Sub

    Public Sub 作業場所コンボ(ByVal setDDL As ComboBox)
        Dim cDB As New clsDB
        Dim getSQL As String
        Dim myTable As New DataTable

        If Not myTable Is Nothing Then myTable.Clear()
        ''検索SQL======================================================
        getSQL = "SELECT コード,内容"
        getSQL += " FROM MST_区分明細"
        getSQL += " WHERE 区分 = 10 AND 削除フラグ = 0"
        getSQL += " ORDER BY コード"

        mCommand = cDB.getsqlComand(getSQL)
        mSDA.SelectCommand = mCommand

        Call mSDA.Fill(myTable)
        ''=============================================================

        ''空行追加-----------------------------------------------------
        Dim myRow As DataRow = myTable.NewRow
        myRow("コード") = "0"
        myRow("内容") = ""
        Call myTable.Rows.InsertAt(myRow, 0)

        With setDDL
            .ValueMember = "コード"
            .DisplayMember = "内容"

            ''グリッド表示
            .DataSource = myTable.DefaultView
            .SelectedValue = 0

        End With
    End Sub

    Public Sub 請求先コンボ(ByVal setDDL As ComboBox)
        Dim cDB As New clsDB
        Dim getSQL As String
        Dim myTable As New DataTable

        If Not myTable Is Nothing Then myTable.Clear()
        ''検索SQL======================================================
        getSQL = "SELECT (取引先ID + '|' + 業者名) as 表示, 取引先ID "
        getSQL += " FROM MST_業者"
        getSQL += " WHERE (削除フラグ IS NULL OR 削除フラグ = 0)"
        getSQL += " ORDER BY 取引先ID"

        mCommand = cDB.getsqlComand(getSQL)
        mSDA.SelectCommand = mCommand

        Call mSDA.Fill(myTable)
        ''=============================================================

        ''空行追加-----------------------------------------------------
        Dim myRow As DataRow = myTable.NewRow
        myRow("表示") = ""
        myRow("取引先ID") = ""
        Call myTable.Rows.InsertAt(myRow, 0)

        With setDDL
            .DisplayMember = "表示"
            .ValueMember = "取引先ID"

            ''グリッド表示
            .DataSource = myTable.DefaultView
            .SelectedValue = 0

        End With
    End Sub

    Public Sub 取引先コンボ(ByVal setDDL As ComboBox, set取引区分 As Integer)
        Dim cDB As New clsDB
        Dim getSQL As String
        Dim myTable As New DataTable

        If Not myTable Is Nothing Then myTable.Clear()
        ''検索SQL======================================================
        getSQL = "SELECT ID"
        getSQL += " ,(CASE WHEN 取引先識別='' THEN 取引先名 ELSE 取引先名+'('+ 取引先識別 + ')'  END) as Display"
        getSQL += " ,フリガナ"
        getSQL += " FROM MST_取引先"
        getSQL += " WHERE (削除フラグ IS NULL OR 削除フラグ = 0)"
        Select Case set取引区分
            Case 1  ''販売先
                getSQL += " AND 販売先フラグ = '1'"
            Case 2  ''仕入先
                getSQL += " AND 仕入先フラグ = '1'"
        End Select
        getSQL += " ORDER BY フリガナ"

        mCommand = cDB.getsqlComand(getSQL)
        mSDA.SelectCommand = mCommand

        Call mSDA.Fill(myTable)
        ''=============================================================

        ''空行追加-----------------------------------------------------
        Dim myRow As DataRow = myTable.NewRow

        myRow("ID") = "0"
        myRow("Display") = ""

        Call myTable.Rows.InsertAt(myRow, 0)

        With setDDL
            .ValueMember = "ID"
            .DisplayMember = "Display"

            ''グリッド表示
            .DataSource = myTable.DefaultView
            .SelectedValue = 0

        End With

    End Sub

End Class
