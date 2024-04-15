using MegaCasting.Core;
using MegaCasting.DBLib.Class;
using MegaCasting.Wpf.Core;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaCasting.Wpf.ViewModel
{
    /// <summary>
    /// ViewModel pour la gestion des Contrat.
    /// </summary>
    class ContratViewModel : ObservableObject
    {
        // Collection Contrat
        private ObservableCollection<Contrat> _Contrats;

        /// <summary>
        /// Obtient ou définit la collection Contrat.
        /// </summary>
        public ObservableCollection<Contrat> Contrats
        {
            get { return _Contrats; }
            set { SetProperty(nameof(Contrat), ref _Contrats, value); }
        }

        /// <summary>
        /// Initialise une nouvelle instance de la classe ContratViewModel.
        /// </summary>
        public ContratViewModel()
        {
            using (MegaCastingContext mg = new MegaCastingContext())
            {
                // Initialise la collection de Contrat avec les données de la base de données
                Contrats = new ObservableCollection<Contrat>(mg.Contrats.ToList());
            }
        }
    }
}
