using System.Windows;
using DataTemplates.ViewModel;

namespace DataTemplates
{
    /// <summary>
    ///     Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);

            var viewModel = new RobotDataViewModel();
            var view = new RobotsDataWindow() { DataContext = viewModel };
            view.Show();
        }
    }
}