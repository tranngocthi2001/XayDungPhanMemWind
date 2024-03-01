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
    /// Interaction logic for WindowHanghoa.xaml
    /// </summary>
    public partial class WindowHanghoa : Window
    {
        public WindowHanghoa()
        {
            InitializeComponent();
        }

        private void hienthi()
        {
            hoadonContext db=new hoadonContext();
            dgHanghoa.ItemsSource = db.Hanghoas.ToList();
        }
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            hienthi();
        }

        private void lenhThem_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            hoadonContext db = new hoadonContext();
            CHanghoa x = gridHanghoa.DataContext as CHanghoa;
            Hanghoa a = CHanghoa.chuyendoi(x);
            db.Hanghoas.Add(a);
            db.SaveChanges();
            hienthi();

        }

        private void lenhThem_CanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            hoadonContext db = new hoadonContext();
            CHanghoa x = gridHanghoa.DataContext as CHanghoa;
            if (x == null || string.IsNullOrEmpty(x.Mahang))
            {
                e.CanExecute = false; return;
            }
            Double dg;
            if(double.TryParse(x.Dongia,out dg) == false)
            {
                e.CanExecute = false; return;   
            }
            if(db.Hanghoas.Find(x.Mahang)!=null)
            {
                e.CanExecute= false;
                return;
            }
            e.CanExecute = true;
        }

        private void dgHanghoa_SelectedCellsChanged(object sender, SelectedCellsChangedEventArgs e)
        {
            if(dgHanghoa.SelectedValue==null) { return; }
            hoadonContext db = new hoadonContext();
            string maso=dgHanghoa.SelectedValue.ToString();
            Hanghoa x = db.Hanghoas.Find(maso);
            gridHanghoa.DataContext = CHanghoa.chuyendoi(x);
           //hienthi thi du lieu khi chon
        }

        private void lenhXoa_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            CHanghoa x = gridHanghoa.DataContext as CHanghoa;
            hoadonContext db = new hoadonContext();
            Hanghoa a = db.Hanghoas.Find(x.Mahang);
            db.Hanghoas.Remove(a);
            db.SaveChanges();
            hienthi();
        }

        private void lenhXoa_CanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            hoadonContext db = new hoadonContext();
            CHanghoa x = gridHanghoa.DataContext as CHanghoa;
            if (x == null || string.IsNullOrEmpty(x.Mahang))
            {
                e.CanExecute = false; return;
            }

            if (db.Hanghoas.Find(x.Mahang) == null)
            {
                e.CanExecute = false;
                return;
            }
            if (db.Chitiethoadons.Count(t => t.Mahang == x.Mahang) > 0)
            {
                e.CanExecute=false;
                return;
            }
            e.CanExecute = true;
        }

        private void lenhSua_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            CHanghoa x = gridHanghoa.DataContext as CHanghoa;
            Hanghoa a = CHanghoa.chuyendoi(x);
            hoadonContext db = new hoadonContext();
            db.Hanghoas.Update(a);
            db.SaveChanges();

            hienthi();
        }

        private void lenhSua_CanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            hoadonContext db = new hoadonContext();
            CHanghoa x = gridHanghoa.DataContext as CHanghoa;
            if (x == null || string.IsNullOrEmpty(x.Mahang))
            {
                e.CanExecute = false; return;
            }
            Double dg;
            if (double.TryParse(x.Dongia, out dg) == false)
            {
                e.CanExecute = false; return;
            }
            if (db.Hanghoas.Find(x.Mahang) == null)//kt hang hoa co trong cdsl
            {
                e.CanExecute = false;
                return;
            }

            e.CanExecute = true;
        }
    }
}
