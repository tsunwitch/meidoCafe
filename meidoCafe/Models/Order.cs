using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace meidoCafe.Models
{
    internal class Order
    {
        public int OrderID { get; set; }
        public int Value { get; set; }
        public virtual ICollection<Product> Products { get; set; }
        public virtual int EmployeeId { get; set; }
        public virtual int CustomerId { get; set; }
    }
}
