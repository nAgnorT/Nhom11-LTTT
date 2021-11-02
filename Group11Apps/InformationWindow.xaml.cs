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
using System.Windows.Shapes;

namespace Group11Apps
{
    /// <summary>
    /// Interaction logic for InformationWindow.xaml
    /// </summary>
    public partial class InformationWindow : Window
    {
        public InformationWindow()
        {
            InitializeComponent();
        }
        private void getName()
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
                    txtHoTen.Text = dr.GetString(0);
                }
            }
            context.CloseConnection();
        }
        private string getPassword()
        {
            string password = "";
            var username = lblUsername.Text;
            DataContext context = new DataContext();
            context.OpenConnection();
            string query = "select Password from Users where Username = @username";
            SQLiteCommand myCommand = new SQLiteCommand(query, context.myConnection);
            myCommand.Parameters.AddWithValue("@username", username);
            myCommand.ExecuteNonQuery();
            using (SQLiteDataReader dr = myCommand.ExecuteReader())
            {
                bool success = dr.Read();
                if (success)
                {
                    password = dr.GetString(0);
                }
            }
            context.CloseConnection();
            return password;
        }
        private void doiPassword()
        {
            string name = lblUsername.Text;
            string newpassword = txtNewPassword.Password;
            DataContext context = new DataContext();
            context.OpenConnection();
            string query = "UPDATE Users SET Password = @pass Where Username=@name";
            SQLiteCommand myCommand = new SQLiteCommand(query, context.myConnection);
            myCommand.Parameters.AddWithValue("@name", name);
            myCommand.Parameters.AddWithValue("@pass", newpassword );
            myCommand.ExecuteNonQuery();
            context.CloseConnection();
        }

        private void btnLuu_Click(object sender, RoutedEventArgs e)
        {
            DataContext context = new DataContext();
            context.OpenConnection();
            string name = lblUsername.Text;
            string hoten = txtHoTen.Text;
            if((txtPassword.Password == getPassword() && txtPassword.Password == txtNewPassword.Password)  || txtNewPassword.Password=="" || txtPassword.Password=="" || txtPassword.Password != getPassword())
            {
                string query = "UPDATE Users SET HoTen = @hoten Where Username=@name";
                SQLiteCommand myCommand = new SQLiteCommand(query, context.myConnection);
                myCommand.Parameters.AddWithValue("@name", name);
                myCommand.Parameters.AddWithValue("@hoten", hoten);
                myCommand.ExecuteNonQuery();
            }
            else
            {
                doiPassword();
            }
            context.CloseConnection();
            getName();
            MessageBox.Show("Đã Lưu thông tin");
        }

        private void btnThoat_Click(object sender, RoutedEventArgs e)
        {
            MainWindow sw = new MainWindow();
            sw.lblUsername.Text = lblUsername.Text;
            sw.Show();
            Close();
        }
    }
}
