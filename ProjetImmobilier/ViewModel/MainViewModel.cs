using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using Tools;
using Commands;
using System.Collections.ObjectModel;

namespace ProjetImmobilier.ViewModel
{
    class MainViewModel : BaseNotifyPropertyChanged
    {
        ObservableCollection<object> _tabs;

        public MainViewModel()
        {
            _tabs = new ObservableCollection<object>();
            _tabs.Add(new HomeViewModel());
            _tabs.Add(new EstateViewModel());
            _tabs.Add(new ManageViewModel());
            _tabs.Add(new SettingsViewModel());
        }

        public ObservableCollection<object> Tabs { get { return _tabs; } }

    }
}
