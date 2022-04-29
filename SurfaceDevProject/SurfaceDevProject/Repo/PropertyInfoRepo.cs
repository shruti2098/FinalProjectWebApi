using SurfaceDevProject.Data;
using SurfaceDevProject.Interface;
using SurfaceDevProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SurfaceDevProject.Repo
{
    public class PropertyInfoRepo : IPropertyInfo
    {
        ApplicationDbContext _context;
        public PropertyInfoRepo(ApplicationDbContext context)
        {
            _context = context;
        }
        public List<PropertyInfo> GetPropertyInformation()
        {
            return _context.propertyInformation.ToList();
        }
        public PropertyInfo GetPropertyInformationById(int id)
        {
            return _context.propertyInformation.FirstOrDefault(e => e.PropertyInformationId == id);
        }
        public PropertyInfo AddPropertyInformation(PropertyInfo propertyInformation)
        {
            _context.Add(propertyInformation);
            _context.SaveChanges();
            return propertyInformation;
        }
        public PropertyInfo UpdatePropertyInformation(PropertyInfo propertyInformation)
        {
            _context.Update(propertyInformation);
            _context.SaveChanges();
            return propertyInformation;
        }
        public void DeletePropertyInformation(int id)
        {
            var deleteproperty = _context.propertyInformation.Where(s => s.PropertyInformationId == id).FirstOrDefault();
            if (deleteproperty != null)
            {
                _context.Remove(deleteproperty);
                _context.SaveChanges();
            }
        }
    }
}
