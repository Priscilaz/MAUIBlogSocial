using Microsoft.Maui.Controls;
using System;
using System.Collections.ObjectModel;
using System.Threading.Tasks;
using BLOGSOCIALUDLA.Models;
//using System.Windows.Services.Maps;


namespace BLOGSOCIALUDLA.Views
{
    public partial class PostNodo : ContentPage
    {
        private ObservableCollection<Comentario> comentarios;

        public PostNodo()
        {
            InitializeComponent();
            comentarios = new ObservableCollection<Comentario>();
            listaComentarios.ItemsSource = comentarios;
        }

        protected override async void OnAppearing()
        {
            base.OnAppearing();
            await LoadComentarios();
        }

        //metodo que nos enseñó nuestro pana
        private async Task LoadComentarios()
        {
            List<Comentario> ListaComentarios = await DataComentario.GetComentarios();
            foreach (var comentario in ListaComentarios)
            {
                comentarios.Add(comentario);
            }
        }

        private void OnClickShowDetails(object sender, SelectedItemChangedEventArgs e)
        {
            if (e.SelectedItem == null)
                return;

            var selectedComment = e.SelectedItem as Comentario;

            DisplayAlert("Comentario seleccionado", $"Comentario: {selectedComment.Contenido}", "OK");

            listaComentarios.SelectedItem = null;
        }

        private void ClickComentarioNodo(object sender, EventArgs e)
        {
            string comentarioTexto = comentarioEntry.Text;

            if (string.IsNullOrWhiteSpace(comentarioTexto))
            {
                DisplayAlert("Error", "El comentario no puede estar vacío.", "OK");
                return;
            }

            var nuevoComentario = new Comentario
            {
                Contenido = comentarioTexto
            };

            comentarios.Add(nuevoComentario);

            DisplayAlert("Comentario añadido", "Tu comentario ha sido añadido exitosamente.", "OK");

            comentarioEntry.Text = string.Empty;
        }

        private void ClickPostNodo(object sender, EventArgs e)
        {
            DisplayAlert("Post añadido", "Tu post ha sido añadido exitosamente.", "OK");

        }
    }
}
