using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppLivres
{
    internal class Revue : Livres
    {
        public int Numero {  get; set; }
        public int Annee { get; set; }

        public Revue(string titre, string auteur, int nombrePages, int numero, int annee)
            : base(titre, auteur, nombrePages)
        {
            Numero = numero;
            Annee = annee;
        }

        public override void AfficherDetails()
       {
            base.AfficherDetails();
            Console.WriteLine($"Titre: {Titre}, Auteur: {Auteur}, Nombres de page: {NombresPages}, Annee: {Annee}, Numero : {Numero}”.");
        }
    }
}
