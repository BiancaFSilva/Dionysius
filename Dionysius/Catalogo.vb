Public Class Catalogo
    Private Sub Catalogo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call conectaDataBase()
        Call limpaBusca()
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
            Me.Close()
        Catch ex As Exception
            Exit Sub
        End Try
    End Sub

    Private Sub btnCatalogo_Click(sender As Object, e As EventArgs) Handles btnCatalogo.Click
        Try
            Process.Start(Application.StartupPath & "\db\Dionysius.mdb")
        Catch ex As Exception
            Exit Sub
        End Try
    End Sub

    Private Sub txtBusca_TextChanged(sender As Object, e As EventArgs) Handles txtBusca.TextChanged
        dgvBuscaProduto.Visible = True

        Try
            Call limpaBusca()

            If txtBusca.Text = "" Then
                dgvBuscaProduto.Visible = False
            End If

            sql = "SELECT * FROM tb_vinhos WHERE nome LIKE '" & txtBusca.Text & "%'"
            rs = db.Execute(sql)

            With dgvBuscaProduto
                .Rows.Clear()

                cont = 1
                Do While rs.EOF = False
                    .Rows.Add(rs.Fields(1).Value, rs.Fields(3).Value, rs.Fields(4).Value, rs.Fields(5).Value)
                    rs.MoveNext()

                    cont += 1
                Loop
            End With
        Catch ex As Exception
            MsgBox("Ocorreu um erro durante a busca do produto", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
            Call limpaBusca()
            Exit Sub
        End Try
    End Sub

    Private Sub dgvBuscaProduto_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvBuscaProduto.CellContentClick
        txtBusca.Text = dgvBuscaProduto.Rows(dgvBuscaProduto.CurrentCell.RowIndex).Cells("NomeProduto").Value
        dgvBuscaProduto.Visible = False
    End Sub

    Private Sub btnBusca_Click(sender As Object, e As EventArgs) Handles btnBusca.Click
        Try
            sql = "SELECT * FROM tb_vinhos WHERE nome = '" & txtBusca.Text & "'"
            rs = db.Execute(sql)

            imgProduto.Visible = True

            lblNomeSafraProduto.Text = "" & rs.Fields(1).Value & ", " & rs.Fields(5).Value & ""
            lblTipoClasseProduto.Text = "" & rs.Fields(3).Value & " - " & rs.Fields(4).Value & ""
            lblDescricaoProduto.Text = "" & rs.Fields(2).Value & ""
            lblDadosGerais.Text = "" & rs.Fields(7).Value & ", " & rs.Fields(8).Value & "" + vbNewLine &
                                  "Uvas e componentes: " & rs.Fields(6).Value & "" + vbNewLine &
                                  "Teor alcóolico: " & rs.Fields(11).Value & "%" + vbNewLine &
                                  "Harmonização: " & rs.Fields(12).Value & ""
            imgProduto.Load(rs.Fields(15).Value)
        Catch ex As Exception
            MsgBox("Ocorreu um erro durante a busca do produto", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
            Call limpaBusca()
            Exit Sub
        End Try
    End Sub
End Class