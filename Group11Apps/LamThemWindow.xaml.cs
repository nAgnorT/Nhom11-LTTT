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
using System.Windows.Navigation;
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
        public DateTime now = DateTime.Now;
        private void LoadData()
        {
            DataContext context = new DataContext();
            context.OpenConnection();
            string query = "Select Id STT, TuNgay [Từ Ngày], DenNgay [Đến Ngày], NguoiDangKy [Người Đăng Ký], LyDo [Lý Do]  from LamThem";
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
        private void LoadCboDate()
        {
            cboDenNgay.Items.Clear();
            cboTuNgay.Items.Clear();
            int day = now.Day;
            for(int i =day; i < 31;)
            {
                if (i < 10)
                {
                    string add = "0" + i.ToString();
                    cboTuNgay.Items.Add(add);
                    cboDenNgay.Items.Add(add);
                }
                else
                {
                    cboTuNgay.Items.Add(i);
                    cboDenNgay.Items.Add(i);
                }
                i++;
            }
            
        }
        private void Grid_Loaded(object sender, RoutedEventArgs e)
        {
            LoadData();
            LoadCboDate();
            cboTuThang.Items.Clear();
            cboDenThang.Items.Clear();
            cboTuThang.Items.Add(now.Month);
            cboTuThang.Items.Add(now.Month + 1);
            cboDenThang.Items.Add(now.Month);
            cboDenThang.Items.Add(now.Month + 1);
            btnThem.IsEnabled = true;
            btnSua.IsEnabled = false;
            btnXoa.IsEnabled = false;
            int day = now.Day;
            cboTuNgay.SelectedItem = "0" + day.ToString();
            cboDenNgay.SelectedItem = "0" + day.ToString();
            cboTuThang.SelectedItem = now.Month;
            cboDenThang.SelectedItem = now.Month;
            
             
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
            TuNgay.Text = cboTuNgay.Text + "/"+cboTuThang.Text;
            DenNgay.Text = cboDenNgay.Text + "/" + cboDenThang.Text;
            var tuNgay = TuNgay.Text;
            var denNgay = DenNgay.Text;
            var nguoiDangky = cboNguoiDangKy.Text;
            var lyDo = txtLyDo.Text;
            using (DataContext context = new DataContext())
            {
                bool overtimeFound = context.LamThem.Any(extra => extra.DenNgay == denNgay && extra.TuNgay == tuNgay && extra.NguoiDangKy == nguoiDangky);
                if(overtimeFound)
                {
                    MessageBox.Show("Không hợp lệ");
                }    
                else if (tuNgay=="/" || denNgay=="/" || nguoiDangky=="")
                {
                    MessageBox.Show("Không hợp lệ");
                }
                else
                {
                    context.OpenConnection();
                    string query = "INSERT INTO LamThem (`TuNgay`, `DenNgay`, `NguoiDangKy`, `LyDo`) VALUES (@tungay, @denngay, @nguoidangky, @lydo)";
                    SQLiteCommand myCommand = new SQLiteCommand(query, context.myConnection);
                    
                    myCommand.Parameters.AddWithValue("@tungay", tuNgay);
                    myCommand.Parameters.AddWithValue("@denngay", denNgay);
                    myCommand.Parameters.AddWithValue("@nguoidangky", nguoiDangky);
                    myCommand.Parameters.AddWithValue("@lydo", lyDo);
                    myCommand.ExecuteNonQuery();
                    context.CloseConnection();
                    
                }
            }    
            
            LoadData();

        }

        private void cboTuThang_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (cboTuThang.SelectedItem.ToString()=="12")
            {
                cboTuNgay.Items.Clear();
                for (int i = 1; i < 32;)
                {
                    if (i < 10)
                    {
                        cboTuNgay.Items.Add("0" + i.ToString());
                    }
                    else
                    {
                        cboTuNgay.Items.Add(i);
                    }
                    i++;
                }
            }
            else
            {
                cboTuNgay.Items.Clear();
                for (int i = now.Day; i < 31;)
                {
                    if (i < 10)
                    {
                        cboTuNgay.Items.Add("0" + i.ToString());
                    }
                    else
                    {
                        cboTuNgay.Items.Add(i);
                    }
                    i++;
                }
            }    
        }

        private void cboDenThang_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (cboDenThang.SelectedItem.ToString() == "12")
            {
                cboDenNgay.Items.Clear();
                for (int i = 1; i < 32;)
                {
                    if (i < 10)
                    {
                        cboDenNgay.Items.Add("0" + i.ToString());
                    }
                    else
                    {
                        cboDenNgay.Items.Add(i);
                    }
                    i++;
                }
            }
            else
            {
                cboDenNgay.Items.Clear();
                for (int i = now.Day; i < 31;)
                {
                    if (i < 10)
                    {
                        cboDenNgay.Items.Add("0" + i.ToString());
                    }
                    else
                    {
                        cboDenNgay.Items.Add(i);
                    }
                    i++;
                }
            }
        }

        private void DataGridXAML_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            DataGrid dg = sender as DataGrid;
            DataRowView dr = dg.SelectedItem as DataRowView;
            if (dr != null)
            {
                string[] fromDate = dr["Từ Ngày"].ToString().Split("/");
                string[] toDate = dr["Đến Ngày"].ToString().Split("/");
                cboNguoiDangKy.SelectedItem = dr["Người Đăng Ký"];
                txtLyDo.Text = dr["Lý Do"].ToString();
                cboTuNgay.SelectedItem = fromDate[0];
                cboTuThang.SelectedItem = fromDate[1];
                cboDenNgay.SelectedItem = toDate[0];
                cboDenThang.SelectedItem = toDate[1];
                btnThem.IsEnabled = false;
                btnSua.IsEnabled = true;
                btnXoa.IsEnabled = true;
                STT.Text = dr["STT"].ToString();
            }
        }

        private void btnSua_Click(object sender, RoutedEventArgs e)
        {
            TuNgay.Text = cboTuNgay.Text + "/" + cboTuThang.Text;
            DenNgay.Text = cboDenNgay.Text + "/" + cboDenThang.Text;
            var tuNgay = TuNgay.Text;
            var denNgay = DenNgay.Text;
            var nguoiDangky = cboNguoiDangKy.Text;
            var lyDo = txtLyDo.Text;
            int stt = int.Parse(STT.Text);
            using (DataContext context = new DataContext())
            {
                bool overtimeFound = context.LamThem.Any(extra => extra.DenNgay == denNgay && extra.TuNgay == tuNgay && extra.NguoiDangKy == nguoiDangky);
                if (overtimeFound)
                {
                    MessageBox.Show("Không hợp lệ");
                }
                else if (tuNgay == "/" || denNgay == "/" || nguoiDangky == "")
                {
                    MessageBox.Show("Không hợp lệ");
                }
                else
                {
                    context.OpenConnection();
                    string query = "UPDATE LamThem SET TuNgay=@tungay ,DenNgay=@denngay, NguoiDangKy=@nguoidangky, LyDo=@lydo Where Id=@stt";
                    SQLiteCommand myCommand = new SQLiteCommand(query, context.myConnection);
                    myCommand.Parameters.AddWithValue("@tungay", tuNgay);
                    myCommand.Parameters.AddWithValue("@denngay", denNgay);
                    myCommand.Parameters.AddWithValue("@nguoidangky", nguoiDangky);
                    myCommand.Parameters.AddWithValue("@lydo", lyDo);
                    myCommand.Parameters.AddWithValue("@stt", stt);
                    myCommand.ExecuteNonQuery();
                    context.CloseConnection();

                }
            }

            LoadData();
        }

        private void btnXoa_Click(object sender, RoutedEventArgs e)
        {
            TuNgay.Text = cboTuNgay.Text + txtDauCheo.Text + cboTuThang.Text;
            DenNgay.Text = cboDenNgay.Text + txtDauCheo.Text + cboDenThang.Text;
            var tuNgay = TuNgay.Text;
            var denNgay = DenNgay.Text;
            var nguoiDangky = cboNguoiDangKy.Text;
            var lyDo = txtLyDo.Text;
            int stt = int.Parse(STT.Text);
            using (DataContext context = new DataContext())
            {
                bool overtimeFound = context.LamThem.Any(extra => extra.Id == stt);
                if (overtimeFound)
                {
                    context.OpenConnection();
                    string query = "DELETE FROM LamThem WHERE Id=@stt";
                    SQLiteCommand myCommand = new SQLiteCommand(query, context.myConnection);
                    myCommand.Parameters.AddWithValue("@stt", stt);
                    myCommand.ExecuteNonQuery();
                    context.CloseConnection();
                    
                }
                else if (tuNgay == "/" || denNgay == "/" || nguoiDangky == "")
                {
                    MessageBox.Show("Không hợp lệ");
                }
                else
                {
                    MessageBox.Show("Không hợp lệ");

                }
                LoadData();
            }
        }
    }
}
