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
    /// Description: Permet de définir les bonus/malus d'un item.
    /// Date: 2016-09-12
    /// </summary>
    public class cEffetItem : cTable
    {
        private string _typeEffet; // Remplacer par un enum ?
        private int _valeurEffet;

        /// <summary>
        /// Constructeur
        /// </summary>
        /// <param name="type"></param>
        /// <param name="valeurEffet"></param>
        public cEffetItem(string type, int valeurEffet)
        {
            _typeEffet = type;
            _valeurEffet = valeurEffet;
        }

        /// <summary>
        /// Permet d'ajouter un effet à un item.
        /// </summary>
        /// <param name="objet"></param>
        public void AjouterEffet(cItem objet)
        {
            
        }

        /// <summary>
        /// Permet de modifier un effet à un item.
        /// </summary>
        /// <param name="objet"></param>
        /// <param name="type"></param>
        /// <param name="valeurEffet"></param>
        public void ModifierEffet(cItem objet, string type, int valeurEffet)
        {
            // A modifier evidement
            _typeEffet = type;
            _valeurEffet = valeurEffet;
        }

        /// <summary>
        /// Permet de supprimer un effet à un item.
        /// </summary>
        /// <param name="objet"></param>
        public void SupprimerEffet(cItem objet)
        {

        }
    }
}
