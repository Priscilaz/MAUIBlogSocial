using BLOGSOCIALUDLA.Models;
using BLOGSOCIALUDLA.Models.BLOGSOCIALUDLA.Models;
using Microsoft.Maui.Controls;
using System;
using System.Linq;

namespace BLOGSOCIALUDLA.Views
{
    public partial class UsuarioView : ContentPage
    {
        private User _currentUser;

        public UsuarioView(string username)
        {
            InitializeComponent();
            DatosDelUsuario(username);
        }

        private void DatosDelUsuario(string username)
        {
            _currentUser = UserData.Users.FirstOrDefault(user => user.Username == username);

            if (_currentUser != null)
            {
                NombresLabel.Text = _currentUser.Nombres;
                ApellidosLabel.Text = _currentUser.Apellidos;
                NumeroTelefonoLabel.Text = _currentUser.NumeroTelefono;
                CorreoLabel.Text = _currentUser.Username;
            }
            else
            {
                DisplayAlert("Error", "Usuario no encontrado.", "OK");
            }
        }
    }
}
