Module Module2

    Sub Main()

        Dim plateau(2, 2) As String
        Dim gagnant As String

        For tour As Integer = 1 To 9

            Dim joueur As String = IIf(tour Mod 2 = 1, "X", "O")

            afficherPlateau(plateau)
            joueurCoup(plateau, joueur)

            gagnant = getGagnant(plateau)

            If gagnant <> Nothing Then
                affichageGagnant(plateau, joueur)
                Exit For
            End If

        Next

        If gagnant = Nothing Then affichageNul(plateau, gagnant)

        Console.ReadLine()

    End Sub

    Sub afficherPlateau(ByVal plateau(,) As String)

        Console.Clear()
        For i As Integer = 0 To 2
            For j As Integer = 0 To 2
                If plateau(i, j) = Nothing Then
                    Console.Write("[ ]")
                Else
                    Console.Write("[{0}]", plateau(i, j))
                End If
            Next

            Console.Write(Environment.NewLine)
        Next

    End Sub

    Sub joueurCoup(ByRef plateau(,) As String, ByVal joueur As String)
        Console.WriteLine()
        Console.WriteLine("Vous etes le joueur {0}, saisissez un coup :", joueur)

        Dim ligne As Integer = Console.ReadLine()
        Dim colonne As Integer = Console.ReadLine()

        plateau(ligne - 1, colonne - 1) = joueur
    End Sub

    Function getGagnant(ByVal plateau(,) As String)

        For i As Integer = 0 To 2
            If plateau(i, 0) <> Nothing And plateau(i, 0) = plateau(i, 1) And plateau(i, 0) = plateau(i, 2) Then
                Return plateau(i, 0)
            End If
        Next

        For i As Integer = 0 To 2
            If plateau(0, i) <> Nothing And plateau(0, i) = plateau(1, i) And plateau(0, i) = plateau(2, i) Then
                Return plateau(0, i)
            End If
        Next

        If plateau(0, 0) <> Nothing And plateau(0, 0) = plateau(1, 1) And plateau(0, 0) = plateau(2, 2) Then
            Return plateau(0, 0)
        End If

        If plateau(0, 2) <> Nothing And plateau(0, 2) = plateau(1, 1) And plateau(0, 2) = plateau(2, 0) Then
            Return plateau(0, 2)
        End If

        Return Nothing

    End Function

    Sub affichageGagnant(ByVal plateau(,) As String, ByVal gagnant As String)
        afficherPlateau(plateau)
        Console.WriteLine("Félicitation le joueur {0} a gagné !!", gagnant)
    End Sub

    Sub affichageNul(ByVal plateau(,) As String, ByVal gagnant As String)
        afficherPlateau(plateau)
        Console.WriteLine("Partie terminée, Match nul.")
    End Sub

End Module
