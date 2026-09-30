// See https://aka.ms/new-console-template for more information
using jour_2.Metier;

Console.WriteLine("Entrez la référence du produit :");
var reference = Console.ReadLine();
Console.WriteLine("Entrez le nom du produit :");
var nom = Console.ReadLine();
Console.WriteLine("Entrez le prix du produit :");
var prixInput = Console.ReadLine();

if (!double.TryParse(prixInput, out var prix))
{
    Console.WriteLine("Prix invalide. Entrez un nombre.");
    return;
}

Produit produit = new Produit(reference, nom, prix);
Console.WriteLine($"Produit créé : \nRéférence : {produit.Reference}, Nom : {produit.Nom}, Prix : {produit.Prix} $");
