using BLOGSOCIALUDLA.Models;
using BLOGSOCIALUDLA.ViewModels;
using System.Collections.ObjectModel;

namespace BLOGSOCIALUDLA.Views
{
    public partial class PostSeleccionado : ContentPage
    {
        private Post _post;

        public ObservableCollection<Comentario> Comentarios { get; set; }

        public PostSeleccionado(Post post)
        {
            InitializeComponent();
            BindingContext = new PostSeleccionadoViewModel(post);

             }

       
    }
}
