using System;

class Program
{
    // Fonction qui calcule le prix total avec remise
    static double CalculerPrixTotal(int nombrePersonnes, double prixUnitaire)
    {
        double total = nombrePersonnes * prixUnitaire;
        double remise = 0;

        if (nombrePersonnes >= 10)
        {
            remise = 0.30; // 30% de réduction
        }
        else if (nombrePersonnes >= 5)
        {
            remise = 0.15; // 15% de réduction
        }
        else if (nombrePersonnes >= 3)
        {
            remise = 0.05; // 5% de réduction
        }

        double prixFinal = total * (1 - remise);
        return prixFinal;
    }

    // Procédure qui affiche le prix final
    static void AfficherPrixFinal(int nombrePersonnes, double prixUnitaire)
    {
        double prixFinal = CalculerPrixTotal(nombrePersonnes, prixUnitaire);
        Console.WriteLine($"Le prix final pour {nombrePersonnes} personnes est : {prixFinal} euros");
    }

    static void Main()
    {
        Console.Write("Entrez le prix unitaire du ticket : ");
        double prixUnitaire;
        while (!double.TryParse(Console.ReadLine(), out prixUnitaire))
        {
            Console.Write("Entrée invalide. Veuillez entrer un prix valide : ");
        }

        Console.Write("Entrez le nombre de personnes : ");
        int nombrePersonnes;
        while (!int.TryParse(Console.ReadLine(), out nombrePersonnes))
        {
            Console.Write("Entrée invalide. Veuillez entrer un nombre entier : ");
        }

        AfficherPrixFinal(nombrePersonnes, prixUnitaire);
    }
}
