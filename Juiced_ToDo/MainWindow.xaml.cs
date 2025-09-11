using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Juiced_ToDo
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            loginContext loginContext = new loginContext();
            ObservableCollection<taskModel> taskList = new ObservableCollection<taskModel>();

            LoginWindow loginWindow = new LoginWindow(ref loginContext);
            loginWindow.ShowDialog();
            if(loginContext.getIsLoggedIn() == false)
            {
                MessageBox.Show("Logowanie nie powiodło się.\nAplikacja teraz zostanie zamknięta.", "Nie Zalogowano", MessageBoxButton.OK, MessageBoxImage.Warning);
                Application.Current.Shutdown();
            }
            InitializeComponent();
            Console.WriteLine("Init.");
        }
    }
}
