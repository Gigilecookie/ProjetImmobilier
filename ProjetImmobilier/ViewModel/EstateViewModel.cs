using ProjetImmobilier.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetImmobilier.ViewModel
{
    class EstateViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private ObservableCollection<EstateItem> listEstate;

        public EstateViewModel()
        {
            listEstate = new ObservableCollection<EstateItem>();
            listEstate.Add(new EstateItem("Maison 1", "Maison", ""));
            listEstate.Add(new EstateItem("Appartement 1", "Appartement", ""));

        }

        public ObservableCollection<EstateItem> ListEstate
        {
            get { return listEstate; }
            set
            {
                if (value != listEstate)
                {
                    listEstate = value;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(ListEstate)));
                }
            }
        }

    }
}
