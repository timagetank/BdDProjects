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
        private Classe _classe;

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
            _classe = new Classe();

            _classe.NomClasse = nom;
            _classe.Description = description;
            _classe.StatBaseStr = StatStr;
            _classe.StatBaseDex = StatDex;
            _classe.StatBaseInt = StatInt;
            _classe.StatBaseVitalite = StatVitalite;
        }

        public void CreerClasse()
        {
            context.Classe.Add(_classe);
            context.SaveChanges();
        }

        public void SuprimerClasse()
        {
            context.Classe.Remove(_classe);
            context.SaveChanges();
        }

        public void ModifierClasse(string nom, string description, int StatStr, int StatDex, int StatInt, int StatVitalite)
        {
            _classe.NomClasse = nom;
            _classe.Description = description;
            _classe.StatBaseStr = StatStr;
            _classe.StatBaseDex = StatDex;
            _classe.StatBaseInt = StatInt;
            _classe.StatBaseVitalite = StatVitalite;
        }

        public Classe AccederClass()
        {
            return _classe;
        }

    }
    
}
