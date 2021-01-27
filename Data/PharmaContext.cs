using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Pharma.Models;

namespace Pharma.Data
{
    public class PharmaContext : DbContext
    {
        public PharmaContext (DbContextOptions<PharmaContext> options)
            : base(options)
        {
        }

        public DbSet<Pharma.Models.Medicine> Medicine { get; set; }
    }
}
