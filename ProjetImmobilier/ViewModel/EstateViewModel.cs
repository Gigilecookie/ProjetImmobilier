using ProjetImmobilier.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjetImmobilier.Tools;
using Microsoft.EntityFrameworkCore;

namespace ProjetImmobilier.ViewModel
{
    class EstateViewModel : BaseNotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private Estate selectedEstate;
        private ObservableCollection<Estate> listEstate;
        private String searchBar;

        public EstateViewModel()
        {
            listEstate = new ObservableCollection<Estate>(EstateDbContext.Current.Estates.Include(e => e.Photos)
                                                                                        .Include(e => e.Contracts)
                                                                                        .Include(e => e.MainPhoto)
                                                                                        .Include(e => e.Owner));
            if (listEstate.Count != 0)
                selectEstate(listEstate[0]);

            searchBar = "Search";
        }

        public ObservableCollection<Estate> ListEstate
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

        public Estate SelectedEstate
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

        public String SearchBar
        {
            get { return searchBar; }
            set
            {
                if (value != searchBar)
                {
                    searchBar = value;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(SearchBar)));
                }
            }
        }

        public String EstateType
        {
            get { return GetField<String>(); }
            set { SetField(value); }
        }

        public String Title
        {
            get { return GetField<String>(); }
            set { SetField(value); }
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

        public String Photo
        {
            get { return GetField<String>(); }
            set { SetField(value); }
        }

        public String Owner
        {
            get { return GetField<String>(); }
            set { SetField(value); }
        }

        private void selectEstate(Estate e)
        {
            int id = e.Id - 36;

            EstateType = listEstate[id].Type.ToString();
            Title = listEstate[id].Contracts[0].Title;
            Photo = listEstate[id].MainPhoto.Content;
            Address = listEstate[id].Address.ToString();
            Zip = listEstate[id].Zip.ToString();
            City = listEstate[id].City.ToString();
            Surface = listEstate[id].Surface.ToString() + "m²";
            FloorC = listEstate[id].FloorCount.ToString();
            RoomsC = listEstate[id].RoomsCount.ToString();
            EnergyE = listEstate[id].EnergyEfficiency.ToString();
            RoomsC = listEstate[id].RoomsCount.ToString();
            //BuildDate = listEstate[id].BuildDate.Value;
            Owner = listEstate[id].Owner.CompleteName.ToString();

        }


        public Commands.Command Search
        {

            get
            {
                return new Commands.Command(search);
            }

        }

        private void search()
        {

        }
    }
}
