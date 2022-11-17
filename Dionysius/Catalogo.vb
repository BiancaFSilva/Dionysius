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

    Private Sub FavoritosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FavoritosToolStripMenuItem.Click
        Try
            frmFavoritos.ShowDialog()
            Me.Close()
        Catch ex As Exception
            MsgBox("Ocorreu um erro durante o carregamento da página", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
            Exit Sub
        End Try
    End Sub

    Private Sub SairDoSistemaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SairDoSistemaToolStripMenuItem.Click
        Try
            Application.Exit()
        Catch ex As Exception
            Exit Sub
        End Try
    End Sub

    Private Sub txtBusca_TextChanged(sender As Object, e As EventArgs) Handles txtBusca.TextChanged
        lstBuscaProduto.Visible = True

        Try
            Call limpaBusca()

            sql = "SELECT * FROM tb_vinhos WHERE nome OR tipo OR classificacao OR safra LIKE '%" & txtBusca.Text & "%' ORDER BY preco ASC"
            rs = db.Execute(sql)

            cont = 1
            With lstBuscaProduto
                .Items.Clear()

                Do While rs.EOF = False
                    .Items.Add("" & rs.Fields(1).Value & ", " & rs.Fields(3).Value & "")
                    aux = rs.Fields(1).Value

                    rs.MoveNext()
                    cont += 1
                Loop
            End With

            txtBusca.Text = lstBuscaProduto.SelectedItem
        Catch ex As Exception
            MsgBox("Ocorreu um erro durante a busca do produto", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
            Call limpaBusca()
            Exit Sub
        End Try
    End Sub

    Private Sub btnBusca_Click(sender As Object, e As EventArgs) Handles btnBusca.Click
        Try
            sql = "SELECT * FROM tb_vinhos WHERE nome = '" & aux & "'"
            rs = db.Execute(sql)

            lstBuscaProduto.Visible = False

            ' imgProduto.Load(rs.Fields(15).Value)
            lblNomeSafraProduto.Text = "" & rs.Fields(1).Value & ", " & rs.Fields(5).Value & ""
            lblTipoClasseProduto.Text = "" & rs.Fields(3).Value & " - " & rs.Fields(4).Value & ""
            lblDescricaoProduto.Text = "" & rs.Fields(2).Value & ""
            lblPaisRegião.Text = "" & rs.Fields(7).Value & ", " & rs.Fields(8).Value & ""
            lblEspecieUva.Text = "Uvas e componentes: " & rs.Fields(6).Value & ""
            lblTeorAlcoolico.Text = "Teor alcóolico: " & rs.Fields(11).Value & "%"
            lblHarmonizacao.Text = "Harmonização: " & rs.Fields(12).Value & ""
        Catch ex As Exception
            MsgBox("Ocorreu um erro durante a busca do produto", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
            Call limpaBusca()
            Exit Sub
        End Try
    End Sub
End Class