using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PrimeNumbersApi.Models;

namespace PrimeNumbersApi.Controllers
{
    [Route("api/prime")]
    public class PrimeNumberController : Controller
    {
        [HttpGet("")]
        public JsonResult GetPrimeNumbers()
        {
            return new JsonResult
                (PrimeDataStore.Current.Primes);
        }

        [HttpGet("{id}")]
        public IActionResult GetPrimeNumber(int id)
        {
            var primeObj=PrimeDataStore.
                Current.
                Primes.
                FirstOrDefault(prime => prime.indexPrime==id);
            if (primeObj == null)
            {
                PrimeDto primeTemp = new Models.PrimeDto();
                primeObj =primeTemp.getPrimeValue(id);
            }
            return Ok(primeObj);
        }
        //public IActionResult Index()
        //{
        //    return View();
        //}
    }
}