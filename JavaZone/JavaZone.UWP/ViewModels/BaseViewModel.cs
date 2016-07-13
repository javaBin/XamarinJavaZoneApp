using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace JavaZone.UWP.ViewModels
{
    public class BaseViewModel : INotifyPropertyChanged
    {
        #region Variables
        public event PropertyChangedEventHandler PropertyChanged;

        private bool isBusy;
        #endregion

        public BaseViewModel()
        {
            
        }


        #region Methods

        #endregion



        #region Properties
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public bool IsBusy { get { return isBusy; } set { isBusy = value; OnPropertyChanged("IsBusy"); } }

        #endregion
    }
}
