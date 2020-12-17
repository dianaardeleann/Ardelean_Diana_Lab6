using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Ardelean_Diana_Lab6.Models;

namespace Ardelean_Diana_Lab6.Data
{
    public class Ardelean_Diana_Lab6Context : DbContext
    {
        public Ardelean_Diana_Lab6Context (DbContextOptions<Ardelean_Diana_Lab6Context> options)
            : base(options)
        {
        }

        public DbSet<Ardelean_Diana_Lab6.Models.Book> Book { get; set; }
    }
}
