using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace ViewLifeCycle
{
    public class MyButtonViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        // This method is called by the Set accessor of each property.
        // The CallerMemberName attribute that is applied to the optional propertyName
        // parameter causes the property name of the caller to be substituted as an argument.
        protected void NotifyPropertyChanged([CallerMemberName] String propertyName = "")
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        private string buttonText = "Before Loaded";
        public string ButtonText{
            get{
                return buttonText;
            }
            set {
                buttonText = value;
                NotifyPropertyChanged();
            }
        }

        public MyButtonViewModel()
        {
        }
    }
}
