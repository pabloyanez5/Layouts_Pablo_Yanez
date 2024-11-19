using Layouts.ViewModels;

namespace Layouts;

public partial class FlexPage : ContentPage
{
    public FlexPage()
    {
        InitializeComponent();
        BindingContext = new MainViewModel();
    }
}
