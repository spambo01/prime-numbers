using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PrimeNumbersApi.Models
{
    public class PrimeDto
    {
        public int indexPrime { get; set; }
        public int valuePrime { get; set; }

        public PrimeDto getPrimeValue(int givenPrimeIndex)
        {
            PrimeDto primeNumber = new PrimeDto();
            var isPrime = true;
            var prime = 2;
            var indexPrime = 1;

            while (indexPrime <= givenPrimeIndex)
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

            primeNumber.indexPrime = indexPrime-1;
            primeNumber.valuePrime = prime-1;
            //store into database the primedto
            return primeNumber;
        }
    }
}
