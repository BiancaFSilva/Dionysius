Public Class Home
    Private Sub btnVerCatalogo_Click(sender As Object, e As EventArgs)
        Try
            Catalogo.ShowDialog()
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

    Private Sub FornecedoresToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FornecedoresToolStripMenuItem.Click
        Try
            Fornecedores.ShowDialog()
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

    Private Sub SairDoSistemaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SairDoSistemaToolStripMenuItem.Click
        Try
            Application.Exit()
        Catch ex As Exception
            Exit Sub
        End Try
    End Sub

    Private Sub btnVerCatalogo_Click_1(sender As Object, e As EventArgs) Handles btnVerCatalogo.Click
        Try
            Process.Start(Application.StartupPath & "\db\Dionysius.mdb")
        Catch ex As Exception
            MsgBox("Ocorreu um erro durante o carregamento da página", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
            Exit Sub
        End Try
    End Sub
End Class