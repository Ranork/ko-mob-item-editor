using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KO_Monster_Exp_Editor
{
    public partial class main : Form
    {
        public main()
        {
            InitializeComponent();
        }

        public string connectionstr { get; set; }

        private void main_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            mobexp mexp = new mobexp();
            mexp.connectionstr = connectionstr;
            mexp.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {

            mobexp mexp = new mobexp();
            mexp.connectionstr = connectionstr;
            mexp.Show();
        }

        private void main_FormClosing(object sender, FormClosingEventArgs e)
        {

            Application.Exit();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            itemedit ie = new itemedit();
            ie.connectionstr = connectionstr;
            ie.Show();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            itemedit ie = new itemedit();
            ie.connectionstr = connectionstr;
            ie.Show();
        }
    }
}
