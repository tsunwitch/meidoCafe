using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace meidoCafe.Models
{
    internal class Product
    {
        public int ProductId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }
        public float Price { get; set; }
        public virtual int CategoryId { get; set; }
        public virtual int ProductTypeId { get; set; }
        public virtual int OrderId { get; set; }
    }
}
