using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;
using WpfApp1.Models;

namespace WpfApp1.ModelVM
{
    class ChitietHoadonView
    {
        public string Mahang { get; set; }
        public string Tenhang { get; set; }
        public string Dvt { get; set; }
        public double? Dongia { get; set; }
        public int? Soluong { get; set; }
        public double? Thanhtien { get; set; }

        public static ChitietHoadonView chuyendoi(Chitiethoadon x)
        {
            hoadonContext db = new hoadonContext();
            if (x == null) return null;
            return new ChitietHoadonView
            {
                Mahang = x.Mahang,
                Tenhang = x.MahangNavigation.Tenhang,
                Dongia = x.Dongia,
                Dvt = x.MahangNavigation.Dvt,
                Soluong = x.Soluong,
                Thanhtien=x.Dongia.Value*x.Soluong.Value
            };
        }
    }
}
