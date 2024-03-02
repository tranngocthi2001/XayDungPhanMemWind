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
using WpfApp1.Models;
using WpfApp1.ModelVM;

namespace WpfApp1.UI
{
    /// <summary>
    /// Interaction logic for WindowHoadon.xaml
    /// </summary>
    public partial class WindowHoadon : Window
    {
        private Hoadon hd;
        public WindowHoadon()
        {
            InitializeComponent();
        }

        private void hienthi()
        {
            hoadonContext db=new hoadonContext();
            dgHoadon.ItemsSource=db.Hoadons.Select(t=>CHoadon.chuyendoi(t)).ToList();

        }
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            hd=new Hoadon();
            hoadonContext db = new hoadonContext();
            cmbMahang.ItemsSource = db.Hanghoas.ToList();
            hienthi();
        }

        private void dgHoadon_LoadingRowDetails(object sender, DataGridRowDetailsEventArgs e)
        {
            hoadonContext db= new hoadonContext();

            string sohd = dgHoadon.SelectedValue.ToString();
            Hoadon x = db.Hoadons.Find(sohd);
            //DataGrid dg = e.DetailsElement.FindName("dgCHTH") as DataGrid;
            x.Chitiethoadons=db.Chitiethoadons.Where(t=>t.Sohd==sohd).ToList();
            foreach(Chitiethoadon ct in x.Chitiethoadons)
            {
                ct.MahangNavigation=db.Hanghoas.Find(ct.Mahang);
            }
            DataGrid dg = e.DetailsElement.FindName("dgCTHD") as DataGrid;
            hienthiCTHD(dg, x);
        }

        //private void dgCTHD_Loaded(object sender, RoutedEventArgs e)
        //{
         
        //}
        public void hienthiCTHD(DataGrid dg,Hoadon x)
        {
            dg.ItemsSource= x.Chitiethoadons.Select(t=>ChitietHoadonView.chuyendoi(t)).ToList();
        }

        private void lenhChon_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            ChitiethoadonVM x = gridCTHD.DataContext as ChitiethoadonVM;
            Chitiethoadon ct = hd.Chitiethoadons.FirstOrDefault(t => t.Mahang == x.Mahang);
                if(ct==null)
            {
                hoadonContext db = new hoadonContext();
                ct = new Chitiethoadon();
                ct.Mahang = x.Mahang;
                ct.MahangNavigation = db.Hanghoas.Find(ct.Mahang);
                ct.Dongia = ct.MahangNavigation.Dongia;
                ct.Soluong = int.Parse(x.Soluong);
                hd.Chitiethoadons.Add(ct);
            }
            else
            {
                ct.Soluong += int.Parse(x.Soluong);
            }
            hienthiCTHD(dgCTHD, hd);
        }

        private void lenhChon_CanExecute(object sender, CanExecuteRoutedEventArgs e)
        {

        }
    }
}
