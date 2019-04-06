using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace ProjetImmobilier.ViewModel
{
    class ManageViewModel : Tools.BaseNotifyPropertyChanged
    {

        private int idPerson;

        public Array EstateTypeItems
        {
            get { return Enum.GetValues(typeof(Model.EstateType)); }
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

            // Créer l'estate
            // Créer le contrat

            /*var e = new Model.Estate()
            {

                //Type = EstateType.House,
                Address = this.Address,
                Zip = this.Zip,
                City = this.City,
                //Latitude = 45.7997667,
                //Longitude = 4.8253093,
                Surface = Int32.Parse(this.Surface),
                FloorCount = Int32.Parse(this.FloorC),
                FloorNumber = Int32.Parse(this.FloorN),
                RoomsCount = Int32.Parse(this.RoomsC),
                EnergyEfficiency = Int32.Parse(this.EnergyE),
                BuildDate = this.BuildDate

            };

            Model.EstateDbContext.Current.Add(e);
            Model.EstateDbContext.Current.SaveChanges();

            /*var person = new Model.Person()
            {

                Quality = Quality.Miss,
                Name = "Fork",
                FirstName = "Beth",
                Address = "805 Crawford street",
                Zip = "27893",
                City = "Wilson",
                Latitude = 35.7154951,
                Longitude = -77.9208202,
                Phone = "+33758462136",
                CellPhone = "+33758462136",
                Mail = "beth.fork@gmail.com"

            };

            var estate = new Model.Estate()
            {

                Type = EstateType.House,
                Address = "23 Chemin de Montpellas",
                Zip = "69009",
                City = "Lyon",
                Latitude = 45.7997667,
                Longitude = 4.8253093,
                Surface = 190,
                FloorCount = 1,
                FloorNumber = -1,
                RoomsCount = 7,
                EnergyEfficiency = 4,
                BuildDate = new DateTime(2001, 2, 10, 0, 0, 0)
                
            };

            var contract = new Model.Contract()
            {

                EstateId = 1,
                Type = ContractType.Sale,
                PubDate = new DateTime(),
                Description = "Loft aux bordures de la campagne",
                Title = "Loft de 190m², Lyon 9ème",
                Price = 395000

            };

            DataAccess.EstateDbContext.Current.Add(person);
            DataAccess.EstateDbContext.Current.Add(estate);
            DataAccess.EstateDbContext.Current.Add(contract);

            DataAccess.EstateDbContext.Current.SaveChanges();*/

            /*var monBien = DataAccess.EstateDbContext.Current.Estates
                .Where(estate => estate.City == "Lyon")
                .OrderBy(estate => estate.Address)
                .First();*/
        }

    }
}
