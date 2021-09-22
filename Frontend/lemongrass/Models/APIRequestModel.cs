using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static lemongrass.StaticDetails;

namespace lemongrass.Models
{
    public class APIRequestModel
    {
        public APIType ApiType { get; set; } = APIType.GET;
        public string Url { get; set; }
        public object Data { get; set; }
        public string AccessToken { get; set; }
    }
}