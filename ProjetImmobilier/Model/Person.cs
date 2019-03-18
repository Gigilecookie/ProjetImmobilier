using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tools;

namespace ProjetImmobilier.Model
{
    public class Person : BaseNotifyPropertyChanged
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public Quality Quality { get; set; }
        public String Name { get; set; }
        public String FirstName { get; set; }
        public String Address { get; set; }
        public String Zip { get; set; }
        public String City { get; set; }
        public double? Latitude { get; set; }
        public double? Longitude { get; set; }
        public String Phone { get; set; }
        public String CellPhone { get; set; }
        public String Mail { get; set; }

    }
}
