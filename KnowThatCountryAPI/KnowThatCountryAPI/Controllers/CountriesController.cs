using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;
using KnowThatCountryAPI.Models;
using KnowThatCountryAPI.Services;
using Microsoft.AspNetCore.Mvc;

namespace KnowThatCountryAPI.Controllers
{
    [ApiController]
    [Route("[controller]/[action]")]
    public class CountriesController : Controller
    {
        ICountryServices countryService;
        public CountriesController(ICountryServices country )
        {
            countryService = country;
        }
        [HttpGet]
        public List<CountryInfo> GetAll()
        {
            return countryService.GetAll();
        }

        [HttpGet]
        public CountryInfo GetByID(int id )
        {
            return countryService.GetByID(id);
        }

    }


}