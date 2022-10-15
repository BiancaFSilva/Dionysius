Module Modulo
    ' Variáveis de conexão com o banco de dados
    Public db As New ADODB.Connection
    Public rs As New ADODB.Recordset
    Public dirDb = Application.StartupPath & "\db\Dionysius.mdb"

    ' Variáveis
    Public dir, sql As String
    Public resp, aux As String
    Public cont As Integer

    Sub conectaDataBase()
        Try
            ' Inicializa a conexão com o banco de dados e informao banco que deve ser aberto
            db = CreateObject("ADODB.Connection")
            db.Open("Provider=Microsoft.JET.OLEDB.4.0;Data Source=" & dirDb)

            MsgBox("Conexão realizada com sucesso", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "AVISO")
        Catch ex As Exception
            MsgBox("Ocorreu um erro durante a conexão" + vbNewLine &
                   "Tente novamente mais tarde", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
        End Try
    End Sub

    Sub carregaDadosVinho()
        Try
            sql = "SELECT * FROM tb_vinhos ORDER BY nome ASC"
            rs = db.Execute(sql)

            cont = 1
            With Dashboard.dgvDadosVinho
                .Rows.Clear()

                Do While rs.EOF = False
                    .Rows.Add(cont, rs.Fields(1).Value, rs.Fields(2).Value, rs.Fields(3).Value, rs.Fields(4).Value, rs.Fields(5).Value, rs.Fields(6).Value, rs.Fields(7).Value, rs.Fields(11).Value, rs.Fields(12).Value, rs.Fields(14).Value, rs.Fields(15).Value, Nothing, Nothing)
                    rs.MoveNext()

                    cont = cont + 1
                Loop
            End With
        Catch ex As Exception
            MsgBox("Ocorreu um erro durante o carregamento" + vbNewLine &
                   "Tente novamente mais tarde", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
        End Try
    End Sub
End Module
