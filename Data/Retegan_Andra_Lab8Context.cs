using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Retegan_Andra_Lab8.Models;

namespace Retegan_Andra_Lab8.Data
{
    public class Retegan_Andra_Lab8Context : DbContext
    {
        public Retegan_Andra_Lab8Context (DbContextOptions<Retegan_Andra_Lab8Context> options)
            : base(options)
        {
        }

        public DbSet<Retegan_Andra_Lab8.Models.Book> Book { get; set; }

        public DbSet<Retegan_Andra_Lab8.Models.Publisher> Publisher { get; set; }

        public DbSet<Retegan_Andra_Lab8.Models.Category> Category { get; set; }
    }
}
