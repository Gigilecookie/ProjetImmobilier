using System;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjetImmobilier.Tools;

namespace ProjetImmobilier.Model
{
    public class Estate : BaseNotifyPropertyChanged
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public EstateType Type { get; set; }
        public String Address { get; set; }
        public String Zip { get; set; }
        public String City { get; set; }
        public double? Latitude { get; set; }
        public double? Longitude { get; set; }
        public int Surface { get; set; }
        public int FloorCount { get; set; }
        public int FloorNumber { get; set; }
        public int RoomsCount { get; set; }
        public int EnergyEfficiency { get; set; }
        public DateTime? BuildDate { get; set; }
        public int? MainPhotoId { get; set; }
        public int OwnerId { get; set; }

        [ForeignKey(nameof(MainPhotoId))]
        public Photo MainPhoto { get; set; }

        [ForeignKey(nameof(OwnerId))]
        public Person Owner { get; set; }

        [InverseProperty(nameof(Photo.Estate))]
        public ObservableCollection<Photo> Photos { get; set; }

        [InverseProperty(nameof(Contract.Estate))]
        public ObservableCollection<Contract> Contracts { get; set; }

        [NotMapped]
        public string CompleteAddress
        {
            get { return Address + ", " + Zip + " " + City; }
        }

        [NotMapped]
        public string SurfaceUnit
        {
            get { return Surface + "m²"; }
        }

    }
}
