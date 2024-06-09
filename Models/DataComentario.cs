using BLOGSOCIALUDLA.Models;
using BLOGSOCIALUDLA.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public static class DataComentario
{
    public static Task<List<Comentario>> GetComentarios()
    {
        
        var comentarios = new List<Comentario>
        {
            new Comentario { Contenido = "¡La mejor de las facultades de la U! :)." },
            new Comentario { Contenido = "¿Cómo funciona el mentor virtual?." },
        };
        return Task.FromResult(comentarios);
    }
    //public static Task<List<Comentario>> GetComentarioFica()
    //{

    //    var comentariosFica = new List<Comentario>
    //    {
    //        new Comentario { Contenido = "¡FICA me cambio la vida, la mejor facultad de Inges! :)." },
    //        new Comentario { Contenido = "Alguien sabe como contacto a mi mentor?" },
    //    };
    //    return Task.FromResult(comentariosFica);
    //}

}
