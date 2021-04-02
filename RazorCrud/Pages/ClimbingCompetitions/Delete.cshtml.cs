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
    public class DeleteModel : PageModel
    {
        private readonly RazorCrudClimbingCompetitionContext _context;

        public DeleteModel(RazorCrudClimbingCompetitionContext context)
        {
            _context = context;
        }

        [BindProperty]
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

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            ClimbingCompetition = await _context.ClimbingCompetition.FindAsync(id);

            if (ClimbingCompetition != null)
            {
                _context.ClimbingCompetition.Remove(ClimbingCompetition);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
