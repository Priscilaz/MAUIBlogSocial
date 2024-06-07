namespace BLOGSOCIALUDLA.Views;

public partial class LoginView : ContentPage
{
	public LoginView()
	{
		InitializeComponent();
	}

    private void ClickLogin(object sender, EventArgs e)
    {
		Navigation.PushAsync(new InicioSesion());
       
    }

    private void ClickRegistro(object sender, EventArgs e)
    {
        Navigation.PushAsync(new RegistroUsuario());
    }
}