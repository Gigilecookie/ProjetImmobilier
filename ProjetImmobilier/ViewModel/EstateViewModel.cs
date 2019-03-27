using ProjetImmobilier.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tools;

namespace ProjetImmobilier.ViewModel
{
    class EstateViewModel : BaseNotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private ObservableCollection<EstateItem> listEstate;
        private EstateItem selectedEstate;

        public EstateViewModel()
        {
            listEstate = new ObservableCollection<EstateItem>();
            listEstate.Add(new EstateItem("0", "120m²", "Maison", "C:\\Users\\Public\\Pictures\\Sample Pictures\\Koala.jpg"));
            listEstate.Add(new EstateItem("1", "120m²", "Appartement", "C:\\Users\\Public\\Pictures\\Sample Pictures\\Koala.jpg"));
            listEstate.Add(new EstateItem("2", "120m²", "Appartement", "C:\\Users\\Public\\Pictures\\Sample Pictures\\Koala.jpg"));
            listEstate.Add(new EstateItem("3", "120m²", "Appartement", "C:\\Users\\Public\\Pictures\\Sample Pictures\\Koala.jpg"));
            listEstate.Add(new EstateItem("4", "120m²", "Appartement", "C:\\Users\\Public\\Pictures\\Sample Pictures\\Koala.jpg"));
            listEstate.Add(new EstateItem("5", "120m²", "Appartement", "C:\\Users\\Public\\Pictures\\Sample Pictures\\Koala.jpg"));
            listEstate.Add(new EstateItem("6", "120m²", "Appartement", "C:\\Users\\Public\\Pictures\\Sample Pictures\\Koala.jpg"));
            listEstate.Add(new EstateItem("7", "120m²", "Appartement", "C:\\Users\\Public\\Pictures\\Sample Pictures\\Koala.jpg"));
            listEstate.Add(new EstateItem("8", "120m²", "Appartement", "C:\\Users\\Public\\Pictures\\Sample Pictures\\Koala.jpg"));
            listEstate.Add(new EstateItem("9", "120m²", "Appartement", "C:\\Users\\Public\\Pictures\\Sample Pictures\\Koala.jpg"));
            listEstate.Add(new EstateItem("10", "120m²", "Appartement", "C:\\Users\\Public\\Pictures\\Sample Pictures\\Koala.jpg"));
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

        public EstateItem SelectedEstate
        {
            get { return selectedEstate; }
            set
            {
                if (value != selectedEstate)
                {
                    selectedEstate = value;
                    selectEstate(selectedEstate);
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(SelectedEstate))); 
                }
            }
        }

        public Array EstateTypeItems
        {
            get { return Enum.GetValues(typeof(Model.EstateType)); }
        }

        public String Address
        {
            get { return GetField<String>(); }
            set { SetField(value); }
        }

        public String Zip
        {
            get { return GetField<String>(); }
            set { SetField(value); }
        }

        public String City
        {
            get { return GetField<String>(); }
            set { SetField(value); }
        }

        public String Surface
        {
            get { return GetField<String>(); }
            set { SetField(value); }
        }

        public String FloorC
        {
            get { return GetField<String>(); }
            set { SetField(value); }
        }

        public String RoomsC
        {
            get { return GetField<String>(); }
            set { SetField(value); }
        }

        public String EnergyE
        {
            get { return GetField<String>(); }
            set { SetField(value); }
        }

        public DateTime BuildDate
        {
            get { return GetField<DateTime>(); }
            set { SetField(value); }
        }

        private void selectEstate(EstateItem e)
        {
            RoomsC = e.Id;
            System.Console.WriteLine("JE SUIS LA !!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!");
        }
    }
}
