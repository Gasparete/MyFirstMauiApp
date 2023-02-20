using MyFirstMauiApp.ViewModel;

namespace MyFirstMauiApp;

public partial class MainPage : ContentPage
{
	public MainPage(MainViewModel vm)
	{
		InitializeComponent();
		BindingContext = vm; // With Injection Dependency

        // Similar way to do
        // BindingContext = new MainViewModel();
    }
}

