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
        private EffetItem _effet;

        /// <summary>
        /// Constructeur
        /// </summary>
        /// <param name="type"></param>
        /// <param name="valeurEffet"></param>
        public cEffetItem(int type, int valeurEffet)
        {
            _effet.TypeEffet = type;
            _effet.ValeurEffet = valeurEffet;
            context.SaveChanges();
        }

        /// <summary>
        /// Permet d'ajouter un effet à un item.
        /// </summary>
        /// <param name="objet"></param>
        public void AjouterEffet()
        {
            context.EffetItem.Add(_effet);
            context.SaveChanges();
        }

        /// <summary>
        /// Permet de modifier un effet à un item.
        /// </summary>
        /// <param name="objet"></param>
        /// <param name="type"></param>
        /// <param name="valeurEffet"></param>
        public void ModifierEffet(int type, int valeurEffet)
        {
            // A modifier evidement
            _effet.TypeEffet = type;
            _effet.ValeurEffet = valeurEffet;
            context.SaveChanges();
        }

        /// <summary>
        /// Permet de supprimer un effet à un item.
        /// </summary>
        /// <param name="objet"></param>
        public void SupprimerEffet(cItem objet)
        {
            context.EffetItem.Remove(_effet);
            context.SaveChanges();
        }
    }
}
