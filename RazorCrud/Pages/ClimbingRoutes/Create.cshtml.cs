using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using RazorCrud.Models;

namespace RazorCrud.Pages.ClimbingRoutes
{
    public class CreateModel : PageModel
    {
        private readonly RazorCrudClimbingRouteContext _context;

        public CreateModel(RazorCrudClimbingRouteContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public ClimbingRoute ClimbingRoute { get; set; }

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.ClimbingRoute.Add(ClimbingRoute);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
