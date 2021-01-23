using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;

namespace Obsidian.GUI.Views
{
    public class PageSummary : UserControl
    {
        public PageSummary()
        {
            this.InitializeComponent();
            Globals.ObsidianServer.StartServer(0);
        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }
    }
}
