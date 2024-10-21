using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppLivres
{
    internal class Roman : Livres
    {
        public string Genre { get; set; }

        public Roman(string titre, string auteur, int nombrePages, string genre)
            : base(titre, auteur, nombrePages)
        {
            Genre = genre;
        }

        public override void AfficherDetails()
        {
            base.AfficherDetails();
            Console.WriteLine($"Genre: {Genre}");
        }
    }
}

