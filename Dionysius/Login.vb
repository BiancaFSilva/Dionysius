Public Class Login
    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call conectaDataBase()
    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Try
            Dashboard.ShowDialog()
        Catch ex As Exception
            MsgBox("Ocorreu um erro durante o processamento" + vbNewLine &
                   "Tente novamente mais tarde", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
        End Try
    End Sub

    Private Sub btnCriaConta_Click(sender As Object, e As EventArgs) Handles btnCriaConta.Click

    End Sub

    Private Sub imgVerSenha_Click(sender As Object, e As EventArgs) Handles imgVerSenha.Click

    End Sub

    Private Sub lblEsqueceuSenha_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lblEsqueceuSenha.LinkClicked

    End Sub
End Class
