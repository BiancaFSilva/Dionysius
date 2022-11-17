Public Class Fornecedores
    Private Sub DionysiusToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DionysiusToolStripMenuItem.Click
        Try
            Home.ShowDialog()
            Me.Close()
        Catch ex As Exception
            MsgBox("Ocorreu um erro durante o carregamento da página", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
            Exit Sub
        End Try
    End Sub

    Private Sub CatálogoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CatálogoToolStripMenuItem.Click
        Try
            Catalogo.ShowDialog()
            Me.Close()
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

    Private Sub FavoritosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FavoritosToolStripMenuItem.Click
        Try
            frmFavoritos.ShowDialog()
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

    Private Sub lblContatoFornecedor_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lblContatoFornecedor.LinkClicked
        Try
            frmCadastraFornecedor.ShowDialog()
        Catch ex As Exception
            Exit Sub
        End Try
    End Sub
End Class