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
    /// Description: Permet de définir l'inventaire d'un héros.
    /// Date: 2016-09-14
    /// </summary>
    public class cInventaireHeros : cTable
    {
        private List<cItem> _items;
        private InventaireHero _inventaire;

        /// <summary>
        /// Constructeur
        /// </summary>
        public cInventaireHeros(int idHero)
        {
            _inventaire = new InventaireHero();
            _inventaire.IdHero = idHero;
            _items = new List<cItem>();
            context.InventaireHero.Add(_inventaire);
            context.SaveChanges();
        }

        /// <summary>
        /// Permet d'ajouter un item dans l'inventaire d'un héros.
        /// </summary>
        /// <param name="objet"></param>
        public void AjouterItemInventaire(cItem objet)
        {
            _items.Add(objet);
            context.SaveChanges();
        }

        /// <summary>
        /// Permet de supprimer un item de l'inventaire du héros.
        /// </summary>
        /// <param name="objet"></param>
        public void SupprimerItemInventaire(cItem objet)
        {
            _items.Remove(objet);
            context.SaveChanges();
        }

        public InventaireHero AccederInventaire()
        {
            return _inventaire;
        }
    }
}
