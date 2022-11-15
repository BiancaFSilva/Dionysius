Public Class frmAdicionaEvento
    Private Sub frmAdicionaEvento_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call conectaDataBase()
        Call limpaEvento()

        If btnAdicionarEvento.Text = "Atualizar Evento" Then
            lblId.Visible = True
            txtId.Visible = True

            aux = camposEvento(0)
            sql = "SELECT * FROM tb_eventos WHERE id_evento  = " & aux & ""
            rs = db.Execute(sql)

            Try
                txtId.Text = rs.Fields(0).Value
                txtNome.Text = rs.Fields(1).Value
                txtDescricao.Text = rs.Fields(2).Value
                txtData.Text = rs.Fields(3).Value
                txtHora.Text = rs.Fields(4).Value
                txtEndereco.Text = rs.Fields(5).Value
                txtBairro.Text = rs.Fields(6).Value
                txtCidade.Text = rs.Fields(7).Value
                txtUf.Text = rs.Fields(8).Value
                txtCep.Text = rs.Fields(9).Value
                cmbParticipantes.Text = rs.Fields(10).Value
            Catch ex As Exception
                Exit Try
            End Try
        Else
            Call limpaEvento()
        End If

        With cmbParticipantes.Items
            Try
                sql = "SELECT * FROM tb_clientes"
                rs = db.Execute(sql)

                Do While rs.EOF = False
                    .Add(rs.Fields(1).Value & " " & rs.Fields(2).Value)

                    rs.MoveNext()
                    cont += 1
                Loop
            Catch ex As Exception
                MsgBox("Ocorreu um erro durante o carregamento dos items.", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
                Exit Sub
            End Try
        End With
    End Sub

    Private Sub txtData_LostFocus(sender As Object, e As EventArgs) Handles txtData.LostFocus
        Try
            If CDate(txtData.Text).Year < Date.Now.Year Then
                MsgBox("Os eventos só podem ser marcados para datas futuras.", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
                txtData.Clear()
                txtData.Focus()
            ElseIf (CDate(txtData.Text).Day <= 0 Or CDate(txtData.Text).Day > 31) Or (CDate(txtData.Text).Month <= 0 Or CDate(txtData.Text).Month > 12) Or (CDate(txtData.Text).Year < Date.Now.Year Or CDate(txtData.Text).Year >= 2500) Then
                MsgBox("Informe uma data válida!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "AVISO")
                txtData.Clear()
                txtData.Focus()
            End If
        Catch ex As Exception
            Exit Sub
        End Try
    End Sub

    Private Sub txtHora_LostFocus(sender As Object, e As EventArgs) Handles txtHora.LostFocus
        Try
            If (Hour(txtHora.Text) < 0 Or Hour(txtHora.Text) > 23) Or (Minute(txtHora.Text) < 0 Or Minute(txtHora.Text) > 60) Then
                MsgBox("Informe um horário válido!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "AVISO")
                txtHora.Clear()
                txtHora.Focus()
            End If
        Catch ex As Exception
            Exit Sub
        End Try
    End Sub

    Private Sub txtCep_LostFocus(sender As Object, e As EventArgs) Handles txtCep.LostFocus
        Try
            sql = "SELECT * FROM tb_cep WHERE cep = '" & txtCep.Text & "'"
            rs = db.Execute(sql)

            If rs.EOF = False Then
                txtEndereco.Text = rs.Fields(1).Value
                txtBairro.Text = rs.Fields(3).Value
                txtCidade.Text = rs.Fields(2).Value
                txtUf.Text = rs.Fields(4).Value
            Else
                MsgBox("CEP não localizado!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "AVISO")
                txtCep.Clear()
                txtCep.Focus()
            End If
        Catch ex As Exception
            Exit Sub
        End Try
    End Sub

    Private Sub btnCadastrar_Click(sender As Object, e As EventArgs) Handles btnAdicionarEvento.Click
        Try
            If txtNome.Text = "" Or txtDescricao.Text = "" Or txtData.Text = "" Or txtHora.Text = "" Or txtCep.Text = "" Then
                MsgBox("Preencha todos os campos!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "AVISO")
                Exit Sub
            Else
                sql = "SELECT * FROM tb_eventos WHERE nome = '" & txtNome.Text & "'"
                rs = db.Execute(sql)

                If rs.EOF = False Then
                    If btnAdicionarEvento.Text = "Atualizar Evento" Then
                        sql = "UPDATE tb_eventos SET nome = '" & txtNome.Text & "', descricao = '" & txtDescricao.Text & "', data = '" & txtData.Text & "', " &
                              "hora = '" & txtHora.Text & "', endereco = '" & txtEndereco.Text & "', bairro = '" & txtBairro.Text & "', cidade = '" & txtCidade.Text & "', " &
                              "uf = '" & txtUf.Text & "', cep = '" & txtCep.Text & "', participantes = '" & cmbParticipantes.Text & "' WHERE id_evento = " & txtId.Text & ""
                        rs = db.Execute(UCase(sql))

                        Call carregaDadosEvento()
                        Call limpaEvento()

                        MsgBox("Dadps dp evento " & txtNome.Text & " atualizados com sucesso!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "AVISO")
                        Me.Close()
                    Else
                        Exit Sub
                    End If
                Else
                    sql = "INSERT INTO tb_eventos (nome, descricao, data, hora, endereco, bairro, cidade, uf, cep, participantes)" &
                          "VALUES ('" & txtNome.Text & "', '" & txtDescricao.Text & "', '" & txtData.Text & "', '" & txtHora.Text & "', " &
                          "'" & txtEndereco.Text & "', '" & txtBairro.Text & "', '" & txtCidade.Text & "', '" & txtUf.Text & "', " &
                          "'" & txtCep.Text & "', '" & cmbParticipantes.SelectedItem & "')"
                    rs = db.Execute(UCase(sql))

                    Call carregaDadosEvento()

                    resp = MsgBox("Evento cadastrado com sucesso!" + vbNewLine &
                                  "Deseja cadastrar outro evento?", MsgBoxStyle.Information + MsgBoxStyle.YesNo, "AVISO")
                    If resp = vbYes Then
                        Call limpaEvento()
                    Else
                        Me.Close()
                    End If
                End If
            End If
        Catch ex As Exception
            MsgBox("Ocorreu um erro e não foi possível adicionar o evento.", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
            Exit Sub
        End Try
    End Sub
End Class