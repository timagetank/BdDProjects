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
        static cMonde monde1;
        static cObjetMonde objet1;


        static void Main(string[] args)
        {
            /* // Anciens jeux de test pour la classe cMonde
            monde1.CreerMonde();
            ListerMonde();
            */

            // Jeux de test ObjetMonde
            CreateMonde("Enfer", 666, 666);
            CreateObjet("BabyGoon", 5, 69, 99);
            CreateMonde("Enfer", 666, 666);



            Console.ReadKey();
        }

        #region Methodes

        static void CreateMonde(string description, int limitX, int limitY)
        {
            monde1 = new cMonde(description, limitX, limitY);
            monde1.CreerMonde();
            AfficherMonde(monde1);
            Console.WriteLine("Creation du monde");
        }

        static void AfficherMonde(cMonde monde)
        {
            Console.WriteLine("ID: " + monde.AccesMonde.Id);
            Console.WriteLine("Description: " + monde.AccesMonde.Description);
            Console.WriteLine("Limites en X et Y: " + monde.AccesMonde.LimiteX + ", " + monde.AccesMonde.LimiteY);
        }

        static void ListerMonde()
        {
            foreach (var m in monde1.RetournerListeMondes())
                Console.WriteLine(m.Id + Environment.NewLine + m.Description);
        }

        static void SupprimMonde(cMonde monde)
        {
            Console.WriteLine("Monde avant la supression");
            AfficherMonde(monde);
            monde.SupprimerMonde();
            Console.WriteLine("Monde supprime!");
        }

        static void CreateObjet(string description, int type, int x, int y)
        {
            objet1 = new cObjetMonde(description, type, x, y);
            objet1.CreerObjet(monde1);
            Console.WriteLine("Creation d'un objet");
        }

        #endregion
    }
}
