using ProjetImmobilier.Model;
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
        private int ownerId;

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

        public String Nom
        {
            get { return GetField<String>(); }
            set { SetField(value); }
        }

        public String Prenom
        {
            get { return GetField<String>(); }
            set { SetField(value); }
        }

        public String Description
        {
            get { return GetField<String>(); }
            set { SetField(value); }
        }

        public int Prix
        {
            get { return GetField<int>(); }
            set { SetField(value); }
        }

        public bool Enabled
        {
            get { return GetField<bool>(); }
            set { SetField(value); }
        }

        public ManageViewModel()
        {
            BuildDate = DateTime.Now;
            Enabled = true;
            Address = "";
            Zip = "";
            City =  "";
            Surface = "";
            FloorC = "";
            FloorN = "";
            RoomsC = "";
            EnergyE = "";
            Nom = "";
            Prenom = "";
            Description = "";
        }

        public Commands.Command Rechercher
        {
            get
            {
                return new Commands.Command(search);
            }
        }

        public Commands.Command Ajouter
        {
            get
            {
                return new Commands.Command(add);
            }
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
            /*var e = new Model.Person()
            {

                Quality = Quality.Mister,
                Name = "Ferrer",
                FirstName = "Hugo",
                Address = "41 rue Hénon",
                Zip = "69004",
                City = "Lyon",
                Phone = "0608355564",
                CellPhone = "0608355564",
                Mail = "hugo-ferrer@hotmail.fr"

            };

            Model.EstateDbContext.Current.Add(e);
            Model.EstateDbContext.Current.SaveChanges();*/

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

        private void search()
        {
            if (!Nom.Equals("") && !Prenom.Equals(""))
            {
                var person = EstateDbContext.Current.Persons.Where(p => p.Name == Nom && p.FirstName == Prenom)
                                                            .Select(p => p.Id)
                                                            .ToList();
                if (person.Count != 0)
                {
                    ownerId = person[0];
                    Enabled = false;
                }
                else
                {
                    add();
                }
            } else
            {
                add();
            }
        }

        private void add()
        {
            View.AddPersonWindow win = new View.AddPersonWindow(Nom, Prenom);
            win.Show();
        }

    }
}
