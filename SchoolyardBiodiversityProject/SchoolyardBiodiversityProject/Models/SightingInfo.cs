using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace SchoolyardBiodiversityProject.Models
{
    public class SightingInfo
    {
        [Display(Name = "Type of Plant or Animal")]
        [Required(ErrorMessage = "*Required")]
        public PlantAnimalTypeEnum type;

        [Display(Name = "Species")]
        [Required(ErrorMessage = "*Required")]
        public string species;

        [Display(Name = "Individual or Group")]
        [Required(ErrorMessage = "*Required")]
        public GroupEnum group;
        [Display(Name = "Gender")]
        [Required(ErrorMessage = "*Required")]
        public GenderEnum gender;
        [Display(Name = "Age")]
        [Required(ErrorMessage = "*Required")]
        public AgeEnum age;
        [Display(Name = "Was the Sighting Verified?")]
        public bool verifiedSighting;

        [Display(Name = "GPS Location")]
        [Required(ErrorMessage = "*Required")]
        public string gpsLocation;
        [Display(Name = "Date and Time")]
        [Required(ErrorMessage = "*Required")]
        public DateTime dateTime;

        [Display(Name = "Temperature in Fahrenheit")]
        [Required(ErrorMessage = "*Required")]
        public int tempF;
        [Display(Name = "What was the Weather Like?")]
        [Required(ErrorMessage = "*Required")]
        public WeatherEnum weather;
        [Display(Name = "Amount of Precipitation")]
        [Required(ErrorMessage = "*Required")]
        public bool isPrecipitating;

        [Display(Name = "Was a Photo Taken?")]
        public bool photoTaken;
        [Display(Name = "Notes")]
        public string notes;
    }
}
