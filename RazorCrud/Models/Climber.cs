using System;
using System.ComponentModel.DataAnnotations;

namespace RazorCrud.Models
{
    public class Climber
    {
        public int ID { get; set; }

        [Display(Name = "Climber's Name")]
        [StringLength(60, MinimumLength = 3)]
        [Required]
        public string ClimberName { get; set; }

        [Display(Name = "Date of birth")]
        [DataType(DataType.Date)]
        public DateTime Date { get; set; }
        
        [Display(Name = "Nationality")]
        [RegularExpression(@"^[A-Z]+[,a-zA-Z]*$")]
        [Required]
        [StringLength(30)]
        public string Country { get; set; }

        [Display(Name = "Favorite Climbing Style")]
        [RegularExpression(@"^[A-Z]+[,a-zA-Z]*$")]
        [Required]
        [StringLength(30)]
        public string Style { get; set; }

        [Display(Name = "Favorite Climbing Spot")]
        [RegularExpression(@"^[A-Z]+[,a-zA-Z]*$")]
        [Required]
        [StringLength(30)]
        public string FavoritePlace { get; set; }

        [Display(Name = "Latest Climbing Achievement")]
        [RegularExpression(@"^[A-Z]+[,a-zA-Z]*$")]
        [Required]
        [StringLength(30)]
        public string Achievement { get; set; }
    }
}