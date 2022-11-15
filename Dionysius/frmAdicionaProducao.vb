Public Class frmAdicionaProducao
    Private Sub frmAdicionaProducao_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call conectaDataBase()

        If btnCadastraProducao.Text = "Atualizar Processo" Then
            lblId.Visible = True
            txtId.Visible = True

            aux = camposProducao(0)
            sql = "SELECT * FROM tb_fabricacao WHERE id_fabricacao = " & aux & ""
            rs = db.Execute(sql)

            Try
                txtId.Text = rs.Fields(0).Value
                cmbProcesso.Text = rs.Fields(1).Value
                txtDataInicio.Text = rs.Fields(2).Value
                TxtDataFim.Text = rs.Fields(3).Value
                cmbFornecedores.Text = rs.Fields(4).Value
                cmbProduto.Text = rs.Fields(5).Value
            Catch ex As Exception
                Exit Try
            End Try
        Else
            Call limpaProducao()
        End If

        With cmbProcesso.Items
            .Add("01 - Plantio das uvas")
            .Add("02 - Cultivo da videira e amadurecimento das uvas")
            .Add("03 - Colheita das uvas")
            .Add("04 - Desengace e esmagamento das uvas")
            .Add("05 - Fermentação alcoólica")
            .Add("06 - Maceração")
            .Add("07 - Decantação")
            .Add("08 - Remontagem")
            .Add("09 - Fermentação")
            .Add("10 - Prensagem")
            .Add("11 - Transfega")
            .Add("12 - Fermentação maloláctica")
            .Add("13 - Clarificação")
            .Add("14 - Estágio")
            .Add("15 - Engarrafamento")
            .Add("16 - Comercialização")
        End With

        With cmbFornecedores.Items
            Try
                sql = "SELECT * FROM tb_fornecedores"
                rs = db.Execute(sql)

                Do While rs.EOF = False
                    .Add(rs.Fields(1).Value)

                    rs.MoveNext()
                    cont += 1
                Loop
            Catch ex As Exception
                MsgBox("Ocorreu um erro durante o carregamento dos items.", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
                Exit Sub
            End Try
        End With

        With cmbProduto.Items
            Try
                sql = "SELECT * FROM tb_vinhos"
                rs = db.Execute(sql)

                Do While rs.EOF = False
                    .Add(rs.Fields(1).Value)

                    rs.MoveNext()
                    cont += 1
                Loop
            Catch ex As Exception
                MsgBox("Ocorreu um erro durante o carregamento dos items.", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
                Exit Sub
            End Try
        End With
    End Sub

    Private Sub txtDataInicio_LostFocus(sender As Object, e As EventArgs) Handles txtDataInicio.LostFocus
        Try
            If (CDate(txtDataInicio.Text).Day <= 0 Or CDate(txtDataInicio.Text).Day > 31) Or (CDate(txtDataInicio.Text).Month <= 0 Or CDate(txtDataInicio.Text).Month > 12) Or (CDate(txtDataInicio.Text).Year < Date.Now.Year Or CDate(txtDataInicio.Text).Year >= 2500) Then
                MsgBox("Informe uma data de início válida!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "AVISO")
                txtDataInicio.Clear()
                txtDataInicio.Focus()
            End If
        Catch ex As Exception
            Exit Sub
        End Try
    End Sub

    Private Sub TxtDataFim_LostFocus(sender As Object, e As EventArgs) Handles TxtDataFim.LostFocus
        Try
            If (CDate(TxtDataFim.Text).Day <= 0 Or CDate(TxtDataFim.Text).Day > 31) Or (CDate(TxtDataFim.Text).Month <= 0 Or CDate(TxtDataFim.Text).Month > 12) Or (CDate(TxtDataFim.Text).Year < CDate(txtDataInicio.Text).Year Or CDate(TxtDataFim.Text).Year >= 2500) Then
                MsgBox("Informe uma data de término válida!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "AVISO")
                TxtDataFim.Clear()
                TxtDataFim.Focus()
            End If
        Catch ex As Exception
            Exit Sub
        End Try
    End Sub

    Private Sub btnCadastraProducao_Click(sender As Object, e As EventArgs) Handles btnCadastraProducao.Click
        Try
            If cmbProcesso.SelectedItem = "" Or txtDataInicio.Text = "" Or TxtDataFim.Text = "" Or cmbFornecedores.SelectedItem = "" Or cmbProduto.SelectedItem = "" Then
                MsgBox("Preencha todos os campos!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "AVISO")
                Exit Sub
            Else
                sql = "SELECT * FROM tb_fabricacao WHERE processo = '" & cmbProcesso.SelectedItem & "'"
                rs = db.Execute(sql)

                If rs.EOF = False Then
                    If btnCadastraProducao.Text = "Atualizar Processo" Then
                        sql = "UPDATE tb_fabricacao SET processo = '" & cmbProcesso.Text & "', data_inicio = '" & txtDataInicio.Text & "', data_final = '" & TxtDataFim.Text & "', " &
                              "fornecedores_relacionados = '" & cmbFornecedores.Text & "', produto_relacionado = '" & cmbProduto.Text & "' WHERE id_fabricacao = " & txtId.Text & ""
                        rs = db.Execute(UCase(sql))

                        Call carregaDadosProducao()
                        Call limpaProducao()

                        MsgBox("Dados do processo de fabricação alterados com sucesso!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "AVISO")
                        Me.Close()
                    Else
                        Exit Sub
                    End If
                Else
                    sql = "INSERT INTO tb_fabricacao (processo, data_inicio, data_final, fornecedores_relacionados, produto_relacionado)" &
                          "VALUES ('" & cmbProcesso.SelectedItem & "', '" & txtDataInicio.Text & "', '" & TxtDataFim.Text & "', '" & cmbFornecedores.SelectedItem & "', '" & cmbProduto.SelectedItem & "')"
                    rs = db.Execute(UCase(sql))

                    Call carregaDadosProducao()

                    resp = MsgBox("Etapa do processo de fabricação do produto " & cmbProduto.SelectedItem & " cadastrada com sucesso!" + vbNewLine &
                                  "Deseja cadastrar o processo de outro produto?", MsgBoxStyle.Information + MsgBoxStyle.YesNo, "AVISO")
                    If resp = vbYes Then
                        Call limpaProducao()
                    Else
                        Me.Close()
                    End If
                End If
            End If
        Catch ex As Exception
            MsgBox("Ocorreu um erro e não foi possível adicionar o processo de fabricação do produto.", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
            Exit Sub
        End Try
    End Sub
End Class