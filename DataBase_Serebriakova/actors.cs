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
    public partial class actors : Form
    {
        public actors()
        {
            InitializeComponent();
        }

        public void Update(MySqlDataAdapter adp)
        {
            BD bd = new BD();
            bd.OpenCon();
            DataTable DATA = new DataTable();
            adp.Fill(DATA);
            dataGridView1.DataSource = DATA;
            bd.CloseCon();
        }

        private void actors_Load(object sender, EventArgs e)
        {
            if (trash.Text == "admin") { button3.Visible = button6.Visible = button7.Visible = true; }

            BD bd = new BD();
            try{
                bd.OpenCon();
                
                MySqlDataAdapter adap = new MySqlDataAdapter("SELECT `id_актёра` AS `ID`, `фио` AS `Ф.И.О.`, `ранг` AS `Роль`, `опыт` AS `Стаж` FROM `актёры`", bd.getCon());
                Update(adap);
                bd.CloseCon();
            }catch (Exception ex){MessageBox.Show(ex.Message);Application.Exit();
            }finally{
                bd.CloseCon();
            }
        }
        // Назад
        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        // Закрыть
        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        // Обновить список
        private void button1_Click(object sender, EventArgs e)
        {
            BD bd = new BD();
            try
            {
                bd.OpenCon();
                MySqlDataAdapter adap = new MySqlDataAdapter("SELECT `фио` AS `Ф.И.О.`, `ранг` AS `Роль`, `опыт` AS `Стаж` FROM `актёры`", bd.getCon());
                Update(adap);
                bd.CloseCon();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Application.Exit();
            }
            finally
            {
                bd.CloseCon();
            }
        }
        // Закрыть список
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Добавить
        private void button3_Click(object sender, EventArgs e){
            temp Form = new temp();
            Form.doing.Text = "добавить а";
            Form.Show();
        }
        // Удалить
        private void button7_Click(object sender, EventArgs e){
            temp Form = new temp();
            Form.doing.Text = "удалить а";
            Form.Show();
        }
        // Изменить
        private void button6_Click(object sender, EventArgs e){
            temp Form = new temp();
            Form.doing.Text = "изменить а";
            Form.Show();
        }
    }
}
