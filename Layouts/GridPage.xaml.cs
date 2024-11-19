using Layouts.ViewModels;

namespace Layouts;

public partial class GridPage : ContentPage
{
    public GridPage()
    {
        InitializeComponent();
        BindingContext = new MainViewModel();
    }
}
