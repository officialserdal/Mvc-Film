using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using ProjeP.Models.Sınıflar;

namespace ProjeP.Models
{
    public class context : DbContext
    {
        public DbSet<Film> Filmler { get; set; } 

        
    }
}
