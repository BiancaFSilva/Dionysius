Public Class Fornecedores
    Private Sub Fornecedores_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call conectaDataBase()
    End Sub

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

    Private Sub lblContatoFornecedor_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lblContatoFornecedor.LinkClicked
        frmCadastraFornecedor.ShowDialog()
    End Sub
End Class