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
        private string _courriel;
        private cHero _hero; // ???
        private List<cHero> _heros;
        private string _nom;
        private string _prenom;
        private string _nomUtilisateur;
        private string _password;
        private int _TypeUtilisateur; // Rempalcer par un enum ?
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
            _courriel = courriel;
            _nom = nom;
            _prenom = prenom;
            _nomUtilisateur = username;
            _password = mdp;
            _TypeUtilisateur = type;           
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
        public void ModifierParametres(string courriel, string nom, string prenom, string mdp, int type) // A revoir
        {
            _courriel = courriel;
            _nom = nom;
            _prenom = prenom;
            _password = mdp;
            _TypeUtilisateur = type;
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
        public void ValiderConnexion()
        {

        }

    }
}
