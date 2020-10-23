using KnowThatCountryAPI.Models;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;

namespace KnowThatCountryAPI.Services
{
    public class CountriesService:ICountryServices
    {
        private readonly ILogger<CountriesService> _logger;
        List<CountryInfo> CountriesInfo;
        public CountriesService( ILogger<CountriesService> logger )
        {
            _logger = logger;
            CountriesInfo = ReadFile();
        }
        private List<CountryInfo> ReadFile( )
        {
            var fs = System.IO.File.ReadAllText(@"Data/CountriesInfo.json");
            var data = JsonSerializer.Deserialize<List<CountryInfo>>(fs);
            return data;
        }

        public List<CountryInfo> GetAll( )
        {
            return CountriesInfo;
        }

        public CountryInfo GetByID(int id )
        {
            return CountriesInfo[id];
        }
    }
}
