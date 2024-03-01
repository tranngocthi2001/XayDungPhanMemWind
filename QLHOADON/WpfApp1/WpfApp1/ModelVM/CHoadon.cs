using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfApp1.Models;

namespace WpfApp1.ModelVM
{
    class CHoadon
    {
        public string Sohd { get; set; }
        public DateTime? Ngaylaphd { get; set; }
        public string Tenkh { get; set; }
        public double Thanhtien { get; set; }
        public static CHoadon chuyendoi(Hoadon x)
        {
            if (x == null) return null;
            hoadonContext db = new hoadonContext();
            double tt = 0;
            tt = db.Chitiethoadons.Where(t => t.Sohd == x.Sohd).Sum(k => k.Dongia.Value * k.Soluong.Value);
            return new CHoadon()
            {
                Sohd = x.Sohd,
                Ngaylaphd = x.Ngaylaphd,
                Tenkh = x.Tenkh,
                Thanhtien = tt
            };
        }
    }
}
