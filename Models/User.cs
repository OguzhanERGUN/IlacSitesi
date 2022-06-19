using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace IlacSitesi.Models
{
    public class User
    {
        [Key]
        public int UserID { get; set; }
        public string UserMail { get; set; }
        public string UserName { get; set; }
        public string UserSurname { get; set; }
        public string PhoneNumber { get; set; }
        public string Occupation { get; set; }
        public string UserPassword { get; set; }
        public string Institution { get; set; }
        public DateTime EntiryDate { get; set; }
    }
}