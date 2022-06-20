using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _30SecondsGame
{
    public partial class startpanelNEW : Form
    {
        int flag = -1;
        public startpanelNEW()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            flag *= -1;
            if (flag == 1)
                panel1.Hide();
            else
                panel1.Show();

            panel1.Controls.Clear();
            startrulesform srf = new startrulesform();
            srf.TopLevel = false;
            panel1.Controls.Add(srf);
            srf.Show();
        }
    }
}
