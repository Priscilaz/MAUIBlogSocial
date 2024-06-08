using BLOGSOCIALUDLA.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Collections.Generic;

namespace BLOGSOCIALUDLA.Models
{
    public static class DataPost
    {
        public static List<Post> Posts = new List<Post>
        {
            new Post {Titulo = "Primer Post Prueba", Contenido = "Hola ¿Como están?." }
        };
    }
}
