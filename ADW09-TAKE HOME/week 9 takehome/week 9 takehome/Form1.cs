using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ADW09_TAKE_HOME;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace week_9_takehome
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
          
        }


        private void playerDataToolStripMenuItem_Click(object sender, EventArgs e)
        {

            Form2 form2 = new Form2();
            form2.Dock = DockStyle.Fill;
            form2.TopLevel = false;
            form2.ControlBox = false;
            form2.FormBorderStyle = FormBorderStyle.None;
            this.panel1.Controls.Clear();
            this.panel1.Controls.Add(form2);
            form2.Show();
        }

        private void showMatchDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.Dock = DockStyle.Fill;
            form3.TopLevel = false;
            form3.ControlBox = false;
            form3.FormBorderStyle = FormBorderStyle.None;
            this.panel1.Controls.Clear();
            this.panel1.Controls.Add(form3);
            form3.Show();

        }
    }
}
