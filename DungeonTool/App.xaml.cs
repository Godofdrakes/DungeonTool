using System.Reflection;
using System.Windows;
using DungeonTool.ViewModel;
using ReactiveUI;
using Splat;

namespace DungeonTool
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App
    {
        private void App_OnStartup(object sender, StartupEventArgs e)
        {
            Locator.CurrentMutable.RegisterViewsForViewModels(Assembly.GetExecutingAssembly());

            MainWindow = new MainWindow()
            {
                ViewModel = new MainWindowViewModel()
            };

            MainWindow.Show();
        }

        private void App_OnExit(object sender, ExitEventArgs e)
        {
        }
    }
}