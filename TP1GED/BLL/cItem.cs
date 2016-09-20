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
        private string _description;
        private List<cEffetItem> _effets;
        private int _niveau;
        private string _nom;
        private int _poids;
        private int _quantite;
        private int _reqDexterite;
        private int _reqEndurance;
        private int _reqForce;
        private int _reqIntelligence;
        private int _reqNiveau;
        private int _valeurArgent;
        private int _x;
        private int _y;

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
            _description = description;
            _niveau = niveau;
            _nom = nom;
            _poids = poids;
            _quantite = quantite;
            _reqDexterite = reqDexterite;
            _reqEndurance = reqEndurance;
            _reqForce = reqForce;
            _reqIntelligence = reqIntelligence;
            _reqNiveau = reqNiveau;
            _valeurArgent = ValeurArgent;
            _x = x;
            _y = y;
        }

        /// <summary>
        /// Réinitialise la position x,y de l'item lorsqu'il est rammassé.
        /// </summary>
        public void RamasserItem()
        {
            _x = 0;
            _y = 0;
        }

        /// <summary>
        /// Permet de créer un item.
        /// </summary>
        public void CreerItem() // Pour la BD
        {

        }

        /// <summary>
        /// Permet de modifier la quantité d'un item.
        /// </summary>
        /// <param name="qte"></param>
        public void ModifierQte(int qte)
        {
            _quantite = qte;
        }

        /// <summary>
        /// Permet de supprimer un item.
        /// </summary>
        public void SupprimerItem()
        {

        }
    }
}
