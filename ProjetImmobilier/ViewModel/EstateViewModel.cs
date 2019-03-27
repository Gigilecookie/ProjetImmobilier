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
            listEstate.Add(new EstateItem("0","Maison 1", "Maison", "C:\\Users\\Public\\Pictures\\Sample Pictures\\Koala.jpg"));
            listEstate.Add(new EstateItem("1", "Appartement 1", "Appartement", "C:\\Users\\Public\\Pictures\\Sample Pictures\\Koala.jpg"));
            listEstate.Add(new EstateItem("2", "Appartement 2", "Appartement", "C:\\Users\\Public\\Pictures\\Sample Pictures\\Koala.jpg"));
            listEstate.Add(new EstateItem("3", "Appartement 3", "Appartement", "C:\\Users\\Public\\Pictures\\Sample Pictures\\Koala.jpg"));
            listEstate.Add(new EstateItem("4", "Appartement 4", "Appartement", "C:\\Users\\Public\\Pictures\\Sample Pictures\\Koala.jpg"));
            listEstate.Add(new EstateItem("5", "Appartement 5", "Appartement", "C:\\Users\\Public\\Pictures\\Sample Pictures\\Koala.jpg"));
            listEstate.Add(new EstateItem("6", "Appartement 6", "Appartement", "C:\\Users\\Public\\Pictures\\Sample Pictures\\Koala.jpg"));
            listEstate.Add(new EstateItem("7", "Appartement 7", "Appartement", "C:\\Users\\Public\\Pictures\\Sample Pictures\\Koala.jpg"));
            listEstate.Add(new EstateItem("8", "Appartement 8", "Appartement", "C:\\Users\\Public\\Pictures\\Sample Pictures\\Koala.jpg"));
            listEstate.Add(new EstateItem("9", "Appartement 9", "Appartement", "C:\\Users\\Public\\Pictures\\Sample Pictures\\Koala.jpg"));
            listEstate.Add(new EstateItem("10", "Appartement 10", "Appartement", "C:\\Users\\Public\\Pictures\\Sample Pictures\\Koala.jpg"));
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
