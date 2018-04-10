using PrimeNumbersApi.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PrimeNumbersApi.Services
{
    public interface IPrimeNumberRepository
    {
        PrimeNumber GetPrimeNumber(int primeNumberIndex);
        bool NumberExist(int indexPrimeNumber);
        PrimeNumber GetFromDB(int indexPrimeNumber);
        void AddPrimeToDb(int indexPrimeNumber, int valuePrimeNumber);
        bool Save();
    }
}
