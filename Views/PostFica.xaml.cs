using Microsoft.Maui.Controls;
using BLOGSOCIALUDLA.Models;
using System.Collections.ObjectModel;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Linq;

namespace BLOGSOCIALUDLA.Views
{
    public partial class PostFica : ContentPage
    {
        private ObservableCollection<Comentario> comentariosFica;
        private ObservableCollection<Post> posts;
        private Post selectedPost;

        public string ComentarioText { get; set; } 

        public PostFica()
        {
            InitializeComponent();
            BindingContext = this;
            comentariosFica = new ObservableCollection<Comentario>();
            posts = new ObservableCollection<Post>(DataPost.Posts);
            listaPosts.ItemsSource = posts;
        }

        protected override async void OnAppearing()
        {
            base.OnAppearing();
            await LoadComentarios();
            LoadPosts();
        }

        private async Task LoadComentarios()
        {
            List<Comentario> ListaComentarios = await DataComentario.GetComentarioFica();
            comentariosFica.Clear();
            foreach (var comentario in ListaComentarios)
            {
                comentariosFica.Add(comentario);
            }
        }

        private void LoadPosts()
        {
            posts.Clear();
            foreach (var post in DataPost.Posts)
            {
                posts.Add(post);
            }
        }
         
        private void OnPostSelected(object sender, SelectedItemChangedEventArgs e)
        {
            if (e.SelectedItem == null)
                return;
            selectedPost = e.SelectedItem as Post;
            DisplayAlert("Post seleccionado", $"Título: {selectedPost.Titulo}\nContenido: {selectedPost.Contenido}", "OK");
            listaPosts.SelectedItem = null;
        }

        private void OnAddComment(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            Post selectedPost = (Post)button.CommandParameter;
            string comentarioTexto = ComentarioText; 

            if (string.IsNullOrWhiteSpace(comentarioTexto))
            {
                DisplayAlert("Error", "El comentario no puede estar vacío.", "OK");
                return;
            }

            var nuevoComentario = new Comentario
            {
                Contenido = comentarioTexto
            };

            selectedPost.Comentarios.Add(nuevoComentario);
            ComentarioText = string.Empty; 
        }

        private async void ClickComentarioFica(object sender, EventArgs e)
        {
            string comentarioTexto = ComentarioText; 
            if (string.IsNullOrWhiteSpace(comentarioTexto))
            {
                DisplayAlert("Error", "El comentario no puede estar vacío.", "OK");
                return;
            }
            var nuevoComentario = new Comentario
            {
                Contenido = comentarioTexto
            };
            comentariosFica.Add(nuevoComentario);
            DisplayAlert("Comentario añadido", "Tu comentario ha sido añadido exitosamente.", "OK");
            ComentarioText = string.Empty; 
        }

        private async void ClickPostFica(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new AddPostPage());
        }
    }
}