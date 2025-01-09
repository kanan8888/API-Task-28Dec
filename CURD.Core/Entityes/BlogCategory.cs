using CURD.Core.Entityes.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace CURD.Core.Entityes;
public class BlogCategory : BaseEntity
{
    public int BlogId { get; set; }

    [JsonIgnore]
    public Blog Blog { get; set; }
    public int CategoryId { get; set; }
    public Category Category { get; set; }

}
