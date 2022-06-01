using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectWebAPI.DTO
{
    public class CategoryDataWithProductNameDTO
    {
        public int ID { get; set; }
        public string CategoryName { get; set; }
        public string Image { get; set; }
        public List<string> ProductName { get; set; } = new List<string>();
    }
}
