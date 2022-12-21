using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using ExchangeLibrary.Models;

namespace ExchangeLibrary
{
    public class ExchangeService
    {
        private readonly IExchange _provider;

        public ExchangeService(IExchange provider)
        {
            _provider = provider;
        }

        public LatestClass ReturnLatestRates(string baseCurrency) //+
        {
            var latest = _provider.GetLatestRates(baseCurrency).Result;

            return latest;
        }

        public PairClass ReturnPairRates(string baseCurrency, string targetCurrency) //+
        {
            var pairs = _provider.GetPairRate(baseCurrency, targetCurrency).Result;
            return pairs;
        }

        public HistoricalClass ReturnHistoricalRates(string currency, int year, int month, int day) //+
        {
            var historical = _provider.GetHistoricalRates(currency, year, month, day).Result;
            return historical;
        }

        public CodesClass ReturnAllCodes() //+
        {
            var codes = _provider.GetCurrencyCodes().Result;
            return codes;
        }


        public Dictionary<string, string> GetCodesInDict() //+
        {
            var codesDict = new Dictionary<string, string>();
            var arr = ReturnAllCodes().supported_codes;

            for (int i = 0; i < arr.GetLength(0); i++)
            {
                codesDict.Add(arr[i, 0], arr[i, 1]);
            }

            return codesDict;
        }

        public Dictionary<string, double> GetLatestRatesInDict(ConversionRate latestRates) //+
        {
            var rates = new Dictionary<string, double>();
            var props = latestRates.GetType().GetProperties();

            foreach (var prop in props)
            {
               rates.Add(prop.Name, (double)prop.GetValue(latestRates));
            }

            return rates;
        }

        public Dictionary<string, double> GetHistoricalRatesInDict(HistoricalRate historicalRates) //+
        {
            var hRates = new Dictionary<string, double>();
            //var latsestRates = ReturnLatestRates(key).conversion_rates;
            var props = historicalRates.GetType().GetProperties();

            foreach (var prop in props)
            {
                hRates.Add(prop.Name, (double)prop.GetValue(historicalRates));
            }

            return hRates;
        }

        public double ConvertAmount(double baseAmount, double rate) //+
        {
            return baseAmount * rate;
        }

    }
}
