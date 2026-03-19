using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Exceptions
{
    public class UnauthorizedUserException : Exception
    {
        public UnauthorizedUserException(User user) : base ($"Unauthorized user: {user}")
        {
            
        }
    }
}
