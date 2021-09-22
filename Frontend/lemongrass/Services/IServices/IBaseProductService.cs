using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using lemongrass.Models.DTO;
using lemongrass.Models;

namespace lemongrass.Services.IServices
{
    public interface IBaseProductService : IDisposable
    {
        ResponseDTO responseDTOModel { get; set; }
        Task<T> SendAsync<T>(APIRequestModel ApiRequestModel);
    }
}