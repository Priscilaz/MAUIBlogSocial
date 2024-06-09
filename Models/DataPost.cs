using BLOGSOCIALUDLA.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Collections.Generic;


namespace BLOGSOCIALUDLA.Models
{
    public static class DataPost
    {
        private static List<Post> _posts = new List<Post>
        {
            new Post
            {
                Titulo = "Primer Post Prueba",
                Contenido = "Hola ¿Cómo están?",
                Comentarios = new List<Comentario>
                {
                    new Comentario { Contenido = "Primer comentario", Fecha = DateTime.Now }
                }
            }
        };

        public static List<Post> Posts
        {
            get { return _posts; }
        }

        public static void AgregarPost(Post nuevoPost)
        {
            _posts.Add(nuevoPost);
        }
    }
}