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
    public partial class UserControlChi : UserControl
    {
        public static int rdChoose ;
        public UserControlChi()
        {
            InitializeComponent();
        }

        private void rdThuenha_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void UserControlChi_Load(object sender, EventArgs e)
        {
            if (rdThuenha.Checked)
            {

                FrmNhap.tenDM = rdThuenha.Text;
                FrmNhap.rdChoose = 0;
            }
            else if (rdHoctap.Checked)
            {
                FrmNhap.tenDM = rdHoctap.Text;

                FrmNhap.rdChoose = 1;
            }
            else if (rdPhilienlac.Checked)
            {
                FrmNhap.tenDM = rdPhilienlac.Text;
                FrmNhap.rdChoose = 2;
            }
            else if (rdDiennuoc.Checked)

            {
                FrmNhap.tenDM = rdDiennuoc.Text;
                FrmNhap.rdChoose = 3;
            }
            else if (rdMuasam.Checked)
            {
                FrmNhap.tenDM = rdMuasam.Text;
                FrmNhap.rdChoose = 4;
            }
            else if (rdYte.Checked)
            {
                FrmNhap.tenDM = rdYte.Text;

                FrmNhap.rdChoose = 5;
            }
            else if (rdDichuyen.Checked)
            {
                FrmNhap.tenDM = rdDichuyen.Text;

                FrmNhap.rdChoose = 6;
            }
            else if (rdAnuong.Checked)
            {
                FrmNhap.tenDM = rdAnuong.Text;

                FrmNhap.rdChoose = 7;
            }
            else if (rdPhikhac.Checked)
            {
                FrmNhap.tenDM = rdPhikhac.Text;

                FrmNhap.rdChoose = 8;
            }

        }

       
    }
}
