using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace KO_Monster_Exp_Editor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string ip = "";
        string uid = "";
        string upass = "";
        string db = "";

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                ip = textBox1.Text;
                uid = textBox2.Text;
                upass = textBox3.Text;
                db = textBox4.Text;

                SqlConnection con = new SqlConnection("Server=" + ip + ";Database=" + db + ";User Id=" + uid + ";Password=" + upass);

                try
                {
                    con.Open();
                    con.Close();
                }
                catch
                {
                    MessageBox.Show("Database'e bağlanamadı");
                    return;
                }

                main frm = new main();
                frm.connectionstr = "Server=" + ip + ";Database=" + db + ";User Id=" + uid + ";Password=" + upass;
                frm.Show();
                this.Hide();
            }
            else if (radioButton2.Checked)
            {
                db = textBox6.Text;

                SqlConnection con = new SqlConnection("Server=127.0.0.1;Trusted_Connection=True;Database=" + db);

                try
                {
                    con.Open();
                    con.Close();
                }
                catch
                {
                    MessageBox.Show("Database'e bağlanamadı");
                    return;
                }

                main frm = new main();
                frm.connectionstr = "Server=127.0.0.1;Trusted_Connection=True;Database=" + db;
                frm.Show();
                this.Hide();

            }

            

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
