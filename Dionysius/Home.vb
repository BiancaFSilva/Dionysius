Public Class Home
    Private Sub LoginToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LoginToolStripMenuItem.Click
        Try
            Login.ShowDialog()
        Catch ex As Exception
            MsgBox("Ocorreu um erro durante o processamento" + vbNewLine &
                   "Tente novamente mais tarde", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
        End Try
    End Sub
End Class