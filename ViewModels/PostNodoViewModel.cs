using BLOGSOCIALUDLA.Data;
using BLOGSOCIALUDLA.Models;
using BLOGSOCIALUDLA.Views;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace BLOGSOCIALUDLA.ViewModels
{
    public class PostNodoViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler? PropertyChanged;
        public ObservableCollection<Post> Posts { get; set; }
        public ICommand AddPostCommand { get; }
        public ICommand PostSelectedCommand { get; }
        public ICommand BackCommand { get; }
        private Post _selectedPost;
        public Post SelectedPost
        {
            get => _selectedPost;
            set
            {
                if (_selectedPost != value)
                {
                    _selectedPost = value;
                    OnPropertyChanged();
                    PostSelectedCommand.Execute(_selectedPost);
                }
            }
        }

        public PostNodoViewModel()
        {
            Posts = new ObservableCollection<Post>(DataPostNodo.PostsNodo);
            AddPostCommand = new Command(async () => await OnAddPost());
            PostSelectedCommand = new Command<Post>(async (post) => await OnPostSelected(post));
            BackCommand = new Command(async () => await OnBack());
        }
        private async Task OnAddPost()
        {
            //funcionamiento del picker para poder elefir le post
            var nuevaPage = new AddPostPage();
            nuevaPage.PostAgregado += NuevaPage_PostAgregado;
            await Application.Current.MainPage.Navigation.PushAsync(nuevaPage);
        }

        private void NuevaPage_PostAgregado(object sender, Post e)
        {
            DataPostNodo.AgregarPostNodo(e);
            Posts.Add(e);
        }

        private async Task OnPostSelected(Post selectedPost)
        {
            if (selectedPost != null)
            {
                await Application.Current.MainPage.Navigation.PushAsync(new PostSeleccionado(selectedPost));
            }
        }

        private async Task OnBack()
        {
            await Application.Current.MainPage.Navigation.PopAsync();
        }
        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }






    }
}
