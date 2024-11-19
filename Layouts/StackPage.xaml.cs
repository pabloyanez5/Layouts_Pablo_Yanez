using Layouts.ViewModels;

namespace Layouts;

public partial class StackPage : ContentPage
{
    public StackPage()
    {
        InitializeComponent();
        BindingContext = new MainViewModel();
    }
}
