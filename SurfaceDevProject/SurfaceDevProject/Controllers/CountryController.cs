using Microsoft.AspNetCore.Mvc;
using SurfaceDevProject.Authentication;
using SurfaceDevProject.Models;
using SurfaceDevProject.Services;
using SurfaceDevProject.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SurfaceDevProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CountryController : Controller
    {
        CountryService _countryservice;
        public CountryController(CountryService service)
        {
            _countryservice = service;
        }
        [HttpGet]
        [Route("GetCountries")]
        public IActionResult GetCountries()
        {
            var country = _countryservice.GetCountries();
            return Ok(country);
        }
        [HttpGet]
        [Route("GetCountryById")]
        public IActionResult GetCountryById(int id)
        {
            var country = _countryservice.GetCountryById(id);
            return Ok(country);
        }

        [HttpPost]
        [Route("AddCountry")]
        public IActionResult AddCountry(Country country)
        {
            try
            {
                _countryservice.AddCountry(country);
                return Ok(new Response { Status = "Success", Message = "Country added Successfully" });
            }
            catch (Exception ex)
            {
                return NotFound(ex.Message);
            }
        }
        [HttpPut]
        [Route("UpdateCountry")]
        public IActionResult UpdateCountry(CountryVM contryVM)
        {
            try
            {
                _countryservice.UpdateCountry(contryVM);
                return Ok(new Response { Status = "Success", Message = "Country updated Successfully" });
            }
            catch (Exception ex)
            {
                return NotFound(ex.Message);
            }
        }
        [HttpDelete]
        [Route("DeleteCountry/{id}")]
        public IActionResult DeleteCountry(int id)
        {
            try
            {
                _countryservice.DeleteCountry(id);
                return Ok(new Response { Status = "Success", Message = "Country deleted Successfully" });
            }
            catch (Exception ex)
            {
                return NotFound(ex.Message);
            }
        }
    }
}
