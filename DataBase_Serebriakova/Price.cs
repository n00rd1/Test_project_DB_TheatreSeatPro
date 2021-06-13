using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataBase_Serebriakova
{
    public partial class Price : Form
    {
        public Price(){InitializeComponent();}

        private void apdater() {
            BD bd = new BD();
            parter_purple.Text = zapros("1").Rows[0][0].ToString();
            parter_red.Text = zapros("2").Rows[0][0].ToString();
            parter_orange.Text = zapros("3").Rows[0][0].ToString();
            loja_red.Text = zapros("4").Rows[0][0].ToString();
            loja_orange.Text = zapros("5").Rows[0][0].ToString();
            pol_red.Text = zapros("6").Rows[0][0].ToString();
            pol_orange.Text = zapros("7").Rows[0][0].ToString();
            amfi_red.Text = zapros("8").Rows[0][0].ToString();
            amfi_orange.Text = zapros("9").Rows[0][0].ToString();
            bel_orange.Text = zapros("10").Rows[0][0].ToString();
            bel_green.Text = zapros("11").Rows[0][0].ToString();
            bel_blue.Text = zapros("12").Rows[0][0].ToString();
            balkon_green.Text = zapros("13").Rows[0][0].ToString();
            balkon_blue.Text = zapros("14").Rows[0][0].ToString();
        }

        private DataTable zapros(string id){
            BD bd = new BD();
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            MySqlDataAdapter adap = new MySqlDataAdapter("SELECT `цена` FROM `зал` WHERE `id_зал`= " + id, bd.getCon());
            adap.Fill(table);
            bd.CloseCon();
            return table;
        }

        private void Price_Load(object sender, EventArgs e){apdater();}

        private void update(string msg, int id)
        {
            try
            {
                BD bd = new BD();
                bd.OpenCon();
 
                    MySqlCommand update = new MySqlCommand("UPDATE `зал` SET `цена` = '" + msg + "' WHERE `зал`.`id_зал` = "+ id + ";", bd.getCon());
                    update.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(textBox1.Text)) { update(textBox1.Text, 1); }
            if (!String.IsNullOrEmpty(textBox2.Text)) { update(textBox2.Text, 2); }
            if (!String.IsNullOrEmpty(textBox3.Text)) { update(textBox3.Text, 3); }
            if (!String.IsNullOrEmpty(textBox4.Text)) { update(textBox4.Text, 4); }
            if (!String.IsNullOrEmpty(textBox5.Text)) { update(textBox5.Text, 5); }
            if (!String.IsNullOrEmpty(textBox6.Text)) { update(textBox6.Text, 8); }
            if (!String.IsNullOrEmpty(textBox7.Text)) { update(textBox7.Text, 9); }
            if (!String.IsNullOrEmpty(textBox8.Text)) { update(textBox8.Text, 6); }
            if (!String.IsNullOrEmpty(textBox9.Text)) { update(textBox9.Text, 7); }
            if (!String.IsNullOrEmpty(textBox10.Text)) { update(textBox10.Text, 10); }
            if (!String.IsNullOrEmpty(textBox11.Text)) { update(textBox11.Text, 11); }
            if (!String.IsNullOrEmpty(textBox12.Text)) { update(textBox12.Text, 12); }
            if (!String.IsNullOrEmpty(textBox13.Text)) { update(textBox13.Text, 13); }
            if (!String.IsNullOrEmpty(textBox14.Text)) { update(textBox14.Text, 14); }

            textBox1.Text = textBox2.Text = textBox3.Text = textBox4.Text = textBox5.Text = textBox6.Text = textBox7.Text = textBox8.Text = textBox9.Text = textBox10.Text = textBox11.Text = textBox12.Text = textBox13.Text = textBox14.Text = null;
            MessageBox.Show("Изменение успешно!");
            apdater();
        }
    }
}
