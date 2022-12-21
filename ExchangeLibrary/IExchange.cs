using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using ExchangeLibrary.Models;

namespace ExchangeLibrary
{
    public interface IExchange
    {
        public Task<LatestClass> GetLatestRates(string currency);
        public Task<PairClass> GetPairRate(string baseCurrency, string targetCurrency);
        public Task<CodesClass> GetCurrencyCodes();
        public Task<HistoricalClass> GetHistoricalRates(string currency, int year, int month, int day);
    }
}
