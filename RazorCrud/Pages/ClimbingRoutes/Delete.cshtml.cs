using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RazorCrud.Models;

namespace RazorCrud.Pages.ClimbingRoutes
{
    public class DeleteModel : PageModel
    {
        private readonly RazorCrudClimbingRouteContext _context;

        public DeleteModel(RazorCrudClimbingRouteContext context)
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

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            ClimbingRoute = await _context.ClimbingRoute.FindAsync(id);

            if (ClimbingRoute != null)
            {
                _context.ClimbingRoute.Remove(ClimbingRoute);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
