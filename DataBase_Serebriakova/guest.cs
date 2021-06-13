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
    public partial class guest : Form {
        public guest() { 
            InitializeComponent();
        }

        public void Update(MySqlDataAdapter adp){
            BD dbase = new BD();
            dbase.OpenCon();
            DataTable DATA = new DataTable();
            adp.Fill(DATA);
            dataGridView1.DataSource = DATA;
            dbase.CloseCon();
        }
        //запуск кнопки закрытия
        private void button2_Click(object sender, EventArgs e){Application.Exit();}
        //Открытие сайта по слову
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                VisitLink();
            }
            catch (Exception ex){MessageBox.Show("К сожалению не получилось открыть ссылку!.");}
        }
        private void VisitLink()
        {
            System.Diagnostics.Process.Start("https://afisha.yandex.ru/perm/theatre_show/places/teatr-opery-i-baleta-imeni-chaikovskogo?city=perm&source=suggest&schedule-filter-tickets=true#schedule");
        }
        private void guest_Load(object sender, EventArgs e)
        {
            BD dbase = new BD();
            try
            {
                dbase.OpenCon();
                MySqlDataAdapter adap = new MySqlDataAdapter("SELECT `id_основа` AS `id`, `название` AS `Название`, `свободные места` AS `Свободно`, `минимальная_цена` AS `Минимальная`, `максимальная_цена` AS `Максимальная`, `день` AS `Дата`, `Время`, `постановшик` AS `Режиссёр` FROM `основание`", dbase.getCon());
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
        //Кнопка обновления базы данных
        private void button1_Click(object sender, EventArgs e)
        {
            BD dbase = new BD();
            try
            {
                dbase.OpenCon();
                MySqlDataAdapter adap = new MySqlDataAdapter("SELECT `id_основа` AS `id`, `название` AS `Название`, `свободные места` AS `Свободно`, `минимальная_цена` AS `Минимальная`, `максимальная_цена` AS `Максимальная`, `день` AS `Дата`, `Время`, `постановшик` AS `Режиссёр` FROM `основание`", dbase.getCon());
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
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
