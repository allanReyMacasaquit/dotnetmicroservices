using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Threading.Tasks;
using lemongrass.Models.DTO;

namespace lemongrass.Services.IServices
{
    public interface IProductService : IBaseProductService
    {
        Task<T> GetAllProductsAsync<T>();
        Task<T> GetProductByIdAsync<T>(int id);
        Task<T> CreateProductAsync<T>(ProductDTO productDTO);
        Task<T> UpdateProductAsync<T>(ProductDTO productDTO);
        Task<T> DeleteProductAsync<T>(int id);
    }
}