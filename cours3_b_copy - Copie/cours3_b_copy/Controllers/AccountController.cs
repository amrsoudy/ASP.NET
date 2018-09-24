using cours3_b_copy.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace cours3_b_copy.Controllers
{
    public class AccountController : Controller
    {
        // GET: Account
        [HttpGet]
        public ActionResult Register()
        {



            return View();
        }
        [HttpPost]
        public ActionResult save(Student std)
        {

            Student myStudent = new Student();


            myStudent.StudantName = std.StudantName;
            myStudent.Age = std.Age;
            myStudent.Description = std.Description;
            myStudent.StudentGender = std.StudentGender;
            myStudent.isNewlyEnrolled = std.isNewlyEnrolled;

            return View("Confirmationsave", myStudent);
        }
        [HttpPost]
        public ActionResult Edit()
        {

            Student st = new Student();
            st.StudentId = 5;
            st.Age = 25;
            st.StudantName = "Paul";

            return View(st);

        }
        public ActionResult Edit(Student st)
        {

            if (ModelState.IsValid)
            {

                return RedirectToAction("Index");

            }

            return View(st);

        }
    }
}