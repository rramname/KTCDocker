using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace KnowThatCountryAPI.Models
{
    public class CountryInfo
    {
        [JsonPropertyName("name")]

        public string Name { get; set; }

        [JsonPropertyName("capital")]

        public string Capital { get; set; }

        public List<Currency> currencies { get; set; }
    }

    public class Currency
    {
        [JsonPropertyName("code")]

        public string Code { get; set; }

        [JsonPropertyName("name")]

        public string Name { get; set; }
    }
}
