using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PrimeNumbersApi.Entities
{
    public class PrimeNumberContext : DbContext
    {
        public  PrimeNumberContext(DbContextOptions<PrimeNumberContext> options) : base(options)
        {
            Database.EnsureCreated();
        }
        public DbSet<PrimeNumber> PrimeNumbers { get; set; }

        
    }
}
