Public Class frmAdicionaProduto
    Private Sub frmAdicionaProduto_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call conectaDataBase()
        Call limpaProduto()

        If btnAdicionaProduto.Text = "Atualizar Produto" Then
            lblId.Visible = True
            txtId.Visible = True

            aux = camposProduto(0)
            sql = "SELECT * FROM tb_vinhos WHERE id_vinho = " & aux & ""
            rs = db.Execute(sql)

            Try
                txtId.Text = rs.Fields(0).Value
                txtNome.Text = rs.Fields(1).Value
                txtDescricao.Text = rs.Fields(2).Value
                cmbTipo.Text = rs.Fields(3).Value
                cmbClasse.Text = rs.Fields(4).Value
                txtSafra.Text = rs.Fields(5).Value
                cmbUva.Text = rs.Fields(6).Value
                txtPais.Text = rs.Fields(7).Value
                txtRegião.Text = rs.Fields(8).Value
                txtPreco.Text = rs.Fields(9).Value
                txtProdutores.Text = rs.Fields(10).Value
                txtTeorAlcoolico.Text = rs.Fields(11).Value
                txtHarmonizacao.Text = rs.Fields(12).Value
                txtVisual.Text = rs.Fields(13).Value
                txtQtdeEmEstoque.Text = rs.Fields(14).Value

                imgProduto.Load(rs.Fields(15).Value)
            Catch ex As Exception
                Exit Try
            End Try
        Else
            Call limpaProduto()
        End If

        With cmbTipo.Items
            .Add("Vinho Tinto")
            .Add("Vinho Branco")
            .Add("Vinho Rosé")
            .Add("Espumante")
        End With

        With cmbClasse.Items
            .Add("Seco")
            .Add("Suave")
            .Add("Demi-Seco")
            .Add("Doce")
            .Add("Fortificado")
            .Add("Licoroso")
            .Add("Brut")
            .Add("Extra Brut")
            .Add("Nature")
        End With

        With cmbUva.Items
            .Add("Alvarinho")
            .Add("Cabernet")
            .Add("Cabernet Franc")
            .Add("Cabernet Sauvignon")
            .Add("Chardonnay")
            .Add("Chenin Blanc")
            .Add("Gewürztraminer")
            .Add("Malbec")
            .Add("Merlot")
            .Add("Muscat")
            .Add("Pinot Grigio (Grauburgunder)")
            .Add("Pinot Noir")
            .Add("Riesling")
            .Add("Sauvignon Blanc")
            .Add("Sémillon")
            .Add("Syrah")
            .Add("Tannat")
            .Add("Tempranillo (Aragonez)")
            .Add("Torrontés")
            .Add("Touriga Franca")
            .Add("Touriga Nacional")
            .Add("Viognier")
        End With
    End Sub

    Private Sub imgProduto_Click(sender As Object, e As EventArgs) Handles imgProduto.Click
        Try
            With OpenFileDialog1
                .Title = "Selecione uma foto"
                .InitialDirectory = Application.StartupPath & "\img\produtos\sinenomine.png"
                .ShowDialog()

                dir = .FileName
                imgProduto.Load(dir)
            End With
        Catch ex As Exception
            Exit Sub
        End Try
    End Sub

    Private Sub btnAdicionaProduto_Click(sender As Object, e As EventArgs) Handles btnAdicionaProduto.Click
        Try
            If txtNome.Text = "" Or txtDescricao.Text = "" Or txtSafra.Text = "" Or txtPais.Text = "" Or txtRegião.Text = "" Or txtPreco.Text = "" Or txtProdutores.Text = "" Or txtTeorAlcoolico.Text = "" Or txtHarmonizacao.Text = "" Or txtVisual.Text = "" Or txtQtdeEmEstoque.Text = "" Then
                MsgBox("Preencha todos os campos!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "AVISO")
                Exit Sub
            Else
                sql = "SELECT * FROM tb_vinhos WHERE nome = '" & txtNome.Text & "'"
                rs = db.Execute(sql)

                If rs.EOF = False Then
                    If btnAdicionaProduto.Text = "Atualizar Produto" Then
                        sql = "UPDATE tb_vinhos SET nome = '" & txtNome.Text & "', descricao = '" & txtDescricao.Text & "', tipo = '" & cmbTipo.Text & "', classificacao = '" & cmbClasse.Text & "', " &
                              "safra = '" & txtSafra.Text & "', uva = '" & cmbUva.Text & "', pais = '" & txtPais.Text & "', regiao = '" & txtRegião.Text & "', preco = '" & txtPreco.Text & "', produtor = '" & txtProdutores.Text & "', " &
                              "teor_alcoolico = '" & txtTeorAlcoolico.Text & "', harmonizacao = '" & txtHarmonizacao.Text & "', visual = '" & txtVisual.Text & "', qtde_estoque = '" & txtQtdeEmEstoque.Text & "', " &
                              "img = '" & dir & "' WHERE id_vinho = " & txtId.Text & ""
                        rs = db.Execute(sql)

                        Call carregaDadosVinho()
                        Call limpaProduto()

                        MsgBox("Dados do produto alterados com sucesso!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "AVISO")
                        Me.Close()
                    Else
                        Exit Sub
                    End If
                Else
                    sql = "INSERT INTO tb_vinhos (nome, descricao, tipo, classificacao, safra, uva, pais, regiao, preco, produtor, teor_alcoolico, harmonizacao, visual, qtde_estoque, img)" &
                          "VALUES ('" & txtNome.Text & "', '" & txtDescricao.Text & "', '" & cmbTipo.Text & "', '" & cmbClasse.Text & "', '" & txtSafra.Text & "', '" & cmbUva.Text & "', " &
                          "'" & txtPais.Text & "', '" & txtRegião.Text & "', '" & txtPreco.Text & "', '" & txtProdutores.Text & "', '" & txtTeorAlcoolico.Text & "', '" & txtHarmonizacao.Text & "', " &
                          "'" & txtVisual.Text & "', '" & txtQtdeEmEstoque.Text & "', '" & dir & "')"
                    rs = db.Execute(sql)

                    Call carregaDadosVinho()

                    resp = MsgBox("Produto cadastrado com sucesso!" + vbNewLine &
                                  "Deseja cadastrar outro produto?", MsgBoxStyle.Information + MsgBoxStyle.YesNo, "AVISO")
                    If resp = vbYes Then
                        Call limpaProduto()
                    Else
                        Me.Close()
                    End If
                End If
            End If
        Catch ex As Exception
            MsgBox("Ocorreu um erro e não foi possível adicionar o produto.", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
            Exit Sub
        End Try
    End Sub
End Class