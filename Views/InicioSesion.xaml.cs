using Microsoft.Maui.Controls;
using System;
using System.Linq;
using BLOGSOCIALUDLA.Data;
using BLOGSOCIALUDLA.ViewModels;

namespace BLOGSOCIALUDLA.Views
{
    public partial class InicioSesion : ContentPage
    {
        public InicioSesion()
        {
            var apiService = new ApiService(new HttpClient());

            BindingContext = new InicioSesionViewModel(apiService);

            InitializeComponent();
        }
    }
}
