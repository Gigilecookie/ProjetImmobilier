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
    public class Photo : BaseNotifyPropertyChanged
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public String Content { get; set; }
        public int EstateId { get; set; }
        public String Title { get; set; }

        [ForeignKey(nameof(EstateId))]
        public Estate Estate { get; set; }
    }
}
