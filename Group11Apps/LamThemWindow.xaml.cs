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
    /// Interaction logic for LamThemWindow.xaml
    /// </summary>
    public partial class LamThemWindow : Window
    {
        public LamThemWindow()
        {
            InitializeComponent();
        }
        private void LoadData()
        {
            DataContext context = new DataContext();
            context.OpenConnection();
            string query = "Select Id STT, TuNgay [Từ Ngày], DenNgay [Đến Ngày], TuGio [Từ Giờ], DenGio [Đến Giờ], NguoiDangKy [Người Đăng Ký], LyDo [Lý Do]  from LamThem";
            SQLiteCommand createCommand = new SQLiteCommand(query, context.myConnection);
            createCommand.ExecuteNonQuery();
            SQLiteDataAdapter dataAdp = new SQLiteDataAdapter(createCommand);
            DataTable dt = new DataTable("LamThem");
            dataAdp.Fill(dt);
            DataGridXAML.ItemsSource = dt.DefaultView;
            dataAdp.Update(dt);
            context.CloseConnection();
            usernamee.Visibility = Visibility.Hidden;
        }
        private void Grid_Loaded(object sender, RoutedEventArgs e)
        {
            LoadData();
            for (int i = 0; i < 24;)
            {
                if (i < 10)
                {
                    string add = "0" + i.ToString();
                    cboTuGio.Items.Add(add);
                    cboDenGio.Items.Add(add);
                }
                else
                {
                    cboTuGio.Items.Add(i);
                    cboDenGio.Items.Add(i);
                }
                i++;
            }
            for (int j = 0; j < 60;)
            {
                if (j < 10)
                {
                    string add = "0" + j.ToString();
                    cboTuPhut.Items.Add(add);
                    cboDenPhut.Items.Add(add);
                }
                else
                {
                    cboTuPhut.Items.Add(j);
                    cboDenPhut.Items.Add(j);
                }
                j++;
            }
            DataContext context = new DataContext();
            context.OpenConnection();
            string query = "select HoTen from Users";
            SQLiteCommand myCommand = new SQLiteCommand(query, context.myConnection);
            myCommand.ExecuteNonQuery();
            SQLiteDataReader dr = myCommand.ExecuteReader();
            while (dr.Read())
            {
                    string name = dr.GetString(0);
                    cboNguoiDangKy.Items.Add(name);
            }
            context.CloseConnection();
        }

        private void btnBack_Click(object sender, RoutedEventArgs e)
        {
            MainWindow sw = new MainWindow();
            sw.lblUsername.Text = usernamee.Text;
            sw.Show();
            Close();
        }

        private void btnUser_Click(object sender, RoutedEventArgs e)
        {
            AdminWindow sw = new AdminWindow();
            sw.usernamee.Text = usernamee.Text;
            sw.Show();
            Close();
        }

        private void btnThem_Click(object sender, RoutedEventArgs e)
        {
            var tungay = dpTuNgay.SelectedDate.ToString();
            var dengay = dpDenNgay.SelectedDate.ToString();
            var tugio = cboTuGio.Text + ":" + cboTuPhut.Text;
            var dengio = cboDenGio.Text + ":" + cboDenPhut.Text;
            var nguoidangky = cboNguoiDangKy.Text;
            var lydo = txtLyDo.Text;
            DataContext context = new DataContext();
            context.OpenConnection();
            string query = "INSERT INTO [LamThem] (TuNgay,DenNgay, TuGio, DenGio, NguoiDangKy,LyDo) VALUES (@tungay,@denngay,@tugio,@dengio,@nguoidangky,@lydo)";
            SQLiteCommand myCommand = new SQLiteCommand(query, context.myConnection);
            myCommand.Parameters.Add(new SQLiteParameter("@tungay", tungay));
            myCommand.Parameters.Add(new SQLiteParameter("@dengay", dengay)); 
            myCommand.Parameters.Add(new SQLiteParameter("@tugio", tugio)); 
            myCommand.Parameters.Add(new SQLiteParameter("@dengio", dengio)); 
            myCommand.Parameters.Add(new SQLiteParameter("@nguoidangky", nguoidangky)); 
            myCommand.Parameters.Add(new SQLiteParameter("@lydo", lydo)); 
            context.CloseConnection();
            myCommand.ExecuteNonQuery();
            LoadData();

        }
    }
}
