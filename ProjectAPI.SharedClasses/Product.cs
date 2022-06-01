using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectWebAPI.SharedClasses
{
    public class Product
    {
        public int ID { get; set; }
        [Required]
        [MinLength(2)]
        public string Name { get; set; }
        [Required]
        public int Price { get; set; }
        [Required]
        public string Details { get; set; }
        [Required]
        public string Image { get; set; }
        [Required]
        [ForeignKey("Category")]
        public int CategoryID { get; set; }
        public virtual Category Category { get; set; }
    }
}
