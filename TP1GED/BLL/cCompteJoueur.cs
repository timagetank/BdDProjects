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
    /// Description: Permet de créer les paramètres de connexion du joueur.
    /// Date: 2016-09-12
    /// </summary>
    public class cCompteJoueur : cTable
    {
        private CompteJoueur _compte;

        /// <summary>
        /// Constructeur
        /// </summary>
        /// <param name="couriel"></param>
        /// <param name="nom"></param>
        /// <param name="prenom"></param>
        /// <param name="username"></param>
        /// <param name="mdp"></param>
        /// <param name="type"></param>
        public cCompteJoueur(string courriel, string nom, string prenom, string username, string mdp, int type)
        {
            _compte = new CompteJoueur();

            _compte.Courriel = courriel;
            _compte.Nom = nom;
            _compte.Prenom = prenom;
            _compte.NomUtilisateur = username;
            _compte.Password = mdp;
            _compte.TypeUtilisateur = type;   
        }

    
        public CompteJoueur AccesCompte
        {
            get
            {
                return _compte;
            }
        }

        /// <summary>
        /// Permet de créer un nouveau joueur.
        /// </summary>
        public void CreerJoueur()
        {
            context.CompteJoueur.Add(_compte);
            context.SaveChanges();
        }
        
        /// <summary>
        /// Permet de modifier les paramètres d'un joueur.
        /// </summary>
        /// <param name="courriel"></param>
        /// <param name="nom"></param>
        /// <param name="prenom"></param>
        /// <param name="mdp"></param>
        /// <param name="type"></param>
        public void ModifierParametres(string courriel, string nom, string prenom, string userName, string mdp, int type)
        {
            _compte.Courriel = courriel;
            _compte.Nom = nom;
            _compte.Prenom = prenom;
            _compte.NomUtilisateur = userName;
            _compte.Password = mdp;
            _compte.TypeUtilisateur = type;
            context.SaveChanges();
        }

        /// <summary>
        /// Permet de supprimer un joueur.
        /// </summary>
        public void SupprimerJoueur()
        {
            context.CompteJoueur.Remove(_compte);
            context.SaveChanges();
        }

        /// <summary>
        /// Permet de valider la connexion d'un joueur
        /// </summary>
        public bool ValiderConnexion(string userName, string mdp)
        {
            var joueur = context.CompteJoueur.Where(x => x.NomUtilisateur == userName).FirstOrDefault();
            if (joueur.Password == mdp)
                return true;
            return false;
        }

    }
}
