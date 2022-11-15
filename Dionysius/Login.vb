Public Class Login
    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call conectaDataBase()
    End Sub

    Private Sub btnCriaConta_Click(sender As Object, e As EventArgs) Handles btnCriaConta.Click
        Try
            frmCadastraUsuario.ShowDialog()
        Catch ex As Exception
            Exit Sub
        End Try
    End Sub

    Private Sub lblEsqueceuSenha_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lblEsqueceuSenha.LinkClicked
        Try
            frmRecuperaSenha.ShowDialog()
        Catch ex As Exception
            Exit Sub
        End Try
    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Try
            ' Login do usuário administrativo
            If txtUsuario.Text = "admin" And txtSenha.Text = "admin" Then
                MsgBox("Login realizado com sucesso!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "AVISO")

                With Dashboard
                    .tabControlDashboard.TabPages.RemoveByKey("tabProdutos")
                    .tabControlDashboard.TabPages.RemoveByKey("tabProducao")
                    .tabControlDashboard.TabPages.RemoveByKey("tabFornecedores")
                End With

                Dashboard.ShowDialog()
                Me.Close()
            ElseIf (txtUsuario.Text = "enólogo" Or txtUsuario.Text = "viticultor") And txtSenha.Text = "admin" Then
                MsgBox("Login realizado com sucesso!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "AVISO")

                With Dashboard
                    .tabControlDashboard.TabPages.RemoveByKey("tabUsuarios")
                End With

                Dashboard.ShowDialog()
                Me.Close()
            End If

            sql = "SELECT * FROM tb_clientes WHERE email = '" & txtUsuario.Text & "' AND senha = '" & txtSenha.Text & "'"
            rs = db.Execute(sql)

            ' Login dos usuários comuns
            If rs.EOF = False Then
                MsgBox("Login realizado com sucesso!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "AVISO")

                Home.ShowDialog()
                Me.Close()
            Else
                MsgBox("Usuário e/ou senha inválidos!" + vbNewLine &
                       "Tente novamente ou cadastre-se.", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "AVISO")
                Call limpaLogin()
            End If
        Catch ex As Exception
            MsgBox("Ocorreu um erro durante o processamento." + vbNewLine &
                   "Tente novamente mais tarde.", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
            Exit Sub
        End Try
    End Sub
End Class
