using Microsoft.Maui.Controls;
using System.Windows.Input;

namespace Layouts.ViewModels
{
    internal class MainViewModel
    {
        public ICommand GoToGridPageCommand { get; }
        public ICommand GoToStackPageCommand { get; }
        public ICommand GoToFlexPageCommand { get; }
        public ICommand GoToAbsolutePageCommand { get; }

        public MainViewModel()
        {
            GoToGridPageCommand = new Command(async () => await Shell.Current.GoToAsync("///GridPage"));
            GoToStackPageCommand = new Command(async () => await Shell.Current.GoToAsync("///StackPage"));
            GoToFlexPageCommand = new Command(async () => await Shell.Current.GoToAsync("///FlexPage"));
            GoToAbsolutePageCommand = new Command(async () => await Shell.Current.GoToAsync("///AbsolutePage"));
        }
    }
}
