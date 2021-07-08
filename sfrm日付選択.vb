Public Class sfrm日付選択

    ''選択日付
    Private getDate
    Public Property 日付() As String
        Get
            Return getDate
        End Get

        Set(ByVal value As String)
            getDate = value
        End Set
    End Property

    ''閉じるボタン押下
    Private Sub btn_Exit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Exit.Click
        getDate = ""

        Call Me.Close()
    End Sub

    ''選択日付を格納
    Private Sub MonthCalendar_DateSelected(ByVal sender As Object, ByVal e As System.Windows.Forms.DateRangeEventArgs) Handles MonthCalendar.DateSelected
        getDate = Format(MonthCalendar.SelectionStart, "yyyy/MM/dd")

        Call Me.Close()
    End Sub

    Private Sub sfrm_InputCalender_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Form Size
        Me.Size = New Size(MonthCalendar.Size.Width + 30, MonthCalendar.Size.Height + 90)
        'Button Location
        btn_Exit.Location = New Point((Me.Size.Width \ 2) - (btn_Exit.Size.Width \ 2) - 2, btn_Exit.Location.Y)
    End Sub

    Private Sub btn今日_Click(sender As Object, e As EventArgs) Handles btn今日.Click
        getDate = Now.Date

        Call Me.Close()
    End Sub
End Class