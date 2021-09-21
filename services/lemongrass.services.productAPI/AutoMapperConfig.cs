using AutoMapper;
using lemongrass.services.productAPI.Models.DTO;
using lemongrass.services.productAPI.Models;


namespace lemongrass.services.productAPI
{
    public class AutoMapperConfig
    {
        public static MapperConfiguration RegisterMaps()
        {
            var autoMapperConfig = new MapperConfiguration(config =>
            {
                config.CreateMap<ProductDTO, ProductModel>();
                config.CreateMap<ProductModel, ProductDTO>();
            });

            return autoMapperConfig;
        }
    }
}