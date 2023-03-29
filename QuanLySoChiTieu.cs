using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyChiTieu
{
    class QuanLySoChiTieu
    {
        List<SoChiTieu> ds = new List<SoChiTieu>();
        public QuanLySoChiTieu(SoChiTieu s)
        {
            ds.Add(s);
        }
        public void them(SoChiTieu s)
        {
            ds.Add(s);
        }
       
    }
}
