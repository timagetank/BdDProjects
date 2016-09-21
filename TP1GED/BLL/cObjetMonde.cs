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
        private int _type; // À remplacer par un enum ?
        private int _x;
        private int _y;
        private ObjetMonde _objet;

        /// <summary>
        /// Constructeur
        /// </summary>
        public cObjetMonde(string description, int type, int x, int y)
        {
            _objet = new ObjetMonde();
            _description = description;
            _type = type;
            // Ajouter une condition ?
            _x = x;
            _y = y;
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
            _objet.Id = monde.AccesMonde.Id;
            monde.AjouterObjet(_objet);
            context.ObjetMonde.Add(_objet);
            //context.SaveChanges();
        }

        /// <summary>
        /// Permet de modifierla description d'un objet pour un monde donné.
        /// </summary>
        public void ModifierDescription(cMonde monde, string description)
        {
            _description = description;
            monde.AjouterObjet(_objet);
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
