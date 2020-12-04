Imports System
Imports System.Data.Entity
Imports System.Linq

Public Class ProductBase
    Inherits DbContext

    ' Votre contexte a été configuré pour utiliser une chaîne de connexion « ProductBase » du fichier 
    ' de configuration de votre application (App.config ou Web.config). Par défaut, cette chaîne de connexion cible 
    ' la base de données « BaseProduit.ProductBase » sur votre instance LocalDb. 
    ' 
    ' Pour cibler une autre base de données et/ou un autre fournisseur de base de données, modifiez 
    'la chaîne de connexion « ProductBase » dans le fichier de configuration de l'application.
    Public Sub New()
        MyBase.New("name=ProductBase")

        Database.SetInitializer(Of ProductBase)(New MigrateDatabaseToLatestVersion(Of ProductBase, Migrations.Configuration))
    End Sub

    ' Ajoutez un DbSet pour chaque type d'entité à inclure dans votre modèle. Pour plus d'informations 
    ' sur la configuration et l'utilisation du modèle Code First, consultez http:'go.microsoft.com/fwlink/?LinkId=390109.
    Public Overridable Property Products() As DbSet(Of Product)
    Public Overridable Property Refunds() As DbSet(Of Refund)
    Public Overridable Property Customers() As DbSet(Of Customer)


    'Protected Overrides Sub OnModelCreating(modelBuilder As DbModelBuilder)
    '    MyBase.OnModelCreating(modelBuilder)

    '    modelBuilder.Entity(Of Customer).HasKey(Function(c) c.Id)
    'End Sub

End Class

'Public Class MyEntity
'    Public Property Id() As Int32
'    Public Property Name() As String
'End Class
