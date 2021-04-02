using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using RazorCrud.Models;

namespace RazorCrud.Pages.ClimbingCompetitions
{
    public class CreateModel : PageModel
    {
        private readonly RazorCrudClimbingCompetitionContext _context;

        public CreateModel(RazorCrudClimbingCompetitionContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public ClimbingCompetition ClimbingCompetition { get; set; }

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.ClimbingCompetition.Add(ClimbingCompetition);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
