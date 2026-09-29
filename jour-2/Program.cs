// See https://aka.ms/new-console-template for more information
using jour_2.Metier;

Console.WriteLine("Entrez la référence du produit :");
var reference = Console.ReadLine();
Console.WriteLine("Entrez le nom du produit :");
var nom = Console.ReadLine();
Console.WriteLine("Entrez le prix du produit :");
var prixInput = Console.ReadLine();
Produit produit = new Produit(reference, nom, double.Parse(prixInput));
Console.WriteLine($"Produit créé : Référence = {produit.Reference}, Nom = {produit.Nom}, Prix = {produit.Prix}");