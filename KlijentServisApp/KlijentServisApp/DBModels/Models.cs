using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;

namespace ADO.NETEntityCodeFirst.DBModels
{
    public class Models : DbContext
    {

        public Models() : base("name=Models")
        {

        }

        public DbSet<Klijent> klijenti { get; set; }
        public DbSet<Servis> servisi { get; set; }
    }
  
}
