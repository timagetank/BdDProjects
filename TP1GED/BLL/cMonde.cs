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
        private List<cClasse> _classes; // Il faut ajouter un new pour une composition, sinon c'est un agrégation ???
        private string _description;
        private List<cHero> _heros;
        private List<cItem> _items;
        private int _limiteX;
        private int _limiteY;
        private List<cMonstre> _monstres;
        private List<cObjetMonde> _objetsMonde;
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
            _monde.Description = description;
            _monde.LimiteX = limiteX;
            _monde.LimiteY = limiteY;
            _description = description;
            _limiteX = limiteX;
            _limiteY = limiteY;
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
        public void CreerMonde() // Pour la BD
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
            _description = description;
            _monde.Description = _description;
            context.SaveChanges();
        }

        /// <summary>
        /// Permet de modifier les limites d'un monde.
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        public void ModifierLimites(int x, int y)
        {
            _limiteX = x;
            _limiteY = y;
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
            List<Monde> listeMondes = new List<Monde>();
            var req = context.Monde;
            foreach (Monde m in req)
            {
                listeMondes.Add(m);                              
            }
            return listeMondes;
        }

        /// <summary>
        /// Supprime un monde de la BD.
        /// </summary>
        public void SupprimerMonde()
        {
            context.Monde.Remove(_monde);
            context.SaveChanges();
        }
    }
}
