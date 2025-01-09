using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CURD.Core.Entityes.Base;
public abstract class BaseEntity
{
    public int Id { get; set; }
    public bool IsDeleted { get; set; } 

}
