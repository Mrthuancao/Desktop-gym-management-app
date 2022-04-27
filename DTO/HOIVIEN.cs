using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    internal class HOIVIEN
    {
        private char mahv;
        private char hoten;
        private char phai;
        private char ngsinh;
        private char ngdangki;
        private char sdt;
        private char nvquanli;

        public char Mahv { get => mahv; set => mahv = value; }
        public char Hoten { get => hoten; set => hoten = value; }
        public char Phai { get => phai; set => phai = value; }
        public char Ngsinh { get => ngsinh; set => ngsinh = value; }
        public char Ngdangki { get => ngdangki; set => ngdangki = value; }
        public char Sdt { get => sdt; set => sdt = value; }
        public char Nvquanli { get => nvquanli; set => nvquanli = value; }

        public HOIVIEN(char mahv, char hoten, char phai, char ngsinh, char ngdangki, char sdt, char nvquanli)
        {
            this.Mahv = mahv;
            this.Hoten = hoten;
            this.Phai = phai;
            this.Ngsinh = ngsinh;
            this.Ngdangki = ngdangki;
            this.Sdt = sdt;
            this.Nvquanli = nvquanli;
        }
    }
}
