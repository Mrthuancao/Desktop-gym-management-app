using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class HoaDon
    {
        private string mahd;
        private string mahv;
        private DateTime ngaymua;

        public string Mahd { get => mahd; set => mahd = value; }
        public string Mahv { get => mahv; set => mahv = value; }
        public DateTime Ngaymua { get => ngaymua; set => ngaymua = value; }
    }
}
