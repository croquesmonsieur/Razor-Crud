using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using RazorCrud.Models;

    public class RazorCrudClimbingCompetitionContext : DbContext
    {
        public RazorCrudClimbingCompetitionContext (DbContextOptions<RazorCrudClimbingCompetitionContext> options)
            : base(options)
        {
        }

        public DbSet<RazorCrud.Models.ClimbingCompetition> ClimbingCompetition { get; set; }
    }
