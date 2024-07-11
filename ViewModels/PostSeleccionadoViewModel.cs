using BLOGSOCIALUDLA.Models;
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
    public class PostSeleccionadoViewModel: INotifyPropertyChanged
    {
        private Post _post;
        public ObservableCollection<Comentario> Comentarios { get; set; }
        public string Titulo => _post.Titulo;
        public string Contenido => _post.Contenido;
        public DateTime Fecha => _post.FechaPublicacion;

        public ICommand EnviarComentarioCommand { get; }

        public PostSeleccionadoViewModel(Post post)
        {
            _post = post;
            Comentarios = new ObservableCollection<Comentario>(post.Comentarios);
            EnviarComentarioCommand = new Command(EnviarComentario);
        }

        private void EnviarComentario()
        {
            if (!string.IsNullOrWhiteSpace(NuevoComentario))
            {
                var nuevoComentario = new Comentario
                {
                    Contenido = NuevoComentario,
                    Fecha = DateTime.Now
                };

                _post.Comentarios.Add(nuevoComentario);
                Comentarios.Add(nuevoComentario);

                NuevoComentario = string.Empty;
                OnPropertyChanged(nameof(NuevoComentario));
            }
        }

        private string _nuevoComentario;

        public event PropertyChangedEventHandler? PropertyChanged;

        public string NuevoComentario
        {
            get => _nuevoComentario;
            set
            {
                _nuevoComentario = value;
                OnPropertyChanged();
            }
        }
        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }


    }
}
