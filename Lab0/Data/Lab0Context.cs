using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Lab0.Models;

namespace Lab0.Data
{
    public class Lab0Context : DbContext
    {
        public Lab0Context (DbContextOptions<Lab0Context> options)
            : base(options)
        {
        }

        public DbSet<Lab0.Models.Movie> Movie { get; set; } = default!;
    }
}
