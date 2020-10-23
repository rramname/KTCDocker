using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;
using KnowThatCountryAPI.Models;
using Microsoft.Extensions.Logging;

namespace KnowThatCountryAPI.Services
{
    public class CountriesServiceTest:ICountryServices
    {
        private readonly ILogger<CountriesService> _logger;
        List<CountryInfo> CountriesInfo;
        public CountriesServiceTest( ILogger<CountriesService> logger )
        {
            _logger = logger;
            CountriesInfo = ReadFile();
        }
        private List<CountryInfo> ReadFile( )
        {
            var fs = System.IO.File.ReadAllText("Data\\CountriesInfo.json");
            var data = JsonSerializer.Deserialize<List<CountryInfo>>(fs);
            return data.Take(10).ToList();
        }
        public List<CountryInfo> GetAll( )
        {
            return CountriesInfo;
        }

        public CountryInfo GetByID( int id )
        {
            return CountriesInfo[id];
        }
    }
}
