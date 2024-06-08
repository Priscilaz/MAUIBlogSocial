using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLOGSOCIALUDLA.Models
{
    using System.Collections.Generic;

    namespace BLOGSOCIALUDLA.Models
    {
        public static class UserData
        {
            public static List<User> Users = new List<User>
        {
            new User { Username = "admin", Password = "1234", Nombres = "Admin", Apellidos = "ProAdmin", NumeroTelefono = "123456789" },
            new User { Username = "user", Password = "123", Nombres = "Fer", Apellidos = "Recalde", NumeroTelefono = "987654321" }
        };
        }
    }

}
