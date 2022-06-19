using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace IlacSitesi.Models
{
    public class Indications
    {
        [Key]
        public int indications_id { get; set; }
        public string indications_details { get; set; }
    }
}