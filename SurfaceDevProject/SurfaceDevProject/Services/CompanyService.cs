using SurfaceDevProject.Interface;
using SurfaceDevProject.Models;
using SurfaceDevProject.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SurfaceDevProject.Services
{
    public class CompanyService
    {
        ICompany _service;
        public CompanyService(ICompany service)
        {
            _service = service;
        }
        public List<Company> GetCompanies()
        {
            return _service.GetCompanies().ToList();
        }
        public Company GetCompanyById(int CompanyId)
        {
            return _service.GetCompanyById(CompanyId);
        }
        public void AddCompany(CompanyVM company)
        {
            Company company1 = new Company()
            {
                CompanyId = company.CompanyId,
                CompanyName = company.
                Description = company.Description

            };
            _service.AddCompany(company1);
        }
        public void UpdateCompany(CompanyVM companyVM)
        {
            Company company1 = new Company()
            {
                CompanyId = companyVM.CompanyId,
                CompanyName = companyVM.CompanyName,
                Description = companyVM.Description

            };
            _service.UpdateCompany(company1);
        }
        public void DeleteCompany(int Id)
        {
            _service.DeleteCompany(Id);
        }
    }
}
