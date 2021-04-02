using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RazorCrud.Models;

namespace RazorCrud.Pages.Climbers
{
    public class DeleteModel : PageModel
    {
        private readonly RazorCrudClimberContext _context;

        public DeleteModel(RazorCrudClimberContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Climber Climber { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Climber = await _context.Climber.FirstOrDefaultAsync(m => m.ID == id);

            if (Climber == null)
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

            Climber = await _context.Climber.FindAsync(id);

            if (Climber != null)
            {
                _context.Climber.Remove(Climber);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
