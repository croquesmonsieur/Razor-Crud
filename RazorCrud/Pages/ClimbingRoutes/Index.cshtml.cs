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
    public class IndexModel : PageModel
    {
        private readonly RazorCrudClimbingRouteContext _context;

        public IndexModel(RazorCrudClimbingRouteContext context)
        {
            _context = context;
        }

        public IList<ClimbingRoute> ClimbingRoute { get;set; }

        public async Task OnGetAsync()
        {
            ClimbingRoute = await _context.ClimbingRoute.ToListAsync();
        }
    }
}
