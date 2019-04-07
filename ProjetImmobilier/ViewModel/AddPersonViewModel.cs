using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetImmobilier.ViewModel
{
    class AddPersonViewModel : Tools.BaseNotifyPropertyChanged
    {

        private View.AddPersonWindow win;

        public AddPersonViewModel(String n, String p, View.AddPersonWindow o)
        {
            Lastname = n;
            Firstname = p;
            AddressP = "";
            Zip = "";
            City = "";
            Phone = "";
            Mail = "";
            win = o;
        }

        public Array QualityItems
        {
            get { return Enum.GetValues(typeof(Model.Quality)); }
        }

        public Model.Quality Selected
        {
            get { return GetField<Model.Quality>(); }
            set { SetField(value); }
        }

        public String Lastname
        {
            get { return GetField<String>(); }
            set { SetField(value); }
        }

        public String Firstname
        {
            get { return GetField<String>(); }
            set { SetField(value); }
        }

        public String AddressP
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

        public String Phone
        {
            get { return GetField<String>(); }
            set { SetField(value); }
        }

        public String Mail
        {
            get { return GetField<String>(); }
            set { SetField(value); }
        }

        public Commands.Command Add
        {

            get
            {
                return new Commands.Command(add);
            }

        }

        private void add()
        {

            // Vérifier tous les champs

            var person = new Model.Person()
            {
                Quality = Selected,
                Name = Lastname,
                FirstName = Firstname,
                Address = AddressP,
                Zip = Zip,
                City = City,
                Phone = Phone,
                Mail = Mail
            };

            Model.EstateDbContext.Current.Add(person);
            Model.EstateDbContext.Current.SaveChanges();

            win.Close();
        }
    }
}
