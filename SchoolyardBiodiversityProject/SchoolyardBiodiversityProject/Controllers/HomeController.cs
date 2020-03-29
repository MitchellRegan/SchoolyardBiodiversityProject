using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SchoolyardBiodiversityProject.Models;

namespace SchoolyardBiodiversityProject.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }


        //Method used in TeacherRegistration.cshtml to fill out the form
        [HttpGet]
        public ActionResult TeacherRegistration()
        {
            TeacherRegistrationInfo newTeach = new TeacherRegistrationInfo();
            return View(newTeach);
        }

        //Method used in TeacherRegistration.cshtml to make sure the form is filled out correctly
        [HttpPost]
        public ActionResult TeacherRegistration(TeacherRegistrationInfo teacher_)
        {
            //If the form was filled out correctly we send the info out and return to the home page
            if(ModelState.IsValid)
            {
                TempData["message"] = string.Format("Your information has been submitted for approval. Thank You!");
                return RedirectToAction("Index");
            }
            //If the form wasn't filled out correctly we stay on the same page
            else
            {
                return View(teacher_);
            }
        }


        //Method used in DataSubmission.cshtml to fill out the form
        [HttpGet]
        public ActionResult DataSubmission()
        {
            SightingInfo newSighting = new SightingInfo();
            return View(newSighting);
        }

        //Method used in DataSubmission.cshtml to make sure the form is filled out correctly
        [HttpPost]
        public ActionResult DataSubmission(SightingInfo sighting_)
        {
            if (ModelState.IsValid)
            {
                TempData["message"] = string.Format("Your information has been submitted for approval. Thank You!");
                return RedirectToAction("Index");
            }
            //If the form wasn't filled out correctly we stay on the same page
            else
            {
                return View(sighting_);
            }
        }



        public IActionResult ViewSpreadsheetData()
        {
            return View();
        }




        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
