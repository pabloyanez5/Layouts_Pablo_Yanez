using Microsoft.Maui.Controls;
using System.Windows.Input;

namespace Layouts.ViewModels
{
    internal class MainViewModel
    {
        // Comandos para navegar entre las páginas
        public ICommand GoToGridPageCommand { get; }
        public ICommand GoToStackPageCommand { get; }
        public ICommand GoToFlexPageCommand { get; }
        public ICommand GoToAbsolutePageCommand { get; }

        // Constructor donde se inicializan los comandos
        public MainViewModel()
        {
            GoToGridPageCommand = new Command(() => Shell.Current.GoToAsync(nameof(GridPage)));
            GoToStackPageCommand = new Command(() => Shell.Current.GoToAsync(nameof(StackPage)));
            GoToFlexPageCommand = new Command(() => Shell.Current.GoToAsync(nameof(FlexPage)));
            GoToAbsolutePageCommand = new Command(() => Shell.Current.GoToAsync(nameof(AbsolutePage)));
        }
    }
}
