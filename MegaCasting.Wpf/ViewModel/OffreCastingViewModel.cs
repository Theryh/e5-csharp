using MegaCasting.Core;
using MegaCasting.DBLib.Class;
using MegaCasting.Wpf.Core;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaCasting.Wpf.ViewModel
{
    /// <summary>
    /// ViewModel pour la gestion des offres de casting.
    /// </summary>
    class OffreCastingViewModel : ObservableObject
    {
        // Collection d'offres de casting
        private ObservableCollection<Casting> _OffreCastings;

        /// <summary>
        /// Obtient ou définit la collection d'offres de casting.
        /// </summary>
        public ObservableCollection<Casting> OffreCastings
        {
            get { return _OffreCastings; }
            set { SetProperty(nameof(OffreCastings), ref _OffreCastings, value); }
        }

        /// <summary>
        /// Initialise une nouvelle instance de la classe OffreCastingViewModel.
        /// </summary>
        public OffreCastingViewModel()
        {
            using (MegaCastingContext mg = new MegaCastingContext())
            {
                // Initialise la collection d'offres de casting avec les données de la base de données
                OffreCastings = new ObservableCollection<Casting>(mg.Castings.ToList());
            }
        }
    }
}