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
    [Table("Klijenti", Schema = "dbo")]
    public class Klijent
    {
        public Klijent()
        {
            Servisi = new List<Servis>();
        }
        [Key] [Required]
        public int Id { get; set; }

        [Required]
        [MaxLength(40)]
        [DisplayName("Naziv")]
        public string NazivKlijenta{ get; set; }
        [Required]
        [MaxLength(20)]
        [DisplayName("Registracija")]
        public string RegistarskiBroj { get; set; }
        [Required]
        [MaxLength(40)]
        [DisplayName("Kontakt")]
        public string Kontakt { get; set; }

        [Required]
        [MaxLength(200)]
        [DisplayName("komentar")]
        public string DodatniKomentar { get; set; }
        public virtual ICollection<Servis> Servisi{ get; set; }
    }
}
