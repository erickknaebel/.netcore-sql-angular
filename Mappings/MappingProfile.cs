using System.Linq;
using AutoMapper;
using DealerApp.Models;
using dotnetcore_sql_angular.Models;
using dotnetcore_sql_angular.Resources;

namespace dotnetcore_sql_angular.Mappings
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            //Domain to API Resources
            CreateMap<Make, MakeResource>();
            CreateMap<Model, ModelResource>();
            CreateMap<Feature, FeatureResource>();
            CreateMap<Vehicle, VehicleResource>()
                .ForMember(vr => vr.Contact, opt => opt.MapFrom(v => 
                    new ContactResource { 
                        Name = v.ContactName, 
                        Email = v.ContactEmail, 
                        Phone = v.ContactPhone
                    }
                ))
                .ForMember(vr => vr.Features, opt => opt.MapFrom(v => 
                    v.Features.Select(vf => vf.FeatureId))); 
      

            // API Resource to Domain
            CreateMap<VehicleResource, Vehicle>()
                .ForMember(v => v.ContactName, opt => opt.MapFrom(vr => vr.Contact.Name)) 
                .ForMember(v => v.ContactEmail, opt => opt.MapFrom(vr => vr.Contact.Email)) 
                .ForMember(v => v.ContactPhone, opt => opt.MapFrom(vr => vr.Contact.Phone)) 
                .ForMember(v => v.Features, opt => opt.MapFrom(vr => vr.Features.Select(id => 
                    new VehicleFeature { FeatureId = id })));
        }
    }
}