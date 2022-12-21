using ExchangeLibrary;
using ExchangeLibrary.Models;
using Moq;
using NUnit.Framework;
using System.Threading.Tasks;

namespace TestProject1
{
    public class Tests
    {
        private ExchangeService _service;

        // [SetUp]
        // public void Setup()
        // {
        // }

        [Test]
        public void TestPairReturn()
        {
            var pair = new PairClass()
            {
                result = "success",
                documentation = "https://www.exchangerate-api.com/docs",
                terms_of_use = "https://www.exchangerate-api.com/terms",
                time_last_update_unix = "1585267200",
                time_last_update_utc = "Fri, 27 Mar 2020 00:00:00 +0000",
                time_next_update_unix = "1585270800",
                time_next_update_utc = "Sat, 28 Mar 2020 01:00:00 +0000",
                base_code = "EUR",
                target_code = "GBP",
                conversion_rate = 0.8412
            };

            var mockExchangeService = new Mock<IExchange>();

            mockExchangeService.Setup(p => p.GetPairRate("EUR", "GBP")).ReturnsAsync(pair);

            _service = new ExchangeService(mockExchangeService.Object);

            var result = _service.ReturnPairRates("EUR", "GBP");

            Assert.AreEqual(0.8412, result.conversion_rate);
        }
        [Test]
        public void TestLatestReturn()
        {
            var latest_rates = new ConversionRate()
            {
                USD = 1,
                AUD = 1.4817,
                BGN = 1.7741,
                CAD = 1.3168,
                CHF = 0.9774,
                CNY = 6.9454,
                EGP = 15.7361,
                EUR = 0.9013,
                GBP = 0.7679
            };
            var latest = new LatestClass()
            {
                result = "success",
                documentation = "https://www.exchangerate-api.com/docs",
                terms_of_use = "https://www.exchangerate-api.com/terms",
                time_last_update_unix = "1585267200",
                time_last_update_utc = "Fri, 27 Mar 2020 00:00:00 +0000",
                time_next_update_unix = "1585270800",
                time_next_update_utc = "Sat, 28 Mar 2020 01:00:00 +0000",
                base_code = "USD",
                conversion_rates = latest_rates
            };

            var mockExchangeService = new Mock<IExchange>();

            mockExchangeService.Setup(p => p.GetLatestRates("USD")).ReturnsAsync(latest);

            _service = new ExchangeService(mockExchangeService.Object);

            var result = _service.ReturnLatestRates("USD");

            Assert.AreEqual("success", result.result);
            Assert.AreEqual("USD", result.base_code);
            Assert.AreEqual(latest_rates, result.conversion_rates);
        }

        [Test]
        public void TestCodesReturn()
        {
            var supported_codes_all = new[,] {
                {"AED", "UAE Dirham"},
                {"AFN", "Afghan Afghani"},
                {"ALL", "Albanian Lek"},
                {"AMD", "Armenian Dram"},
                {"ANG", "Netherlands Antillian Guilder"},
                {"AOA", "Angolan Kwanza"},
                {"ARS", "Argentine Peso"},
                {"AUD", "Australian Dollar"},
                {"AWG", "Aruban Florin"},
                {"AZN", "Azerbaijani Manat"},
                {"BAM", "Bosnia and Herzegovina Convertible Mark"},
                { "BBD", "Barbados Dollar" }
            };
            var codes = new CodesClass()
            {
                result = "success",
                documentation = "https://www.exchangerate-api.com/docs",
                terms_of_use = "https://www.exchangerate-api.com/terms",
                supported_codes = supported_codes_all
            };

            var mockExchangeService = new Mock<IExchange>();

            mockExchangeService.Setup(p => p.GetCurrencyCodes()).ReturnsAsync(codes);

            _service = new ExchangeService(mockExchangeService.Object);

            var result = _service.ReturnAllCodes();

            Assert.AreEqual("success", result.result);
            Assert.AreEqual(supported_codes_all, result.supported_codes);
        }

        [Test]
        public void TestHistoricalReturn()
        {
            var conversion_rates_hist = new HistoricalRate()
            {
                AUD = 1.4196,
                BRL = 4.0003,
                CAD = 1.324,
                CHF = 0.9744,
                CNY = 6.3559,
                DKK = 6.6601,
                EUR = 0.8929,
                GBP = 0.6595,
                HKD = 7.75,
                INR = 65.57,
                JPY = 119.58,
                KRW = 118
            };
            var codes = new HistoricalClass()
            {
                result = "success",
                documentation = "https://www.exchangerate-api.com/docs",
                terms_of_use = "https://www.exchangerate-api.com/terms",
                year = 2015,
                month = 2,
                day = 22,
                base_code = "USD",
                conversion_rates = conversion_rates_hist
            };


            var mockExchangeService = new Mock<IExchange>();

            mockExchangeService.Setup(p => p.GetHistoricalRates("USD", 2015, 2, 22)).ReturnsAsync(codes);

            _service = new ExchangeService(mockExchangeService.Object);

            var result = _service.ReturnHistoricalRates("USD", 2015, 2, 22);

            Assert.AreEqual("success", result.result);
            Assert.AreEqual(conversion_rates_hist, result.conversion_rates);
        }

