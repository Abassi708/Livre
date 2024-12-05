Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btn_ajouter.Click
        Dim l As Livre
        l.ISBN = txt_isbn.Text
        l.titre = txt_titre.Text
        l.titre = txt_auteur.Text

        If AjouterLivre(l) Then
            MessageBox.Show("Ajout du livre avec succes")
        Else
            MessageBox.Show("le tableau bibliotheque est saturé!!")
        End If
    End Sub

    Private Sub btn_afficher_Click(sender As Object, e As EventArgs) Handles btn_afficher.Click
        btn_afficher.Show()
    End Sub
End Class
