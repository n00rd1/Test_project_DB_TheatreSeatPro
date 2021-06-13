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
    public partial class Hall : Form
    {
        public Hall()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private DataTable zapros(string id) {
            BD dbase = new BD();
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            MySqlDataAdapter adap = new MySqlDataAdapter("SELECT `цена` FROM `зал` WHERE `id_зал`= " + id, dbase.getCon());
            adap.Fill(table);
            dbase.CloseCon();
            return table;
        }

        private void Hall_Load(object sender, EventArgs e)
        {
            BD dbase = new BD();
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
        //Как это выглядит
        private void label3_Click(object sender, EventArgs e){pictureBox1.Image = DataBase_Serebriakova.Properties.Resources.Untitled;checkBox1.Checked = false;checkBox2.Checked = false;}
        //Пандемия
        private void checkBox1_CheckedChanged(object sender, EventArgs e){pictureBox1.Image = DataBase_Serebriakova.Properties.Resources.пандемия; checkBox2.Checked = false; }
        //Полный зал
        private void checkBox2_CheckedChanged(object sender, EventArgs e){pictureBox1.Image = DataBase_Serebriakova.Properties.Resources.Полный_зал; checkBox1.Checked = false; }
        //Закрыть форму
        private void button5_Click(object sender, EventArgs e){this.Hide();}
        //Изменение цен
        private void label4_Click(object sender, EventArgs e){Price Form = new Price();Form.Show();}
    }
}
