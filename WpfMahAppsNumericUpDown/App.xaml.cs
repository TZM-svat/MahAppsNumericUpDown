using System.Windows;

namespace WpfMahAppsNumericUpDown
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs args)
        {
            var vm = new MainWindowViewModel();
            var v = new MainWindow();
            v.DataContext = vm;
            v.ShowDialog();
        }
    }
}
