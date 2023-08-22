using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ProjeP.Models.Sınıflar
{
    public class Önerilen_Filmler
    {

        [Key]
        public int İD { get; set; }
        public string FilmAdi { get; set; }
        public string Tür { get; set; }
        public string YayinYili { get; set; }
        public string Açiklama { get; set; }
        public string FotoUrl { get; set; }
    }
}