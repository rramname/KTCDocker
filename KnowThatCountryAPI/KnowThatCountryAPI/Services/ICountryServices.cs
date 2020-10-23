using KnowThatCountryAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KnowThatCountryAPI.Services
{
    public interface ICountryServices
    {

        List<CountryInfo> GetAll( );

        CountryInfo GetByID( int id );
        
    }
}
