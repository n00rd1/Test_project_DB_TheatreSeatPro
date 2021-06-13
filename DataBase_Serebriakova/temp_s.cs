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
    public partial class temp_s : Form
    {
        public temp_s()
        {
            InitializeComponent();
        }
        // Удалить
        private void buttondelete_Click(object sender, EventArgs e)
        {
            BD dbase = new BD();
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            MySqlDataAdapter adap = new MySqlDataAdapter("DELETE FROM `спектакли` WHERE `спектакли`.`id_выступления` = " + textBox1.Text, dbase.getCon());
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

                MySqlCommand update = new MySqlCommand("UPDATE `спектакли` SET `" + listizmen.Text + "` = '" + textizmen.Text + "' WHERE `спектакли`.`id_выступления` = " + textBox1.Text + ";", dbase.getCon());
                update.ExecuteNonQuery();
                MessageBox.Show("Успешно!");
                this.Close();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }
        // Добавить
        private void buttonadd_Click(object sender, EventArgs e)
        {
            try
            {
                BD dbase = new BD();
                dbase.OpenCon();

                MySqlCommand update = new MySqlCommand("INSERT INTO `спектакли` (`id_выступления`, `название`, `свободные места`, `минимальная цена`, `максимальная цена`, `день`, `время`, `продолжительность`, `постановшик`, `описание`, `актёры`, `id_залl`, `id_основание`) VALUES('" + textadd1.Text + "','" + textadd2.Text + "','" + textadd3.Text + "','" + textadd4.Text + "','" + textadd5.Text + "','" + textadd6.Text + "','" + textadd7.Text + "','" + textadd8.Text + "','" + textadd9.Text + "','" + textadd10.Text + "','" + textadd11.Text + "', '1', '0');", dbase.getCon());
                MessageBox.Show(update.CommandText.ToString());
                update.ExecuteNonQuery();
                MessageBox.Show("Успешно!");
                this.Close();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void spektakl(string doing)
        {
            if (doing == "изменить а")
            {
                this.Text = "Редактирование";
                label2.Visible = label1.Visible = textBox1.Visible = replace2.Visible = textizmen.Visible = listizmen.Visible = izmen.Visible = true;
                button6.Visible = true;
                return;
            }
            if (doing == "удалить а")
            {
                this.Text = "Удаление";
                label1.Visible = textBox1.Visible = true;
                buttondelete.Visible = true;
                return;
            }
            if (doing == "добавить а")
            {
                this.Text = "Добавление";
                label3.Visible = label4.Visible = label5.Visible = true;
                add1.Visible = add2.Visible = add3.Visible = add4.Visible = add5.Visible = add6.Visible = add7.Visible = add8.Visible = add9.Visible = add10.Visible = add11.Visible = true;
                textadd1.Visible = textadd2.Visible = textadd3.Visible = textadd4.Visible = textadd5.Visible = textadd6.Visible = textadd7.Visible = textadd8.Visible = textadd9.Visible = textadd10.Visible = textadd11.Visible = true;
                buttonadd.Visible = true;
                return;
            }
        }
        private void temp_s_Load(object sender, EventArgs e)
        {
            if (doing.Text == "изменить а") { spektakl(doing.Text); return; }
            if (doing.Text == "удалить а") { spektakl(doing.Text); return; }
            if (doing.Text == "добавить а") { spektakl(doing.Text); return; }
        }
    }
}
