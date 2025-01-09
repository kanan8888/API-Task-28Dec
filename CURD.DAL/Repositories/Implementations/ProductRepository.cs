using CURD.Core.Entityes;
using CURD.DAL.Context;
using CURD.DAL.Repositories.Implementations.Generic;
using CURD.DAL.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CURD.DAL.Repositories.Implementations;
public class ProductRepository : Repository<Product>, IProductRepository
{
    public ProductRepository(CURD_DbContext context) : base(context) {}

}

