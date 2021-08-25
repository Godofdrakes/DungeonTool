using ReactiveUI;

namespace DungeonTool.ViewModel
{
    public class MainWindowViewModel : ViewModelBase, IScreen
    {
        public RoutingState Router { get; }

        public MainWindowViewModel()
        {
            Router = new RoutingState();
        }
    }
}