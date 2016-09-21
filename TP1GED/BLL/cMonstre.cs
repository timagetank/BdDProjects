using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP1GED.DAL;

namespace TP1GED.BLL
{
    /// <summary>
    /// Auteur: Alexandre Constant
    /// Description: Permet de définir les monstres dans un monde.
    /// Date: 2016-09-11
    /// </summary>
    public class cMonstre : cTable
    {
        private Monstre _monstre;

        /// <summary>
        /// Constructeur
        /// </summary>
        /// <param name="nom"></param>
        /// <param name="niveau"></param>
        /// <param name="DmgMax"></param>
        /// <param name="DmgMin"></param>
        /// <param name="PV"></param>
        /// <param name="x"></param>
        /// <param name="y"></param>
        public cMonstre(string nom, int x, int y)
        {
            _monstre = new Monstre();
            _monstre.Nom = nom;
            Random rnd = new Random(DateTime.Now.Millisecond);

            _monstre.Niveau = rnd.Next(1, 20);
            _monstre.StatDmgMax = rnd.Next(10, 40);
            _monstre.StatDmgMin = rnd.Next(1, 40);
            _monstre.StatPV = rnd.Next(1, 50);
            _monstre.x = x;
            _monstre.y = y;
        }

        /// <summary>
        /// Propriété pour accéder au monstre.
        /// </summary>
        public Monstre AccesMonstre
        {
            get
            {
                return _monstre;
            }
        }


        /// <summary>
        /// Permet de créer un monstre.
        /// </summary>
        public void CreerMonstre(cMonde monde)
        {            
            monde.AjouterMonstre(_monstre);
            context.SaveChanges();
        }

        /// <summary>
        /// Permet de modifier les informations d'un monstre
        /// </summary>
        public void ModifierInfos(string nom, int x, int y) // Ceux generer random aussi ?
        {
            _monstre.Nom = nom;
            _monstre.x = x;
            _monstre.y = y;
            context.SaveChanges();
        }

        /// <summary>
        /// Permet de tuer un monstre
        /// </summary>
        public void SupprimerMonstre(cMonde monde)
        {
            monde.RetirerMonstre(_monstre);
            context.Monstre.Remove(_monstre);
            context.SaveChanges();
        }
    }
}
