using SurfaceDevProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SurfaceDevProject.Interface
{
    public interface ICountry
    {
        public List<Country> GetCountries();
        public Country GetCountryById(int Id);
        public Country AddCountry(Country country);
        public Country UpdateCountry(Country country);
        public void DeleteCountry(int id);
    }
}
