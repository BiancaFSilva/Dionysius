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
            Me.Close()
        Catch ex As Exception
            MsgBox("Ocorreu um erro durante o carregamento da página", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
            Exit Sub
        End Try
    End Sub

    Private Sub dgvDadosVinho_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvDadosVinho.CellContentClick
        Try
            With dgvDadosVinho
                If .CurrentRow.Cells(13).Selected Then
                    aux = .CurrentRow.Cells(1).Value

                    resp = MsgBox("Deseja realmente excluir os dados referentes à este produto?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "ATENÇÃO")
                    If resp = vbYes Then
                        sql = "DELETE * FROM tb_vinhos WHERE nome '" & aux & "'"
                        rs = db.Execute(sql)

                        carregaDadosVinho()
                    End If
                Else
                    Exit Sub
                End If
            End With
        Catch ex As Exception
            MsgBox("Ocorreu um erro durante o carregamento da seleção" + vbNewLine &
                   "Tente novamente mais tarde", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
        End Try
    End Sub
End Class