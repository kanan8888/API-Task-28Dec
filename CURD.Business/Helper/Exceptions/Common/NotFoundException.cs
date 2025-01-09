using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CURD.Business.Helper.Exceptions.Common;
public class NotFoundException<T> : Exception where T : class
{
    public NotFoundException() : base($"{typeof(T)} not found") {}
    public NotFoundException(string message) : base(message) {}
}
