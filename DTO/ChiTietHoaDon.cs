using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class ChiTietHoaDon
    {
        private string mact;
        private string mahd;
        private string masp;
        private int soluong;

        public string Mact { get => mact; set => mact = value; }
        public string Mahd { get => mahd; set => mahd = value; }
        public string Masp { get => masp; set => masp = value; }
        public int Soluong { get => soluong; set => soluong = value; }
    }
}
