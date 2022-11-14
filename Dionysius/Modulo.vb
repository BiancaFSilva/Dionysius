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

    Sub carregaDadosProducao()
        Try
            sql = "SELECT * FROM tb_fabricacao ORDER BY processo ASC"
            rs = db.Execute(sql)

            cont = 1
            With Dashboard.dgvDadosProducao
                .Rows.Clear()

                Do While rs.EOF = False
                    .Rows.Add(cont, rs.Fields(5).Value, rs.Fields(1).Value, rs.Fields(2).Value, rs.Fields(3).Value, rs.Fields(4).Value, Nothing, Nothing)
                    rs.MoveNext()

                    cont = cont + 1
                Loop
            End With
        Catch ex As Exception
            MsgBox("Ocorreu um erro durante o carregamento" + vbNewLine &
                   "Tente novamente mais tarde", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
        End Try
    End Sub

    Sub carregaDadosEvento()
        Try
            sql = "SELECT * FROM tb_eventos ORDER BY nome ASC"
            rs = db.Execute(sql)

            cont = 1
            With Dashboard.dgvDadosEvento
                .Rows.Clear()

                Do While rs.EOF = False
                    .Rows.Add(cont, rs.Fields(1).Value, rs.Fields(2).Value, rs.Fields(3).Value, rs.Fields(4).Value, rs.Fields(5).Value, rs.Fields(6).Value, rs.Fields(7).Value, rs.Fields(8).Value, rs.Fields(9).Value, Nothing, Nothing)
                    rs.MoveNext()

                    cont = cont + 1
                Loop
            End With
        Catch ex As Exception
            MsgBox("Ocorreu um erro durante o carregamento" + vbNewLine &
                   "Tente novamente mais tarde", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
        End Try
    End Sub

    Sub carregaDadosFornecedores()
        Try
            sql = "SELECT * FROM tb_fornecedores ORDER BY nome ASC"
            rs = db.Execute(sql)

            cont = 1
            With Dashboard.dgvDadosFornecedores
                .Rows.Clear()

                Do While rs.EOF = False
                    .Rows.Add(cont, rs.Fields(1).Value, rs.Fields(2).Value, rs.Fields(4).Value, rs.Fields(5).Value, rs.Fields(3).Value, rs.Fields(6).Value, Nothing, Nothing)
                    rs.MoveNext()

                    cont = cont + 1
                Loop
            End With
        Catch ex As Exception
            MsgBox("Ocorreu um erro durante o carregamento" + vbNewLine &
                   "Tente novamente mais tarde", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
        End Try
    End Sub

    Sub carregaDadosUsuario()
        Try
            sql = "SELECT * FROM tb_clientes ORDER BY nome ASC"
            rs = db.Execute(sql)

            cont = 1
            With Dashboard.dgvDadosUsuarios
                .Rows.Clear()

                Do While rs.EOF = False
                    .Rows.Add(cont, rs.Fields(1).Value, rs.Fields(2).Value, rs.Fields(3).Value, rs.Fields(4).Value, rs.Fields(7).Value, rs.Fields(5).Value, rs.Fields(6).Value, rs.Fields(8).Value, rs.Fields(10).Value, Nothing, Nothing)
                    rs.MoveNext()

                    cont = cont + 1
                Loop
            End With
        Catch ex As Exception
            MsgBox("Ocorreu um erro durante o carregamento" + vbNewLine &
                   "Tente novamente mais tarde", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
        End Try
    End Sub

    Sub limpaLogin()
        Try
            With Login
                .txtUsuario.Clear()
                .txtSenha.Clear()
                .txtUsuario.Focus()
            End With
        Catch ex As Exception
            Exit Sub
        End Try
    End Sub

    Sub limpaCadastro()
        Try
            With frmCadastraUsuario
                .txtNome.Clear()
                .txtSobrenome.Clear()
                .txtDataNascimento.Clear()
                .txtCpf.Clear()
                .txtFone.Clear()
                .txtCep.Clear()
                .txtEmail.Clear()
                .txtSenha.Clear()
                .txtRepeteSenha.Clear()
                .txtNome.Focus()
            End With
        Catch ex As Exception
            Exit Sub
        End Try
    End Sub

    Sub limpaRecuperaSenha()
        With frmRecuperaSenha
            .txtEmail.Clear()
            .txtSenha.Clear()
            .txtRepeteSenha.Clear()
            .txtEmail.Focus()
        End With
    End Sub

    Sub limpaEvento()
        Try
            With frmAdicionaEvento
                .txtNome.Clear()
                .txtDescricao.Clear()
                .txtData.Clear()
                .txtHora.Clear()
                .txtCep.Clear()
                .txtEndereco.Clear()
                .txtBairro.Clear()
                .txtCidade.Clear()
                .txtUf.Clear()
                .cmbParticipantes.SelectedIndex = 0

                .txtNome.Focus()
            End With
        Catch ex As Exception
            Exit Sub
        End Try
    End Sub

    Sub limpaProduto()
        Try
            With frmAdicionaProduto
                .txtNome.Clear()
                .txtDescricao.Clear()
                .cmbTipo.SelectedIndex = 0
                .cmbClasse.SelectedIndex = 0
                .cmbUva.SelectedIndex = 0
                .txtSafra.Clear()
                .txtPais.Clear()
                .txtRegião.Clear()
                .txtPreco.Clear()
                .txtProdutores.Clear()
                .txtTeorAlcoolico.Clear()
                .txtHarmonizacao.Clear()
                .txtVisual.Clear()
                .txtQtdeEmEstoque.Clear()
                .imgProduto.Load(Application.StartupPath & "\img\add_image.png")

                .txtNome.Focus()
            End With
        Catch ex As Exception
            Exit Sub
        End Try
    End Sub

    Sub limpaProducao()
        Try
            With frmAdicionaProducao
                .cmbProcesso.SelectedIndex = 0
                .txtDataInicio.Clear()
                .TxtDataFim.Clear()
                .cmbFornecedores.SelectedIndex = 0
                .cmbProduto.SelectedIndex = 0
            End With
        Catch ex As Exception
            Exit Sub
        End Try
    End Sub
End Module