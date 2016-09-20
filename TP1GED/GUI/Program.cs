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

        static void Main(string[] args)
        {

            /*CreateMonde("Monde SATANIQUE", 666, 666);
            SupprimMonde(monde1);*/


            Console.ReadKey();
        }

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
            Console.WriteLine("Limies en X et Y: " + monde.AccesMonde.LimiteX + ", " + monde.AccesMonde.LimiteY);
        }

        static void ListerMonde()
        {

        }

        static void SupprimMonde(cMonde monde)
        {
            Console.WriteLine("Monde avant la supression");
            AfficherMonde(monde);
            monde.SupprimerMonde();
            Console.WriteLine("Monde supprime !");
        }
    }
}
