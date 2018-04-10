using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PrimeNumbersApi.Models;
using PrimeNumbersApi.Services;
using PrimeNumbersApi.Entities;

namespace PrimeNumbersApi.Controllers
{
    [Route("api/prime")]
    public class PrimeNumberController : Controller
    {
        private IPrimeNumberRepository _primeNumberRepository;
        public PrimeNumberController(IPrimeNumberRepository primeNumberRepository)
        {
            _primeNumberRepository = primeNumberRepository;
        }

        [HttpGet("{id}")]
        public IActionResult GetPrimeNumber(int id)
        {
            var result = new PrimeDto();
            if (_primeNumberRepository.NumberExist(id))
            {
                result.indexPrime = (_primeNumberRepository.GetFromDB(id)).IndexPrime;
                result.valuePrime = (_primeNumberRepository.GetFromDB(id)).ValuePrime;
            }
            else
            {
                result.indexPrime = (_primeNumberRepository.GetPrimeNumber(id)).IndexPrime;
                result.valuePrime = (_primeNumberRepository.GetPrimeNumber(id)).ValuePrime;
                _primeNumberRepository.AddPrimeToDb(result.indexPrime, result.valuePrime);
                if (!_primeNumberRepository.Save())
                {
                    return StatusCode(500, "Problem while Saving");
                }
            }
            return Ok(result);
        }

    }
}