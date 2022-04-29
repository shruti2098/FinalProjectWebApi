using SurfaceDevProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SurfaceDevProject.Interface
{
    public interface ICompany
    {
        public List<Company> GetCompanies();
        public Company GetCompanyById(int ComapnyId);
        public Company AddCompany(Company company);
        public Company UpdateCompany(Company comapany);
        public void DeleteCompany(int id);
    }
}
