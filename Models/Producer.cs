using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace IlacSitesi.Models
{
    public class Producer
    {
        //Defining SQL lists
        [Key]
        public int producer_id { get; set; }
        public string producer_name { get; set; }

        //Defining relationships with MonoklonalAntikors
        public ICollection<MonoklonalAntikors> monoklonalAntikors { get; set; } 
    }
}