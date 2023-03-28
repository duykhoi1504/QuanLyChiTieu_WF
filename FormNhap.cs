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
    public partial class FrmNhap : Form
    {
        public static int rdChoose ;
        public static string tenDM;
        public FrmNhap()
        {
            InitializeComponent();
        }

        private void btChi_Click(object sender, EventArgs e)
        {
            txtNhaptien.Text ="Tiền chi:";
            btThu.BackColor = Color.White;
            containerDanhmuc.Controls.Clear();
            UserControlChi ucChi = new UserControlChi();
            containerDanhmuc.Controls.Add(ucChi);

            btChi.BackColor = Color.Orange;
        }

        private void btThu_Click(object sender, EventArgs e)
        {
            txtNhaptien.Text = "Tiền thu:";
            
            btChi.BackColor = Color.White;
            containerDanhmuc.Controls.Clear();
            UserControlThu ucThu = new UserControlThu();
            containerDanhmuc.Controls.Add(ucThu);
            btThu.BackColor = Color.Orange;
        }

        private void FormNhap_Load(object sender, EventArgs e)
        {
            btThu.BackColor = Color.White;
            UserControlChi ucChi = new UserControlChi();
            containerDanhmuc.Controls.Add(ucChi);
            btChi.BackColor = Color.Orange;
        }
        //hàm chỉ cho phep nhap so vao txtNhaptien
        private void txtTienthu_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtAccept_Click(object sender, EventArgs e)
        {
            if (txtNhaptienthuchi.Text == "") return;
            ListViewItem item = new ListViewItem(tenDM);
            item.SubItems.Add(txtNhaptien.Text);

            item.SubItems.Add(dtNgaythuchi.Value.ToString());
            item.SubItems.Add(txtGhichu.Text);
            item.ImageIndex = rdChoose;
            listThuchi.Items.Add(item);

        }
    }
}
