using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using RazorCrud.Models;

namespace RazorCrud.Pages.ClimbingRoutes
{
    public class EditModel : PageModel
    {
        private readonly RazorCrudClimbingRouteContext _context;

        public EditModel(RazorCrudClimbingRouteContext context)
        {
            _context = context;
        }

        [BindProperty]
        public ClimbingRoute ClimbingRoute { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            ClimbingRoute = await _context.ClimbingRoute.FirstOrDefaultAsync(m => m.ID == id);

            if (ClimbingRoute == null)
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

            _context.Attach(ClimbingRoute).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ClimbingRouteExists(ClimbingRoute.ID))
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

        private bool ClimbingRouteExists(int id)
        {
            return _context.ClimbingRoute.Any(e => e.ID == id);
        }
    }
}
