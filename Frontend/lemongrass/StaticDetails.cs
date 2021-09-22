using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace lemongrass
{
    public static class StaticDetails
    {
        public static string ProductAPIBase { get; set; }
        public enum APIType
        {
            GET,
            POST,
            PUT,
            DELETE,
        }
    }
}