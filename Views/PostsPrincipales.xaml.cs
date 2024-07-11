using BLOGSOCIALUDLA.ViewModels;

namespace BLOGSOCIALUDLA.Views;

public partial class PostsPrincipales : ContentPage
{
	public PostsPrincipales()
	{
		InitializeComponent();
		BindingContext = new PostFicaViewModel();
	}
}