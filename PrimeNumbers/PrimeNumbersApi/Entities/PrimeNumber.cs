using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PrimeNumbersApi.Entities
{
    public class PrimeNumber
    {
        [Key]
        public int indexPrime { get; set; }
        [Required]
        public int valuePrime { get; set; }
    }
}
