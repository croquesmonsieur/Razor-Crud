using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using RazorCrud.Models;

    public class RazorCrudClimbingRouteContext : DbContext
    {
        public RazorCrudClimbingRouteContext (DbContextOptions<RazorCrudClimbingRouteContext> options)
            : base(options)
        {
        }

        public DbSet<RazorCrud.Models.ClimbingRoute> ClimbingRoute { get; set; }
    }
