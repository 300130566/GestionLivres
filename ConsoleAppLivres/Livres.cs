using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppLivres
{
    internal class Livres
    {
        public string Titre { get; set; }
        public string Auteur { get; set; }
        public int NombresPages { get; set; }

        public Livres(string titre, string auteur, int nombrePages) 
        {
            Titre = titre;
            Auteur = auteur;
            NombresPages = nombrePages;
        }

        public virtual void AfficherDetails() 
        {
            Console.WriteLine($"Titre: {Titre}, Auteur: {Auteur}, Nombres de page: {NombresPages} ");
        }

    }
}
