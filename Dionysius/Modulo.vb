Imports System.Windows.Forms.DataVisualization.Charting

Module Modulo
    ' Variáveis de conexão com o banco de dados
    Public db As New ADODB.Connection
    Public rs As New ADODB.Recordset
    Public dirDb = Application.StartupPath & "\db\Dionysius.mdb"

    ' Variáveis Globais
    Public dir, sql As String
    Public resp, aux As String
    Public cont As Integer

    ' Variáveis para comunicação entre DataGridView e Form
    Public camposProduto(1) As String
    Public camposProducao(1) As String
    Public camposEvento(1) As String
    Public camposFornecedor(1) As String
    Public camposUsuario(1) As String

    Sub conectaDataBase()
        Try
            ' Inicializa a conexão com o banco de dados e informao banco que deve ser aberto
            db = CreateObject("ADODB.Connection")
            db.Open("Provider=Microsoft.JET.OLEDB.4.0;Data Source=" & dirDb)

            ' MsgBox("Conexão realizada com sucesso", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "AVISO")
        Catch ex As Exception
            MsgBox("Ocorreu um erro durante a conexão" + vbNewLine &
                   "Tente novamente mais tarde", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
        End Try
    End Sub

    ' Carregar os dados do DataGridView de cada parte do Dashboard
    Sub carregaDadosVinho()
        Try
            sql = "SELECT * FROM tb_vinhos ORDER BY nome ASC"
            rs = db.Execute(sql)

            cont = 1
            With Dashboard.dgvDadosVinho
                .Rows.Clear()

                Do While rs.EOF = False
                    .Rows.Add(rs.Fields(0).Value, rs.Fields(1).Value, rs.Fields(2).Value, rs.Fields(3).Value, rs.Fields(4).Value, rs.Fields(5).Value, rs.Fields(6).Value, rs.Fields(7).Value & ", " & rs.Fields(8).Value, rs.Fields(11).Value, rs.Fields(12).Value, rs.Fields(14).Value, rs.Fields(9).Value, rs.Fields(15).Value, Nothing, Nothing)
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
                    .Rows.Add(rs.Fields(0).Value, rs.Fields(5).Value, rs.Fields(1).Value, rs.Fields(2).Value, rs.Fields(3).Value, rs.Fields(4).Value, Nothing, Nothing)
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
                    .Rows.Add(rs.Fields(0).Value, rs.Fields(1).Value, rs.Fields(2).Value, rs.Fields(3).Value, rs.Fields(4).Value, rs.Fields(5).Value, rs.Fields(6).Value, rs.Fields(7).Value, rs.Fields(8).Value, rs.Fields(9).Value, rs.Fields(10).Value, Nothing, Nothing)
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
                    .Rows.Add(rs.Fields(0).Value, rs.Fields(1).Value, rs.Fields(2).Value, rs.Fields(4).Value, rs.Fields(5).Value, rs.Fields(3).Value, rs.Fields(6).Value, Nothing, Nothing)
                    rs.MoveNext()

                    cont += 1
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
                    .Rows.Add(rs.Fields(0).Value, rs.Fields(1).Value, rs.Fields(2).Value, rs.Fields(3).Value, rs.Fields(4).Value, rs.Fields(7).Value, rs.Fields(5).Value, rs.Fields(6).Value, rs.Fields(8).Value, rs.Fields(10).Value, Nothing, Nothing)
                    rs.MoveNext()

                    cont = cont + 1
                Loop
            End With
        Catch ex As Exception
            MsgBox("Ocorreu um erro durante o carregamento" + vbNewLine &
                   "Tente novamente mais tarde", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
        End Try
    End Sub

    ' Reseta os dados do sistema
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
                .cmbStatusUsuario.Items.Clear()

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
                .cmbParticipantes.Items.Clear()

                .cmbParticipantes.SelectedIndex = -1

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
                .cmbTipo.Items.Clear()
                .cmbClasse.Items.Clear()
                .cmbUva.Items.Clear()
                .txtSafra.Clear()
                .txtPais.Clear()
                .txtRegião.Clear()
                .txtPreco.Clear()
                .txtProdutores.Clear()
                .txtTeorAlcoolico.Clear()
                .txtHarmonizacao.Clear()
                .txtVisual.Clear()
                .txtQtdeEmEstoque.Clear()
                .imgProduto.Refresh()
                .imgProduto.Load(Application.StartupPath & "\img\produtos\sinenomine.png")

                .cmbTipo.Text = ""
                .cmbClasse.Text = ""
                .cmbUva.Text = ""

                .txtNome.Focus()
            End With
        Catch ex As Exception
            Exit Sub
        End Try
    End Sub

    Sub limpaProducao()
        Try
            With frmAdicionaProducao
                .cmbProcesso.Items.Clear()
                .txtDataInicio.Clear()
                .TxtDataFim.Clear()
                .cmbFornecedores.Items.Clear()
                .cmbProduto.Items.Clear()

                .cmbProcesso.SelectedIndex = -1
                .cmbFornecedores.SelectedIndex = -1
                .cmbProduto.SelectedIndex = -1
            End With
        Catch ex As Exception
            Exit Sub
        End Try
    End Sub

    Sub limpaFornecedores()
        Try
            With frmCadastraFornecedor
                .txtNome.Clear()
                .txtRamo.Clear()
                .txtProdutoFornecido.Clear()
                .txtEmail.Clear()
                .txtFone.Clear()
                .txtCep.Clear()

                .txtNome.Focus()
            End With
        Catch ex As Exception
            Exit Sub
        End Try
    End Sub

    Sub limpaBusca()
        Try
            With Catalogo
                .lstBuscaProduto.Items.Clear()
                .lblNomeSafraProduto.Text = " "
                .lblTipoClasseProduto.Text = " "
                .lblDescricaoProduto.Text = " "
                .lblDadosGerais.Text = " "
                .imgProduto.Visible = False
            End With
        Catch ex As Exception
            Exit Sub
        End Try
    End Sub

    ' Desenha os gráficos do Dashboard
    Sub desenhaGrafico()
        Try
            Dim tinto, branco, rose, espumante As Integer
            Dim seco, suave, demiSeco, doce, fortificado, licoroso, brut, extraBrut, nature As Integer
            Dim arg, aus, bra, chi, esp, fra, geo, ita, por, uru As Integer

            If Dashboard.dgvDadosVinho.ColumnHeadersVisible = True Then
                For Each c As DataGridViewRow In Dashboard.dgvDadosVinho.Rows
                    If c.Cells(3).Value <> "" Then
                        If c.Cells(3).Value = "Vinho Tinto" Then
                            tinto += 1
                        ElseIf c.Cells(3).Value = "Vinho Branco" Then
                            branco += 1
                        ElseIf c.Cells(3).Value = "Vinho Rosé" Then
                            rose += 1
                        ElseIf c.Cells(3).Value = "Espumante" Then
                            espumante += 1
                        End If
                    End If
                Next
            End If

            If Dashboard.dgvDadosVinho.ColumnHeadersVisible = True Then
                For Each c As DataGridViewRow In Dashboard.dgvDadosVinho.Rows
                    If c.Cells(4).Value <> "" Then
                        If c.Cells(4).Value = "Seco" Then
                            seco += 1
                        ElseIf c.Cells(4).Value = "Suave" Then
                            suave += 1
                        ElseIf c.Cells(4).Value = "Demi-Seco" Then
                            demiSeco += 1
                        ElseIf c.Cells(4).Value = "Doce" Then
                            doce += 1
                        ElseIf c.Cells(4).Value = "Fortificado" Then
                            fortificado += 1
                        ElseIf c.Cells(4).Value = "Licoroso" Then
                            licoroso += 1
                        ElseIf c.Cells(4).Value = "Brut" Then
                            brut += 1
                        ElseIf c.Cells(4).Value = "Extra Brut" Then
                            extraBrut += 1
                        ElseIf c.Cells(4).Value = "Nature" Then
                            nature += 1
                        End If
                    End If
                Next
            End If

            If Dashboard.dgvDadosVinho.ColumnHeadersVisible = True Then
                For Each c As DataGridViewRow In Dashboard.dgvDadosVinho.Rows
                    If c.Cells(7).Value <> "" Then
                        If c.Cells(7).Value = "Argentina, Cafayate" Or c.Cells(7).Value = "Argentina, General Roca, Rio Negro - Patagônia" Or c.Cells(7).Value = "Argentina, Mendoza" Or c.Cells(7).Value = "Argentina, Salta" Or c.Cells(7).Value = "Argentina, San Juan (Vale de Tulum)" Then
                            arg += 1
                        ElseIf c.Cells(7).Value = "Austrália, Riverina" Then
                            aus += 1
                        ElseIf c.Cells(7).Value = "Brasil, Espírito Santo do Pinhal" Or c.Cells(7).Value = "Brasil, Rio Grande do Sul" Or c.Cells(7).Value = "Brasil, Serra Gaúcha" Or c.Cells(7).Value = "Brasil, Vale dos Vinhedos" Then
                            bra += 1
                        ElseIf c.Cells(7).Value = "Chile, Maipo" Or c.Cells(7).Value = "Chile, Maule" Or c.Cells(7).Value = "Chile, Vale Central" Or c.Cells(7).Value = "Chile, Vale de Casablanca" Or c.Cells(7).Value = "Chile, Vale do Colchagua" Or c.Cells(7).Value = "Chile, Vale do Maipo" Or c.Cells(7).Value = "Chile, Vale do Cachapoal" Then
                            chi += 1
                        ElseIf c.Cells(7).Value = "Espanha, Valência" Or c.Cells(7).Value = "Espanha, Jumilla" Or c.Cells(7).Value = "Espanha, La Mancha" Or c.Cells(7).Value = "Espanha, Catalunha" Then
                            esp += 1
                        ElseIf c.Cells(7).Value = "França, Aquitânia" Or c.Cells(7).Value = "França, Bordeaux" Or c.Cells(7).Value = "França, Borgonha" Or c.Cells(7).Value = "França, Languedoc" Or c.Cells(7).Value = "França, Languedoc-Roussillon" Or c.Cells(7).Value = "França, Val de Loire" Then
                            fra += 1
                        ElseIf c.Cells(7).Value = "Geórgia, Kakheti" Then
                            geo += 1
                        ElseIf c.Cells(7).Value = "Itália, Piemonte" Or c.Cells(7).Value = "Itália, Puglia" Or c.Cells(7).Value = "Itália, Sicília" Or c.Cells(7).Value = "Itália, Toscana" Or c.Cells(7).Value = "Itália, Veneto" Then
                            ita += 1
                        ElseIf c.Cells(7).Value = "Portugal, Vinho Verde" Or c.Cells(7).Value = "Portugal, Dão" Or c.Cells(7).Value = "Portugal, Douro" Then
                            por += 1
                        ElseIf c.Cells(7).Value = "Uruguai, Maldonado" Then
                            uru += 1
                        End If
                    End If
                Next
            End If

            With Dashboard.ChartRelacaoProdutos
                .Series("Produto").Points.AddXY("Vinho Tinto", tinto)
                .Series("Produto").Points.AddXY("Vinho Branco", branco)
                .Series("Produto").Points.AddXY("Vinho Rosé", rose)
                .Series("Produto").Points.AddXY("Espumante", espumante)
            End With

            With Dashboard.ChartRelacaoClasse
                .Series("Classificacao").Points.AddXY("Seco", seco)
                .Series("Classificacao").Points.AddXY("Suave", suave)
                .Series("Classificacao").Points.AddXY("Demi-Seco", demiSeco)
                .Series("Classificacao").Points.AddXY("Doce", doce)
                .Series("Classificacao").Points.AddXY("Fortificado", fortificado)
                .Series("Classificacao").Points.AddXY("Licoroso", licoroso)
                .Series("Classificacao").Points.AddXY("Brut", brut)
                .Series("Classificacao").Points.AddXY("Extra Brut", extraBrut)
                .Series("Classificacao").Points.AddXY("Nature", nature)
            End With

            With Dashboard.ChartPaises
                .Series("Paises").Points.AddXY("Argentina", arg)
                .Series("Paises").Points.AddXY("Austrália", aus)
                .Series("Paises").Points.AddXY("Brasil", bra)
                .Series("Paises").Points.AddXY("Chile", chi)
                .Series("Paises").Points.AddXY("Espanha", esp)
                .Series("Paises").Points.AddXY("França", fra)
                .Series("Paises").Points.AddXY("Geórgia", geo)
                .Series("Paises").Points.AddXY("Itália", ita)
                .Series("Paises").Points.AddXY("Portugal", por)
                .Series("Paises").Points.AddXY("Uruguai", uru)
            End With
        Catch ex As Exception
            Exit Sub
        End Try
    End Sub
End Module