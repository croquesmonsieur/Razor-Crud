using System;
using System.ComponentModel.DataAnnotations;

namespace RazorCrud.Models
{
    public class ClimbingCompetition
    {
        public int ID { get; set; }

        [Display(Name = "Competition Name")]
        [StringLength(60, MinimumLength = 3)]
        [Required]
        public string CompetitionName { get; set; }

        [Display(Name = "Takes place on")]
        [DataType(DataType.Date)]
        public DateTime Date { get; set; }

        [Display(Name = "Is organised in")]
        [RegularExpression(@"^[A-Z]+[,a-zA-Z]*$")]
        [Required]
        [StringLength(30)]
        public string Country { get; set; }

        [Display(Name = "Current Champion Men")]
        [RegularExpression(@"^[A-Z]+[,a-zA-Z]*$")]
        [Required]
        [StringLength(30)]
        public string CurrentChampionMen { get; set; }
        
        [Display(Name = "Current Champion Women")]
        [RegularExpression(@"^[A-Z]+[,a-zA-Z]*$")]
        [Required]
        [StringLength(30)]
        public string CurrentChampionWomen { get; set; }
    }
}