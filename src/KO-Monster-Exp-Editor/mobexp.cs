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
    public partial class mobexp : Form
    {
        public string connectionstr { get; set; }

        SqlConnection con = new SqlConnection();


        public mobexp()
        {
            InitializeComponent();
        }

        private void main_FormClosing(object sender, FormClosingEventArgs e)
        {
        }

        private void main_Load(object sender, EventArgs e)
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

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void listBox1_DoubleClick(object sender, EventArgs e)
        {
            listBox2.Items.Clear();

            string itemtext = listBox1.Items[listBox1.SelectedIndex].ToString();
            string mobname = itemtext.Substring(itemtext.IndexOf('-')+1);
            string mobid = itemtext.Substring(0, itemtext.Length - mobname.Length - 1);

            textBox8.Text = mobid;
            textBox9.Text = mobname;

            SqlCommand mobgetir = new SqlCommand("SELECT iExp,iMoney,iHpPoint,sDamage,sAc,sLevel,sSize,iLoyalty,sFireR,sColdR,sLightningR,sMagicR,sDiseaseR,sPoisonR,byAttackRange,bySearchRange,byTracingRange from K_MONSTER Where sSid = " + mobid, con);
            con.Open();
            SqlDataReader dr = mobgetir.ExecuteReader();
            while (dr.Read())
            {
                textBox3.Text = dr[0].ToString();
                textBox6.Text = dr[1].ToString();
                textBox2.Text = dr[2].ToString();
                textBox4.Text = dr[3].ToString();
                textBox5.Text = dr[4].ToString();
                textBox7.Text = dr[5].ToString();
                textBox10.Text = dr[6].ToString();
                textBox11.Text = dr[7].ToString();
                textBox12.Text = dr[8].ToString();
                textBox13.Text = dr[9].ToString();
                textBox14.Text = dr[10].ToString();
                textBox15.Text = dr[11].ToString();
                textBox16.Text = dr[12].ToString();
                textBox17.Text = dr[13].ToString();
                textBox20.Text = dr[14].ToString();
                textBox18.Text = dr[15].ToString();
                textBox19.Text = dr[16].ToString();
            }
            con.Close();

            List<string> zoneids = new List<string>();
            SqlCommand mobzonegetir = new SqlCommand("SELECT ZoneID FROM K_NPCPOS WHERE NpcID = " + mobid, con);
            con.Open();
            dr = mobzonegetir.ExecuteReader();
            while (dr.Read())
            {
                zoneids.Add(dr[0].ToString());
            }
            con.Close();

            foreach (string str in zoneids)
            {
                SqlCommand zoneinfogetir = new SqlCommand("SELECT bz FROM ZONE_INFO WHERE ZoneNo = " + str, con);
                con.Open();
                dr = zoneinfogetir.ExecuteReader();
                while (dr.Read())
                {
                    listBox2.Items.Add(str + " - " + dr[0].ToString());
                }
                con.Close();
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string mobid = textBox8.Text;

            SqlCommand kaydet = new SqlCommand("UPDATE K_MONSTER SET iExp = '" + textBox3.Text + "', iMoney = '" + textBox6.Text + "', iHpPoint = '" +
                textBox2.Text + "', sDamage = '" + textBox4.Text + "', sAc = '" + textBox5.Text + "', sLevel = '" + textBox7.Text + 
                "', sSize = '" + textBox10.Text + "', iLoyalty = '" + textBox11.Text + "', sFireR = '" + textBox12.Text + "', sColdR = '" + textBox13.Text + "', sLightningR = '" +
                textBox14.Text + "', sMagicR = '" + textBox15.Text + "', sDiseaseR = '" + textBox16.Text + "', sPoisonR = '" + textBox17.Text + "', byAttackRange = '" + textBox20.Text +
                "', bySearchRange = '" + textBox18.Text + "', byTracingRange = '" + textBox19.Text +
                "' WHERE sSid = '" + mobid + "'", con);

            try
            {
                con.Open();
                kaydet.ExecuteNonQuery();
                con.Close();
            }
            catch
            {
                MessageBox.Show("Kaydedilirken hata ile karşılaşıldı." + Environment.NewLine + "SQL COMMAND: " + Environment.NewLine + kaydet.CommandText);
                return;
            }
            MessageBox.Show("Kayıt başarılı.");
        }

        private void textBox8_Leave(object sender, EventArgs e)
        {
            listBox2.Items.Clear();
            
            string mobid = textBox8.Text;
            

            SqlCommand mobgetir = new SqlCommand("SELECT iExp,iMoney,iHpPoint,sDamage,sAc,sLevel,sSize,iLoyalty,sFireR,sColdR,sLightningR,sMagicR,sDiseaseR,sPoisonR,byAttackRange,bySearchRange,byTracingRange,strName from K_MONSTER Where sSid = " + mobid, con);
            con.Open();
            SqlDataReader dr = mobgetir.ExecuteReader();
            while (dr.Read())
            {
                textBox3.Text = dr[0].ToString();
                textBox6.Text = dr[1].ToString();
                textBox2.Text = dr[2].ToString();
                textBox4.Text = dr[3].ToString();
                textBox5.Text = dr[4].ToString();
                textBox7.Text = dr[5].ToString();
                textBox10.Text = dr[6].ToString();
                textBox11.Text = dr[7].ToString();
                textBox12.Text = dr[8].ToString();
                textBox13.Text = dr[9].ToString();
                textBox14.Text = dr[10].ToString();
                textBox15.Text = dr[11].ToString();
                textBox16.Text = dr[12].ToString();
                textBox17.Text = dr[13].ToString();
                textBox20.Text = dr[14].ToString();
                textBox18.Text = dr[15].ToString();
                textBox19.Text = dr[16].ToString();
                textBox9.Text = dr[17].ToString();
            }
            con.Close();

            List<string> zoneids = new List<string>();
            SqlCommand mobzonegetir = new SqlCommand("SELECT ZoneID FROM K_NPCPOS WHERE NpcID = " + mobid, con);
            con.Open();
            dr = mobzonegetir.ExecuteReader();
            while (dr.Read())
            {
                zoneids.Add(dr[0].ToString());
            }
            con.Close();

            foreach (string str in zoneids)
            {
                SqlCommand zoneinfogetir = new SqlCommand("SELECT bz FROM ZONE_INFO WHERE ZoneNo = " + str, con);
                con.Open();
                dr = zoneinfogetir.ExecuteReader();
                while (dr.Read())
                {
                    listBox2.Items.Add(str + " - " + dr[0].ToString());
                }
                con.Close();
            }
        }
    }
}
