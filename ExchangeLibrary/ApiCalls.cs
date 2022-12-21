using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using ExchangeLibrary.Models;
using Newtonsoft.Json;

namespace ExchangeLibrary
{
    public class ApiCalls : IExchange
    {
        static readonly HttpClient Client = new HttpClient();
        readonly string UrlString = "https://v6.exchangerate-api.com/v6/16a71226e4f9a3fed05e32e1";
        public async Task<LatestClass> GetLatestRates(string currency)
        {
            var latestUrl = $"{UrlString}/latest/{currency}";
            var content = await Client.GetStringAsync(latestUrl);
            return JsonConvert.DeserializeObject<LatestClass>(content);
        }

        public async Task<PairClass> GetPairRate(string baseCurrency, string targetCurrency)
        {
            var pairUrl = $"{UrlString}/pair/{baseCurrency}/{targetCurrency}";
            var content = await Client.GetStringAsync(pairUrl);
            return JsonConvert.DeserializeObject<PairClass>(content);
        }

        public async Task<CodesClass> GetCurrencyCodes()
        {
            var codesUrl = $"{UrlString}/codes";
            var content = await Client.GetStringAsync(codesUrl);
            return JsonConvert.DeserializeObject<CodesClass>(content);
        }

        public async Task<HistoricalClass> GetHistoricalRates(string currency, int year, int month, int day)
        {
            var historicalUrl = $"{UrlString}/history/{currency}/{year}/{month}/{day}";
            var content = await Client.GetStringAsync(historicalUrl);
            return JsonConvert.DeserializeObject<HistoricalClass>(content);
        }
    }
}
