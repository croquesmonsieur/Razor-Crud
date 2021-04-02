using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RazorCrud.Models;

namespace RazorCrud.Pages.ClimbingCompetitions
{
    public class DetailsModel : PageModel
    {
        private readonly RazorCrudClimbingCompetitionContext _context;

        public DetailsModel(RazorCrudClimbingCompetitionContext context)
        {
            _context = context;
        }

        public ClimbingCompetition ClimbingCompetition { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            ClimbingCompetition = await _context.ClimbingCompetition.FirstOrDefaultAsync(m => m.ID == id);

            if (ClimbingCompetition == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
