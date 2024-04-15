using MegaCasting.DBLib.Class;
using MegaCasting.Wpf.View;
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

namespace MegaCasting.Wpf
{
    /// <summary>
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Action déclenchée lors du clic sur le bouton "Liste Diffuseur"
        /// </summary>
        /// <param name="sender">L'objet qui a déclenché l'événement</param>
        /// <param name="e">Les données de l'événement</param>
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Doc.Children.Clear();
            this.Doc.Children.Add(new DiffuseurView());
        }

        /// <summary>
        /// Action déclenchée lors du clic sur le bouton "Ajouter Artiste"
        /// </summary>
        /// <param name="sender">L'objet qui a déclenché l'événement</param>
        /// <param name="e">Les données de l'événement</param>
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            this.Doc.Children.Clear();
            this.Doc.Children.Add(new ArtisteView());
        }

        /// <summary>
        /// Action déclenchée lors du clic sur le bouton "Liste Artiste"
        /// </summary>
        /// <param name="sender">L'objet qui a déclenché l'événement</param>
        /// <param name="e">Les données de l'événement</param>
        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            this.Doc.Children.Clear();
            this.Doc.Children.Add(new ArtisteListView());
        }

        /// <summary>
        /// Action déclenchée lors du clic sur le bouton "Ajouter offre Casting"
        /// </summary>
        /// <param name="sender">L'objet qui a déclenché l'événement</param>
        /// <param name="e">Les données de l'événement</param>
        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            this.Doc.Children.Clear();
            this.Doc.Children.Add(new OffreCastingView());
        }

        /// <summary>
        /// Action déclenchée lors du clic sur le bouton "Ajouter Diffuseur"
        /// </summary>
        /// <param name="sender">L'objet qui a déclenché l'événement</param>
        /// <param name="e">Les données de l'événement</param>
        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            this.Doc.Children.Clear();
            this.Doc.Children.Add(new DiffuseurFormView());
        }

        /// <summary>
        /// Action déclenchée lors du clic sur le bouton "Liste Offre Casting"
        /// </summary>
        /// <param name="sender">L'objet qui a déclenché l'événement</param>
        /// <param name="e">Les données de l'événement</param>
        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            this.Doc.Children.Clear();
            this.Doc.Children.Add(new OffreCastingListe());
        }

        /// <summary>
        /// Action déclenchée lors du clic sur le bouton "Fermer"
        /// </summary>
        /// <param name="sender">L'objet qui a déclenché l'événement</param>
        /// <param name="e">Les données de l'événement</param>
        private void CloseButton_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }


        /// <summary>
        /// Action déclenchée lors du clic sur le bouton "Liste Contrat"
        /// </summary>
        /// <param name="sender">L'objet qui a déclenché l'événement</param>
        /// <param name="e">Les données de l'événement</param>
        private void Button_Click_6(object sender, RoutedEventArgs e)
        {

            this.Doc.Children.Clear();
            this.Doc.Children.Add(new ContratListe());
        }
    }
}
