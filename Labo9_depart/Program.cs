using System;
using System.Globalization;
using System.Text;

namespace RougeOuNoir
{
    class Program
    {
        public static Random rand = new ();
        public static readonly string[] typeCartes = {"♥", "♦", "♠", "♣" };

        // Autres utilisations
        // Console.WriteLine("\U0001F0A0"); // Dos de carte 🂠
        // Console.WriteLine("\U0001F0A1"); // As de pique 🂡
        // Console.WriteLine("🂡 🂱 🃁 🃑");
        // https://symbl.cc/fr/unicode/blocks/playing-cards/
        public static readonly string[] imageCartes = {
            "🂱🂲🂳🂴🂵🂶🂷🂸🂹🂺🂻🂽🂾",
            "🃁🃂🃃🃄🃅🃆🃇🃈🃉🃊🃋🃍🃎",
            "🂡🂢🂣🂤🂥🂦🂧🂨🂩🂪🂫🂭🂮",
            "🃑🃒🃓🃔🃕🃖🃗🃘🃙🃚🃛🃝🃞"
        };


        // Ma fonction d'affichage de Carte, vous pouvez l'utiliser (ou pas) en complément mais pas en remplacement
        /*
        public static void AfficherCarte(Carte carte)
        {
            Console.Write(StringInfo.GetNextTextElement(
                imageCartes[carte.couleur], (carte.valeur - 1) * 2)
            );
        }
        */

        // La fonction pour melanger le paquet de cartes. Enlever les commentaires pour l'utiliser
        /*
        public static void MelangerPaquet(Carte[] paquet)
        {
            for (int i = paquet.Length - 1; i > 0; i--)
            {
                int j = rand.Next(0, i + 1);
                (paquet[j], paquet[i]) = (paquet[i], paquet[j]);
            }
        }
        */

        static void Main(string[] _)
        {
            Console.OutputEncoding = Encoding.UTF8;     // Pour afficher les symboles speciaux dans la console (au besoin)

            //Carte[] paquet = GenererPaquet();       // Créer la fonction puis enlever les commentaires
            //AfficherPaquet(paquet);               // Créer la fonction puis enlever les commentaires
            //MelangerPaquet(paquet);
            //AfficherPaquet(paquet);               // Créer la fonction puis enlever les commentaires

            Console.WriteLine("***************** ROUGE OU NOIR *****************");
        }
    }
}