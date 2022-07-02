using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace IlacSitesi.Models
{
    public class MonoklonalAntikors
    {
        //Defining SQL lists
        [Key]
        public int ma_id { get; set; }
        public string icd10_code { get; set; }
        public string dose { get; set; }
        public string defined_daily_dose { get; set; }

        //Defining relationships with producer
        public int producer_id { get; set; }
        public virtual Producer Producer { get; set; }

        //Defining relationships with İndications
        public int indications_id { get; set; }
        public virtual Indications Indications { get; set; }

    }
}