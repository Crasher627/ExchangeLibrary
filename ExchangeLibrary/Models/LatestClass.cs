using System;
using System.Collections.Generic;
using System.Text;

namespace ExchangeLibrary.Models
{
    public class LatestClass
    {
        public string result { get; set; }
        public string documentation { get; set; }
        public string terms_of_use { get; set; }
        public string time_last_update_unix { get; set; }
        public string time_last_update_utc { get; set; }
        public string time_next_update_unix { get; set; }
        public string time_next_update_utc { get; set; }
        public string base_code { get; set; }
        public ConversionRate conversion_rates { get; set; }

        public override string ToString()
        {
            return $"{nameof(result)}: {result}, {nameof(documentation)}: {documentation}, {nameof(terms_of_use)}: {terms_of_use}, {nameof(time_last_update_unix)}: {time_last_update_unix}, {nameof(time_last_update_utc)}: {time_last_update_utc}, {nameof(time_next_update_unix)}: {time_next_update_unix}, {nameof(time_next_update_utc)}: {time_next_update_utc}, {nameof(base_code)}: {base_code}, {nameof(conversion_rates)}: {conversion_rates}";
        }
    }
}
