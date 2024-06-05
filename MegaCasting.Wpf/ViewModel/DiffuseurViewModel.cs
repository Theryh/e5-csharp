using MegaCasting.Core;
using MegaCasting.DBLib.Class;
using MegaCasting.Wpf.Core;
using System.Collections.ObjectModel;
using System.Linq;
using System.Windows;

namespace MegaCasting.Wpf.ViewModel
{
    class DiffuseurViewModel : ObservableObject
    {
        // Collection de diffuseurs
        private ObservableCollection<Diffuseur> _Diffuseurs;

        /// <summary>
        /// Obtient ou définit la collection de diffuseurs.
        /// </summary>
        public ObservableCollection<Diffuseur> Diffuseurs
        {
            get { return _Diffuseurs; }
            set { SetProperty(nameof(Diffuseurs), ref _Diffuseurs, value); }
        }

        // Nom du nouveau diffuseur
        private string _NewDiffuseurName;

        /// <summary>
        /// Obtient ou définit le nom du nouveau diffuseur.
        /// </summary>
        public string NewDiffuseurName
        {
            get { return _NewDiffuseurName; }
            set { SetProperty(nameof(NewDiffuseurName), ref _NewDiffuseurName, value); }
        }

        // Note de montage du nouveau diffuseur
        private string _NewNoteDeMontage;

        /// <summary>
        /// Obtient ou définit la note de montage du nouveau diffuseur.
        /// </summary>
        public string NewNoteDeMontage
        {
            get { return _NewNoteDeMontage; }
            set { SetProperty(nameof(NewNoteDeMontage), ref _NewNoteDeMontage, value); }
        }

        // Diffuseur sélectionné
        private Diffuseur _SelectedDiffuseur;

        /// <summary>
        /// Obtient ou définit le diffuseur sélectionné.
        /// </summary>
        public Diffuseur SelectedDiffuseur
        {
            get { return _SelectedDiffuseur; }
            set { SetProperty(nameof(SelectedDiffuseur), ref _SelectedDiffuseur, value); }
        }

        /// <summary>
        /// Initialise une nouvelle instance de la classe DiffuseurViewModel.
        /// </summary>
        public DiffuseurViewModel()
        {
            using (MegaCastingContext mg = new MegaCastingContext())
            {
                // Initialise la collection de diffuseurs avec les données de la base de données
                Diffuseurs = new ObservableCollection<Diffuseur>(mg.Diffuseurs.ToList());
            }
        }

        /// <summary>
        /// Ajoute un diffuseur
        /// </summary>
        public void AddDiffuseur()
        {
            // Vérifie si le libellé du diffuseur est rempli
            if (!string.IsNullOrWhiteSpace(NewDiffuseurName))
            {
                using (MegaCastingContext mg = new MegaCastingContext())
                {
                    // Crée un nouveau diffuseur avec les valeurs spécifiées
                    Diffuseur newDiffuseur = new Diffuseur
                    {
                        LibelleDiffuseur = NewDiffuseurName,
                        NoteDeMontage = NewNoteDeMontage // Assigner la note de montage
                    };

                    // Ajoute le nouveau diffuseur à la base de données et à la collection
                    mg.Add(newDiffuseur);
                    mg.SaveChanges();
                    Diffuseurs.Add(newDiffuseur);
                }
            }
            else
            {
                // Affiche un message d'erreur si le libellé du diffuseur n'est pas rempli
                MessageBox.Show("Veuillez remplir le libellé du diffuseur.", "Erreur", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        /// <summary>
        /// Mise à jour d'un diffuseur
        /// </summary>
        public void UpdateDiffuseur()
        {
            // Vérifie si un diffuseur est sélectionné
            if (SelectedDiffuseur != null)
            {
                using (MegaCastingContext mg = new MegaCastingContext())
                {
                    mg.Update(SelectedDiffuseur);
                    mg.SaveChanges();
                }
            }
            else
            {
                // Affiche un message d'erreur si aucun diffuseur n'est sélectionné
                MessageBox.Show("Veuillez sélectionner un diffuseur à mettre à jour.", "Erreur", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        /// <summary>
        /// Supprime un diffuseur
        /// </summary>
        public void RemoveDiffuseur()
        {
            // Vérifie si un diffuseur est sélectionné
            if (SelectedDiffuseur != null)
            {
                using (MegaCastingContext mg = new MegaCastingContext())
                {
                    mg.Remove(SelectedDiffuseur);
                    mg.SaveChanges();
                    Diffuseurs.Remove(SelectedDiffuseur);
                }
            }
            else
            {
                // Affiche un message d'erreur si aucun diffuseur n'est sélectionné
                MessageBox.Show("Veuillez sélectionner un diffuseur à supprimer.", "Erreur", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        public void Refresh()
        {

        }
    }
}
