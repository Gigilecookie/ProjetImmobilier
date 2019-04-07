using Microsoft.EntityFrameworkCore;
using ProjetImmobilier.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace ProjetImmobilier.ViewModel
{
    class ManageViewModel : Tools.BaseNotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private int idPerson;
        private ObservableCollection<Estate> listEstate;
        private Estate selectedEstate;

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

        public Array EstateTypeItems
        {
            get { return Enum.GetValues(typeof(Model.EstateType)); }
        }

        public Array ContractTypeItems
        {
            get { return Enum.GetValues(typeof(Model.ContractType)); }
        }

        public Model.EstateType SelectedEstateType
        {
            get { return GetField<Model.EstateType>(); }
            set { SetField(value); }
        }

        public Model.ContractType SelectedContractType
        {
            get { return GetField<Model.ContractType>(); }
            set { SetField(value); }
        }

        public String Title
        {
            get { return GetField<String>(); }
            set { SetField(value); }
        }

        public bool Enabled
        {
            get { return GetField<bool>(); }
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

        public String FloorN
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

        public String Name
        {
            get { return GetField<String>(); }
            set { SetField(value); }
        }

        public String Firstname
        {
            get { return GetField<String>(); }
            set { SetField(value); }
        }

        public DateTime BuildDate
        {
            get { return GetField<DateTime>(); }
            set { SetField(value); }
        }

        public int Price
        {
            get { return GetField<int>(); }
            set { SetField(value); }
        }

        public String Description
        {
            get { return GetField<String>(); }
            set { SetField(value); }
        }

        public ManageViewModel()
        {
            listEstate = new ObservableCollection<Estate>(EstateDbContext.Current.Estates.Include(e => e.Photos)
                                                                                        .Include(e => e.Contracts)
                                                                                        .Include(e => e.MainPhoto)
                                                                                        .Include(e => e.Owner));

            Enabled = true;
            Address = "";
            Zip = "";
            City = "";
            Surface = "";
            FloorC = "";
            FloorN = "";
            RoomsC = "";
            EnergyE = "";
            BuildDate = DateTime.Now;
            Description = "";
        }

        public void selectEstate(Estate e)
        {
            
            int id = e.Id - 36;
            Address = listEstate[id].Address;
            Zip = listEstate[id].Zip;
            City = listEstate[id].City;
            Surface = listEstate[id].Surface.ToString();
            FloorC = listEstate[id].FloorCount.ToString();
            FloorN = listEstate[id].FloorNumber.ToString();
            RoomsC = listEstate[id].RoomsCount.ToString();
            EnergyE = listEstate[id].EnergyEfficiency.ToString();
            BuildDate = DateTime.Now;
            Description = listEstate[id].Contracts[0].Description;
            Name = listEstate[id].Owner.Name;
            Firstname = listEstate[id].Owner.FirstName;
            Price = (int)listEstate[id].Contracts[0].Price;
        }

        public Commands.Command EnvoyerFormulaire
        {

            get
            {
                return new Commands.Command(saveData);
            }

        }

        public Commands.Command Search
        {

            get
            {
                return new Commands.Command(search);
            }

        }

        public Commands.Command Add
        {

            get
            {
                return new Commands.Command(add);
            }

        }

        private void search()
        {
            var searchedPerson = Model.EstateDbContext.Current.Persons.Where(p => p.FirstName == Firstname && p.Name == Name)
                                                                      .Select(p => p.Id)
                                                                      .ToList();
            if (searchedPerson.Count != 0)
            {
                idPerson = searchedPerson[0];
                Enabled = false;
            }else
            {
                add();
            }
        }

        private void add()
        {
            View.AddPersonWindow win = new View.AddPersonWindow(Name, Firstname);
            win.Show();
        }

        private void saveData()
        {

            // Vérifier si l'adresse n'existe pas
            var estAddr = Model.EstateDbContext.Current.Estates.Where(e => e.Address == Address).ToList();

            if (estAddr.Count != 0)
            {
                // Créer l'estate
                var estate = new Model.Estate()
                {
                    Type = SelectedEstateType,
                    Address = Address,
                    Zip = Zip,
                    City = City,
                    Surface = Int32.Parse(Surface),
                    FloorCount = Int32.Parse(FloorC),
                    FloorNumber = Int32.Parse(FloorN),
                    RoomsCount = Int32.Parse(RoomsC),
                    EnergyEfficiency = Int32.Parse(EnergyE),
                    BuildDate = BuildDate,
                    OwnerId = idPerson
                };

                // Récupérer l'id en base de données
                var estId = Model.EstateDbContext.Current.Estates.Where(e => e.Address == Address).Select(e => e.Id).ToList();

                int eId = 0;
                if (estId.Count != 0)
                    eId = estId[0];

                // Créer le contrat
                var contract = new Model.Contract()
                {
                    EstateId = eId,
                    Type = SelectedContractType,
                    PubDate = new DateTime(),
                    Description = Description,
                    Title = Title,
                    Price = Price
                };
            }
        }

    }
}
