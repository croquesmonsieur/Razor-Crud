using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using RazorCrud.Models;

namespace RazorCrud.Pages.Climbers
{
    public class CreateModel : PageModel
    {
        private readonly RazorCrudClimberContext _context;

        public CreateModel(RazorCrudClimberContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Climber Climber { get; set; }

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Climber.Add(Climber);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
