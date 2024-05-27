namespace BLOGSOCIALUDLA.Views;

public partial class RegistroUsuario : ContentPage
{
	public RegistroUsuario()
	{
		InitializeComponent();
	}

	private void ClickInicioSesionRegistro(object sender, EventArgs e)
	{
		Navigation.PushAsync(new InicioSesion());
	}
}