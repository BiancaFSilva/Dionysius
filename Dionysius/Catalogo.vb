﻿Public Class Catalogo
    Private Sub Catalogo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call conectaDataBase()
    End Sub

    Private Sub MenuStrip1_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles MenuStrip1.ItemClicked
        Try
            Home.ShowDialog()
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

    Private Sub FavoritosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FavoritosToolStripMenuItem.Click

    End Sub
End Class