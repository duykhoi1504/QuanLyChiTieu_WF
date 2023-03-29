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
       
        private float tongChi=0;
        private float tongThu=0;
        private float tongThuCHi;
      
        public FrmNhap()
        {
            InitializeComponent();
        }

        private void btChi_Click(object sender, EventArgs e)
        {
            lbnhaptien.Text ="Tiền chi:";
            btThu.BackColor = Color.White;
            containerDanhmuc.Controls.Clear();
            UserControlChi ucChi = new UserControlChi();
            containerDanhmuc.Controls.Add(ucChi);

            btChi.BackColor = Color.Orange;
        }

        private void btThu_Click(object sender, EventArgs e)
        {
            lbnhaptien.Text = "Tiền thu:";
            
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
      

        private void txtAccept_Click(object sender, EventArgs e)
        {
            

            if (txtSotien.Text == "") return;
            ListViewItem item = new ListViewItem(FrmMain.tenDM);
            
            if ( FrmMain.isThu== true)
            {
                int tienThu = int.Parse(txtSotien.Text);
                item.SubItems.Add(tienThu.ToString());
                tongThu += tienThu;
            }
            else
            {
                int tienChi = int.Parse(txtSotien.Text) * -1;
                item.SubItems.Add(tienChi.ToString());
                tongChi +=tienChi;

            }
            item.SubItems.Add(dtNgaythuchi.Value.ToString());
            item.SubItems.Add(txtGhichu.Text);
            item.ImageIndex = FrmMain.rdChoose;
            listThuchi.Items.Add(item);
            //total
            lbChitieu.Text = tongChi.ToString();
            lbThunhap.Text = tongThu.ToString();
            lbThuchi.Text = (tongChi+tongThu).ToString();

            //luuu du lieu bang constructor
            //SoChiTieu a = new SoChiTieu(FrmMain.tenDM, txtSotien.Text, dtNgaythuchi.Value.ToString(), txtGhichu.Text);
            //QuanLySoChiTieu ql = new QuanLySoChiTieu(a);


        }

        private void txtSotien_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }
    }
}
