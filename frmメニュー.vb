''' <summary>frmベース　[Enter]キーで次の TabIndex があるコントロールへフォーカスを移す
''' フォームKeyDownイベントで実験
''' </summary>
Public Class frmメニュー
    Private Shared _mutex As System.Threading.Mutex
    Private OpenForm As Form

    Private Sub frmメニュー_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            ''多重起動禁止========================================================
            _mutex = New System.Threading.Mutex(False, Application.ProductName)

            If _mutex.WaitOne(0, False) = False Then
                MessageBox.Show("多重起動はできません。")
                Call Application.Exit()
            End If
            ''====================================================================
        Catch ex As Exception
            MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning)

        End Try

        lblバージョン.Text = "Ver" + System.Reflection.Assembly.GetExecutingAssembly().GetName().Version.ToString()
    End Sub

    Private Sub btn環境設定_Click(sender As Object, e As EventArgs) Handles btn環境設定.Click
        Dim sfrm As New frmM環境設定
        Call sfrm.ShowDialog()
    End Sub

    Private Sub btn区分管理マスタ_Click(sender As Object, e As EventArgs) Handles btn区分管理マスタ.Click
        Dim sfrm As New frmM区分管理
        Call sfrm.ShowDialog()
    End Sub


    Private Sub frmメニュー_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        ''環境設定読み込み
        my環境設定 = New cls環境設定
    End Sub

    Private Sub btn郵便番号取込_Click(sender As Object, e As EventArgs) Handles btn郵便番号取込.Click
        Dim sfrm As New frmM郵便番号取込
        Call sfrm.ShowDialog()
    End Sub

    Private Sub btn社員マスタ_Click(sender As Object, e As EventArgs) Handles btn社員マスタ.Click
        Dim sfrm As New frmM社員マスタ
        Call sfrm.ShowDialog()
    End Sub

    Private Sub btn得意先マスタ_Click(sender As Object, e As EventArgs) Handles btn得意先マスタ.Click
        Dim sfrm As New FrmM得意先
        Call sfrm.ShowDialog()
    End Sub

    Private Sub btn依頼書登録_Click(sender As Object, e As EventArgs) Handles btn依頼書登録.Click
        Dim sfrm As New frmI依頼書登録
        Call sfrm.ShowDialog()
    End Sub

End Class