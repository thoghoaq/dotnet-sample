using AutoMapper;
using BusinessLayer.Extensions.AutoMapper.Module;
using Microsoft.Extensions.DependencyInjection;

namespace BusinessLayer.Extensions.AutoMapper
{
    public static class MapperConfig
    {
        public static void IntializeAutoMapper(this IServiceCollection services)
        {
            MapperConfiguration mapperConfiguration = new(mc =>
            {
                mc.ConfigPersonModule();
            });
            IMapper mapper = mapperConfiguration.CreateMapper();
            services.AddSingleton(mapper);
        }
    }
}
