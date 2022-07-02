using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace IlacSitesi.Models
{
    public class Ilac
    {
        [Key]
        public int IlacID { get; set; }
        public int StokAdedi { get; set; }
        public int Price { get; set; }
        public string Description { get; set; }
        public string IlacAdi { get; set; }

       
    }
}