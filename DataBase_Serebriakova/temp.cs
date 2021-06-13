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
    public partial class temp : Form
    {
        public temp()
        {
            InitializeComponent();
        }

        private void acter(string doing){
            if (doing == "изменить а") {
                this.Text = "Редактирование";
                label2.Visible = label1.Visible = textBox1.Visible = replace2.Visible = textizmen.Visible = listizmen.Visible = izmen.Visible = true;
                button6.Visible = true;
                return;
            }
            if (doing == "удалить а") {
                this.Text = "Удаление";
                label1.Visible = textBox1.Visible = true;
                buttondelete.Visible = true;
                return;
            }
            if (doing == "добавить а") {
                this.Text = "Добавление";
                add2.Visible = add3.Visible = add4.Visible = add5.Visible = true;
                textadd2.Visible = textadd3.Visible = textadd4.Visible = textadd5.Visible = true;
                buttonadd.Visible = true;
                return;
            }
        }

        private void temp_Load(object sender, EventArgs e){
            if (doing.Text == "изменить а") { acter(doing.Text); return; }
            if (doing.Text == "удалить а") { acter(doing.Text); return; }
            if (doing.Text == "добавить а") { acter(doing.Text); return; }
        }

        private void update(string msg, int id){
            try{
                BD dbase = new BD();
                dbase.OpenCon();

                MySqlCommand update = new MySqlCommand("UPDATE `зал` SET `цена` = '" + msg + "' WHERE `зал`.`id_зал` = " + id + ";", dbase.getCon());
                update.ExecuteNonQuery();
            }catch (Exception ex){MessageBox.Show(ex.Message);}
        }

        // Удалить
        private void buttondelete_Click(object sender, EventArgs e)
        {
            BD dbase = new BD();
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            MySqlDataAdapter adap = new MySqlDataAdapter("DELETE FROM `актёры` WHERE `актёры`.`id_актёра` = " + textBox1.Text, dbase.getCon());
            adap.Fill(table);
            dbase.CloseCon();
            MessageBox.Show("Успешно!");
            this.Close();
        }
        // Изменить
        private void button6_Click(object sender, EventArgs e)
        {
            try
            {
                BD dbase = new BD();
                dbase.OpenCon();

                MySqlCommand update = new MySqlCommand("UPDATE `актёры` SET `" + listizmen.Text + "` = '" + textizmen.Text + "' WHERE `актёры`.`id_актёра` = " + textBox1.Text + ";", dbase.getCon());
                update.ExecuteNonQuery();
                MessageBox.Show("Успешно!");
                this.Close();
            }
            catch (Exception ex){MessageBox.Show(ex.Message);}
        }
        // Добавить
        private void buttonadd_Click(object sender, EventArgs e)
        {
            try
            {
                BD dbase = new BD();
                dbase.OpenCon();

                MySqlCommand update = new MySqlCommand("INSERT INTO `актёры` (`номер`, `фио`, `ранг`, `опыт`) VALUES(" + textadd2.Text + "," + textadd3.Text.ToString() + "," + textadd4.Text + "," + textadd5.Text + ");", dbase.getCon());
                MessageBox.Show(update.CommandText.ToString());
                update.ExecuteNonQuery();
                MessageBox.Show("Успешно!");
                this.Close();
            }
            catch (Exception ex){MessageBox.Show(ex.Message);}
        }
    }
}
