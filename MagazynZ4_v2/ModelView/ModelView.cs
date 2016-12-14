using System.Collections.Generic;
using System.ComponentModel;

namespace MagazynZ4
{
    public class ModelView : INotifyPropertyChanged
    {
        #region Konstruktor

        MainWindow _mainWindow;

        public ModelView(MainWindow window)
        {
            _mainWindow = window;
        }

        #endregion

        #region Manipulatory

        private bool _isManipulatorsFlyoutShowed = false;
        /// <summary>
        /// Flyout otwarty/zamknięty
        /// </summary>
        public bool IsManipulatorsFlyoutShowed
        {
            get { return _isManipulatorsFlyoutShowed; }
            set
            {
                SetField(ref _isManipulatorsFlyoutShowed, value, "IsManipulatorsFlyoutShowed");
            }
        }

        private string _manipulatorName;
        /// <summary>
        /// Header - "Manipulator" + "numer_wybranego_manipulatora"
        /// </summary>
        public string ManipulatorName
        {
            get { return _manipulatorName; }
            set { SetField(ref _manipulatorName, value, "ManipulatorName"); }
        }

        #endregion

        #region Magazyn

        private bool _isStorageFlyoutShowed = false;
        /// <summary>
        /// Flyout otwarty/zamknięty
        /// </summary>
        public bool IsStorageFlyoutShowed
        {
            get { return _isStorageFlyoutShowed; }
            set
            {

                if (SetField(ref _isStorageFlyoutShowed, value, "IsStorageFlyoutShowed"));
                            
            }
        }

        private string _storageName;
        /// <summary>
        /// Header - "Magazyn" + "numer_wybranego_manipulatora"
        /// </summary>
        public string StorageName
        {
            get { return _storageName; }
            set { SetField(ref _storageName, value, "StorageName"); }
        }

        #endregion
        
        #region Implementacja interfejsu INotifyPropertyChanged

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }


        bool SetField<T>(ref T field, T value, string propertyName)
        {
            if (EqualityComparer<T>.Default.Equals(field, value))
                return false;

            field = value;
            OnPropertyChanged(propertyName);

            return true;
        }

        #endregion


    }
}
