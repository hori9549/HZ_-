Imports System.IO   ''ファイル操作用
Imports System.Text ''エンコード時使用

Public Class clsCSV

    ''CSV読み込み
    Public Function b_CSVReader(ByVal CSVFileName As String, ByRef retData As System.IO.StreamReader) As Boolean

        If Not File.Exists(CSVFileName) Then Return False

        Dim mySReader As New StreamReader(CSVFileName, Encoding.Default)

        ''データを返す
        retData = mySReader ''データ取得

        'Call mySReader.Close()
        Return True
    End Function

    ''CSV書き出し
    ''Append追記、上書きチェック　true:追記,false:上書き
    Public Function b_CSVWriter(ByVal CSVFileName As String, ByVal WriteData As String, ByVal Append As Boolean) As Boolean

        ''If Not File.Exists(CSVFileName) Then Return False

        Dim mySWrite As New StreamWriter(CSVFileName, Append, Encoding.Default)

        ''データを返す
        Call mySWrite.WriteLine(WriteData)  ''データ書き込み
        Call mySWrite.Close()

        Return True
    End Function

    ''CSV書き出し(データテーブル)
    Public Sub b_CSVWriterDataTable(ByVal CSVFilePath As String, ByVal pDataTable As DataTable)

        Dim csvData As String = String.Empty
        Dim strTmp As String = String.Empty

        For i_Col As Integer = 0 To pDataTable.Columns.Count - 1
            If csvData <> "" Then csvData += "," ''カンマを付加
            csvData += """" + pDataTable.Columns(i_Col).ColumnName + """"
        Next

        csvData += vbCrLf

        For Each WriteDataRow As DataRow In pDataTable.Rows

            strTmp = String.Empty

            For i As Integer = 0 To WriteDataRow.ItemArray.Length - 1
                If strTmp <> "" Then strTmp += "," ''カンマを付加
                strTmp += """" + WriteDataRow(i).ToString + """"
            Next
            csvData += strTmp & vbCrLf
        Next

        Dim SW As New StreamWriter(CSVFilePath, False, Encoding.Default)

        Call SW.WriteLine(csvData)  ''データ書き込み
        Call SW.Close()

    End Sub


End Class
