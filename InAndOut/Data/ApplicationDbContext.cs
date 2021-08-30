using InAndOut.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InAndOut.Data
{
    public class ApplicationDbContext: DbContext
    {
        public ApplicationDbContext(DbContextOptions <ApplicationDbContext> options): base (options)
        {

        }
        //this is the table of items 
        public DbSet<Itemm> Itemms { get; set; }
        public DbSet<Expence> Expences { get; set; }
    }
}
