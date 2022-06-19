using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace IlacSitesi.Models
{
    public class MonoklonalAntikors
    {
        //İlişkilerin oluşturulması gerekiyor sadece sınıfları oluşturdum
        [Key]
        public int ma_id { get; set; }
        public string icd10_code { get; set; }
        public string dose { get; set; }
        public string defined_daily_dose { get; set; }
        public int indications_id { get; set; }

    }
}