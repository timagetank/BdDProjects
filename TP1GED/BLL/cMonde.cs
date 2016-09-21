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
    /// Description: Permet de stocker les informations relatives à un monde (carte) dans lequel évoluera le jeu.
    /// Date: 2016-09-10
    /// </summary>
    public class cMonde : cTable
    {
        private Monde _monde; 

        /// <summary>
        /// Constructeur
        /// </summary>
        /// <param name="description"></param>
        /// <param name="limiteX"></param>
        /// <param name="limiteY"></param>
        public cMonde(string description, int limiteX, int limiteY)
        {
            _monde = new Monde();
            _monde.ObjetMonde = new List<ObjetMonde>();
            _monde.Monstre = new List<Monstre>();
            _monde.Description = description;
            _monde.LimiteX = limiteX;
            _monde.LimiteY = limiteY;
        }

        /// <summary>
        /// Propriété pour accéder au monde.
        /// </summary>
        public Monde AccesMonde
        {
            get
            {
                return _monde;
            }
        }


        /// <summary>
        /// Permet de créer un nouveau monde.
        /// </summary>
        public void CreerMonde()
        {
            context.Monde.Add(_monde);
            context.SaveChanges();
        }

        /// <summary>
        /// Permet de modifier la description d'un monde.
        /// </summary>
        /// <param name="description"></param>
        public void ModifierDescription(string description)
        {
            _monde.Description = description;
            context.SaveChanges();
        }

        /// <summary>
        /// Permet de modifier les limites d'un monde.
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        public void ModifierLimites(int x, int y)
        {
            _monde.LimiteX = x;
            _monde.LimiteY = y;
            context.SaveChanges();
        }

        /// <summary>
        /// Permet de retourner la liste des mondes.
        /// </summary>
        /// <returns></returns>
        public List<Monde> RetournerListeMondes() 
        {
            
            return context.Monde.ToList();
        }

        /// <summary>
        /// Supprime un monde de la BD.
        /// </summary>
        public void SupprimerMonde()
        {
            context.Monde.Remove(_monde);
            context.SaveChanges();
        }

        /// <summary>
        /// Permet d'ajouter un objet au monde.
        /// </summary>
        /// <param name="objet"></param>
        public void AjouterObjet(ObjetMonde objet)
        {
            _monde.ObjetMonde.Add(objet);
            context.SaveChanges();
        }

        /// <summary>
        /// Permet de retirer un objet au monde.
        /// </summary>
        /// <param name="objet"></param>
        public void RetirerObjet(ObjetMonde objet)
        {
            _monde.ObjetMonde.Remove(objet);
            context.SaveChanges();
        }

        /// <summary>
        /// Permet d'ajouter un monstre au monde.
        /// </summary>
        /// <param name="monstre"></param>
        public void AjouterMonstre(Monstre monstre)
        {
            _monde.Monstre.Add(monstre);
            context.SaveChanges();
        }

        /// <summary>
        /// Permet de retirer un monstre au monde.
        /// </summary>
        /// <param name="monstre"></param>
        public void RetirerMonstre(Monstre monstre)
        {
            _monde.Monstre.Remove(monstre);
            context.SaveChanges();
        }
    }
}
