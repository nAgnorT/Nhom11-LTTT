using System;
using System.Collections.Generic;
using System.Data.SQLite;
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

namespace Group11Apps
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        public string quyen = "Nhân viên";
        private void btnExit_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void Grid_Loaded(object sender, RoutedEventArgs e)
        {
            var username = lblUsername.Text;
            DataContext context = new DataContext();
            context.OpenConnection();
            string query = "select HoTen from Users where Username = @username";
            SQLiteCommand myCommand = new SQLiteCommand(query, context.myConnection);
            myCommand.Parameters.AddWithValue("@username", username);
            myCommand.ExecuteNonQuery();
            using (SQLiteDataReader dr = myCommand.ExecuteReader())
            {
                bool success = dr.Read();
                if (success)
                {
                    lblHoTen.Text = dr.GetString(0);
                }
            }
            string query2 = "select Quyen from Users where Username = @username";
            SQLiteCommand command = new SQLiteCommand(query2, context.myConnection);
            command.Parameters.AddWithValue("@username", username);
            command.ExecuteNonQuery();
            using (SQLiteDataReader dd = command.ExecuteReader())
            {
                bool success = dd.Read();
                if (success)
                {
                    quyen = dd.GetString(0);
                    if (quyen == "Admin")
                    {
                        btnAdmin.IsEnabled = true;
                    }
                    else
                    {
                        btnAdmin.IsEnabled = false;
                    }
                }
            }
            context.CloseConnection();
               
        }


        private void btnAdmin_Click(object sender, RoutedEventArgs e)
        {
            AdminWindow sw = new AdminWindow();
            sw.usernamee.Text = lblUsername.Text;
            sw.Show();
            Close();
        }

        private void btnTaiKhoan_Click(object sender, RoutedEventArgs e)
        {
            InformationWindow sw = new InformationWindow();
            sw.lblUsername.Text = lblUsername.Text;
            sw.txtHoTen.Text = lblHoTen.Text;
            sw.Show();
            Close();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Login sw = new Login();
            sw.Show();
            Close();
        }
    }
}
