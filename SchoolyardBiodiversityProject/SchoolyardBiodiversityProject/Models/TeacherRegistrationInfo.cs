using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace SchoolyardBiodiversityProject.Models
{
    public class TeacherRegistrationInfo
    {
        [Display(Name ="First Name")]
        [Required(ErrorMessage = "Please enter your first name.")]
        public string firstName { get; set; }
        [Display(Name = "Last Name")]
        [Required(ErrorMessage = "Please enter your last name.")]
        public string lastName { get; set; }

        [Display(Name = "School Email")]
        [Required(ErrorMessage = "Please enter your school email address.")]
        [EmailAddress]
        public string schoolEmail { get; set; }

        [Display(Name = "School Name")]
        [Required(ErrorMessage = "Please enter the name of your school.")]
        public string schoolName { get; set; }
        [Display(Name = "School Zip Code")]
        [Required(ErrorMessage = "Please enter your school's zip code")]
        public int schoolZipCode { get; set; }

        //Var for if this teacher's sightings are considered as "verified sightings"
        [Display(Name = "Verified")]
        public bool isVerified {get;set;}
    }
}
