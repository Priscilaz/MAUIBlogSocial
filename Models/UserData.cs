using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLOGSOCIALUDLA.Models
{
    public static class UserData
    {
        public static List<User> Users = new List<User>
        {
            new User { Username = "admin", Password = "1234" },
            new User { Username = "user", Password = "123" }
        };
    }
}
