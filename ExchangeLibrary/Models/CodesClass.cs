using System;
using System.Collections.Generic;
using System.Text;

namespace ExchangeLibrary.Models
{
    public class CodesClass
    {
        public string result { get; set; }
        public string documentation { get; set; }
        public string terms_of_use { get; set; }
        public string[,] supported_codes { get; set; }

        public override string ToString()
        {
            return $"{nameof(result)}: {result}, {nameof(documentation)}: {documentation}, {nameof(terms_of_use)}: {terms_of_use}, {nameof(supported_codes)}: {supported_codes}";
        }
    }
}
