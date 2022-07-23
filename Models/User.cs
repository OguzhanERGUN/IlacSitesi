using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace IlacSitesi.Models
{
    public class User
    {
        //This Class made for Members İnformations
        [Key]
        public int UserID { get; set; }
        [Required]
        public string UserMail { get; set; }
        public string UserName { get; set; }
        public string UserSurname { get; set; }
        public string PhoneNumber { get; set; }
        public string UserPassword { get; set; }
        public string Occupation{ get; set; }
        public DateTime EntiryDate { get; set; }
        public Jobs Institution_type { get; set; }


    }
    public enum Jobs
    {
        DevletHastanesi,
        ÖzelHastane,
        Muayenehane,
        Üniversite,
        ÜniversiteHastanesi,
        EveAraştırmaHastanesi
    }
}