Module Modulo
    ' Variáveis de conexão com o banco de dados
    'Public db As New ADODB.Connection
    'Public rs As New ADODB.Recordset
    Public dirDb = Application.StartupPath & "\db\*"

    ' Variáveis
    Public dir, sql As String

    Sub conectaDataBase()
        Try
            ' Inicializa a conexão com o banco de dados e informao banco que deve ser aberto
            'db = CreateObject("ADODB.Connection")
            'db.Open("Provider=Microsoft.JET.OLEDB.4.0;Data Source=" & dirDb)

            MsgBox("Conexão realizada com sucesso", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "AVISO")
        Catch ex As Exception
            MsgBox("Ocorreu um erro durante a conexão" + vbNewLine &
                   "Tente novamente mais tarde", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
        End Try
    End Sub
End Module
