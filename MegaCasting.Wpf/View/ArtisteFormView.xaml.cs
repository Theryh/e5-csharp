using MegaCasting.Wpf.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
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

namespace MegaCasting.Wpf.View
{
    /// <summary>
    /// Vue pour afficher et interagir avec les artistes.
    /// </summary>
    public partial class ArtisteView : UserControl
    {
        /// <summary>
        /// Initialise une nouvelle instance de la classe ArtisteView.
        /// </summary>
        public ArtisteView()
        {
            InitializeComponent();
            // Définit le contexte de données de cette vue sur une nouvelle instance de ArtisteListViewModel.
            this.DataContext = new ArtisteListViewModel();
        }

        /// <summary>
        /// Gère le clic sur le bouton "Insérer" pour ajouter un artiste.
        /// </summary>
        private void Insert_Click(object sender, RoutedEventArgs e) => ((ArtisteListViewModel)this.DataContext).AddArtiste();

        /// <summary>
        /// Gère le clic sur le bouton "Mettre à jour" pour mettre à jour un artiste.
        /// </summary>
        private void Update_Click(object sender, RoutedEventArgs e) => ((ArtisteListViewModel)this.DataContext).UpdateArtiste();

        /// <summary>
        /// Gère le clic sur le bouton "Supprimer" pour supprimer un artiste.
        /// </summary>
        private void Remove_Click(object sender, RoutedEventArgs e) => ((ArtisteListViewModel)this.DataContext).RemoveArtiste();

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
