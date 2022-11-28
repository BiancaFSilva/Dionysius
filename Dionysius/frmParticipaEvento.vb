Public Class frmParticipaEvento
    Private Sub frmParticipaEvento_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call conectaDataBase()
    End Sub

    Private Sub btnConfirmaPresenca_Click(sender As Object, e As EventArgs) Handles btnConfirmaPresenca.Click
        Try
            If txtNomeParticipante.Text = "" Or txtSobrenomeParticipante.Text = "" Or txtEmailParticipante.Text = "" Then
                MsgBox("Preencha os campos!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "AVISO")
                Exit Sub
            Else
                sql = "SELECT * FROM tb_clientes WHERE nome = '" & txtNomeParticipante.Text & "' AND sobrenome = '" & txtSobrenomeParticipante.Text & "' AND email = '" & txtEmailParticipante.Text & "'"
                rs = db.Execute(sql)

                If rs.EOF = False Then
                    sql = "UPDATE tb_eventos SET participantes = (participantes  + ', ' + '" & txtNomeParticipante.Text & "' + ' ' + '" & txtSobrenomeParticipante.Text & "') WHERE nome = '" & Eventos.lblTituloEvento.Text & "'"
                    rs = db.Execute(sql)

                    Call carregaDadosEvento()

                    MsgBox("Seu interesse em participar do evento " + Eventos.lblTituloEvento.Text + " foi registrado com sucesso!" + vbNewLine &
                           "Seu nome estará na lista.", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "AVISO")
                    Me.Close()
                Else
                    MsgBox("Dados inválidos!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "AVISO")
                    Exit Sub
                End If
            End If
        Catch ex As Exception
            MsgBox("Ocorreu um erro e não foi possível confirmar a presença do usuário no evento.", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
            Exit Sub
        End Try
    End Sub
End Class