﻿using System;
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
    public partial class UserControlDays : UserControl
    {
        public UserControlDays()
        {
            InitializeComponent();
        }

        
        public void days(int num)
        {
            lbdays.Text = num.ToString();
        }
        public void txteve(string eve)
        {
            if (eve.Equals("0"))
                lbMoneys.Text = "";
            else
            {
                if (int.Parse(eve) > 0)
                    lbMoneys.Text = "+" + eve;
                else
                    lbMoneys.Text = eve;
            }

        }

    }
}
