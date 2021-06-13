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
    public partial class spectacles : Form
    {
        public spectacles()
        {
            InitializeComponent();
        }

        public void Update(MySqlDataAdapter adp)
        {
            BD dbase = new BD();
            dbase.OpenCon();
            DataTable DATA = new DataTable();
            adp.Fill(DATA);
            dataGridView1.DataSource = DATA;
            dbase.CloseCon();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e){}
        // Закрыть
        private void button8_Click(object sender, EventArgs e){ Application.Exit();  }
        // Выйти из профиля
        private void button5_Click(object sender, EventArgs e){ this.Close();}
        // Закрыть приложение
        private void button2_Click(object sender, EventArgs e){ Application.Exit(); }
        // Обновить
        private void button1_Click(object sender, EventArgs e)
        {
            BD dbase = new BD();
            try
            {
                dbase.OpenCon();
                MySqlDataAdapter adap = new MySqlDataAdapter("SELECT `id_выступления` AS `Номер выступления`, `название` AS `Название выступления`, `свободные места` AS `свободно`, `минимальная цена`, `максимальная цена`, `день`, `время`, `продолжительность`, `постановшик` AS `Постановщик`, `описание`, `актёры` FROM `спектакли`;", dbase.getCon());
                Update(adap);
                dbase.CloseCon();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Application.Exit();
            }
            finally
            {
                dbase.CloseCon();
            }
        }
        // Открыть схему
        private void button4_Click(object sender, EventArgs e)
        {
            Hall form = new Hall();
            this.Hide();
            form.Show();

        }
        // Автозагрузка БД
        private void spectacles_Load(object sender, EventArgs e)
        {
            if (trash.Text == "admin") { button3.Visible = button6.Visible = button7.Visible = true; }

            BD dbase = new BD();
            try
            {
                dbase.OpenCon();
                MySqlDataAdapter adap = new MySqlDataAdapter("SELECT `id_выступления` AS `Номер выступления`, `название` AS `Название выступления`, `свободные места` AS `свободно`, `минимальная цена`, `максимальная цена`, `день`, `время`, `продолжительность`, `постановшик` AS `Постановщик`, `описание`, `актёры` FROM `спектакли`;", dbase.getCon());
                Update(adap);
                dbase.CloseCon();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Application.Exit();
            }
            finally
            {
                dbase.CloseCon();
            }
        }
        // Добавить
        private void button3_Click(object sender, EventArgs e)
        {
            temp_s Form = new temp_s();
            Form.doing.Text = "добавить а";
            Form.Show();
        }
        // Изменить
        private void button6_Click(object sender, EventArgs e)
        {
            temp_s Form = new temp_s();
            Form.doing.Text = "изменить а";
            Form.Show();
        }
        // Удалить
        private void button7_Click(object sender, EventArgs e)
        {
            temp_s Form = new temp_s();
            Form.doing.Text = "удалить а";
            Form.Show();
        }
    }
}
