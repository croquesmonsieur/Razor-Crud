using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using RazorCrud.Models;

    public class RazorCrudClimberContext : DbContext
    {
        public RazorCrudClimberContext (DbContextOptions<RazorCrudClimberContext> options)
            : base(options)
        {
        }

        public DbSet<RazorCrud.Models.Climber> Climber { get; set; }
    }
