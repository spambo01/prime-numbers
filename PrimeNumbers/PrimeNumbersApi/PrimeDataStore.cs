using PrimeNumbersApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PrimeNumbersApi
{
    public class PrimeDataStore
    {
        public static PrimeDataStore 
            Current { get; } = 
            new PrimeDataStore();
        public List<PrimeDto> Primes { get; set; }
        public PrimeDataStore()
        {
            Primes = new List<PrimeDto>()
            {
                new PrimeDto()
                {
                    indexPrime=1,
                    valuePrime=2
                },
                new PrimeDto()
                {
                    indexPrime=2,
                    valuePrime=3
                }
            };
        }
    }

   
}
