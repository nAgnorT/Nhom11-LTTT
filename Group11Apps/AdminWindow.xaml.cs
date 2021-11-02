using System;
using System.Collections.Generic;
using System.Data;
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
    /// Interaction logic for AdminWindow.xaml
    /// </summary>
    public partial class AdminWindow : Window
    {
        public AdminWindow()
        {
            InitializeComponent();
        }
        private void LoadData()
        {
            DataContext context = new DataContext();
            context.OpenConnection();
            string query = "Select Username [Tài Khoản], HoTen [Họ và Tên], Quyen [Chức vụ], TrangThai [Trạng Thái] from Users";
            SQLiteCommand createCommand = new SQLiteCommand(query, context.myConnection);
            createCommand.ExecuteNonQuery();
            SQLiteDataAdapter dataAdp = new SQLiteDataAdapter(createCommand);
            DataTable dt = new DataTable("Users");
            dataAdp.Fill(dt);
            DataGridXAML.ItemsSource = dt.DefaultView;
            dataAdp.Update(dt);
            context.CloseConnection();
            usernamee.Visibility= Visibility.Hidden;
        }
        private void Grid_Loaded(object sender, RoutedEventArgs e)
        {
            cboQuyen.Items.Add("Admin");
            cboQuyen.Items.Add("Nhân viên");
            LoadData();
            btnXoa.IsEnabled = false;
            btnBan.IsEnabled = false;
            btnActive.IsEnabled = false;
            btnSua.IsEnabled = false;
        }
        private void DataGridXAML_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            DataGrid dg = sender as DataGrid;
            DataRowView dr = dg.SelectedItem as DataRowView;
            if (dr != null)
            {
                lblUsername.Text = dr["Tài Khoản"].ToString();
                txtHoTen.Text = dr["Họ và Tên"].ToString();
                cboQuyen.Text = dr["Chức vụ"].ToString();
                btnXoa.IsEnabled = true;
                btnBan.IsEnabled = true;
                btnSua.IsEnabled = true;
                btnActive.IsEnabled = true;
            }
        }

        private void cboQuyen_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void btnSua_Click(object sender, RoutedEventArgs e)
        {
            DataContext context = new DataContext();
            context.OpenConnection();
            string name = lblUsername.Text;
            string quyen = cboQuyen.Text;
            string hoten = txtHoTen.Text;
            string query = "UPDATE Users SET HoTen = @hoten, Quyen = @quyen Where Username=@name";
            SQLiteCommand myCommand = new SQLiteCommand(query, context.myConnection);
            myCommand.Parameters.AddWithValue("@name", name);
            myCommand.Parameters.AddWithValue("@quyen", quyen);
            myCommand.Parameters.AddWithValue("@hoten", hoten);
            myCommand.ExecuteNonQuery();
            context.CloseConnection();
            LoadData();
        }

        private void btnBan_Click(object sender, RoutedEventArgs e)
        {
            DataContext context = new DataContext();
            context.OpenConnection();
            string name = lblUsername.Text;
            string query = "UPDATE Users SET TrangThai='Banned' Where Username=@name";
            SQLiteCommand myCommand = new SQLiteCommand(query, context.myConnection);
            myCommand.Parameters.AddWithValue("@name", name);
            myCommand.ExecuteNonQuery();
            context.CloseConnection();
            LoadData();
        }

        private void btnActive_Click(object sender, RoutedEventArgs e)
        {
            DataContext context = new DataContext();
            context.OpenConnection();
            string name = lblUsername.Text;
            string query = "UPDATE Users SET TrangThai='Active' Where Username=@name";
            SQLiteCommand myCommand = new SQLiteCommand(query, context.myConnection);
            myCommand.Parameters.AddWithValue("@name", name);
            myCommand.ExecuteNonQuery();
            context.CloseConnection();
            LoadData();
        }

        private void btnXoa_Click(object sender, RoutedEventArgs e)
        {
            DataContext context = new DataContext();
            context.OpenConnection();
            string name = lblUsername.Text;
            string query = "DELETE From Users Where Username=@name";
            SQLiteCommand myCommand = new SQLiteCommand(query, context.myConnection);
            myCommand.Parameters.AddWithValue("@name", name);
            myCommand.ExecuteNonQuery();
            context.CloseConnection();
            LoadData();
        }

        private void btnBack_Click(object sender, RoutedEventArgs e)
        {
            MainWindow sw = new MainWindow();
            sw.lblUsername.Text = usernamee.Text;
            sw.Show();
            Close();
        }

        private void btnOverTime_Click(object sender, RoutedEventArgs e)
        {
            LamThemWindow sw = new LamThemWindow();
            sw.usernamee.Text = usernamee.Text;
            sw.Show();
            Close();
        }
    }
}
