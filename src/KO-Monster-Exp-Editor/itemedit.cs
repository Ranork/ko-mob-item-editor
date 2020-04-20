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
    public partial class itemedit : Form
    {
        public string connectionstr { get; set; }

        SqlConnection con = new SqlConnection();

        public itemedit()
        {
            InitializeComponent();
        }

        private void itemedit_Load(object sender, EventArgs e)
        {
            con.ConnectionString = connectionstr;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void button3_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();

            SqlCommand itemgetir = new SqlCommand("SELECT * FROM ITEM Where strName like '%" + textBox1.Text + "%' ORDER BY Num",con);

            con.Open();
            SqlDataReader dr = itemgetir.ExecuteReader();
            while (dr.Read())
            {
                listBox1.Items.Add(dr["Num"] + "|" + dr["strName"]);
            }
            con.Close();

        }

        private void listBox1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            string listitem = listBox1.Items[listBox1.SelectedIndex].ToString();
            char spchar = '|';
            string itemid = listitem.Split(spchar)[0];
            string itemname = listitem.Split(spchar)[1];

            textBox2.Text = itemid;
            textBox3.Text = itemname;

            SqlCommand select = new SqlCommand("SELECT Num,ItemExt,ItemClass,strName,Kind,Slot,Race,Class,Damage,Delay,Range,Weight,Duration," +
                "BuyPrice, SellPrice, Ac, Countable, Effect1, Effect2, ReqLevel, ReqLevelMax, ReqRank, ReqTitle, ReqStr, ReqSta," +
                "ReqDex, ReqIntel, ReqCha, SellingGroup, ItemType, Hitrate, Evasionrate, DaggerAc, SwordAc, MaceAc, AxeAc," +
                "SpearAc, BowAc, FireDamage, IceDamage, LightningDamage, PoisonDamage, HPDrain, MPDamage, MPDrain, MirrorDamage," +
                "StrB, StaB, DexB, IntelB, ChaB, MaxHpB, MaxMpB, FireR, ColdR, LightningR, MagicR, PoisonR, CurseR," +
                "UpgradeNotice, NPbuyPrice, Bound FROM ITEM WHERE Num = " + itemid, con);

            con.Open();
            SqlDataReader dr = select.ExecuteReader();
            while (dr.Read())
            {
                textBox4.Text = dr["Kind"].ToString();
                textBox5.Text = dr["Slot"].ToString();
                textBox6.Text = dr["Damage"].ToString();
                textBox7.Text = dr["Delay"].ToString();
                textBox8.Text = dr["Range"].ToString();
                textBox9.Text = dr["Weight"].ToString();
                textBox10.Text = dr["Duration"].ToString();
                textBox11.Text = dr["BuyPrice"].ToString();
                textBox12.Text = dr["SellPrice"].ToString();
                textBox13.Text = dr["Countable"].ToString();
                textBox59.Text = dr["NPbuyPrice"].ToString();
                textBox14.Text = dr["Ac"].ToString();
                textBox15.Text = dr["Effect1"].ToString();
                textBox16.Text = dr["Effect2"].ToString();
                textBox17.Text = dr["ReqLevel"].ToString();
                textBox18.Text = dr["ReqLevelMax"].ToString();
                textBox19.Text = dr["ReqRank"].ToString();
                textBox20.Text = dr["ReqTitle"].ToString();
                textBox21.Text = dr["ReqStr"].ToString();
                textBox22.Text = dr["ReqSta"].ToString();
                textBox23.Text = dr["ReqDex"].ToString();
                textBox24.Text = dr["ReqIntel"].ToString();
                textBox25.Text = dr["ReqCha"].ToString();
                textBox26.Text = dr["SellingGroup"].ToString();
                textBox27.Text = dr["ItemType"].ToString();
                textBox28.Text = dr["Hitrate"].ToString();
                textBox29.Text = dr["Evasionrate"].ToString();
                textBox30.Text = dr["DaggerAc"].ToString();
                textBox31.Text = dr["SwordAc"].ToString();
                textBox32.Text = dr["MaceAc"].ToString();
                textBox33.Text = dr["AxeAc"].ToString();
                textBox34.Text = dr["SpearAc"].ToString();
                textBox35.Text = dr["BowAc"].ToString();
                textBox36.Text = dr["FireDamage"].ToString();
                textBox37.Text = dr["IceDamage"].ToString();
                textBox38.Text = dr["LightningDamage"].ToString();
                textBox39.Text = dr["PoisonDamage"].ToString();
                textBox40.Text = dr["HPDrain"].ToString();
                textBox41.Text = dr["MPDamage"].ToString();
                textBox42.Text = dr["MPDrain"].ToString();
                textBox43.Text = dr["MirrorDamage"].ToString();
                textBox44.Text = dr["StrB"].ToString();
                textBox45.Text = dr["StaB"].ToString();
                textBox46.Text = dr["DexB"].ToString();
                textBox47.Text = dr["IntelB"].ToString();
                textBox48.Text = dr["ChaB"].ToString();
                textBox49.Text = dr["MaxHpB"].ToString();
                textBox50.Text = dr["MaxMpB"].ToString();
                textBox51.Text = dr["FireR"].ToString();
                textBox52.Text = dr["ColdR"].ToString();
                textBox53.Text = dr["LightningR"].ToString();
                textBox54.Text = dr["MagicR"].ToString();
                textBox55.Text = dr["PoisonR"].ToString();
                textBox56.Text = dr["CurseR"].ToString();
                textBox57.Text = dr["UpgradeNotice"].ToString();
                textBox58.Text = dr["Bound"].ToString();
            }
            con.Close();

        }

        private void button2_Click(object sender, EventArgs e)
        {

            string listitem = listBox1.Items[listBox1.SelectedIndex].ToString();
            char spchar = '|';
            string itemid = listitem.Split(spchar)[0];
            string itemname = listitem.Split(spchar)[1];

            textBox2.Text = itemid;
            textBox3.Text = itemname;

            SqlCommand select = new SqlCommand("SELECT Num,ItemExt,ItemClass,strName,Kind,Slot,Race,Class,Damage,Delay,Range,Weight,Duration," +
                "BuyPrice, SellPrice, Ac, Countable, Effect1, Effect2, ReqLevel, ReqLevelMax, ReqRank, ReqTitle, ReqStr, ReqSta," +
                "ReqDex, ReqIntel, ReqCha, SellingGroup, ItemType, Hitrate, Evasionrate, DaggerAc, SwordAc, MaceAc, AxeAc," +
                "SpearAc, BowAc, FireDamage, IceDamage, LightningDamage, PoisonDamage, HPDrain, MPDamage, MPDrain, MirrorDamage," +
                "StrB, StaB, DexB, IntelB, ChaB, MaxHpB, MaxMpB, FireR, ColdR, LightningR, MagicR, PoisonR, CurseR," +
                "UpgradeNotice, NPbuyPrice, Bound FROM ITEM WHERE Num = " + itemid, con);

            con.Open();
            SqlDataReader dr = select.ExecuteReader();
            while (dr.Read())
            {
                textBox4.Text = dr["Kind"].ToString();
                textBox5.Text = dr["Slot"].ToString();
                textBox6.Text = dr["Damage"].ToString();
                textBox7.Text = dr["Delay"].ToString();
                textBox8.Text = dr["Range"].ToString();
                textBox9.Text = dr["Weight"].ToString();
                textBox10.Text = dr["Duration"].ToString();
                textBox11.Text = dr["BuyPrice"].ToString();
                textBox12.Text = dr["SellPrice"].ToString();
                textBox13.Text = dr["Countable"].ToString();
                textBox59.Text = dr["NPbuyPrice"].ToString();
                textBox14.Text = dr["Ac"].ToString();
                textBox15.Text = dr["Effect1"].ToString();
                textBox16.Text = dr["Effect2"].ToString();
                textBox17.Text = dr["ReqLevel"].ToString();
                textBox18.Text = dr["ReqLevelMax"].ToString();
                textBox19.Text = dr["ReqRank"].ToString();
                textBox20.Text = dr["ReqTitle"].ToString();
                textBox21.Text = dr["ReqStr"].ToString();
                textBox22.Text = dr["ReqSta"].ToString();
                textBox23.Text = dr["ReqDex"].ToString();
                textBox24.Text = dr["ReqIntel"].ToString();
                textBox25.Text = dr["ReqCha"].ToString();
                textBox26.Text = dr["SellingGroup"].ToString();
                textBox27.Text = dr["ItemType"].ToString();
                textBox28.Text = dr["Hitrate"].ToString();
                textBox29.Text = dr["Evasionrate"].ToString();
                textBox30.Text = dr["DaggerAc"].ToString();
                textBox31.Text = dr["SwordAc"].ToString();
                textBox32.Text = dr["MaceAc"].ToString();
                textBox33.Text = dr["AxeAc"].ToString();
                textBox34.Text = dr["SpearAc"].ToString();
                textBox35.Text = dr["BowAc"].ToString();
                textBox36.Text = dr["FireDamage"].ToString();
                textBox37.Text = dr["IceDamage"].ToString();
                textBox38.Text = dr["LightningDamage"].ToString();
                textBox39.Text = dr["PoisonDamage"].ToString();
                textBox40.Text = dr["HPDrain"].ToString();
                textBox41.Text = dr["MPDamage"].ToString();
                textBox42.Text = dr["MPDrain"].ToString();
                textBox43.Text = dr["MirrorDamage"].ToString();
                textBox44.Text = dr["StrB"].ToString();
                textBox45.Text = dr["StaB"].ToString();
                textBox46.Text = dr["DexB"].ToString();
                textBox47.Text = dr["IntelB"].ToString();
                textBox48.Text = dr["ChaB"].ToString();
                textBox49.Text = dr["MaxHpB"].ToString();
                textBox50.Text = dr["MaxMpB"].ToString();
                textBox51.Text = dr["FireR"].ToString();
                textBox52.Text = dr["ColdR"].ToString();
                textBox53.Text = dr["LightningR"].ToString();
                textBox54.Text = dr["MagicR"].ToString();
                textBox55.Text = dr["PoisonR"].ToString();
                textBox56.Text = dr["CurseR"].ToString();
                textBox57.Text = dr["UpgradeNotice"].ToString();
                textBox58.Text = dr["Bound"].ToString();
            }
            con.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            SqlCommand insert = new SqlCommand(
                "UPDATE dbo.ITEM SET " +
                "Kind = " + textBox4.Text +
                ",Slot = " + textBox5.Text +
                ",Damage = " + textBox6.Text +
                ",Delay = " + textBox7.Text +
                ",Range = " + textBox8.Text +
                ",Weight = " + textBox9.Text +
                ",Duration = " + textBox10.Text +
                ",BuyPrice = " + textBox11.Text +
                ",SellPrice = " + textBox12.Text +
                ",Ac = " + textBox14.Text +
                ",Countable = " + textBox13.Text +
                ",Effect1 = " + textBox15.Text +
                ",Effect2 = " + textBox16.Text +
                ",ReqLevel = " + textBox17.Text +
                ",ReqLevelMax = " + textBox18.Text +
                ",ReqRank = " + textBox19.Text +
                ",ReqTitle = " + textBox20.Text +
                ",ReqStr = " + textBox21.Text +
                ",ReqSta = " + textBox22.Text +
                ",ReqDex = " + textBox23.Text +
                ",ReqIntel = " + textBox24.Text +
                ",ReqCha = " + textBox25.Text +
                ",SellingGroup = " + textBox26.Text +
                ",ItemType = " + textBox27.Text +
                ",Hitrate = " + textBox28.Text +
                ",Evasionrate = " + textBox29.Text +
                ",DaggerAc = " + textBox30.Text +
                ",SwordAc = " + textBox31.Text +
                ",MaceAc = " + textBox32.Text +
                ",AxeAc = " + textBox33.Text +
                ",SpearAc = " + textBox34.Text +
                ",BowAc = " + textBox35.Text +
                ",FireDamage = " + textBox36.Text +
                ",IceDamage = " + textBox37.Text +
                ",LightningDamage = " + textBox38.Text +
                ",PoisonDamage = " + textBox39.Text +
                ",HPDrain = " + textBox40.Text +
                ",MPDamage = " + textBox41.Text +
                ",MPDrain = " + textBox42.Text +
                ",MirrorDamage = " + textBox43.Text +
                ",StrB = " + textBox44.Text +
                ",StaB = " + textBox45.Text +
                ",DexB = " + textBox46.Text +
                ",IntelB = " + textBox47.Text +
                ",ChaB = " + textBox48.Text +
                ",MaxHpB = " + textBox49.Text +
                ",MaxMpB = " + textBox50.Text +
                ",FireR = " + textBox51.Text +
                ",ColdR = " + textBox52.Text +
                ",LightningR = " + textBox53.Text +
                ",MagicR = " + textBox54.Text +
                ",PoisonR = " + textBox55.Text +
                ",CurseR = " + textBox56.Text +
                ",UpgradeNotice = " + textBox57.Text +
                ",NPbuyPrice = " + textBox59.Text +
                ",Bound = " + textBox58.Text +
                " WHERE Num = " + textBox2.Text, con);

            try
            {
                con.Open();
                insert.ExecuteNonQuery();
                con.Close();
            }
            catch (SqlException exc)
            {
                MessageBox.Show(exc.ToString());
                return;
            }

            MessageBox.Show("Kayıt başarılı.");
        }
    }
}
