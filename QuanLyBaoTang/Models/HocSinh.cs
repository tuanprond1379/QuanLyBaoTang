using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace QuanLyBaoTang.Models
{
    public class MonHoc
    {
        public int Ma_Hoc_Sinh;
        public string Ho_Ten;
        public int Tuoi;
        public string Lop;

        public MonHoc(int ma_Hoc_Sinh, string ho_Ten, int tuoi, string lop)
        {
            Ma_Hoc_Sinh = ma_Hoc_Sinh;
            Ho_Ten = ho_Ten;
            Tuoi = tuoi;
            Lop = lop;
        }

        public MonHoc(){}
    }
}