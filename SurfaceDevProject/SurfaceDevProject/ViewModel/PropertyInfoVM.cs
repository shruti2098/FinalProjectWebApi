using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SurfaceDevProject.ViewModel
{
    public class PropertyInfoVM
    {
        public int PropertyInformationId { get; set; }
        public int UniqueId { get; set; }
        public int MapId { get; set; }
        public string Rural { get; set; }
        //public bool domainionLandSurvey { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string Zipcode { get; set; }
        public string CountryName { get; set; }
        public string StateName { get; set; }
        public string CompanyName { get; set; }
        public string OperatingArea { get; set; }
        public string Type { get; set; }
        public string SubType { get; set; }
        public string Comment { get; set; }
        public string Status { get; set; }
    }
}
