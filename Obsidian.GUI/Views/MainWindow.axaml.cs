using Avalonia;
using Avalonia.Controls;
using Avalonia.Interactivity;
using Avalonia.Markup.Xaml;
using System;

namespace Obsidian.GUI.Views
{
    public class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
#if DEBUG
            //this.AttachDevTools();
#endif
        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }

        public void OP_Click(object sender, RoutedEventArgs e)
        {
            var btn = (Button)sender;
            var playerUuid = Guid.Parse(btn.Tag.ToString());
            MessageBox.Avalonia.MessageBoxManager.GetMessageBoxStandardWindow(new MessageBox.Avalonia.DTO.MessageBoxStandardParams
            {
                ContentMessage = $"OP_Click event executed for {playerUuid}",
                ContentTitle = $"{Title}"
            }).ShowDialog(this);
        }

        public void DEOP_Click(object sender, RoutedEventArgs e)
        {
            var btn = (Button)sender;
            var playerUuid = Guid.Parse(btn.Tag.ToString());
            MessageBox.Avalonia.MessageBoxManager.GetMessageBoxStandardWindow(new MessageBox.Avalonia.DTO.MessageBoxStandardParams
            {
                ContentMessage = $"DEOP_Click event executed for {playerUuid}",
                ContentTitle = $"{Title}"
            }).ShowDialog(this);
        }

        public void Ban_Click(object sender, RoutedEventArgs e)
        {
            var btn = (Button)sender;
            var playerUuid = Guid.Parse(btn.Tag.ToString());
            MessageBox.Avalonia.MessageBoxManager.GetMessageBoxStandardWindow(new MessageBox.Avalonia.DTO.MessageBoxStandardParams
            {
                ContentMessage = $"Ban_Click event executed for {playerUuid}",
                ContentTitle = $"{Title}"
            }).ShowDialog(this);
        }

        public void Kick_Click(object sender, RoutedEventArgs e)
        {
            var btn = (Button)sender;
            var playerUuid = Guid.Parse(btn.Tag.ToString());
            MessageBox.Avalonia.MessageBoxManager.GetMessageBoxStandardWindow(new MessageBox.Avalonia.DTO.MessageBoxStandardParams
            {
                ContentMessage = $"Kick_Click event executed for {playerUuid}",
                ContentTitle = $"{Title}"
            }).ShowDialog(this);
        }
    }
}
