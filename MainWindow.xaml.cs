using System.Windows;
using System.Windows.Input;
using ShoppingApp.Core;
using ShoppingApp.Core.Services;

namespace ShoppingApp
{
    public partial class MainWindow : Window, IMessageService
    {
        private MainWindow mainWindowInstance;
        public MainWindow()
        {
            InitializeComponent();

            DataContext = new MainWindowViewModel(this);

            mainWindowInstance = (MainWindow)Application.Current.MainWindow;
        }
        private void Window_MouseDown(object sender, MouseButtonEventArgs e)
        {
            this.DragMove();
        }


        public void CloseApplication()
        {
            App.Current.Shutdown();
        }

        public void MinimalizeApplication()
        {
            WindowState = WindowState.Minimized;
        }
    }
}
