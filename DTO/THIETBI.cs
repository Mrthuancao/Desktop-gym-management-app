using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    internal class THIETBI
    {
        private char tenthietbi;
        private char matb;
        private char ngmua;
        private char ngsd;
        private char hanbaotri;
        private int gia;
        private char mahang;
        private char maltb;
        private int soluong;

        public char Tenthietbi { get => tenthietbi; set => tenthietbi = value; }
        public char Matb { get => matb; set => matb = value; }
        public char Ngmua { get => ngmua; set => ngmua = value; }
        public char Ngsd { get => ngsd; set => ngsd = value; }
        public char Hanbaotri { get => hanbaotri; set => hanbaotri = value; }
        public int Gia { get => gia; set => gia = value; }
        public char Mahang { get => mahang; set => mahang = value; }
        public char Maltb { get => maltb; set => maltb = value; }
        public int Soluong { get => soluong; set => soluong = value; }
    }
}
