using CURD.Core.Entityes.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CURD.Core.Entityes
{
    public class Product : BaseEntity
    {
        public string ProductName { get; set; }
        public string Description { get; set; }
        public int Price { get; set; }
        public int? OldPrice { get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; }
        public ICollection<TagProduct> Tags { get; set; }

    }
}
