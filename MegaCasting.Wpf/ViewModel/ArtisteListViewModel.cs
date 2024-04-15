using MegaCasting.Core;
using MegaCasting.DBLib.Class;
using MegaCasting.Wpf.Core;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;


namespace MegaCasting.Wpf.ViewModel
{
    /// <summary>
    /// ViewModel pour la gestion des artistes.
    /// </summary>
    class ArtisteListViewModel : ObservableObject
    {
        // Collection d'artistes
        private ObservableCollection<Artiste> _Artistes;

        /// <summary>
        /// Obtient ou définit la collection d'artistes.
        /// </summary>
        public ObservableCollection<Artiste> Artistes
        {
            get { return _Artistes; }
            set { SetProperty(nameof(Artistes), ref _Artistes, value); }
        }

        // Collection de métiers
        private ObservableCollection<Metier> _Metiers;

        /// <summary>
        /// Obtient ou définit la collection de métiers.
        /// </summary>
        public ObservableCollection<Metier> Metiers
        {
            get { return _Metiers; }
            set { SetProperty(nameof(Metiers), ref _Metiers, value); }
        }

        // Métier sélectionné
        private Metier _SelectedMetier;

        /// <summary>
        /// Obtient ou définit le métier sélectionné.
        /// </summary>
        public Metier SelectedMetier
        {
            get { return _SelectedMetier; }
            set { SetProperty(nameof(SelectedMetier), ref _SelectedMetier, value); }
        }

        // Nom du nouvel artiste
        private string _NewArtisteName;

        /// <summary>
        /// Obtient ou définit le nom du nouvel artiste.
        /// </summary>
        public string NewArtisteName
        {
            get { return _NewArtisteName; }
            set { SetProperty(nameof(NewArtisteName), ref _NewArtisteName, value); }
        }



        private string _NewArtisteAge;

        /// <summary>
        /// Obtient ou définit l'âge du nouvel artiste.
        /// </summary>
        public string NewArtisteAge
        {
            get { return _NewArtisteAge; }
            set { SetProperty(nameof(NewArtisteAge), ref _NewArtisteAge, value); }
        }

        private string _NewArtistePrenom;

        /// <summary>
        /// Obtient ou définit le prénom du nouvel artiste.
        /// </summary>
        public string NewArtistePrenom
        {
            get { return _NewArtistePrenom; }
            set { SetProperty(nameof(NewArtistePrenom), ref _NewArtistePrenom, value); }
        }

        private Artiste _SelectedArtiste;

        /// <summary>
        /// Obtient ou définit l'artiste sélectionné.
        /// </summary>
        public Artiste SelectedArtiste
        {
            get { return _SelectedArtiste; }
            set { SetProperty(nameof(SelectedArtiste), ref _SelectedArtiste, value); }
        }

        /// <summary>
        /// Initialise une nouvelle instance de la classe ArtisteListViewModel.
        /// </summary>
        public ArtisteListViewModel()
        {
            using (MegaCastingContext mg = new MegaCastingContext())
            {
                // Initialise la collection d'artistes avec les données de la base de données
                Artistes = new ObservableCollection<Artiste>(mg.Artistes.ToList());

                // Initialise la collection de métiers avec les données de la base de données
                Metiers = new ObservableCollection<Metier>(mg.Metiers.ToList());
            }
        }

        /// <summary>
        /// Méthode pour ajouter un nouvel artiste.
        /// </summary>
        public void AddArtiste()
        {
            using (MegaCastingContext mg = new MegaCastingContext())
            {
                // Vérifie si un Metier est sélectionné
                if (SelectedMetier != null)
                {
                    // Vérifie si les champs Nom et Prénom sont remplis
                    if (!string.IsNullOrEmpty(NewArtisteName) && !string.IsNullOrEmpty(NewArtistePrenom))
                    {
                        // Convertit NewArtisteAge en entier
                        if (int.TryParse(NewArtisteAge, out int age))
                        {
                            // Crée un nouvel Artiste avec l'ID du Metier sélectionné
                            Artiste newArtiste = new Artiste
                            {
                                Nom = NewArtisteName,
                                Prenom = NewArtistePrenom, // Définit le prénom
                                Age = age, // Définit l'âge
                                MetierId = SelectedMetier.Id  // Définit l'ID du Metier sélectionné
                            };

                            mg.Add(newArtiste);
                            mg.SaveChanges();
                            Artistes.Add(newArtiste);
                        }
                        else
                        {
                            // Affiche un message d'erreur pour l'âge non valide
                            MessageBox.Show("L'âge doit être un entier valide.", "Erreur", MessageBoxButton.OK, MessageBoxImage.Error);
                        }
                    }
                    else
                    {
                        // Affiche un message d'erreur pour les champs manquants
                        MessageBox.Show("Veuillez remplir tous les champs.", "Erreur", MessageBoxButton.OK, MessageBoxImage.Error);
                    }
                }
                else
                {
                    // Affiche un message d'erreur pour aucun Metier sélectionné
                    MessageBox.Show("Veuillez sélectionner un métier.", "Erreur", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
        }

        /// <summary>
        /// Méthode pour mettre à jour les informations d'un artiste.
        /// </summary>
        public void UpdateArtiste()
        {
            // Vérifie si un artiste est sélectionné
            if (SelectedArtiste != null)
            {
                using (MegaCastingContext mg = new MegaCastingContext())
                {
                    mg.Update(SelectedArtiste);
                    mg.SaveChanges();
                }
            }
            else
            {
                // Affiche un message d'erreur si aucun artiste n'est sélectionné
                MessageBox.Show("Veuillez sélectionner un artiste à mettre à jour.", "Erreur", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        /// <summary>
        /// Méthode pour supprimer un artiste.
        /// </summary>
        public void RemoveArtiste()
        {
            // Vérifie si un artiste est sélectionné
            if (SelectedArtiste != null)
            {
                using (MegaCastingContext mg = new MegaCastingContext())
                {
                    mg.Remove(SelectedArtiste);
                    mg.SaveChanges();
                    Artistes.Remove(SelectedArtiste);
                }
            }
            else
            {
                // Affiche un message d'erreur si aucun artiste n'est sélectionné
                MessageBox.Show("Veuillez sélectionner un artiste à supprimer.", "Erreur", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

    }
}