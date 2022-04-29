using Microsoft.AspNetCore.Authorization;
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
   // [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class PropertyInfoController : Controller
    {
        PropertyInfoService _service;
        public PropertyInfoController(PropertyInfoService service)
        {
            _service = service;
        }
        [HttpGet]
        [Route("GetPropertyInformation")]
        public IActionResult GetPropertyInformation()
        {
            var company = _service.GetPropertyInformation();
            return Ok(company);
        }
        [HttpGet]
        [Route("GetPropertyInformationById")]
        public IActionResult GetPropertyInformationById(int PropertyId)
        {
            var company = _service.GetPropertyInformationById(PropertyId);
            return Ok(company);
        }
        [HttpPost]
        [Route("AddPropertyInformation")]
        public IActionResult AddPropertyInformation([FromBody] PropertyInfoVM propertyInformation)
        {
            try
            {
                _service.AddPropertyInformation(propertyInformation);
                return Ok(new Response { Status = "Success", Message = "Property information added Successfully" });
            }
            catch (Exception ex)
            {
                return NotFound(ex.Message);
            }
        }
        [HttpPut]
        [Route("UpdatePropertyInformation")]
        public IActionResult UpdatePropertyInformation(PropertyInfoVM propertyInformationVM)
        {
            try
            {
                _service.UpdatePropertyInformation(propertyInformationVM);
                return Ok(new Response { Status = "Success", Message = "Property information updated Successfully" });
            }
            catch (Exception ex)
            {
                return NotFound(ex.Message);
            }
        }
        [HttpDelete]
        [Route("DeletePropertyInformation/{id}")]
        public IActionResult DeletePropertyInformation(int id)
        {
            try
            {
                _service.DeletePropertyInformation(id);
                return Ok();
            }
            catch (Exception ex)
            {
                return NotFound(ex.Message);
            }
        }
    }
}
