using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace PrimeNumbersApi.Controllers
{
    public class PrimeNumberController : Controller
    {
        [HttpGet("api/prime")]
        public JsonResult GetPrimeNumber()
        {
            return new JsonResult(new List<object>()
            {
                new {id=0, PrimeNumbber=1}
            });
        }
        //public IActionResult Index()
        //{
        //    return View();
        //}
    }
}