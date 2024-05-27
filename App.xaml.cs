using BLOGSOCIALUDLA.Views;

namespace BLOGSOCIALUDLA
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            var navPage= new NavigationPage(new LoginView());
            navPage.Background = Colors.DarkRed;
            navPage.BarTextColor = Colors.DarkRed;

           MainPage = navPage;
            //MainPage = new InicioSesion();

            //Registro Cuenta 
            //  MainPage = new PaginaPrincipal();

            //RegistroCuenta
            //MainPage = new RegistroUsuario();

        }
    }
}
