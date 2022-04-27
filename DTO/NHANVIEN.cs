using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    internal class NHANVIEN
    {
        private char manv;
        private char hoten;
        private char phai;
        private char ngsinh;
        private char ngvaolam;
        private char sdt;
        private char email;
        private int luong;
        private char malnv;


        public char Manv { get => manv; set => manv = value; }
        public char Hoten { get => hoten; set => hoten = value; }
        public char Phai { get => phai; set => phai = value; }
        public char Ngsinh { get => ngsinh; set => ngsinh = value; }
        public int Luong { get => luong; set => luong = value; }
    }
}
