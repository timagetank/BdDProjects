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
        private string _nom;
        private int _niveau;
        private int _StatDmgMax;
        private int _StatDmgMin;
        private int _StatPV;
        private int _x;
        private int _y;
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
            _nom = nom;
            _monstre = new Monstre();
            Random rnd = new Random();

            _niveau = rnd.Next(1, 20);
            _StatDmgMax = rnd.Next(10, 40);
            _StatDmgMin = rnd.Next(1, 40);
            _StatPV = rnd.Next(1, 50);
            _x = x;
            _y = y;
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
        }

        /// <summary>
        /// Permet de modifier les informations d'un monstre
        /// </summary>
        public void ModifierInfos(cMonde monde, string nom, int x, int y) // Ceux generer random aussi ?
        {
            _nom = nom;
            _x = x;
            _y = y;
            monde.AjouterMonstre(_monstre);
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
