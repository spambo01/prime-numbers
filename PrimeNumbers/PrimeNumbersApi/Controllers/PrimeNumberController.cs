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
            var result = new PrimeNumber();
            if (_primeNumberRepository.NumberExist(id))
            {
                 result = _primeNumberRepository.GetFromDB(id);
            }
            else
            {
                result = _primeNumberRepository.GetPrimeNumber(id);
            }
            return Ok(result);
        }

    }
}