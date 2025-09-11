using System;
using System.Collections.Generic;
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
using System.Windows.Shapes;

namespace Juiced_ToDo
{
    public partial class LoginWindow : Window
    {
        private loginContext loginContextLocalRef;
        public LoginWindow(ref loginContext loginContext)
        {
            InitializeComponent();
            loginContextLocalRef = loginContext;
        }
        public void LoginSucceeded(ref loginContext loginContext)
        {
            loginContext.setIsLoggedIn(true);
        }

        private void LoginButtonClicked(object sender, RoutedEventArgs e)
        {
            String email_address = tbemail_address.Text;
            String password = tbpassword.Text;

            if(email_address == String.Empty || password == String.Empty)
            {
                MessageBox.Show("Wypełnij wszystkie pola.", "Błąd", MessageBoxButton.OK, MessageBoxImage.Warning);
                return;
            }
            //db fetch and login logic happens here
            loginContextLocalRef.setIsLoggedIn(true);
            loginContextLocalRef.setEmailAddress("xyz@example.com");
            loginContextLocalRef.setUserID(0xBEEF);


        }
    }
}