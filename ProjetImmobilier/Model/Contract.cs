using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjetImmobilier.Tools;

namespace ProjetImmobilier.Model
{
    public class Contract : BaseNotifyPropertyChanged
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public int EstateId { get; set; }
        public ContractType Type { get; set; }
        public DateTime PubDate { get; set; }
        public DateTime SignDate { get; set; }
        public DateTime CloseDate { get; set; }
        public String Description { get; set; }
        public String Title { get; set; }
        public decimal Price { get; set; }

        [ForeignKey(nameof(EstateId))]
        public Estate Estate { get; set; }

    }
}
