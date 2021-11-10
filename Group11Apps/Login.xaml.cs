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
using System.Data.SQLite;

namespace Group11Apps
{
    /// <summary>
    /// Interaction logic for Login.xaml
    /// </summary>
    public partial class Login : Window
    {
        public Login()
        {
            InitializeComponent();
        }
        string trangThai = "Active";

        private void Grid_MouseDown(object sender, MouseButtonEventArgs e)
        {

        }
        private void Border_MouseDown(object sender, MouseButtonEventArgs e)
        {
            DragMove();
        }

        private void btnExit_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }
        public void GrantAccess()
        {
            MainWindow sw = new MainWindow();
            sw.lblUsername.Text = txtUsername.Text;
            
            sw.Show();
        }

        private void btnLogin_Click(object sender, RoutedEventArgs e)
        {
            var username = txtUsername.Text;
            var password = txtPassword.Password;

            using (DataContext context = new DataContext())
            {
                bool userfound = context.Users.Any(user => user.Username == username && user.Password == password && user.TrangThai == trangThai);
                bool userban = context.Users.Any(user => user.Username == username && user.Password == password && user.TrangThai == "Banned");
                if (userfound)
                {
                    GrantAccess();
                    Close();
                }
                else if(userban)
                {
                    MessageBox.Show("Tài khoản đã bị ban");
                    clearr();
                }    
                else
                {
                    MessageBox.Show("Tài Khoản hoặc mật khẩu không chính xác");
                    clearr();
                }
            }
        }
        private void clearr()
        {
            txtPassword.Clear();
            txtUsername.Clear();
            txtUsername.Focus();
        }
        
    }
}
