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
    
    public partial class FrmMain : Form
    {
        public static string DangNhap = "";
    

        public FrmMain()
        {
            FrmLogin f = new FrmLogin();
            f.ShowDialog();
            InitializeComponent();
        }
        private void FrmMain_Load(object sender, EventArgs e)
        {
            UserControlMenu ucMenu = new UserControlMenu();
            containerMenu.Controls.Add(ucMenu);
            
            

        }
        
        private void btChi_Click(object sender, EventArgs e)
        {

            btThu.BackColor = Color.White;
            containerDanhmuc.Controls.Clear();
            UserControlChi ucChi = new UserControlChi();
            containerDanhmuc.Controls.Add(ucChi);
           
            btChi.BackColor = Color.Orange;
            
        }

        private void btThu_Click(object sender, EventArgs e)
        {
            btChi.BackColor = Color.White;
          

            containerDanhmuc.Controls.Clear();
            UserControlThu ucThu = new UserControlThu();
            containerDanhmuc.Controls.Add(ucThu);
            btThu.BackColor = Color.Orange;
        }

        
    }
}
