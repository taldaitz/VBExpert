Module Module1

    Sub Main()

        Dim plateau(2, 2) As String
        Dim gagnant As String

        For tour As Integer = 1 To 9

            Dim joueur As String = IIf(tour Mod 2 = 1, "X", "O")

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

            Console.WriteLine()
            Console.WriteLine("Vous etes le joueur {0}, saisissez un coup :", joueur)

            Dim ligne As Integer = Console.ReadLine()
            Dim colonne As Integer = Console.ReadLine()

            plateau(ligne - 1, colonne - 1) = joueur

            For i As Integer = 0 To 2
                If plateau(i, 0) <> Nothing And plateau(i, 0) = plateau(i, 1) And plateau(i, 0) = plateau(i, 2) Then
                    gagnant = plateau(i, 0)
                End If
            Next

            For i As Integer = 0 To 2
                If plateau(0, i) <> Nothing And plateau(0, i) = plateau(1, i) And plateau(0, i) = plateau(2, i) Then
                    gagnant = plateau(0, i)
                End If
            Next

            If plateau(0, 0) <> Nothing And plateau(0, 0) = plateau(1, 1) And plateau(0, 0) = plateau(2, 2) Then
                gagnant = plateau(0, 0)
            End If

            If plateau(0, 2) <> Nothing And plateau(0, 2) = plateau(1, 1) And plateau(0, 2) = plateau(2, 0) Then
                gagnant = plateau(0, 2)
            End If

            If gagnant <> Nothing Then
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
                Console.WriteLine("Félicitation le joueur {0} a gagné !!", gagnant)
                Exit For
            End If

        Next

        If gagnant = Nothing Then
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
            Console.WriteLine("Partie terminée, Match nul.")
        End If

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
End Module
