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
    /// Vue pour afficher les offres de casting.
    /// </summary>
    public partial class OffreCastingView : UserControl
    {
        /// <summary>
        /// Initialise une nouvelle instance de la classe OffreCastingView.
        /// </summary>
        public OffreCastingView()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Gère le clic sur le bouton "Effacer" pour vider les champs du formulaire.
        /// </summary>
        private void Clear_Click(object sender, RoutedEventArgs e)
        {
            // Cette méthode est vide car elle ne contient pas de logique spécifique, elle est probablement destinée à être implémentée ultérieurement.
            // Lorsqu'elle sera implémentée, cette méthode effacera les champs du formulaire.
        }
    }
}
