using System;
using ReactiveUI;
using Splat;

namespace DungeonTool.ViewModel
{
    public abstract class RoutableViewModelBase : ViewModelBase, IRoutableViewModel
    {
        public string UrlPathSegment => GetType().ToString();

        public IScreen HostScreen { get; }

        protected RoutableViewModelBase()
        {
            HostScreen = Locator.Current.GetService<IScreen>() ?? throw new InvalidOperationException();
        }
    }
}