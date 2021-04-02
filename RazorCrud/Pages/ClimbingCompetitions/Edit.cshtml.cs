using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using RazorCrud.Models;

namespace RazorCrud.Pages.ClimbingCompetitions
{
    public class EditModel : PageModel
    {
        private readonly RazorCrudClimbingCompetitionContext _context;

        public EditModel(RazorCrudClimbingCompetitionContext context)
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

        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(ClimbingCompetition).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ClimbingCompetitionExists(ClimbingCompetition.ID))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool ClimbingCompetitionExists(int id)
        {
            return _context.ClimbingCompetition.Any(e => e.ID == id);
        }
    }
}