        [Test]

        public void TestCodesInDict()
        {
            var supported_codes_all = new[,] {
                {"AED", "UAE Dirham"},
                {"AFN", "Afghan Afghani"},
                {"ALL", "Albanian Lek"},
                {"AMD", "Armenian Dram"},
                {"ANG", "Netherlands Antillian Guilder"},
                {"AOA", "Angolan Kwanza"},
                {"ARS", "Argentine Peso"},
                {"AUD", "Australian Dollar"},
                {"AWG", "Aruban Florin"},
                {"AZN", "Azerbaijani Manat"},
                {"BAM", "Bosnia and Herzegovina Convertible Mark"},
                { "BBD", "Barbados Dollar" }
            };
            var codes = new CodesClass()
            {
                result = "success",
                documentation = "https://www.exchangerate-api.com/docs",
                terms_of_use = "https://www.exchangerate-api.com/terms",
                supported_codes = supported_codes_all
            };

            var mockExchangeService = new Mock<IExchange>();

            _service = new ExchangeService(mockExchangeService.Object);

            mockExchangeService.Setup(p => p.GetCurrencyCodes()).ReturnsAsync(codes);

            var result = _service.GetCodesInDict();

            Assert.AreEqual("UAE Dirham", result["AED"]);
            Assert.AreEqual("Afghan Afghani", result["AFN"]);

        }

        [Test]
        public void TestLatestRatesInDict()
        {
            var latest_rates = new ConversionRate()
            {
                USD = 1,
                AUD = 1.4817,
                BGN = 1.7741,
                CAD = 1.3168,
                CHF = 0.9774,
                CNY = 6.9454,
                EGP = 15.7361,
                EUR = 0.9013,
                GBP = 0.7679
            };
            var latest = new LatestClass()
            {
                result = "success",
                documentation = "https://www.exchangerate-api.com/docs",
                terms_of_use = "https://www.exchangerate-api.com/terms",
                time_last_update_unix = "1585267200",
                time_last_update_utc = "Fri, 27 Mar 2020 00:00:00 +0000",
                time_next_update_unix = "1585270800",
                time_next_update_utc = "Sat, 28 Mar 2020 01:00:00 +0000",
                base_code = "USD",
                conversion_rates = latest_rates
            };

            var mockExchangeService = new Mock<IExchange>();

            mockExchangeService.Setup(p => p.GetLatestRates("USD")).ReturnsAsync(latest);

            _service = new ExchangeService(mockExchangeService.Object);

            var result = _service.GetLatestRatesInDict(latest.conversion_rates);

            Assert.AreEqual(1, result["USD"]);
            Assert.AreEqual(1.4817, result["AUD"]);
            Assert.AreEqual(0.9013, result["EUR"]);
        }

        [Test]
        public void TestHistoricalRatesInDict()
        {
            var conversion_rates_hist = new HistoricalRate()
            {
                AUD = 1.4196,
                BRL = 4.0003,
                CAD = 1.324,
                CHF = 0.9744,
                CNY = 6.3559,
                DKK = 6.6601,
                EUR = 0.8929,
                GBP = 0.6595,
                HKD = 7.75,
                INR = 65.57,
                JPY = 119.58,
                KRW = 118
            };
            var codes = new HistoricalClass()
            {
                result = "success",
                documentation = "https://www.exchangerate-api.com/docs",
                terms_of_use = "https://www.exchangerate-api.com/terms",
                year = 2015,
                month = 2,
                day = 22,
                base_code = "USD",
                conversion_rates = conversion_rates_hist
            };


            var mockExchangeService = new Mock<IExchange>();

            mockExchangeService.Setup(p => p.GetHistoricalRates("USD", 2015, 2, 22)).ReturnsAsync(codes);

            _service = new ExchangeService(mockExchangeService.Object);

            var result = _service.GetHistoricalRatesInDict(codes.conversion_rates);

            Assert.AreEqual(1.4196, result["AUD"]);
            Assert.AreEqual(118, result["KRW"]);
            Assert.AreEqual(0.6595, result["GBP"]);
        }

        [Test]

        public void TestConvertAmount()
        {
            var baseAmount = 9.12;
            var convRate = 0.8929;

            var mockExchangeService = new Mock<IExchange>();
            _service = new ExchangeService(mockExchangeService.Object);

            var result = _service.ConvertAmount(baseAmount, convRate);

            Assert.AreEqual(8.143248, result);
        }

    }
}