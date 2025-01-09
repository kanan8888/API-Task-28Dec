using CURD.Core.Entityes.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace CURD.Core.Entityes
{
    public class Category : BaseEntity
    {
        public string CategoryName { get; set; }
        public ICollection<Product> Products { get; set; }

        [JsonIgnore]
        public ICollection<BlogCategory> BlogCategories { get; set; }   

    }
}
