namespace BLOGSOCIALUDLA.Views;
using Microsoft.Maui.Controls;
using BLOGSOCIALUDLA.Models;
using global::BLOGSOCIALUDLA.Models;

    public partial class AddPostPage : ContentPage
    {
        public AddPostPage()
        {
            InitializeComponent();
        }

        private async void ClickAñadirPost(object sender, EventArgs e)
        {
            string titulo = TituloPost.Text;
            string contenido = ContenidoPost.Text;

            if (string.IsNullOrEmpty(titulo) || string.IsNullOrEmpty(contenido))
            {
                await DisplayAlert("Error", "Por favor, completa todos los campos.", "OK");
                return;
            }

            var newPost = new Post
            {
                Titulo = titulo,
                Contenido = contenido
            };

            DataPost.Posts.Add(newPost);

            await DisplayAlert("Post añadido", "Tu post ha sido añadido exitosamente.", "OK");

            await Navigation.PopAsync(); 
        }
    }
