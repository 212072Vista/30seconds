using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _30SecondsGame
{
    public partial class Start : Form
    {
        int flag = -1;
        public Start()
        {
            InitializeComponent();

            string cs = @"URI=file:C:/Users/bram/source/repos/Challenge12/Challenge12/challenge12database.db";


            var con = new SQLiteConnection(cs);
            con.Open();

            using (var cmd = new SQLiteCommand("SELECT * FROM vraag", con))
            {
                var vraag = cmd.ExecuteReader();

                while (vraag.Read())
                {
                    var antwoord = vraag.GetString(1);
                }

            }

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            panel1.Controls.Clear();
            startrulesform srf = new startrulesform();
            srf.TopLevel = false;
            panel1.Controls.Add(srf);
            srf.Show();
            
          
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void Start_Load(object sender, EventArgs e)
        {
        

             
                
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            flag *= -1;
            if (flag == 1)
                panel1.Hide();
            else
                panel1.Show();

            panel1.Controls.Clear();
            startpanelNEW spn = new startpanelNEW();
            spn.TopLevel = false;
            panel1.Controls.Add(spn);
            spn.Show();
        }
    }
}
