using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace QuanLyBaoTang.Models
{
    public class MonHoc1
    {
        public int So_Thu_Tu;
        public string Ten_Mon_Hoc;
        public string Tin_Chi;

        public MonHoc1(int so_thu_tu, string ten_mon_hoc, string tin_chi)
        {
            this.So_Thu_Tu = so_thu_tu;
            this.Ten_Mon_Hoc = ten_mon_hoc;
            this.Tin_Chi  = tin_chi;
        }

        public MonHoc1() { }
    }
}