using SurfaceDevProject.Interface;
using SurfaceDevProject.Models;
using SurfaceDevProject.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SurfaceDevProject.Services
{
    public class CountryService
    {
        ICountry _service;
        public CountryService(ICountry service)
        {
            _service = service;
        }
        public List<Country> GetCountries()
        {
            return _service.GetCountries().ToList();
        }
        public Country GetCountryById(int Id)
        {
            return _service.GetCountryById(Id);
        }
        public void AddCountry(Country country)
        {
            Country country1 = new Country()
            {
                Id = country.Id,
                CountryName = country.CountryName,
                Description = country.Description,
            };
            _service.AddCountry(country1);
        }
        public void UpdateCountry(CountryVM countryVM)
        {
            Country country = new Country()
            {
                Id = countryVM.Id,
                CountryName = countryVM.CountryName,
                Description = countryVM.Description,
            };
            _service.UpdateCountry(country);
        }
        public void DeleteCountry(int id)
        {
            _service.DeleteCountry(id);
        }
    }
}
