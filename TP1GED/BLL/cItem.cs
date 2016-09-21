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
    /// Description: Permet les items que peuvent utiliser les héros.
    /// Date: 2016-09-12
    /// </summary>
    public class cItem : cTable
    {
        private Item _item;

        /// <summary>
        /// Constructeur
        /// </summary>
        /// <param name="description"></param>
        /// <param name="niveau"></param>
        /// <param name="nom"></param>
        /// <param name="poids"></param>
        /// <param name="quantite"></param>
        /// <param name="reqDexterite"></param>
        /// <param name="reqEndurance"></param>
        /// <param name="reqForce"></param>
        /// <param name="reqIntelligence"></param>
        /// <param name="reqNiveau"></param>
        /// <param name="ValeurArgent"></param>
        /// <param name="x"></param>
        /// <param name="y"></param>
        public cItem(string description, int niveau, string nom, int poids, int quantite, int reqDexterite, int reqEndurance, int reqForce, int reqIntelligence, int reqNiveau, int ValeurArgent, int x, int y) // A modifier
        {
            _item = new Item();
            _item.Description = description;
            _item.Niveau = niveau;
            _item.Nom = nom;
            _item.Poids = poids;
            _item.Quantite = quantite;
            _item.ReqDexterite = reqDexterite;
            _item.ReqEndurance = reqEndurance;
            _item.ReqForce = reqForce;
            _item.ReqIntelligence = reqIntelligence;
            _item.ReqNiveau = reqNiveau;
            _item.ValeurArgent = ValeurArgent;
            _item.x = x;
            _item.y = y;
        }

        /// <summary>
        /// Réinitialise la position x,y de l'item lorsqu'il est rammassé.
        /// </summary>
        public void RamasserItem()
        {
            _item.x = 0;
            _item.y = 0;
            context.SaveChanges();
        }

        /// <summary>
        /// Permet de créer un item.
        /// </summary>
        public void CreerItem() // Pour la BD
        {
            context.Item.Add(_item);
            context.SaveChanges();
        }

        /// <summary>
        /// Permet de modifier la quantité d'un item.
        /// </summary>
        /// <param name="qte"></param>
        public void ModifierQte(int qte)
        {
            _item.Quantite = qte;
            context.SaveChanges();
        }

        /// <summary>
        /// Permet de supprimer un item.
        /// </summary>
        public void SupprimerItem()
        {
            context.Item.Remove(_item);
            context.SaveChanges();
        }
    }
}
