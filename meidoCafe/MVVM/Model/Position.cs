using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace meidoCafe.Models
{
    internal class Position
    {
        public int PositionId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int Pay { get; set; }
        public virtual int EmployeeId { get; set; }
    }
}
