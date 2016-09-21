using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP1GED.BLL;

namespace TP1GED.GUI
{
    class Program
    {
        static cMonde monde;
        static cObjetMonde objet1;
        static cCompteJoueur user1;


        static void Main(string[] args)
        {
            /* // Anciens jeux de test pour la classe cMonde
            monde1.CreerMonde();
            ListerMonde();
            */

            // Jeux de test ObjetMonde
            //CreateMonde("Monde SATANIQUE", 666, 666);
            //CreateObjet("BabyGoon", 5, 69, 99);

            CreateUser("spam@shit.com", "SATANIQUE", "Ricaneur", "Irrite-Anus","1234", 666);
            CreateUser("spam@phish.com", "Har-Laporte", "Xeyve", "xharl","1234", 665);
            ListerUser();

            // CreateMonde("Premier Monde", 16, 16);

            ListerMonde();

            Console.ReadKey();
        }

        #region Methodes

        static void CreateMonde(string description, int limitX, int limitY)
        {
            monde = new cMonde(description, limitX, limitY);
            monde.CreerMonde();
            AfficherMonde(monde);
            Console.WriteLine("Creation du monde: " + description);
        }

        static void AfficherMonde(cMonde monde)
        {
            Console.WriteLine("ID: " + monde.AccesMonde.Id);
            Console.WriteLine("Description: " + monde.AccesMonde.Description);
            Console.WriteLine("Limites en X et Y: " + monde.AccesMonde.LimiteX + ", " + monde.AccesMonde.LimiteY);
        }

        static void ListerMonde()
        {
            var test = monde.RetournerListeMondes();
            foreach (var m in test)
                Console.WriteLine(m.Id + ", " + m.Description + ", [" + m.LimiteX + ", " + m.LimiteY + "]");
        }

        static void SupprimMonde(cMonde monde)
        {
            Console.WriteLine("Monde pret a etre supprime: " + monde);
            AfficherMonde(monde);
            monde.SupprimerMonde();
            Console.WriteLine("Monde supprime!");
        }

        static void CreateObjet(string description, int type, int x, int y)
        {
            objet1 = new cObjetMonde(description, type, x, y);
            objet1.CreerObjet(monde);
            Console.WriteLine("Creation d'un objet");
        }

        static void CreateUser(string email, string nom, string prenom, string username, string mdp, int type)
        {
            user1 = new cCompteJoueur(email, nom, prenom, username, mdp, type);
            user1.CreerJoueur();
            Console.WriteLine("Creation d'un joueur sous le compte de: " + username);
        }

        static void ListerUser()
        {
            cRequest allo = new cRequest();
            foreach (var u in allo.getEntities().CompteJoueur   )
                Console.WriteLine(u.Id + ": " + u.NomUtilisateur);
        }
        #endregion
    }
}
