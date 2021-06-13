using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataBase_Serebriakova
{
    public partial class otchet : Form
    {
        public otchet(){InitializeComponent();}
        private DataTable zapros(string id)
        {
            BD dbase = new BD();
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            MySqlDataAdapter adap = new MySqlDataAdapter("SELECT `цена` FROM `зал` WHERE `id_зал`= " + id, dbase.getCon());
            adap.Fill(table);
            dbase.CloseCon();
            return table;
        }
        private void otchet_Load(object sender, EventArgs e)
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

        private void button1_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(sum1.Text)){
                if (!String.IsNullOrEmpty(sum2.Text)){
                    if (!String.IsNullOrEmpty(sum3.Text)){
                        if (!String.IsNullOrEmpty(sum4.Text)){
                            if (!String.IsNullOrEmpty(sum5.Text)){
                                try { // получаем выбранный файл
                                    //FileStream fs = new FileStream("Отчёт.txt", FileMode.CreateNew);
                                    //StreamWriter w = new StreamWriter(fs, Encoding.Default);
                                    string b = Convert.ToString(((Convert.ToInt32(parter_orange.Text) * Convert.ToInt32(sum1.Text)) + (Convert.ToInt32(parter_purple.Text) * Convert.ToInt32(sum2.Text)) + (Convert.ToInt32(parter_red.Text) * Convert.ToInt32(sum3.Text)) + (Convert.ToInt32(loja_orange.Text) * Convert.ToInt32(sum4.Text)) + (Convert.ToInt32(loja_red.Text) * Convert.ToInt32(sum5.Text)) + (Convert.ToInt32(pol_red.Text) * Convert.ToInt32(sum6.Text)) + (Convert.ToInt32(pol_red.Text) * Convert.ToInt32(sum7.Text)) + (Convert.ToInt32(amfi_orange.Text) * Convert.ToInt32(sum8.Text)) + (Convert.ToInt32(amfi_red.Text) * Convert.ToInt32(sum9.Text)) + (Convert.ToInt32(bel_blue.Text) * Convert.ToInt32(sum10.Text)) + (Convert.ToInt32(bel_green.Text) * Convert.ToInt32(sum11.Text)) + (Convert.ToInt32(bel_orange.Text) * Convert.ToInt32(sum12.Text)) + (Convert.ToInt32(balkon_blue.Text) * Convert.ToInt32(sum13.Text)) + (Convert.ToInt32(balkon_green.Text) * Convert.ToInt32(sum14.Text))));
                                    string str1 = "Отчёт по премьерному показу спектакля" + textBox4.Text + "!\n От " + DateTime.Now.ToShortDateString() + "\n\nЗа партер в сумме получено: " + parter_orange.Text + " * " + sum1.Text + " + " + parter_purple.Text + " * "  + sum2.Text + " + " + parter_red.Text + " * " + sum3.Text + " = " + ((Convert.ToInt32(parter_orange.Text) * Convert.ToInt32(sum1.Text)) + (Convert.ToInt32(parter_purple.Text) *Convert.ToInt32(sum2.Text)) + (Convert.ToInt32(parter_red.Text) * Convert.ToInt32(sum3.Text))) + "\nЗа ложи в сумме получено: " + loja_orange.Text + " * " + sum4.Text + " + " + loja_red.Text + " * " + sum5.Text + " = " + ((Convert.ToInt32(loja_orange.Text) * Convert.ToInt32(sum4.Text)) + (Convert.ToInt32(loja_red.Text)) * Convert.ToInt32(sum5.Text)) + "\nЗа полукруг в сумме получено: " + pol_orange.Text + " * " + sum6.Text + " + " + pol_red.Text + " * " + sum7.Text + " = " + ((Convert.ToInt32(pol_red.Text) * Convert.ToInt32(sum6.Text)) + (Convert.ToInt32(pol_orange.Text) * Convert.ToInt32(sum7.Text))) + "\nЗа амфитеатр в сумме получено: " + amfi_orange.Text + " * " + sum8.Text + " + " + amfi_red.Text + " * " + sum9.Text + " = " + ((Convert.ToInt32(amfi_orange.Text) * Convert.ToInt32(sum8.Text)) + (Convert.ToInt32(amfi_red.Text) * Convert.ToInt32(sum9.Text))) + "\nЗа Бельэтаж в сумме получено: " + bel_blue.Text + " * " + sum10.Text + " + " + bel_green.Text + " * " + sum11.Text + " + " + bel_orange.Text + " * " + sum12.Text + " = " + ((Convert.ToInt32(bel_green.Text) * Convert.ToInt32(sum10.Text)) + (Convert.ToInt32(bel_orange.Text) * Convert.ToInt32(sum11.Text)) + (Convert.ToInt32(bel_blue.Text) + Convert.ToInt32(sum12.Text))) + "\nЗа партер в сумме получено: " + balkon_blue.Text + " * " + sum13.Text + " + " + balkon_green.Text + " * " + sum14.Text + " = " + ((Convert.ToInt32(balkon_blue.Text) * Convert.ToInt32(sum13.Text)) + (Convert.ToInt32(balkon_green.Text) * Convert.ToInt32(sum14.Text))) + "\n\nВ итоге со всего спектакля полученно: " + ((Convert.ToInt32(parter_orange.Text) * Convert.ToInt32(sum1.Text)) + (Convert.ToInt32(parter_purple.Text) * Convert.ToInt32(sum2.Text)) + (Convert.ToInt32(parter_red.Text) * Convert.ToInt32(sum3.Text)) + (Convert.ToInt32(loja_orange.Text) * Convert.ToInt32(sum4.Text)) + (Convert.ToInt32(loja_red.Text) * Convert.ToInt32(sum5.Text)) + (Convert.ToInt32(pol_red.Text) * Convert.ToInt32(sum6.Text)) + (Convert.ToInt32(pol_red.Text) * Convert.ToInt32(sum7.Text)) + (Convert.ToInt32(amfi_orange.Text) * Convert.ToInt32(sum8.Text)) + (Convert.ToInt32(amfi_red.Text) * Convert.ToInt32(sum9.Text)) + (Convert.ToInt32(bel_blue.Text) * Convert.ToInt32(sum10.Text)) + (Convert.ToInt32(bel_green.Text) * Convert.ToInt32(sum11.Text)) + (Convert.ToInt32(bel_orange.Text) * Convert.ToInt32(sum12.Text)) + (Convert.ToInt32(balkon_blue.Text) * Convert.ToInt32(sum13.Text)) + (Convert.ToInt32(balkon_green.Text) * Convert.ToInt32(sum14.Text))) + "\n\t С учётом вычета НДС получается = " + (((Convert.ToInt32(parter_orange.Text) * Convert.ToInt32(sum1.Text)) + (Convert.ToInt32(parter_purple.Text) * Convert.ToInt32(sum2.Text)) + (Convert.ToInt32(parter_red.Text) * Convert.ToInt32(sum3.Text)) + (Convert.ToInt32(loja_orange.Text) * Convert.ToInt32(sum4.Text)) + (Convert.ToInt32(loja_red.Text) * Convert.ToInt32(sum5.Text)) + (Convert.ToInt32(pol_red.Text) * Convert.ToInt32(sum6.Text)) + (Convert.ToInt32(pol_red.Text) * Convert.ToInt32(sum7.Text)) + (Convert.ToInt32(amfi_orange.Text) * Convert.ToInt32(sum8.Text)) + (Convert.ToInt32(amfi_red.Text) * Convert.ToInt32(sum9.Text)) + (Convert.ToInt32(bel_blue.Text) * Convert.ToInt32(sum10.Text)) + (Convert.ToInt32(bel_green.Text) * Convert.ToInt32(sum11.Text)) + (Convert.ToInt32(bel_orange.Text) * Convert.ToInt32(sum12.Text)) + (Convert.ToInt32(balkon_blue.Text) * Convert.ToInt32(sum13.Text)) + (Convert.ToInt32(balkon_green.Text) * Convert.ToInt32(sum14.Text))) * 0.87);
                                    if (!String.IsNullOrEmpty(textBox1.Text)) { str1 += "\n\nЗа вычетом первого поля дополнительных расходов получается = " + (Convert.ToInt32(b) - Convert.ToInt32(textBox1.Text)); b = Convert.ToString(Convert.ToInt32(b) - Convert.ToInt32(textBox1.Text)); }
                                    if (!String.IsNullOrEmpty(textBox2.Text)) { str1 +=   "\nЗа вычетом второго поля дополнительных расходов получается = " + (Convert.ToInt32(b) - Convert.ToInt32(textBox2.Text)); b = Convert.ToString(Convert.ToInt32(b) - Convert.ToInt32(textBox2.Text)); }
                                    if (!String.IsNullOrEmpty(textBox3.Text)) { str1 +=  "\nЗа вычетом третьего поля дополнительных расходов получается = " + (Convert.ToInt32(b) - Convert.ToInt32(textBox3.Text)); b = Convert.ToString(Convert.ToInt32(b) - Convert.ToInt32(textBox3.Text)); }
                                    b = ("\n\nВ итоге за спектакль \"" + textBox4.Text + "\" было получено " + Convert.ToInt32(b) + " бумажек (рублей).");
                                    if (otch3t.ShowDialog() == DialogResult.Cancel) return;
                                    string name = otch3t.FileName;
                                    System.IO.File.WriteAllText(name, str1);
                                    MessageBox.Show(b);
                                } catch (Exception ex) { MessageBox.Show(ex.Message); } 
                            }else MessageBox.Show("не заполненое поле! в  Ложа Оранжевый");
                        }else MessageBox.Show("не заполненое поле! в  Ложа Красный");
                    }else MessageBox.Show("не заполненое поле! в  Партер Фиолетовый");
                }else MessageBox.Show("не заполненое поле! в  Партер Красный");
            }else MessageBox.Show("не заполненое поле! в  Партер Оранжевый");
            
        }
    }
}
