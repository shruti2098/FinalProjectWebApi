using SurfaceDevProject.Models;
using System.Collections.Generic;

namespace SurfaceDevProject.Interface
{
    public interface IPropertyInfo
    {
        public List<PropertyInfo> GetPropertyInformation();
        public PropertyInfo GetPropertyInformationById(int PropertyId);
        public PropertyInfo AddPropertyInformation(PropertyInfo propertyInformation);
        public PropertyInfo UpdatePropertyInformation(PropertyInfo propertyInformation);
        public void DeletePropertyInformation(int id);
    }
}
