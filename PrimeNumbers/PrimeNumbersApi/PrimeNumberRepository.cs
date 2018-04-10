using PrimeNumbersApi.Entities;
using PrimeNumbersApi.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace PrimeNumbersApi
{
    public class PrimeNumberRepository : IPrimeNumberRepository
    {
        private PrimeNumberContext _context;

        public PrimeNumberRepository(PrimeNumberContext context)
        {
            _context = context;
        }

        public bool NumberExist(int indexPrimeNumber)
        {
            return _context.PrimeNumbers.Any(pn => pn.IndexPrime == indexPrimeNumber);
        }

        public PrimeNumber GetFromDB(int indexPrimeNumber)
        {
            return _context.PrimeNumbers.Where(pn => pn.IndexPrime == indexPrimeNumber).FirstOrDefault();           
        }

        public PrimeNumber GetPrimeNumber(int indexPrimeNumber)
        {
            var isPrime = true;
            var prime = 2;
            var indexPrime = 1;

            while (indexPrime <= indexPrimeNumber)
            {
                isPrime = true;
                for (var num = 2; num < prime; num++)
                {
                    if (prime % num == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }
                if (isPrime)
                {
                    indexPrime++;
                }
                prime++;
            }

            var result = new PrimeNumber();
            result.IndexPrime = indexPrime - 1;
            result.ValuePrime = prime - 1;
            //save to DB

            return result;
        }

    }
}
