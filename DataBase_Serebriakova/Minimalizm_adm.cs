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
    public partial class Minimalizm_adm : Form
    {
        public Minimalizm_adm()
        {
            InitializeComponent();
        }
        // Выйти из профиля
        private void button5_Click(object sender, EventArgs e)
        {
            autorization Form = new autorization();
            Form.Show();
            this.Hide();
        }
        // Закрыть приложение
        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        // Список спектаклей
        private void button1_Click(object sender, EventArgs e)
        {
            spectacles Form = new spectacles();
            Form.trash.Text = "admin";
            Form.Show();
        }
        // Изменить актёров
        private void button2_Click(object sender, EventArgs e)
        {
            actors Form = new actors();
            Form.trash.Text = "admin";
            Form.Show();
        }
        // Изменить цены
        private void button6_Click(object sender, EventArgs e)
        {
            Hall Form = new Hall();
            Form.label4.Visible = true;
            Form.Show();
        }
        // Войти как гость
        private void button3_Click(object sender, EventArgs e)
        {
            guest Form = new guest();
            Form.Show();
        }
        // Смена формы
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            main Form = new main();
            this.label1.Text = "Доброго  времени суток, ADMIN!";
            Form.Show();
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            otchet Form = new otchet();
            Form.Show();
        }
    }
}
