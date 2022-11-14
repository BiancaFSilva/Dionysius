Public Class frmAdicionaProduto
    Private Sub frmAdicionaProduto_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call conectaDataBase()
        Call limpaProduto()

        With cmbTipo.Items
            .Add("")
            .Add("Vinho Tinto")
            .Add("Vinho Branco")
            .Add("Vinho Rosé")
            .Add("Espumante")
        End With

        With cmbClasse.Items
            .Add("")
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
            .Add("")
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
                .InitialDirectory = Application.StartupPath & "\img"
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
                    MsgBox("Este produto já está cadastrado!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "AVISO")
                    Call limpaProduto()
                    Exit Sub
                Else
                    sql = "INSERT INTO tb_vinhos (nome, descricao, tipo, classificacao, safra, uva, pais, regiao, preco, produtor, teor_alcoolico, harmonizacao, visual, qtde_estoque, img)" &
                          "VALUES ('" & txtNome.Text & "', '" & txtDescricao.Text & "', '" & cmbTipo.SelectedItem & "', '" & cmbClasse.SelectedItem & "', '" & txtSafra.Text & "', '" & cmbUva.SelectedItem & "', '" & txtPais.Text & "', '" & txtRegião.Text & "', '" & txtPreco.Text & "', '" & txtProdutores.Text & "', '" & txtTeorAlcoolico.Text & "', '" & txtHarmonizacao.Text & "', '" & txtVisual.Text & "', '" & txtQtdeEmEstoque.Text & "', '" & dir & "')"
                    rs = db.Execute(UCase(sql))

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
            MsgBox("Ocorreu um erro e não foi possível adicionar o evento.", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
            Exit Sub
        End Try
    End Sub
End Class