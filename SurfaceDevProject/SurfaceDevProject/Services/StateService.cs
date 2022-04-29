using SurfaceDevProject.Interface;
using SurfaceDevProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SurfaceDevProject.Services
{
    public class StateService
    {
        IState _service;
        public StateService(IState service)
        {
            _service = service;
        }
        public List<State> GetStates()
        {
            return _service.GetStates().ToList();
        }
        public State GetStateById(int Id)
        {
            return _service.GetStateById(Id);
        }
        public void AddState(State statevm)
        {
            _service.AddState(statevm);
        }
        public void UpdateState(State state)
        {
            _service.UpdateState(state);
        }
        public void DeleteState(int id)
        {
            _service.DeleteState(id);
        }
    }
}
