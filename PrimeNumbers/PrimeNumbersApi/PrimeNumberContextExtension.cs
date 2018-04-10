using PrimeNumbersApi.Entities;
using PrimeNumbersApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PrimeNumbersApi
{
    public static class PrimeNumberContextExtension
    {
         
        public static void SeedDataForContext(this PrimeNumberContext context)
        {
            if (context.PrimeNumbers.Any())
            {
                return;
            }

            
                var primes = new List<PrimeNumber>()
            {
                new PrimeNumber()
                {
                    IndexPrime=1,
                    ValuePrime=2
                },
                new PrimeNumber()
                {
                    IndexPrime=2,
                    ValuePrime=3
                }
            };

            context.PrimeNumbers.AddRange(primes);
            context.SaveChanges();

        }
    }
}
