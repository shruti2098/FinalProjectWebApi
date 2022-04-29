using SurfaceDevProject.Interface;
using SurfaceDevProject.Models;
using SurfaceDevProject.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SurfaceDevProject.Services
{
    public class PropertyInfoService
    {
        IPropertyInfo _service;
        public PropertyInfoService(IPropertyInfo service)
        {
            _service = service;
        }
        public List<PropertyInfo> GetPropertyInformation()
        {
            return _service.GetPropertyInformation().ToList();
        }
        public PropertyInfo GetPropertyInformationById(int PropertyId)
        {
            return _service.GetPropertyInformationById(PropertyId);
        }
        public void AddPropertyInformation(PropertyInfoVM propertyInformationVM)
        {
            PropertyInfo propertyInformation = new PropertyInfo()
            {
                PropertyInformationId = propertyInformationVM.PropertyInformationId,
                UniqueId = propertyInformationVM.UniqueId,
                MapId = propertyInformationVM.MapId,
                Rural = propertyInformationVM.Rural,
                //domainionLandSurvey = propertyInformationVM.domainionLandSurvey,
                Address = propertyInformationVM.Address,
                City = propertyInformationVM.City,
                Zipcode = propertyInformationVM.Zipcode,
                CompanyName = propertyInformationVM.CompanyName,
                CountryName = propertyInformationVM.CountryName,
                StateName = propertyInformationVM.StateName,
                OperatingArea = propertyInformationVM.OperatingArea,
                Type = propertyInformationVM.Type,
                SubType = propertyInformationVM.SubType,
                Comment = propertyInformationVM.Comment,
                Status = propertyInformationVM.Status
            };
            _service.AddPropertyInformation(propertyInformation);
        }
        public void UpdatePropertyInformation(PropertyInfoVM propertyInformationVM)
        {
            PropertyInfo propertyInformation = new PropertyInfo()
            {
                PropertyInformationId = propertyInformationVM.PropertyInformationId,
                UniqueId = propertyInformationVM.UniqueId,
                MapId = propertyInformationVM.MapId,
                Rural = propertyInformationVM.Rural,
                Address = propertyInformationVM.Address,
                City = propertyInformationVM.City,
                Zipcode = propertyInformationVM.Zipcode,
                CompanyName = propertyInformationVM.CompanyName,
                CountryName = propertyInformationVM.CountryName,
                StateName = propertyInformationVM.StateName,
                OperatingArea = propertyInformationVM.OperatingArea,
                Type=propertyInformationVM.Type,
                SubType = propertyInformationVM.SubType,
                Comment = propertyInformationVM.Comment,
                Status = propertyInformationVM.Status
            };
            _service.UpdatePropertyInformation(propertyInformation);
        }
        public void DeletePropertyInformation(int Id)
        {
            _service.DeletePropertyInformation(Id);
        }
    }
}
