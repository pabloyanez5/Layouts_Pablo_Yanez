using Layouts.ViewModels;

namespace Layouts;

public partial class AbsolutePage : ContentPage
{
    public AbsolutePage()
    {
        InitializeComponent();
        BindingContext = new MainViewModel();
    }
}
