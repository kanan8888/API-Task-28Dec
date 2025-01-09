using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CURD.Business.Helper.Exceptions.UserExceptions;
public class UserRegisterException : Exception
{
    public UserRegisterException() : base("register zamani xeta bas verdi") { }
    public UserRegisterException(string message) : base(message) { }


}
