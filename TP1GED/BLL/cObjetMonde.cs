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
        private ObjetMonde _objet;

        /// <summary>
        /// Constructeur
        /// </summary>
        public cObjetMonde(string description, int type, int x, int y)
        {
            _objet = new ObjetMonde();
            _objet.Description = description;
            _objet.TypeObjet = type;
            // Ajouter une condition ?
            _objet.x = x;
            _objet.y = y;
        }

        /// <summary>
        /// Propriété pour accéder à l'objet.
        /// </summary>
        public ObjetMonde AccesObjet
        {
            get
            {
                return _objet;
            }
        }


        /// <summary>
        /// Permet de créer un objet pour un monde donné.
        /// </summary>
        public void CreerObjet(cMonde monde)
        {
            monde.AjouterObjet(_objet);
            context.SaveChanges();
        }

        /// <summary>
        /// Permet de modifierla description d'un objet pour un monde donné.
        /// </summary>
        public void ModifierDescription( string description)
        {
            _objet.Description = description;
            context.SaveChanges();
        }

        /// <summary>
        /// Permet de supprimer un objet pour un monde donné.
        /// </summary>
        public void SupprimerObjet(cMonde monde) // Pour la BD
        {
            monde.RetirerObjet(_objet);
            context.ObjetMonde.Remove(_objet);
            context.SaveChanges();
        }
    }
}
