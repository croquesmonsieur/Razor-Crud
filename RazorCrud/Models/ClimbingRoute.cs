using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace RazorCrud.Models
{
    public class ClimbingRoute
    {
        public int ID { get; set; }

        [StringLength(60, MinimumLength = 3)]
        [Required]
        public string Name { get; set; }

        [Display(Name = "Founded Date")]
        [DataType(DataType.Date)]
        public DateTime OriginatedDate { get; set; }

        [RegularExpression(@"^[A-Z]+[,a-zA-Z]*$")]
        [Required]
        [StringLength(30)]
        public string Country { get; set; }

        [RegularExpression(@"^[A-Z]+[,a-zA-Z]*$")]
        [Required]
        [StringLength(30)]
        public string Originator { get; set; }

        [RegularExpression(@"^[0-9A-Z]+[a-zA-Z0-9""'\s-]*$")]
        [StringLength(5)]
        public string Rating { get; set; }
    }
}