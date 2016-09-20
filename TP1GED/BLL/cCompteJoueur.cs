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
        private string _TypeUtilisateur; // Rempalcer par un enum ?

        /// <summary>
        /// Constructeur
        /// </summary>
        /// <param name="couriel"></param>
        /// <param name="nom"></param>
        /// <param name="prenom"></param>
        /// <param name="username"></param>
        /// <param name="mdp"></param>
        /// <param name="type"></param>
        public cCompteJoueur(string courriel, string nom, string prenom, string username, string mdp, string type)
        {
            _courriel = courriel;
            _nom = nom;
            _prenom = prenom;
            _nomUtilisateur = username;
            _password = mdp;
            _TypeUtilisateur = type;           
        }

        /// <summary>
        /// Permet de créer un nouveau joueur.
        /// </summary>
        public void CreerJoueur()
        {

        }
        
        /// <summary>
        /// Permet de modifier les paramètres d'un joueur.
        /// </summary>
        /// <param name="courriel"></param>
        /// <param name="nom"></param>
        /// <param name="prenom"></param>
        /// <param name="mdp"></param>
        /// <param name="type"></param>
        public void ModifierParametres(string courriel, string nom, string prenom, string mdp, string type) // A revoir
        {
            _courriel = courriel;
            _nom = nom;
            _prenom = prenom;
            _password = mdp;
            _TypeUtilisateur = type;
        }

        /// <summary>
        /// Permet de supprimer un joueur.
        /// </summary>
        public void SupprimerJoueur()
        {

        }

        /// <summary>
        /// Permet de valider la connexion d'un joueur
        /// </summary>
        public void ValiderConnexion()
        {

        }

    }
}
