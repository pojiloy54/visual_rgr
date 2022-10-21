using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using Avalonia.Interactivity;
using Footbool.ViewModels;

namespace Footbool.Views
{
    public partial class SecondView : UserControl
    {
        public SecondView()
        {
            InitializeComponent();
            this.FindControl<Button>("Select").Click += ClickEventSelect;
            this.FindControl<Button>("Join").Click += ClickEventJoin;
            this.FindControl<Button>("Group").Click += ClickEventGroup;
        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }
        private async void ClickEventSelect(object? sender, RoutedEventArgs e)
        {
            var window = new SelectDBView((this.DataContext as SecondViewModel).MainContext);
            await window.ShowDialog((Window)this.VisualRoot);
        }
        private async void ClickEventJoin(object? sender, RoutedEventArgs e)
        {
            var window = new JoinDBView((this.DataContext as SecondViewModel).MainContext);
            await window.ShowDialog((Window)this.VisualRoot);
        }
        private async void ClickEventGroup(object? sender, RoutedEventArgs e)
        {
            var window = new GroupDBView((this.DataContext as SecondViewModel).MainContext);
            await window.ShowDialog((Window)this.VisualRoot);
        }
    }
}
