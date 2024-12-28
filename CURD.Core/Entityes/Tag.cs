using CURD.Core.Entityes.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CURD.Core.Entityes
{
    public class Tag : BaseEntity
    {
        public string TagName { get; set; }
        public ICollection<TagProduct> Products { get; set; }

    }
}
