using Microsoft.AspNetCore.Mvc;
using SurfaceDevProject.Models;
using SurfaceDevProject.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SurfaceDevProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StateController : Controller
    {
        StateService _repo;
        public StateController(StateService repo)
        {
            _repo = repo;
        }
        [HttpGet]
        [Route("GetState")]
        public IActionResult GetStates()
        {
            var state = _repo.GetStates();
            return Ok(state);
        }
        [HttpGet]
        [Route("GetStateById")]
        public IActionResult GetStateByID(int StateId)
        {
            var state = _repo.GetStateById(StateId);
            return Ok(state);
        }
        [HttpPost]
        [Route("AddState")]
        public IActionResult AddState([FromBody] State state)
        {
            try
            {
                _repo.AddState(state);
                return Ok();
            }
            catch (Exception ex)
            {
                return NotFound(ex.Message);
            }
        }
        [HttpPut]
        [Route("UpdateState")]
        public IActionResult UpdateState(State state)
        {
            try
            {
                _repo.UpdateState(state);
                return Ok();
            }
            catch (Exception ex)
            {
                return NotFound(ex.Message);
            }
        }
        [HttpDelete]
        [Route("DeleteState/{StateId}")]
        public IActionResult DeleteState(int StateId)
        {
            try
            {
                _repo.DeleteState(StateId);
                return Ok();
            }
            catch (Exception ex)
            {
                return NotFound(ex.Message);
            }
        }
    }
}
