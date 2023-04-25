using AutoMapper;
using BusinessLayer.DTOs.Response;
using DataAccess.Models;

namespace BusinessLayer.Extensions.AutoMapper.Module
{
    public static class PersonModule
    {
        public static void ConfigPersonModule(this IMapperConfigurationExpression mc)
        {
            mc.CreateMap<Person, PersonResponseModel>().ReverseMap();
        }
    }
}
