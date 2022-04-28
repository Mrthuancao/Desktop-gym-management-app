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
        public char Ngvaolam { get => ngvaolam; set => ngvaolam = value; }
        public char Sdt { get => sdt; set => sdt = value; }
        public char Email { get => email; set => email = value; }
        public char Malnv { get => malnv; set => malnv = value; }

        public NHANVIEN(char manv, char hoten, char phai, char ngsinh, int luong, char ngvaolam, char sdt, char email, char malnv)
        {
            this.Manv = manv;
            this.Hoten = hoten;
            this.Phai = phai;
            this.Ngsinh = ngsinh;
            this.Luong = luong;
            this.Ngvaolam = ngvaolam;
            this.Sdt = sdt;
            this.Email = email;
            this.Malnv = malnv;
        }
    }
}
