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
        private Heros _hero;

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
            _hero.Argent = argent; //
            _hero.Classe = classeHero.AccederClass();
            _hero.Experience = exp; //
           // Yo WTF ? _hero.InventaireHero = inventaire.AccederInventaire();
            _hero.Niveau = niveau; //
            _hero.StatDex = StatDex;
            _hero.StatInt = StatInt;
            _hero.StatStr = StatStr;
            _hero.StatVitalite = StatVit;
            _hero.x = x;
            _hero.y = y;
        }

        /// <summary>
        /// Permet de créer un héros.
        /// </summary>
        public void CreerHeros()
        {
            context.Heros.Add(_hero);
            context.SaveChanges();
        }

        /// <summary>
        /// Permet de déplacer un héros.
        /// </summary>
        public void DeplacerHeros(int x, int y)
        {
            _hero.x = x;
            _hero.y = y;
            context.SaveChanges();
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
            _hero.Argent = argent;
            _hero.Classe = classeHeros.AccederClass();
            _hero.Experience = exp;
            // Still, the fuck ?_hero.Inventaire = inventaire;
            _hero.Niveau = niveau;
            _hero.StatDex = StatDex;
            _hero.StatInt = StatInt;
            _hero.StatStr = StatStr;
            _hero.StatVitalite = StatVit;
        }
        
        /// <summary>
        /// Permet de retourner tous les éléments dans un rayon de 200 par 200.
        /// </summary>
        /// <param name="monde"></param>
        public IEnumerable<ObjetMonde> RetournerElements() // À modifier
        {
            return _hero.Monde.ObjetMonde.Where(obj => Math.Abs(obj.x - _hero.x) <= 200 && Math.Abs(obj.y - _hero.y) <= 200);
        }

        /// <summary>
        /// Permet de supprimer un héros.
        /// </summary>
        public void SupprimerHeros()
        {
            context.Heros.Remove(_hero);
            context.SaveChanges();
        }
    }
}
