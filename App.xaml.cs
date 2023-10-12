using System.Windows;
using TicTacToeTest.Stores;
using TicTacToeTest.ViewModels;

namespace TicTacToeTest
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            MainWindow = new MainWindow()
            {
                DataContext = new BoardViewModel(new CurrentPlayerStore())
            };
            MainWindow.Show();
            base.OnStartup(e);
        }
    }
}
