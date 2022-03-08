using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TangyWeb_Models
{
    public class Demo_Product
    {
        public int Id { get; set; }
        public double price { get; set; }
        public string? Name { get; set; }
        public bool IsActive { get; set; }

        public string Active = "Active";
        public string Inactive = "Inactive";
        public List<Demo_ProductProp> ProductProperties { get; set; }
    }
}
