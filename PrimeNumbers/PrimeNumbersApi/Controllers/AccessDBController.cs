using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PrimeNumbersApi.Entities;

namespace PrimeNumbersApi.Controllers
{
    public class AccessDBController : Controller
    {
        private PrimeNumberContext _pnc;

        public AccessDBController(PrimeNumberContext pnc)
        {
            _pnc = pnc;
        }

        [HttpGet]
        [Route("api/checkdb")]
        public IActionResult CheckDb()
        {
            return Ok();
        }
    }
}