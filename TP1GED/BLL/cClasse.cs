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
    /// Description: Permet de définir les classes associées aux héros du jeu.
    /// Date: 2016-09-14
    /// </summary>
    public class cClasse : cTable
    {
        private string _nom;
        private string _description;
        private int _statBaseStr;
        private int _statBaseDex;
        private int _statBaseInt;
        private int _statBaseVitalite;

        /// <summary>
        /// Constructeur
        /// </summary>
        /// <param name="nom"></param>
        /// <param name="description"></param>
        /// <param name="StatStr"></param>
        /// <param name="StatDex"></param>
        /// <param name="StatInt"></param>
        /// <param name="StatVitalite"></param>
        public cClasse(string nom, string description, int StatStr, int StatDex, int StatInt, int StatVitalite)
        {
            _nom = nom;
            _description = description;
            _statBaseStr = StatStr;
            _statBaseDex = StatDex;
            _statBaseInt = StatInt;
            _statBaseVitalite = StatVitalite;
        }

        public void CreerClasse()
        {
            
        }

        public void ModifierClasse()
        {

        }

    }
    
}
