using BLOGSOCIALUDLA.Models;

namespace BLOGSOCIALUDLA.Views
{
    public partial class PostSeleccionado : ContentPage
    {
        public PostSeleccionado(Post post)
        {
            InitializeComponent();

            tituloLabel.Text = post.Titulo;
            contenidoLabel.Text = post.Contenido;
        }
    }
}
