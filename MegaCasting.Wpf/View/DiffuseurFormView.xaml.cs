using Azure;
using MegaCasting.Wpf.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using MegaCasting.Wpf.ViewModel;


namespace MegaCasting.Wpf.View
{
    /// <summary>
    /// Vue pour afficher et interagir avec les formulaires de diffuseurs.
    /// </summary>
    public partial class DiffuseurFormView : UserControl
    {
        /// <summary>
        /// Initialise une nouvelle instance de la classe DiffuseurFormView.
        /// </summary>
        public DiffuseurFormView()
        {
            InitializeComponent();
            // Définit le contexte de données de cette vue sur une nouvelle instance de DiffuseurViewModel.
            this.DataContext = new DiffuseurViewModel();
        }

        /// <summary>
        /// Gère le clic sur le bouton "Insérer" pour ajouter un diffuseur.
        /// </summary>
        private void Insert_Click(object sender, RoutedEventArgs e) => ((DiffuseurViewModel)this.DataContext).AddDiffuseur();

        /// <summary>
        /// Gère le clic sur le bouton "Mettre à jour" pour mettre à jour un diffuseur.
        /// </summary>
        private void Update_Click(object sender, RoutedEventArgs e) => ((DiffuseurViewModel)this.DataContext).UpdateDiffuseur();

        /// <summary>
        /// Gère le clic sur le bouton "Supprimer" pour supprimer un diffuseur.
        /// </summary>
        private void Remove_Click(object sender, RoutedEventArgs e) => ((DiffuseurViewModel)this.DataContext).RemoveDiffuseur();
    }
}
