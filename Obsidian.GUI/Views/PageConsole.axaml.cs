using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;

namespace Obsidian.GUI.Views
{
    public class PageConsole : UserControl
    {
        public PageConsole()
        {
            this.InitializeComponent();
        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }
    }
}
