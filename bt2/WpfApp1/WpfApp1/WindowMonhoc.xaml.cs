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
using waMonhoc.Models;

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        qlhvContext db = new qlhvContext();
        public MainWindow()
        {
            InitializeComponent();
        }
        public void hienThi()
        {
            qlhvContext db = new qlhvContext();
            dg.ItemsSource = db.Monhocs.ToList();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            hienThi();
        }



        private void btnName_Click(object sender, RoutedEventArgs e)
        {
            MonHoc x = gridMonHoc.DataContext as MonHoc; //lấy data từ UI về gán cho x 
            Monhoc a = CMonHoc.chuyendoi(x);
            if (string.IsNullOrEmpty(x.Msmh) == true)
            {
                MessageBox.Show("Bạn phải nhập mssv");
                return;
            }
            if (db.Monhocs.Find(x.Msmh) != null)
            {
                MessageBox.Show("Mã này đã có");
                return;
            }
            db.Monhocs.Add(a);
            db.SaveChanges();
            hienThi();
        }

        private void btnXoa_Click(object sender, RoutedEventArgs e)
        {
            string maso = dg.SelectedValue.ToString();
            Monhoc x = db.Monhocs.Find(maso);
            if (x != null)
            {
                try
                {
                    db.Monhocs.Remove(x);
                    db.SaveChanges();

                    hienThi();
                }
                catch (Exception)
                {
                    MessageBox.Show("Không thể xóa môn học này");
                }
            }
        }

        private void btnSua_Click(object sender, RoutedEventArgs e)
        {
            //qlhvContext db = new qlhvContext();
            Button btn = sender as Button;
            Grid gr = btn.Parent as Grid;
            CMonHoc x = gr.DataContext as CMonHoc;
            Monhoc a = CMonHoc.chuyendoi(x);
            db.Monhocs.Update(a);
            db.SaveChanges();
            hienThi();

        }

        private void dg_LoadingRowDetails(object sender, DataGridRowDetailsEventArgs e)
        {
            string maso = dg.SelectedValue.ToString();
            Monhoc a = db.Monhocs.Find(maso);
            Grid gr = e.DetailsElement.FindName("gridSuaMonHoc") as Grid;
            gr.DataContext = CMonHoc.chuyendoi(a);
        }
    }
}

