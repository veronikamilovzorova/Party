using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Party.Models
{
    public class Guest
    {
        public int Id { get; set; } 
        [Required(ErrorMessage = "Sissesta nimi siia")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Sissesta eaadress siia")]
        [RegularExpression(@".+\@.+\..+", ErrorMessage = "Vale eaadress")]
        public string Email { get; set; }
        [RegularExpression(@"\+372[0-9]{8}", ErrorMessage = "Vale number")]//?
        public string Phone { get; set; }
        [Required(ErrorMessage = "Tee oma valik")]
        public bool? WillAttend { get; set; }

        public string Notes { get; set; }
        [Display(Name = "Birthday")]
        public int? BirthdayId { get; set; }

        [ForeignKey("BirthdayId")]
        public Birthday Birthday { get; set; }
        public List<Birthday> Birthdays { get; set; }
    }



}