using Microsoft.Maui.Controls;
using BLOGSOCIALUDLA.Models;
using System;
using System.Linq;
using BLOGSOCIALUDLA.Models.BLOGSOCIALUDLA.Models;

namespace BLOGSOCIALUDLA.Views
{
    public partial class InicioSesion : ContentPage
    {
        public InicioSesion()
        {
            InitializeComponent();
        }

        private void ClickIngreso(object sender, EventArgs e)
        {
            string username = usernameEntry.Text;
            string password = passwordEntry.Text;

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                errorMessage.Text = "Por favor, ingrese nombre de usuario y contraseña.";
                errorMessage.IsVisible = true;
                return;
            }

            var user = UserData.Users.FirstOrDefault(u => u.Username == username && u.Password == password);
            if (user != null)
            {
                Application.Current.MainPage = new NavigationPage(new GaleriaServicios());
            }
            else
            {
                errorMessage.Text = "Nombre de usuario o contraseña incorrectos.";
                errorMessage.IsVisible = true;
            }
        }

        private async void ClickRegistroInicio(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new RegistroUsuario());

        }
    }
}
