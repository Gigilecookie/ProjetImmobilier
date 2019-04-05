using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetImmobilier.ViewModel
{
    class AddPersonViewModel : Tools.BaseNotifyPropertyChanged
    {

        public AddPersonViewModel(String n, String p)
        {
            Name = n;
            FirstName = p;
        }

        public Array PersonQualityItems
        {
            get { return Enum.GetValues(typeof(Model.Quality)); }
        }

        public String Name
        {
            get { return GetField<String>(); }
            set { SetField(value); }
        }

        public String FirstName
        {
            get { return GetField<String>(); }
            set { SetField(value); }
        }

        public String Address
        {
            get { return GetField<String>(); }
            set { SetField(value); }
        }

        public String City
        {
            get { return GetField<String>(); }
            set { SetField(value); }
        }

        public String Zip
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

        public Commands.Command AddPerson
        {

            get
            {
                return new Commands.Command(addPerson);
            }

        }

        private void addPerson()
        {
            //à faire
        }

    }
}
