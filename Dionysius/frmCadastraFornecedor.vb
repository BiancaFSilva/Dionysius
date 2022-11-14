Public Class frmCadastraFornecedor
    Private Sub frmCadastraFornecedor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call conectaDataBase()
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
End Class