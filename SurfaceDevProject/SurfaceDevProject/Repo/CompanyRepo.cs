using SurfaceDevProject.Data;
using SurfaceDevProject.Interface;
using SurfaceDevProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SurfaceDevProject.Repo
{
    public class CompanyRepo : ICompany
    {
        ApplicationDbContext _context;
        public CompanyRepo(ApplicationDbContext context)
        {
            _context = context;
        }
        public List<Company> GetCompanies()
        {
            return _context.Companies.ToList();
        }
        public Company GetCompanyById(int id)
        {
            return _context.Companies.FirstOrDefault(e => e.CompanyId == id);
        }
        public Company AddCompany(Company company)
        {
            _context.Add(company);
            _context.SaveChanges();
            return company;
        }
        public Company UpdateCompany(Company company)
        {
            _context.Update(company);
            _context.SaveChanges();
            return company;
        }
        public void DeleteCompany(int Companyid)
        {
            var deletecompany = _context.Companies.Where(s => s.CompanyId == Companyid).FirstOrDefault();
            if (deletecompany != null)
            {
                _context.Remove(deletecompany);
                _context.SaveChanges();
            }
        }
    }
}
