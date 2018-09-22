using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace cours3_b_copy.Models
{
    public class Student
    {

        public enum Gendre { Male, Female }
        public int StudentId { get; set; }

        [Required(ErrorMessage ="L nom est obligateur")]
        public string StudantName { get; set; }
        [Range (5,50)]
        public int Age { get; set; }
        public bool isNewlyEnrolled { get; set; }
        public string Description { get; set; }
        public string Password { get; set; }
        public Gendre StudentGender { get; set; }
        public DateTime DoB { get; set; }
    }
}