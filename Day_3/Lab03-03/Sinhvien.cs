using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab03_03
{
    public class Sinhvien
    {

        public Sinhvien(string mssv, string hoten, string khoa, float diemTb)
        {
            this.mssv = mssv;
            this.hoten = hoten;
            this.khoa = khoa;
            this.diemTB = diemTb;
        }

        public string mssv { get; set; }
        public string hoten {  get; set; }
        public string khoa { get; set; }
        public float diemTB { get; set; }
    }
}
