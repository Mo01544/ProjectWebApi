using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectWebAPI.DTO
{
    public class ProductDataWithCategoryNameDTO
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }
        public string Details { get; set; }
        public string Image { get; set; }
        public string CategoryName { get; set; }
    }
}
