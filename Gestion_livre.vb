Module Gestion_livre

    Public Structure Livre
        Dim ISBN As Integer
        Dim titre As String
        Dim auteur As String
    End Structure

    Public bibliotheque(100) As Livre
    Dim NB As Integer = 0

    Function AjouterLivre(l As Livre) As Boolean
        If NB < bibliotheque.Length Then
            bibliotheque(NB) = l
            NB += 1
            Return True
        Else
            Return False

        End If
    End Function

    Sub afficher_livre(l1 As ListBox, l2 As ListBox, l3 As ListBox)
        For Each Livre As Livre In bibliotheque
            l1.Items.Add(Livre.ISBN)
            l2.Items.Add(Livre.titre)
            l3.Items.Add(Livre.auteur)
        Next
    End Sub


End Module
