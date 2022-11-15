Public Class frmCadastraFornecedor
    Private Sub frmCadastraFornecedor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call conectaDataBase()
        Call limpaFornecedores()

        Try
            If btnCadastrar.Text = "Atualizar Fornecedor" Then
                lblId.Visible = True
                txtId.Visible = True

                txtId.Text = camposFornecedor(0)
                txtNome.Text = camposFornecedor(1)
                txtRamo.Text = camposFornecedor(2)
                txtEmail.Text = camposFornecedor(3)
                txtFone.Text = camposFornecedor(4)
                txtProdutoFornecido.Text = camposFornecedor(5)
                txtCep.Text = camposFornecedor(6)
            Else
                Call limpaFornecedores()
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
            If txtNome.Text = "" Or txtRamo.Text = "" Or txtProdutoFornecido.Text = "" Or txtEmail.Text = "" Or txtFone.Text = "" Or txtCep.Text = "" Then
                MsgBox("Preencha todos os campos!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "AVISO")
                Exit Sub
            Else
                sql = "SELECT * FROM tb_fornecedores WHERE nome = '" & txtNome.Text & "'"
                rs = db.Execute(sql)

                If rs.EOF = False Then
                    sql = "UPDATE tb_fornecedores SET nome = '" & txtNome.Text & "', ramo = '" & txtRamo.Text & "', produto_fornecido = '" & txtProdutoFornecido.Text & "', " &
                          "email  = '" & txtEmail.Text & "', telefone = '" & txtFone.Text & "', localizacao = '" & txtCep.Text & "' WHERE id_fornecedor = '" & txtId.Text & "'"
                    rs = db.Execute(UCase(sql))

                    Call carregaDadosFornecedores()

                    MsgBox("Dados do fornecedor " & txtNome.Text & " alterados com sucesso!", MsgBoxStyle.Information + MsgBoxStyle.YesNo, "AVISO")
                    Me.Close()
                Else
                    sql = "INSERT INTO tb_fornecedores (nome, ramo, produto_fornecido, email, telefone, localizacao)" &
                          "VALUES ('" & txtNome.Text & "', '" & txtRamo.Text & "', '" & txtProdutoFornecido.Text & "', '" & txtEmail.Text & "', '" & txtFone.Text & "', '" & txtCep.Text & "')"
                    rs = db.Execute(UCase(sql))

                    Call carregaDadosFornecedores()

                    resp = MsgBox("O fornecedor " & txtNome.Text & " foi adicionado com sucesso!" + vbNewLine &
                                  "Deseja cadastrar o fornecedor?", MsgBoxStyle.Information + MsgBoxStyle.YesNo, "AVISO")
                    If resp = vbYes Then
                        Call limpaFornecedores()
                    Else
                        Me.Close()
                    End If
                End If
            End If
        Catch ex As Exception
            MsgBox("Ocorreu um erro durante o processamento e não foi possível cadastrar os dados do fornecedor.", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
            Exit Sub
        End Try
    End Sub
End Class