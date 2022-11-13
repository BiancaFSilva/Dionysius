Public Class frmRecuperaSenha
    Private Sub frmRecuperaSenha_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call conectaDataBase()
    End Sub

    Private Sub chkVerSenha_CheckedChanged(sender As Object, e As EventArgs) Handles chkVerSenha.CheckedChanged
        Try
            If chkVerSenha.Checked Then
                txtSenha.PasswordChar = ""
                txtRepeteSenha.PasswordChar = ""
                imgVerSenha.Image = Image.FromFile("\icon\unshow.png")
            Else
                txtSenha.PasswordChar = "•"
                txtRepeteSenha.PasswordChar = "•"
                imgVerSenha.Image = Image.FromFile("\icon\show.png")
            End If
        Catch ex As Exception
            Exit Sub
        End Try
    End Sub

    Private Sub btnRedefineSenha_Click(sender As Object, e As EventArgs) Handles btnRedefineSenha.Click
        Try
            If txtEmail.Text = "" Or txtSenha.Text = "" Or txtRepeteSenha.Text = "" Then
                MsgBox("Preencha todos os campos!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "AVISO")
                Exit Sub
            ElseIf txtSenha.Text <> txtRepeteSenha.Text Then
                MsgBox("Senhas não conferem!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "AVISO")
                Exit Sub
            Else
                sql = "SELECT * FROM tb_clientes WHERE email = '" & txtEmail.Text & "'"
                rs = db.Execute(sql)

                If rs.EOF = False Then
                    sql = "UPDATE tb_clientes SET senha = '" & txtSenha.Text & "' WHERE email = '" & txtEmail.Text & "'"
                    rs = db.Execute(UCase(sql))

                    MsgBox("Sua senha foi alterada com sucesso!" + vbNewLine &
                           "Realize o login para recuperar o acesso a sua conta.", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "AVISO")
                    Me.Close()
                Else
                    Call limpaRecuperaSenha()
                    MsgBox("Email inválido!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "AVISO")
                End If
            End If
        Catch ex As Exception
            MsgBox("Ocorreu um erro e não foi possível alterar a senha.", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
            Exit Sub
        End Try
    End Sub
End Class