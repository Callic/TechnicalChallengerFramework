using System;
using System.Collections.Generic;
using TechnicalChallengeLibrary.Helpers;
using TechnicalChallengeLibrary.Interfaces;
using TechnicalChallengeLibrary.Models;

namespace TechnicalChallengeLibrary
{
    public class Main : IMain
    {
        public Response<DividingAndPrimeNumbers> DiscoverDividingAndPrimeNumbers(int number)
        {
            try
            {
                if (number < 0)
                    return new Response<DividingAndPrimeNumbers>(false, "Não são permitidos números negativos!", null);
                var dividingNumbers = DividingNumbers(number);
                var dividingAndPrimeNumbers = new DividingAndPrimeNumbers
                {
                    DividingNumbers = dividingNumbers,
                    PrimeNumbers = DiscoverPrimeNumbers(new List<int>(dividingNumbers), number)
                };
                return new Response<DividingAndPrimeNumbers>(true, "", dividingAndPrimeNumbers);

            }
            catch (Exception e)
            {
                return new Response<DividingAndPrimeNumbers>(false, e.ToString(), null, e);
            }
        }
        private List<int> DividingNumbers(int number)
        {
            List<int> dividingNumbers = new List<int>();
            for (int i = 1; i <= number; i++)
            {
                if (number % i == 0)
                    dividingNumbers.Add(i);
            }
            return dividingNumbers;
        }
        private List<int> DiscoverPrimeNumbers(List<int> lst, int number)
        {
            List<int> list = new List<int>();
            bool isPrime = true;
            var possibleFactors = Math.Sqrt(number);
            lst.RemoveAll(a => a > possibleFactors);
            lst.ForEach(x =>
            {
                var aux = Math.Sqrt(x);
                for (var factor = 2; factor <= aux; factor++)
                {
                    isPrime = true;
                    if (x % factor == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }
                if (isPrime)
                {
                    list.Add(x);
                }
            });
            return list;
        }
    }
}
