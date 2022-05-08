﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class HOIVIEN
    {
        private string mahv;
        private string hoten;
        private string phai;
        private float cannang;
        private float chieucao;
        private string ngsinh;
        private string ngdangki;
        private string sdt;
        private string nvquanli;

        public string Mahv { get => mahv; set => mahv = value; }
        public string Hoten { get => hoten; set => hoten = value; }
        public string Phai { get => phai; set => phai = value; }
        public string Ngsinh { get => ngsinh; set => ngsinh = value; }
        public string Ngdangki { get => ngdangki; set => ngdangki = value; }
        public string Sdt { get => sdt; set => sdt = value; }
        public string Nvquanli { get => nvquanli; set => nvquanli = value; }
        public float Cannang { get => cannang; set => cannang = value; }
        public float Chieucao { get => chieucao; set => chieucao = value; }

        public HOIVIEN(string mahv, string hoten, string phai, float cannang, float chieucao, string ngsinh, string ngdangki, string sdt, string nvquanli)
        {
            this.Mahv = mahv;
            this.Hoten = hoten;
            this.Phai = phai;
            this.Cannang = cannang;
            this.Chieucao = chieucao;
            this.Ngsinh = ngsinh;
            this.Ngdangki = ngdangki;
            this.Sdt = sdt;
            this.Nvquanli = nvquanli;
        }
        public HOIVIEN(DataRow row)
        {
            this.Mahv = row["mahv"].ToString();
            this.Hoten = row["hoten"].ToString();
            this.Phai = row["phai"].ToString();
            this.Cannang = (float)row["cannang"];
            this.Chieucao = (float)row["chieucao"];
            this.Ngsinh = row["ngsinh"].ToString();
            this.Ngdangki = row["ngdangki"].ToString();
            this.Sdt = row["sdt"].ToString();
            this.Nvquanli = row["nvquanli"].ToString();

        }
    }
}
