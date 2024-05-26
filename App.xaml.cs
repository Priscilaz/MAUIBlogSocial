using BLOGSOCIALUDLA.Views;

namespace BLOGSOCIALUDLA
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

           // MainPage = new LoginView();
            MainPage = new InicioSesion();

            //Registro Cuenta 
            //  MainPage = new PaginaPrincipal();

        }
    }
}
