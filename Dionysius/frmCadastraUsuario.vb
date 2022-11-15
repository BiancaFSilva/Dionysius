Public Class frmCadastraUsuario
    Private Sub frmCadastraUsuario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call conectaDataBase()

        If btnCadastrar.Text = "Atualizar" Then
            lblId.Visible = True
            txtId.Visible = True
        End If
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles chkVerSenha.CheckedChanged
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

    Private Sub txtDataNascimento_LostFocus(sender As Object, e As EventArgs) Handles txtDataNascimento.LostFocus
        Try
            If (Date.Now.Year - CDate(txtDataNascimento.Text).Year) < 18 Then
                MsgBox("A idade mínima permitida é de dezoito (18) anos.", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
                txtDataNascimento.Clear()
                txtDataNascimento.Focus()
            ElseIf (CDate(txtDataNascimento.Text).Day <= 0 Or CDate(txtDataNascimento.Text).Day > 31) Or (CDate(txtDataNascimento.Text).Month <= 0 Or CDate(txtDataNascimento.Text).Month > 12) Or (CDate(txtDataNascimento.Text).Year <= 1850 Or CDate(txtDataNascimento.Text).Year >= 2500) Then
                MsgBox("Informe uma data válida!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "AVISO")
                txtDataNascimento.Clear()
                txtDataNascimento.Focus()
            End If
        Catch ex As Exception
            Exit Sub
        End Try
    End Sub

    Private Sub txtCep_LostFocus(sender As Object, e As EventArgs) Handles txtCep.LostFocus
        Try
            sql = "SELECT * FROM tb_cep WHERE cep = '" & txtCep.Text & "'"
            rs = db.Execute(sql)

            If rs.EOF = True Then
                MsgBox("CEP não localizado!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "AVISO")
                txtCep.Clear()
                txtCep.Focus()
            End If
        Catch ex As Exception
            Exit Sub
        End Try
    End Sub

    Private Sub btnCadastrar_Click(sender As Object, e As EventArgs) Handles btnCadastrar.Click
        Try
            If txtNome.Text = "" Or txtSobrenome.Text = "" Or txtDataNascimento.Text = "" Or txtCpf.Text = "" Or txtFone.Text = "" Or txtCep.Text = "" Or txtEmail.Text = "" Or txtSenha.Text = "" Or txtRepeteSenha.Text = "" Then
                MsgBox("Preencha todos os campos!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "AVISO")
                Exit Sub
            ElseIf txtSenha.Text <> txtRepeteSenha.Text Then
                MsgBox("Senhas não conferem!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "AVISO")
                Exit Sub
            Else
                sql = "SELECT * FROM tb_clientes WHERE cpf = '" & txtCpf.Text & "' OR email = '" & txtEmail.Text & "'"
                rs = db.Execute(sql)

                If rs.EOF = False Then
                    Call limpaCadastro()
                    MsgBox("Este usuário já está cadastrado!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "AVISO")
                    Exit Sub
                Else
                    sql = "INSERT INTO tb_clientes (nome, sobrenome, email, telefone, cpf, data_nascimento, localizacao, senha, status)" &
                          "VALUES ('" & txtNome.Text & "', '" & txtSobrenome.Text & "', '" & txtEmail.Text & "', '" & txtFone.Text & "', '" & txtCpf.Text & "', '" & txtDataNascimento.Text & "', '" & txtCep.Text & "', '" & txtSenha.Text & "','Ativo')"
                    rs = db.Execute(UCase(sql))

                    MsgBox("Conta cadastrada com sucesso!" + vbNewLine &
                           "Realize o login para ter acesso ao sistema.", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "ATENÇÃO")
                    Me.Close()
                End If
            End If
        Catch ex As Exception
            MsgBox("Ocorreu um erro e não foi possível cadastrar a conta.", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
            Exit Sub
        End Try
    End Sub
End Class