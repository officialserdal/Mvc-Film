using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ProjeP.Models.Sınıflar
{
    public class Film
    {
        [Key]
        public int ID { get; set; }
        public string Ad { get; set; }
        public string Tur { get; set; }
        public string Aciklama { get; set; }
        public int Yil { get; set; }

    }
}