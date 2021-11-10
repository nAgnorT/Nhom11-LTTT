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

namespace Group11Apps
{
    /// <summary>
    /// Interaction logic for SearchWindow.xaml
    /// </summary>
    public partial class SearchWindow : Window
    {
        public SearchWindow()
        {
            InitializeComponent();
        }
        public DateTime now = DateTime.Now;
        private void LoadCboDate()
        {
            cboDenNgay.Items.Clear();
            cboTuNgay.Items.Clear();
            int day = now.Day;
            for (int i = day; i < 31;)
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
        private void btnTimKiem_Click(object sender, RoutedEventArgs e)
        {

            DataContext context = new DataContext();
            if ( cboDenNgay.Text=="" || cboDenThang.Text=="" ||cboTuNgay.Text==""|| cboTuThang.Text=="")
            {
                MessageBox.Show("Lỗi");
            }
            else
            {
                int tungay = int.Parse(cboTuNgay.Text);
                int tuthang = int.Parse(cboTuThang.Text);
                int denngay = int.Parse(cboDenNgay.Text);
                int denthang = int.Parse(cboDenThang.Text);
                string query = "Select Id STT, TuNgay [Từ Ngày], DenNgay [Đến Ngày], NguoiDangKy [Người Đăng Ký], LyDo [Lý Do]  from LamThem where (convert(int, substring(TuNgay,1,2))<=@tungay and ";
            }
        }

        private void Grid_Loaded(object sender, RoutedEventArgs e)
        {
            LoadCboDate();
            cboTuThang.Items.Clear();
            cboDenThang.Items.Clear();
            cboTuThang.Items.Add(now.Month);
            cboTuThang.Items.Add(now.Month + 1);
            cboDenThang.Items.Add(now.Month);
            cboDenThang.Items.Add(now.Month + 1);
            int day = now.Day;
            cboTuNgay.SelectedItem = "0" + day.ToString();
            cboDenNgay.SelectedItem = "0" + day.ToString();
            cboTuThang.SelectedItem = now.Month;
            cboDenThang.SelectedItem = now.Month;
        }
        private void cboTuThang_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (cboTuThang.SelectedItem.ToString() == "12")
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
    }
}
