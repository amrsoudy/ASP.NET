using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ExamenIntraAmrSeoudy.Models
{
    public class Information
    {
        [Required(ErrorMessage ="Le nom est Obligatoire")]
        public string nom { get; set; }
        [Required(ErrorMessage = "Le prenom est Obligatoire")]
        public string prenom { get; set; }
       
        public string date { get; set; }
        [Required(ErrorMessage ="Le kilo metrage dois Ecrire ")]
        [Range(5,200)]
        public int kilo { get; set; }
        [Required]

        public string ville { get; set; }
        [Range(0,Int32.MaxValue)]
        public double fraisResturant { get; set; }
        [Required(ErrorMessage ="Tu dois Sasier le postalCode ")]
        [MinLength(6),MaxLength(6)]
        public string postalCode { get; set; }
        [EmailAddress(ErrorMessage ="LeCourrial dois Etre valide SVP")]
        public string Email { get; set; }
    }
}