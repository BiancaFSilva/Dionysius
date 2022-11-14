Public Class Dashboard
    Private Sub Dashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call conectaDataBase()
        Call carregaDadosVinho()
        Call carregaDadosProducao()
        Call carregaDadosEvento()
        Call carregaDadosFornecedores()
        Call carregaDadosUsuario()
    End Sub

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

    Private Sub btnAdicionaVinho_Click(sender As Object, e As EventArgs) Handles btnAdicionaVinho.Click
        Try
            frmAdicionaProduto.ShowDialog()
        Catch ex As Exception
            MsgBox("Ocorreu um erro durante o carregamento", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
            Exit Sub
        End Try
    End Sub

    Private Sub btnAdicionaProducao_Click(sender As Object, e As EventArgs) Handles btnAdicionaProducao.Click
        Try
            frmAdicionaProducao.ShowDialog()
        Catch ex As Exception
            MsgBox("Ocorreu um erro durante o carregamento", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
            Exit Sub
        End Try
    End Sub

    Private Sub btnAdicionaEvento_Click(sender As Object, e As EventArgs) Handles btnAdicionaEvento.Click
        Try
            frmAdicionaEvento.ShowDialog()
        Catch ex As Exception
            MsgBox("Ocorreu um erro durante o carregamento", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
            Exit Sub
        End Try
    End Sub

    Private Sub btnAdicionaFornecedor_Click(sender As Object, e As EventArgs) Handles btnAdicionaFornecedor.Click
        Try
            frmCadastraFornecedor.ShowDialog()
        Catch ex As Exception
            MsgBox("Ocorreu um erro durante o carregamento", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
            Exit Sub
        End Try
    End Sub

    Private Sub btnAdicionaUsuario_Click(sender As Object, e As EventArgs) Handles btnAdicionaUsuario.Click
        Try

        Catch ex As Exception
            MsgBox("Ocorreu um erro durante o carregamento", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
            Exit Sub
        End Try
    End Sub

    Private Sub dgvDadosVinho_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvDadosVinho.CellContentClick
        Try
            With dgvDadosVinho
                aux = .CurrentRow.Cells(1).Value

                If .CurrentRow.Cells(12).Selected Then
                    frmAdicionaProduto.ShowDialog()
                ElseIf .CurrentRow.Cells(13).Selected Then
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

                If .CurrentRow.Cells(10).Selected Then
                    frmAdicionaEvento.ShowDialog()
                ElseIf .CurrentRow.Cells(11).Selected Then
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
End Class