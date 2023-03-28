using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyChiTieu
{
    public partial class UserControlMenu : UserControl
    {
        List<object> objectPool = new List<object>();
        public UserControlMenu()
        {
            InitializeComponent();
        }

        private void btNhap_Click(object sender, EventArgs e)
        {
            FrmMain M = new FrmMain();
           
            M.ShowDialog();
        }

        private void btLich_Click(object sender, EventArgs e)
        {
           
            FrmLich L = new FrmLich();
            

            L.ShowDialog();
        }

        private void btBaocao_Click(object sender, EventArgs e)
        {
            FrmBaoCao B = new FrmBaoCao();
            B.ShowDialog();
        }
    }
}
