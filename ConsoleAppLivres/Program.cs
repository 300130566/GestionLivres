using ConsoleAppLivres;

internal class Program
{
    private static void Main(string[] args)

    {
        Revue revue1 = new Revue("Cybersecurite", "Robert Milan", 300, 2, 2015);
        Revue revue2 = new Revue("Cloud Computing", "Jean Michel", 200, 5, 2023);
        Revue revue3 = new Revue("Reseautique", "Raschad Gigan", 150, 3, 2017);

        Roman roman1 = new Roman("1984", "George Orwell", 328, "Science-fiction");
        Roman roman2 = new Roman("Le Petit Prince", "Antoine de Saint-Exupery", 96, "Conte philosophique");
        Roman roman3 = new Roman("La Peste", "albert Camus", 320, "Roman philosophique");


        revue1.AfficherDetails();
        revue2.AfficherDetails();
        revue3.AfficherDetails();

        roman1.AfficherDetails();
        roman2.AfficherDetails();
        roman3.AfficherDetails();


        List<Livres> Livres = new List<Livres>();

        Livres.Add(revue1);
        Livres.Add(revue2);
        Livres.Add(revue3);
        Livres.Add(roman1);
        Livres.Add(roman2);
        Livres.Add(roman3);

        foreach (Livres livre in Livres)
        {
            livre.AfficherDetails();
            Console.WriteLine();
        }

    }

}
 
   