namespace BLOGSOCIALUDLA.Views;

public partial class InicioSesion : ContentPage
{
	public InicioSesion()
	{
		InitializeComponent();
	}

    private void ClickIngreso(object sender, EventArgs e)
    {
		Navigation.PushAsync(new PaginaPrincipal());
    }

    private void ClickRegistroInicio(object sender, EventArgs e)
    {
        Navigation.PushAsync(new RegistroUsuario());
    }
}