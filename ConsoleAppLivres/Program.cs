using ConsoleAppLivres;

internal class Program
{
    private static void Main(string[] args)

    {
        Revue revue1 = new Revue("Cybersecurite", "Robert Milan", 300, 2, 2015);
        Revue revue2 = new Revue("Cloud Computing", "Jean Michel", 200, 5, 2023);
        Revue revue3 = new Revue("Reseautique", "Raschad Gigan", 150, 3, 2017);
          
        revue1.AfficherDetails();
        revue2.AfficherDetails();
        revue3.AfficherDetails();
    }

}
 
   