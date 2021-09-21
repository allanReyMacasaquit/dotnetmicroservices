using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using lemongrass.services.productAPI.Models.DTO;

namespace lemongrass.services.productAPI.Repository
{
    public interface IProductRepository
    {
        Task<IEnumerable<ProductDTO>> GetProducts();
        Task<ProductDTO> GetProductById(int productId);
        Task<ProductDTO> CreateUpdateProduct(ProductDTO productDTO);
        Task<bool> DeleteProduct(int productId);
    }
}