using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace lemongrass.Models.DTO
{
    public class ProductDTO
    {

        public int ProductId { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public string Description { get; set; }
        public string CategoryNAme { get; set; }
        public string ImageUrl { get; set; }
    }
}