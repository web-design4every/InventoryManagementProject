using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SE1421_Project
{
    public partial class Loading : Form
    {
        public Loading()
        {
            InitializeComponent();
            timer1.Start();
        }
        int startpoint = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            startpoint += 5;
            progressLoading.Value = startpoint;
            if (progressLoading.Value==100)
            {
                progressLoading.Value = 0;
                timer1.Stop();
                DangNhap dn = new DangNhap();
                dn.Show();
                this.Hide();
            }
        }
    }
}
