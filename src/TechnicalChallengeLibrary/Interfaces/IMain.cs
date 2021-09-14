using System;
using System.Collections.Generic;
using System.Text;
using TechnicalChallengeLibrary.Helpers;
using TechnicalChallengeLibrary.Models;

namespace TechnicalChallengeLibrary.Interfaces
{
    public interface IMain
    {
        Response<DividingAndPrimeNumbers> DiscoverDividingAndPrimeNumbers(int number);
    }
}
