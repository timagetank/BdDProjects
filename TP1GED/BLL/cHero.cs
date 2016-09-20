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
    /// Description: Permet de définir le héros d'un joueur.
    /// Date: 2016-09-14
    /// </summary>
    public class cHero : cTable
    {
        // Initialiser certains éléments à zéro ?
        private int _argent;
        private cClasse _classeHero;
        private int _experience;
        private cInventaireHeros _inventaire;
        private int _niveau;
        private int _statDex;
        private int _statInt;
        private int _statStr;
        private int _statVitalite;
        private int _x;
        private int _y;

        /// <summary>
        /// Constructeur
        /// </summary>
        /// <param name="argent"></param>
        /// <param name="classeHero"></param>
        /// <param name="exp"></param>
        /// <param name="inventaire"></param>
        /// <param name="niveau"></param>
        /// <param name="StatDex"></param>
        /// <param name="StatInt"></param>
        /// <param name="StatStr"></param>
        /// <param name="StatVit"></param>
        /// <param name="x"></param>
        /// <param name="y"></param>
        public cHero(int argent, cClasse classeHero, int exp, cInventaireHeros inventaire, int niveau, int StatDex, int StatInt, int StatStr, int StatVit, int x, int y) // À modifier
        {
            _argent = argent; //
            _classeHero = classeHero;
            _experience = exp; //
            _inventaire = inventaire;
            _niveau = niveau; //
            _statDex = StatDex;
            _statInt = StatInt;
            _statStr = StatStr;
            _statVitalite = StatVit;
            _x = x;
            _y = y;
        }

        /// <summary>
        /// Permet de créer un héros.
        /// </summary>
        public void CreerHeros()
        {

        }

        /// <summary>
        /// Permet de déplacer un héros.
        /// </summary>
        public void DeplacerHeros()
        {

        }

        /// <summary>
        /// Permet de lister tous les héros pour un joueur.
        /// </summary>
        /// <param name="joueur"></param>
        public void ListerHeros(cCompteJoueur joueur)
        {

        }

        /// <summary>
        /// Permet de modifier les valeurs d'un héros.
        /// </summary>
        /// <param name="argent"></param>
        /// <param name="classeHeros"></param>
        /// <param name="exp"></param>
        /// <param name="inventaire"></param>
        /// <param name="niveau"></param>
        /// <param name="StatDex"></param>
        /// <param name="StatInt"></param>
        /// <param name="StatStr"></param>
        /// <param name="StatVit"></param>
        public void ModifierHeros(int argent, cClasse classeHeros, int exp, cInventaireHeros inventaire, int niveau, int StatDex, int StatInt, int StatStr, int StatVit)
        {
            _argent = argent;
            _classeHero = classeHeros;
            _experience = exp;
            _inventaire = inventaire;
            _niveau = niveau;
            _statDex = StatDex;
            _statInt = StatInt;
            _statStr = StatStr;
            _statVitalite = StatVit;
        }
        
        /// <summary>
        /// Permet de retourner tous les éléments dans un rayon de 200 par 200.
        /// </summary>
        /// <param name="monde"></param>
        public void RetournerElements(cMonde monde) // À modifier
        {

        }

        /// <summary>
        /// Permet de supprimer un héros.
        /// </summary>
        public void SupprimerHeros()
        {

        }
    }
}
