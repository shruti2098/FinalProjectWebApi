using Microsoft.AspNetCore.Mvc;
using SurfaceDevProject.Authentication;
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
    public class CompanyController : Controller
    {
        CompanyService _companyservice;
        public CompanyController(CompanyService service)
        {
            _companyservice = service;
        }
        [HttpGet]
        [Route("GetCompany")]
        public IActionResult GetCompanies()
        {
            var company = _companyservice.GetCompanies();
            return Ok(company);
        }
        [HttpGet]
        [Route("GetCompanyById")]
        public IActionResult GetCompanyById(int Companyid)
        {
            var company = _companyservice.GetCompanyById(Companyid);
            return Ok(company);
        }
        [HttpPost]
        [Route("AddCompany")]
        public IActionResult AddCompany([FromBody] CompanyVM company)
        {
            try
            {
                _companyservice.AddCompany(company);
                return Ok(new Response { Status = "Success", Message = "Company added Successfully" });
            }
            catch (Exception ex)
            {
                return NotFound(ex.Message);
            }
        }
        [HttpPut]
        [Route("UpdateCompany")]
        public IActionResult UpdateCompany(CompanyVM companyVM)
        {
            try
            {
                _companyservice.UpdateCompany(companyVM);
                return Ok(new Response { Status = "Success", Message = "Company updated Successfully" });
            }
            catch (Exception ex)
            {
                return NotFound(ex.Message);
            }
        }
        [HttpDelete]
        [Route("DeleteCompany/{id}")]
        public IActionResult DeleteCompany(int id)
        {
            try
            {
                _companyservice.DeleteCompany(id);
                return Ok(new Response { Status = "Success", Message = "Company deleted Successfully" });
            }
            catch (Exception ex)
            {
                return NotFound(ex.Message);
            }
        }
    }
}
