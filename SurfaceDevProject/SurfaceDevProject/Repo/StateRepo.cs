using SurfaceDevProject.Data;
using SurfaceDevProject.Interface;
using SurfaceDevProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SurfaceDevProject.Repo
{
    public class StateRepo : IState
    {
        ApplicationDbContext _context;
        public StateRepo(ApplicationDbContext context)
        {
            _context = context;
        }
        public List<State> GetStates()
        {
            return _context.States.ToList();
        }
        public State GetStateById(int id)
        {
            return _context.States.FirstOrDefault(e => e.Id == id);
        }
        public State AddState(State state)
        {
            _context.Add(state);
            _context.SaveChanges();
            return state;
        }
        public State UpdateState(State state)
        {
            _context.Update(state);
            _context.SaveChanges();
            return state;
        }
        public void DeleteState(int id)
        {
            var deletestate = _context.States.Where(s => s.Id == id).FirstOrDefault();
            if (deletestate != null)
            {
                _context.Remove(deletestate);
                _context.SaveChanges();
            }
        }
    }
}
