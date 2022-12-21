using System;
using System.Collections.Generic;
using System.Text;

namespace ExchangeLibrary.Models
{
    public class HistoricalClass
    {
        public string result { get; set; }
        public string documentation { get; set; }
        public string terms_of_use { get; set; }
        public int year { get; set; }
        public int month { get; set; }
        public int day { get; set; }
        public string base_code { get; set; }
        public HistoricalRate conversion_rates { get; set; }

        public override string ToString()
        {
            return $"{nameof(result)}: {result}, {nameof(documentation)}: {documentation}, {nameof(terms_of_use)}: {terms_of_use}, {nameof(year)}: {year}, {nameof(month)}: {month}, {nameof(day)}: {day}, {nameof(base_code)}: {base_code}, {nameof(conversion_rates)}: {conversion_rates}";
        }
    }
}
