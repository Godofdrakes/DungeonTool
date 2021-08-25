using System;
using System.Collections.Generic;
using System.Linq;
using System.Reactive.Disposables;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using DungeonTool.ViewModel;
using ReactiveUI;
using Splat;

namespace DungeonTool
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow
    {
        public MainWindow()
        {
            InitializeComponent();

            this.WhenActivated(disposable =>
            {
                this.OneWayBind(ViewModel, model => model.Router, self => self.RoutedViewHost.Router);

                ViewModel!.Router.CurrentViewModel.Subscribe(model =>
                {
                    RouterStatus.Text =
                        $"Current: {model?.GetType()}, Depth: {ViewModel!.Router.NavigationStack.Count}";
                }).DisposeWith(disposable);
                
                Locator.CurrentMutable.Register(() => ViewModel, typeof(IScreen));

                ViewModel!.Router.Navigate.Execute(new FrontendViewModel());
            });
        }
    }
}