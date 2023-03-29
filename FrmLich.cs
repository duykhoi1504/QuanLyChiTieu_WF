using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;
namespace QuanLyChiTieu
{
    public partial class FrmLich : Form
    {
        int month, year;
       
        public FrmLich()
        {
            InitializeComponent();
        }
        //public FrmLich(ListViewItem s)
        //{
        //    listThuChi.Items.Add(s);
        //    InitializeComponent();
        //}

        private void FrmBaoCao_Load(object sender, EventArgs e)
        {
            lbThu.Text = FrmMain.tongThu.ToString();
            lbChi.Text = FrmMain.tongChi.ToString();
            lbTong.Text = (FrmMain.tongThu+FrmMain.tongChi).ToString();

            foreach (ListViewItem item in FrmMain.toLich)
                listThuChi.Items.Add(item);
            displayDays();
            //

        }
        private void displayDays()
        {
            DateTime now = DateTime.Now;
            month = now.Month;
            year = now.Year;

            string monthname = DateTimeFormatInfo.CurrentInfo.GetMonthName(month);
            LBDATE.Text = monthname + " " + year;

            // lay ngay dau tien cua thang
            DateTime startofthemonth = new DateTime(year, month, 1);
            // lay so ngay cua thang
            int days = DateTime.DaysInMonth(year, month);
            //doi  startofthemonth sang interger
            int dayoftheweak = Convert.ToInt32(startofthemonth.DayOfWeek.ToString("d"))+1;
            // tao blank usercontroll
            for( int i = 1; i < dayoftheweak; i++)
            {
                UserControlBlank ucblank = new UserControlBlank();
                daycontainer.Controls.Add(ucblank);
            }
            //tao usercontroll cho days
            for(int i = 1; i <= days; i++)
            {
                UserControlDays ucdays = new UserControlDays();
                ucdays.days(i);
                daycontainer.Controls.Add(ucdays);
            }
        }

        private void btprevious_Click(object sender, EventArgs e)
        {
            //xóa container
            daycontainer.Controls.Clear();
            //giảm tháng lên thành tháng trước đó
            month--;
            string monthname = DateTimeFormatInfo.CurrentInfo.GetMonthName(month);
            LBDATE.Text = monthname + " " + year;
            DateTime startofthemonth = new DateTime(year, month, 1);
            // lay so ngay cua thang
            int days = DateTime.DaysInMonth(year, month);
            //doi  startofthemonth sang interger
            int dayoftheweak = Convert.ToInt32(startofthemonth.DayOfWeek.ToString("d")) + 1;
            // tao blank usercontroll
            for (int i = 1; i < dayoftheweak; i++)
            {
                UserControlBlank ucblank = new UserControlBlank();
                daycontainer.Controls.Add(ucblank);
            }
            //tao usercontroll for days
            for (int i = 1; i <= days; i++)
            {
                UserControlDays ucdays = new UserControlDays();
                ucdays.days(i);
                daycontainer.Controls.Add(ucdays);
            }
        }

        private void btnext_Click(object sender, EventArgs e)
        {
            //xóa container
            daycontainer.Controls.Clear();
            //tăng tháng lên thành tháng tiếp theo
            month++;
            string monthname = DateTimeFormatInfo.CurrentInfo.GetMonthName(month);
            LBDATE.Text = monthname + " " + year;
            DateTime startofthemonth = new DateTime(year, month, 1);
            // lay so ngay cua thang
            int days = DateTime.DaysInMonth(year, month);
            //doi  startofthemonth sang interger
            int dayoftheweak = Convert.ToInt32(startofthemonth.DayOfWeek.ToString("d")) + 1;
            // tao blank usercontroll
            for (int i = 1; i < dayoftheweak; i++)
            {
                UserControlBlank ucblank = new UserControlBlank();
                daycontainer.Controls.Add(ucblank);
            }
            //tao usercontroll for days
            for (int i = 1; i <= days; i++)
            {
                UserControlDays ucdays = new UserControlDays();
                ucdays.days(i);
                daycontainer.Controls.Add(ucdays);
            }
        }
        private void btXoa_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item in listThuChi.SelectedItems)
            {
                listThuChi.Items.Remove(item);
                FrmMain.toLich.Remove(item);
            }
        }

        private void btClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
