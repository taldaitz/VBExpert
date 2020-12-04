Namespace LibService

    Partial Public Class Auteur

        Public Overrides Function ToString() As String
            Return String.Format("{0} {1}", Me.Prenom, Me.Nom)
        End Function


    End Class

End Namespace


