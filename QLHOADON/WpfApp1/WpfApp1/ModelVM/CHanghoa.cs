using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfApp1.Models;

namespace WpfApp1.ModelVM
{
    class CHanghoa
    {
        public string Mahang { get; set; }
        public string Tenhang { get; set; }
        public string Dvt { get; set; }
        public string Dongia { get; set; }
        public static Hanghoa chuyendoi(CHanghoa x)
        {
            if (x == null) return null;
            return new Hanghoa
            {
                Mahang = x.Mahang,
                Tenhang = x.Tenhang,
                Dvt = x.Dvt,
                Dongia = double.Parse(x.Dongia)
            };
        }
        public static CHanghoa chuyendoi(Hanghoa x)
        {
            if (x == null) return null;
            return new CHanghoa
            {
                Mahang = x.Mahang,
                Tenhang = x.Tenhang,
                Dvt = x.Dvt,
                Dongia = x.Dongia.ToString()
            };
        }

    }
    
}
