using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace cour3_b.Models
{
    public class Student
    {

        public enum Gendre { Male,Female}
        public int StudentId { get; set; }

        [DisplayName("Le Nom ")]
        public string StudantName { get; set; }
        public int Age { get; set; }
        public bool isNewlyEnrolled { get; set; }
        public string Description { get; set; }
        public string  Password { get; set; }
        public Gendre StudentGender { get; set; }
        public DateTime DoB { get; set; }
    }

  
}