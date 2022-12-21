using ExchangeLibrary;
using ExchangeLibrary.Models;
using Newtonsoft.Json;
using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            var apiCalls = new ApiCalls();
            var latest = apiCalls.GetLatestRates("USD");
            var pair = apiCalls.GetPairRate("EUR", "USD");
            var codes = apiCalls.GetCurrencyCodes();
            var service = new ExchangeService(apiCalls);

            var rates = service.GetLatestRatesInDict("USD");

            foreach (var rate in rates)
            {
                Console.WriteLine($"{rate.Key} {rate.Value}");
            }

            // var keys =service.GetCodesInList(service.ReturnAllCodes().supported_codes);
            //
            // foreach (var key in keys)
            // {
            //     Console.WriteLine($"{key.Key}: {key.Value}");   
            // }

        }
    }
}
