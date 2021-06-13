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
    public partial class main : Form
    {
        
        public main() { InitializeComponent();  }
        // Изменить список актёров
        private void button2_Click(object sender, EventArgs e){
            actors Form = new actors();
            Form.trash.Text = root.Text;
            Form.Show();
        }
        // Войти как гость
        private void button3_Click(object sender, EventArgs e){
            guest Form = new guest();
            Form.Show();
        }
        // Спектакли
        private void button1_Click(object sender, EventArgs e){
            spectacles Form = new spectacles();
            Form.Show();
        }
        // Закрыть приложение
        private void button4_Click(object sender, EventArgs e) { Application.Exit(); }
        // Выход из профиля
        private void button5_Click(object sender, EventArgs e){
            autorization Form = new autorization();
            Form.Show();
            this.Hide();
        }
        private void main_Load(object sender, EventArgs e){
            if (root.Text == "user" || root.Text == "guest"){
                button1.Text = "Список спектаклей";
                button2.Text = "Список актёров";
                button3.Text = "Войти в зал";
                return;
            }else if (root.Text == "admin") { return; }
        }
    }
}
