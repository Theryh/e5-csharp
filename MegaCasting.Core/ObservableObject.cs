using System.ComponentModel;

namespace MegaCasting.Core
{
    /// <summary>
    /// Classe rendant un objet observable
    /// </summary>
    public abstract class ObservableObject : INotifyPropertyChanged, INotifyPropertyChanging
    {
        #region Events

        /// <summary>
        /// Se produit quand on modifie une propriété
        /// </summary>
        public event PropertyChangingEventHandler? PropertyChanging;

        /// <summary>
        /// Se produit quand la propriété à été changée
        /// </summary>
        public event PropertyChangedEventHandler? PropertyChanged;

        #endregion

        #region Methods

        /// <summary>
        /// Déclenche l'événement <see cref="PropertyChanging"/>
        /// </summary>
        /// <param name="propertyName"></param>
        protected void OnPropertyChanging(string propertyName)
        {
            this.PropertyChanging?.Invoke(this, new PropertyChangingEventArgs(propertyName));
        }
        /// <summary>
        /// Déclenche l'événement <see cref="PropertyChanged"/>
        /// </summary>
        /// <param name="propertyName"></param>
        protected void OnPropertyChanged(string propertyName)
        {
            this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        /// <summary>
        /// Assigne une propriété et déclenche les événements <see cref="PropertyChanging"/> puis <see cref="PropertyChanged"/> 
        /// </summary>
        /// <typeparam name="T">Type de la propriété</typeparam>
        /// <param name="propertyName">Nom de la propriété</param>
        /// <param name="field">Référence de l'attribut à assigner</param>
        /// <param name="value"> Valeur</param>
        protected void SetProperty<T>(string propertyName, ref T field, T value)
        {
            if ((field == null && value != null)
                || (field?.Equals(value) == false))
            {
                OnPropertyChanging(propertyName);
                field = value;
                OnPropertyChanged(propertyName);

            }
        }


        #endregion

    }
}