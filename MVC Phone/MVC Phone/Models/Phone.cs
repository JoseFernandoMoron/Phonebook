using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVC_Phone.Models
{
    public enum TypeContact
    {
        PhoneNumber,
        Email,
        Facebook,
        Twitter,
        LinkedIN
    }
    public class Phone
    {
        [Key]
        public int PhoneID { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public TypeContact Ty { get; set; }
        [Required]
        public string Contact { get; set; }
    }
}