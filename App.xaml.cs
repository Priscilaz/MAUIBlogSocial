using BLOGSOCIALUDLA.Views;

namespace BLOGSOCIALUDLA
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new LoginView();

            //Registro Cuenta 
            MainPage = new RegistroCuenta();

        }
    }
}
