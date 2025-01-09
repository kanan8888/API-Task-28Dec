using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CURD.Business.Helper.Exceptions.UserExceptions;
public class UserLoginException : Exception
{
    public UserLoginException() : base("login zamani xeta bas verdi") { }
    public UserLoginException(string message) : base(message) { }

}
