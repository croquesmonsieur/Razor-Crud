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
    public class IndexModel : PageModel
    {
        private readonly RazorCrudClimberContext _context;

        public IndexModel(RazorCrudClimberContext context)
        {
            _context = context;
        }

        public IList<Climber> Climber { get;set; }

        public async Task OnGetAsync()
        {
            Climber = await _context.Climber.ToListAsync();
        }
    }
}
