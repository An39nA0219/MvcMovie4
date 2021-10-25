using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MvcMovie4.Models;

namespace MvcMovie4.Data
{
    public class MvcMovie4Context : DbContext
    {
        public MvcMovie4Context (DbContextOptions<MvcMovie4Context> options)
            : base(options)
        {
        }

        public DbSet<MvcMovie4.Models.Movie> Movie { get; set; }
    }
}
