using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADO.NETEntityCodeFirst.DBModels
{
    [Table("Servisi", Schema = "dbo")]
    public class Servis
    {
        [Key]
        [Required]
        [DisplayName("Id")]
        public int Id { get; set; }

        [Required]
        [ForeignKey("Klijent")]
        public int KlijentId { get; set; }
        
        [Required]
        [DisplayName("Datum servisa")]
        public DateTime DatumServisa { get; set; }

        [Required]
        [MaxLength(400)]
        [DisplayName("Opis usluge")]
        public string OpisUsluge{get; set;}
        
        public Klijent Klijent { get; set; }
    }
}
