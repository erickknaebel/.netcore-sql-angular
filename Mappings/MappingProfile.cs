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
            CreateMap<Make, MakeResource>();
            CreateMap<Model, ModelResource>();
            CreateMap<Feature, FeatureResource>();
        }
    }
}