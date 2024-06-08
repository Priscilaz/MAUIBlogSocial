namespace BLOGSOCIALUDLA.Views;
using BLOGSOCIALUDLA.Models;
using System.Collections.ObjectModel;

public partial class PostFica : ContentPage
{
    private ObservableCollection<Comentario> comentarios;

    public PostFica()
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

    private void ClickComentarioFica(object sender, EventArgs e)
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

    private void ClickPostFica(object sender, EventArgs e)
    {
        DisplayAlert("Post añadido", "Tu post ha sido añadido exitosamente.", "OK");

    }

   
}