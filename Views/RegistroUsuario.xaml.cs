using Microsoft.Maui.Controls;
using BLOGSOCIALUDLA.Models;
using System;
using System.Linq;

namespace BLOGSOCIALUDLA.Views
{
    public partial class RegistroUsuario : ContentPage
    {
        public RegistroUsuario()
        {
            InitializeComponent();
        }

        private void ClickRegistrarse(object sender, EventArgs e)
        {
            string nombres = Nombres.Text;
            string apellidos = Apellidos.Text;
            string numeroTelefono = NumeroTelefono.Text;
            string correo = Correo.Text;
            string contrasena = Contrasena.Text;

            if (string.IsNullOrEmpty(nombres) || string.IsNullOrEmpty(apellidos) ||
                string.IsNullOrEmpty(numeroTelefono) || string.IsNullOrEmpty(correo) ||
                string.IsNullOrEmpty(contrasena))
            {
                errorMessage.Text = "Por favor, complete todos los campos.";
                errorMessage.IsVisible = true;
                return;
            }

            var newUser = new User
            {
                Username = correo,
                Password = contrasena
            };

            UserData.Users.Add(newUser);

            Application.Current.MainPage.DisplayAlert("Registro Bacan", "Tu usuario registrado exitosamente. Ahora puede iniciar sesión.", "OK");
            Application.Current.MainPage = new NavigationPage(new InicioSesion());
        }

        private void ClickInicioSesionRegistro(object sender, EventArgs e)

        {
            Navigation.PopAsync();
//            Application.Current.MainPage = new NavigationPage(new InicioSesion());
        }
    }
}
