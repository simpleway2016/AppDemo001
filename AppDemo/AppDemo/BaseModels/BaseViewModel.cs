using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace AppDemo
{
    class BaseViewModel : INotifyPropertyChanged
    {
        public BaseModels.TextResourceModel textres
        {
            get => App.TextResource;
        }

        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged(string propertyName)
        {
            if(PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
}
