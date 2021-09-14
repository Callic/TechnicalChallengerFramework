using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TechnicalChallengeLibrary.Interfaces;
using TechnicalChallengeLibrary.Models;

namespace TechnicalChallengeAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TechnicalChallengerController : ControllerBase
    {
        private readonly IMain _main;
        public TechnicalChallengerController(IMain main)
        {
            _main = main;
        }
        [HttpGet("DividingAndPrimeNumbers/{number:int}")]
        public DividingAndPrimeNumbers GetDividingAndPrimeNumbers(int number)
        {
            var entity = _main.DiscoverDividingAndPrimeNumbers(number);
            return entity.Entity;
        }
    }
}
