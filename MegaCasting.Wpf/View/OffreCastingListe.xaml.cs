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
    /// Vue pour afficher une liste d'offres de casting.
    /// </summary>
    public partial class OffreCastingListe : UserControl
    {
        /// <summary>
        /// Initialise une nouvelle instance de la classe OffreCastingListe.
        /// </summary>
        public OffreCastingListe()
        {
            InitializeComponent();
            // Définit le contexte de données de cette vue sur une nouvelle instance de OffreCastingViewModel.
            this.DataContext = new OffreCastingViewModel();
        }
    }
}
