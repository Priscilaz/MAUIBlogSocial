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
        public ObservableCollection<Post> Posts { get; set; }

        public PostNodo()
        {
          
            InitializeComponent();
            Posts = new ObservableCollection<Post>(DataPost.Posts);
            BindingContext = this;
        }

        private async void PostPicker_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedPost = (sender as Picker)?.SelectedItem as Post;
            if (selectedPost != null)
            {
                await Navigation.PushAsync(new PostSeleccionado(selectedPost));
            }
        }

        private async void ClickPostNodo(object sender, EventArgs e)
        {
            var nuevaPage = new AddPostPage();
            nuevaPage.PostAgregado += NuevaPage_PostAgregado;
            await Navigation.PushAsync(nuevaPage);
        }

        private void NuevaPage_PostAgregado(object sender, Post e)
        {
            DataPost.AgregarPost(e);
            Posts.Add(e);
        }

        private async void Volver(object sender, EventArgs e)
        {
            await Navigation.PopAsync();
        }

       
    }
}
    

