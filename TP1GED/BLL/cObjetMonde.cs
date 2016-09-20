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
    /// Description: Permet de définir les éléments du décor dans le monde.
    /// Date: 2016-09-11
    /// </summary>
    public class cObjetMonde : cTable
    {
        private string _description;
        private string _type; // À remplacer par un enum ?
        private int _x;
        private int _y;

        /// <summary>
        /// Constructeur
        /// </summary>
        public cObjetMonde(string description, string type, int x, int y)
        {
            _description = description;
            _type = type;
            _x = x;
            _y = y;
        }

        /// <summary>
        /// Permet de Créer un objet pour un monde donné.
        /// </summary>
        public void CreerObjet(cMonde monde) // Pour la BD
        {

        }

        /// <summary>
        /// Permet de modifierla description d'un objet pour un monde donné.
        /// </summary>
        public void ModifierDescription(cMonde monde, string description)
        {
            _description = description;
        }

        /// <summary>
        /// Permet de supprimer un objet pour un monde donné.
        /// </summary>
        public void SupprimerObjet(cMonde monde) // Pour la BD
        {

        }
    }
}
