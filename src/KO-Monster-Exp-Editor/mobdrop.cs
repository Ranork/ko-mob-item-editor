using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KO_Monster_Exp_Editor
{
    public partial class mobdrop : Form
    {
        public string connectionstr { get; set; }

        SqlConnection con = new SqlConnection();

        public mobdrop()
        {
            InitializeComponent();
        }

        private void mobdrop_Load(object sender, EventArgs e)
        {
            con.ConnectionString = connectionstr;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            listBox1.Items.Clear();

            SqlCommand yaratikbul = new SqlCommand("SELECT * from K_MONSTER Where strName like '%" + textBox1.Text + "%'", con);
            con.Open();
            SqlDataReader dr = yaratikbul.ExecuteReader();
            while (dr.Read())
            {
                listBox1.Items.Add(dr[0].ToString() + "-" + dr[1].ToString());
            }
            con.Close();
        }
    }
}
