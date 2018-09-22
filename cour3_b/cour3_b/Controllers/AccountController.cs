using cour3_b.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace cour3_b.Controllers
{
    public class AccountController : Controller
    {

        
        // GET: Account

        [HttpPost]
        public ActionResult Register(Student std)
        {

            Student myStudent = new Student();


            myStudent.StudantName = std.StudantName;
            myStudent.Age = std.Age;
            myStudent.Description = std.Description;
            myStudent.StudentGender = std.StudentGender;
            myStudent.isNewlyEnrolled = std.isNewlyEnrolled;

            return View("Confirmationsave", myStudent);

        }
    }
}