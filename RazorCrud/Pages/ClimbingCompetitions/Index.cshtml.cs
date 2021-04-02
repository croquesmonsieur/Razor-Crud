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
    public class IndexModel : PageModel
    {
        private readonly RazorCrudClimbingCompetitionContext _context;

        public IndexModel(RazorCrudClimbingCompetitionContext context)
        {
            _context = context;
        }

        public IList<ClimbingCompetition> ClimbingCompetition { get;set; }

        public async Task OnGetAsync()
        {
            ClimbingCompetition = await _context.ClimbingCompetition.ToListAsync();
        }
    }
}
