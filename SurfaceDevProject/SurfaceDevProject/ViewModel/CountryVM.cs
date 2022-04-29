using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SurfaceDevProject.ViewModel
{
    public class CountryVM
    {
        public int Id { get; set; }
        public string CountryName { get; set; }
        public string Description { get; set; }
        public int StateId { get; set; }
    }
}
