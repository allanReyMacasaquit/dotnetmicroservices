using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using static lemongrass.StaticDetails;
using lemongrass.Models;
using lemongrass.Models.DTO;
using lemongrass.Services;
using lemongrass.Services.IServices;

namespace lemongrass.Services
{
    public class ProductService : BaseProductService, IBaseProductService
    {
        private readonly IHttpClientFactory _clientFactory;

        public ProductService(IHttpClientFactory clientFactory) : base(clientFactory)
        {
            _clientFactory = clientFactory;
        }

        public async Task<T> GetAllProductsAsync<T>(string token)
        {
            return await this.SendAsync<T>(new APIRequestModel()
            {
                ApiType = StaticDetails.APIType.GET,
                Url = StaticDetails.ProductAPIBase + "/api/products",
                AccessToken = "",
            });
        }

        public async Task<T> GetProductByIdAsync<T>(int id, string token)
        {
            return await this.SendAsync<T>(new APIRequestModel()
            {
                ApiType = StaticDetails.APIType.GET,
                Url = StaticDetails.ProductAPIBase + "/api/products/" + id,
                AccessToken = "",
            });
        }

        public async Task<T> CreateProductAsync<T>(ProductDTO productDTO, string token)
        {
            return await this.SendAsync<T>(new APIRequestModel()
            {
                ApiType = StaticDetails.APIType.POST,
                Data = productDTO,
                Url = StaticDetails.ProductAPIBase + "/api/products",
                AccessToken = "",
            });
        }

        public async Task<T> UpdateProductAsync<T>(ProductDTO productDTO, string token)
        {
            return await this.SendAsync<T>(new APIRequestModel()
            {
                ApiType = StaticDetails.APIType.PUT,
                Data = productDTO,
                Url = StaticDetails.ProductAPIBase + "/api/products",
                AccessToken = "",
            });
        }

        public async Task<T> DeleteProductAsync<T>(int id, string token)
        {
            return await this.SendAsync<T>(new APIRequestModel()
            {
                ApiType = StaticDetails.APIType.DELETE,
                Url = StaticDetails.ProductAPIBase + "/api/products/" + id,
                AccessToken = token
            });
        }
    }
}