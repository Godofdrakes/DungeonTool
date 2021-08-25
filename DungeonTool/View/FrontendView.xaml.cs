using System.Windows.Controls;
using ReactiveUI;

namespace DungeonTool.View
{
    public partial class FrontendView
    {
        public FrontendView()
        {
            InitializeComponent();

            this.WhenActivated(disposable =>
            {
                TextBlock.Text = ViewModel!.GetType().ToString();
            });
        }
    }
}