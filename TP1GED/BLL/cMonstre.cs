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
        public cMonstre(string nom, int niveau, int DmgMax, int DmgMin, int PV, int x, int y)
        {
            _nom = nom;

            // À déterminer aléatoires ???
            _niveau = niveau;
            _StatDmgMax = DmgMax;
            _StatDmgMin = DmgMin;
            _StatPV = PV;
            _x = x;
            _y = y;
        }

        /// <summary>
        /// Permet de créer un monstre avec des valeurs aléatoires
        /// </summary>
        public void CreerMonstre() // Pour la BD
        {

        }

        /// <summary>
        /// Permet de modifier les informations d'un monstre
        /// </summary>
        public void ModifierInfos()
        {

        }

        /// <summary>
        /// Permet de tuer un monstre
        /// </summary>
        public void SupprimerMonstre()
        {

        }
    }
}
