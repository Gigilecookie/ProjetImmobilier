using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetImmobilier.ViewModel
{
    class ManageViewModel : Tools.BaseNotifyPropertyChanged
    {

        private String address, zip, city, surface, floorC, floorN, roomsC, energyE;
        private DateTime buildDate;

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

        public DateTime BuildDate
        {
            get { return GetField<DateTime>(); }
            set { SetField(value); }
        }

        public ManageViewModel()
        {
            BuildDate = DateTime.Now;
        }

        public Commands.Command EnvoyerFormulaire
        {

            get
            {
                return new Commands.Command(saveData);
            }

        }

        private void saveData()
        {
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
