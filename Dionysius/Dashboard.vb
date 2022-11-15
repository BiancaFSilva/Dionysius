Public Class Dashboard
    Private Sub Dashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call conectaDataBase()
        Call carregaDadosVinho()
        Call carregaDadosProducao()
        Call carregaDadosEvento()
        Call carregaDadosFornecedores()
        Call carregaDadosUsuario()
    End Sub

    ' Ações do MenuStrip
    Private Sub DionysiusToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DionysiusToolStripMenuItem.Click
        Try
            Home.ShowDialog()
        Catch ex As Exception
            MsgBox("Ocorreu um erro durante o carregamento da página", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
            Exit Sub
        End Try
    End Sub

    Private Sub CatálogoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CatálogoToolStripMenuItem.Click
        Try
            Catalogo.ShowDialog()
        Catch ex As Exception
            MsgBox("Ocorreu um erro durante o carregamento da página", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
            Exit Sub
        End Try
    End Sub

    Private Sub FornecedoresToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FornecedoresToolStripMenuItem.Click
        Try
            Fornecedores.ShowDialog()
        Catch ex As Exception
            MsgBox("Ocorreu um erro durante o carregamento da página", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
            Exit Sub
        End Try
    End Sub

    Private Sub EventosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EventosToolStripMenuItem.Click
        Try
            Eventos.ShowDialog()
        Catch ex As Exception
            MsgBox("Ocorreu um erro durante o carregamento da página", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
            Exit Sub
        End Try
    End Sub

    Private Sub SairDoSistemaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SairDoSistemaToolStripMenuItem.Click
        Try
            Application.Exit()
        Catch ex As Exception
            Exit Sub
        End Try
    End Sub

    ' Ações do TabControl
    Private Sub btnAdicionaVinho_Click(sender As Object, e As EventArgs) Handles btnAdicionaVinho.Click
        Try
            frmAdicionaProduto.btnAdicionaProduto.Text = "Adicionar Produto"
            frmAdicionaProduto.ShowDialog()
        Catch ex As Exception
            MsgBox("Ocorreu um erro durante o carregamento", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
            Exit Sub
        End Try
    End Sub

    Private Sub btnAdicionaProducao_Click(sender As Object, e As EventArgs) Handles btnAdicionaProducao.Click
        Try
            frmAdicionaProducao.btnCadastraProducao.Text = "Adicionar Processo"
            frmAdicionaProducao.ShowDialog()
        Catch ex As Exception
            MsgBox("Ocorreu um erro durante o carregamento", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
            Exit Sub
        End Try
    End Sub

    Private Sub btnAdicionaEvento_Click(sender As Object, e As EventArgs) Handles btnAdicionaEvento.Click
        Try
            frmAdicionaEvento.btnAdicionarEvento.Text = "Adicionar Evento"
            frmAdicionaEvento.ShowDialog()
        Catch ex As Exception
            MsgBox("Ocorreu um erro durante o carregamento", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
            Exit Sub
        End Try
    End Sub

    Private Sub btnAdicionaFornecedor_Click(sender As Object, e As EventArgs) Handles btnAdicionaFornecedor.Click
        Try
            frmCadastraFornecedor.btnCadastrar.Text = "Adicionar Fornecedor"
            frmCadastraFornecedor.ShowDialog()
        Catch ex As Exception
            MsgBox("Ocorreu um erro durante o carregamento", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
            Exit Sub
        End Try
    End Sub

    Private Sub btnAdicionaUsuario_Click(sender As Object, e As EventArgs) Handles btnAdicionaUsuario.Click
        Try
            frmCadastraUsuario.btnCadastrar.Text = "Cadastrar"
            frmCadastraUsuario.ShowDialog()
        Catch ex As Exception
            MsgBox("Ocorreu um erro durante o carregamento", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
            Exit Sub
        End Try
    End Sub

    ' Ações do DataGridView
    Private Sub dgvDadosVinho_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvDadosVinho.CellContentClick
        Try
            With dgvDadosVinho
                aux = .CurrentRow.Cells(1).Value

                If .CurrentRow.Cells(13).Selected Then
                    frmAdicionaProduto.btnAdicionaProduto.Text = "Atualizar Produto"
                    frmAdicionaProduto.ShowDialog()
                ElseIf .CurrentRow.Cells(14).Selected Then
                    resp = MsgBox("Deseja realmente excluir os dados referentes à este produto?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "ATENÇÃO")
                    If resp = vbYes Then
                        sql = "DELETE * FROM tb_vinhos WHERE nome = '" & aux & "'"
                        rs = db.Execute(sql)

                        Call carregaDadosVinho()
                    End If
                Else
                    Exit Sub
                End If
            End With
        Catch ex As Exception
            MsgBox("Ocorreu um erro durante o carregamento da seleção" + vbNewLine &
                   "Tente novamente mais tarde", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
            Exit Sub
        End Try
    End Sub

    Private Sub dgvDadosProducao_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvDadosProducao.CellContentClick
        Try
            With dgvDadosProducao
                aux = .CurrentRow.Cells(1).Value

                If .CurrentRow.Cells(6).Selected Then
                    frmAdicionaProducao.btnCadastraProducao.Text = "Atualizar Processo"
                    frmAdicionaProducao.ShowDialog()
                ElseIf .CurrentRow.Cells(7).Selected Then
                    resp = MsgBox("Deseja realmente excluir os dados referentes à este processo de fabricação?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "ATENÇÃO")
                    If resp = vbYes Then
                        sql = "DELETE * FROM tb_fabricacao WHERE produto_relacionado = '" & aux & "'"
                        rs = db.Execute(sql)

                        Call carregaDadosProducao()
                    End If
                Else
                    Exit Sub
                End If
            End With
        Catch ex As Exception
            MsgBox("Ocorreu um erro durante o carregamento da seleção" + vbNewLine &
                   "Tente novamente mais tarde", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
            Exit Sub
        End Try
    End Sub

    Private Sub dgvDadosEvento_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvDadosEvento.CellContentClick
        Try
            With dgvDadosEvento
                aux = .CurrentRow.Cells(1).Value

                If .CurrentRow.Cells(11).Selected Then
                    frmAdicionaEvento.btnAdicionarEvento.Text = "Atualizar Evento"
                    frmAdicionaEvento.ShowDialog()
                ElseIf .CurrentRow.Cells(12).Selected Then
                    resp = MsgBox("Deseja realmente excluir os dados referentes à este evento?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "ATENÇÃO")
                    If resp = vbYes Then
                        sql = "DELETE * FROM tb_eventos WHERE nome = '" & aux & "'"
                        rs = db.Execute(sql)

                        Call carregaDadosEvento()
                    End If
                Else
                    Exit Sub
                End If
            End With
        Catch ex As Exception
            MsgBox("Ocorreu um erro durante o carregamento da seleção" + vbNewLine &
                   "Tente novamente mais tarde", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
            Exit Sub
        End Try
    End Sub

    Private Sub dgvDadosFornecedores_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvDadosFornecedores.CellContentClick
        Try
            With dgvDadosFornecedores
                aux = .CurrentRow.Cells(1).Value

                If .CurrentRow.Cells(7).Selected Then
                    frmCadastraFornecedor.btnCadastrar.Text = "Atualizar Fornecedor"
                    frmCadastraFornecedor.ShowDialog()
                ElseIf .CurrentRow.Cells(8).Selected Then
                    resp = MsgBox("Deseja realmente excluir os dados referentes à este fornecedor?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "ATENÇÃO")
                    If resp = vbYes Then
                        sql = "DELETE * FROM tb_fornecedores WHERE nome = '" & aux & "'"
                        rs = db.Execute(sql)

                        Call carregaDadosFornecedores()
                    End If
                Else
                    Exit Sub
                End If
            End With
        Catch ex As Exception
            MsgBox("Ocorreu um erro durante o carregamento da seleção" + vbNewLine &
                   "Tente novamente mais tarde", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
            Exit Sub
        End Try
    End Sub

    Private Sub dgvDadosUsuarios_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvDadosUsuarios.CellContentClick
        Try
            With dgvDadosUsuarios
                aux = .CurrentRow.Cells(1).Value

                If .CurrentRow.Cells(10).Selected Then
                    frmCadastraUsuario.lblCadastraUsuario.Text = "Atualizar Conta"
                    frmCadastraUsuario.btnCadastrar.Text = "Atualizar"
                    frmCadastraUsuario.ShowDialog()
                ElseIf .CurrentRow.Cells(11).Selected Then
                    resp = MsgBox("Deseja realmente excluir os dados referentes à este usuário?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "ATENÇÃO")
                    If resp = vbYes Then
                        sql = "DELETE * FROM tb_clientes WHERE nome = '" & aux & "'"
                        rs = db.Execute(sql)

                        Call carregaDadosUsuario()
                    End If
                Else
                    Exit Sub
                End If
            End With
        Catch ex As Exception
            MsgBox("Ocorreu um erro durante o carregamento da seleção" + vbNewLine &
                   "Tente novamente mais tarde", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
            Exit Sub
        End Try
    End Sub

    ' Transfere dados do DataGridView para Form
    Private Sub dgvDadosVinho_CellEnter(sender As Object, e As DataGridViewCellEventArgs) Handles dgvDadosVinho.CellEnter
        Try
            With dgvDadosVinho.Rows(dgvDadosVinho.CurrentCell.RowIndex)
                camposProduto(0) = .Cells("IdProduto").Value
            End With
        Catch ex As Exception
            Exit Sub
        End Try
    End Sub

    Private Sub dgvDadosProducao_CellEnter(sender As Object, e As DataGridViewCellEventArgs) Handles dgvDadosProducao.CellEnter
        Try
            With dgvDadosProducao.Rows(dgvDadosProducao.CurrentCell.RowIndex)
                camposProducao(0) = .Cells("IdProducao").Value
            End With
        Catch ex As Exception
            Exit Sub
        End Try
    End Sub

    Private Sub dgvDadosEvento_CellEnter(sender As Object, e As DataGridViewCellEventArgs) Handles dgvDadosEvento.CellEnter
        Try
            With dgvDadosEvento.Rows(dgvDadosEvento.CurrentCell.RowIndex)
                camposEvento(0) = .Cells("IdEvento").Value
            End With
        Catch ex As Exception
            Exit Sub
        End Try
    End Sub

    Private Sub dgvDadosFornecedores_CellEnter(sender As Object, e As DataGridViewCellEventArgs) Handles dgvDadosFornecedores.CellEnter
        Try
            With dgvDadosFornecedores.Rows(dgvDadosFornecedores.CurrentCell.RowIndex)
                camposFornecedor(0) = .Cells("IdFornecedor").Value
            End With
        Catch ex As Exception
            Exit Sub
        End Try
    End Sub

    Private Sub dgvDadosUsuarios_CellEnter(sender As Object, e As DataGridViewCellEventArgs) Handles dgvDadosUsuarios.CellEnter
        Try
            With dgvDadosUsuarios.Rows(dgvDadosUsuarios.CurrentCell.RowIndex)
                camposUsuario(0) = .Cells("IdUsuario").Value
            End With
        Catch ex As Exception
            Exit Sub
        End Try
    End Sub
End Class